namespace FunctionsCSharp
{
    internal class Program
    {
        static bool LeapYear(int Year)
        {
            bool Del100 = Year % 100 == 0;
            bool Del400 = Year % 400 == 0;
            bool Del4 = Year % 4 == 0;
            if ( Del100 )
            {
                return false;
            }
            if(Del400)
            {
                return true;
            }
            return Del4;
            
        }
        static int BetweenDays(int DayOne, int MonthOne, int YearOne, int DayTwo, int MonthTwo, int YearTwo)
        {
            var DateOne = new DateTime(YearOne, MonthOne, DayOne);
            var DateTwo = new DateTime(YearTwo, MonthTwo, DayTwo);
            return Math.Abs((DateTwo - DateOne).Days);
        }

        static double AverageNumber(int[] arr)
        {
            int Summ = 0;
            foreach (var i in arr)
            {
                Summ += i;
            }
            return Summ / arr.Length;
        }

        static void NumbersType(int[] arr, out int Positive, out int Negative, out int Zero)
        {
            Positive = 0;
            Negative = 0;
            Zero = 0;

            foreach (var i in arr)
            {
                if(i > 0)
                {
                    Positive++;
                }
                 if (i < 0)
                {
                    Negative++;
                }
                else
                {
                    Zero++;
                }
            } 
        }
        
        static void Main(string[] args)
        {
            
            
        }
    }
}
