
namespace JSON
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.tb_hobbies = new System.Windows.Forms.TextBox();
            this.lbl_hobbies = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(22, 24);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 20);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(26, 49);
            this.tb_id.MaxLength = 10;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(378, 26);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(26, 112);
            this.tb_name.MaxLength = 20;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(378, 26);
            this.tb_name.TabIndex = 3;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(22, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 20);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "NAME";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(22, 151);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(81, 20);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "GENDER";
            // 
            // tb_age
            // 
            this.tb_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_age.Location = new System.Drawing.Point(26, 239);
            this.tb_age.MaxLength = 3;
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(378, 26);
            this.tb_age.TabIndex = 7;
            this.tb_age.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_age_KeyPress);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(22, 214);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(44, 20);
            this.lbl_age.TabIndex = 6;
            this.lbl_age.Text = "AGE";
            // 
            // tb_hobbies
            // 
            this.tb_hobbies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hobbies.Location = new System.Drawing.Point(26, 303);
            this.tb_hobbies.MaxLength = 30;
            this.tb_hobbies.Name = "tb_hobbies";
            this.tb_hobbies.Size = new System.Drawing.Size(378, 26);
            this.tb_hobbies.TabIndex = 9;
            this.tb_hobbies.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_hobbies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_hobbies_KeyPress);
            // 
            // lbl_hobbies
            // 
            this.lbl_hobbies.AutoSize = true;
            this.lbl_hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hobbies.Location = new System.Drawing.Point(22, 278);
            this.lbl_hobbies.Name = "lbl_hobbies";
            this.lbl_hobbies.Size = new System.Drawing.Size(85, 20);
            this.lbl_hobbies.TabIndex = 8;
            this.lbl_hobbies.Text = "HOBBIES";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(305, 365);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 48);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(200, 365);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 48);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cb_gender.Location = new System.Drawing.Point(26, 174);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(378, 28);
            this.cb_gender.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 442);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_hobbies);
            this.Controls.Add(this.lbl_hobbies);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox tb_hobbies;
        private System.Windows.Forms.Label lbl_hobbies;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_gender;
    }
}

