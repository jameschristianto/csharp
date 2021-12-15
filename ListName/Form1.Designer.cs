
namespace ListName
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
            this.lb_name = new System.Windows.Forms.ListBox();
            this.lbl_new = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ascending = new System.Windows.Forms.Button();
            this.btn_descending = new System.Windows.Forms.Button();
            this.btn_clear_list = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_save_to = new System.Windows.Forms.Button();
            this.btn_load_from = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.FormattingEnabled = true;
            this.lb_name.ItemHeight = 20;
            this.lb_name.Location = new System.Drawing.Point(12, 12);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(286, 424);
            this.lb_name.TabIndex = 0;
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new.Location = new System.Drawing.Point(306, 12);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(100, 25);
            this.lbl_new.TabIndex = 1;
            this.lbl_new.Text = "Add new :";
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(311, 40);
            this.tb_name.MaxLength = 30;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(374, 30);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(311, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 39);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(412, 76);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 39);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ascending
            // 
            this.btn_ascending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ascending.Location = new System.Drawing.Point(311, 393);
            this.btn_ascending.Name = "btn_ascending";
            this.btn_ascending.Size = new System.Drawing.Size(95, 39);
            this.btn_ascending.TabIndex = 5;
            this.btn_ascending.Text = "A to Z";
            this.btn_ascending.UseVisualStyleBackColor = true;
            this.btn_ascending.Click += new System.EventHandler(this.btn_ascending_Click);
            // 
            // btn_descending
            // 
            this.btn_descending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descending.Location = new System.Drawing.Point(412, 393);
            this.btn_descending.Name = "btn_descending";
            this.btn_descending.Size = new System.Drawing.Size(95, 39);
            this.btn_descending.TabIndex = 6;
            this.btn_descending.Text = "Z to A";
            this.btn_descending.UseVisualStyleBackColor = true;
            this.btn_descending.Click += new System.EventHandler(this.btn_descending_Click);
            // 
            // btn_clear_list
            // 
            this.btn_clear_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_list.Location = new System.Drawing.Point(513, 393);
            this.btn_clear_list.Name = "btn_clear_list";
            this.btn_clear_list.Size = new System.Drawing.Size(95, 39);
            this.btn_clear_list.TabIndex = 7;
            this.btn_clear_list.Text = "Clear";
            this.btn_clear_list.UseVisualStyleBackColor = true;
            this.btn_clear_list.Click += new System.EventHandler(this.btn_clear_list_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(311, 166);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 39);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(412, 166);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(95, 39);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(513, 121);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 39);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_up);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(412, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_down);
            // 
            // btn_save_to
            // 
            this.btn_save_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_to.Location = new System.Drawing.Point(311, 211);
            this.btn_save_to.Name = "btn_save_to";
            this.btn_save_to.Size = new System.Drawing.Size(95, 39);
            this.btn_save_to.TabIndex = 13;
            this.btn_save_to.Text = "Save...";
            this.btn_save_to.UseVisualStyleBackColor = true;
            this.btn_save_to.Click += new System.EventHandler(this.btn_save_to_Click);
            // 
            // btn_load_from
            // 
            this.btn_load_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_from.Location = new System.Drawing.Point(412, 211);
            this.btn_load_from.Name = "btn_load_from";
            this.btn_load_from.Size = new System.Drawing.Size(95, 39);
            this.btn_load_from.TabIndex = 14;
            this.btn_load_from.Text = "Load...";
            this.btn_load_from.UseVisualStyleBackColor = true;
            this.btn_load_from.Click += new System.EventHandler(this.btn_load_from_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.btn_load_from);
            this.Controls.Add(this.btn_save_to);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear_list);
            this.Controls.Add(this.btn_descending);
            this.Controls.Add(this.btn_ascending);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_new);
            this.Controls.Add(this.lb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_name;
        private System.Windows.Forms.Label lbl_new;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ascending;
        private System.Windows.Forms.Button btn_descending;
        private System.Windows.Forms.Button btn_clear_list;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save_to;
        private System.Windows.Forms.Button btn_load_from;
    }
}

