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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCV = new System.Windows.Forms.Label();
            this.tmrTemp = new System.Windows.Forms.Timer(this.components);
            this.tmrRecToDb = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMySql = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.historianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetToGrah = new CTS_Application.DataSetToGrah();
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.historianTableAdapter = new CTS_Application.DataSetToGrahTableAdapters.historianTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrAlarm = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmeventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimerecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmhistorianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctsDataSetAlarm = new CTS_Application.ctsDataSetAlarm();
            this.alarm_historianTableAdapter = new CTS_Application.ctsDataSetAlarmTableAdapters.alarm_historianTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(136, 16);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 18;
            this.lblPercentage.Text = "Percentage";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(237, 16);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(51, 13);
            this.lblTimeLeft.TabIndex = 20;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(16, 16);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 26;
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.ForeColor = System.Drawing.Color.Blue;
            this.lblCV.Location = new System.Drawing.Point(368, 80);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(60, 31);
            this.lblCV.TabIndex = 27;
            this.lblCV.Text = "N/A";
            // 
            // tmrTemp
            // 
            this.tmrTemp.Interval = 2000;
            this.tmrTemp.Tick += new System.EventHandler(this.tmrTemp_Tick);
            // 
            // tmrRecToDb
            // 
            this.tmrRecToDb.Interval = 10000;
            this.tmrRecToDb.Tick += new System.EventHandler(this.tmrRecToDb_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.subscribersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // subscribersToolStripMenuItem
            // 
            this.subscribersToolStripMenuItem.Name = "subscribersToolStripMenuItem";
            this.subscribersToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.subscribersToolStripMenuItem.Text = "Subscribers";
            this.subscribersToolStripMenuItem.Click += new System.EventHandler(this.subscribersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lblMySql);
            this.panel1.Controls.Add(this.lblMemory);
            this.panel1.Controls.Add(this.lblPercentage);
            this.panel1.Controls.Add(this.lblTimeLeft);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 40);
            this.panel1.TabIndex = 47;
            // 
            // lblMySql
            // 
            this.lblMySql.AutoSize = true;
            this.lblMySql.Location = new System.Drawing.Point(872, 16);
            this.lblMySql.Name = "lblMySql";
            this.lblMySql.Size = new System.Drawing.Size(141, 13);
            this.lblMySql.TabIndex = 58;
            this.lblMySql.Text = "MySQL Status: Not Running";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(1044, 16);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(78, 13);
            this.lblMemory.TabIndex = 22;
            this.lblMemory.Text = "Memory Usage";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(24, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "End Date";
            // 
            // chrtTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtTemp.ChartAreas.Add(chartArea1);
            this.chrtTemp.DataSource = this.historianBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend1);
            this.chrtTemp.Location = new System.Drawing.Point(8, 144);
            this.chrtTemp.Name = "chrtTemp";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "datetime_recorded";
            series1.YValueMembers = "value";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Orange;
            series2.Legend = "Legend1";
            series2.Name = "SpLow";
            series2.XValueMember = "datetime_recorded";
            series2.YValueMembers = "setpoint_low";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "SpHigh";
            series3.XValueMember = "datetime_recorded";
            series3.YValueMembers = "setpoint_high";
            this.chrtTemp.Series.Add(series1);
            this.chrtTemp.Series.Add(series2);
            this.chrtTemp.Series.Add(series3);
            this.chrtTemp.Size = new System.Drawing.Size(1156, 312);
            this.chrtTemp.TabIndex = 30;
            this.chrtTemp.Text = "chart1";
            // 
            // historianBindingSource
            // 
            this.historianBindingSource.DataMember = "historian";
            this.historianBindingSource.DataSource = this.dataSetToGrah;
            // 
            // dataSetToGrah
            // 
            this.dataSetToGrah.DataSetName = "DataSetToGrah";
            this.dataSetToGrah.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tmrStatus
            // 
            this.tmrStatus.Interval = 1000;
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // historianTableAdapter
            // 
            this.historianTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Current Temperature";
            // 
            // tmrAlarm
            // 
            this.tmrAlarm.Interval = 5000;
            this.tmrAlarm.Tick += new System.EventHandler(this.tmrAlarm_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Start Date";
            // 
            // btnSubView
            // 
            this.btnSubView.Location = new System.Drawing.Point(240, 109);
            this.btnSubView.Name = "btnSubView";
            this.btnSubView.Size = new System.Drawing.Size(75, 23);
            this.btnSubView.TabIndex = 59;
            this.btnSubView.Text = "Submit View";
            this.btnSubView.UseVisualStyleBackColor = true;
            this.btnSubView.Click += new System.EventHandler(this.btnSubView_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alarmeventidDataGridViewTextBoxColumn,
            this.datetimerecordedDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alarmhistorianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(536, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 104);
            this.dataGridView1.TabIndex = 60;
            // 
            // alarmeventidDataGridViewTextBoxColumn
            // 
            this.alarmeventidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alarmeventidDataGridViewTextBoxColumn.DataPropertyName = "alarm_event_id";
            this.alarmeventidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.alarmeventidDataGridViewTextBoxColumn.Name = "alarmeventidDataGridViewTextBoxColumn";
            this.alarmeventidDataGridViewTextBoxColumn.Width = 43;
            // 
            // datetimerecordedDataGridViewTextBoxColumn
            // 
            this.datetimerecordedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datetimerecordedDataGridViewTextBoxColumn.DataPropertyName = "datetime_recorded";
            this.datetimerecordedDataGridViewTextBoxColumn.HeaderText = "Occurred";
            this.datetimerecordedDataGridViewTextBoxColumn.Name = "datetimerecordedDataGridViewTextBoxColumn";
            this.datetimerecordedDataGridViewTextBoxColumn.Width = 76;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // alarmhistorianBindingSource
            // 
            this.alarmhistorianBindingSource.DataMember = "alarm_historian";
            this.alarmhistorianBindingSource.DataSource = this.ctsDataSetAlarm;
            // 
            // ctsDataSetAlarm
            // 
            this.ctsDataSetAlarm.DataSetName = "ctsDataSetAlarm";
            this.ctsDataSetAlarm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarm_historianTableAdapter
            // 
            this.alarm_historianTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chrtTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabin Temperature System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Timer tmrTemp;
        private System.Windows.Forms.Timer tmrRecToDb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTemp;
        private DataSetToGrah dataSetToGrah;
        private System.Windows.Forms.BindingSource historianBindingSource;
        private DataSetToGrahTableAdapters.historianTableAdapter historianTableAdapter;
        private System.Windows.Forms.Timer tmrStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubView;
        private System.Windows.Forms.Label lblMySql;
        private System.Windows.Forms.ToolStripMenuItem subscribersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ctsDataSetAlarm ctsDataSetAlarm;
        private System.Windows.Forms.BindingSource alarmhistorianBindingSource;
        private ctsDataSetAlarmTableAdapters.alarm_historianTableAdapter alarm_historianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmeventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimerecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}