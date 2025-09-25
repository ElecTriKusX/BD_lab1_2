using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class DeleteJobForm : Form
    {
        private DataSet_main dataSet;
        private DataSet_main.JobRow jobToDelete;

        public DeleteJobForm(DataSet_main dataSet, DataSet_main.JobRow job)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.jobToDelete = job;

            // Заполняем поля данными выбранной работы
            if (job != null)
            {
                dateTimePicker_StartDate.Value = job.StartDate;
                dateTimePicker_EndDate.Value = job.EndDate;
                textBox_Description.Text = job.IsDescriptionNull() ? string.Empty : job.Description;

                // Получаем ФИО работника (исправленная строка)
                var employee = dataSet.Employees.FirstOrDefault(emp => emp.ID == job.EmployeeID);
                if (employee != null)
                {
                    textBox_EmployeeName.Text = employee.FullName;
                }

                // Делаем поля только для чтения
                SetControlsReadOnly();
            }
        }

        // Остальной код без изменений...
        private void SetControlsReadOnly()
        {
            textBox_EmployeeName.ReadOnly = true;
            dateTimePicker_StartDate.Enabled = false;
            dateTimePicker_EndDate.Enabled = false;
            textBox_Description.ReadOnly = true;

            // Устанавливаем серый фон для наглядности
            textBox_EmployeeName.BackColor = SystemColors.Control;
            dateTimePicker_StartDate.BackColor = SystemColors.Control;
            dateTimePicker_EndDate.BackColor = SystemColors.Control;
            textBox_Description.BackColor = SystemColors.Control;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (jobToDelete == null)
            {
                MessageBox.Show("Не выбрана работа для удаления!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Подтверждение удаления
                var result = MessageBox.Show("Вы уверены, что хотите удалить эту запись о работе?",
                                           "Подтверждение удаления",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                // Удаляем работу
                jobToDelete.Delete();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteJobForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем фокус на кнопку отмены при загрузке формы
            button_Cancel.Focus();
        }
    }
}