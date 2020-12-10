namespace Homework
{
    partial class FormSignIn99
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn99));
            this.textuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.labelXXXX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textXXXX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textuser
            // 
            this.textuser.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textuser.Location = new System.Drawing.Point(243, 122);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(375, 57);
            this.textuser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(97, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textpwd
            // 
            this.textpwd.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textpwd.Location = new System.Drawing.Point(243, 185);
            this.textpwd.Name = "textpwd";
            this.textpwd.PasswordChar = '●';
            this.textpwd.Size = new System.Drawing.Size(375, 57);
            this.textpwd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(97, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼：";
            // 
            // btnSignin
            // 
            this.btnSignin.Enabled = false;
            this.btnSignin.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignin.Location = new System.Drawing.Point(441, 397);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(126, 65);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "登入";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // labelXXXX
            // 
            this.labelXXXX.AutoSize = true;
            this.labelXXXX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelXXXX.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXXXX.ForeColor = System.Drawing.Color.White;
            this.labelXXXX.Location = new System.Drawing.Point(244, 248);
            this.labelXXXX.Name = "labelXXXX";
            this.labelXXXX.Size = new System.Drawing.Size(63, 34);
            this.labelXXXX.TabIndex = 1;
            this.labelXXXX.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(60, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 47);
            this.label4.TabIndex = 1;
            this.label4.Text = "驗證碼：";
            // 
            // textXXXX
            // 
            this.textXXXX.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textXXXX.Location = new System.Drawing.Point(426, 248);
            this.textXXXX.Name = "textXXXX";
            this.textXXXX.Size = new System.Drawing.Size(192, 57);
            this.textXXXX.TabIndex = 0;
            this.textXXXX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textXXXX_KeyPress);
            this.textXXXX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textXXXX_KeyUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(365, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "         ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnADD.Location = new System.Drawing.Point(250, 397);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(126, 65);
            this.btnADD.TabIndex = 2;
            this.btnADD.Text = "註冊";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(474, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(316, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 30);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "我已閱讀且同意";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(500, 317);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "使用規範";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "點我";
            // 
            // FormSignIn99
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 563);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.labelXXXX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textXXXX);
            this.Controls.Add(this.textpwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textuser);
            this.Name = "FormSignIn99";
            this.Text = "請登入";
            this.Load += new System.EventHandler(this.FormSignIn99_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label labelXXXX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textXXXX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
    }
}