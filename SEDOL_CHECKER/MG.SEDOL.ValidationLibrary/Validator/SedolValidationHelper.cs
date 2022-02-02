using MG.SEDOL.ValidationLibrary.Constants;
using System;
using System.Text.RegularExpressions;

namespace MG.SEDOL.ValidationLibrary.Validator
{
    internal sealed class SedolValidationHelper : ISedolValidationHelper
    {
        private readonly string _input = string.Empty;
        private SedolValidationHelper()
        {
        }
        public SedolValidationHelper(string input)
        {
            _input = input;
        }

        public bool IsInvalidLength() => _input?.Length != SedolConstants.ValidLength;
        public bool HasInvalidCharacters() => Regex.IsMatch(_input, @"^[a-zA-Z0-9]+$") == false;
        public bool IsInvalidCheckSum()
        {
            if (IsInvalidLength())
            {
                return true;
            }

            string sedolValue = _input.Substring(0, 6);
            int sedolCheckDigit = Convert.ToInt32(_input.Substring(6, 1));

            int sum = 0;
            for (int index = 0; index < sedolValue.Length; index++)
            {
                sum += ConvertToSedolNumber(sedolValue[index]) * SedolConstants.PositionalSedolWeight[index];
            }
            int calculatedCheckDigit = (10 - sum % 10) % 10;


            return sedolCheckDigit != calculatedCheckDigit;
        }
        public bool IsUserDefinedSedol() => _input?.Length > 0 && Convert.ToString(_input[0]) == "9";
        private int ConvertToSedolNumber(char sedolCharacter)
        {
            if (int.TryParse(sedolCharacter.ToString(), out int parsedValue))
            {
                return parsedValue;
            }
            else
            {
                //Get the alphabet position and add offset to it
                return Convert.ToInt32(sedolCharacter) - 64 + SedolConstants.LetterOffset;
            }
        }




    }
}
