using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class DeleteEmployeeForm : Form
    {
        private DataSet_main dataSet;
        private DataSet_main.EmployeesRow employeeToDelete;

        public DeleteEmployeeForm(DataSet_main dataSet, DataSet_main.EmployeesRow employee)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.employeeToDelete = employee;

            // Заполняем поля данными выбранного работника
            if (employee != null)
            {
                textBox_FullName.Text = employee.FullName;
                dateTimePicker_BirthDate.Value = employee.BirthDate.Date;
                textBox_INN.Text = employee.INN;
                textBox_PensionCertificate.Text = employee.PensionCertificateNumber;
                textBox_PassportData.Text = employee.PassportData;

                // Делаем поля только для чтения
                SetControlsReadOnly();
            }
        }

        private void SetControlsReadOnly()
        {
            textBox_FullName.ReadOnly = true;
            dateTimePicker_BirthDate.Enabled = false;
            textBox_INN.ReadOnly = true;
            textBox_PensionCertificate.ReadOnly = true;
            textBox_PassportData.ReadOnly = true;

            // Устанавливаем серый фон для наглядности
            textBox_FullName.BackColor = SystemColors.Control;
            dateTimePicker_BirthDate.BackColor = SystemColors.Control;
            textBox_INN.BackColor = SystemColors.Control;
            textBox_PensionCertificate.BackColor = SystemColors.Control;
            textBox_PassportData.BackColor = SystemColors.Control;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (employeeToDelete == null)
            {
                MessageBox.Show("Не выбран работник для удаления!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Проверяем, есть ли связанные записи в таблице Job
                if (employeeToDelete.GetJobRows().Length > 0)
                {
                    var result = MessageBox.Show("У этого работника есть записи о работе. " +
                                               "Все связанные записи также будут удалены. " +
                                               "Продолжить удаление?", "Предупреждение",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                }

                // Удаляем работника (связанные записи удалятся автоматически благодаря каскадному удалению)
                employeeToDelete.Delete();

                dataSet.Employees.AcceptChanges();
                dataSet.Job.AcceptChanges();
                dataSet.WriteXml("DataSet.xml");
                Console.Write("Saved\n");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем фокус на кнопку отмены при загрузке формы
            button_Cancel.Focus();
        }
    }
}