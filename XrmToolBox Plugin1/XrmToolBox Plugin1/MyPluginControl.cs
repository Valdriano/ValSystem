using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace XrmToolBox_Plugin1
{
    public partial class MyPluginControl : PluginControlBase
    {

        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load( object sender, EventArgs e )
        {
            // Loads or creates the settings for the plugin
            if ( !SettingsManager.Instance.TryLoad( GetType(), out mySettings ) )
            {
                mySettings = new Settings();

                LogWarning( "Settings not found => created" );
            }
            else
            {
                LogInfo( "Settings found and loaded" );
            }
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool( object sender, EventArgs e )
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save( GetType(), mySettings );
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_ConnectionUpdated( object sender, ConnectionUpdatedEventArgs e )
        {
            mySettings.LastUsedOrganizationWebappUrl = e.ConnectionDetail.WebApplicationUrl;
            LogInfo( "Connection has changed to: {0}", e.ConnectionDetail.WebApplicationUrl );
        }
    }
}
