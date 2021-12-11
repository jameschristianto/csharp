
namespace TemperatureConvertion
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
            this.lbl_fahrenheit = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.lbl_celcius = new System.Windows.Forms.Label();
            this.btn_fahrenheit = new System.Windows.Forms.Button();
            this.btn_celcius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.tb_fahrenheit = new System.Windows.Forms.TextBox();
            this.tb_celcius = new System.Windows.Forms.TextBox();
            this.tb_kelvin = new System.Windows.Forms.TextBox();
            this.tb_rankine = new System.Windows.Forms.TextBox();
            this.btn_rankine = new System.Windows.Forms.Button();
            this.lbl_rankine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_fahrenheit
            // 
            this.lbl_fahrenheit.AutoSize = true;
            this.lbl_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fahrenheit.Location = new System.Drawing.Point(30, 35);
            this.lbl_fahrenheit.Name = "lbl_fahrenheit";
            this.lbl_fahrenheit.Size = new System.Drawing.Size(143, 29);
            this.lbl_fahrenheit.TabIndex = 0;
            this.lbl_fahrenheit.Text = "Fahrenheit";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kelvin.Location = new System.Drawing.Point(30, 197);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(89, 29);
            this.lbl_kelvin.TabIndex = 1;
            this.lbl_kelvin.Text = "Kelvin";
            // 
            // lbl_celcius
            // 
            this.lbl_celcius.AutoSize = true;
            this.lbl_celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celcius.Location = new System.Drawing.Point(30, 116);
            this.lbl_celcius.Name = "lbl_celcius";
            this.lbl_celcius.Size = new System.Drawing.Size(104, 29);
            this.lbl_celcius.TabIndex = 2;
            this.lbl_celcius.Text = "Celcius";
            // 
            // btn_fahrenheit
            // 
            this.btn_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_fahrenheit.Location = new System.Drawing.Point(384, 37);
            this.btn_fahrenheit.Name = "btn_fahrenheit";
            this.btn_fahrenheit.Size = new System.Drawing.Size(90, 29);
            this.btn_fahrenheit.TabIndex = 3;
            this.btn_fahrenheit.Text = "convert";
            this.btn_fahrenheit.UseVisualStyleBackColor = true;
            this.btn_fahrenheit.Click += new System.EventHandler(this.btn_fahrenheit_Click);
            // 
            // btn_celcius
            // 
            this.btn_celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_celcius.Location = new System.Drawing.Point(384, 118);
            this.btn_celcius.Name = "btn_celcius";
            this.btn_celcius.Size = new System.Drawing.Size(90, 29);
            this.btn_celcius.TabIndex = 4;
            this.btn_celcius.Text = "convert";
            this.btn_celcius.UseVisualStyleBackColor = true;
            this.btn_celcius.Click += new System.EventHandler(this.btn_celcius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_kelvin.Location = new System.Drawing.Point(384, 199);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(90, 29);
            this.btn_kelvin.TabIndex = 5;
            this.btn_kelvin.Text = "convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // tb_fahrenheit
            // 
            this.tb_fahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fahrenheit.Location = new System.Drawing.Point(194, 37);
            this.tb_fahrenheit.MaxLength = 8;
            this.tb_fahrenheit.Name = "tb_fahrenheit";
            this.tb_fahrenheit.Size = new System.Drawing.Size(168, 30);
            this.tb_fahrenheit.TabIndex = 6;
            this.tb_fahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_fahrenheit_KeyPress);
            // 
            // tb_celcius
            // 
            this.tb_celcius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_celcius.Location = new System.Drawing.Point(194, 118);
            this.tb_celcius.MaxLength = 8;
            this.tb_celcius.Name = "tb_celcius";
            this.tb_celcius.Size = new System.Drawing.Size(168, 30);
            this.tb_celcius.TabIndex = 7;
            this.tb_celcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_celcius_KeyPress);
            // 
            // tb_kelvin
            // 
            this.tb_kelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kelvin.Location = new System.Drawing.Point(194, 199);
            this.tb_kelvin.MaxLength = 8;
            this.tb_kelvin.Name = "tb_kelvin";
            this.tb_kelvin.Size = new System.Drawing.Size(168, 30);
            this.tb_kelvin.TabIndex = 8;
            this.tb_kelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kelvin_KeyPress);
            // 
            // tb_rankine
            // 
            this.tb_rankine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_rankine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rankine.Location = new System.Drawing.Point(194, 280);
            this.tb_rankine.MaxLength = 8;
            this.tb_rankine.Name = "tb_rankine";
            this.tb_rankine.Size = new System.Drawing.Size(168, 30);
            this.tb_rankine.TabIndex = 11;
            // 
            // btn_rankine
            // 
            this.btn_rankine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_rankine.Location = new System.Drawing.Point(384, 280);
            this.btn_rankine.Name = "btn_rankine";
            this.btn_rankine.Size = new System.Drawing.Size(90, 29);
            this.btn_rankine.TabIndex = 10;
            this.btn_rankine.Text = "convert";
            this.btn_rankine.UseVisualStyleBackColor = true;
            this.btn_rankine.Click += new System.EventHandler(this.btn_rankine_Click);
            this.btn_rankine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_rankine_KeyPress);
            // 
            // lbl_rankine
            // 
            this.lbl_rankine.AutoSize = true;
            this.lbl_rankine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rankine.Location = new System.Drawing.Point(30, 278);
            this.lbl_rankine.Name = "lbl_rankine";
            this.lbl_rankine.Size = new System.Drawing.Size(113, 29);
            this.lbl_rankine.TabIndex = 9;
            this.lbl_rankine.Text = "Rankine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 383);
            this.Controls.Add(this.tb_rankine);
            this.Controls.Add(this.btn_rankine);
            this.Controls.Add(this.lbl_rankine);
            this.Controls.Add(this.tb_kelvin);
            this.Controls.Add(this.tb_celcius);
            this.Controls.Add(this.tb_fahrenheit);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celcius);
            this.Controls.Add(this.btn_fahrenheit);
            this.Controls.Add(this.lbl_celcius);
            this.Controls.Add(this.lbl_kelvin);
            this.Controls.Add(this.lbl_fahrenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fahrenheit;
        private System.Windows.Forms.Label lbl_kelvin;
        private System.Windows.Forms.Label lbl_celcius;
        private System.Windows.Forms.Button btn_fahrenheit;
        private System.Windows.Forms.Button btn_celcius;
        private System.Windows.Forms.Button btn_kelvin;
        private System.Windows.Forms.TextBox tb_fahrenheit;
        private System.Windows.Forms.TextBox tb_celcius;
        private System.Windows.Forms.TextBox tb_kelvin;
        private System.Windows.Forms.TextBox tb_rankine;
        private System.Windows.Forms.Button btn_rankine;
        private System.Windows.Forms.Label lbl_rankine;
    }
}

