namespace Homework
{
    partial class a8FormCalc1
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
            this.labelresult = new System.Windows.Forms.Label();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnpercent = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btntrue = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btngen = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btnchen = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.labelnum1 = new System.Windows.Forms.Label();
            this.labelnum2 = new System.Windows.Forms.Label();
            this.labelsign = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelresult
            // 
            this.labelresult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelresult.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelresult.ForeColor = System.Drawing.Color.Lime;
            this.labelresult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelresult.Location = new System.Drawing.Point(12, 9);
            this.labelresult.Name = "labelresult";
            this.labelresult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelresult.Size = new System.Drawing.Size(245, 85);
            this.labelresult.TabIndex = 24;
            this.labelresult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnresult.Location = new System.Drawing.Point(138, 398);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(120, 53);
            this.btnresult.TabIndex = 22;
            this.btnresult.Text = "=";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnpercent
            // 
            this.btnpercent.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpercent.Location = new System.Drawing.Point(201, 280);
            this.btnpercent.Name = "btnpercent";
            this.btnpercent.Size = new System.Drawing.Size(57, 53);
            this.btnpercent.TabIndex = 21;
            this.btnpercent.Text = "%";
            this.btnpercent.UseVisualStyleBackColor = true;
            this.btnpercent.Click += new System.EventHandler(this.btnpercent_Click);
            // 
            // btnpow
            // 
            this.btnpow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpow.Location = new System.Drawing.Point(201, 340);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(57, 53);
            this.btnpow.TabIndex = 20;
            this.btnpow.Text = "^";
            this.btnpow.UseVisualStyleBackColor = true;
            this.btnpow.Click += new System.EventHandler(this.btnpow_Click);
            // 
            // btntrue
            // 
            this.btntrue.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntrue.Location = new System.Drawing.Point(75, 163);
            this.btntrue.Name = "btntrue";
            this.btntrue.Size = new System.Drawing.Size(57, 53);
            this.btntrue.TabIndex = 19;
            this.btntrue.Text = "/";
            this.btntrue.UseVisualStyleBackColor = true;
            this.btntrue.Click += new System.EventHandler(this.btncount);
            // 
            // btnSign
            // 
            this.btnSign.Enabled = false;
            this.btnSign.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSign.Location = new System.Drawing.Point(83, 21);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(57, 53);
            this.btnSign.TabIndex = 18;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(12, 163);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(57, 53);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btngen
            // 
            this.btngen.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngen.Location = new System.Drawing.Point(201, 221);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(57, 53);
            this.btngen.TabIndex = 16;
            this.btngen.Text = "-";
            this.btngen.UseVisualStyleBackColor = true;
            this.btngen.Click += new System.EventHandler(this.btncount);
            // 
            // btnchia
            // 
            this.btnchia.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnchia.Location = new System.Drawing.Point(201, 163);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(57, 53);
            this.btnchia.TabIndex = 15;
            this.btnchia.Text = "+";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btncount);
            // 
            // btnchen
            // 
            this.btnchen.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnchen.Location = new System.Drawing.Point(138, 162);
            this.btnchen.Name = "btnchen";
            this.btnchen.Size = new System.Drawing.Size(57, 53);
            this.btnchen.TabIndex = 4;
            this.btnchen.Text = "*";
            this.btnchen.UseVisualStyleBackColor = true;
            this.btnchen.Click += new System.EventHandler(this.btncount);
            // 
            // btnpoint
            // 
            this.btnpoint.Enabled = false;
            this.btnpoint.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpoint.Location = new System.Drawing.Point(11, 21);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(57, 53);
            this.btnpoint.TabIndex = 13;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.Click += new System.EventHandler(this.numclick);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn0.Location = new System.Drawing.Point(75, 398);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 53);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numclick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn9.Location = new System.Drawing.Point(138, 339);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 53);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numclick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn8.Location = new System.Drawing.Point(75, 339);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 53);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numclick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn7.Location = new System.Drawing.Point(12, 340);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 53);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numclick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn6.Location = new System.Drawing.Point(138, 280);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 53);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numclick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn5.Location = new System.Drawing.Point(75, 280);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 53);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numclick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(12, 281);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 53);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numclick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(138, 221);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 53);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numclick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(75, 221);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 53);
            this.btn2.TabIndex = 23;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numclick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(12, 222);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 53);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numclick);
            // 
            // labelnum1
            // 
            this.labelnum1.AutoSize = true;
            this.labelnum1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelnum1.Location = new System.Drawing.Point(153, 106);
            this.labelnum1.Name = "labelnum1";
            this.labelnum1.Size = new System.Drawing.Size(0, 19);
            this.labelnum1.TabIndex = 26;
            // 
            // labelnum2
            // 
            this.labelnum2.AutoSize = true;
            this.labelnum2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelnum2.Location = new System.Drawing.Point(152, 127);
            this.labelnum2.Name = "labelnum2";
            this.labelnum2.Size = new System.Drawing.Size(0, 19);
            this.labelnum2.TabIndex = 26;
            // 
            // labelsign
            // 
            this.labelsign.AutoSize = true;
            this.labelsign.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelsign.Location = new System.Drawing.Point(80, 126);
            this.labelsign.Name = "labelsign";
            this.labelsign.Size = new System.Drawing.Size(0, 19);
            this.labelsign.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSign);
            this.groupBox1.Controls.Add(this.btnpoint);
            this.groupBox1.Location = new System.Drawing.Point(75, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 84);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待新增";
            // 
            // a8FormCalc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelsign);
            this.Controls.Add(this.labelnum2);
            this.Controls.Add(this.labelnum1);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btnpercent);
            this.Controls.Add(this.btnpow);
            this.Controls.Add(this.btntrue);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnchen);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "a8FormCalc1";
            this.Text = "簡易計算機";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnpercent;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btntrue;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btnchen;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label labelnum1;
        private System.Windows.Forms.Label labelnum2;
        private System.Windows.Forms.Label labelsign;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}