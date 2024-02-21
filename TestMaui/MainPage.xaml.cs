namespace TestMaui;

public partial class MainPage : ContentPage // signup class
{
	public MainPage()
	{
		InitializeComponent();
	}

	public bool ComparePassword()
	{
		if (confPass != null && pass != null)
		{
			if (!string.IsNullOrEmpty(confPass.Text) && !string.IsNullOrEmpty(pass.Text))
			{
				return confPass.Text.Equals(pass.Text);
			}
			else
			{
				DisplayAlert("Empty fields!", "Make sure the password fields are not blank!", "OK");
			}
		}
		else
		{
			DisplayAlert("Loading Error!", "Restart app!", "OK");
		}

		return false;
	}

	public User CreateUser()
	{
		return new User(fname.Text, lname.Text, pass.Text);
	}

	private void SignupUser(object sender, EventArgs e)
	{
		if (ComparePassword())
		{
			User final = CreateUser();
			Button button = (Button)sender;
			DisplayAlert("Signed Up!", "You may now login!", "OK");
		}
		else
		{
			DisplayAlert("Passwords Error!", "Make sure your passwords match!", "OK");
		}
	}
}
