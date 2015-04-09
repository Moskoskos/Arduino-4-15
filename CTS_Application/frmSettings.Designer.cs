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
            this.SuspendLayout();
            // 
            // btnDelRec
            // 
            this.btnDelRec.Location = new System.Drawing.Point(8, 8);
            this.btnDelRec.Name = "btnDelRec";
            this.btnDelRec.Size = new System.Drawing.Size(144, 23);
            this.btnDelRec.TabIndex = 0;
            this.btnDelRec.Text = "Delete Recordings";
            this.btnDelRec.UseVisualStyleBackColor = true;
            this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);
            // 
            // btnDelAla
            // 
            this.btnDelAla.Location = new System.Drawing.Point(8, 40);
            this.btnDelAla.Name = "btnDelAla";
            this.btnDelAla.Size = new System.Drawing.Size(144, 23);
            this.btnDelAla.TabIndex = 4;
            this.btnDelAla.Text = "Delete Alarms";
            this.btnDelAla.UseVisualStyleBackColor = true;
            this.btnDelAla.Click += new System.EventHandler(this.btnDelAla_Click);
            // 
            // btnDelSub
            // 
            this.btnDelSub.Location = new System.Drawing.Point(8, 72);
            this.btnDelSub.Name = "btnDelSub";
            this.btnDelSub.Size = new System.Drawing.Size(144, 23);
            this.btnDelSub.TabIndex = 5;
            this.btnDelSub.Text = "Delete Subscribers";
            this.btnDelSub.UseVisualStyleBackColor = true;
            this.btnDelSub.Click += new System.EventHandler(this.btnDelSub_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 408);
            this.Controls.Add(this.btnDelSub);
            this.Controls.Add(this.btnDelAla);
            this.Controls.Add(this.btnDelRec);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelRec;
        private System.Windows.Forms.Button btnDelAla;
        private System.Windows.Forms.Button btnDelSub;
    }
}