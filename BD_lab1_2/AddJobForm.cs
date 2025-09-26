using System;
using System.Data;
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

            // Проверяем, что работник передан
            if (employee == null)
            {
                MessageBox.Show("Не выбран работник! Пожалуйста, выберите работника в главном окне.", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            // Проверка даты начала 
            if (dateTimePicker_StartDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Дата начала обязательна для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_StartDate.Focus();
                return;
            }

            // Проверка даты окончания 
            if (dateTimePicker_EndDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Дата окончания обязательна для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_EndDate.Focus();
                return;
            }

            // Проверка корректности дат
            if (dateTimePicker_EndDate.Value.Date < dateTimePicker_StartDate.Value.Date)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_EndDate.Focus();
                return;
            }

            // Проверка длины описания 
            if (!string.IsNullOrWhiteSpace(textBox_Description.Text) && textBox_Description.Text.Length > 3000)
            {
                MessageBox.Show("Описание не должно превышать 3000 символов!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Description.Focus();
                return;
            }

            try
            {
                // Создание новой записи
                DataSet_main.JobRow newJob = dataSet.Job.NewJobRow();

                newJob.EmployeeID = selectedEmployee.ID;
                newJob.StartDate = dateTimePicker_StartDate.Value.Date;
                newJob.EndDate = dateTimePicker_EndDate.Value.Date;

                // Описание - опциональное поле
                if (!string.IsNullOrWhiteSpace(textBox_Description.Text))
                    newJob.Description = textBox_Description.Text.Trim();
                else
                    newJob.SetDescriptionNull(); // Явно устанавливаем NULL

                dataSet.Job.AddJobRow(newJob);

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

        private void AddJobForm_Load(object sender, EventArgs e)
        {
            // Установка фокуса на первое поле при загрузке формы
            dateTimePicker_StartDate.Focus();
        }
    }
}
