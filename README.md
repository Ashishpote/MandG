# MandG

//The code in this block can be used to pass it in unit test cases
#region "Sedol Code"

ISedolValidator ISedolValidator = new SedolValidator();
ISedolValidationResult ISedolValidationResult = ISedolValidator.ValidateSedol(txtSEDOL.Text);

#endregion
//block ends here
