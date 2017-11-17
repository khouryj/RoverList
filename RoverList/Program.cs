using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    //Joseph Khoury, Andrew Spaziani, Bryant White
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            RoverList rList = new RoverList();
            rList.Add("Gordon");
            rList.Add("Ramsay");
            rList.Add("Lamb Sauce");
            rList.Add("Eric Harris");
            rList.Add("Dylan Klebold");
            rList.Add("Klabundasaurus");
            rList.Add("idubbbz");
            rList.Add("maxmoefoe");
            rList.Add("Tank zos");
            rList.Add("Nofriendo Switch");
            rList.Add("Big Water");
            rList.Add("Gabe Newell");
            rList.Add("Harrible");
            rList.Add("Canada");
            rList.Add("CS1.6, CS1.6");
            rList.Add("Z9Z9Z9Z9Z9");
            // TODO:  Print out the list
            rList.ListNodes();

            // TODO:  Remove every 3rd word
            for (int i = 2; i < rList.Count; i += 3)
            {
                rList.RemoveAt(i);
            }

            Console.WriteLine();
            // TODO:  Print out the list
            rList.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list
            String input = "";
            while (input != "done")
            {
                Console.Write("Enter any word then press enter, (enter 'done' to stop adding word): ");
                input = Console.ReadLine();
                
                if (input != "done")
                {
                    rList.Add(input);
                }
            }


            Console.WriteLine();

            rList.ListNodes();

            Console.WriteLine();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            input = "";
            while (input != "done")
            {
                Console.Write("Enter any word then press enter, (enter 'done' to stop adding word): ");
                input = Console.ReadLine();

                if (input != "done")
                {
                    rList.Add(0,input);
                }
            }

            rList.ListNodes();

            Console.WriteLine();

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list
            for (int i = 0; i < rList.Count; i++)
            {
                if (rList.ElementAt(i).Data.ToString().Length % 2 != 0)
                {
                    rList.RemoveAt(i);
                }
            }
            rList.ListNodes();
            Console.WriteLine();

            // TODO:  Clear the list
            // TODO:  Print out the list

            rList.Clear();
            rList.ListNodes();

        }
    }
}
