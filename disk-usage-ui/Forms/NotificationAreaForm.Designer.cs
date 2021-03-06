﻿namespace disk_usage_ui.Forms
{
    partial class NotificationAreaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationAreaForm));
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPathTaskbarButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editJsonButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.hideInaccessableItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.offMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveminMI = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyMI = new System.Windows.Forms.ToolStripMenuItem();
            this.onehourMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fourhourMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.diskStack = new System.Windows.Forms.FlowLayoutPanel();
            this.emptySpaceContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.emptySpaceAddPathButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderByCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipProvider = new System.Windows.Forms.ToolTip(this.components);
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.taskbarContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitTBMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new disk_usage_ui.NoFocusCueButton();
            this.mainContextMenu.SuspendLayout();
            this.emptySpaceContext.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.taskbarContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbarIcon
            // 
            this.taskbarIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.taskbarIcon.BalloonTipText = "Click the taskbar icon to see disk usage information";
            this.taskbarIcon.BalloonTipTitle = "Disk Usage";
            this.taskbarIcon.ContextMenuStrip = this.taskbarContext;
            this.taskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarIcon.Icon")));
            this.taskbarIcon.Text = "Disk Usage";
            this.taskbarIcon.Visible = true;
            this.taskbarIcon.BalloonTipClicked += new System.EventHandler(this.taskbarIcon_BalloonTipClicked);
            this.taskbarIcon.Click += new System.EventHandler(this.taskbarIcon_Click);
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPathTaskbarButton,
            this.editJsonButton,
            this.viewChartButton,
            this.hideInaccessableItem,
            this.notificationsMI,
            this.toolStripSeparator2,
            this.aboutButton,
            this.exitButton});
            this.mainContextMenu.MinimumSize = new System.Drawing.Size(279, 16);
            this.mainContextMenu.Name = "taskbarMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(281, 178);
            this.mainContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.taskbarContext_Opening);
            // 
            // addPathTaskbarButton
            // 
            this.addPathTaskbarButton.Image = global::disk_usage_ui.Properties.Resources.action_add_16xLG;
            this.addPathTaskbarButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addPathTaskbarButton.Name = "addPathTaskbarButton";
            this.addPathTaskbarButton.Size = new System.Drawing.Size(280, 24);
            this.addPathTaskbarButton.Text = "Add new path";
            this.addPathTaskbarButton.Click += new System.EventHandler(this.AddNewPath);
            // 
            // editJsonButton
            // 
            this.editJsonButton.Name = "editJsonButton";
            this.editJsonButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.editJsonButton.Size = new System.Drawing.Size(280, 24);
            this.editJsonButton.Text = "Edit JSON path list";
            this.editJsonButton.Visible = false;
            this.editJsonButton.Click += new System.EventHandler(this.editJsonButton_Click);
            // 
            // viewChartButton
            // 
            this.viewChartButton.Image = global::disk_usage_ui.Properties.Resources.KPI_16xLG;
            this.viewChartButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewChartButton.Name = "viewChartButton";
            this.viewChartButton.Size = new System.Drawing.Size(280, 24);
            this.viewChartButton.Text = "View bar chart";
            this.viewChartButton.Click += new System.EventHandler(this.viewChartButton_Click);
            // 
            // hideInaccessableItem
            // 
            this.hideInaccessableItem.Name = "hideInaccessableItem";
            this.hideInaccessableItem.Size = new System.Drawing.Size(280, 24);
            this.hideInaccessableItem.Text = "Hide inaccessable paths";
            this.hideInaccessableItem.Click += new System.EventHandler(this.hideInaccessableItem_Click);
            // 
            // notificationsMI
            // 
            this.notificationsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offMI,
            this.fiveminMI,
            this.thirtyMI,
            this.onehourMI,
            this.fourhourMI});
            this.notificationsMI.Image = global::disk_usage_ui.Properties.Resources.ic_notifications_black_18dp;
            this.notificationsMI.Name = "notificationsMI";
            this.notificationsMI.Size = new System.Drawing.Size(280, 24);
            this.notificationsMI.Text = "Notifications";
            this.notificationsMI.DropDownOpened += new System.EventHandler(this.notificationsMI_DropDownOpened);
            // 
            // offMI
            // 
            this.offMI.Name = "offMI";
            this.offMI.Size = new System.Drawing.Size(202, 24);
            this.offMI.Text = "Off";
            this.offMI.Click += new System.EventHandler(this.offMI_Click);
            // 
            // fiveminMI
            // 
            this.fiveminMI.Name = "fiveminMI";
            this.fiveminMI.Size = new System.Drawing.Size(202, 24);
            this.fiveminMI.Text = "Every 5 minutes";
            this.fiveminMI.Click += new System.EventHandler(this.fiveminMI_Click);
            // 
            // thirtyMI
            // 
            this.thirtyMI.Name = "thirtyMI";
            this.thirtyMI.Size = new System.Drawing.Size(202, 24);
            this.thirtyMI.Text = "Every 30 minutes";
            this.thirtyMI.Click += new System.EventHandler(this.thirtyMI_Click);
            // 
            // onehourMI
            // 
            this.onehourMI.Name = "onehourMI";
            this.onehourMI.Size = new System.Drawing.Size(202, 24);
            this.onehourMI.Text = "Once an hour";
            this.onehourMI.Click += new System.EventHandler(this.onehourMI_Click);
            // 
            // fourhourMI
            // 
            this.fourhourMI.Name = "fourhourMI";
            this.fourhourMI.Size = new System.Drawing.Size(202, 24);
            this.fourhourMI.Text = "Once every 4 hours";
            this.fourhourMI.Click += new System.EventHandler(this.fourhourMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(280, 24);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(280, 24);
            this.exitButton.Text = "E&xit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diskStack
            // 
            this.diskStack.AutoScroll = true;
            this.diskStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diskStack.BackColor = System.Drawing.Color.White;
            this.diskStack.ContextMenuStrip = this.emptySpaceContext;
            this.diskStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.diskStack.Location = new System.Drawing.Point(0, 0);
            this.diskStack.Margin = new System.Windows.Forms.Padding(0);
            this.diskStack.MinimumSize = new System.Drawing.Size(257, 0);
            this.diskStack.Name = "diskStack";
            this.diskStack.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.diskStack.Size = new System.Drawing.Size(303, 449);
            this.diskStack.TabIndex = 3;
            this.diskStack.WrapContents = false;
            // 
            // emptySpaceContext
            // 
            this.emptySpaceContext.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.emptySpaceContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptySpaceAddPathButton});
            this.emptySpaceContext.Name = "contextMenuStrip1";
            this.emptySpaceContext.Size = new System.Drawing.Size(169, 28);
            // 
            // emptySpaceAddPathButton
            // 
            this.emptySpaceAddPathButton.Image = global::disk_usage_ui.Properties.Resources.action_add_16xLG;
            this.emptySpaceAddPathButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emptySpaceAddPathButton.Name = "emptySpaceAddPathButton";
            this.emptySpaceAddPathButton.Size = new System.Drawing.Size(168, 24);
            this.emptySpaceAddPathButton.Text = "Add new path";
            this.emptySpaceAddPathButton.Click += new System.EventHandler(this.AddNewPath);
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Controls.Add(this.diskStack, 0, 0);
            this.tableLayout.Controls.Add(this.panel1, 0, 2);
            this.tableLayout.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.MinimumSize = new System.Drawing.Size(257, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayout.Size = new System.Drawing.Size(303, 497);
            this.tableLayout.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.orderByCombo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(257, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 35);
            this.panel1.TabIndex = 5;
            // 
            // orderByCombo
            // 
            this.orderByCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.orderByCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByCombo.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByCombo.FormattingEnabled = true;
            this.orderByCombo.Items.AddRange(new object[] {
            "Sort by Name (A-Z)"});
            this.orderByCombo.Location = new System.Drawing.Point(26, 5);
            this.orderByCombo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.orderByCombo.Name = "orderByCombo";
            this.orderByCombo.Size = new System.Drawing.Size(209, 21);
            this.orderByCombo.TabIndex = 4;
            this.toolTipProvider.SetToolTip(this.orderByCombo, "Select Sorting Method");
            this.orderByCombo.SelectedIndexChanged += new System.EventHandler(this.orderByCombo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::disk_usage_ui.Properties.Resources.div;
            this.pictureBox1.Location = new System.Drawing.Point(0, 449);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipProvider
            // 
            this.toolTipProvider.BackColor = System.Drawing.Color.White;
            this.toolTipProvider.ForeColor = System.Drawing.Color.Black;
            this.toolTipProvider.IsBalloon = true;
            // 
            // notificationTimer
            // 
            this.notificationTimer.Interval = 10000;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // taskbarContext
            // 
            this.taskbarContext.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.taskbarContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTSMI,
            this.exitTBMI});
            this.taskbarContext.Name = "taskbarContext";
            this.taskbarContext.Size = new System.Drawing.Size(170, 77);
            // 
            // exitTBMI
            // 
            this.exitTBMI.Name = "exitTBMI";
            this.exitTBMI.Size = new System.Drawing.Size(169, 24);
            this.exitTBMI.Text = "E&xit";
            this.exitTBMI.Click += new System.EventHandler(this.exitTBMI_Click);
            // 
            // openTSMI
            // 
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.Size = new System.Drawing.Size(169, 24);
            this.openTSMI.Text = "&Open";
            this.openTSMI.Click += new System.EventHandler(this.openTSMI_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::disk_usage_ui.Properties.Resources.SettingsDropdown;
            this.settingsButton.Location = new System.Drawing.Point(238, 3);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(32, 24);
            this.settingsButton.TabIndex = 5;
            this.toolTipProvider.SetToolTip(this.settingsButton, "Settings Menu");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsMainButton_Click);
            // 
            // NotificationAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 497);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(321, 515);
            this.MinimumSize = new System.Drawing.Size(321, 96);
            this.Name = "NotificationAreaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FormDeactivate);
            this.Resize += new System.EventHandler(this.NotificationAreaForm_Resize);
            this.mainContextMenu.ResumeLayout(false);
            this.emptySpaceContext.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.taskbarContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon taskbarIcon;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.FlowLayoutPanel diskStack;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        //private DiskTile diskTile5;
        private System.Windows.Forms.ContextMenuStrip emptySpaceContext;
        private System.Windows.Forms.ToolStripMenuItem emptySpaceAddPathButton;
        private System.Windows.Forms.ToolStripMenuItem addPathTaskbarButton;
        private System.Windows.Forms.ToolStripMenuItem editJsonButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox orderByCombo;
        private System.Windows.Forms.ToolStripMenuItem viewChartButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.Panel panel1;
        private NoFocusCueButton settingsButton;
        private System.Windows.Forms.ToolTip toolTipProvider;
        private System.Windows.Forms.ToolStripMenuItem hideInaccessableItem;
        private System.Windows.Forms.Timer notificationTimer;
        private System.Windows.Forms.ToolStripMenuItem notificationsMI;
        private System.Windows.Forms.ToolStripMenuItem offMI;
        private System.Windows.Forms.ToolStripMenuItem fiveminMI;
        private System.Windows.Forms.ToolStripMenuItem thirtyMI;
        private System.Windows.Forms.ToolStripMenuItem onehourMI;
        private System.Windows.Forms.ToolStripMenuItem fourhourMI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip taskbarContext;
        private System.Windows.Forms.ToolStripMenuItem openTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTBMI;
    }
}

