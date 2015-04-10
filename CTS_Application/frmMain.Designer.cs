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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tmrSimTemp = new System.Windows.Forms.Timer(this.components);
            this.tmrRecToDb = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHysteresis = new System.Windows.Forms.TextBox();
            this.txtSpH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMemory = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetAlarmEvents = new CTS_Application.dataSetAlarmEvents();
            this.alarmhistorianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarm_historianTableAdapter = new CTS_Application.dataSetAlarmEventsTableAdapters.alarm_historianTableAdapter();
            this.chrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimerecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmeventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetToGrah = new CTS_Application.DataSetToGrah();
            this.historianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historianTableAdapter = new CTS_Application.DataSetToGrahTableAdapters.historianTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlarmEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).BeginInit();
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
            // btnSubscribers
            // 
            this.btnSubscribers.Location = new System.Drawing.Point(24, 88);
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
            this.lblTimeLeft.Location = new System.Drawing.Point(216, 16);
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
            // txtSpL
            // 
            this.txtSpL.Location = new System.Drawing.Point(136, 56);
            this.txtSpL.Name = "txtSpL";
            this.txtSpL.Size = new System.Drawing.Size(100, 20);
            this.txtSpL.TabIndex = 23;
            this.txtSpL.Text = "3";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(24, 56);
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
            this.btnSubmit.Location = new System.Drawing.Point(608, 56);
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
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Current Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Setpoint Low";
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
            this.menuSettings});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(116, 22);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // txtHysteresis
            // 
            this.txtHysteresis.Location = new System.Drawing.Point(360, 56);
            this.txtHysteresis.Name = "txtHysteresis";
            this.txtHysteresis.Size = new System.Drawing.Size(100, 20);
            this.txtHysteresis.TabIndex = 41;
            this.txtHysteresis.Text = "3";
            // 
            // txtSpH
            // 
            this.txtSpH.Location = new System.Drawing.Point(248, 56);
            this.txtSpH.Name = "txtSpH";
            this.txtSpH.Size = new System.Drawing.Size(100, 20);
            this.txtSpH.TabIndex = 43;
            this.txtSpH.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Hysteresis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Setpoint High";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lblMemory);
            this.panel1.Controls.Add(this.lblPercentage);
            this.panel1.Controls.Add(this.lblTimeLeft);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 40);
            this.panel1.TabIndex = 47;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(1144, 16);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(78, 13);
            this.lblMemory.TabIndex = 22;
            this.lblMemory.Text = "Memory Usage";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 440);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1024, 440);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 50;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "End Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Summer",
            "Autumn",
            "Winter",
            "Spring"});
            this.comboBox1.Location = new System.Drawing.Point(472, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Period?";
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
            this.dataGridView1.Location = new System.Drawing.Point(816, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 112);
            this.dataGridView1.TabIndex = 55;
            // 
            // dataSetAlarmEvents
            // 
            this.dataSetAlarmEvents.DataSetName = "dataSetAlarmEvents";
            this.dataSetAlarmEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarmhistorianBindingSource
            // 
            this.alarmhistorianBindingSource.DataMember = "alarm_historian";
            this.alarmhistorianBindingSource.DataSource = this.dataSetAlarmEvents;
            // 
            // alarm_historianTableAdapter
            // 
            this.alarm_historianTableAdapter.ClearBeforeFill = true;
            // 
            // chrtTemp
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtTemp.ChartAreas.Add(chartArea4);
            this.chrtTemp.DataSource = this.historianBindingSource;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chrtTemp.Legends.Add(legend4);
            this.chrtTemp.Location = new System.Drawing.Point(8, 144);
            this.chrtTemp.Name = "chrtTemp";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "datetime_recorded";
            series4.YValueMembers = "value";
            this.chrtTemp.Series.Add(series4);
            this.chrtTemp.Size = new System.Drawing.Size(1256, 288);
            this.chrtTemp.TabIndex = 30;
            this.chrtTemp.Text = "chart1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimerecordedDataGridViewTextBoxColumn
            // 
            this.datetimerecordedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datetimerecordedDataGridViewTextBoxColumn.DataPropertyName = "datetime_recorded";
            this.datetimerecordedDataGridViewTextBoxColumn.HeaderText = "datetime_recorded";
            this.datetimerecordedDataGridViewTextBoxColumn.Name = "datetimerecordedDataGridViewTextBoxColumn";
            this.datetimerecordedDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimerecordedDataGridViewTextBoxColumn.Width = 120;
            // 
            // alarmeventidDataGridViewTextBoxColumn
            // 
            this.alarmeventidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alarmeventidDataGridViewTextBoxColumn.DataPropertyName = "alarm_event_id";
            this.alarmeventidDataGridViewTextBoxColumn.HeaderText = "alarm_event_id";
            this.alarmeventidDataGridViewTextBoxColumn.Name = "alarmeventidDataGridViewTextBoxColumn";
            this.alarmeventidDataGridViewTextBoxColumn.ReadOnly = true;
            this.alarmeventidDataGridViewTextBoxColumn.Width = 104;
            // 
            // dataSetToGrah
            // 
            this.dataSetToGrah.DataSetName = "DataSetToGrah";
            this.dataSetToGrah.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historianBindingSource
            // 
            this.historianBindingSource.DataMember = "historian";
            this.historianBindingSource.DataSource = this.dataSetToGrah;
            // 
            // historianTableAdapter
            // 
            this.historianTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Update Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpH);
            this.Controls.Add(this.txtHysteresis);
            this.Controls.Add(this.chrtTemp);
            this.Controls.Add(this.txtSpL);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubscribers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cabin Temperature System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlarmEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmhistorianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToGrah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historianBindingSource)).EndInit();
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
        private System.Windows.Forms.Timer tmrSimTemp;
        private System.Windows.Forms.Timer tmrRecToDb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHysteresis;
        private System.Windows.Forms.TextBox txtSpH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dataSetAlarmEvents dataSetAlarmEvents;
        private System.Windows.Forms.BindingSource alarmhistorianBindingSource;
        private dataSetAlarmEventsTableAdapters.alarm_historianTableAdapter alarm_historianTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmeventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimerecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataSetToGrah dataSetToGrah;
        private System.Windows.Forms.BindingSource historianBindingSource;
        private DataSetToGrahTableAdapters.historianTableAdapter historianTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}