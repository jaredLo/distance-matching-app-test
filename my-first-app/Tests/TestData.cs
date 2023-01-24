using System;
using my_first_app.Models;
using Faker;

namespace my_first_app.Tests
{
	public class TestData
	{

        private Random _random = new Random();

        public List<User> GenerateRandomUsers(int range)
        {

            List<User> people = new List<User>();

            for (var i = 0; i < range; i++)
            {

                double latitude = _random.NextDouble() * 180 - 90;
                double longitude = _random.NextDouble() * 360 - 180;
                string name = Faker.Name.First();


                User u = new User
                {
                    Name = name,
                    Longitude = longitude,
                    Latitude = latitude

                };

                people.Add(u);
        
            }

            return people;
        }



        



    }
}

