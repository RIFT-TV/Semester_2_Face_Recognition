namespace Facial_recognitionGUI;

public partial class Intro_page : Form
{
    public Intro_page()
    {
        InitializeComponent();
    }

    private void Button59_Click(object sender, EventArgs e)
    {
        Form1 Home = new Form1();
        Home.Show();

        this.Hide();
    }
public Intro_page(string username, string fullName, string email) : this()
{
    Label28.Text = $"Hello, {username}!";
    Label57.Text = fullName;
    Label58.Text = email;
}

}