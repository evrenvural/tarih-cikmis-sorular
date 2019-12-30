namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.lblTrueQuestionCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWrongQuestionCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCountOfQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestion.Location = new System.Drawing.Point(53, 27);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(497, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "lsaldkjsalkdjsalşkjdsalkjfslakjdsalkjfsakljdşsakjflksjflksajd";
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(53, 178);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(286, 71);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(436, 178);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(286, 71);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(53, 284);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(286, 71);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(436, 284);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(286, 71);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "button4";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnE.Location = new System.Drawing.Point(231, 367);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(286, 71);
            this.btnE.TabIndex = 5;
            this.btnE.Text = "button1";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(713, 77);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 48);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soru Sayısı:";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestionCount.Location = new System.Drawing.Point(320, 489);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(16, 17);
            this.lblQuestionCount.TabIndex = 8;
            this.lblQuestionCount.Text = "0";
            // 
            // lblTrueQuestionCount
            // 
            this.lblTrueQuestionCount.AutoSize = true;
            this.lblTrueQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrueQuestionCount.Location = new System.Drawing.Point(320, 518);
            this.lblTrueQuestionCount.Name = "lblTrueQuestionCount";
            this.lblTrueQuestionCount.Size = new System.Drawing.Size(16, 17);
            this.lblTrueQuestionCount.TabIndex = 10;
            this.lblTrueQuestionCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(231, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doğru Sayısı:";
            // 
            // lblWrongQuestionCount
            // 
            this.lblWrongQuestionCount.AutoSize = true;
            this.lblWrongQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWrongQuestionCount.Location = new System.Drawing.Point(320, 548);
            this.lblWrongQuestionCount.Name = "lblWrongQuestionCount";
            this.lblWrongQuestionCount.Size = new System.Drawing.Size(16, 17);
            this.lblWrongQuestionCount.TabIndex = 12;
            this.lblWrongQuestionCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(231, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Yanlış Sayısı:";
            // 
            // lblCountOfQuestion
            // 
            this.lblCountOfQuestion.AutoSize = true;
            this.lblCountOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountOfQuestion.Location = new System.Drawing.Point(12, 27);
            this.lblCountOfQuestion.Name = "lblCountOfQuestion";
            this.lblCountOfQuestion.Size = new System.Drawing.Size(35, 25);
            this.lblCountOfQuestion.TabIndex = 13;
            this.lblCountOfQuestion.Text = "1 )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 584);
            this.Controls.Add(this.lblCountOfQuestion);
            this.Controls.Add(this.lblWrongQuestionCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTrueQuestionCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.Label lblTrueQuestionCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWrongQuestionCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCountOfQuestion;
    }
}

