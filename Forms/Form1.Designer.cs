
namespace Forms
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
            this.btn_form1 = new System.Windows.Forms.Button();
            this.lbl_form1 = new System.Windows.Forms.Label();
            this.btn_form1_doalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form1
            // 
            this.btn_form1.Location = new System.Drawing.Point(17, 41);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(120, 35);
            this.btn_form1.TabIndex = 0;
            this.btn_form1.Text = "Form 2";
            this.btn_form1.UseVisualStyleBackColor = true;
            this.btn_form1.Click += new System.EventHandler(this.btn_form1_Click);
            // 
            // lbl_form1
            // 
            this.lbl_form1.AutoSize = true;
            this.lbl_form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form1.Location = new System.Drawing.Point(12, 9);
            this.lbl_form1.Name = "lbl_form1";
            this.lbl_form1.Size = new System.Drawing.Size(167, 29);
            this.lbl_form1.TabIndex = 1;
            this.lbl_form1.Text = "This first form";
            // 
            // btn_form1_doalog
            // 
            this.btn_form1_doalog.Location = new System.Drawing.Point(17, 82);
            this.btn_form1_doalog.Name = "btn_form1_doalog";
            this.btn_form1_doalog.Size = new System.Drawing.Size(120, 35);
            this.btn_form1_doalog.TabIndex = 2;
            this.btn_form1_doalog.Text = "Form 2 Dialog";
            this.btn_form1_doalog.UseVisualStyleBackColor = true;
            this.btn_form1_doalog.Click += new System.EventHandler(this.btn_form1_doalog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.btn_form1_doalog);
            this.Controls.Add(this.lbl_form1);
            this.Controls.Add(this.btn_form1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Label lbl_form1;
        private System.Windows.Forms.Button btn_form1_doalog;
    }
}

