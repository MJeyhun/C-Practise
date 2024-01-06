using DemoLibrary;
namespace WinFormsUAY
{
    public partial class FirstName : Form
    {
        public FirstName()
        {
            InitializeComponent();
        }

        private void combineName_Click(object sender, EventArgs e)
        {
            string fullName = PersonProcessor.JoinName(firstNameText.Text, lastNameText.Text);
            string message = $"Fullname: {fullName}";
            MessageBox.Show(message);
        }
    }
}   