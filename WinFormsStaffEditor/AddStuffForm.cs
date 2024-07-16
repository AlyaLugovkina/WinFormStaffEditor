using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsStaffEditor
{
    public partial class AddStuffForm : Form
    {
        StaffContext staffDataBase = new StaffContext();

        private DataGridView dgv { get; set; }

        public AddStuffForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MessageBox.Show("Введите дату в формате ГГГГ-ММ-ДД", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

            if (NameField.Text == "" || SurnameField.Text == "" || PatronymicField.Text == "" || BirthDateField.Text == ""
                || SnilsField.Text == "" || PositionField.Text == "" || EmploymentDateField.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dateFormat = "yyyy-MM-dd";

            DateOnly newBirthDate, newEmploymentDate = new DateOnly();

            if (!DateOnly.TryParseExact(BirthDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out newBirthDate)
                || !DateOnly.TryParseExact(EmploymentDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out newEmploymentDate))
            {
                MessageBox.Show("Введите дату в указаном формате: ГГГГ-ММ-ДД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!double.TryParse(SnilsField.Text, out double num))
            {
                MessageBox.Show("В поле СНИЛС должны содержаться только цифры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Staff newEmployee = new Staff
                {
                    Name = NameField.Text,
                    Surname = SurnameField.Text,
                    Patronymic = PatronymicField.Text,
                    BirthDate = newBirthDate,
                    Snils = SnilsField.Text,
                    Position = PositionField.Text,
                    EmploymentDate = newEmploymentDate
                };
                RowData.newStuff = newEmployee;
                this.Close();
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо заполнить все поля для того, чтобы создать нового пользователя. Когда редактирование будет завершено нажмите кнопку \"Сохранить\".", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
