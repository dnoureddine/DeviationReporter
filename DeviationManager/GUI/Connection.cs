using DeviationManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviationManager.GUI
{
    public partial class Connection : Form
    {
        private DeviationModel  deviationModel;
        public Connection()
        {
            InitializeComponent();

            this.deviationModel = new DeviationModel();
        }

        private void passwordchange_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            bool connectionStatus = deviationModel.verifyPassword(this.passwort.Text);
            if (connectionStatus)
            {
                ApprovementGroupGUI appGroup = new ApprovementGroupGUI();
                appGroup.Show();

                this.Close();

            }else
            {
                MessageBox.Show(languageModel.getString("passwordWrong"));
            }
        }
    }
}
