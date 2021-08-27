using System;
using System.Collections.Generic;

namespace demo3
{
    public class FamilyTreeApp
    {
        static void Main(string[] args)
        {
            var sverreMagnus = new Person {Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005};
            var ingridAlexandra = new Person {Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004};
            var haakon = new Person {Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973};
            var metteMarit = new Person {Id = 4, FirstName = "Mette-Marit", BirthYear = 1973};
            var marius = new Person {Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997};
            var harald = new Person {Id = 6, FirstName = "Harald", BirthYear = 1937};
            var sonja = new Person {Id = 7, FirstName = "Sonja", BirthYear = 1937};
            var olav = new Person {Id = 8, FirstName = "Olav", BirthYear = 1903};

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            //sverreMagnus.Show();
            //Console.ReadLine();



            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon,
                metteMarit, marius, harald, sonja, olav);

            Console.WriteLine(app.WelcomeMessage());
            while (true)
            {
                Console.Write(app.CommandPrompt());
                var command = Console.ReadLine();
                var response = app.HandleCommand(command);
                Console.WriteLine(response);
            }


            //Tuple<List<string>, List<string>> familiyList = app.CreateFamilyTreeList(); // , List<string>, List<string>



            //    for (int i = 0; i < familiyList.Item1.Count; i++)
            //    {
            //        Console.Write("Father: " + familiyList.Item1[i] + "\t");
            //        Console.Write("Child: " + familiyList.Item2[i] + Environment.NewLine);

            //    }





            //List<string> hasNoChild = app.HasNoChildrenList();

            //foreach (string element in fatherList)
            //{
            //    Console.WriteLine(element);
            //}

            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine(people[i].GetDescription());
            //}


            
            }



            //app.HandleCommand(command);
                // var response;
                //Console.WriteLine(response);
            }
        }

    

