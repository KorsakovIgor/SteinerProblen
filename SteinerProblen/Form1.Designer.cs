namespace SteinerProblen
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CoordX = new System.Windows.Forms.TextBox();
            this.CoordY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.populationCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxIterNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxWetghtNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vIndMax = new System.Windows.Forms.TextBox();
            this.vVolMax = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.AnswerF = new System.Windows.Forms.RichTextBox();
            this.MaxIterFNumeric = new System.Windows.Forms.NumericUpDown();
            this.Beta0 = new System.Windows.Forms.TextBox();
            this.Gamma = new System.Windows.Forms.TextBox();
            this.Alpha = new System.Windows.Forms.TextBox();
            this.FpopulNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.populationCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWetghtNumeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterFNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpopulNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(460, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 420);
            this.listBox1.TabIndex = 1;
            // 
            // CoordX
            // 
            this.CoordX.Location = new System.Drawing.Point(619, 30);
            this.CoordX.Name = "CoordX";
            this.CoordX.Size = new System.Drawing.Size(109, 20);
            this.CoordX.TabIndex = 2;
            // 
            // CoordY
            // 
            this.CoordY.Location = new System.Drawing.Point(619, 61);
            this.CoordY.Name = "CoordY";
            this.CoordY.Size = new System.Drawing.Size(109, 20);
            this.CoordY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "У:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить точку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Решить задачу Штейнера";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Список точек:";
            // 
            // populationCountNumeric
            // 
            this.populationCountNumeric.Location = new System.Drawing.Point(241, 132);
            this.populationCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.populationCountNumeric.Name = "populationCountNumeric";
            this.populationCountNumeric.Size = new System.Drawing.Size(47, 20);
            this.populationCountNumeric.TabIndex = 10;
            this.populationCountNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaxIterNumeric
            // 
            this.MaxIterNumeric.Location = new System.Drawing.Point(241, 36);
            this.MaxIterNumeric.Name = "MaxIterNumeric";
            this.MaxIterNumeric.Size = new System.Drawing.Size(47, 20);
            this.MaxIterNumeric.TabIndex = 11;
            this.MaxIterNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaxWetghtNumeric
            // 
            this.MaxWetghtNumeric.Location = new System.Drawing.Point(241, 61);
            this.MaxWetghtNumeric.Name = "MaxWetghtNumeric";
            this.MaxWetghtNumeric.Size = new System.Drawing.Size(47, 20);
            this.MaxWetghtNumeric.TabIndex = 12;
            this.MaxWetghtNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Кол-во итераций:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Мах вес рыбы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max шаг индивидуального перемещения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Мах шаг волевого плавания:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Размер популяции:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Свободные параметры алгоритма косяка рыб:";
            // 
            // vIndMax
            // 
            this.vIndMax.Location = new System.Drawing.Point(241, 84);
            this.vIndMax.Name = "vIndMax";
            this.vIndMax.Size = new System.Drawing.Size(47, 20);
            this.vIndMax.TabIndex = 21;
            this.vIndMax.Text = "0,5";
            // 
            // vVolMax
            // 
            this.vVolMax.Location = new System.Drawing.Point(241, 107);
            this.vVolMax.Name = "vVolMax";
            this.vVolMax.Size = new System.Drawing.Size(47, 20);
            this.vVolMax.TabIndex = 22;
            this.vVolMax.Text = "0,5";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(2, 30);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(452, 420);
            this.zedGraphControl1.TabIndex = 23;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(165, 161);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(179, 36);
            this.Answer.TabIndex = 24;
            this.Answer.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(618, 416);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 34);
            this.progressBar1.TabIndex = 25;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(619, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 246);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Answer);
            this.tabPage1.Controls.Add(this.MaxIterNumeric);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.populationCountNumeric);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.vVolMax);
            this.tabPage1.Controls.Add(this.MaxWetghtNumeric);
            this.tabPage1.Controls.Add(this.vIndMax);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Алгоритм косяка рыб";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.FpopulNumeric);
            this.tabPage2.Controls.Add(this.Alpha);
            this.tabPage2.Controls.Add(this.Gamma);
            this.tabPage2.Controls.Add(this.Beta0);
            this.tabPage2.Controls.Add(this.MaxIterFNumeric);
            this.tabPage2.Controls.Add(this.AnswerF);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Алгоритм светлячков";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Количество итераций:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Привлекательность при 0-м расстоянии:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Коэффициент поглощения света средой:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Свободный параметр рандомизации:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Размер популяции:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Решить задачу Штейнера";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AnswerF
            // 
            this.AnswerF.Location = new System.Drawing.Point(165, 158);
            this.AnswerF.Name = "AnswerF";
            this.AnswerF.ReadOnly = true;
            this.AnswerF.Size = new System.Drawing.Size(179, 36);
            this.AnswerF.TabIndex = 6;
            this.AnswerF.Text = "";
            // 
            // MaxIterFNumeric
            // 
            this.MaxIterFNumeric.Location = new System.Drawing.Point(272, 12);
            this.MaxIterFNumeric.Name = "MaxIterFNumeric";
            this.MaxIterFNumeric.Size = new System.Drawing.Size(40, 20);
            this.MaxIterFNumeric.TabIndex = 7;
            this.MaxIterFNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Beta0
            // 
            this.Beta0.Location = new System.Drawing.Point(272, 35);
            this.Beta0.Name = "Beta0";
            this.Beta0.Size = new System.Drawing.Size(40, 20);
            this.Beta0.TabIndex = 8;
            this.Beta0.Text = "1";
            // 
            // Gamma
            // 
            this.Gamma.Location = new System.Drawing.Point(272, 60);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(40, 20);
            this.Gamma.TabIndex = 9;
            this.Gamma.Text = "1";
            // 
            // Alpha
            // 
            this.Alpha.Location = new System.Drawing.Point(272, 86);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(40, 20);
            this.Alpha.TabIndex = 10;
            this.Alpha.Text = "0,5";
            // 
            // FpopulNumeric
            // 
            this.FpopulNumeric.Location = new System.Drawing.Point(272, 112);
            this.FpopulNumeric.Name = "FpopulNumeric";
            this.FpopulNumeric.Size = new System.Drawing.Size(40, 20);
            this.FpopulNumeric.TabIndex = 11;
            this.FpopulNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoordY);
            this.Controls.Add(this.CoordX);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Решение задачи Штейнера";
            ((System.ComponentModel.ISupportInitialize)(this.populationCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWetghtNumeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterFNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpopulNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CoordX;
        private System.Windows.Forms.TextBox CoordY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown populationCountNumeric;
        private System.Windows.Forms.NumericUpDown MaxIterNumeric;
        private System.Windows.Forms.NumericUpDown MaxWetghtNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vIndMax;
        private System.Windows.Forms.TextBox vVolMax;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox AnswerF;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown FpopulNumeric;
        private System.Windows.Forms.TextBox Alpha;
        private System.Windows.Forms.TextBox Gamma;
        private System.Windows.Forms.TextBox Beta0;
        private System.Windows.Forms.NumericUpDown MaxIterFNumeric;
    }
}

