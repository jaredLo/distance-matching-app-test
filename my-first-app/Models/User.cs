using System;
namespace my_first_app.Models
{
    public class User
    {
        public string? Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Latitude: {Latitude}, Longitude: {Longitude}";
        }

    }
}

