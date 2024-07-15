using System.Data;
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

        private void CreateCollumns()
        {
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("patronymic", "Отчество");
            dataGridView1.Columns.Add("birthDate", "Дата рождения");
            dataGridView1.Columns.Add("snils", "СНИЛС");
            dataGridView1.Columns.Add("position", "Должность");
            dataGridView1.Columns.Add("employmentDate", "Дата приёма");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        private void ReadSinglRow(DataGridView dgv, Staff stuff)
        {
            dgv.Rows.Add(stuff.Id, stuff.Surname, stuff.Name, stuff.Patronymic, stuff.BirthDate,
                        stuff.Snils, stuff.Position, stuff.EmploymentDate, RowState.ModifidedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            var employees = staffDataBase.Staff.ToList();
            foreach (var employee in employees)
            {
                ReadSinglRow(dgv, employee);
            }



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCollumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                IdField.Text = row.Cells["id"].Value.ToString();
                NameField.Text = row.Cells["Name"].Value.ToString();
                SurnameField.Text = row.Cells["Surname"].Value.ToString();
                PatronymicField.Text = row.Cells["Patronymic"].Value.ToString();
                SnilsField.Text = row.Cells["Snils"].Value.ToString();
                BirthDateField.Text = row.Cells["BirthDate"].Value.ToString();
                EmploymentDateField.Text = row.Cells["EmploymentDate"].Value.ToString();
                PositionField.Text = row.Cells["Position"].Value.ToString();

            }
        }

        private void synchronization_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
