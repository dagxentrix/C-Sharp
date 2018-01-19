namespace Trening_test
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
            this.lvlOvelser = new System.Windows.Forms.Label();
            this.listOvelser = new System.Windows.Forms.ListBox();
            this.listTreningData = new System.Windows.Forms.ListBox();
            this.lvlTreningData = new System.Windows.Forms.Label();
            this.btnLeggTilData = new System.Windows.Forms.Button();
            this.txtVekt = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtOvelseNavn = new System.Windows.Forms.TextBox();
            this.btnNyOvelse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlOvelser
            // 
            this.lvlOvelser.AutoSize = true;
            this.lvlOvelser.Location = new System.Drawing.Point(9, 40);
            this.lvlOvelser.Name = "lvlOvelser";
            this.lvlOvelser.Size = new System.Drawing.Size(43, 13);
            this.lvlOvelser.TabIndex = 0;
            this.lvlOvelser.Text = "Øvelser";
            // 
            // listOvelser
            // 
            this.listOvelser.FormattingEnabled = true;
            this.listOvelser.Location = new System.Drawing.Point(12, 84);
            this.listOvelser.Name = "listOvelser";
            this.listOvelser.Size = new System.Drawing.Size(151, 225);
            this.listOvelser.TabIndex = 1;
            this.listOvelser.SelectedIndexChanged += new System.EventHandler(this.listOvelser_SelectedIndexChanged);
            // 
            // listTreningData
            // 
            this.listTreningData.FormattingEnabled = true;
            this.listTreningData.Location = new System.Drawing.Point(327, 84);
            this.listTreningData.Name = "listTreningData";
            this.listTreningData.Size = new System.Drawing.Size(208, 147);
            this.listTreningData.TabIndex = 3;
            this.listTreningData.SelectedIndexChanged += new System.EventHandler(this.listTreningData_SelectedIndexChanged);
            // 
            // lvlTreningData
            // 
            this.lvlTreningData.AutoSize = true;
            this.lvlTreningData.Location = new System.Drawing.Point(324, 40);
            this.lvlTreningData.Name = "lvlTreningData";
            this.lvlTreningData.Size = new System.Drawing.Size(48, 13);
            this.lvlTreningData.TabIndex = 2;
            this.lvlTreningData.Text = "Historikk";
            // 
            // btnLeggTilData
            // 
            this.btnLeggTilData.Location = new System.Drawing.Point(563, 164);
            this.btnLeggTilData.Name = "btnLeggTilData";
            this.btnLeggTilData.Size = new System.Drawing.Size(75, 23);
            this.btnLeggTilData.TabIndex = 4;
            this.btnLeggTilData.Text = "Legg til data";
            this.btnLeggTilData.UseVisualStyleBackColor = true;
            this.btnLeggTilData.Click += new System.EventHandler(this.btnLeggTilData_Click);
            // 
            // txtVekt
            // 
            this.txtVekt.Location = new System.Drawing.Point(563, 84);
            this.txtVekt.Name = "txtVekt";
            this.txtVekt.Size = new System.Drawing.Size(100, 20);
            this.txtVekt.TabIndex = 5;
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(563, 111);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(100, 20);
            this.txtRep.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(72, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(12, 365);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(75, 23);
            this.btnShowHide.TabIndex = 9;
            this.btnShowHide.Text = "Vis valg";
            this.btnShowHide.UseVisualStyleBackColor = true;
            // 
            // txtOvelseNavn
            // 
            this.txtOvelseNavn.Location = new System.Drawing.Point(179, 84);
            this.txtOvelseNavn.Name = "txtOvelseNavn";
            this.txtOvelseNavn.Size = new System.Drawing.Size(100, 20);
            this.txtOvelseNavn.TabIndex = 10;
            // 
            // btnNyOvelse
            // 
            this.btnNyOvelse.Location = new System.Drawing.Point(179, 164);
            this.btnNyOvelse.Name = "btnNyOvelse";
            this.btnNyOvelse.Size = new System.Drawing.Size(75, 23);
            this.btnNyOvelse.TabIndex = 11;
            this.btnNyOvelse.Text = "Legg til øvelse";
            this.btnNyOvelse.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 515);
            this.Controls.Add(this.btnNyOvelse);
            this.Controls.Add(this.txtOvelseNavn);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.txtVekt);
            this.Controls.Add(this.btnLeggTilData);
            this.Controls.Add(this.listTreningData);
            this.Controls.Add(this.lvlTreningData);
            this.Controls.Add(this.listOvelser);
            this.Controls.Add(this.lvlOvelser);
            this.Name = "formMain";
            this.Text = "Trening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlOvelser;
        private System.Windows.Forms.ListBox listOvelser;
        private System.Windows.Forms.ListBox listTreningData;
        private System.Windows.Forms.Label lvlTreningData;
        private System.Windows.Forms.Button btnLeggTilData;
        private System.Windows.Forms.TextBox txtVekt;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox txtOvelseNavn;
        private System.Windows.Forms.Button btnNyOvelse;
    }
}

