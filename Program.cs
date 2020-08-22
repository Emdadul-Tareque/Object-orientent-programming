using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterBottle bottle1 = new WaterBottle("red");
            WaterBottle bootle2 = new WaterBottle();

            Console.WriteLine(bottle1.Color);
            Console.WriteLine(bottle1.height);
            Console.WriteLine(bottle1.weight);
            Console.WriteLine(bottle1.logo);
            
            Console.WriteLine(bootle2.Color);
            Console.WriteLine("Before insert water: " + bottle1.currentWater);
            bottle1.insertWater(300);
            Console.WriteLine("After insert water: " + bottle1.currentWater);
            Console.WriteLine("Before insert water: " + bottle1.currentWater);
            bottle1.insertWater(300);
            Console.WriteLine("After insert water: " + bottle1.currentWater);

            bottle1.releaseWater(300);
            Console.WriteLine("After release water : " + bottle1.currentWater);


            
        }
    }

    public class WaterBottle
    {
        // public string color;
        private readonly string color = "blue";
        public double capacity;
        public double height;
        public double weight;
        public double radius;
        public string logo;
        public double currentWater;

        public WaterBottle(string color) :this()  // call default constructor
        {
            //parameterized constructor
            this.color = color;
        }

        public WaterBottle()
        {
            // Default constructor 

            this.color = "blue";
            this.capacity = 500;
            this.height = 200;
            this.weight = 20;
            this.radius = 5;
            this.logo = "Tareque";
            this.currentWater = 0;
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public void insertWater(double waterAmount)
        {
             this.currentWater  += waterAmount;
        }
        public double releaseWater(double waterAmount)
        {
            if (this.currentWater >= waterAmount)
            {
                this.currentWater -= waterAmount;
                return waterAmount;
            }
            else
            {
                var amount = this.currentWater;
                this.currentWater = 0;
                return amount;
            }
        }
    }
}
