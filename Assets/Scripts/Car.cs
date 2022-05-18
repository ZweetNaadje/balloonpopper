using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    // the class (blauwdruk. Zonder blauwdruk is er niks om mee te werken)
    public class Car 
    {
        // the properties (welke eigenschappen heeft de class?)
        private string brand;
        private string model;
        private int maxSpeed;

        // the constructor
        public static Car audi => new Car("audi", "a1", 180);

        public Car(string brand, string model, int maxSpeed)
        {
            this.brand = brand;
            this.model = model;
            this.maxSpeed = maxSpeed;
        }

        public int GetMaxSpeed()
        {
            return this.maxSpeed;
        }

        public void SetMaxSpeed(int newSpeed)
        {
            this.maxSpeed = newSpeed;
        }

        public void WhoAmI()
        {
            Debug.Log($"I am a {this.brand} - {this.model}");
        }
    }
}