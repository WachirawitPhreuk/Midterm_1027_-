public class CollegeStudent: Person {
    private string studentID;

    public CollegeStudent(string title, string firstName, string lastName, string studentID,
    int age, string allergic, string religion, string email, string password): base(title, firstName, lastName, 
    age, allergic, religion, email, password) {
        this.studentID = studentID;
    }
}