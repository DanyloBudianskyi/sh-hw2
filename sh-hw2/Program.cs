using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace sh_hw2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------KEYBOARD-----------------");
            var keyboard = new ManagementObjectSearcher("SELECT * FROM Win32_Keyboard");
            foreach (var k in keyboard.Get())
            {
                foreach (var prop in k.Properties)
                {
                    Console.WriteLine($"Name: {prop.Name}, Value: {prop.Value}");
                } 
            }
            Console.WriteLine("-----------------MOUSE-----------------");
            var mouse = new ManagementObjectSearcher("SELECT * FROM Win32_PointingDevice");
            foreach (var m in mouse.Get())
            {
                foreach (var prop in m.Properties)
                {
                    Console.WriteLine($"Name: {prop.Name}, Value: {prop.Value}");
                }
            }
            Console.WriteLine("-----------------NETWORK-----------------");
            var network = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            foreach (var n in network.Get())
            {
                foreach (var prop in n.Properties)
                {
                    Console.WriteLine($"Name: {prop.Name}, Value: {prop.Value}");
                }
            }
            Console.ReadKey();
        }
    }
}
