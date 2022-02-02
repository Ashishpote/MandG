using MG.SEDOL.ValidationLibrary.Constants;
using MG.SEDOL.ValidationLibrary.Interface;
using System;

namespace MG.SEDOL.ValidationLibrary.Validator
{
    public sealed class SedolValidator : ISedolValidator
    {
        private ISedolValidationHelper _ISedolValidationHelper;
        private ISedolValidationResult _ISedolValidationResult;
        public ISedolValidationResult ValidateSedol(string input)
        {
            _ISedolValidationResult = new SedolValidationResult();
            _ISedolValidationHelper = new SedolValidationHelper(input);

            _ISedolValidationResult.ValidationDetails = null;

            try
            {
                _ISedolValidationResult.InputString = input;
                
                //Sedol Validations

                if (_ISedolValidationHelper.IsInvalidLength())
                {
                    _ISedolValidationResult.ValidationDetails = SedolErrorMessage.LengthError;
                }
                else if (_ISedolValidationHelper.HasInvalidCharacters())
                {
                    _ISedolValidationResult.ValidationDetails = SedolErrorMessage.InvalidCharacters;
                }
                else if (_ISedolValidationHelper.IsInvalidCheckSum())
                {
                    _ISedolValidationResult.ValidationDetails = SedolErrorMessage.ChecksumError;
                }

                if (_ISedolValidationHelper.IsUserDefinedSedol())
                {
                    _ISedolValidationResult.IsUserDefined = true;
                }

                // No Error Added means SEDOL is Valid
                if (string.IsNullOrEmpty(_ISedolValidationResult.ValidationDetails))
                {
                    _ISedolValidationResult.IsValidSedol = true;
                }
            }
            catch (Exception)
            {
                //Log Error here
            }

            return _ISedolValidationResult;
        }
    }
}
