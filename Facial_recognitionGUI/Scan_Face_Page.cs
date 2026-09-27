namespace Facial_recognitionGUI;

public partial class Scan_Face_Page : Form
{
    public Scan_Face_Page()
    {
        InitializeComponent();
    }

private void Button35_Click(object sender, EventArgs e)
{
    // TODO: capture the current frame from the camera
}

private void Button48_Click(object sender, EventArgs e)
{
    // Cancel -> back to the login page
    Login_Page login = new Login_Page();
    login.Show();
    this.Hide();
}




}