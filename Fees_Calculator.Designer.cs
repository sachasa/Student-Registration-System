
namespace Student_Registration_Form
{
    partial class Fees_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com_SubjectCal = new System.Windows.Forms.ComboBox();
            this.com_ClassCal = new System.Windows.Forms.ComboBox();
            this.txt_Fees = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clearCal = new System.Windows.Forms.Button();
            this.btn_ExitCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fees";
            // 
            // com_SubjectCal
            // 
            this.com_SubjectCal.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_SubjectCal.FormattingEnabled = true;
            this.com_SubjectCal.Items.AddRange(new object[] {
            "Chinese",
            "Japanese",
            "English",
            "Tamil"});
            this.com_SubjectCal.Location = new System.Drawing.Point(395, 37);
            this.com_SubjectCal.Name = "com_SubjectCal";
            this.com_SubjectCal.Size = new System.Drawing.Size(203, 42);
            this.com_SubjectCal.TabIndex = 3;
            // 
            // com_ClassCal
            // 
            this.com_ClassCal.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_ClassCal.FormattingEnabled = true;
            this.com_ClassCal.Items.AddRange(new object[] {
            "Theory class",
            "Revision class"});
            this.com_ClassCal.Location = new System.Drawing.Point(395, 116);
            this.com_ClassCal.Name = "com_ClassCal";
            this.com_ClassCal.Size = new System.Drawing.Size(203, 42);
            this.com_ClassCal.TabIndex = 4;
            // 
            // txt_Fees
            // 
            this.txt_Fees.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fees.Location = new System.Drawing.Point(395, 203);
            this.txt_Fees.Name = "txt_Fees";
            this.txt_Fees.ReadOnly = true;
            this.txt_Fees.Size = new System.Drawing.Size(164, 40);
            this.txt_Fees.TabIndex = 5;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calculate.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(97, 371);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(166, 48);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calcutate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clearCal
            // 
            this.btn_clearCal.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_clearCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearCal.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearCal.Location = new System.Drawing.Point(306, 371);
            this.btn_clearCal.Name = "btn_clearCal";
            this.btn_clearCal.Size = new System.Drawing.Size(166, 48);
            this.btn_clearCal.TabIndex = 7;
            this.btn_clearCal.Text = "Clear";
            this.btn_clearCal.UseVisualStyleBackColor = false;
            this.btn_clearCal.Click += new System.EventHandler(this.btn_clearCal_Click);
            // 
            // btn_ExitCal
            // 
            this.btn_ExitCal.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ExitCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExitCal.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitCal.Location = new System.Drawing.Point(513, 371);
            this.btn_ExitCal.Name = "btn_ExitCal";
            this.btn_ExitCal.Size = new System.Drawing.Size(166, 48);
            this.btn_ExitCal.TabIndex = 8;
            this.btn_ExitCal.Text = "Exit";
            this.btn_ExitCal.UseVisualStyleBackColor = false;
            this.btn_ExitCal.Click += new System.EventHandler(this.btn_ExitCal_Click);
            // 
            // Fees_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ExitCal);
            this.Controls.Add(this.btn_clearCal);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_Fees);
            this.Controls.Add(this.com_ClassCal);
            this.Controls.Add(this.com_SubjectCal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fees_Calculator";
            this.Text = "Fees Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_SubjectCal;
        private System.Windows.Forms.ComboBox com_ClassCal;
        private System.Windows.Forms.TextBox txt_Fees;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clearCal;
        private System.Windows.Forms.Button btn_ExitCal;
    }
}