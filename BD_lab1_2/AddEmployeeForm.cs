using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class AddEmployeeForm : Form
    {
        private DataSet_main dataSet;

        public AddEmployeeForm(DataSet_main dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;

            dateTimePicker_BirthDate.MaxDate = DateTime.Today;

            textBox_INN.KeyPress += TextBox_DigitsOnly_KeyPress;
            textBox_PensionCertificate.KeyPress += TextBox_DigitsOnly_KeyPress;
            textBox_PassportData.KeyPress += TextBox_DigitsOnly_KeyPress;
            textBox_FullName.KeyPress += TextBox_FullName_KeyPress;

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            // Проверка ФИО
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text) || textBox_FullName.Text.Length > 120)
            {
                MessageBox.Show("ФИО обязательно для заполнения и не должно превышать 120 символов!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FullName.Focus();
                return;
            }

            // Проверка цифр в ФИО
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_FullName.Text, @"\d"))
            {
                MessageBox.Show("ФИО не должно содержать цифры!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FullName.Focus();
                return;
            }

            // Проверка даты рождения
            if (dateTimePicker_BirthDate.Value == null || dateTimePicker_BirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения должна быть корректной датой, не позднее текущей даты.", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_BirthDate.Focus();
                return;
            }

            // Проверка ИНН (12 цифр)
            if (string.IsNullOrWhiteSpace(textBox_INN.Text) || textBox_INN.Text.Length != 12 ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox_INN.Text, @"^\d+$"))
            {
                MessageBox.Show("ИНН должен содержать ровно 12 цифр!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_INN.Focus();
                return;
            }

            // Проверка пенсионного свидетельства (11 цифр)
            if (string.IsNullOrWhiteSpace(textBox_PensionCertificate.Text) || textBox_PensionCertificate.Text.Length != 11 ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox_PensionCertificate.Text, @"^\d+$"))
            {
                MessageBox.Show("№ пенсионного свидетельства должен содержать ровно 11 цифр!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_PensionCertificate.Focus();
                return;
            }

            // Проверка паспортных данных (10 цифр)
            if (string.IsNullOrWhiteSpace(textBox_PassportData.Text) || textBox_PassportData.Text.Length != 10 ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox_PassportData.Text, @"^\d+$"))
            {
                MessageBox.Show("Паспортные данные должны содержать ровно 10 цифр!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_PassportData.Focus();
                return;
            }

            try
            {
                // Создание новой записи сотрудника
                DataSet_main.EmployeesRow newEmployee = dataSet.Employees.NewEmployeesRow();

                newEmployee.FullName = textBox_FullName.Text.Trim();
                newEmployee.BirthDate = dateTimePicker_BirthDate.Value.Date;
                newEmployee.INN = textBox_INN.Text.Trim();
                newEmployee.PensionCertificateNumber = textBox_PensionCertificate.Text.Trim();
                newEmployee.PassportData = textBox_PassportData.Text.Trim();

                // Добавление в DataSet
                dataSet.Employees.AddEmployeesRow(newEmployee);

                dataSet.Employees.AcceptChanges();
                dataSet.Job.AcceptChanges();
                dataSet.WriteXml("DataSet.xml");
                Console.Write("Saved\n");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Обработчик события KeyPress для полей с цифрами
        private void TextBox_DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем Backspace, Delete и цифры
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отменяем ввод символа
            }
        }
        private void TextBox_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем: буквы (русские и английские), пробел, дефис, апостроф, Backspace
            if (char.IsLetter(e.KeyChar) ||
                e.KeyChar == ' ' ||
                e.KeyChar == '-' ||
                e.KeyChar == '\'' ||
                char.IsControl(e.KeyChar))
            {
                e.Handled = false; // Разрешаем ввод
            }
            else
            {
                e.Handled = true; // Запрещаем ввод
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // Установка фокуса на первое поле при загрузке формы
            textBox_FullName.Focus();
        }

        private void dateTimePicker_BirthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}