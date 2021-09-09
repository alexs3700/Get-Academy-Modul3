using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    public class FamilyApp
    {
        public string command;
        private string _response;
        public readonly List<Person> _people = new List<Person>();

        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }

        public string GetPeople()
        {
            string ListAllPeople = null;
            foreach(Person aPerson in _people)
            {
                ListAllPeople += aPerson.GetDescription() + Environment.NewLine;
            }
            return ListAllPeople;
        }

        //public List<Person> GetChildrenByParentId(int parentId)
        //{
        //    List<Person> children = new List<Person>();

        //    foreach (Person aPerson in _people)
        //    {
        //        if (aPerson.HasParentWithId(parentId)) children.Add(aPerson);
        //    }
        //    return children;
        //}


        public Person GetPerson(int Id)
        {
            Person aPerson = new();

            aPerson = _people[Id];
            return aPerson;
        }

        public Tuple<List<string>, List<string>> CreateFamilyTreeList() // , List<string>, List<string>
        {
            List<string> FatherList = new List<string>();
            List<string> MotherList = new List<string>();

            List<string> childrenOfFather = new List<string>();
            List<string> childrenOfMother = new List<string>();



            for (int i = 0; i < _people.Count; i++)
            {
                if (_people[i].Father != null)
                {
                    string fatherName = _people[i].Father.FirstName;
                    fatherName = fatherName.Split(" ")[0];
                    FatherList.Add(fatherName);
                    childrenOfFather.Add(_people[i].FirstName.Split(" ")[0]);
                }

                //if (_people[i].Mother != null)
                //{
                //    string motherName = _people[i].Mother.FirstName;
                //    motherName = motherName.Split(" ")[0];
                //    FatherList.Add(motherName);
                //    childrenOfMother.Add(_people[i].FirstName.Split(" ")[0]);
                //}


            }

            return Tuple.Create(FatherList, childrenOfFather); // , MotherList, childrenOfMother

        }

        public string CommandPrompt()
        {
            string promptText = "<input>: ";
            return promptText;
        }

        public string StartConsoleText()
        {
            string consoleStartString = "Hjelp, vis eller vis <id>";
            return consoleStartString;
        }

        public string WelcomeMessage()
        {
            string welcomeMSG = "Welcome to my family tree app";
            return welcomeMSG;
        }


        public string HandleCommand(string command)
        {
           if (command == "help")
            {
                _response = GetHelp();
            }

            if (command == "show 3")
            {
                return _people[2].GetDescription();
            }

            if (command == "list")
            {
                string allFamilyMembers = GetPeople();
                _response = allFamilyMembers;
                return _response;
            }

            return _response;


        }

        
                //else if (motherId == idArray[i])
                //{


        public string GetHelp()
        {
            string helpString1 = "Help=> Help text\n";
            string helpString2 = "List=>Listing all ID's\n";
            string helpString3 = "Show <id> => Showing person with the <id>\n";

            string helpString = helpString1 + helpString2 + helpString3;
            return helpString;
        }



        //public Person GetPersonWithId(int personId)
        //{
        //    return _people[personId];
        //}

        ////public void GetParent(int id)
        ////{

        ////    Person aPerson = _people[id];

        ////    string name = ( aPerson.FirstName ).Split(" ")[0];
        ////    string aFather = aPerson.Father.FirstName;
        ////    int aFatherId = aPerson.Father.Id;

        ////    ////var aMother = aPerson.Mother.FirstName;
        ////    //   Console.WriteLine($"Father {aFather}. Mother: {aMother}");
        ////}

        ////public void CheckForParentNames()
        ////{
        ////    // If not a parent
        ////}

        //public void CreateFatherList()
        //{
        //    List<string> parentNames = new List<string>();
        //    for (int i = 0; i < _people.Count; i++)
        //    {
        //        Console.WriteLine(_people[i].Father);
        //        //Console.WriteLine(_people[i].FirstName);
        //    }



    }
}

            
            
        
    

       //public void GetChildren() {}

      

    

