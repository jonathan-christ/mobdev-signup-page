public class User
{
    private String firstName;
    private String lastName;
    private String password;

    public User(String fname = "", String lname = "", String pass = "")
    {
        firstName = fname;
        lastName = lname;
        password = pass;

    }
    public String FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public String LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public String Password
    {
        get { return password; }
        set { password = value; }
    }
}