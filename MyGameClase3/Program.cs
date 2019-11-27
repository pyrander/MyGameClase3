using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameClase3 {
    class Program {
        static void Main (string[] args)
        {
            int x = 5;
            float y = 4.5f;
            string str = "la old confiable";
            bool myBool = false;
            float result = 5 + 7;

            Console.WriteLine (result + " valor: " + myBool);

            result = 5 - 7;
            Console.WriteLine (result);

            result = 5 * 7;
            Console.WriteLine (result);

            result = 5f / 7f;
            Console.WriteLine (result);

            result = 5 % 2;
            Console.WriteLine ("modulo: " + result);

            Console.WriteLine ("la " + Console.ReadLine () + " confiable" );
            Console.ReadLine ();
        }
    }
}
