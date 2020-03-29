using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
 
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Freaking World");

            #region Demo Variables
                byte number = 2;
                int count = 10;
                float totalPrice = 20.95f;
                char character = 'A';
                string firstName = "mosh";

                bool isWorking = true;

                /*var - used as a global data type which detects the applicable data type 
                 * for the declared value
                */

                Console.WriteLine(number);
                Console.WriteLine(count);
                Console.WriteLine(totalPrice);
                Console.WriteLine(character);
                Console.WriteLine(firstName);
                Console.WriteLine(isWorking);

                Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);

                const float pi = 3.14f;
            #endregion

            #region Demo Type Conversion
            byte b = 1;
                int i = b;
                Console.WriteLine(i);

                int j = 1;
                byte h = (byte) j;
                Console.WriteLine(h);

                int L = 1000;
                byte M = (byte)L;
                Console.WriteLine(M); // Data Loss will occur here

                //var num = "1234";
                //int N = Convert.ToInt32(num);
                //Console.WriteLine(N);

                try
                {
                    var num = "1234";
                    int N = Convert.ToByte(num); // Will crash and generate report
                    Console.WriteLine(N);
                }
                catch (Exception)
                {
                    Console.WriteLine("The number could not converted to byte");
                }
            #endregion

            #region Demo Operators

                var A = 10;
                var B = 3;
                var C = 3;

                Console.WriteLine(A+B);
                Console.WriteLine((float)A/(float)B);
                //Operator precedence
                Console.WriteLine(A + B * C);
                Console.WriteLine((A + B) * C);
                Console.WriteLine(A < B);
                Console.WriteLine(A == B);
                Console.WriteLine(A != B);
                Console.WriteLine(!(A != B));

                Console.WriteLine(C > B && C > A);

                Console.WriteLine(C > B || C == A);

                Console.WriteLine(!(C > B || C == A));
            #endregion

            #region Comments
                //- Comment single line
                /*Multiple line comment*/

            /*Use comments to explain whys, hows, constrains, etc.
             Not the whats
             Codes should be cleaned and straight forward*/
            #endregion
        }
    }
}
