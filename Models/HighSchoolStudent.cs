public class HighSchoolStudent: Person {
    private string grade;
    private string school;

    public HighSchoolStudent(string title, string firstName, string lastName,
    int age, string grade, string allergic, string religion, string school, string email, string password): base(title, firstName, lastName, 
    age, allergic, religion, email, password) {
        this.grade = grade;
        this.school = school; 
    }

    public string GetGrade() {
        return this.grade;
    }

    public string GetSchool() {
        return this.school;
    }
}