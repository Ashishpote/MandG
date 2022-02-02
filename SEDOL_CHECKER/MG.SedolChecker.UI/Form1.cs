using MG.SEDOL.ValidationLibrary.Interface;
using MG.SEDOL.ValidationLibrary.Validator;
using System;
using System.Windows.Forms;

namespace MG.SedolChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            //The code in this block can be used to pass it in unit test cases
            #region "Sedol Code"

            ISedolValidator ISedolValidator = new SedolValidator();
            ISedolValidationResult ISedolValidationResult = ISedolValidator.ValidateSedol(txtSEDOL.Text);

            #endregion
            //block ends here



            //This is done only for printing null as String purpose
            string input = "Null";
            string validationMessage = "Null";

            if (ISedolValidationResult.InputString?.Length > 0)
            {
                input = ISedolValidationResult.InputString;
            }

            if (ISedolValidationResult.ValidationDetails?.Length > 0)
            {
                validationMessage = ISedolValidationResult.ValidationDetails;
            }            

            MessageBox.Show($"Sedol Result: {input},{ISedolValidationResult.IsValidSedol},{ISedolValidationResult.IsUserDefined},{ validationMessage}");
        }
    }
}
