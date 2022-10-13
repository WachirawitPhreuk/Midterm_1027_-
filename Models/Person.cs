public class Person {
    private string title;
    private string firstName;
    private string lastName;
    private int age;
    private string allergic;
    private string religion;
    private string email;
    private string password;

    
    public Person(string title,
    string firstName, string lastName,
    int age, string allergic, string religion,
    string email, string password) {
        this.title = title;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.allergic =  allergic;
        this.religion = religion;
        this.email = email;
        this.password = password;
    }

    public string GetTitle() {
        return this.title;
    }
    
    public string GetFirstName() {
        return this.firstName;
    }

    public string GetLastName() {
        return this.lastName;
    }

    public int GetAge() {
        return this.age;
    }

    public string GetAllergic() {
        return this.allergic;
    }

    public string GetReligion() {
        return this.religion;
    }

    public string GetEmail() {
        return this.email;
    }

    public string GetPassword() {
        return this.password;
    }
}