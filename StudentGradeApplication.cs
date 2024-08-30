using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeApplication
{
    internal class frmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            // while loop for if the user enter the wrong input
            while (true)
            {

                // try statement for exceptions 
                try
                {
                    //display for entering your name and course
                    Console.Write("Enter your full name: ");
                    String Name = Console.ReadLine();
                    Console.Write("Enter your course: ");
                    String Course = Console.ReadLine();

                    //display for entering your grade
                    Console.Write("Enter your grade in English: ");
                    double EnglishGrade = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your grade in Math: ");
                    double MathGrade = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your grade in Science: ");
                    double ScienceGrade = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your grade in Filipino: ");
                    double FilipinoGrade = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your grade in History: ");
                    double HistoryGrade = Convert.ToDouble(Console.ReadLine());

                    //equation for adding up all the grade
                    double Sum = (double)(EnglishGrade + MathGrade + ScienceGrade + FilipinoGrade + HistoryGrade);

                    //equation for average grade
                    double Avg = (double)(Sum / 5);

                    //if statement for passing or failing grade
                    if (Avg < 75)
                    {
                        Console.WriteLine("The student Failed. \n The general average of " + Name + " from " + Course + " is " + Avg);
                    }
                    else
                    {
                        Console.WriteLine("The student Passed. \n The general average of " + Name + " from " + Course + " is " + Avg);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter proper input.");
                }
                break;
            }
        }
    }
}

