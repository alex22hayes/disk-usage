﻿namespace disk_usage_ui.Forms
{
    partial class PropertiesForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 70D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacityBytesLabel = new System.Windows.Forms.Label();
            this.freeBytesLabel = new System.Windows.Forms.Label();
            this.usedBytesLabel = new System.Windows.Forms.Label();
            this.driveIcon = new System.Windows.Forms.PictureBox();
            this.driveLabelTextBox = new System.Windows.Forms.TextBox();
            this.freeSpaceText = new System.Windows.Forms.Label();
            this.usedSpaceText = new System.Windows.Forms.Label();
            this.freeSpaceIndicator = new System.Windows.Forms.Panel();
            this.usedSpaceIndicator = new System.Windows.Forms.Panel();
            this.divider3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.diskTypeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.Panel();
            this.divider1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.explorerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.capacityBytesLabel);
            this.panel1.Controls.Add(this.freeBytesLabel);
            this.panel1.Controls.Add(this.usedBytesLabel);
            this.panel1.Controls.Add(this.driveIcon);
            this.panel1.Controls.Add(this.driveLabelTextBox);
            this.panel1.Controls.Add(this.divider1);
            this.panel1.Controls.Add(this.usedSpaceText);
            this.panel1.Controls.Add(this.freeSpaceText);
            this.panel1.Controls.Add(this.freeSpaceIndicator);
            this.panel1.Controls.Add(this.usedSpaceIndicator);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.diskTypeLabel);
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.divider2);
            this.panel1.Controls.Add(this.pieChart);
            this.panel1.Controls.Add(this.divider3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 364);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // capacityBytesLabel
            // 
            this.capacityBytesLabel.Location = new System.Drawing.Point(94, 176);
            this.capacityBytesLabel.Name = "capacityBytesLabel";
            this.capacityBytesLabel.Size = new System.Drawing.Size(150, 23);
            this.capacityBytesLabel.TabIndex = 21;
            this.capacityBytesLabel.Text = "1,869,166,407,680 bytes";
            this.capacityBytesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.capacityBytesLabel.Click += new System.EventHandler(this.capacityBytesLabel_Click);
            // 
            // freeBytesLabel
            // 
            this.freeBytesLabel.Location = new System.Drawing.Point(109, 146);
            this.freeBytesLabel.Name = "freeBytesLabel";
            this.freeBytesLabel.Size = new System.Drawing.Size(135, 24);
            this.freeBytesLabel.TabIndex = 20;
            this.freeBytesLabel.Text = "106,464,231,424 bytes";
            this.freeBytesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usedBytesLabel
            // 
            this.usedBytesLabel.Location = new System.Drawing.Point(106, 125);
            this.usedBytesLabel.Name = "usedBytesLabel";
            this.usedBytesLabel.Size = new System.Drawing.Size(138, 23);
            this.usedBytesLabel.TabIndex = 19;
            this.usedBytesLabel.Text = "1,762,702,176,256 bytes";
            this.usedBytesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // driveIcon
            // 
            this.driveIcon.Image = global::disk_usage_ui.Properties.Resources.networkdrive7;
            this.driveIcon.Location = new System.Drawing.Point(28, 17);
            this.driveIcon.Name = "driveIcon";
            this.driveIcon.Size = new System.Drawing.Size(32, 32);
            this.driveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.driveIcon.TabIndex = 18;
            this.driveIcon.TabStop = false;
            // 
            // driveLabelTextBox
            // 
            this.driveLabelTextBox.Location = new System.Drawing.Point(78, 17);
            this.driveLabelTextBox.MaxLength = 22;
            this.driveLabelTextBox.Name = "driveLabelTextBox";
            this.driveLabelTextBox.Size = new System.Drawing.Size(231, 20);
            this.driveLabelTextBox.TabIndex = 17;
            this.driveLabelTextBox.Text = "Label";
            this.driveLabelTextBox.TextChanged += new System.EventHandler(this.driveLabelTextBox_TextChanged);
            // 
            // freeSpaceText
            // 
            this.freeSpaceText.AutoSize = true;
            this.freeSpaceText.Location = new System.Drawing.Point(36, 150);
            this.freeSpaceText.Name = "freeSpaceText";
            this.freeSpaceText.Size = new System.Drawing.Size(63, 13);
            this.freeSpaceText.TabIndex = 16;
            this.freeSpaceText.Text = "Free space:";
            // 
            // usedSpaceText
            // 
            this.usedSpaceText.AutoSize = true;
            this.usedSpaceText.Location = new System.Drawing.Point(35, 130);
            this.usedSpaceText.Name = "usedSpaceText";
            this.usedSpaceText.Size = new System.Drawing.Size(67, 13);
            this.usedSpaceText.TabIndex = 15;
            this.usedSpaceText.Text = "Used space:";
            // 
            // freeSpaceIndicator
            // 
            this.freeSpaceIndicator.BackColor = System.Drawing.Color.Magenta;
            this.freeSpaceIndicator.Location = new System.Drawing.Point(17, 149);
            this.freeSpaceIndicator.MaximumSize = new System.Drawing.Size(16, 16);
            this.freeSpaceIndicator.MinimumSize = new System.Drawing.Size(16, 16);
            this.freeSpaceIndicator.Name = "freeSpaceIndicator";
            this.freeSpaceIndicator.Size = new System.Drawing.Size(16, 16);
            this.freeSpaceIndicator.TabIndex = 14;
            // 
            // usedSpaceIndicator
            // 
            this.usedSpaceIndicator.BackColor = System.Drawing.Color.Blue;
            this.usedSpaceIndicator.Location = new System.Drawing.Point(17, 127);
            this.usedSpaceIndicator.MaximumSize = new System.Drawing.Size(16, 16);
            this.usedSpaceIndicator.MinimumSize = new System.Drawing.Size(16, 16);
            this.usedSpaceIndicator.Name = "usedSpaceIndicator";
            this.usedSpaceIndicator.Size = new System.Drawing.Size(16, 16);
            this.usedSpaceIndicator.TabIndex = 13;
            // 
            // divider3
            // 
            this.divider3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.divider3.Location = new System.Drawing.Point(17, 299);
            this.divider3.Margin = new System.Windows.Forms.Padding(0);
            this.divider3.MaximumSize = new System.Drawing.Size(1000, 1);
            this.divider3.MinimumSize = new System.Drawing.Size(20, 1);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(292, 1);
            this.divider3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(86, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Not determined";
            // 
            // diskTypeLabel
            // 
            this.diskTypeLabel.AutoSize = true;
            this.diskTypeLabel.Location = new System.Drawing.Point(86, 81);
            this.diskTypeLabel.Name = "diskTypeLabel";
            this.diskTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.diskTypeLabel.TabIndex = 9;
            this.diskTypeLabel.Text = "Network Drive";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoEllipsis = true;
            this.locationLabel.Location = new System.Drawing.Point(86, 62);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(223, 19);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "C:\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capacity:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // divider2
            // 
            this.divider2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.divider2.Location = new System.Drawing.Point(17, 171);
            this.divider2.Margin = new System.Windows.Forms.Padding(0);
            this.divider2.MaximumSize = new System.Drawing.Size(1000, 1);
            this.divider2.MinimumSize = new System.Drawing.Size(20, 1);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(292, 1);
            this.divider2.TabIndex = 6;
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.divider1.Location = new System.Drawing.Point(17, 121);
            this.divider1.Margin = new System.Windows.Forms.Padding(0);
            this.divider1.MaximumSize = new System.Drawing.Size(1000, 1);
            this.divider1.MinimumSize = new System.Drawing.Size(20, 1);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(292, 1);
            this.divider1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "File system:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.Location = new System.Drawing.Point(17, 202);
            this.pieChart.Name = "pieChart";
            series1.BorderColor = System.Drawing.SystemColors.ControlText;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.Blue;
            dataPoint2.Color = System.Drawing.Color.Magenta;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.ShadowOffset = 5;
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(292, 94);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "chart1";
            this.pieChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(270, 409);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(189, 409);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // explorerButton
            // 
            this.explorerButton.Image = global::disk_usage_ui.Properties.Resources.properties_16xLG;
            this.explorerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.explorerButton.Location = new System.Drawing.Point(58, 409);
            this.explorerButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.explorerButton.Name = "explorerButton";
            this.explorerButton.Size = new System.Drawing.Size(125, 23);
            this.explorerButton.TabIndex = 2;
            this.explorerButton.Text = "&Explorer Properties";
            this.explorerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.explorerButton.UseVisualStyleBackColor = true;
            this.explorerButton.Click += new System.EventHandler(this.explorerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.890909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(74, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "This label only applies to the Disk Usage program";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 392);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(339, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customize";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PropertiesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(357, 439);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.explorerButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button explorerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.Panel divider2;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label diskTypeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel divider3;
        private System.Windows.Forms.Label freeSpaceText;
        private System.Windows.Forms.Label usedSpaceText;
        private System.Windows.Forms.Panel freeSpaceIndicator;
        private System.Windows.Forms.Panel usedSpaceIndicator;
        private System.Windows.Forms.TextBox driveLabelTextBox;
        private System.Windows.Forms.PictureBox driveIcon;
        private System.Windows.Forms.Label capacityBytesLabel;
        private System.Windows.Forms.Label freeBytesLabel;
        private System.Windows.Forms.Label usedBytesLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}