using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_review
{
    public class SuperStudent : BachelorStudent
    {
        private bool _holdStatus;
        public SuperStudent(string name) : base(name) 
        {
            _creditsForGraduation = 200;
            _holdStatus = false;
            
        }
        public override void AddCredits(int credits)
        {
            if (_holdStatus)
            {
                _credits += credits;
                Console.WriteLine($"{_name} has {_credits} credits.");
                CanGraduate();
            }
            else
            {
                base.AddCredits(credits);
            }
        }
        private double CalculateAverageGrade()
        {
            int sumOfGrades = 0;
            foreach (int grades in _grades)
            {
                sumOfGrades += grades;
            }
            double averageGrade = sumOfGrades / _grades.Count;
            return averageGrade;
        }

        private bool CheckGradesForGraduation()
        {
            if (_grades.Count > 3) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override void CanGraduate()
        {
            if (CheckGradesForGraduation() && CheckCreditsForGraduation())
            {
                base.CanGraduate();
                Console.WriteLine("Your average grade is: " + CalculateAverageGrade());
            }

        }
        public void ChangeStudentHoldStatus()
        {
            if (_holdStatus)
            {
                Console.WriteLine($"{_name} is now not on hold");
                _holdStatus = false;
            }
            else 
            {
                Console.WriteLine($"{_name} is now on hold");
                _holdStatus = true;
            }
        }
    }
}
