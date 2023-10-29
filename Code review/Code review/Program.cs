namespace Code_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BachelorStudent oliver = new BachelorStudent("Oliver");
            oliver.AddCredits(20);
            oliver.AddGrades(20);
            oliver.PrintLastGrade();
            oliver.AddGrades(5);
            oliver.AddGrades(3);
            oliver.PrintLastGrade();
            oliver.ConvertGrades(99);
            oliver.ConvertGrades(1001);
            oliver.ConvertGrades(30);
            oliver.PrintStudentInfo();
            oliver.ChangeStudentStatus();
            oliver.AddCredits(10);
            oliver.AddGrades(4);
            oliver.ChangeStudentStatus();
            oliver.PrintGrades();
            oliver.AddCredits(160);

            Console.WriteLine();

            MastersStudent gregor = new MastersStudent("Gregor", 3);
            gregor.ConvertGrades(45);
            gregor.AddCredits(20);
            gregor.AddGrades(20);
            gregor.PrintLastGrade();
            gregor.AddGrades(5);
            gregor.AddGrades(3);
            gregor.PrintLastGrade();
            gregor.ConvertGrades(99);
            gregor.ConvertGrades(1001);
            gregor.ConvertGrades(30);
            gregor.PrintStudentInfo();
            gregor.ChangeStudentStatus();
            gregor.AddCredits(10);
            gregor.AddGrades(4);
            gregor.ChangeStudentStatus();
            gregor.PrintGrades();
            gregor.AddCredits(160);

            Console.WriteLine();

            SuperStudent chris = new SuperStudent("Chris");
            chris.AddCredits(20);
            chris.AddGrades(20);
            chris.PrintLastGrade();
            chris.AddGrades(5);
            chris.AddGrades(3);
            chris.PrintLastGrade();
            chris.ConvertGrades(99);
            chris.ConvertGrades(1001);
            chris.ConvertGrades(30);
            chris.PrintStudentInfo();
            chris.ChangeStudentStatus();
            chris.AddCredits(10);
            chris.AddGrades(4);
            chris.ChangeStudentStatus();
            chris.PrintGrades();
            chris.AddCredits(160);
            chris.AddGrades(4);
            chris.ChangeStudentStatus();
            chris.ChangeStudentHoldStatus();
            chris.AddCredits(10);
            chris.ChangeStudentHoldStatus();
            chris.ChangeStudentStatus();
            chris.AddCredits(20);

            Console.WriteLine();

            BachelorStudent rene = new BachelorStudent("Rene");
            rene.ChangeStudentStatus();
            rene.AddCredits(50);
            rene.AddGrades(50);
            rene.ChangeStudentStatus();
            rene.AddCredits(90);
            rene.AddGrades(4);
            rene.AddGrades(5);
            rene.ConvertGrades(85);
            rene.ConvertGrades(190);
            rene.PrintLastGrade();
            rene.PrintStudentInfo();
            rene.PrintGrades();
            rene.AddCredits(100);
        }
    }
}