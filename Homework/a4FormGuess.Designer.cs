namespace Homework
{
    partial class a4FormGuess
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.butGuess = new System.Windows.Forms.Button();
            this.textInt = new System.Windows.Forms.TextBox();
            this.labelresult = new System.Windows.Forms.Label();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.btngiveup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "終極密碼";
            // 
            // butGuess
            // 
            this.butGuess.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butGuess.Location = new System.Drawing.Point(281, 59);
            this.butGuess.Name = "butGuess";
            this.butGuess.Size = new System.Drawing.Size(141, 57);
            this.butGuess.TabIndex = 1;
            this.butGuess.Text = "Guess";
            this.butGuess.UseVisualStyleBackColor = true;
            this.butGuess.Click += new System.EventHandler(this.butGuess_Click);
            // 
            // textInt
            // 
            this.textInt.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textInt.Location = new System.Drawing.Point(20, 59);
            this.textInt.Name = "textInt";
            this.textInt.Size = new System.Drawing.Size(239, 57);
            this.textInt.TabIndex = 2;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelresult.Location = new System.Drawing.Point(12, 119);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(0, 47);
            this.labelresult.TabIndex = 0;
            // 
            // timerTest
            // 
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // btngiveup
            // 
            this.btngiveup.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngiveup.Location = new System.Drawing.Point(20, 260);
            this.btngiveup.Name = "btngiveup";
            this.btngiveup.Size = new System.Drawing.Size(402, 57);
            this.btngiveup.TabIndex = 1;
            this.btngiveup.Text = "Give Up";
            this.btngiveup.UseVisualStyleBackColor = true;
            this.btngiveup.Click += new System.EventHandler(this.btngiveup_Click);
            // 
            // a4FormGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 329);
            this.Controls.Add(this.textInt);
            this.Controls.Add(this.btngiveup);
            this.Controls.Add(this.butGuess);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.label1);
            this.Name = "a4FormGuess";
            this.Text = "終極密碼";
            this.Load += new System.EventHandler(this.a4FormGuess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butGuess;
        private System.Windows.Forms.TextBox textInt;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Button btngiveup;
    }
}