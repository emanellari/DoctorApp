using ConsoleApp.Test.Interfaces;

namespace ConsoleApp.Test
{
    public class Patient : IDataService //BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetDataFromDatabase()
        {
            //throw new NotImplementedException();

            //MYSQL

            return "";
        }

        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }



        //public int GetAge()
        //{
        //    var age = DateTime.Now.Year - DateOfBirth.Year;
        //    return age;
        //}


    }
}

