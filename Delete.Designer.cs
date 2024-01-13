
namespace Student_Registration_Form
{
    partial class Delete
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_ExitDel = new System.Windows.Forms.Button();
            this.btn_ClearDel = new System.Windows.Forms.Button();
            this.btn_Dele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(295, 89);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(270, 37);
            this.txt_ID.TabIndex = 23;
            // 
            // btn_ExitDel
            // 
            this.btn_ExitDel.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ExitDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExitDel.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitDel.Location = new System.Drawing.Point(519, 257);
            this.btn_ExitDel.Name = "btn_ExitDel";
            this.btn_ExitDel.Size = new System.Drawing.Size(142, 53);
            this.btn_ExitDel.TabIndex = 26;
            this.btn_ExitDel.Text = "Exit";
            this.btn_ExitDel.UseVisualStyleBackColor = false;
            this.btn_ExitDel.Click += new System.EventHandler(this.btn_ExitDel_Click);
            // 
            // btn_ClearDel
            // 
            this.btn_ClearDel.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ClearDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClearDel.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearDel.Location = new System.Drawing.Point(295, 257);
            this.btn_ClearDel.Name = "btn_ClearDel";
            this.btn_ClearDel.Size = new System.Drawing.Size(142, 53);
            this.btn_ClearDel.TabIndex = 25;
            this.btn_ClearDel.Text = "Clear";
            this.btn_ClearDel.UseVisualStyleBackColor = false;
            this.btn_ClearDel.Click += new System.EventHandler(this.btn_ClearDel_Click);
            // 
            // btn_Dele
            // 
            this.btn_Dele.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Dele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dele.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dele.Location = new System.Drawing.Point(67, 257);
            this.btn_Dele.Name = "btn_Dele";
            this.btn_Dele.Size = new System.Drawing.Size(142, 53);
            this.btn_Dele.TabIndex = 24;
            this.btn_Dele.Text = "Delete";
            this.btn_Dele.UseVisualStyleBackColor = false;
            this.btn_Dele.Click += new System.EventHandler(this.btn_Dele_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(692, 427);
            this.Controls.Add(this.btn_ExitDel);
            this.Controls.Add(this.btn_ClearDel);
            this.Controls.Add(this.btn_Dele);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_ExitDel;
        private System.Windows.Forms.Button btn_ClearDel;
        private System.Windows.Forms.Button btn_Dele;
    }
}