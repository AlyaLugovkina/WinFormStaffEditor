using Azure.Core.GeoJson;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsStaffEditor
{
    enum RowState
    {
        Existed,
        Modifided,
        Deleted,
        New,
        ModifidedNew
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
            dataGridView1.Columns.Add("surname", "�������");
            dataGridView1.Columns.Add("name", "���");
            dataGridView1.Columns.Add("patronymic", "��������");
            dataGridView1.Columns.Add("birthDate", "���� ��������");
            dataGridView1.Columns.Add("snils", "�����");
            dataGridView1.Columns.Add("position", "���������");
            dataGridView1.Columns.Add("employmentDate", "���� �����");
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

                DateOnly bDate = (DateOnly)row.Cells["BirthDate"].Value;
                DateOnly eDate = (DateOnly)row.Cells["EmploymentDate"].Value;


                NameField.Text = row.Cells["Name"].Value.ToString();
                SurnameField.Text = row.Cells["Surname"].Value.ToString();
                PatronymicField.Text = row.Cells["Patronymic"].Value.ToString();
                SnilsField.Text = row.Cells["Snils"].Value.ToString();
                BirthDateField.Text = bDate.ToString("yyyy-MM-dd");
                EmploymentDateField.Text = eDate.ToString("yyyy-MM-dd");
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
            DialogResult result = addStuffForm.ShowDialog();
            if (result == DialogResult.Cancel && RowData.newStuff != null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if(RowData.newStuff.Snils == dataGridView1.Rows[i].Cells["snils"].Value.ToString())
                    {
                        MessageBox.Show("�������� ����� ��� ���������������! ���������� ������� �����", "������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ReadSinglRow(dataGridView1, RowData.newStuff);
                int n = dataGridView1.Rows.Count;
                dataGridView1.Rows[n - 1].Cells["isNew"].Value = RowState.New;
                RowData.newStuff = null;
                MessageBox.Show("������ ������� ���������", "�����!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Search(DataGridView dgv)
        {

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

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.New || rowState == RowState.ModifidedNew)
                {
                    Staff newEmployee = new Staff
                    {
                        Name = dataGridView1.Rows[i].Cells["name"].Value.ToString(),
                        Surname = dataGridView1.Rows[i].Cells["surname"].Value.ToString(),
                        Patronymic = dataGridView1.Rows[i].Cells["Patronymic"].Value.ToString(),
                        BirthDate = (DateOnly)dataGridView1.Rows[i].Cells["BirthDate"].Value,
                        Snils = dataGridView1.Rows[i].Cells["snils"].Value.ToString(),
                        Position = dataGridView1.Rows[i].Cells["position"].Value.ToString(),
                        EmploymentDate = (DateOnly)dataGridView1.Rows[i].Cells["EmploymentDate"].Value
                    };

                    staffDataBase.Staff.Add(newEmployee);
                }

                if (rowState == RowState.Deleted)
                {
                    var deleteId = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value);
                    var deletedStaff = staffDataBase.Staff.Single(r => r.Id == deleteId);
                    if (deletedStaff != null)
                    {
                        staffDataBase.Staff.Remove(deletedStaff);
                    }
                }

                if (rowState == RowState.Modifided)
                {
                    var id = Convert.ToUInt32(dataGridView1.Rows[i].Cells["id"].Value);

                    var updatedStaff = staffDataBase.Staff.Single(r => r.Id == id);
                    if (updatedStaff != null)
                    {
                        updatedStaff.Name = dataGridView1.Rows[i].Cells["name"].Value.ToString();
                        updatedStaff.Surname = dataGridView1.Rows[i].Cells["surname"].Value.ToString();
                        updatedStaff.Patronymic = dataGridView1.Rows[i].Cells["Patronymic"].Value.ToString();
                        updatedStaff.Position = dataGridView1.Rows[i].Cells["position"].Value.ToString();
                        updatedStaff.Snils = dataGridView1.Rows[i].Cells["snils"].Value.ToString();
                        updatedStaff.BirthDate = (DateOnly)dataGridView1.Rows[i].Cells["BirthDate"].Value;
                        updatedStaff.EmploymentDate = (DateOnly)dataGridView1.Rows[i].Cells["EmploymentDate"].Value;

                        staffDataBase.Staff.Update(updatedStaff);
                    }

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
            RowState state = (RowState)dataGridView1.Rows[selectedRowIndex].Cells["isNew"].Value;

            var ID = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value;
            var Name = NameField.Text;
            var Surname = SurnameField.Text;
            var Patronymic = PatronymicField.Text;
            var Snils = SnilsField.Text;
            var dateFormat = "yyyy-MM-dd";
            var Position = PositionField.Text;
            DateOnly BirthDate, EmploymentDate = new DateOnly();

            var isSnilsExist = staffDataBase.Staff.Where(r => r.Snils == Snils);
            bool sameRow = false;

            
            foreach(Staff stuff in isSnilsExist)
            {
                if(stuff.Id == Convert.ToUInt32(ID))
                    sameRow = true;
            }
            
            if (isSnilsExist.Any() && !sameRow)
            {
                MessageBox.Show("�������� ����� ��� ��������� � ���� ������", "������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SnilsField.Text.Length < 10 || SnilsField.Text.Length > 11)
            {
                MessageBox.Show("����� �������� ������ ���� ����� 10 � 11 ���������", "������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateOnly.TryParseExact(BirthDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out BirthDate)
                || !DateOnly.TryParseExact(EmploymentDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out EmploymentDate))
            {
                MessageBox.Show("������� ���� � �������� �������: ����-��-��", "������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!double.TryParse(SnilsField.Text, out double num))
            {
                MessageBox.Show("� ���� ����� ������ ����������� ������ �����!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (state == RowState.New)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value, Surname, Name, Patronymic,
                                                                BirthDate, Snils, Position, EmploymentDate);
                dataGridView1.Rows[selectedRowIndex].Cells["isNew"].Value = RowState.ModifidedNew;
                return;
            }
            else
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value, Surname, Name, Patronymic,
                                                                BirthDate, Snils, Position, EmploymentDate);
                dataGridView1.Rows[selectedRowIndex].Cells["isNew"].Value = RowState.Modifided;
                return;
            }
            
        }

        private void EditStuffButton_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "" || SurnameField.Text == "" || PatronymicField.Text == "" || BirthDateField.Text == ""
                || SnilsField.Text == "" || PositionField.Text == "" || EmploymentDateField.Text == "")
            {
                MessageBox.Show("��� ���� ������ ���� ���������!", "��������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Change();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("� ������� ������������ ���������� � ���������. ��� ������� �� ����� �������� ������ ���������� ���������� � ���� ����. " +
                "��� ���������� ������ �� ������ ������ ������ \"�������\" ��� \"��������\". " +
                "�� ������ ������ ��� ���������� ������ ��������� � ����� ��� �������� � ����� ������ ������, ����� ������ ���������. " +
                "������ \"����� ������\" ������� ���� ��� �������� ����� ������ � �������. ����� ��� ��������� � ������� �������, ������� ������ \"���������\". " +
                "����� � ������� ������� ��������� ������ ��� �������������. ����������� � ����� ���������� ��� ���������� ������ � �������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
