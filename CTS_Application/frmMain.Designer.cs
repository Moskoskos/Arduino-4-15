﻿namespace CTS_Application
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnSubscribers = new System.Windows.Forms.Button();
            this.tmrStatusChanged = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtSpL = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.historianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctsDataSetDbHistorianToGraph = new CTS_Application.ctsDataSetDbHistorianToGraph();
            this.tmrSimTemp = new System.Windows.Forms.Timer(this.components);
            this.tmrRecToDb = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmeventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimerecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmhistorianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctsDataSetHistorian = new CTS_Application.ctsDataSetHistorian();
            this.alarm_historianTableAdapter = new CTS_Application.ctsDataSetHistorianTableAdapters.alarm_historianTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historianTableAdapter = new CTS_Application.ctsDataSetDbHistorianToGraphTableAdapters.historianTableAdapter();
            this.txtHysteresis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetDbHistorianToGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetHistorian)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(640, 400);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 18;
            this.lblPercentage.Text = "Percentage";
            // 
            // btnSubscribers
            // 
            this.btnSubscribers.Location = new System.Drawing.Point(1168, 392);
            this.btnSubscribers.Name = "btnSubscribers";
            this.btnSubscribers.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribers.TabIndex = 19;
            this.btnSubscribers.Text = "Subscribers";
            this.btnSubscribers.UseVisualStyleBackColor = true;
            this.btnSubscribers.Click += new System.EventHandler(this.btnSubscribers_Click);
            // 
            // tmrStatusChanged
            // 
            this.tmrStatusChanged.Interval = 30000;
            this.tmrStatusChanged.Tick += new System.EventHandler(this.tmrStatusChanged_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(720, 400);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(51, 13);
            this.lblTimeLeft.TabIndex = 20;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(520, 400);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // txtSpL
            // 
            this.txtSpL.Location = new System.Drawing.Point(120, 48);
            this.txtSpL.Name = "txtSpL";
            this.txtSpL.Size = new System.Drawing.Size(100, 20);
            this.txtSpL.TabIndex = 23;
            this.txtSpL.Text = "3";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(8, 48);
            this.txtCV.Name = "txtCV";
            this.txtCV.ReadOnly = true;
            this.txtCV.Size = new System.Drawing.Size(100, 20);
            this.txtCV.TabIndex = 24;
            this.txtCV.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 26;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(368, 48);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Current Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Set Point Alarm";
            // 
            // chrtTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtTemp.ChartAreas.Add(chartArea1);
            this.chrtTemp.DataSource = this.historianBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend1);
            this.chrtTemp.Location = new System.Drawing.Point(8, 80);
            this.chrtTemp.Name = "chrtTemp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "datetime_recorded";
            series1.YValueMembers = "value";
            this.chrtTemp.Series.Add(series1);
            this.chrtTemp.Size = new System.Drawing.Size(776, 288);
            this.chrtTemp.TabIndex = 30;
            this.chrtTemp.Text = "chart1";
            // 
            // historianBindingSource
            // 
            this.historianBindingSource.DataMember = "historian";
            this.historianBindingSource.DataSource = this.ctsDataSetDbHistorianToGraph;
            // 
            // ctsDataSetDbHistorianToGraph
            // 
            this.ctsDataSetDbHistorianToGraph.DataSetName = "ctsDataSetDbHistorianToGraph";
            this.ctsDataSetDbHistorianToGraph.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tmrSimTemp
            // 
            this.tmrSimTemp.Interval = 1000;
            this.tmrSimTemp.Tick += new System.EventHandler(this.tmrSimTemp_Tick);
            // 
            // tmrRecToDb
            // 
            this.tmrRecToDb.Interval = 3000;
            this.tmrRecToDb.Tick += new System.EventHandler(this.tmrRecToDb_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1000, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Alarmlist";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Test Alarm 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Test Alarm 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Test Alarm 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Test Alarm 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Test Alarm 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alarmeventidDataGridViewTextBoxColumn,
            this.datetimerecordedDataGridViewTextBoxColumn,
            this.alarmidDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alarmhistorianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(792, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(456, 288);
            this.dataGridView1.TabIndex = 39;
            // 
            // alarmeventidDataGridViewTextBoxColumn
            // 
            this.alarmeventidDataGridViewTextBoxColumn.DataPropertyName = "alarm_event_id";
            this.alarmeventidDataGridViewTextBoxColumn.HeaderText = "alarm_event_id";
            this.alarmeventidDataGridViewTextBoxColumn.Name = "alarmeventidDataGridViewTextBoxColumn";
            this.alarmeventidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimerecordedDataGridViewTextBoxColumn
            // 
            this.datetimerecordedDataGridViewTextBoxColumn.DataPropertyName = "datetime_recorded";
            this.datetimerecordedDataGridViewTextBoxColumn.HeaderText = "datetime_recorded";
            this.datetimerecordedDataGridViewTextBoxColumn.Name = "datetimerecordedDataGridViewTextBoxColumn";
            this.datetimerecordedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmidDataGridViewTextBoxColumn
            // 
            this.alarmidDataGridViewTextBoxColumn.DataPropertyName = "alarm_id";
            this.alarmidDataGridViewTextBoxColumn.HeaderText = "alarm_id";
            this.alarmidDataGridViewTextBoxColumn.Name = "alarmidDataGridViewTextBoxColumn";
            this.alarmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmhistorianBindingSource
            // 
            this.alarmhistorianBindingSource.DataMember = "alarm_historian";
            this.alarmhistorianBindingSource.DataSource = this.ctsDataSetHistorian;
            // 
            // ctsDataSetHistorian
            // 
            this.ctsDataSetHistorian.DataSetName = "ctsDataSetHistorian";
            this.ctsDataSetHistorian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarm_historianTableAdapter
            // 
            this.alarm_historianTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSettingsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionSettingsToolStripMenuItem.Text = "Connection settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // historianTableAdapter
            // 
            this.historianTableAdapter.ClearBeforeFill = true;
            // 
            // txtHysteresis
            // 
            this.txtHysteresis.Location = new System.Drawing.Point(232, 48);
            this.txtHysteresis.Name = "txtHysteresis";
            this.txtHysteresis.Size = new System.Drawing.Size(100, 20);
            this.txtHysteresis.TabIndex = 41;
            this.txtHysteresis.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hysteresis";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHysteresis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrtTemp);
            this.Controls.Add(this.txtSpL);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnSubscribers);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSub";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetDbHistorianToGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetHistorian)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnSubscribers;
        private System.Windows.Forms.Timer tmrStatusChanged;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtSpL;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTemp;
        private System.Windows.Forms.Timer tmrSimTemp;
        private System.Windows.Forms.Timer tmrRecToDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ctsDataSetHistorian ctsDataSetHistorian;
        private System.Windows.Forms.BindingSource alarmhistorianBindingSource;
        private ctsDataSetHistorianTableAdapters.alarm_historianTableAdapter alarm_historianTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private ctsDataSetDbHistorianToGraph ctsDataSetDbHistorianToGraph;
        private System.Windows.Forms.BindingSource historianBindingSource;
        private ctsDataSetDbHistorianToGraphTableAdapters.historianTableAdapter historianTableAdapter;
        private System.Windows.Forms.TextBox txtHysteresis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmeventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimerecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}