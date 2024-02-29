using CsharpAfterJava.Exercise3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    internal class Exercise3
    {

        //        Back to Exercise 4 from exercises-csharp-csharpafterjava :
        //          This time we populate students and teachers without the use of the classes of these entities!
        //          Write this code in two different ways:
        //              explicit Tuples
        //               implicit Tuples
        //Use the Main method to show some results of querying this implementation.
        //For example:


        //Tuple<String, List<String, Tuple<>>> Howest = new Tuple<>
        public void run() 
        {

            // implicit Tuples
            var Howest = (name: "Howest", groups: 
                new List<(
                    string name,
                    string principle,
                    List<(
                               int number,
                               string firstname,
                               string lastname
                               )>
                    )>()
                );

            // explicite 

            (string name, List<(string name, string principle, List<(int number, string firstname, string lastname)>)> groups) howest2 = (name: "Howest2", groups:
             new List<(
                 string name,
                 string principle,
                 List<(
                            int number,
                            string firstname,
                            string lastname
                            )>
                 )>()
             );


            //new List<Tuple<string,
            // Tuple<int,string,string>,
            //    List<Tuple<int, string,string>> >> = );
        }

         

           // var t = (a: "test", b: "another test");
    }
}
