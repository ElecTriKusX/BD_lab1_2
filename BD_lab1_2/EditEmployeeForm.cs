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
                textBox_BirthDate.Text = employee.BirthDate;
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
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text) || textBox_FullName.Text.Length > 120)
            {
                MessageBox.Show("ФИО обязательно и не более 120 символов!");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_FullName.Text, @"\d"))
            {
                MessageBox.Show("ФИО не должно содержать цифры!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_INN.Text) || textBox_INN.Text.Length != 12 ||
    !System.Text.RegularExpressions.Regex.IsMatch(textBox_INN.Text, @"^\d+$"))
            {
                MessageBox.Show("ИНН должен содержать ровно 12 цифр!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_PensionCertificate.Text) || textBox_PensionCertificate.Text.Length != 11 ||
    !System.Text.RegularExpressions.Regex.IsMatch(textBox_PensionCertificate.Text, @"^\d+$"))
            {
                MessageBox.Show("Пенсионное свидетельство должно содержать ровно 11 цифр!");
                return;
            }
            if (dateTimePicker_BirthDate.Value > DateTime.Now || dateTimePicker_BirthDate.Value.Year > 2200)
            {
                MessageBox.Show("Дата рождения не может быть в будущем или позже 2200 года!");
                return;
            }
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            // Установка фокуса на первое поле при загрузке формы
            textBox_FullName.Focus();
        }

        private void EditEmployeeForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}