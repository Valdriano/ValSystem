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
                    using ( AppController app = new AppController() )
                    {
                        treeNode = new TreeNode[ app.Modulos.Count() + 1 ];

                        treeNode[ 0 ] = new TreeNode( "1 - Configurações do Sistema", 0, 0 );
                        tnModuloItem = treeNode[ 0 ].Nodes.Add( "10", "10 - Menu", 1, 1 );
                        tnModuloItem.Tag = treeNode;
                        tnRotina = tnModuloItem.Nodes.Add( "10", "100 - Carregar Menu", 2, 2 );
                        tnRotina.Tag = tnRotina;

                        int iModulos = 1;

                        foreach ( Modulo modulo in app.Modulos.OrderBy( o => o.IdModulo ) )
                        {
                            iModulos++;

                            treeNode[ iModulos - 1 ] = new TreeNode( modulo.IdModulo + " - " + modulo.Descricao.TrimEnd(), 0, 0 );
                            treeNode[ iModulos - 1 ].Tag = modulo;

                            foreach ( ModuloItem moduloItem in app.ModulosItens.Where( w => w.IdModulo == modulo.IdModulo ).OrderBy( o => o.IdModuloItem ) )
                            {
                                tnModuloItem = treeNode[ iModulos - 1 ].Nodes.Add( moduloItem.IdModulo.ToString(), moduloItem.IdModuloItem + " - " + moduloItem.Descricao.TrimEnd(), 1, 1 );
                                tnModuloItem.Tag = moduloItem;

                                foreach ( Rotina rotina in app.Rotinas.Where( w => w.IdModulo == modulo.IdModulo && w.IdModuloItem == moduloItem.IdModuloItem ).OrderBy( o => o.IdRotina ) )
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

                     foreach ( string asm in asmList )
                     {
                         fileInfo = new FileInfo( asm );

                         if ( fileInfo.Name.Contains( "Interfaces.View" ) )
                         {
                             assembly = Assembly.LoadFrom( AppUtil.DiretorioExecutacao + @"\" + fileInfo.Name );

                             var classes = AppUtil.ListaClasses( assembly );

                             foreach ( string classe in classes.Where( w => ( w.Contains( "Interfaces.View" ) && ( w.Contains( "ViewerForm" ) ) ) ) )
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

                                     SalvaMenu( _IdModulo, _Modulo, _IdModuloItem, _ModuloItem, _IdRotina, _Rotina, _IdRotinaItem, classe, fileInfo.Name, ref novoModulo, ref novoModuloItem, ref novaRotina );
                                 }

                                 if ( novoModulo )
                                     dicionario.Add( "Modulos", 1 );
                                 if ( novoModuloItem )
                                     dicionario.Add( "Modulo Item", 1 );
                                 if ( novaRotina )
                                     dicionario.Add( "Rotinas", 1 );
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

        private static void SalvaMenu( string IdModulo, string Modulo, string IdModuloItem, string ModuloItem, string IdRotina, string Rotina, List<string> IdRotinaItem, string NameSpace, string NameAssembly, ref bool novoModulo, ref bool novoModuloItem, ref bool novaRotina )
        {
            try
            {
                novoModulo = novoModuloItem = novaRotina = false;

                using ( AppController app = new AppController() )
                {
                    if ( app.Modulos.Where( w => w.IdModulo == Convert.ToInt16( IdModulo ) ).Count() == 0 )
                    {
                        app.Modulos.Add( new Modulo { IdModulo = Convert.ToInt16( IdModulo), Descricao = Modulo } );
                        novoModulo = true;
                    }

                    if ( app.ModulosItens.Where( w => w.IdModuloItem == Convert.ToInt32( IdModuloItem ) && w.IdModulo == Convert.ToInt32( IdModulo ) ).Count() == 0 )
                    {
                        app.ModulosItens.Add( new ModuloItem { IdModulo = Convert.ToInt32( IdModulo ), IdModuloItem = Convert.ToInt32( IdModuloItem ), Descricao = ModuloItem } );
                        novoModuloItem = true;
                    }

                    if ( app.Rotinas.Where( w => w.IdRotina == Convert.ToInt32( IdRotina ) && w.IdModulo == Convert.ToInt32( IdModulo ) && w.IdModuloItem == Convert.ToInt32( IdModuloItem ) ).Count() == 0 )
                    {
                        app.Rotinas.Add( new Rotina { IdRotina = Convert.ToInt32( IdRotina ), Descricao = Rotina, IdModulo = Convert.ToInt32( IdModulo ), IdModuloItem = Convert.ToInt32( IdModuloItem ), NameSpace = NameSpace, NameAssembly = NameAssembly } );
                        novaRotina = true;
                    }

                    foreach ( string item in IdRotinaItem )
                    {
                        if ( app.RotinasItens.Where( w => w.IdRotinaItem == Convert.ToInt32( item.Substring( 0, item.IndexOf( "-" ) ).Trim() ) && w.IdRotina == Convert.ToInt32( IdRotina ) ).Count() == 0 )
                        {
                            app.RotinasItens.Add( new RotinaItem { IdRotina = Convert.ToInt32( IdRotina ), Descricao = item, IdRotinaItem = Convert.ToInt32( item.Substring( 0, item.IndexOf( "-" ) ).Trim() ) } );
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

        public Form CarregarRotina( TreeView treeView )
        {
            try
            {

                Form oForm = null;

                if ( treeView.SelectedNode != null && treeView.SelectedNode.Tag != null )
                {
                    if ( treeView.SelectedNode.Text == "100 - Carregar Menu" )
                        this.CriarMenu();

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
                                oForm = obj as DataViewerForm;
                            }
                            else
                            {
                                //oForm = null;
                            }
                        }
                    }
                }

                return oForm;

            }
            catch ( Exception ex )
            {

                throw new Exception( ex.Message );
            }
        }
    }
}
