namespace TaxPayrollPay
{
    partial class Helpful_Links_and_AboutUs_Frm
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
            this.btnAddDesp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbHelpfulLink = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLinks = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbHelpfulLink.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDesp
            // 
            this.btnAddDesp.Location = new System.Drawing.Point(295, 139);
            this.btnAddDesp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddDesp.Name = "btnAddDesp";
            this.btnAddDesp.Size = new System.Drawing.Size(367, 35);
            this.btnAddDesp.TabIndex = 2;
            this.btnAddDesp.Text = "Upload &New Description";
            this.btnAddDesp.UseVisualStyleBackColor = true;
            this.btnAddDesp.Click += new System.EventHandler(this.btnAddDesp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "About Us:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Home Page Detail Update";
            // 
            // gbHelpfulLink
            // 
            this.gbHelpfulLink.Controls.Add(this.txtTitle);
            this.gbHelpfulLink.Controls.Add(this.label5);
            this.gbHelpfulLink.Controls.Add(this.txtLinks);
            this.gbHelpfulLink.Controls.Add(this.btnUpload);
            this.gbHelpfulLink.Controls.Add(this.label4);
            this.gbHelpfulLink.Controls.Add(this.label3);
            this.gbHelpfulLink.Controls.Add(this.cmbType);
            this.gbHelpfulLink.Location = new System.Drawing.Point(118, 199);
            this.gbHelpfulLink.Name = "gbHelpfulLink";
            this.gbHelpfulLink.Size = new System.Drawing.Size(544, 232);
            this.gbHelpfulLink.TabIndex = 0;
            this.gbHelpfulLink.TabStop = false;
            this.gbHelpfulLink.Text = "Helpful Links";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(170, 90);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(351, 26);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Enter += new System.EventHandler(this.selectAllMethod);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Title";
            // 
            // txtLinks
            // 
            this.txtLinks.Location = new System.Drawing.Point(170, 133);
            this.txtLinks.Name = "txtLinks";
            this.txtLinks.Size = new System.Drawing.Size(351, 26);
            this.txtLinks.TabIndex = 0;
            this.txtLinks.Enter += new System.EventHandler(this.selectAllMethod);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(409, 189);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(112, 35);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "&Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Links";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(170, 39);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(351, 28);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(595, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Helpful_Links_and_AboutUs_Frm
            // 
            this.AcceptButton = this.btnUpload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 496);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbHelpfulLink);
            this.Controls.Add(this.btnAddDesp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Helpful_Links_and_AboutUs_Frm";
            this.Text = "Helpful_Links_and_AboutUs_Frm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Helpful_Links_and_AboutUs_Frm_FormClosing);
            this.Load += new System.EventHandler(this.Helpful_Links_and_AboutUs_Frm_Load);
            this.gbHelpfulLink.ResumeLayout(false);
            this.gbHelpfulLink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddDesp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbHelpfulLink;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtLinks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
    }
}