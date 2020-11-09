using System;

namespace Calculator
{
    class ScienceMathLib : MathLib
    {
        public void OneDivByX()
        {
            this.Result = (1 / this.FNum).ToString();
        }

        public void Sqrt()
        {
            this.Result = (Math.Sqrt(this.FNum)).ToString();
        }
    }
}
