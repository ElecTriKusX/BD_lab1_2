using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    partial class EditEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label_Title;
        private Label label_FullName;
        private TextBox textBox_FullName;
        private Label label_BirthDate;
        private DateTimePicker dateTimePicker_BirthDate;
        private Label label_INN;
        private TextBox textBox_INN;
        private Label label_PensionCertificate;
        private TextBox textBox_PensionCertificate;
        private Label label_PassportData;
        private TextBox textBox_PassportData;
        private Button button_Cancel;
        private Button button_Save;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

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
            this.SuspendLayout();
            // 
            // EditEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load_1);
            this.ResumeLayout(false);

        }
    }
}