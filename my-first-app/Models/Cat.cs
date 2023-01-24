using System;
namespace my_first_app.Models
{
   public class Cat : Animal
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
}

