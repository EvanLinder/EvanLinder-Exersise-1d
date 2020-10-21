using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elinder2e1
{
   public class LogicalOperations
    {
        
        public static bool q01(decimal subtotal)
        {
            // #01
            return subtotal >= 250 && subtotal < 500;

        }
        public static bool q02(int timeInService)
        {
            // #02
            return timeInService <= 4 || timeInService >= 12;

        }
        public static bool q03(bool isValid, int years, int counter)
        {
            // #03
            return isValid == true & counter++ < years;

        }
        public static bool q04(bool isValid, int years, int counter)
        {
            // #04
            return isValid == true & counter++ < years;

        }
        public static bool q05(bool isValid, int years, int counter)
        {
            // #05
            return isValid == true || counter++ < years;

        }
        public static bool q06(bool isValid, int years, int counter)
        {
            // #06
            return isValid == true | counter++ < years;

        }
        public static bool q07(DateTime startDate, DateTime expirationDate, DateTime date, bool isValid)
        {
            // #07
            return date > startDate && date < expirationDate || isValid == true;

        }
        public static bool q08(decimal thisYTD, decimal lastYTD, string empType, int startYear, int currentYear)
        {
            // #08
            return thisYTD > lastYTD || empType == "Part Time" && startYear < currentYear;

        }
        public static bool q09(int years, int counter)
        {
            // #09
            return (!(counter++ >= years));

        }
        public static bool q10(int a, int b, int c, int d)
        {
            // #10
            return (a > b && (b < c || c < d));

        }
        public static bool q11(bool member, decimal price, float weight)
        {
            // #11
            return member == true || price >= 25 | weight <= 1;

        }
        public static bool q12(bool member, decimal price, float weight)
        {
            // #12
            return member == true || price >= 25 | weight <= 1;

        }
        public static bool q13(string shipState, string itemType)
        {
            // #11
            return shipState == "MN" & !(itemType == "Clothing" | itemType == "Food");

        }
    }
}
