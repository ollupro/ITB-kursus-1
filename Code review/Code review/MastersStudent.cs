using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_review
{
    public class MastersStudent : BachelorStudent
    {
        public MastersStudent(string name, int studentNumber) : base(name) 
        {
            _creditsForGraduation = 120;
            _name = name + studentNumber;
        }
        public override void ConvertGrades(int percentage)
        {
            if (percentage > 39 && percentage < 61)
            {
                Console.WriteLine($"Converted to 1, added grade to {_name}.");
                _grades.Add(1);
            }
            else
            {
                base.ConvertGrades(percentage);
            }
            
        }
    }
}
