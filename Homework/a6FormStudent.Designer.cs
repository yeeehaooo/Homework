namespace Homework
{
    partial class a6FormStudent
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsearch1 = new System.Windows.Forms.Button();
            this.textup = new System.Windows.Forms.TextBox();
            this.textdown = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkeyIN = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butrmd = new System.Windows.Forms.Button();
            this.textenglish = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textmath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textchinese = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.btncount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelsingle = new System.Windows.Forms.Label();
            this.btnlie = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelresult.Location = new System.Drawing.Point(269, 145);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(90, 21);
            this.labelresult.TabIndex = 17;
            this.labelresult.Text = "查詢結果：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnsearch1);
            this.groupBox2.Controls.Add(this.textup);
            this.groupBox2.Controls.Add(this.textdown);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 103);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜尋";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(116, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "分";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "科目：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(52, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "~";
            // 
            // btnsearch1
            // 
            this.btnsearch1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnsearch1.Location = new System.Drawing.Point(144, 70);
            this.btnsearch1.Name = "btnsearch1";
            this.btnsearch1.Size = new System.Drawing.Size(79, 24);
            this.btnsearch1.TabIndex = 2;
            this.btnsearch1.Text = "範圍查詢";
            this.btnsearch1.UseVisualStyleBackColor = true;
            this.btnsearch1.Click += new System.EventHandler(this.btnsearch1_Click);
            // 
            // textup
            // 
            this.textup.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textup.Location = new System.Drawing.Point(73, 70);
            this.textup.Name = "textup";
            this.textup.Size = new System.Drawing.Size(40, 25);
            this.textup.TabIndex = 0;
            // 
            // textdown
            // 
            this.textdown.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textdown.Location = new System.Drawing.Point(9, 70);
            this.textdown.Name = "textdown";
            this.textdown.Size = new System.Drawing.Size(40, 25);
            this.textdown.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkeyIN);
            this.groupBox1.Controls.Add(this.btn20);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.butrmd);
            this.groupBox1.Controls.Add(this.textenglish);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textmath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textchinese);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 208);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績輸入";
            // 
            // btnkeyIN
            // 
            this.btnkeyIN.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnkeyIN.Location = new System.Drawing.Point(58, 147);
            this.btnkeyIN.Name = "btnkeyIN";
            this.btnkeyIN.Size = new System.Drawing.Size(100, 25);
            this.btnkeyIN.TabIndex = 4;
            this.btnkeyIN.Text = "輸入";
            this.btnkeyIN.UseVisualStyleBackColor = true;
            this.btnkeyIN.Click += new System.EventHandler(this.btnkeyIN_Click);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn20.Location = new System.Drawing.Point(14, 177);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(86, 25);
            this.btn20.TabIndex = 4;
            this.btn20.Text = "隨機輸入";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "英文";
            // 
            // butrmd
            // 
            this.butrmd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butrmd.Location = new System.Drawing.Point(121, 177);
            this.butrmd.Name = "butrmd";
            this.butrmd.Size = new System.Drawing.Size(118, 25);
            this.butrmd.TabIndex = 4;
            this.butrmd.Text = "隨機輸入20筆";
            this.butrmd.UseVisualStyleBackColor = true;
            this.butrmd.Click += new System.EventHandler(this.butrmd_Click);
            // 
            // textenglish
            // 
            this.textenglish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textenglish.Location = new System.Drawing.Point(58, 81);
            this.textenglish.Name = "textenglish";
            this.textenglish.Size = new System.Drawing.Size(100, 29);
            this.textenglish.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsearch.Location = new System.Drawing.Point(164, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 25);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "查詢";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(10, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "數學";
            // 
            // textmath
            // 
            this.textmath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textmath.Location = new System.Drawing.Point(58, 112);
            this.textmath.Name = "textmath";
            this.textmath.Size = new System.Drawing.Size(100, 29);
            this.textmath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "國文";
            // 
            // textchinese
            // 
            this.textchinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textchinese.Location = new System.Drawing.Point(58, 50);
            this.textchinese.Name = "textchinese";
            this.textchinese.Size = new System.Drawing.Size(100, 29);
            this.textchinese.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textname.Location = new System.Drawing.Point(58, 18);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 29);
            this.textname.TabIndex = 2;
            // 
            // btncount
            // 
            this.btncount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncount.Location = new System.Drawing.Point(282, 117);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 25);
            this.btncount.TabIndex = 4;
            this.btncount.Text = "統計";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_name,
            this.dgv_chinese,
            this.dgv_english,
            this.dgv_math,
            this.dvg_del});
            this.dataGridView1.Location = new System.Drawing.Point(523, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 641);
            this.dataGridView1.TabIndex = 14;
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
            // dgv_english
            // 
            this.dgv_english.DataPropertyName = "stuEnglish";
            this.dgv_english.HeaderText = "英文";
            this.dgv_english.Name = "dgv_english";
            // 
            // dgv_math
            // 
            this.dgv_math.DataPropertyName = "stuMath";
            this.dgv_math.HeaderText = "數學";
            this.dgv_math.Name = "dgv_math";
            // 
            // dvg_del
            // 
            this.dvg_del.DataPropertyName = "stuName";
            this.dvg_del.HeaderText = "";
            this.dvg_del.Name = "dvg_del";
            this.dvg_del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dvg_del.Text = "刪除";
            this.dvg_del.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(519, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "成績表";
            // 
            // labelsingle
            // 
            this.labelsingle.AutoSize = true;
            this.labelsingle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelsingle.Location = new System.Drawing.Point(12, 216);
            this.labelsingle.Name = "labelsingle";
            this.labelsingle.Size = new System.Drawing.Size(90, 21);
            this.labelsingle.TabIndex = 17;
            this.labelsingle.Text = "個人成績：";
            // 
            // btnlie
            // 
            this.btnlie.Location = new System.Drawing.Point(996, 6);
            this.btnlie.Name = "btnlie";
            this.btnlie.Size = new System.Drawing.Size(69, 24);
            this.btnlie.TabIndex = 18;
            this.btnlie.Text = "資料匯出";
            this.btnlie.UseVisualStyleBackColor = true;
            this.btnlie.Click += new System.EventHandler(this.btnlie_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "國文",
            "英文",
            "數學"});
            this.comboBox1.Location = new System.Drawing.Point(9, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // a6FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 677);
            this.Controls.Add(this.btnlie);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.labelsingle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "a6FormStudent";
            this.Text = "#129成績單";
            this.Load += new System.EventHandler(this.a6FormStudent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsearch1;
        private System.Windows.Forms.TextBox textup;
        private System.Windows.Forms.TextBox textdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkeyIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textenglish;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textmath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textchinese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_english;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_math;
        private System.Windows.Forms.DataGridViewButtonColumn dvg_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsingle;
        private System.Windows.Forms.Button btnlie;
        private System.Windows.Forms.Button butrmd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}