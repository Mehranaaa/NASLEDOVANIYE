using System;

namespace NASLEDOVANIYE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualAccount count = new IndividualAccount();
            count.Sum = 1000;
            count.Open_data = new DateTime(2000, 12, 2);
            count.Account_number = 54545454;
            count.Sum1();
            count.OpenData();
            count.Percent(15);
            count.Cashout();
        }
    }


    class Count
    {
        public int Sum
        {
            get; set;
        }
        public DateTime Open_data
        {
            get; set;
        }
        public int Account_number
        {
            get; set;
        }

        public void Sum1()
        {
            Console.WriteLine("Summa na balanse: " + Sum);
        }

        public void OpenData()
        {
            Console.WriteLine($"Data otkritiya balansa: " + Open_data);
        }


    }


    class IndividualAccount : Count
    {
        public string Count_Type { get; set; }

        public void Percent(double percent)
        {
            double a = Sum * percent / 100;
            double b = Sum + a;
            Console.WriteLine("Summa nachislennix procentov: " + a);
            Console.WriteLine("Obshaya obnovlennaya summa: " + b);
        }

        public void Cashout()
        {
            double cashout = 250;
            if (cashout <= Sum)
            {
                double ostatok = Sum - cashout;
                Console.WriteLine("Udachnje snatie so scheta! Ostalos na shetu: " + ostatok);
            }
        }

    }

    class YurAccount : Count
    {
        public void Percent(double percent)
        {
            double a = Sum * percent / 100;
            double b = Sum + a;
            Console.WriteLine("Summa nachislennix procentov: " + a);
            Console.WriteLine("Obshaya obnovlennaya summa: " + b);
        }
    }


}





