using System;

namespace InheritanceDemo
{
    class Program 
    {
        static void Main (string[] args) {
            Radio myRadio = new Radio(false, "Hitachi");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTv = new TV(false, "Sony");
            myTv.SwitchOn();
            myTv.WatchTV();
        }
    }
}