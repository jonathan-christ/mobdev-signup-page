namespace TestMaui;

public partial class MainPage : ContentPage // signup class
{
	public MainPage()
	{
		InitializeComponent();
	}

	public bool ComparePassword()
	{
		return SignUpBtn.Equals(pass);
	}

	public User CreateUser()
	{
		return new User(fname, lname, pass);
	}

	private void SignupUser(object sender, EventArgs e)
	{
		if (ComparePassword())
		{
			User final = CreateUser();
			Button button = (Button)sender;
			DisplayAlert("Signed Up!", "You may now login!", "OK");
		}else{
			DisplayAlert("Passwords Error!", "Make sure your passwords match!", "OK");
		}
	}
}
