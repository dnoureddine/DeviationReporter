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
    public partial class ChangePassword : Form
    {
        private DeviationModel deviationModel;
        public ChangePassword()
        {
            InitializeComponent();

            this.deviationModel = new DeviationModel();

        }

        private void Changepwd_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            bool changePwdStatus = deviationModel.updatePassword(this.oldPassword.Text, this.newPassword.Text);
            if (changePwdStatus)
            {
                MessageBox.Show(languageModel.getString("passwordChanged"));

                this.Close();
            }else
            {
                MessageBox.Show(languageModel.getString("passwordChangeFailed"));
            }
        }
    }
}
