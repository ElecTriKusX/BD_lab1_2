using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class AddJobForm : Form
    {
        private DataSet_main dataSet;
        private DataSet_main.EmployeesRow selectedEmployee;

        public AddJobForm(DataSet_main dataSet, DataSet_main.EmployeesRow employee)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.selectedEmployee = employee;

            // Если передан работник, устанавливаем его ФИО
            if (employee != null)
            {
                textBox_EmployeeName.Text = employee.FullName;
                textBox_EmployeeName.ReadOnly = true;
                textBox_EmployeeName.BackColor = SystemColors.Control;
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
            if (selectedEmployee == null)
            {
                MessageBox.Show("Не выбран работник!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Создание новой записи работы
                DataSet_main.JobRow newJob = dataSet.Job.NewJobRow();

                newJob.EmployeeID = selectedEmployee.ID;
                newJob.StartDate = dateTimePicker_StartDate.Value;
                newJob.EndDate = dateTimePicker_EndDate.Value;
                newJob.Description = textBox_Description.Text.Trim();

                // Добавление в DataSet
                dataSet.Job.AddJobRow(newJob);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SelectEmployee_Click(object sender, EventArgs e)
        {
            using (var selectForm = new SelectEmployeeForm(dataSet))
            {
                if (selectForm.ShowDialog() == DialogResult.OK && selectForm.SelectedEmployee != null)
                {
                    selectedEmployee = selectForm.SelectedEmployee;
                    textBox_EmployeeName.Text = selectedEmployee.FullName;
                    textBox_EmployeeName.ReadOnly = true;
                    textBox_EmployeeName.BackColor = SystemColors.Control;
                }
            }
        }

        private void AddJobForm_Load(object sender, EventArgs e)
        {
            // Установка фокуса на первое поле при загрузке формы
            if (selectedEmployee == null)
            {
                button_SelectEmployee.Focus();
            }
            else
            {
                dateTimePicker_StartDate.Focus();
            }
        }
    }
}