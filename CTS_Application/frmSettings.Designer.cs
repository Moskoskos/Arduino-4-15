namespace CTS_Application
{
    partial class frmSettings
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
            this.btnDelRec = new System.Windows.Forms.Button();
            this.btnDelAla = new System.Windows.Forms.Button();
            this.btnDelSub = new System.Windows.Forms.Button();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubCom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpH = new System.Windows.Forms.TextBox();
            this.txtSpL = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(8, 8);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(176, 23);
            this.btnDelRec.TabIndex = 0;
            this.btnDelRec.Text = "Delete Temperature Recordings";
            this.btnDelRec.UseVisualStyleBackColor = true;
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnDelAla
            // 
            this.btnDelAla.Location = new System.Drawing.Point(8, 40);
            this.btnDelAla.Name = "btnDelAla";
            this.btnDelAla.Size = new System.Drawing.Size(176, 23);
            this.btnDelAla.TabIndex = 4;
            this.btnDelAla.Text = "Delete Alarm Recordings";
            this.btnDelAla.UseVisualStyleBackColor = true;
            this.btnDelAla.Click += new System.EventHandler(this.btnDelAla_Click);
            // 
            // btnDelSub
            // 
            this.btnDelSub.Location = new System.Drawing.Point(8, 72);
            this.btnDelSub.Name = "btnDelSub";
            this.btnDelSub.Size = new System.Drawing.Size(176, 23);
            this.btnDelSub.TabIndex = 5;
            this.btnDelSub.Text = "Delete Subscribers";
            this.btnDelSub.UseVisualStyleBackColor = true;
            this.btnDelSub.Click += new System.EventHandler(this.btnDelSub_Click);
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(8, 120);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ComPort";
            // 
            // btnSubCom
            // 
            this.btnSubCom.Location = new System.Drawing.Point(120, 120);
            this.btnSubCom.Name = "btnSubCom";
            this.btnSubCom.Size = new System.Drawing.Size(75, 23);
            this.btnSubCom.TabIndex = 8;
            this.btnSubCom.Text = "Submit";
            this.btnSubCom.UseVisualStyleBackColor = true;
            this.btnSubCom.Click += new System.EventHandler(this.btnSubCom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Setpoint High";
            // 
            // txtSpH
            // 
            this.txtSpH.Location = new System.Drawing.Point(120, 176);
            this.txtSpH.Name = "txtSpH";
            this.txtSpH.Size = new System.Drawing.Size(100, 20);
            this.txtSpH.TabIndex = 47;
            this.txtSpH.Text = "0";
            // 
            // txtSpL
            // 
            this.txtSpL.Location = new System.Drawing.Point(8, 176);
            this.txtSpL.Name = "txtSpL";
            this.txtSpL.Size = new System.Drawing.Size(100, 20);
            this.txtSpL.TabIndex = 46;
            this.txtSpL.Text = "0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(232, 176);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(64, 23);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Setpoint Low";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpH);
            this.Controls.Add(this.txtSpL);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.btnDelSub);
            this.Controls.Add(this.btnDelAla);
            this.Controls.Add(this.btnDelRec);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnDelAla;
        private System.Windows.Forms.Button btnDelSub;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpH;
        private System.Windows.Forms.TextBox txtSpL;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
    }
}