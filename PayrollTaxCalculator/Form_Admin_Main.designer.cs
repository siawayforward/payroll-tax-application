namespace TaxPayrollPay
{
    partial class adminHomeForm
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
            this.btnSiteLinkUpdates = new System.Windows.Forms.Button();
            this.btnContactUpdate = new System.Windows.Forms.Button();
            this.btnTaxRateUpdate = new System.Windows.Forms.Button();
            this.btnViewFeeback = new System.Windows.Forms.Button();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = " Administator Updates";
            // 
            // btnSiteLinkUpdates
            // 
            this.btnSiteLinkUpdates.Location = new System.Drawing.Point(223, 153);
            this.btnSiteLinkUpdates.Name = "btnSiteLinkUpdates";
            this.btnSiteLinkUpdates.Size = new System.Drawing.Size(450, 48);
            this.btnSiteLinkUpdates.TabIndex = 1;
            this.btnSiteLinkUpdates.Text = "Update &Helpful link and About Us";
            this.btnSiteLinkUpdates.UseVisualStyleBackColor = true;
            this.btnSiteLinkUpdates.Click += new System.EventHandler(this.btnSiteLinkUpdates_Click);
            // 
            // btnContactUpdate
            // 
            this.btnContactUpdate.Location = new System.Drawing.Point(223, 225);
            this.btnContactUpdate.Name = "btnContactUpdate";
            this.btnContactUpdate.Size = new System.Drawing.Size(450, 48);
            this.btnContactUpdate.TabIndex = 2;
            this.btnContactUpdate.Text = "Update &Contact Information";
            this.btnContactUpdate.UseVisualStyleBackColor = true;
            this.btnContactUpdate.Click += new System.EventHandler(this.btnContactUpdate_Click);
            // 
            // btnTaxRateUpdate
            // 
            this.btnTaxRateUpdate.Location = new System.Drawing.Point(223, 299);
            this.btnTaxRateUpdate.Name = "btnTaxRateUpdate";
            this.btnTaxRateUpdate.Size = new System.Drawing.Size(450, 48);
            this.btnTaxRateUpdate.TabIndex = 3;
            this.btnTaxRateUpdate.Text = "Update &Federal and State Tax Rate ";
            this.btnTaxRateUpdate.UseVisualStyleBackColor = true;
            this.btnTaxRateUpdate.Click += new System.EventHandler(this.btnTaxRateUpdate_Click);
            // 
            // btnViewFeeback
            // 
            this.btnViewFeeback.Location = new System.Drawing.Point(223, 372);
            this.btnViewFeeback.Name = "btnViewFeeback";
            this.btnViewFeeback.Size = new System.Drawing.Size(450, 48);
            this.btnViewFeeback.TabIndex = 4;
            this.btnViewFeeback.Text = "&View Feedback";
            this.btnViewFeeback.UseVisualStyleBackColor = true;
            this.btnViewFeeback.Click += new System.EventHandler(this.btnViewFeeback_Click);
            // 
            // btnlogOut
            // 
            this.btnlogOut.Location = new System.Drawing.Point(223, 450);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(450, 48);
            this.btnlogOut.TabIndex = 5;
            this.btnlogOut.Text = "&LogOut";
            this.btnlogOut.UseVisualStyleBackColor = true;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // adminHomeForm
            // 
            this.AcceptButton = this.btnSiteLinkUpdates;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.btnViewFeeback);
            this.Controls.Add(this.btnTaxRateUpdate);
            this.Controls.Add(this.btnContactUpdate);
            this.Controls.Add(this.btnSiteLinkUpdates);
            this.Controls.Add(this.label1);
            this.Name = "adminHomeForm";
            this.Text = "Admin Home Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminHomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiteLinkUpdates;
        private System.Windows.Forms.Button btnContactUpdate;
        private System.Windows.Forms.Button btnTaxRateUpdate;
        private System.Windows.Forms.Button btnViewFeeback;
        private System.Windows.Forms.Button btnlogOut;
    }
}

