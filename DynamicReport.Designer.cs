
namespace Student_Registration_Form
{
    partial class DynamicReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dynamic_report = new Student_Registration_Form.Dynamic_report();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.com_type = new System.Windows.Forms.ComboBox();
            this.com_subject = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.RegistrationTableAdapter = new Student_Registration_Form.Dynamic_reportTableAdapters.RegistrationTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dynamic_report)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationBindingSource
            // 
            this.RegistrationBindingSource.DataMember = "Registration";
            this.RegistrationBindingSource.DataSource = this.Dynamic_report;
            // 
            // Dynamic_report
            // 
            this.Dynamic_report.DataSetName = "Dynamic_report";
            this.Dynamic_report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkGoldenrod;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RegistrationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Student_Registration_Form.Dynamic_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(41, 171);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1052, 457);
            this.reportViewer1.TabIndex = 0;
            // 
            // com_type
            // 
            this.com_type.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_type.FormattingEnabled = true;
            this.com_type.Items.AddRange(new object[] {
            "Theory class",
            "Revision class"});
            this.com_type.Location = new System.Drawing.Point(285, 103);
            this.com_type.Name = "com_type";
            this.com_type.Size = new System.Drawing.Size(238, 36);
            this.com_type.TabIndex = 29;
            // 
            // com_subject
            // 
            this.com_subject.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_subject.FormattingEnabled = true;
            this.com_subject.Items.AddRange(new object[] {
            "Chinese",
            "Japanese",
            "English",
            "Tamil"});
            this.com_subject.Location = new System.Drawing.Point(285, 43);
            this.com_subject.Name = "com_subject";
            this.com_subject.Size = new System.Drawing.Size(238, 36);
            this.com_subject.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "Class type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Select Subject";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(606, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(153, 62);
            this.btn_Search.TabIndex = 30;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // RegistrationTableAdapter
            // 
            this.RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(832, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 31;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DynamicReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1116, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.com_type);
            this.Controls.Add(this.com_subject);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DynamicReport";
            this.Text = "DynamicReport";
            this.Load += new System.EventHandler(this.DynamicReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dynamic_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox com_type;
        private System.Windows.Forms.ComboBox com_subject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.BindingSource RegistrationBindingSource;
        private Dynamic_report Dynamic_report;
        private Dynamic_reportTableAdapters.RegistrationTableAdapter RegistrationTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}