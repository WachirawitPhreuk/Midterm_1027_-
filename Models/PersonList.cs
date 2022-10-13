using System.Collections.Generic;
using System;
class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }
//1.2
    public bool checkName(string title, string firstName, string lastName) {
        foreach(Person person in this.personList) {
            if(person.GetTitle()==title&&person.GetFirstName()==firstName&&person.GetLastName()==lastName) {
                return true;
            }
        } return false;
    }
//1.3
    public bool checkEmail(string email) {
        foreach(Person person in this.personList)
            if(person is CollegeStudent) {
                CollegeStudent cst = (CollegeStudent)person; 
                if(cst.GetEmail()==email){
                    return true;
                }
            }
            else if(person is Teacher) {
                Teacher teach = (Teacher)person; 
                if(teach.GetEmail()==email)
                 {
                    return true;
                }
            }
            return false;
    }

    public bool checkEmailandPassword(string email, string password) {
        foreach(Person person in this.personList)
            if(person is CollegeStudent) {
                CollegeStudent cst = (CollegeStudent)person; 
                if(cst.GetEmail()==email&&cst.GetPassword()==password){
                    return true;
                }
            }
            else if(person is Teacher) {
                Teacher teach = (Teacher)person; 
                if(teach.GetEmail()==email&&teach.GetPassword()==password)
                 {
                    return true;
                }
            }
            return false;
    }
//1.4
    public void AllParticipants() {
        int collegeStudent=0, highSchoolStudent=0, teacher=0, M4=0, M5=0, M6=0;

        foreach(Person person in this.personList) {
            if (person is CollegeStudent) {collegeStudent++;}
            else if(person is HighSchoolStudent) {highSchoolStudent++;
            if(((HighSchoolStudent)person).GetGrade()=="M.4 / Grade 10") {M4++;}
            if(((HighSchoolStudent)person).GetGrade()=="M.5 / Grade 11") {M5++;}
            if(((HighSchoolStudent)person).GetGrade()=="M.6 / Grade 12") {M6++;}}
            else if(person is Teacher) {teacher++;}
    }

        Console.WriteLine("Current College Student = {0}", collegeStudent);
        Console.WriteLine("High-School Student = {0}", highSchoolStudent);
        Console.WriteLine("M.4/Grade 10 = {0}", M4);
        Console.WriteLine("M.5/Grade 11 = {0}", M5);
        Console.WriteLine("M.6/Grade 12 = {0}", M6);
        Console.WriteLine("Teacher : {0}", teacher);
    }

    public void FetchCollegeStudentList() {
        Console.WriteLine("List of College Student");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is CollegeStudent) {
                Console.WriteLine("{0}{1} {2}", person.GetTitle(), person.GetFirstName(), person.GetLastName());
            }
        }

        Console.WriteLine("Please Enter to go back to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }

    public void FetchHighSchoolStudentList() {
        Console.WriteLine("List of High-School Student");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is HighSchoolStudent) {
                Console.WriteLine("{0}{1} {2}", person.GetTitle(), person.GetFirstName(), person.GetLastName());
            }
        }

        Console.WriteLine("Please Enter to go back to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }

    public void FetchTeacherList() {
        Console.WriteLine("List of Teacher");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is Teacher) {
                Console.WriteLine("{0}{1} {2}", person.GetTitle(), person.GetFirstName(), person.GetLastName());
            }
        }
        
        Console.WriteLine("Please Enter to go back to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }
}