﻿namespace DES_En
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_M = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_CM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_M
            // 
            this.textBox_M.Location = new System.Drawing.Point(74, 50);
            this.textBox_M.Multiline = true;
            this.textBox_M.Name = "textBox_M";
            this.textBox_M.Size = new System.Drawing.Size(182, 111);
            this.textBox_M.TabIndex = 0;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(389, 50);
            this.textBox_Key.Multiline = true;
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(182, 111);
            this.textBox_Key.TabIndex = 0;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(74, 226);
            this.textBox_C.Multiline = true;
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(182, 111);
            this.textBox_C.TabIndex = 0;
            // 
            // textBox_CM
            // 
            this.textBox_CM.Location = new System.Drawing.Point(389, 226);
            this.textBox_CM.Multiline = true;
            this.textBox_CM.Name = "textBox_CM";
            this.textBox_CM.Size = new System.Drawing.Size(182, 111);
            this.textBox_CM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密钥";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "密文";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "明文";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "加密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "解密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CM);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_M);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_M;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_CM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

