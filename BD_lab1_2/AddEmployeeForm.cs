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

            // Проверка паспортных данных
            if (string.IsNullOrWhiteSpace(textBox_PassportData.Text))
            {
                MessageBox.Show("Паспортные данные обязательны для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_PassportData.Focus();
                return;
            }

            try
            {
                // Создание новой записи сотрудника
                DataSet_main.EmployeesRow newEmployee = dataSet.Employees.NewEmployeesRow();

                newEmployee.FullName = textBox_FullName.Text.Trim();
                newEmployee.BirthDate = dateTimePicker_BirthDate.Value;
                newEmployee.INN = textBox_INN.Text.Trim();
                newEmployee.PensionCertificateNumber = textBox_PensionCertificate.Text.Trim();
                newEmployee.PassportData = textBox_PassportData.Text.Trim();

                // Добавление в DataSet
                dataSet.Employees.AddEmployeesRow(newEmployee);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
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