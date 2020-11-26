namespace Homework
{
    partial class a2FormLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(a2FormLoan));
            this.btncalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclean = new System.Windows.Forms.Button();
            this.textmoney = new System.Windows.Forms.TextBox();
            this.textpercent = new System.Windows.Forms.TextBox();
            this.textmon = new System.Windows.Forms.TextBox();
            this.textotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textallloan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncalculate.Location = new System.Drawing.Point(95, 309);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(134, 57);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "計算";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "貸款金額($)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(505, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "每期應繳金額：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(39, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "年利率(％)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(39, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "貸款期數(月)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(39, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "全部利息($)：";
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclean.Location = new System.Drawing.Point(259, 309);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(134, 57);
            this.btnclean.TabIndex = 5;
            this.btnclean.Text = "清除";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // textmoney
            // 
            this.textmoney.Location = new System.Drawing.Point(209, 30);
            this.textmoney.Name = "textmoney";
            this.textmoney.Size = new System.Drawing.Size(184, 22);
            this.textmoney.TabIndex = 1;
            // 
            // textpercent
            // 
            this.textpercent.Location = new System.Drawing.Point(209, 82);
            this.textpercent.Name = "textpercent";
            this.textpercent.Size = new System.Drawing.Size(184, 22);
            this.textpercent.TabIndex = 2;
            // 
            // textmon
            // 
            this.textmon.Location = new System.Drawing.Point(209, 134);
            this.textmon.Name = "textmon";
            this.textmon.Size = new System.Drawing.Size(184, 22);
            this.textmon.TabIndex = 3;
            // 
            // textotal
            // 
            this.textotal.AcceptsReturn = true;
            this.textotal.AcceptsTab = true;
            this.textotal.Location = new System.Drawing.Point(510, 65);
            this.textotal.Multiline = true;
            this.textotal.Name = "textotal";
            this.textotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textotal.Size = new System.Drawing.Size(240, 340);
            this.textotal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textotal);
            this.panel1.Controls.Add(this.btncalculate);
            this.panel1.Controls.Add(this.textallloan);
            this.panel1.Controls.Add(this.textmon);
            this.panel1.Controls.Add(this.btnclean);
            this.panel1.Controls.Add(this.textpercent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textmoney);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(995, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 447);
            this.panel1.TabIndex = 6;
            // 
            // textallloan
            // 
            this.textallloan.Location = new System.Drawing.Point(209, 186);
            this.textallloan.Name = "textallloan";
            this.textallloan.Size = new System.Drawing.Size(184, 22);
            this.textallloan.TabIndex = 3;
            // 
            // a2FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1819, 821);
            this.Controls.Add(this.panel1);
            this.Name = "a2FormLoan";
            this.Text = "利息計算";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.TextBox textmoney;
        private System.Windows.Forms.TextBox textpercent;
        private System.Windows.Forms.TextBox textmon;
        private System.Windows.Forms.TextBox textotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textallloan;
    }
}