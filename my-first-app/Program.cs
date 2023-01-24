using my_first_app.Models;
using my_first_app.Tests;


namespace FirstApp
{

    class Cat : Animal
    {


        public void Meow()
        {
            Console.WriteLine("Meow Meow!");
        }

        public void aboutMe(string genderName)
        {

            string CatName = Name ?? "Booboo";
            Console.WriteLine($"Name: {CatName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {genderName}");
        }

    }



    class Program
    {
        static void Main()
        {

            TestData testData = new TestData();

            List<User> users = testData.GenerateData();


            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }


    }
}