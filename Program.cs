using _20220713_000_lezione.Entities;
using _20220713_000_lezione.Servicies;

List<Student> students = new List<Student>()
{
    new Student{Name = "Bart", Grade=10},
    new Student{Name = "Marin", Grade=5},
    new Student{Name = "Nelson", Grade=9}
};
List<Exam> exams = new List<Exam>()
{
    new Exam{StudentName = "Bart", Grade=10, Argument ="Math"},
    new Exam{StudentName = "Marin", Grade=5, Argument ="Math"},
    new Exam{StudentName = "Nelson",Grade=9, Argument ="Math"}
};

//var calcStudentsGrade = new CalcGrade<Student>(students);
//calcStudentsGrade.CalcAverage();

//var calcExamsGrade = new CalcGrade<Exam>(exams);
//calcExamsGrade.CalcAverage();

//var maxStudent = calcStudentsGrade.GetBestStudent();
//Console.WriteLine(maxStudent.Name);