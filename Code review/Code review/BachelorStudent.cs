using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_review
{
    public class BachelorStudent : IStudent
    {
        protected int _credits;
        protected string _name;
        protected bool _status;
        protected List<int> _grades = new List<int>();
        protected int _creditsForGraduation;
        protected int _grade1LowestValue;

        public BachelorStudent(string name)
        {
            _name = name;
            _credits = 0;
            _creditsForGraduation = 180;
            _status = true;
            _grade1LowestValue = 51;
        }
        public virtual void AddCredits(int credits)
        {
            if (CheckStudentStatus())
            {
                _credits += credits;
                Console.WriteLine($"{_name} has {_credits} credits.");
                CanGraduate();
            }
        }
        public void AddGrades(int grade)
        {
            if (CheckStudentStatus())
            {
                IsGradeValid(grade);
                if (grade == 5)
                {
                    Console.WriteLine("Good job!");
                }
            }
        }
        protected bool IsGradeValid(int grade)
        {
            if (grade > 0 && grade <= 5)
            {
                _grades.Add(grade);
                return true;
            }
            else 
            {
                Console.WriteLine("Cannot add grade, invalid value");
                return false; 
            }
        }
        public virtual void ConvertGrades(int percentage)
        {
            if (IsPercentageValid(percentage))
            {
                int grade = ConvertPercentageToGrade(percentage);
                if (grade >= 1)
                {
                    Console.WriteLine($"Converted to {grade}, added grade to {_name}.");
                    _grades.Add(grade);
                }
                if (grade == 0)
                {
                    Console.WriteLine("Converted to 0, can only add positive grades to students");
                }
            }
        }

        private int ConvertPercentageToGrade(int percentage)
        {
            return percentage switch
            {
                > 90 => 5,
                > 80 and < 91 => 4,
                > 70 and < 81 => 3,
                > 60 and < 71 => 2,
                > 50 and < 60 => 1,
                < 51 => 0,
                _ => -1, 
            };
        }
        protected bool IsPercentageValid(int percentage)
        {
            if (percentage >= 0 && percentage <= 100)
            {
                
                return true;
            }
            else
            {
                Console.WriteLine("Cannot find grade, invalid value");
                return false;
            }
        }
        public void PrintGrades()
        {
            if (DoesStudentHaveGrades())
            {
                Console.Write($"{_name} has the following grades: ");
                foreach (int grades in _grades)
                {
                    Console.Write(grades + " ");
                }
                Console.WriteLine();
            }
        }
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student name is: {_name} and they have {_credits} credits");
        }
        public void PrintLastGrade()
        {
            if (DoesStudentHaveGrades())
            {
                Console.WriteLine($"The last grade {_name} got is {_grades[_grades.Count - 1]}");
            }
        }
        public void ChangeStudentStatus()
        {
            if (_status)
            {
                _status = false;
                Console.WriteLine($"{_name} is now inactive");
            }
            else
            {
                _status = true;
                Console.WriteLine($"{_name} is now active");
            }
        }
        protected bool CheckStudentStatus()
        {
            if (_status)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{_name} has to be active");
                return false;
            }
        }
        protected bool DoesStudentHaveGrades()
        {
            if (_grades.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Student doesn't have any grades");
                return false;
            }
        }
        protected bool CheckCreditsForGraduation()
        {
            if (_credits >= _creditsForGraduation)
            {
                return true;
            }
            else { return false; }
        }
        protected virtual void CanGraduate()
        {
            if (CheckCreditsForGraduation())
            {
                Console.WriteLine("Congratulations, you have graduated");
            }
        }
    }
}