namespace Facial_recognitionGUI;

public partial class Login_Page : Form
{
    public Login_Page()
    {
        InitializeComponent();
    }

    // Back -> return to Form1
    private void btnBack_Click(object sender, EventArgs e)
    {
        Form1 home = new Form1();
        home.Show();
        this.Hide();
    }

    // Eye toggle: show/hide password
    private void btnEye_Click(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        // TODO: validate username/password
    }

    // Scan Face -> open Scan_Face_Page
    private void btnScanFace_Click(object sender, EventArgs e)
    {
        Scan_Face_Page scanface = new Scan_Face_Page();
        scanface.Show();
        this.Hide();
    }
}
