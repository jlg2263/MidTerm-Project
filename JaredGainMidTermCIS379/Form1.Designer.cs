namespace JaredGainMidTermCIS379
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
            this.officeVisitLabel = new System.Windows.Forms.Label();
            this.medicationsLabel = new System.Windows.Forms.Label();
            this.officeVisitTextBox = new System.Windows.Forms.TextBox();
            this.medicationsTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.discountGroupBox = new System.Windows.Forms.GroupBox();
            this.noDiscountRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeStudentDiscountRadioButton = new System.Windows.Forms.RadioButton();
            this.discountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // officeVisitLabel
            // 
            this.officeVisitLabel.AutoSize = true;
            this.officeVisitLabel.Location = new System.Drawing.Point(54, 28);
            this.officeVisitLabel.Name = "officeVisitLabel";
            this.officeVisitLabel.Size = new System.Drawing.Size(60, 13);
            this.officeVisitLabel.TabIndex = 0;
            this.officeVisitLabel.Text = "Office Visit:";
            // 
            // medicationsLabel
            // 
            this.medicationsLabel.AutoSize = true;
            this.medicationsLabel.Location = new System.Drawing.Point(47, 60);
            this.medicationsLabel.Name = "medicationsLabel";
            this.medicationsLabel.Size = new System.Drawing.Size(67, 13);
            this.medicationsLabel.TabIndex = 1;
            this.medicationsLabel.Text = "Medications:";
            // 
            // officeVisitTextBox
            // 
            this.officeVisitTextBox.Location = new System.Drawing.Point(120, 21);
            this.officeVisitTextBox.Name = "officeVisitTextBox";
            this.officeVisitTextBox.Size = new System.Drawing.Size(100, 20);
            this.officeVisitTextBox.TabIndex = 2;
            // 
            // medicationsTextBox
            // 
            this.medicationsTextBox.Location = new System.Drawing.Point(120, 53);
            this.medicationsTextBox.Name = "medicationsTextBox";
            this.medicationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationsTextBox.TabIndex = 3;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputLabel.Location = new System.Drawing.Point(50, 111);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(170, 77);
            this.outputLabel.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(94, 191);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // discountGroupBox
            // 
            this.discountGroupBox.Controls.Add(this.noDiscountRadioButton);
            this.discountGroupBox.Controls.Add(this.employeeStudentDiscountRadioButton);
            this.discountGroupBox.Location = new System.Drawing.Point(285, 21);
            this.discountGroupBox.Name = "discountGroupBox";
            this.discountGroupBox.Size = new System.Drawing.Size(133, 77);
            this.discountGroupBox.TabIndex = 6;
            this.discountGroupBox.TabStop = false;
            this.discountGroupBox.Text = "Discount";
            // 
            // noDiscountRadioButton
            // 
            this.noDiscountRadioButton.AutoSize = true;
            this.noDiscountRadioButton.Checked = true;
            this.noDiscountRadioButton.Location = new System.Drawing.Point(7, 44);
            this.noDiscountRadioButton.Name = "noDiscountRadioButton";
            this.noDiscountRadioButton.Size = new System.Drawing.Size(84, 17);
            this.noDiscountRadioButton.TabIndex = 1;
            this.noDiscountRadioButton.TabStop = true;
            this.noDiscountRadioButton.Text = "No Discount";
            this.noDiscountRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeStudentDiscountRadioButton
            // 
            this.employeeStudentDiscountRadioButton.AutoSize = true;
            this.employeeStudentDiscountRadioButton.Location = new System.Drawing.Point(7, 20);
            this.employeeStudentDiscountRadioButton.Name = "employeeStudentDiscountRadioButton";
            this.employeeStudentDiscountRadioButton.Size = new System.Drawing.Size(113, 17);
            this.employeeStudentDiscountRadioButton.TabIndex = 0;
            this.employeeStudentDiscountRadioButton.Text = "Employee/Student";
            this.employeeStudentDiscountRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 238);
            this.Controls.Add(this.discountGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.medicationsTextBox);
            this.Controls.Add(this.officeVisitTextBox);
            this.Controls.Add(this.medicationsLabel);
            this.Controls.Add(this.officeVisitLabel);
            this.Name = "Form1";
            this.Text = "Taylor Health and Wellness";
            this.discountGroupBox.ResumeLayout(false);
            this.discountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label officeVisitLabel;
        private System.Windows.Forms.Label medicationsLabel;
        private System.Windows.Forms.TextBox officeVisitTextBox;
        private System.Windows.Forms.TextBox medicationsTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox discountGroupBox;
        private System.Windows.Forms.RadioButton noDiscountRadioButton;
        private System.Windows.Forms.RadioButton employeeStudentDiscountRadioButton;
    }
}

