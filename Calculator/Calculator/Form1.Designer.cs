
namespace Calculator
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
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_calcul = new System.Windows.Forms.GroupBox();
            this.bt_reduction = new System.Windows.Forms.Button();
            this.bt_multi = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_subtract = new System.Windows.Forms.Button();
            this.bt_sum = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.Box1.SuspendLayout();
            this.Box2.SuspendLayout();
            this.Box_calcul.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.tb_2);
            this.Box1.Controls.Add(this.tb_1);
            this.Box1.Location = new System.Drawing.Point(60, 98);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(115, 119);
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(6, 72);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(103, 27);
            this.tb_2.TabIndex = 1;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(6, 26);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(103, 27);
            this.tb_1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // Box2
            // 
            this.Box2.Controls.Add(this.tb_4);
            this.Box2.Controls.Add(this.tb_3);
            this.Box2.Location = new System.Drawing.Point(242, 98);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(115, 119);
            this.Box2.TabIndex = 2;
            this.Box2.TabStop = false;
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(6, 72);
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(103, 27);
            this.tb_4.TabIndex = 1;
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(6, 26);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(103, 27);
            this.tb_3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(373, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // Box_calcul
            // 
            this.Box_calcul.Controls.Add(this.bt_reduction);
            this.Box_calcul.Controls.Add(this.bt_multi);
            this.Box_calcul.Controls.Add(this.bt_div);
            this.Box_calcul.Controls.Add(this.bt_subtract);
            this.Box_calcul.Controls.Add(this.bt_sum);
            this.Box_calcul.Location = new System.Drawing.Point(60, 255);
            this.Box_calcul.Name = "Box_calcul";
            this.Box_calcul.Size = new System.Drawing.Size(319, 118);
            this.Box_calcul.TabIndex = 4;
            this.Box_calcul.TabStop = false;
            this.Box_calcul.Text = "Операции";
            // 
            // bt_reduction
            // 
            this.bt_reduction.Location = new System.Drawing.Point(202, 26);
            this.bt_reduction.Name = "bt_reduction";
            this.bt_reduction.Size = new System.Drawing.Size(95, 73);
            this.bt_reduction.TabIndex = 4;
            this.bt_reduction.Text = "Reduction";
            this.bt_reduction.UseVisualStyleBackColor = true;
            this.bt_reduction.Click += new System.EventHandler(this.bt_reduction_Click);
            // 
            // bt_multi
            // 
            this.bt_multi.Location = new System.Drawing.Point(103, 70);
            this.bt_multi.Name = "bt_multi";
            this.bt_multi.Size = new System.Drawing.Size(70, 29);
            this.bt_multi.TabIndex = 3;
            this.bt_multi.Text = "*";
            this.bt_multi.UseVisualStyleBackColor = true;
            this.bt_multi.Click += new System.EventHandler(this.bt_multi_Click);
            // 
            // bt_div
            // 
            this.bt_div.Location = new System.Drawing.Point(103, 26);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(70, 29);
            this.bt_div.TabIndex = 2;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // bt_subtract
            // 
            this.bt_subtract.Location = new System.Drawing.Point(15, 70);
            this.bt_subtract.Name = "bt_subtract";
            this.bt_subtract.Size = new System.Drawing.Size(70, 29);
            this.bt_subtract.TabIndex = 1;
            this.bt_subtract.Text = "-";
            this.bt_subtract.UseVisualStyleBackColor = true;
            this.bt_subtract.Click += new System.EventHandler(this.bt_subtract_Click);
            // 
            // bt_sum
            // 
            this.bt_sum.Location = new System.Drawing.Point(15, 26);
            this.bt_sum.Name = "bt_sum";
            this.bt_sum.Size = new System.Drawing.Size(70, 29);
            this.bt_sum.TabIndex = 0;
            this.bt_sum.Text = "+";
            this.bt_sum.UseVisualStyleBackColor = true;
            this.bt_sum.Click += new System.EventHandler(this.bt_sum_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(412, 143);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(376, 27);
            this.tb_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.Box_calcul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.Box2.ResumeLayout(false);
            this.Box2.PerformLayout();
            this.Box_calcul.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Box_calcul;
        private System.Windows.Forms.Button bt_reduction;
        private System.Windows.Forms.Button bt_multi;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_subtract;
        private System.Windows.Forms.Button bt_sum;
        private System.Windows.Forms.TextBox tb_result;
    }
}

