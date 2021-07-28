
using System;
using System.Windows.Forms;

namespace DisplayCSVFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgViewDisplayCSV = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbxDisplayName = new System.Windows.Forms.ComboBox();
            this.btnDisplayID = new System.Windows.Forms.Button();
            this.cmbxLanguage = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDisplayCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewDisplayCSV
            // 
            resources.ApplyResources(this.dgViewDisplayCSV, "dgViewDisplayCSV");
            this.dgViewDisplayCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewDisplayCSV.Name = "dgViewDisplayCSV";
            this.dgViewDisplayCSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewDisplayCSV_CellContentClick);
            this.dgViewDisplayCSV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgViewDisplayCSV_DataError);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbxDisplayName
            // 
            resources.ApplyResources(this.cmbxDisplayName, "cmbxDisplayName");
            this.cmbxDisplayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDisplayName.FormattingEnabled = true;
            this.cmbxDisplayName.Name = "cmbxDisplayName";
            // 
            // btnDisplayID
            // 
            resources.ApplyResources(this.btnDisplayID, "btnDisplayID");
            this.btnDisplayID.Name = "btnDisplayID";
            this.btnDisplayID.UseVisualStyleBackColor = true;
            this.btnDisplayID.Click += new System.EventHandler(this.btnDisplayID_Click);
            // 
            // cmbxLanguage
            // 
            resources.ApplyResources(this.cmbxLanguage, "cmbxLanguage");
            this.cmbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLanguage.FormattingEnabled = true;
            this.cmbxLanguage.Items.AddRange(new object[] {
            resources.GetString("cmbxLanguage.Items"),
            resources.GetString("cmbxLanguage.Items1"),
            resources.GetString("cmbxLanguage.Items2")});
            this.cmbxLanguage.Name = "cmbxLanguage";
            this.cmbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbxLanguage_SelectedIndexChanged);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblLang
            // 
            resources.ApplyResources(this.lblLang, "lblLang");
            this.lblLang.Name = "lblLang";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbxLanguage);
            this.Controls.Add(this.btnDisplayID);
            this.Controls.Add(this.cmbxDisplayName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgViewDisplayCSV);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDisplayCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgViewDisplayCSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewDisplayCSV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbxDisplayName;
        private System.Windows.Forms.Button btnDisplayID;
        private ComboBox cmbxLanguage;
        private Label lblName;
        private Label lblLang;
    }
}

