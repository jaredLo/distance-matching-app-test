using System;
namespace my_first_app.Models
{
    public class Animal
    {
        private string? _name;
        private int _age;
        private int _gender;


        public string Name
        {
            get { return _name ?? "Unknown"; }
            set { _name = value ?? "Unknown"; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


    }
}



