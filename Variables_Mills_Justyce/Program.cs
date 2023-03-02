using System;

namespace Variables_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int favoriteNumber; //declares int as favoriteNumber
            bool isJumping = false, isRunning = false; //initialize boolean isJummping and isRunning to false on the same line
            float rootbeer;//declares floating point as rootbeer
            favoriteNumber = 16;//assign 16 to favoriteNumber
            rootbeer = 6.9f;//assign 6.9f to rootbeer
            const double finalGrade = 2.55;//initialize double  finalGrade to unchangeable 2.55
            Console.WriteLine(favoriteNumber);//prints favoriteNumber
            Console.WriteLine(isJumping);//prints isJumping
            Console.WriteLine(isRunning);//prints isRunning
            Console.WriteLine(rootbeer);//prints rootbeer
            Console.WriteLine(finalGrade);//prints finalGrade
        }
    }
}
