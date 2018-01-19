namespace TreningLog
{
    partial class formMain
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
            this.lblOvelser = new System.Windows.Forms.Label();
            this.listOvelser = new System.Windows.Forms.ListBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnLeggTilOvelse = new System.Windows.Forms.Button();
            this.txtOvelse = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOvelser
            // 
            this.lblOvelser.AutoSize = true;
            this.lblOvelser.Location = new System.Drawing.Point(9, 80);
            this.lblOvelser.Name = "lblOvelser";
            this.lblOvelser.Size = new System.Drawing.Size(43, 13);
            this.lblOvelser.TabIndex = 0;
            this.lblOvelser.Text = "Øvelser";
            // 
            // listOvelser
            // 
            this.listOvelser.FormattingEnabled = true;
            this.listOvelser.Location = new System.Drawing.Point(12, 115);
            this.listOvelser.Name = "listOvelser";
            this.listOvelser.Size = new System.Drawing.Size(120, 95);
            this.listOvelser.TabIndex = 1;
            this.listOvelser.SelectedIndexChanged += new System.EventHandler(this.listOvelser_SelectedIndexChanged);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(138, 115);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(120, 95);
            this.listLog.TabIndex = 3;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(135, 80);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(31, 13);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Logg";
            // 
            // btnLeggTilOvelse
            // 
            this.btnLeggTilOvelse.Location = new System.Drawing.Point(37, 38);
            this.btnLeggTilOvelse.Name = "btnLeggTilOvelse";
            this.btnLeggTilOvelse.Size = new System.Drawing.Size(75, 23);
            this.btnLeggTilOvelse.TabIndex = 4;
            this.btnLeggTilOvelse.Text = "Legg til";
            this.btnLeggTilOvelse.UseVisualStyleBackColor = true;
            this.btnLeggTilOvelse.Click += new System.EventHandler(this.btnLeggTilOvelse_Click);
            // 
            // txtOvelse
            // 
            this.txtOvelse.Location = new System.Drawing.Point(12, 12);
            this.txtOvelse.Name = "txtOvelse";
            this.txtOvelse.Size = new System.Drawing.Size(100, 20);
            this.txtOvelse.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(118, 12);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 6;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 328);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtOvelse);
            this.Controls.Add(this.btnLeggTilOvelse);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.listOvelser);
            this.Controls.Add(this.lblOvelser);
            this.Name = "formMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOvelser;
        private System.Windows.Forms.ListBox listOvelser;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnLeggTilOvelse;
        private System.Windows.Forms.TextBox txtOvelse;
        private System.Windows.Forms.TextBox txtType;
    }
}

