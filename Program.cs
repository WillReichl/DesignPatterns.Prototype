using System;

namespace PrototypeExercise
{
    // Prototype Coding Exercise 
    //
    // Given the definitions below, you are asked to implement Line.Deepcopy() to perform a deep copy of the current Line object. 
    public class Point
    {
        public int X, Y;
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            return this; // bug
        }
    }
    public class Program
    {

        static void PrintLine(Line line)
        {
            Console.WriteLine($"From coordinates ({line.Start.X},{line.Start.Y}) to ({line.End.X},{line.End.Y})");
        }

        static void Main(string[] args)
        {
            var line1 = new Line 
            { 
                Start = new Point { X = 0, Y = 0 },
                End = new Point { X = 2, Y = 2}
            };

            var line2 = line1.DeepCopy();
            line2.End.X = 10;
            line2.End.Y = 10;

            Console.WriteLine("If deep copy done right, these lines will have different coordinate values.\n");
            Console.WriteLine(nameof(line1)); 
            PrintLine(line1); // if deep copy done right, these values will be the originals

            Console.WriteLine(nameof(line2));
            PrintLine(line2);
        }
    }
}
