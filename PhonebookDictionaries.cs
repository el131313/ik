using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	S { name} – searches for a contact by given name and 
            //                prints it in format "{name} -> {number}".
            //                In case the contact isn't found, print 
            //                "Contact {name} does not exist.".
            //•	END – stop receiving more commands.

            var input = Console.ReadLine();
            var listOfNames = new List<string>();
            var phoneDictionary = new Dictionary<string, string>();
            while (input!="END")
            {
               
                var command = input.Split(' ').ToArray();
                
                if (command[0]=="A")
                {
                    var name = command[1];
                    var phone = command[2];
                    if (!phoneDictionary.ContainsKey(name))
                    {
                        phoneDictionary.Add(name, phone);
                    }
                    else
                    {

                        phoneDictionary.Remove(phone);
                        phoneDictionary.Remove(name);
                        phoneDictionary.Add(name, phone);
                    }
                    

                    //   In case of trying
                    //                to add a name that is already in the phonebook
                    //                you should change the existing phone number with the new one provided.
                }
                else if (command[0]=="S")
                {
                    //SEARCH
                    var name = command[1];
                    listOfNames.Add(name);
                     if (phoneDictionary.ContainsKey(name))
                {
                    
                        Console.WriteLine($"{name} -> {phoneDictionary[name]}");
                    


                }

                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
                    
                }
                

            

                input = Console.ReadLine();
            }
           


        }
    }
}
//A Nakov +359888001122
//A RoYaL(Ivan) 664
//A Gero 5559393
//A Simo 02/987665544
//S Simo
//S simo
//S RoYaL
//S RoYaL(Ivan)
//END

//    output
//    Simo -> 02/987665544
//Contact simo does not exist.
//Contact RoYaL does not exist.
//RoYaL(Ivan) -> 664
