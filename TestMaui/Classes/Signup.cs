public class Signup
{
    //getter and setter
    private string fname;
    private string lname;
    private string pass;
    private string confirmPass;

    public Signup(string firstname, string lastname, string password, string confirm)
    {
        this.fname = firstname;
        this.lname = lastname;
        this.pass = password;
        this.confirmPass = confirm;
    }

    public bool comparePassword()
    {
        return confirmPass == pass;
    }

    public User createUser()
    {
        return new User(fname, lname, pass);
    }

    //button handler
    public bool signupUser()
    {
        if (comparePassword())
        {
            User final = createUser();
            Console.WriteLine("Nice one");
            return true;
        }
        else
        {
            return false;
        }
    }
}