
namespace Student_Registration_Form
{
    partial class Staticreport
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
            this.Static_report = new Student_Registration_Form.Static_report();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RegistrationTableAdapter = new Student_Registration_Form.Static_reportTableAdapters.RegistrationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Static_report)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationBindingSource
            // 
            this.RegistrationBindingSource.DataMember = "Registration";
            this.RegistrationBindingSource.DataSource = this.Static_report;
            // 
            // Static_report
            // 
            this.Static_report.DataSetName = "Static_report";
            this.Static_report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkGoldenrod;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RegistrationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Student_Registration_Form.Static_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // RegistrationTableAdapter
            // 
            this.RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // Staticreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(943, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Staticreport";
            this.Text = "Static report";
            this.Load += new System.EventHandler(this.Staticreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Static_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RegistrationBindingSource;
        private Static_report Static_report;
        private Static_reportTableAdapters.RegistrationTableAdapter RegistrationTableAdapter;
    }
}