using System;
using System.Linq;
using System.Collections.Generic;

namespace Maching
{
    public static class Maching
    {         
        public static void Main()
        {
        	int[] box = {0, 0, 0, 0, 0};

        	Console.WriteLine("Using Maching");
        	Console.WriteLine("Start all the array:");
        	string getStart = Console.ReadLine();
        	
        	box[0] = Int32.Parse(getStart);
        	box[1] = Int32.Parse(getStart);
            box[2] = Int32.Parse(getStart);
            box[3] = Int32.Parse(getStart);
            box[4] = Int32.Parse(getStart);
            
            Console.WriteLine(box[0]);
            Console.WriteLine(box[0] + " " + box[1]);
            Console.WriteLine(box[0] + " " + box[1] + " " + box[2]);
            Console.WriteLine(box[0] + " " + box[1] + " " + box[2] + " " + box[3]);
            Console.WriteLine(box[0] + " " + box[1] + " " + box[2] + " " + box[3] + " " + box[4]);
            
            Console.WriteLine("Is Model!");
        }
    }
}