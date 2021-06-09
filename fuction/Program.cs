using System;

namespace fuction
{

    class Program

    {
        public static bool chkprime(int num)
        {
            for(int i= 2; i<=num/i; i++)
              if (num%i==0)
                    return false;
                return true;
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter the number to chek prime ");
            string var;
            int num;
            var = Console.ReadLine();
            num = Convert.ToInt32(var);
            Console.WriteLine(chkprime(num));
        }
    }
}
