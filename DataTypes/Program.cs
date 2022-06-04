using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySByte = -15;
            Console.WriteLine(mySByte);
            int myInt = 12318925;
            Console.WriteLine(myInt);
            uint myUInt = 123091;
            Console.WriteLine(myUInt);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUShort = 65535;
            Console.WriteLine(myUShort);
            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);
            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);
            char myChar = 'A';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";
            
            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);   
            Console.ReadLine();
        }
    }
}
