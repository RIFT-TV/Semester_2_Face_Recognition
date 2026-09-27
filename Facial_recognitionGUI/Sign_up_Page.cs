namespace Facial_recognitionGUI;

public partial class Sign_up_Page : Form
{
    public Sign_up_Page()
    {
        InitializeComponent();
    }
         private void Button48_Click(object sender, EventArgs e)
    {
        Scan_Face_Page Scanface = new Scan_Face_Page();
        Scanface.Show();

        this.Hide();
    }
    
private void btnBack_Click(object sender, EventArgs e)
{
    Form1 home = new Form1();
    home.Show();
    this.Hide();
}

private void btnEyePassword_Click(object sender, EventArgs e)
{
    Password.UseSystemPasswordChar = !Password.UseSystemPasswordChar;
}

private void btnEyeConfirm_Click(object sender, EventArgs e)
{
    txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
}

private void Button35_Click(object sender, EventArgs e)
{
    
}

}