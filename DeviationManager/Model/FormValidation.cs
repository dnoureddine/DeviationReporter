using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DeviationManager.Model
{
    class FormValidation
    {
        /******* validate the deviation form '=> true-->input valid ## flase--->input not valid */
        public bool isTextBoxNotNull(TextBox textBox, ErrorProvider errorProvider)
        {
            LanguageModel languageModel = new LanguageModel();
            if (textBox.Text == "")
            {
                
                errorProvider.SetError(textBox, languageModel.getString("alertTextboxEmpty"));
                return false;
            }
            else
            {
                return true;
            }
        }

        /******* validate the deviation form '=> true-->input valid ## flase--->input not valid */
        public bool isTexNotNull(TextBox textBox, ErrorProvider errorProvider)
        {
            LanguageModel languageModel = new LanguageModel();
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, languageModel.getString("alertTextboxEmpty"));
                return false;
            }
            else
            {
                return true;
            }
        }

        /******* validate the deviation form '=> true-->Combobox Item selected ## flase--->input not valid */
        public bool isItemFromComoBoxSelected(ComboBox comboBox, ErrorProvider errorProvider)
        {
            LanguageModel languageModel = new LanguageModel();
            if (comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, languageModel.getString("alertNoItemSelected"));
                return false;
            }
            else
            {
                return true;
            }
        }

        //make sure the user choose a deviation type

            public bool istDeviationTypeChoosed(ComboBox comboBox, ErrorProvider errorProvider)
        {
            LanguageModel languageModel = new LanguageModel();
            if (comboBox.SelectedIndex == 0)
            {
                errorProvider.SetError(comboBox, languageModel.getString("alertNoItemSelected"));
                return false;
            }
            else
            {
                return true;
            }
        }

        /*** allow input only in letters, this method interact directry with the deviation form *****/
        public bool isOnlyCharecters(TextBox textBox, ErrorProvider errorProvider)
        {
            LanguageModel languageModel = new LanguageModel();
            Regex r = new Regex(@"^[a-zA-Z\s,]*$");
            if (!r.IsMatch(textBox.Text))
            {
                errorProvider.SetError(textBox, languageModel.getString("alertInvalidTextEntered"));
                return false;
            }
            else
            {
                return true;
            }


        }

    }
}
