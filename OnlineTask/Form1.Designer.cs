namespace OnlineTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reseiveClientControl = new NetManager.Client.ReseiveClientControl();
            this.button = new System.Windows.Forms.Button();
            this.labelT3 = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelDir = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelC3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reseiveClientControl
            // 
            this.reseiveClientControl.IPServer = ((System.Net.IPAddress)(resources.GetObject("reseiveClientControl.IPServer")));
            this.reseiveClientControl.IsSyncronized = true;
            this.reseiveClientControl.Location = new System.Drawing.Point(17, 12);
            this.reseiveClientControl.Margin = new System.Windows.Forms.Padding(4);
            this.reseiveClientControl.Name = "reseiveClientControl";
            this.reseiveClientControl.Size = new System.Drawing.Size(174, 98);
            this.reseiveClientControl.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(71, 116);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Старт";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // labelT3
            // 
            this.labelT3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelT3.AutoSize = true;
            this.labelT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelT3.Location = new System.Drawing.Point(121, 568);
            this.labelT3.Name = "labelT3";
            this.labelT3.Size = new System.Drawing.Size(25, 25);
            this.labelT3.TabIndex = 12;
            this.labelT3.Text = "0";
            // 
            // labelL
            // 
            this.labelL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL.Location = new System.Drawing.Point(121, 392);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(25, 25);
            this.labelL.TabIndex = 17;
            this.labelL.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(27, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "сред.:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(158, 607);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "отношение:";
            // 
            // labelK
            // 
            this.labelK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(318, 607);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(25, 25);
            this.labelK.TabIndex = 20;
            this.labelK.Text = "0";
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDir.ForeColor = System.Drawing.Color.Red;
            this.labelDir.Location = new System.Drawing.Point(393, 12);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(78, 108);
            this.labelDir.TabIndex = 21;
            this.labelDir.Text = "-";
            // 
            // chart
            // 
            chartArea10.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea10);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chart.Legends.Add(legend10);
            this.chart.Location = new System.Drawing.Point(600, 0);
            this.chart.Name = "chart";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart.Series.Add(series10);
            this.chart.Size = new System.Drawing.Size(664, 681);
            this.chart.TabIndex = 22;
            this.chart.Text = "chart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 681);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "на Т3:";
            // 
            // labelC3
            // 
            this.labelC3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelC3.AutoSize = true;
            this.labelC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC3.Location = new System.Drawing.Point(121, 521);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(25, 25);
            this.labelC3.TabIndex = 11;
            this.labelC3.Text = "0";
            this.labelC3.Click += new System.EventHandler(this.labelC3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Спектральная плотность мощности Альфа-ритма:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "на О1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelT3);
            this.panel2.Controls.Add(this.labelL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelK);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelC3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 681);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(26, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(550, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Обучить программу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "При запуске программу нужно обучить.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(553, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Программа в течение 5 секунд будет вычислять срденее значение СПМ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Это значение принимается за положение в центре экрана";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(26, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 72);
            this.button2.TabIndex = 21;
            this.button2.Text = "Перемещать курсор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(320, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 72);
            this.button3.TabIndex = 22;
            this.button3.Text = "Не перемещать курсор";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.button);
            this.Controls.Add(this.reseiveClientControl);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Движение мыши";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetManager.Client.ReseiveClientControl reseiveClientControl;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelT3;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

