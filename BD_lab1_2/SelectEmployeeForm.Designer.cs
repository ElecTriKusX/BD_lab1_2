using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    partial class SelectEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView_Employees;
        private Button button_Cancel;
        private Button button_Select;
        private TableLayoutPanel tableLayoutPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView_Employees = new System.Windows.Forms.DataGridView();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Select = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.AllowUserToAddRows = false;
            this.dataGridView_Employees.AllowUserToDeleteRows = false;
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Employees.Location = new System.Drawing.Point(10, 10);
            this.dataGridView_Employees.MultiSelect = false;
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.ReadOnly = true;
            this.dataGridView_Employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Employees.Size = new System.Drawing.Size(480, 250);
            this.dataGridView_Employees.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(3, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(234, 34);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Select
            // 
            this.button_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Select.Location = new System.Drawing.Point(243, 3);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(234, 34);
            this.button_Select.TabIndex = 2;
            this.button_Select.Text = "Выбрать";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Select, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 260);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SelectEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 310);
            this.Controls.Add(this.dataGridView_Employees);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор работника";
            this.Load += new System.EventHandler(this.SelectEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}