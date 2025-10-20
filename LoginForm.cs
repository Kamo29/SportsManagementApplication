amespace KP_Sports_Management
{
    public partial class Login_Form : Form
    {
        DataHandler dh = new DataHandler();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //compare the usernames and passwords from the textbox and textfile
            string [] line = File.ReadAllLines(@"C:\Users\Student\Documents\Students.txt");
            string[] values;

            for(int i = 0; i < line.Length; i++)
            {
                string[] row = new string[line.Length]; 

                for(int j = 0; j < line.Length; j++)
                {
                    row[j] = line[j].Trim();
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Go to next page to signup
            Main_Form main = new Main_Form();
            main.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
