using Azure.Core.GeoJson;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace WinFormsStaffEditor
{
    enum RowState
    {
        Existed,
        Modifided,
        Deleted
    }


    public partial class MainForm : Form
    {
        StaffContext staffDataBase = new StaffContext();
        int selectedRow;

        public MainForm()
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
                        stuff.Snils, stuff.Position, stuff.EmploymentDate, RowState.Existed);
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
            dataGridView1.Columns["isNew"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

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

        private void NewStuffButton_Click(object sender, EventArgs e)
        {
            AddStuffForm addStuffForm = new AddStuffForm();
            addStuffForm.Show();
        }

        private void Search(DataGridView dgv)
        {
            //r.Id + r.Name + r.Surname + r.Patronymic + r.Snils + r.BirthDate + r.EmploymentDate + r.Position

            dgv.Rows.Clear();

            var searchResult = staffDataBase.Staff.Where(r => EF.Functions.
                                Like(r.Id + r.Name + r.Surname + r.Patronymic + r.Snils + r.BirthDate + r.EmploymentDate + r.Position,
                                                                                                "%" + textBoxSearch.Text + "%"));

            foreach (var result in searchResult)
            {
                ReadSinglRow(dgv, result);
            }

        }

        private void Update()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells["isNew"].Value;


                if (rowState == RowState.Deleted)
                {
                    var deleteId = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value);
                    var deletedStaff = staffDataBase.Staff.Single(r => r.Id == deleteId);
                    if (deletedStaff != null)
                    {
                        staffDataBase.Staff.Remove(deletedStaff);
                    }
                }
                staffDataBase.SaveChanges();
                if (rowState == RowState.Modifided)
                {
                    var id = Convert.ToUInt32(dataGridView1.Rows[i].Cells["id"].Value);
                    var name = dataGridView1.Rows[i].Cells["name"].Value.ToString();
                    var surname = dataGridView1.Rows[i].Cells["surname"].Value.ToString();
                    var dateFormat = "yyyy-MM-dd";
                    var patronymic = dataGridView1.Rows[i].Cells["Patronymic"].Value.ToString();
                    var snils = dataGridView1.Rows[i].Cells["snils"].Value.ToString();
                    var position = dataGridView1.Rows[i].Cells["position"].Value.ToString();
                    DateOnly birthDate, employmentDate = new DateOnly();

                    DateOnly.TryParseExact(BirthDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out birthDate);
                    DateOnly.TryParseExact(EmploymentDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out employmentDate);

                    var updatedStaff = staffDataBase.Staff.Single(r => r.Id == id);
                    if (updatedStaff != null)
                    {
                        updatedStaff.Name = name;
                        updatedStaff.Surname = surname;
                        updatedStaff.Patronymic = patronymic;
                        updatedStaff.Position = position;
                        updatedStaff.Snils = snils;
                        updatedStaff.BirthDate = birthDate;
                        updatedStaff.EmploymentDate = employmentDate;

                        staffDataBase.Staff.Update(updatedStaff);
                    }

                    //Staff updatedEmployee = new Staff
                    //{
                    //    Id = id,
                    //    Name = name,
                    //    Surname = surname,
                    //    Patronymic = patronymic,
                    //    BirthDate = birthDate,
                    //    Snils = snils,
                    //    Position = position,
                    //    EmploymentDate = employmentDate
                    //};

                    //staffDataBase.Staff.Update(updatedEmployee);
                    //staffDataBase.SaveChanges();

                }
                staffDataBase.SaveChanges();
            }
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells["id"].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells["isNew"].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells["isNew"].Value = RowState.Deleted;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void DeleteStuffButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var Name = NameField.Text;
            var Surname = SurnameField.Text;
            var Patronymic = PatronymicField.Text;
            var Snils = SnilsField.Text;
            var dateFormat = "yyyy-MM-dd";
            var Position = PositionField.Text;
            DateOnly BirthDate, EmploymentDate = new DateOnly();


            if (!DateOnly.TryParseExact(BirthDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out BirthDate)
                || !DateOnly.TryParseExact(EmploymentDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out EmploymentDate))
            {
                MessageBox.Show("Введите дату в указаном формате: ГГГГ-ММ-ДД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!double.TryParse(SnilsField.Text, out double num))
            {
                MessageBox.Show("В поле СНИЛС должны содержаться только цифры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value, Surname, Name, Patronymic,
                                                                BirthDate, Snils, Position, EmploymentDate);
                dataGridView1.Rows[selectedRowIndex].Cells["isNew"].Value = RowState.Modifided;
            }
        }

        private void EditStuffButton_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            DeleteRow();
            Update();
        }
    }
}
