using my_first_app.Models;
using my_first_app.Tests;
using my_first_app.Utils;


namespace FirstApp
{
    class Program
    {
        static void Main()
        {

            TestData testData = new TestData();

            List<User> users = testData.GenerateRandomUsers(100);

            List<User> currentUsers = testData.GenerateRandomUsers(1);
            User currentUser = currentUsers[0];

            ProximityMatchingAlgorithm algo = new ProximityMatchingAlgorithm(1000.00);

            List<User> matchedUsers = algo.FindMatches(users, currentUser);

            foreach (var user in matchedUsers)
            {
                Console.WriteLine(user.ToString());
            }




        }


    }
}