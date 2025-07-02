using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class  Car

    {
        private string _model = " ";
        private string _brand = " ";
        private bool _isLuxury;
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if (_isLuxury)
                {
                    return _brand +"-Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("YOU ENTERED NOTHING");
                        _brand = "Defaultvalue";
                    }
                    else
                    {
                        _brand = value;
                    }

                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public Car(string model, String brand, bool is_Luxury) {

            Model = model;
            Brand = brand;
            Console.WriteLine("The car model is " +Model +" is created "+" It is of " +brand);  
            IsLuxury = is_Luxury;
        }
        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and i'm driving");
        }


    }
}
