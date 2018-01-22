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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.listOvelser = new System.Windows.Forms.ListBox();
            this.listTreningData = new System.Windows.Forms.ListBox();
            this.btnLeggTilData = new System.Windows.Forms.Button();
            this.txtVekt = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtOvelseNavn = new System.Windows.Forms.TextBox();
            this.btnNyOvelse = new System.Windows.Forms.Button();
            this.lblNavnOvelse = new System.Windows.Forms.Label();
            this.lblVekt = new System.Windows.Forms.Label();
            this.lblRep = new System.Windows.Forms.Label();
            this.btnSlettOvelse = new System.Windows.Forms.Button();
            this.btnSlettData = new System.Windows.Forms.Button();
            this.btnShowHideData = new System.Windows.Forms.Button();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.comboboxNavn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // btnLeggTilData
            // 
            this.btnLeggTilData.Location = new System.Drawing.Point(563, 208);
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
            this.txtRep.Location = new System.Drawing.Point(563, 127);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(100, 20);
            this.txtRep.TabIndex = 6;
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(179, 286);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(75, 23);
            this.btnShowHide.TabIndex = 9;
            this.btnShowHide.Text = "Vis valg";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
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
            this.btnNyOvelse.Location = new System.Drawing.Point(179, 127);
            this.btnNyOvelse.Name = "btnNyOvelse";
            this.btnNyOvelse.Size = new System.Drawing.Size(75, 23);
            this.btnNyOvelse.TabIndex = 11;
            this.btnNyOvelse.Text = "Legg til øvelse";
            this.btnNyOvelse.UseVisualStyleBackColor = true;
            this.btnNyOvelse.Click += new System.EventHandler(this.btnNyOvelse_Click);
            // 
            // lblNavnOvelse
            // 
            this.lblNavnOvelse.AutoSize = true;
            this.lblNavnOvelse.BackColor = System.Drawing.Color.Transparent;
            this.lblNavnOvelse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNavnOvelse.Location = new System.Drawing.Point(179, 65);
            this.lblNavnOvelse.Name = "lblNavnOvelse";
            this.lblNavnOvelse.Size = new System.Drawing.Size(106, 17);
            this.lblNavnOvelse.TabIndex = 12;
            this.lblNavnOvelse.Text = "Navn på øvelse";
            // 
            // lblVekt
            // 
            this.lblVekt.AutoSize = true;
            this.lblVekt.BackColor = System.Drawing.Color.Transparent;
            this.lblVekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblVekt.Location = new System.Drawing.Point(563, 65);
            this.lblVekt.Name = "lblVekt";
            this.lblVekt.Size = new System.Drawing.Size(36, 17);
            this.lblVekt.TabIndex = 13;
            this.lblVekt.Text = "Vekt";
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.BackColor = System.Drawing.Color.Transparent;
            this.lblRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRep.Location = new System.Drawing.Point(563, 111);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(75, 17);
            this.lblRep.TabIndex = 14;
            this.lblRep.Text = "Repetisjon";
            // 
            // btnSlettOvelse
            // 
            this.btnSlettOvelse.Location = new System.Drawing.Point(179, 166);
            this.btnSlettOvelse.Name = "btnSlettOvelse";
            this.btnSlettOvelse.Size = new System.Drawing.Size(75, 23);
            this.btnSlettOvelse.TabIndex = 16;
            this.btnSlettOvelse.Text = "Slett Øvelse";
            this.btnSlettOvelse.UseVisualStyleBackColor = true;
            this.btnSlettOvelse.Click += new System.EventHandler(this.btnSlettOvelse_Click);
            // 
            // btnSlettData
            // 
            this.btnSlettData.Location = new System.Drawing.Point(563, 237);
            this.btnSlettData.Name = "btnSlettData";
            this.btnSlettData.Size = new System.Drawing.Size(75, 23);
            this.btnSlettData.TabIndex = 17;
            this.btnSlettData.Text = "Slett data";
            this.btnSlettData.UseVisualStyleBackColor = true;
            this.btnSlettData.Click += new System.EventHandler(this.btnSlettData_Click);
            // 
            // btnShowHideData
            // 
            this.btnShowHideData.Location = new System.Drawing.Point(563, 286);
            this.btnShowHideData.Name = "btnShowHideData";
            this.btnShowHideData.Size = new System.Drawing.Size(75, 23);
            this.btnShowHideData.TabIndex = 18;
            this.btnShowHideData.Text = "Vis valg";
            this.btnShowHideData.UseVisualStyleBackColor = true;
            this.btnShowHideData.Click += new System.EventHandler(this.btnShowHideData_Click);
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(563, 390);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(100, 20);
            this.txtPerson.TabIndex = 19;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.BackColor = System.Drawing.Color.Transparent;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPerson.Location = new System.Drawing.Point(560, 150);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(53, 17);
            this.lblPerson.TabIndex = 20;
            this.lblPerson.Text = "Person";
            // 
            // comboboxNavn
            // 
            this.comboboxNavn.FormattingEnabled = true;
            this.comboboxNavn.Items.AddRange(new object[] {
            "Frida",
            "Dag"});
            this.comboboxNavn.Location = new System.Drawing.Point(563, 168);
            this.comboboxNavn.Name = "comboboxNavn";
            this.comboboxNavn.Size = new System.Drawing.Size(100, 21);
            this.comboboxNavn.TabIndex = 22;
            this.comboboxNavn.SelectedIndexChanged += new System.EventHandler(this.comboboxNavn_SelectedIndexChanged);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Trening_test.Properties.Resources.bilde;
            this.ClientSize = new System.Drawing.Size(759, 466);
            this.Controls.Add(this.comboboxNavn);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.btnShowHideData);
            this.Controls.Add(this.btnSlettData);
            this.Controls.Add(this.btnSlettOvelse);
            this.Controls.Add(this.lblRep);
            this.Controls.Add(this.lblVekt);
            this.Controls.Add(this.lblNavnOvelse);
            this.Controls.Add(this.btnNyOvelse);
            this.Controls.Add(this.txtOvelseNavn);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.txtVekt);
            this.Controls.Add(this.btnLeggTilData);
            this.Controls.Add(this.listTreningData);
            this.Controls.Add(this.listOvelser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listOvelser;
        private System.Windows.Forms.ListBox listTreningData;
        private System.Windows.Forms.Button btnLeggTilData;
        private System.Windows.Forms.TextBox txtVekt;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox txtOvelseNavn;
        private System.Windows.Forms.Button btnNyOvelse;
        private System.Windows.Forms.Label lblNavnOvelse;
        private System.Windows.Forms.Label lblVekt;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.Button btnSlettOvelse;
        private System.Windows.Forms.Button btnSlettData;
        private System.Windows.Forms.Button btnShowHideData;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox comboboxNavn;
    }
}

