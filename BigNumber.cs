using System;

namespace BigNumbersLibrary
{
    public class BigNumber
    {
        string _Number;

        public BigNumber()
        {
            _Number = "0";
        }
        public BigNumber(string Number)
        {
            Value = Number;
        }
        public string Value
        {
            get { return this._Number; }
            set
            {
                foreach (char c in value)
                {
                    if (c < '0' || c > '9')
                        throw new ArgumentOutOfRangeException("Input Value Is Not Number");
                }
                this._Number = value;
            }
        }
    }
}
