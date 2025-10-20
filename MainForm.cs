using KP_Sports_Management.Data;
using KP_Sports_Management.Logic;

namespace KP_Sports_Management
{
    public partial class Main_Form : Form
    {
        DataHandler dh = new DataHandler();
        DataTable table;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<Person> student = new List<Person>();
            FileHandler fh = new FileHandler();

            student.Add(new Person(txtName.Text, txtSurname.Text, txtID.Text, int.Parse(txtGender.Text), int.Parse(txtNumber.Text)));
            fh.writeTo(student);

            dgvDisplay.DataSource = student;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<Person> student = new List<Person>();
            FileHandler fh = new FileHandler();

            for(int i = 0; i < student.Count; i++)
            {
                dh.updateStudent(); 
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dh.deleteStudent();

        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
