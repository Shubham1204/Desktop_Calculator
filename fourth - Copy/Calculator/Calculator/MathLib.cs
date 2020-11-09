using System;

namespace Calculator
{
    class MathLib
    {
        public double FNum { get; set; }
        public double SNum { get; set; }
        public string Result { get; set; }
        public MathLib()
        {

        }
        public MathLib(double FNum, double SNum)
        {
            this.FNum = FNum;
            this.SNum = SNum;
        }
        public void Add()
        {
            this.Result = (this.FNum + this.SNum).ToString();
        }
        public void Sub()
        {
            this.Result = (this.FNum - this.SNum).ToString();
        }
        public void Div()
        {
            if (SNum.Equals(0))
            {
                int sno = int.Parse(SNum.ToString());
                int fno = int.Parse(FNum.ToString());
                try
                {
                    int result = fno / sno;
                }
                catch (DivideByZeroException)
                {
                    this.Result = Resource.undefined;
                }
            }
            else
            {
                this.Result = (this.FNum / this.SNum).ToString();
            }
        }
        public void Mul()
        {
            this.Result = (this.FNum * this.SNum).ToString();
        }
        public void Mod()
        {
            this.Result = (this.FNum % this.SNum).ToString();
        }

    }
}
