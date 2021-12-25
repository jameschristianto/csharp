
namespace Forms
{
    partial class Form2
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
            this.lbl_form2 = new System.Windows.Forms.Label();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.btn_form2_dialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_form2
            // 
            this.lbl_form2.AutoSize = true;
            this.lbl_form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form2.Location = new System.Drawing.Point(12, 9);
            this.lbl_form2.Name = "lbl_form2";
            this.lbl_form2.Size = new System.Drawing.Size(208, 29);
            this.lbl_form2.TabIndex = 3;
            this.lbl_form2.Text = "This second form";
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(17, 41);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(120, 35);
            this.btn_form2.TabIndex = 2;
            this.btn_form2.Text = "Form 1";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // btn_form2_dialog
            // 
            this.btn_form2_dialog.Location = new System.Drawing.Point(17, 82);
            this.btn_form2_dialog.Name = "btn_form2_dialog";
            this.btn_form2_dialog.Size = new System.Drawing.Size(120, 35);
            this.btn_form2_dialog.TabIndex = 4;
            this.btn_form2_dialog.Text = "Form 1 Dialog";
            this.btn_form2_dialog.UseVisualStyleBackColor = true;
            this.btn_form2_dialog.Click += new System.EventHandler(this.btn_form2_dialog_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.btn_form2_dialog);
            this.Controls.Add(this.lbl_form2);
            this.Controls.Add(this.btn_form2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_form2;
        private System.Windows.Forms.Button btn_form2;
        private System.Windows.Forms.Button btn_form2_dialog;
    }
}