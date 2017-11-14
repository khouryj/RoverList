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
            rList.Add("idubbz");
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

            
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
