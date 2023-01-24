using my_first_app.Models;
using my_first_app.Tests;


namespace FirstApp
{
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