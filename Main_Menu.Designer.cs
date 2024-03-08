
namespace Student_Registration_Form
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_DynReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(345, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 685);
            this.panel1.TabIndex = 0;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_apply.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Location = new System.Drawing.Point(38, 12);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(265, 89);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_cal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cal.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.Location = new System.Drawing.Point(38, 137);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(265, 89);
            this.btn_cal.TabIndex = 2;
            this.btn_cal.Text = "Fees calculator";
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 89);
            this.button2.TabIndex = 4;
            this.button2.Text = "Time Table";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_DynReport
            // 
            this.btn_DynReport.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_DynReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DynReport.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DynReport.Location = new System.Drawing.Point(38, 539);
            this.btn_DynReport.Name = "btn_DynReport";
            this.btn_DynReport.Size = new System.Drawing.Size(265, 89);
            this.btn_DynReport.TabIndex = 5;
            this.btn_DynReport.Text = "Dynamic Report";
            this.btn_DynReport.UseVisualStyleBackColor = false;
            this.btn_DynReport.Click += new System.EventHandler(this.btn_DynReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "Static Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(976, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DynReport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_DynReport;
        private System.Windows.Forms.Button button1;
    }
}