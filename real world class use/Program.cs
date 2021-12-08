using System;
namespace realworlduseclass
{
    class vehical
    {
        public string model;
        public string color;
        public int year;
        public int speed;
        public vehical(string model, string color, int year, int speed) //constructor
        
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.speed = speed;
        }
        public void hello() //metod
        {
            Console.WriteLine("welcome to the car store");
        }
        public void detail()
        {
            Console.WriteLine("car model: " + model + " " + "car color: " + color + " " + "car year:" + year + "  " + "car speed: " + speed);
        }
    }
    class car2 //get set propertie
    {
        private string model1;
        public string Model1 { 
            get{return model1;}
           set{model1=value;}
    }
    }
    class car //parent class
    {
        public void speed(int speed)
        {
           
            if (speed > 200)
            {
                Console.WriteLine("this car is a bmw car and speed " + speed);
            }
            else { 
                Console.WriteLine("this car is a marsdiz");
            }
        }
        public string color = "yellow";
        public void sws()
        { 
            Console.WriteLine("welcome to the sws showroom");
        }
    }
    class Car3:car //childclass
                     //Car3 inherit car property
    {
        public string model = "sws";

    }
    class program 
    {
        static void Main(string[] args)
        {
            vehical obj = new vehical("bmw","black",2021,350);
            obj.hello();
            obj.detail();
            car2 obj1 = new car2();
            obj1.Model1 = "Marsdiz";
            Console.WriteLine(obj1.Model1);
            car obj2 = new car();
            obj2.speed(350);
            //obj2.sws();
            Car3 obj3 = new Car3();
            obj3.sws();
            Console.WriteLine(obj3.model+" "+obj3.color);

        }
    }
}