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
                dateTimePicker_BirthDate.Value = employee.BirthDate;
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
            // Проверка заполнения обязательных полей
            if (string.IsNullOrWhiteSpace(textBox_FullName.Text))
            {
                MessageBox.Show("Поле 'ФИО работника' обязательно для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_FullName.Focus();
                return;
            }

            if (employeeToEdit == null)
            {
                MessageBox.Show("Не выбран работник для редактирования!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Обновляем данные работника
                employeeToEdit.BeginEdit();
                employeeToEdit.FullName = textBox_FullName.Text.Trim();
                employeeToEdit.BirthDate = dateTimePicker_BirthDate.Value;
                employeeToEdit.INN = textBox_INN.Text.Trim();
                employeeToEdit.PensionCertificateNumber = textBox_PensionCertificate.Text.Trim();
                employeeToEdit.PassportData = textBox_PassportData.Text.Trim();
                employeeToEdit.EndEdit();

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