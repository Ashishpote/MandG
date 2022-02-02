namespace MG.SedolChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSEDOL = new System.Windows.Forms.Label();
            this.txtSEDOL = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSEDOL
            // 
            this.lblSEDOL.AutoSize = true;
            this.lblSEDOL.Location = new System.Drawing.Point(28, 38);
            this.lblSEDOL.Name = "lblSEDOL";
            this.lblSEDOL.Size = new System.Drawing.Size(76, 15);
            this.lblSEDOL.TabIndex = 0;
            this.lblSEDOL.Text = "SEDOL Input:";
            // 
            // txtSEDOL
            // 
            this.txtSEDOL.Location = new System.Drawing.Point(119, 30);
            this.txtSEDOL.Name = "txtSEDOL";
            this.txtSEDOL.Size = new System.Drawing.Size(236, 23);
            this.txtSEDOL.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(392, 26);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 29);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 295);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtSEDOL);
            this.Controls.Add(this.lblSEDOL);
            this.Name = "Form1";
            this.Text = "SEDOL_CHECKER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSEDOL;
        private System.Windows.Forms.TextBox txtSEDOL;
        private System.Windows.Forms.Button btnValidate;
    }
}
