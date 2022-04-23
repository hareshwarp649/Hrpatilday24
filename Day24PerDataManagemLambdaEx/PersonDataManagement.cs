using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24PerDataManagemLambdaEx
{
    public class PersonDataManagement
    {
        List<PersonData> people = new List<PersonData>();
        public  void AddRecords()
        {
            people.Add(new PersonData("9768567495", "jay", "13 main street ,Nagpur, NY", 13));
            people.Add(new PersonData("9768567495", "Ram", "13 main street ,Nagpur, NY", 56));
            people.Add(new PersonData("9768567495", "Dev", "13 main street ,Nagpur, NY", 67));
            people.Add(new PersonData("9768567495", "Shree", "13 main street ,Nagpur, NY", 34));
            people.Add(new PersonData("9768567495", " Shiva", "13 main street ,Nagpur, NY", 87));
            people.Add(new PersonData("9768567495", "jay", "13 main street ,Nagpur, NY", 28));
            people.Add(new PersonData("9768567495", "jay", "13 main street ,Nagpur, NY", 44));
            people.Add(new PersonData("9768567495", "jay", "13 main street ,Nagpur, NY", 13));
            DisplayPerson(people);
        }
        //uc2
        public void ListTop2RecordsAgeLessThan60()
        {
            List<PersonData> datas = people.FindAll(e => e.Age < 60). OrderBy(x => x.Age).Take(2).ToList();
               

            DisplayPerson(datas);
        }

        //uc3
        public void RecordsBetweenGivenAge()
        {
            List<PersonData> datas = people.FindAll(e => e.Age < 13 && e.Age < 18);
            DisplayPerson(datas);
        }

        //uc4
        public void CalculateAverageAge()
        {
            double averageAge = people.Average(e => e.Age);
                
            Console.WriteLine("\n 4] Average Age is : " + averageAge.ToString("#.000"));  
        }


        //uc5
        public void SearchValue(string term)
        {
            bool value = people.Contains(people.FirstOrDefault(e => e.Name.ToUpper().Equals(term.ToUpper())));
              

            if (value == true)
            { Console.WriteLine("\n Search term matched. Value found. \n"); }
            else
            { Console.WriteLine("\n Search term not matched. Value not found. \n"); }
        }

        //uc6
        public void SkipRecords()
        {
            List<PersonData> Datas=people .FindAll(person => person.Age < 60)
                .Skip(3)    //skip first n records and save remaining
                .ToList();

            DisplayPerson(Datas);
        }

        //uc7
        public void RemoveRecord(string term)
        {
            bool removed = people .Remove(people .FirstOrDefault(p => p.Name.ToUpper().Equals(term.ToUpper())));

            if (removed == true)
            { Console.WriteLine("\n Search term matched. Value removed. "); }
            else
            { Console.WriteLine("\n Search term not matched. Value not removed. "); }

            DisplayPerson(people);
        }

        void DisplayPerson(List<PersonData> people)
        {
            Console.WriteLine("\n Displaying person list : ");
            foreach (var p in people)
            {
                Console.WriteLine(" SSN : " + p.SSN + " \t Name : " + p.Name + "\t\t Address : " + p.Address + "\t\t Age : " + p.Age);
            }
        }
    }
}
