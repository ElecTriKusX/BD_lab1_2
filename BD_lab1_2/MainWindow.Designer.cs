namespace BD_lab1_2
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_main = new BD_lab1_2.DataSet_main();
            this.dataGridView_Job = new System.Windows.Forms.DataGridView();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_Employee = new System.Windows.Forms.GroupBox();
            this.groupBox_Job = new System.Windows.Forms.GroupBox();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pensionCertificateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_EmployeeAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_EmployeeEdit = new System.Windows.Forms.Button();
            this.button_EmployeeDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_JobDelete = new System.Windows.Forms.Button();
            this.button_JobEdit = new System.Windows.Forms.Button();
            this.button_JobAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Job)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.groupBox_Employee.SuspendLayout();
            this.groupBox_Job.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.AllowUserToAddRows = false;
            this.dataGridView_Employee.AllowUserToDeleteRows = false;
            this.dataGridView_Employee.AllowUserToResizeColumns = false;
            this.dataGridView_Employee.AllowUserToResizeRows = false;
            this.dataGridView_Employee.AutoGenerateColumns = false;
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.pensionCertificateNumberDataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn});
            this.dataGridView_Employee.DataSource = this.employeesBindingSource;
            this.dataGridView_Employee.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.Size = new System.Drawing.Size(738, 225);
            this.dataGridView_Employee.TabIndex = 0;
            this.dataGridView_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dataSet_main;
            // 
            // dataSet_main
            // 
            this.dataSet_main.DataSetName = "DataSet_main";
            this.dataSet_main.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Job
            // 
            this.dataGridView_Job.AllowUserToAddRows = false;
            this.dataGridView_Job.AllowUserToDeleteRows = false;
            this.dataGridView_Job.AllowUserToResizeColumns = false;
            this.dataGridView_Job.AllowUserToResizeRows = false;
            this.dataGridView_Job.AutoGenerateColumns = false;
            this.dataGridView_Job.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Job.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.employeeIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView_Job.DataSource = this.jobBindingSource;
            this.dataGridView_Job.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Job.Name = "dataGridView_Job";
            this.dataGridView_Job.Size = new System.Drawing.Size(738, 225);
            this.dataGridView_Job.TabIndex = 1;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dataSet_main;
            // 
            // groupBox_Employee
            // 
            this.groupBox_Employee.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Employee.Controls.Add(this.dataGridView_Employee);
            this.groupBox_Employee.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Employee.Name = "groupBox_Employee";
            this.groupBox_Employee.Size = new System.Drawing.Size(975, 250);
            this.groupBox_Employee.TabIndex = 2;
            this.groupBox_Employee.TabStop = false;
            this.groupBox_Employee.Text = "Работники";
            this.groupBox_Employee.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox_Job
            // 
            this.groupBox_Job.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_Job.Controls.Add(this.dataGridView_Job);
            this.groupBox_Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Job.Location = new System.Drawing.Point(12, 268);
            this.groupBox_Job.Name = "groupBox_Job";
            this.groupBox_Job.Size = new System.Drawing.Size(975, 250);
            this.groupBox_Job.TabIndex = 3;
            this.groupBox_Job.TabStop = false;
            this.groupBox_Job.Text = "Работы";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата начала работы";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата окончания работы";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 370;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО работника";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.Width = 120;
            // 
            // pensionCertificateNumberDataGridViewTextBoxColumn
            // 
            this.pensionCertificateNumberDataGridViewTextBoxColumn.DataPropertyName = "PensionCertificateNumber";
            this.pensionCertificateNumberDataGridViewTextBoxColumn.HeaderText = "№ пенсионного страхового свидетельства";
            this.pensionCertificateNumberDataGridViewTextBoxColumn.Name = "pensionCertificateNumberDataGridViewTextBoxColumn";
            this.pensionCertificateNumberDataGridViewTextBoxColumn.Width = 180;
            // 
            // passportDataDataGridViewTextBoxColumn
            // 
            this.passportDataDataGridViewTextBoxColumn.DataPropertyName = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.passportDataDataGridViewTextBoxColumn.Name = "passportDataDataGridViewTextBoxColumn";
            this.passportDataDataGridViewTextBoxColumn.Width = 145;
            // 
            // button_EmployeeAdd
            // 
            this.button_EmployeeAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EmployeeAdd.Location = new System.Drawing.Point(0, 0);
            this.button_EmployeeAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button_EmployeeAdd.Name = "button_EmployeeAdd";
            this.button_EmployeeAdd.Size = new System.Drawing.Size(221, 72);
            this.button_EmployeeAdd.TabIndex = 5;
            this.button_EmployeeAdd.Text = "Добавить работника";
            this.button_EmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_EmployeeDelete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_EmployeeEdit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_EmployeeAdd, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(750, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 225);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button_EmployeeEdit
            // 
            this.button_EmployeeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EmployeeEdit.Location = new System.Drawing.Point(0, 76);
            this.button_EmployeeEdit.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button_EmployeeEdit.Name = "button_EmployeeEdit";
            this.button_EmployeeEdit.Size = new System.Drawing.Size(221, 70);
            this.button_EmployeeEdit.TabIndex = 6;
            this.button_EmployeeEdit.Text = "Редактировать работника";
            this.button_EmployeeEdit.UseVisualStyleBackColor = true;
            // 
            // button_EmployeeDelete
            // 
            this.button_EmployeeDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EmployeeDelete.Location = new System.Drawing.Point(0, 150);
            this.button_EmployeeDelete.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button_EmployeeDelete.Name = "button_EmployeeDelete";
            this.button_EmployeeDelete.Size = new System.Drawing.Size(221, 75);
            this.button_EmployeeDelete.TabIndex = 7;
            this.button_EmployeeDelete.Text = "Удалить работника";
            this.button_EmployeeDelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button_JobDelete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_JobEdit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_JobAdd, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(750, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 225);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // button_JobDelete
            // 
            this.button_JobDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_JobDelete.Location = new System.Drawing.Point(0, 150);
            this.button_JobDelete.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button_JobDelete.Name = "button_JobDelete";
            this.button_JobDelete.Size = new System.Drawing.Size(221, 75);
            this.button_JobDelete.TabIndex = 7;
            this.button_JobDelete.Text = "Удалить работу";
            this.button_JobDelete.UseVisualStyleBackColor = true;
            // 
            // button_JobEdit
            // 
            this.button_JobEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_JobEdit.Location = new System.Drawing.Point(0, 76);
            this.button_JobEdit.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button_JobEdit.Name = "button_JobEdit";
            this.button_JobEdit.Size = new System.Drawing.Size(221, 70);
            this.button_JobEdit.TabIndex = 6;
            this.button_JobEdit.Text = "Редактировать работу";
            this.button_JobEdit.UseVisualStyleBackColor = true;
            // 
            // button_JobAdd
            // 
            this.button_JobAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_JobAdd.Location = new System.Drawing.Point(0, 0);
            this.button_JobAdd.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button_JobAdd.Name = "button_JobAdd";
            this.button_JobAdd.Size = new System.Drawing.Size(221, 72);
            this.button_JobAdd.TabIndex = 5;
            this.button_JobAdd.Text = "Добавить работу";
            this.button_JobAdd.UseVisualStyleBackColor = true;
            this.button_JobAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 531);
            this.Controls.Add(this.groupBox_Job);
            this.Controls.Add(this.groupBox_Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Job)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.groupBox_Employee.ResumeLayout(false);
            this.groupBox_Job.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DataSet_main dataSet_main;
        private System.Windows.Forms.DataGridView dataGridView_Job;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.GroupBox groupBox_Employee;
        private System.Windows.Forms.GroupBox groupBox_Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pensionCertificateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_EmployeeAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_EmployeeEdit;
        private System.Windows.Forms.Button button_EmployeeDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_JobDelete;
        private System.Windows.Forms.Button button_JobEdit;
        private System.Windows.Forms.Button button_JobAdd;
    }
}

