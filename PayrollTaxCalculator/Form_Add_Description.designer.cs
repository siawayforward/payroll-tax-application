namespace TaxPayrollPay
{
    partial class AddDescriptionForm
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
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write Description";
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(43, 86);
            this.txtDescp.Multiline = true;
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(701, 224);
            this.txtDescp.TabIndex = 1;
            this.txtDescp.Enter += new System.EventHandler(this.txtDescp_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(596, 341);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 52);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(434, 342);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddDescriptionForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.label1);
            this.Name = "AddDescriptionForm";
            this.Text = "AddDescriptionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDescriptionForm_FormClosing);
            this.Load += new System.EventHandler(this.AddDescriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
    }
}