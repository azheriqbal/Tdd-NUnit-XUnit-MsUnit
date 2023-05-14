namespace Sparky
{
    public class Calculator
    {

        //Asserting Collections
        public List<int> NumberRange = new();
        public List<int> OddRange (int min, int max)
        {
            NumberRange.Clear();
            for(int i = min; i <= max; i++)
            {
                if(i % 2 != 0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }


        public int AddNums(int a, int b) {
        
            return a + b;
        }

        public double AddNumsdouble(double a, double b)
        {

            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return a % 2 != 0;
        }

    }
}