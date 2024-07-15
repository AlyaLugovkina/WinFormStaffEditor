using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsStaffEditor
{
    public partial class AddStuffForm : Form
    {
        StaffContext staffDataBase = new StaffContext();

        public AddStuffForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MessageBox.Show("Введите дату в формате ГГГГ-ММ-ДД","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            var newName = NameField.Text;
            var newSurname = SurnameField.Text;
            var newPatronymic = PatronymicField.Text;
            var newSnils = SnilsField.Text;
            var dateFormat = "yyyy-MM-dd";
            var newPosition = PositionField.Text;
            DateOnly newBirthDate, newEmploymentDate = new DateOnly();
            if (!DateOnly.TryParseExact(BirthDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out newBirthDate) 
                || !DateOnly.TryParseExact(EmploymentDateField.Text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out newEmploymentDate))
            {
                MessageBox.Show("Введите дату в указаном формате: ГГГГ-ММ-ДД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!double.TryParse(SnilsField.Text, out double num))
            {
                MessageBox.Show("В поле СНИЛС должны содержаться только цифры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Staff newEmployee = new Staff
                {
                    Name = newName,
                    Surname = newSurname,
                    Patronymic = newPatronymic,
                    BirthDate = newBirthDate,
                    Snils = newSnils,
                    Position = newPosition,
                    EmploymentDate = newEmploymentDate
                };
                staffDataBase.Staff.Add(newEmployee);
                MessageBox.Show("Запись успешно добавлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            staffDataBase.SaveChanges();

        }
    }
}
