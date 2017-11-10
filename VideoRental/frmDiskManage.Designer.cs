﻿namespace VideoRental
{
    partial class frmDiskManage
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
            this.dgvDisk = new System.Windows.Forms.DataGridView();
            this.diskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalDataSet = new VideoRental.VideoRentalDataSet();
            this.tbl_DiskTableAdapter = new VideoRental.VideoRentalDataSetTableAdapters.tbl_DiskTableAdapter();
            this.lblDiskID = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtDiskStatus = new System.Windows.Forms.TextBox();
            this.txtDiskCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisk
            // 
            this.dgvDisk.AutoGenerateColumns = false;
            this.dgvDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diskIDDataGridViewTextBoxColumn,
            this.titleIDDataGridViewTextBoxColumn,
            this.diskStatusDataGridViewTextBoxColumn,
            this.diskCodeDataGridViewTextBoxColumn});
            this.dgvDisk.DataSource = this.tblDiskBindingSource;
            this.dgvDisk.Location = new System.Drawing.Point(46, 105);
            this.dgvDisk.Name = "dgvDisk";
            this.dgvDisk.Size = new System.Drawing.Size(450, 185);
            this.dgvDisk.TabIndex = 0;
            this.dgvDisk.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // diskIDDataGridViewTextBoxColumn
            // 
            this.diskIDDataGridViewTextBoxColumn.DataPropertyName = "DiskID";
            this.diskIDDataGridViewTextBoxColumn.HeaderText = "DiskID";
            this.diskIDDataGridViewTextBoxColumn.Name = "diskIDDataGridViewTextBoxColumn";
            this.diskIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleIDDataGridViewTextBoxColumn
            // 
            this.titleIDDataGridViewTextBoxColumn.DataPropertyName = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.HeaderText = "TitleID";
            this.titleIDDataGridViewTextBoxColumn.Name = "titleIDDataGridViewTextBoxColumn";
            // 
            // diskStatusDataGridViewTextBoxColumn
            // 
            this.diskStatusDataGridViewTextBoxColumn.DataPropertyName = "DiskStatus";
            this.diskStatusDataGridViewTextBoxColumn.HeaderText = "DiskStatus";
            this.diskStatusDataGridViewTextBoxColumn.Name = "diskStatusDataGridViewTextBoxColumn";
            // 
            // diskCodeDataGridViewTextBoxColumn
            // 
            this.diskCodeDataGridViewTextBoxColumn.DataPropertyName = "DiskCode";
            this.diskCodeDataGridViewTextBoxColumn.HeaderText = "DiskCode";
            this.diskCodeDataGridViewTextBoxColumn.Name = "diskCodeDataGridViewTextBoxColumn";
            // 
            // tblDiskBindingSource
            // 
            this.tblDiskBindingSource.DataMember = "tbl_Disk";
            this.tblDiskBindingSource.DataSource = this.videoRentalDataSet;
            // 
            // videoRentalDataSet
            // 
            this.videoRentalDataSet.DataSetName = "VideoRentalDataSet";
            this.videoRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DiskTableAdapter
            // 
            this.tbl_DiskTableAdapter.ClearBeforeFill = true;
            // 
            // lblDiskID
            // 
            this.lblDiskID.AutoSize = true;
            this.lblDiskID.Location = new System.Drawing.Point(46, 25);
            this.lblDiskID.Name = "lblDiskID";
            this.lblDiskID.Size = new System.Drawing.Size(35, 13);
            this.lblDiskID.TabIndex = 1;
            this.lblDiskID.Text = "label1";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Location = new System.Drawing.Point(130, 48);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(100, 20);
            this.txtTitleID.TabIndex = 2;
            // 
            // txtDiskStatus
            // 
            this.txtDiskStatus.Location = new System.Drawing.Point(272, 48);
            this.txtDiskStatus.Name = "txtDiskStatus";
            this.txtDiskStatus.Size = new System.Drawing.Size(100, 20);
            this.txtDiskStatus.TabIndex = 2;
            // 
            // txtDiskCode
            // 
            this.txtDiskCode.Location = new System.Drawing.Point(432, 48);
            this.txtDiskCode.Name = "txtDiskCode";
            this.txtDiskCode.Size = new System.Drawing.Size(100, 20);
            this.txtDiskCode.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmDiskManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 345);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiskCode);
            this.Controls.Add(this.txtDiskStatus);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.lblDiskID);
            this.Controls.Add(this.dgvDisk);
            this.Name = "frmDiskManage";
            this.Text = "frmDiskManage";
            this.Load += new System.EventHandler(this.frmDiskManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisk;
        private VideoRentalDataSet videoRentalDataSet;
        private System.Windows.Forms.BindingSource tblDiskBindingSource;
        private VideoRentalDataSetTableAdapters.tbl_DiskTableAdapter tbl_DiskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDiskID;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.TextBox txtDiskStatus;
        private System.Windows.Forms.TextBox txtDiskCode;
        private System.Windows.Forms.Button btnAdd;
    }
}