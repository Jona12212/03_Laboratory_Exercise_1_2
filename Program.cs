using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentRegistrationApplication
{
    internal class frmStudentRegistration
    {
        //pattern for regex
        static string pattern = @"\b(yes|no)\b";
        static void Main(string[] args)
        {

            //directory
            string directorPath = @"C:\Users\JONALYN\OneDrive\Requirements";

            string[] filesToCheck = {
                "GoodMoral.pdf",
                "form137.pdf",
                "grades.xlsx",
            };
            //regex for yes or no
            Regex rg = new Regex(pattern);
            string choose;

            // loop for enrollment
            while (true)
            {
                Console.WriteLine("Do you want to enroll (yes/no)?: ");
                choose = Console.ReadLine();

                if (rg.IsMatch(choose))
                {
                    if (choose == "yes")
                    {
                        Console.WriteLine("The tuition for this enrollment is P 20,000");
                        Console.Write("Payment: ");
                        double payment = Convert.ToDouble(Console.ReadLine());

                        //if stament if the student have enough money
                        if (payment >= 20000.00)
                        {
                            Console.WriteLine("You have enough money.");
                            Console.WriteLine("Requirments: \n 1. Form 137\n 2. Good Moral \n 3.Grades");

                            //display for the requirments
                            Console.WriteLine("Permission to check your requirments (yes/no): ");
                            string filesYesNo = Console.ReadLine();

                            //if statment for files checking
                            if (rg.IsMatch(filesYesNo))
                            {
                                if (filesYesNo == "yes")
                                {
                                    bool allFilesExist = true;
                                    //file checking copy from your example sir
                                    foreach (string fileName in filesToCheck)
                                    {
                                        string filePath = Path.Combine(directorPath, fileName);
                                        if (File.Exists(filePath))
                                        {
                                            Console.WriteLine($"File{fileName} exists.");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"File {fileName} does not exists.");
                                            allFilesExist = false;
                                        }
                                    }
                                    //if statement for picking courses
                                    if (allFilesExist)
                                    {
                                        Console.WriteLine("You can enroll now.");

                                        //course selection
                                        Console.WriteLine("Pick the course you like: \n1. Computer Science \n2. Information Technology\n3. Nursing \n4. Accountancy");
                                        Console.Write("Enter the number of the course you like: ");
                                        int course = Convert.ToInt32(Console.ReadLine());

                                        if (course == 1)
                                        {
                                            Console.WriteLine("You are now enrolled for Bachelor of Science in Computer Science.");
                                            Console.WriteLine($"Your remaining budget is P{payment - 20000}");
                                            break;
                                        }
                                        else if (course == 2)
                                        {
                                            Console.WriteLine("You are now enrolled for Bachelor of Science in Information Technology.");
                                            Console.WriteLine($"Your remaining budget is P{payment - 20000}");
                                            break;
                                        }
                                        else if (course == 3)
                                        {
                                            Console.WriteLine("You are now enrolled for Bachelor of Science in Nursing.");
                                            Console.WriteLine($"Your remaining budget is P{payment - 20000}");
                                            break;
                                        }
                                        else if (course == 4)
                                        {
                                            Console.WriteLine("You are now enrolled for Bachelor of Science in Accountancy.");
                                            Console.WriteLine($"Your remaining budget is P{payment - 20000}");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Input, Please try again");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("We can't enroll you with incomplete requirements.");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("File checking permission denied.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong input.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You do not have enough money.");
                            break;
                        }
                    }
                    else if (choose == "no")
                    {
                       
                        Console.WriteLine("You chose not to enroll.");
                        break; 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}









               
  
            
      
    
























