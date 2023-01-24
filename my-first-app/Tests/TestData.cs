using System;
using my_first_app.Models;

namespace my_first_app.Tests
{
	public class TestData
	{
		public List<User> GenerateData()
		{
            List<User> userList = new List<User>
        {
                new User { Name = "Gelato", Latitude = 48.458769831103695, Longitude = 2.3488736031496558 },
    new User { Name = "Barry", Latitude = 38.458769831103695, Longitude = 2.6488736031496558 }
        };

            return userList;
        }
	}
}

