using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValSystem.Model;
using ValSystem.Util;
using ValSystem.View;

namespace ValSystem.Controller
{
    public class MenuController
    {
        public Task<TreeNode[]> CarregarMenuTreeNode( int IdUsuario, int IdPerfil )
        {
            TreeNode[] treeNode;
            TreeNode tnModuloItem;
            TreeNode tnRotina;

            try
            {
                return Task.Run( () =>
                {
                    using ( AppDbContext app = new AppDbContext( "valsystemDb" ) )
                    {
                        treeNode = new TreeNode[ app.Set<Modulo>().Count() ];

                        int iModulos = 0;

                        foreach ( Modulo modulo in app.Set<Modulo>().OrderBy( o => o.IdModulo ) )
                        {
                            iModulos++;

                            treeNode[ iModulos - 1 ] = new TreeNode( modulo.IdModulo + " - " + modulo.Descricao.TrimEnd(), 0, 0 );
                            treeNode[ iModulos - 1 ].Tag = modulo;

                            foreach ( ModuloItem moduloItem in app.Set<ModuloItem>().Where( w => w.IdModulo == modulo.IdModulo ).OrderBy( o => o.IdModuloItem ) )
                            {
                                tnModuloItem = treeNode[ iModulos - 1 ].Nodes.Add( moduloItem.IdModulo.ToString(), moduloItem.IdModuloItem + " - " + moduloItem.Descricao.TrimEnd(), 1, 1 );
                                tnModuloItem.Tag = moduloItem;

                                foreach ( Rotina rotina in app.Set<Rotina>().Where( w => w.IdModulo == modulo.IdModulo && w.IdModuloItem == moduloItem.IdModuloItem ).OrderBy( o => o.IdRotina ) )
                                {
                                    tnRotina = tnModuloItem.Nodes.Add( moduloItem.IdModuloItem.ToString(), rotina.IdRotina + " - " + rotina.Descricao.TrimEnd(), 2, 2 );
                                    tnRotina.Tag = rotina;
                                }
                            }
                        }
                    }
                    return treeNode;
                }
                );
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
                //
            }
        }

