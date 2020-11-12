using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1000;
            double i = 0.05;
            double t = 0.18;
            double ds = 1100;

            Console.WriteLine(CalculateYears(p, i, t, ds));
        }

        static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            if (principal == desiredPrincipal)
            {
                return 0;
            }
            else
            {
                int years = 0;
                while (principal <= desiredPrincipal)
                {
                    double withoutTax = principal * (1 + interest);
                    principal = withoutTax - ((withoutTax - principal) * tax);
                    years++;
                }
                return years;
            }
            
        }
    }
}
