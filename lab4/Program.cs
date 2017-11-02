using System;
using System.Collections.Generic;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            var cat1 = new Cat(){
                Name = "Tomas"
            };


            cat1.Breath();

            var cat2 = new Cat(){
                Name = "Viorel"
            };

            var cat3 = new Cat(){
                Name = "Garfield"
            };

            var dog1 = new Dog() {
                Name = "Totto"
            };

             var hamster = new Hamster() {
                Name = "Hamsty"
            };

            var animalList = new List<AnimalBase>();
            animalList.Add(cat1);
            animalList.Add(cat2);
            animalList.Add(cat3);
            animalList.Add(dog1);
            animalList.Add(hamster);


            foreach(var animal in animalList)
            {
                animal.Breath();
                animal.Bites();
            }


        }
    }
}
