﻿namespace Homework
{
    partial class a1FormHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(a1FormHello));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textEname = new System.Windows.Forms.TextBox();
            this.textstar = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radiomale = new System.Windows.Forms.RadioButton();
            this.radiofemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "English Name：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "性別：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "星座：";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(235, 29);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(205, 22);
            this.textname.TabIndex = 1;
            // 
            // textEname
            // 
            this.textEname.Location = new System.Drawing.Point(235, 66);
            this.textEname.Name = "textEname";
            this.textEname.Size = new System.Drawing.Size(205, 22);
            this.textEname.TabIndex = 2;
            // 
            // textstar
            // 
            this.textstar.Location = new System.Drawing.Point(235, 141);
            this.textstar.Name = "textstar";
            this.textstar.Size = new System.Drawing.Size(205, 22);
            this.textstar.TabIndex = 5;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(108, 183);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(126, 38);
            this.btnSayHello.TabIndex = 6;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(314, 183);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(126, 38);
            this.btnSayHi.TabIndex = 7;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSayHi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSayHello);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textstar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textname);
            this.panel1.Controls.Add(this.textEname);
            this.panel1.Location = new System.Drawing.Point(591, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 270);
            this.panel1.TabIndex = 3;
            // 
            // radiomale
            // 
            this.radiomale.AutoSize = true;
            this.radiomale.Location = new System.Drawing.Point(40, 9);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(35, 16);
            this.radiomale.TabIndex = 3;
            this.radiomale.TabStop = true;
            this.radiomale.Text = "男";
            this.radiomale.UseVisualStyleBackColor = true;
            // 
            // radiofemale
            // 
            this.radiofemale.AutoSize = true;
            this.radiofemale.Location = new System.Drawing.Point(130, 9);
            this.radiofemale.Name = "radiofemale";
            this.radiofemale.Size = new System.Drawing.Size(35, 16);
            this.radiofemale.TabIndex = 4;
            this.radiofemale.TabStop = true;
            this.radiofemale.Text = "女";
            this.radiofemale.UseVisualStyleBackColor = true;
            this.radiofemale.CheckedChanged += new System.EventHandler(this.radiofemale_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiomale);
            this.groupBox1.Controls.Add(this.radiofemale);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(235, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 27);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // a1FormHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 841);
            this.Controls.Add(this.panel1);
            this.Name = "a1FormHello";
            this.Text = "你好";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textEname;
        private System.Windows.Forms.TextBox textstar;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiomale;
        private System.Windows.Forms.RadioButton radiofemale;
    }
}