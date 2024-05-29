namespace ABC_Semiha
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudKoloni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAlt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudUst = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCevrim = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDeneme = new System.Windows.Forms.NumericUpDown();
            this.chartEniyi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudKoloni
            // 
            this.nudKoloni.Location = new System.Drawing.Point(187, 61);
            this.nudKoloni.Margin = new System.Windows.Forms.Padding(6);
            this.nudKoloni.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKoloni.Name = "nudKoloni";
            this.nudKoloni.Size = new System.Drawing.Size(220, 34);
            this.nudKoloni.TabIndex = 0;
            this.nudKoloni.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koloni Boyutu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alt Sınır";
            // 
            // nudAlt
            // 
            this.nudAlt.Location = new System.Drawing.Point(187, 112);
            this.nudAlt.Margin = new System.Windows.Forms.Padding(6);
            this.nudAlt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAlt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudAlt.Name = "nudAlt";
            this.nudAlt.Size = new System.Drawing.Size(220, 34);
            this.nudAlt.TabIndex = 6;
            this.nudAlt.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudAlt.ValueChanged += new System.EventHandler(this.nudAlt_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Üst Sınır";
            // 
            // nudUst
            // 
            this.nudUst.Location = new System.Drawing.Point(187, 153);
            this.nudUst.Margin = new System.Windows.Forms.Padding(6);
            this.nudUst.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudUst.Name = "nudUst";
            this.nudUst.Size = new System.Drawing.Size(220, 34);
            this.nudUst.TabIndex = 8;
            this.nudUst.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.SlateGray;
            this.btnHesapla.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHesapla.FlatAppearance.BorderSize = 3;
            this.btnHesapla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHesapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Location = new System.Drawing.Point(468, 167);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(350, 46);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Çevrim Sayısı";
            // 
            // nudCevrim
            // 
            this.nudCevrim.Location = new System.Drawing.Point(598, 95);
            this.nudCevrim.Margin = new System.Windows.Forms.Padding(6);
            this.nudCevrim.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCevrim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCevrim.Name = "nudCevrim";
            this.nudCevrim.Size = new System.Drawing.Size(220, 34);
            this.nudCevrim.TabIndex = 11;
            this.nudCevrim.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deneme Sayısı";
            // 
            // nudDeneme
            // 
            this.nudDeneme.Location = new System.Drawing.Point(615, 61);
            this.nudDeneme.Margin = new System.Windows.Forms.Padding(6);
            this.nudDeneme.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDeneme.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeneme.Name = "nudDeneme";
            this.nudDeneme.Size = new System.Drawing.Size(220, 34);
            this.nudDeneme.TabIndex = 13;
            this.nudDeneme.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // chartEniyi
            // 
            this.chartEniyi.BackColor = System.Drawing.Color.RosyBrown;
            this.chartEniyi.BorderlineColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chartEniyi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEniyi.Legends.Add(legend1);
            this.chartEniyi.Location = new System.Drawing.Point(979, 83);
            this.chartEniyi.Name = "chartEniyi";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "x1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "x2";
            this.chartEniyi.Series.Add(series1);
            this.chartEniyi.Series.Add(series2);
            this.chartEniyi.Size = new System.Drawing.Size(461, 307);
            this.chartEniyi.TabIndex = 15;
            this.chartEniyi.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 466);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(946, 282);
            this.textBox1.TabIndex = 16;
            // 
            // chartFx
            // 
            this.chartFx.BackColor = System.Drawing.Color.RosyBrown;
            chartArea2.Name = "ChartArea1";
            this.chartFx.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFx.Legends.Add(legend2);
            this.chartFx.Location = new System.Drawing.Point(979, 441);
            this.chartFx.Name = "chartFx";
            this.chartFx.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "fx";
            this.chartFx.Series.Add(series3);
            this.chartFx.Size = new System.Drawing.Size(461, 307);
            this.chartFx.TabIndex = 17;
            this.chartFx.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(328, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "X1 - X2 - Fx - Fit Değerleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(1158, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fx Grafiği";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SlateGray;
            this.label8.Location = new System.Drawing.Point(1122, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "X1 ve X2 Grafiği";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.nudKoloni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudAlt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudUst);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudCevrim);
            this.groupBox1.Controls.Add(this.nudDeneme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(5, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 251);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Değerleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SlateGray;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(445, 44);
            this.label9.TabIndex = 23;
            this.label9.Text = "YAPAY ARI KOLONİSİ PROJE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(738, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 783);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartFx);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chartEniyi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Yapay Arı Kolonisi - SEMİHA KARADAĞ";
            ((System.ComponentModel.ISupportInitialize)(this.nudKoloni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCevrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeneme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEniyi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudKoloni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAlt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudUst;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCevrim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDeneme;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEniyi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

