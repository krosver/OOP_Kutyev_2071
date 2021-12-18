
namespace Work2
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
            this.Drow_panel = new System.Windows.Forms.Panel();
            this.rb_rect = new System.Windows.Forms.RadioButton();
            this.gb_choice = new System.Windows.Forms.GroupBox();
            this.rb_del = new System.Windows.Forms.RadioButton();
            this.rb_move = new System.Windows.Forms.RadioButton();
            this.rb_train = new System.Windows.Forms.RadioButton();
            this.rb_circl = new System.Windows.Forms.RadioButton();
            this.bt_del = new System.Windows.Forms.Button();
            this.Train_box = new System.Windows.Forms.GroupBox();
            this.Cargo_rb = new System.Windows.Forms.RadioButton();
            this.sand_rb = new System.Windows.Forms.RadioButton();
            this.gb_choice.SuspendLayout();
            this.Train_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drow_panel
            // 
            this.Drow_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drow_panel.Location = new System.Drawing.Point(12, 12);
            this.Drow_panel.Name = "Drow_panel";
            this.Drow_panel.Size = new System.Drawing.Size(923, 508);
            this.Drow_panel.TabIndex = 0;
            this.Drow_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Drow_panel_Paint);
            this.Drow_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Drow_panel_MouseClick);
            this.Drow_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drow_panel_MouseDown);
            this.Drow_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drow_panel_MouseUp);
            // 
            // rb_rect
            // 
            this.rb_rect.AutoSize = true;
            this.rb_rect.Location = new System.Drawing.Point(6, 26);
            this.rb_rect.Name = "rb_rect";
            this.rb_rect.Size = new System.Drawing.Size(96, 24);
            this.rb_rect.TabIndex = 1;
            this.rb_rect.TabStop = true;
            this.rb_rect.Text = "Rectangle";
            this.rb_rect.UseVisualStyleBackColor = true;
            this.rb_rect.CheckedChanged += new System.EventHandler(this.rb_rect_CheckedChanged);
            // 
            // gb_choice
            // 
            this.gb_choice.Controls.Add(this.rb_del);
            this.gb_choice.Controls.Add(this.rb_move);
            this.gb_choice.Controls.Add(this.rb_train);
            this.gb_choice.Controls.Add(this.rb_circl);
            this.gb_choice.Controls.Add(this.rb_rect);
            this.gb_choice.Location = new System.Drawing.Point(949, 60);
            this.gb_choice.Name = "gb_choice";
            this.gb_choice.Size = new System.Drawing.Size(148, 172);
            this.gb_choice.TabIndex = 2;
            this.gb_choice.TabStop = false;
            this.gb_choice.Text = "Выбор ";
            // 
            // rb_del
            // 
            this.rb_del.AutoSize = true;
            this.rb_del.Location = new System.Drawing.Point(9, 148);
            this.rb_del.Name = "rb_del";
            this.rb_del.Size = new System.Drawing.Size(74, 24);
            this.rb_del.TabIndex = 5;
            this.rb_del.TabStop = true;
            this.rb_del.Text = "Delete";
            this.rb_del.UseVisualStyleBackColor = true;
            this.rb_del.CheckedChanged += new System.EventHandler(this.rb_del_CheckedChanged);
            // 
            // rb_move
            // 
            this.rb_move.AutoSize = true;
            this.rb_move.Location = new System.Drawing.Point(9, 117);
            this.rb_move.Name = "rb_move";
            this.rb_move.Size = new System.Drawing.Size(67, 24);
            this.rb_move.TabIndex = 4;
            this.rb_move.TabStop = true;
            this.rb_move.Text = "Move";
            this.rb_move.UseVisualStyleBackColor = true;
            this.rb_move.CheckedChanged += new System.EventHandler(this.rb_move_CheckedChanged_1);
            // 
            // rb_train
            // 
            this.rb_train.AutoSize = true;
            this.rb_train.Location = new System.Drawing.Point(7, 87);
            this.rb_train.Name = "rb_train";
            this.rb_train.Size = new System.Drawing.Size(62, 24);
            this.rb_train.TabIndex = 3;
            this.rb_train.TabStop = true;
            this.rb_train.Text = "Train";
            this.rb_train.UseVisualStyleBackColor = true;
            this.rb_train.CheckedChanged += new System.EventHandler(this.rb_train_CheckedChanged);
            // 
            // rb_circl
            // 
            this.rb_circl.AutoSize = true;
            this.rb_circl.Location = new System.Drawing.Point(6, 56);
            this.rb_circl.Name = "rb_circl";
            this.rb_circl.Size = new System.Drawing.Size(67, 24);
            this.rb_circl.TabIndex = 2;
            this.rb_circl.TabStop = true;
            this.rb_circl.Text = "Circle";
            this.rb_circl.UseVisualStyleBackColor = true;
            this.rb_circl.CheckedChanged += new System.EventHandler(this.rb_circl_CheckedChanged);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(970, 474);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(94, 29);
            this.bt_del.TabIndex = 3;
            this.bt_del.Text = "Delete";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // Train_box
            // 
            this.Train_box.Controls.Add(this.Cargo_rb);
            this.Train_box.Controls.Add(this.sand_rb);
            this.Train_box.Location = new System.Drawing.Point(952, 238);
            this.Train_box.Name = "Train_box";
            this.Train_box.Size = new System.Drawing.Size(145, 100);
            this.Train_box.TabIndex = 4;
            this.Train_box.TabStop = false;
            this.Train_box.Text = "Train";
            // 
            // Cargo_rb
            // 
            this.Cargo_rb.AutoSize = true;
            this.Cargo_rb.Location = new System.Drawing.Point(7, 58);
            this.Cargo_rb.Name = "Cargo_rb";
            this.Cargo_rb.Size = new System.Drawing.Size(70, 24);
            this.Cargo_rb.TabIndex = 1;
            this.Cargo_rb.TabStop = true;
            this.Cargo_rb.Text = "Cargo";
            this.Cargo_rb.UseVisualStyleBackColor = true;
            // 
            // sand_rb
            // 
            this.sand_rb.AutoSize = true;
            this.sand_rb.Location = new System.Drawing.Point(7, 27);
            this.sand_rb.Name = "sand_rb";
            this.sand_rb.Size = new System.Drawing.Size(63, 24);
            this.sand_rb.TabIndex = 0;
            this.sand_rb.TabStop = true;
            this.sand_rb.Text = "Sand";
            this.sand_rb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 538);
            this.Controls.Add(this.Train_box);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.gb_choice);
            this.Controls.Add(this.Drow_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_choice.ResumeLayout(false);
            this.gb_choice.PerformLayout();
            this.Train_box.ResumeLayout(false);
            this.Train_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drow_panel;
        private System.Windows.Forms.RadioButton rb_rect;
        private System.Windows.Forms.GroupBox gb_choice;
        private System.Windows.Forms.RadioButton rb_circl;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.RadioButton rb_train;
        private System.Windows.Forms.GroupBox Train_box;
        private System.Windows.Forms.RadioButton Cargo_rb;
        private System.Windows.Forms.RadioButton sand_rb;
        private System.Windows.Forms.RadioButton rb_del;
        private System.Windows.Forms.RadioButton rb_move;
    }
}

