using GroupsOfStudents;
using Studentns;

Group gr = new Group();

Student st1 = new Student("1","1","1"); gr.AddStudent(st1);
Student st2 = new Student("2", "2", "2"); gr.AddStudent(st2);
Student st3 = new Student("3", "3", "3"); gr.AddStudent(st3);

gr[0].Info();
Console.WriteLine(gr[1]);