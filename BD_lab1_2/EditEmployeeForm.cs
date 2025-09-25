using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class EditEmployeeForm : Form
    {
        private DataSet_main dataSet;
        private DataSet_main.EmployeesRow employeeToEdit;

        public EditEmployeeForm(DataSet_main dataSet, DataSet_main.EmployeesRow employee)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.employeeToEdit = employee;

            // Заполняем поля данными выбранного работника
            if (employee != null)
            {
                textBox_FullName.Text = employee.FullName;
                dateTimePicker_BirthDate.Value = employee.BirthDate.Date;
                textBox_INN.Text = employee.INN;
                textBox_PensionCertificate.Text = employee.PensionCertificateNumber;
                textBox_PassportData.Text = employee.PassportData;
            }
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
                // Редактирование существующей записи сотрудника
                employeeToEdit.BeginEdit();
                employeeToEdit.FullName = textBox_FullName.Text.Trim();
                employeeToEdit.BirthDate = dateTimePicker_BirthDate.Value.Date;
                employeeToEdit.INN = textBox_INN.Text.Trim();
                employeeToEdit.PensionCertificateNumber = textBox_PensionCertificate.Text.Trim();
                employeeToEdit.PassportData = textBox_PassportData.Text.Trim();
                employeeToEdit.EndEdit();

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

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            // Установка фокуса на первое поле при загрузке формы
            textBox_FullName.Focus();
        }

        private void dateTimePicker_BirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}