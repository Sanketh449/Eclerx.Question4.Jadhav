namespace Eclerx.Question4.Jadhav
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblEmployeeNo = new System.Windows.Forms.Label();
            this.LblEmployeeName = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtEmployeeId = new System.Windows.Forms.TextBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.TxtReset = new System.Windows.Forms.Button();
            this.TxtEmployeeType = new System.Windows.Forms.GroupBox();
            this.RBtnConsultant = new System.Windows.Forms.RadioButton();
            this.RBtnPayRoll = new System.Windows.Forms.RadioButton();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            this.TxtEmployeeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmployeeNo
            // 
            this.LblEmployeeNo.AutoSize = true;
            this.LblEmployeeNo.Location = new System.Drawing.Point(164, 20);
            this.LblEmployeeNo.Name = "LblEmployeeNo";
            this.LblEmployeeNo.Size = new System.Drawing.Size(70, 13);
            this.LblEmployeeNo.TabIndex = 0;
            this.LblEmployeeNo.Text = "Employee No";
            // 
            // LblEmployeeName
            // 
            this.LblEmployeeName.AutoSize = true;
            this.LblEmployeeName.Location = new System.Drawing.Point(164, 53);
            this.LblEmployeeName.Name = "LblEmployeeName";
            this.LblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.LblEmployeeName.TabIndex = 1;
            this.LblEmployeeName.Text = "Employee Name";
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Location = new System.Drawing.Point(164, 92);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(36, 13);
            this.LblSalary.TabIndex = 2;
            this.LblSalary.Text = "Salary";
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(260, 85);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 20);
            this.TxtSalary.TabIndex = 3;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(260, 50);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeName.TabIndex = 4;
            // 
            // TxtEmployeeId
            // 
            this.TxtEmployeeId.Location = new System.Drawing.Point(260, 20);
            this.TxtEmployeeId.Name = "TxtEmployeeId";
            this.TxtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeId.TabIndex = 5;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(222, 132);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 6;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // TxtReset
            // 
            this.TxtReset.Location = new System.Drawing.Point(339, 132);
            this.TxtReset.Name = "TxtReset";
            this.TxtReset.Size = new System.Drawing.Size(75, 23);
            this.TxtReset.TabIndex = 7;
            this.TxtReset.Text = "Reset";
            this.TxtReset.UseVisualStyleBackColor = true;
            this.TxtReset.Click += new System.EventHandler(this.TxtReset_Click);
            // 
            // TxtEmployeeType
            // 
            this.TxtEmployeeType.Controls.Add(this.RBtnConsultant);
            this.TxtEmployeeType.Controls.Add(this.RBtnPayRoll);
            this.TxtEmployeeType.Location = new System.Drawing.Point(419, 20);
            this.TxtEmployeeType.Name = "TxtEmployeeType";
            this.TxtEmployeeType.Size = new System.Drawing.Size(200, 100);
            this.TxtEmployeeType.TabIndex = 8;
            this.TxtEmployeeType.TabStop = false;
            this.TxtEmployeeType.Text = "Employee Type";
            // 
            // RBtnConsultant
            // 
            this.RBtnConsultant.AutoSize = true;
            this.RBtnConsultant.Location = new System.Drawing.Point(33, 65);
            this.RBtnConsultant.Name = "RBtnConsultant";
            this.RBtnConsultant.Size = new System.Drawing.Size(75, 17);
            this.RBtnConsultant.TabIndex = 9;
            this.RBtnConsultant.TabStop = true;
            this.RBtnConsultant.Text = "Consultant";
            this.RBtnConsultant.UseVisualStyleBackColor = true;
            // 
            // RBtnPayRoll
            // 
            this.RBtnPayRoll.AutoSize = true;
            this.RBtnPayRoll.Location = new System.Drawing.Point(33, 30);
            this.RBtnPayRoll.Name = "RBtnPayRoll";
            this.RBtnPayRoll.Size = new System.Drawing.Size(64, 17);
            this.RBtnPayRoll.TabIndex = 10;
            this.RBtnPayRoll.TabStop = true;
            this.RBtnPayRoll.Text = "Pay Roll";
            this.RBtnPayRoll.UseVisualStyleBackColor = true;
            // 
            // GridEmployee
            // 
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Location = new System.Drawing.Point(29, 161);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.Size = new System.Drawing.Size(671, 182);
            this.GridEmployee.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.TxtEmployeeType);
            this.Controls.Add(this.TxtReset);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.TxtEmployeeId);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.LblEmployeeName);
            this.Controls.Add(this.LblEmployeeNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TxtEmployeeType.ResumeLayout(false);
            this.TxtEmployeeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeNo;
        private System.Windows.Forms.Label LblEmployeeName;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeId;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button TxtReset;
        private System.Windows.Forms.GroupBox TxtEmployeeType;
        private System.Windows.Forms.RadioButton RBtnConsultant;
        private System.Windows.Forms.RadioButton RBtnPayRoll;
        private System.Windows.Forms.DataGridView GridEmployee;
    }
}

