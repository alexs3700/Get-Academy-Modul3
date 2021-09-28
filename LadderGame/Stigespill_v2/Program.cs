using System;
using System.Collections.Generic;

namespace Stigespill_v2
{
    public class Program
    {
        public static PrintClass print;
        public static Model model;
        

        static void Main(string[] args)
        {
            int pos = 0;
            model = new Model();
            print = new PrintClass(model, 1);
            Console.ReadLine();



            
        }
    }
}
