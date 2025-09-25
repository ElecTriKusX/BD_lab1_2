using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class EditJobForm : Form
    {
        private DataSet_main dataSet;
        private DataSet_main.JobRow jobToEdit;

        public EditJobForm(DataSet_main dataSet, DataSet_main.JobRow job)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.jobToEdit = job;

            // Заполняем поля данными выбранной работы
            if (job != null)
            {
                dateTimePicker_StartDate.Value = job.StartDate.Date;
                dateTimePicker_EndDate.Value = job.EndDate.Date;
                textBox_Description.Text = job.IsDescriptionNull() ? string.Empty : job.Description;

                // Получаем ФИО работника
                var employee = dataSet.Employees.FirstOrDefault(emp => emp.ID == job.EmployeeID);
                if (employee != null)
                {
                    textBox_EmployeeName.Text = employee.FullName;
                }

                // Делаем поля ID и EmployeeID только для чтения
                SetIDControlsReadOnly();
            }
        }

        private void SetIDControlsReadOnly()
        {
            textBox_EmployeeName.ReadOnly = true;
            textBox_EmployeeName.BackColor = SystemColors.Control;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (jobToEdit == null)
            {
                MessageBox.Show("Не выбрана работа для редактирования!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка обязательных полей
            if (dateTimePicker_StartDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Дата начала обязательна для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_StartDate.Focus();
                return;
            }

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

            // Проверка описания (опциональное поле)
            if (!string.IsNullOrWhiteSpace(textBox_Description.Text) && textBox_Description.Text.Length > 3000)
            {
                MessageBox.Show("Описание не должно превышать 3000 символов!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Description.Focus();
                return;
            }

            try
            {
                // Обновляем данные работы
                jobToEdit.BeginEdit();
                jobToEdit.StartDate = dateTimePicker_StartDate.Value.Date;
                jobToEdit.EndDate = dateTimePicker_EndDate.Value.Date;

                // Описание - опциональное поле
                if (!string.IsNullOrWhiteSpace(textBox_Description.Text))
                    jobToEdit.Description = textBox_Description.Text.Trim();
                else
                    jobToEdit.SetDescriptionNull();

                jobToEdit.EndEdit();

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

        private void EditJobForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем фокус на поле даты начала при загрузке формы
            dateTimePicker_StartDate.Focus();
        }

        private void button_SelectEmployee_Click(object sender, EventArgs e)
        {
            using (var selectForm = new SelectEmployeeForm(dataSet))
            {
                if (selectForm.ShowDialog() == DialogResult.OK && selectForm.SelectedEmployee != null)
                {
                    var selectedEmployee = selectForm.SelectedEmployee;
                    textBox_EmployeeName.Text = selectedEmployee.FullName;

                    // Обновляем EmployeeID в редактируемой записи
                    if (jobToEdit != null)
                    {
                        jobToEdit.BeginEdit();
                        jobToEdit.EmployeeID = selectedEmployee.ID;
                        jobToEdit.EndEdit();
                    }
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}