        public Task<Dictionary<string, int>> CriarMenu()
        {
            try
            {
                return Task.Run( () =>
                 {
                     Dictionary<string, int> dicionario = new Dictionary<string, int>();

                     var asmList = AppUtil.CarregarAssembly( AppUtil.DiretorioExecutacao );

                     Assembly assembly;
                     FileInfo fileInfo;

                     int iModulo = 0;
                     int iModuloItem = 0;
                     int iRotina = 0;

                     foreach ( string asm in asmList )
                     {
                         fileInfo = new FileInfo( asm );

                         if ( fileInfo.Name.Contains( "Interfaces.View" ) )
                         {
                             assembly = Assembly.LoadFrom( AppUtil.DiretorioExecutacao + @"\" + fileInfo.Name );

                             var classes = AppUtil.ListaClasses( assembly );

                             foreach ( string classe in classes.Where( w => ( w.Contains( "Interfaces.View" ) && ( w.Contains( "ViewerForm" ) || w.Contains( "ToolForm" ) ) ) ) )
                             {
                                 object obj = assembly.CreateInstance( classe );

                                 string _IdModulo, _Modulo, _IdModuloItem, _ModuloItem, _IdRotina, _Rotina;
                                 List<string> _IdRotinaItem;
                                 bool novoModulo, novoModuloItem, novaRotina;

                                 novoModulo = novoModuloItem = novaRotina = false;

                                 if ( obj.GetType().BaseType.Name == "DataViewerForm" )
                                 {
                                     DataViewerForm frm = obj as DataViewerForm;

                                     _IdModulo = frm.Janela_IDModulo;
                                     _Modulo = frm.Janela_Modulo;
                                     _IdModuloItem = frm.Janela_IDModuloItem;
                                     _ModuloItem = frm.Janela_ModuloItem;
                                     _IdRotina = frm.Janela_IDRotina;
                                     _Rotina = frm.Janela_Rotina;
                                     _IdRotinaItem = frm.Janela_RotinaItem;

                                     SalvaMenu( Convert.ToInt32( _IdModulo ), _Modulo, Convert.ToInt32( _IdModuloItem ), _ModuloItem, Convert.ToInt32( _IdRotina ), _Rotina, _IdRotinaItem, classe, fileInfo.Name, ref novoModulo, ref novoModuloItem, ref novaRotina );

                                 }
                                 else if ( obj.GetType().BaseType.Name == "ToolForm" )
                                 {
                                     ToolForm frm = obj as ToolForm;

                                     _IdModulo = frm.Janela_IDModulo;
                                     _Modulo = frm.Janela_Modulo;
                                     _IdModuloItem = frm.Janela_IDModuloItem;
                                     _ModuloItem = frm.Janela_ModuloItem;
                                     _IdRotina = frm.Janela_IDRotina;
                                     _Rotina = frm.Janela_Rotina;
                                     _IdRotinaItem = frm.Janela_RotinaItem;

                                     SalvaMenu( Convert.ToInt32( _IdModulo ), _Modulo, Convert.ToInt32( _IdModuloItem ), _ModuloItem, Convert.ToInt32( _IdRotina ), _Rotina, _IdRotinaItem, classe, fileInfo.Name, ref novoModulo, ref novoModuloItem, ref novaRotina );
                                 }


                                 if ( novoModulo )
                                     dicionario.Add( "Modulos", ++iModulo );
                                 if ( novoModuloItem )
                                     dicionario.Add( "Modulo Item", ++iModuloItem );
                                 if ( novaRotina )
                                     dicionario.Add( "Rotinas", ++iRotina );
                             }
                         }
                     }

                     return dicionario;
                 }
                 );
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
            finally
            {
            }
        }

        private static void SalvaMenu( int IdModulo, string Modulo, int IdModuloItem, string ModuloItem, int IdRotina, string Rotina, List<string> IdRotinaItem, string NameSpace, string NameAssembly, ref bool novoModulo, ref bool novoModuloItem, ref bool novaRotina )
        {
            try
            {
                novoModulo = novoModuloItem = novaRotina = false;

                using ( AppDbContext app = new AppDbContext( "valsystemDb" ) )
                {
                    if ( app.Set<Modulo>().Where( w => w.IdModulo == IdModulo ).Count() == 0 )
                    {
                        app.Set<Modulo>().Add( new Modulo { IdModulo = IdModulo, Descricao = Modulo } );
                        novoModulo = true;
                    }

                    if ( app.Set<ModuloItem>().Where( w => w.IdModuloItem == IdModuloItem && w.IdModulo == IdModulo ).Count() == 0 )
                    {
                        app.Set<ModuloItem>().Add( new ModuloItem { IdModulo = IdModulo, IdModuloItem = IdModuloItem, Descricao = ModuloItem } );
                        novoModuloItem = true;
                    }

                    if ( app.Set<Rotina>().Where( w => w.IdRotina == IdRotina && w.IdModulo == IdModulo && w.IdModuloItem == IdModuloItem ).Count() == 0 )
                    {
                        app.Set<Rotina>().Add( new Rotina { IdRotina = IdRotina, Descricao = Rotina, IdModulo = IdModulo, IdModuloItem = IdModuloItem, NameSpace = NameSpace, NameAssembly = NameAssembly } );
                        novaRotina = true;
                    }

                    foreach ( string item in IdRotinaItem )
                    {
                        int id = Convert.ToInt32( IdRotina );
                        int idItem = Convert.ToInt32( item.Substring( 0, item.IndexOf( "-" ) ).Trim() );
                        string descricao = Convert.ToString( item.Substring( item.IndexOf( "-" ) + 1 ).Trim() );

                        if ( app.Set<RotinaItem>().Where( w => w.Item == idItem && w.IdRotina == id ).Count() == 0 )
                        {
                            app.Set<RotinaItem>().Add( new RotinaItem { IdRotina = id, Descricao = descricao, Item = idItem } );
                        }
                    }

                    app.SaveChanges();
                }
            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }

        public void CarregarRotina( TreeView treeView, AppForm frmApp )
        {
            try
            {
                if ( treeView.SelectedNode != null && treeView.SelectedNode.Tag != null )
                {
                    Rotina rotina = treeView.SelectedNode.Tag as Rotina;

                    if ( rotina != null )
                    {
                        if ( !AppUtil.Vazio( rotina.NameAssembly ) )
                        {
                            if ( !File.Exists( AppUtil.DiretorioExecutacao + @"\" + rotina.NameAssembly.Trim() ) )
                            {
                                new Exception( "Assembly " + rotina.NameAssembly + "Não localizado." );
                            }

                            Assembly assembly;

                            assembly = Assembly.LoadFrom( AppUtil.DiretorioExecutacao + @"\" + rotina.NameAssembly.Trim() );

                            if ( assembly == null )
                            {
                                new Exception( "Não foi possivel carregar à Rotina." );
                            }

                            object obj = assembly.CreateInstance( rotina.NameSpace.TrimEnd() );

                            if ( obj == null )
                            {
                                new Exception( "Não foi possivel criar à Rotina." );
                            }

                            if ( obj.GetType().BaseType.Name == "DataViewerForm" )
                            {
                                DataViewerForm DataViewer = obj as DataViewerForm;

                                DataViewer.AppForm = frmApp;
                                DataViewer.Show();
                            }
                            else if ( obj.GetType().BaseType.Name == "ToolForm" )
                            {
                                ToolForm toolForm = obj as ToolForm;

                                toolForm.AppForm = frmApp;
                                toolForm.Show();
                            }
                        }
                    }
                }

            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }
    }
}
