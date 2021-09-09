using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    public class Person
    {
        // Person instance variable type declaration and  initializing.
        public int Id = -1;
        public string FirstName = "";
        public string LastName = "";
        public int BirthYear = -1;
        public int DeathYear = -1;
        public Person Father = null;
        public Person Mother = null;

        public List<string> fatherList;
        public List<string> motherList;
        public List<string> hasNoChildrenList;

        public string description;

        private bool _hasMother = false;
        private bool _hasFather = false;


        public bool HasMother()
        {
            if (Mother != null)
            {
                _hasMother = true;
                return _hasMother;
            }
            return _hasMother;
        }

        public bool HasFather()
        {
            if (Father != null)
            {
                return true;
            }

            return false;

        }

        //public void getParentId()
        //{
        //    int[] idArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    // Determine IDs pre-emptively, in case a parent is missing and would thus be null.
        //    int fatherId = HasFather() ? Father.Id : -1;
        //    int motherId = HasMother() ? Mother.Id : -1;


        //    for (int i = 0; i < idArray.Length; i++)
        //    {
        //        if (fatherId == idArray[i])
        //        {
        //            fatherList.Add(Father.FirstName);
        //        }

        //        else if (motherId == idArray[i])
        //        {
        //            motherList.Add(Mother.FirstName);
        //        }

        //    }
        //}

        //public void Show(bool showFatherList = false, bool showMotherList = false)
        //{
        //    getParentId();

        //    int fathers = fatherList.Count;
        //    int mothers = motherList.Count;

        //    if (showFatherList)
        //    {
        //        for (int i = 0; i < fathers; i++)
        //        {
        //            Console.WriteLine(fatherList[i]);
        //        }
        //    }

        //    else if (showMotherList)
        //    {
        //        for (int i = 0; i < mothers; i++)
        //        {
        //            Console.WriteLine(motherList[i]);
        //        }
        //    }
        //}

        public string GetDescription()
        {


            //if (((Mother != null) && (Father != null)) &&
            //        ((FirstName == null) && (LastName == null)) &&
            //            ((BirthYear == -1) && (DeathYear) == -1))
            //{


            //    description = $"{FirstName} {LastName} (id={Id}) Father: {Father.FirstName} (id={Father.Id}) Mother: {Mother.FirstName} (id={Mother.Id})";
            //    return description;
            //}

            //else if (((Mother == null) && (Father != null)) &&
            //     ((FirstName == null) && (LastName == null)) &&
            //         ((BirthYear == -1) && (DeathYear) == -1))
            //{
            //    description = $"{FirstName} {LastName} (id={Id}) Father: {Father.FirstName} (id={Father.Id})";
            //    return description;
            //}

            //else if (((Mother != null) && (Father == null)) &&
            //   ((FirstName == null) && (LastName == null)) &&
            //       ((BirthYear == -1) && (DeathYear) == -1))
            //{

            //    description = $"{FirstName} {LastName} (id={Id}) Mother: {Mother.FirstName} (id={Mother.Id})";
            //    return description;
            //}


            // 
           
                if ( (FirstName != "") && (LastName == "") )
            {

                description = $"{FirstName} (Id={Id}) Født: {BirthYear}";

                return description;

            }

            // No fields

            else if ( (Mother == null) && (Father == null) && 
                    (FirstName == "") && (LastName == "") ){
                description = $"(Id={Id})";
            }

            else if ((Mother != null) && (Father != null) &&
                 (FirstName == "") && (LastName == "") ) {
                description = $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
            }

            return description;
          

            }          
        }
    }


