public class Teacher: Person {
    private string position;

    public Teacher(string title, string firstName, string lastName,
    int age, string position, string allergic, string religion, string email, string password):
    base(title, firstName, lastName, 
    age, allergic, religion,  email, password) {
        this.position = position;
    }
}