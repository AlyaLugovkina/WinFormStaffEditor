using System.IO;

namespace WinFormsStaffEditor
{
    enum RowState
    {
        Existed,
        New,
        Modifided,
        ModifidedNew,
        Deleted
    }


    public partial class Form1 : Form
    {
        StaffContext staffDataBase = new StaffContext();
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
