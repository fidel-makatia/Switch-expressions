using System;

namespace Switch_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;// 1 to 4

            string result;

            result = a switch
            {
                1=>"customer",
                2=>"Client," ,
                3=>"supplier",
                4 =>"Distributer",
                _=>"Invalid"

            };

            Console.WriteLine(result);
        }
    }
}
