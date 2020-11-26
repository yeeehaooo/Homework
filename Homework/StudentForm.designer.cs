namespace WindowsFormsApp1
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkeyIN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textenglish = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textchinese = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textup = new System.Windows.Forms.TextBox();
            this.textdown = new System.Windows.Forms.TextBox();
            this.labelresult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "//2.\r\n//成績單\r\n//Grid_View\r\n//請你建一個 StudentData 的Class\r\n//可以讓使用者輸入 姓名 國文 英文 數學\r\n//之" +
    "後把結果用在GridView\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_name,
            this.dgv_chinese,
            this.dgv_math,
            this.dgv_english,
            this.btnupdate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 574);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_name
            // 
            this.dgv_name.DataPropertyName = "stuName";
            this.dgv_name.HeaderText = "姓名";
            this.dgv_name.Name = "dgv_name";
            // 
            // dgv_chinese
            // 
            this.dgv_chinese.DataPropertyName = "stuChinese";
            this.dgv_chinese.HeaderText = "國文";
            this.dgv_chinese.Name = "dgv_chinese";
            // 
            // dgv_math
            // 
            this.dgv_math.DataPropertyName = "stuMath";
            this.dgv_math.HeaderText = "數學";
            this.dgv_math.Name = "dgv_math";
            // 
            // dgv_english
            // 
            this.dgv_english.DataPropertyName = "stuEnglish";
            this.dgv_english.HeaderText = "英文";
            this.dgv_english.Name = "dgv_english";
            // 
            // btnupdate
            // 
            this.btnupdate.DataPropertyName = "stuName";
            this.btnupdate.HeaderText = "";
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Text = "修改";
            this.btnupdate.UseColumnTextForButtonValue = true;
            this.btnupdate.Width = 50;
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textname.Location = new System.Drawing.Point(59, 19);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 25);
            this.textname.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkeyIN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textenglish);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textchinese);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Location = new System.Drawing.Point(717, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績輸入";
            // 
            // btnkeyIN
            // 
            this.btnkeyIN.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnkeyIN.Location = new System.Drawing.Point(84, 143);
            this.btnkeyIN.Name = "btnkeyIN";
            this.btnkeyIN.Size = new System.Drawing.Size(75, 25);
            this.btnkeyIN.TabIndex = 4;
            this.btnkeyIN.Text = "輸入";
            this.btnkeyIN.UseVisualStyleBackColor = true;
            this.btnkeyIN.Click += new System.EventHandler(this.btnkeyIN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "英文";
            // 
            // textenglish
            // 
            this.textenglish.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textenglish.Location = new System.Drawing.Point(59, 81);
            this.textenglish.Name = "textenglish";
            this.textenglish.Size = new System.Drawing.Size(100, 25);
            this.textenglish.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsearch.Location = new System.Drawing.Point(165, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(69, 25);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "查詢";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "國文";
            // 
            // textchinese
            // 
            this.textchinese.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textchinese.Location = new System.Drawing.Point(59, 50);
            this.textchinese.Name = "textchinese";
            this.textchinese.Size = new System.Drawing.Size(100, 25);
            this.textchinese.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.textup);
            this.groupBox2.Controls.Add(this.textdown);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(717, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜尋";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "國文",
            "英文",
            "數學",
            "自然"});
            this.listBox1.Location = new System.Drawing.Point(63, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 21);
            this.listBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(156, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "分";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "科目：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(70, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "~";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button7.Location = new System.Drawing.Point(184, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 24);
            this.button7.TabIndex = 2;
            this.button7.Text = "查詢";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textup
            // 
            this.textup.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textup.Location = new System.Drawing.Point(92, 63);
            this.textup.Name = "textup";
            this.textup.Size = new System.Drawing.Size(58, 25);
            this.textup.TabIndex = 0;
            // 
            // textdown
            // 
            this.textdown.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textdown.Location = new System.Drawing.Point(6, 63);
            this.textdown.Name = "textdown";
            this.textdown.Size = new System.Drawing.Size(58, 25);
            this.textdown.TabIndex = 0;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelresult.Location = new System.Drawing.Point(713, 450);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(74, 21);
            this.labelresult.TabIndex = 12;
            this.labelresult.Text = "查詢結果";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(59, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "數學";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 598);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textenglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textchinese;
        private System.Windows.Forms.Button btnkeyIN;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textup;
        private System.Windows.Forms.TextBox textdown;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_math;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_english;
        private System.Windows.Forms.DataGridViewButtonColumn btnupdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}