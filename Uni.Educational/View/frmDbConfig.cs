using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Uni.Educational.IoC.Attribute;
using Uni.Educational.IoC.Services;
using System.Configuration;
using Uni.Educational.Configuration;
using System.Data.SqlClient;

namespace Uni.Educational.View
{
    [RegisterView("System", "DbConfig", true)]
    public partial class frmDbConfig : DevExpress.XtraEditors.XtraForm, IViewBase
    {
        private const int SSPI = 0;
        private const int SQL_CREDENTIALS = 1;

        private const string EFConnectionStringRemote = @"Data Source=@Server;User ID=@User;Password=@Password;MultipleActiveResultSets=True";

        public frmDbConfig()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Arguments
        {
            get;
            set;
        }

        public IoC.ApplicationContext ApplicationContext
        {
            get;
            set;
        }

        public void Initialize(IoC.ApplicationContext context, Dictionary<string, object> arguments)
        {
            Arguments = arguments;
            ApplicationContext = context;
            LoadConfig();
        }

        private void bntConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var configuration = configurationSetBindingSource.DataSource as ConfigurationSet;
                var connStr = String.Format(EFConnectionStringRemote, configuration.Server, configuration.User, configuration.Password);
                var connection = new SqlConnection(connStr);
                connection.Open();
                XtraMessageBox.Show("Connected and saved the configuration");
            }
            catch (SqlException sqlEx)
            {
                XtraMessageBox.Show("Connect failed", sqlEx.Message);
            }
        }

        private void SaveConfig()
        {
            var configuration = configurationSetBindingSource.DataSource as ConfigurationSet;

            if (cbAuthentication.SelectedIndex == 0)
            {
                ConfigurationManager.AppSettings["Authentication"] = "0";
            }
            else
            {
                ConfigurationManager.AppSettings["Authentication"] = "1";
                var connStr = String.Format(EFConnectionStringRemote, configuration.Server, configuration.User, configuration.Password);
                ConfigurationManager.AppSettings["EFConnectionStringRemote"] = connStr;

            }
        }

        private void LoadConfig()
        {
            try
            {
                var auth = int.Parse(ConfigurationManager.AppSettings["Authentication"]);
                if (auth == SSPI)
                {
                    cbAuthentication.SelectedIndex = 1;
                    teUser.Properties.ReadOnly = true;
                    tePassword.Properties.ReadOnly = true;
                }
                else if (auth == SQL_CREDENTIALS)
                {
                    cbAuthentication.SelectedIndex = 0;
                    var configuration = new ConfigurationSet();
                    var tokens = ConfigurationManager.AppSettings["EFConnectionStringRemote"].Split(';');
                    configuration.Server = tokens[0].Split('=').Last().Trim();
                    configuration.User = tokens[1].Split('=').Last().Trim();
                    configuration.Password = tokens[2].Split('=').Last().Trim();
                    configurationSetBindingSource.DataSource = configuration;
                }
            }
            catch
            {
                XtraMessageBox.Show("Failed to retreive configuration.");
            }
        }

        private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthentication.SelectedIndex == 1)
            {
                var configuration = configurationSetBindingSource.DataSource as ConfigurationSet;
                configuration.Password = String.Empty;
                configuration.User = String.Empty;
                configurationSetBindingSource.ResetBindings(true);

                teUser.Properties.ReadOnly = true;
                tePassword.Properties.ReadOnly = true;
            }
            else if (cbAuthentication.SelectedIndex == 0)
            {
                teUser.Properties.ReadOnly = false;
                tePassword.Properties.ReadOnly = false;
            }
        }
    }
}