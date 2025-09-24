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
            // Проверка заполнения обязательных полей
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text))
            {
                MessageBox.Show("Поле 'ФИО работника' обязательно для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FullName.Focus();
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