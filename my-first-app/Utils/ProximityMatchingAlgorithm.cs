using System;
using my_first_app.Models;

namespace my_first_app.Utils
{

    public class ProximityMatchingAlgorithm
    {
        private readonly double _range;

        public ProximityMatchingAlgorithm(double range)
        {
            _range = range;
        }

        public List<User> FindMatches(List<User> users, User currentUser)
        {
            var matches = new List<User>();
            foreach (var user in users)
            {
                if (user != currentUser && DistanceBetweenUsers(user, currentUser) <= _range)
                {
                    matches.Add(user);
                }
            }
            return matches;
        }

        private double DistanceBetweenUsers(User user1, User user2)
        {
            // Use the Haversine formula to calculate the distance between two GPS coordinates
            var lat1 = user1.Latitude;
            var lon1 = user1.Longitude;
            var lat2 = user2.Latitude;
            var lon2 = user2.Longitude;
            var R = 6371; // Radius of the earth in km
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;
            return d;
        }

        private double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
    }

}

