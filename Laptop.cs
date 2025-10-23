using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRconstraction
{
    internal class Laptop : Device
    {
        private int ram;
        private int battery;
        private bool Efficiency = true;

        public int Ram
        {
            get {  return ram; }
            set
            {
                if (value <1 && value >64)
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                    Efficiency = false;
                    return;
                }
                ram = value;
            }
        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 1 && value > 100)
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                    Efficiency = false;
                    return;
                }
                battery = value;
            }
        }
        public Laptop (string brand,int ram,int battery): base(brand)
        {
            Ram = ram;
            Battery = battery;
            
        }
        public void Work()
        {
            if (Efficiency) 
            {
                Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram}, заряд: {battery}");    
            }
        }
    }
}
