using System;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking Prodects Price");
            Details Data = new Details();
            Data.GetData();
        }
    }
}
