namespace CTS_Application
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCV = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.historianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetToGrah = new CTS_Application.DataSetToGrah();
            this.historianTableAdapter = new CTS_Application.DataSetToGrahTableAdapters.historianTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmeventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimerecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmhistorianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctsDataSetAlarm = new CTS_Application.ctsDataSetAlarm();
            this.alarm_historianTableAdapter = new CTS_Application.ctsDataSetAlarmTableAdapters.alarm_historianTableAdapter();
            this.tmrUpdateGui = new System.Windows.Forms.Timer(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblMySql = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblStateConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblBatConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsprgBat = new System.Windows.Forms.ToolStripProgressBar();
            this.tslblBat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblDBStatConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblDBStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblRAMConst = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsprgRAM = new System.Windows.Forms.ToolStripProgressBar();
            this.tslblRAM = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetAlarm)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(24, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
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
            chartArea2.Name = "ChartArea1";
            this.chrtTemp.ChartAreas.Add(chartArea2);
            this.chrtTemp.DataSource = this.historianBindingSource;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend2);
            this.chrtTemp.Location = new System.Drawing.Point(8, 144);
            this.chrtTemp.Name = "chrtTemp";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Blue;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "datetime_recorded";
            series4.YValueMembers = "value";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Orange;
            series5.Legend = "Legend1";
            series5.Name = "SpLow";
            series5.XValueMember = "datetime_recorded";
            series5.YValueMembers = "setpoint_low";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "SpHigh";
            series6.XValueMember = "datetime_recorded";
            series6.YValueMembers = "setpoint_high";
            this.chrtTemp.Series.Add(series4);
            this.chrtTemp.Series.Add(series5);
            this.chrtTemp.Series.Add(series6);
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
            // tmrUpdateGui
            // 
            this.tmrUpdateGui.Interval = 2000;
            this.tmrUpdateGui.Tick += new System.EventHandler(this.tmrUpdateGui_Tick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(16, 4);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "State";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(237, 4);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(51, 13);
            this.lblTimeLeft.TabIndex = 20;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(136, 4);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 18;
            this.lblPercentage.Text = "Percentage";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(1044, 4);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(78, 13);
            this.lblMemory.TabIndex = 22;
            this.lblMemory.Text = "Memory Usage";
            // 
            // lblMySql
            // 
            this.lblMySql.AutoSize = true;
            this.lblMySql.Location = new System.Drawing.Point(872, 4);
            this.lblMySql.Name = "lblMySql";
            this.lblMySql.Size = new System.Drawing.Size(141, 13);
            this.lblMySql.TabIndex = 58;
            this.lblMySql.Text = "MySQL Status: Not Running";
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
            this.panel1.Size = new System.Drawing.Size(1119, 40);
            this.panel1.TabIndex = 47;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStateConst,
            this.tslblState,
            this.tslblBatConst,
            this.tsprgBat,
            this.tslblBat,
            this.tslblDBStatConst,
            this.tslblDBStat,
            this.tslblRAMConst,
            this.tsprgRAM,
            this.tslblRAM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblStateConst
            // 
            this.tslblStateConst.Name = "tslblStateConst";
            this.tslblStateConst.Size = new System.Drawing.Size(36, 17);
            this.tslblStateConst.Text = "State:";
            // 
            // tslblState
            // 
            this.tslblState.Name = "tslblState";
            this.tslblState.Size = new System.Drawing.Size(29, 17);
            this.tslblState.Text = "N/A";
            // 
            // tslblBatConst
            // 
            this.tslblBatConst.Name = "tslblBatConst";
            this.tslblBatConst.Size = new System.Drawing.Size(47, 17);
            this.tslblBatConst.Text = "Battery:";
            // 
            // tsprgBat
            // 
            this.tsprgBat.Name = "tsprgBat";
            this.tsprgBat.Size = new System.Drawing.Size(100, 16);
            // 
            // tslblBat
            // 
            this.tslblBat.Name = "tslblBat";
            this.tslblBat.Size = new System.Drawing.Size(29, 17);
            this.tslblBat.Text = "N/A";
            // 
            // tslblDBStatConst
            // 
            this.tslblDBStatConst.Name = "tslblDBStatConst";
            this.tslblDBStatConst.Size = new System.Drawing.Size(92, 17);
            this.tslblDBStatConst.Text = "Database status:";
            // 
            // tslblDBStat
            // 
            this.tslblDBStat.Name = "tslblDBStat";
            this.tslblDBStat.Size = new System.Drawing.Size(29, 17);
            this.tslblDBStat.Text = "N/A";
            // 
            // tslblRAMConst
            // 
            this.tslblRAMConst.Name = "tslblRAMConst";
            this.tslblRAMConst.Size = new System.Drawing.Size(110, 17);
            this.tslblRAMConst.Text = "Memory utilization:";
            // 
            // tsprgRAM
            // 
            this.tsprgRAM.Name = "tsprgRAM";
            this.tsprgRAM.Size = new System.Drawing.Size(100, 16);
            // 
            // tslblRAM
            // 
            this.tslblRAM.Name = "tslblRAM";
            this.tslblRAM.Size = new System.Drawing.Size(30, 17);
            this.tslblRAM.Text = ".../...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 504);
            this.Controls.Add(this.statusStrip1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctsDataSetAlarm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTemp;
        private DataSetToGrah dataSetToGrah;
        private System.Windows.Forms.BindingSource historianBindingSource;
        private DataSetToGrahTableAdapters.historianTableAdapter historianTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubView;
        private System.Windows.Forms.ToolStripMenuItem subscribersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ctsDataSetAlarm ctsDataSetAlarm;
        private System.Windows.Forms.BindingSource alarmhistorianBindingSource;
        private ctsDataSetAlarmTableAdapters.alarm_historianTableAdapter alarm_historianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmeventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimerecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer tmrUpdateGui;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblMySql;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblStateConst;
        private System.Windows.Forms.ToolStripStatusLabel tslblState;
        private System.Windows.Forms.ToolStripStatusLabel tslblBatConst;
        private System.Windows.Forms.ToolStripProgressBar tsprgBat;
        private System.Windows.Forms.ToolStripStatusLabel tslblBat;
        private System.Windows.Forms.ToolStripStatusLabel tslblDBStatConst;
        private System.Windows.Forms.ToolStripStatusLabel tslblDBStat;
        private System.Windows.Forms.ToolStripStatusLabel tslblRAMConst;
        private System.Windows.Forms.ToolStripProgressBar tsprgRAM;
        private System.Windows.Forms.ToolStripStatusLabel tslblRAM;
    }
}