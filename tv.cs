using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class TV : ElectricalDevice
    {


        public TV (bool isOn, string brand):base(isOn, brand ) {
            IsOn = isOn;
            Brand = brand;
        }


        public void WatchTV() {
            if (IsOn) {
                Console.WriteLine("watching the TV");
            } else {
                Console.WriteLine("TV is switched off");
            }
        }
    }
}