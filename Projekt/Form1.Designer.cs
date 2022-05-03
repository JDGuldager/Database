namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistrerNavn = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.næsteKnap = new System.Windows.Forms.Button();
            this.telLabel = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.dataKomplet = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lejBox = new System.Windows.Forms.TextBox();
            this.visKnap = new System.Windows.Forms.Button();
            this.søgLabel = new System.Windows.Forms.Label();
            this.søgBox = new System.Windows.Forms.TextBox();
            this.søgKnap = new System.Windows.Forms.Button();
            this.nyLabel = new System.Windows.Forms.Label();
            this.navnLabel = new System.Windows.Forms.Label();
            this.byLabel = new System.Windows.Forms.Label();
            this.byBox = new System.Windows.Forms.TextBox();
            this.postnrLabel = new System.Windows.Forms.Label();
            this.postnrBox = new System.Windows.Forms.TextBox();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.efterNavn = new System.Windows.Forms.Label();
            this.efterNavnBox = new System.Windows.Forms.TextBox();
            this.forNavnBox = new System.Windows.Forms.TextBox();
            this.gemKnap = new System.Windows.Forms.Button();
            this.RegistrerNavn.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrerNavn
            // 
            this.RegistrerNavn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegistrerNavn.Controls.Add(this.dateTimePicker1);
            this.RegistrerNavn.Controls.Add(this.label3);
            this.RegistrerNavn.Controls.Add(this.emailBox);
            this.RegistrerNavn.Controls.Add(this.næsteKnap);
            this.RegistrerNavn.Controls.Add(this.telLabel);
            this.RegistrerNavn.Controls.Add(this.telBox);
            this.RegistrerNavn.Controls.Add(this.dataKomplet);
            this.RegistrerNavn.Controls.Add(this.label2);
            this.RegistrerNavn.Controls.Add(this.label1);
            this.RegistrerNavn.Controls.Add(this.lejBox);
            this.RegistrerNavn.Controls.Add(this.visKnap);
            this.RegistrerNavn.Controls.Add(this.søgLabel);
            this.RegistrerNavn.Controls.Add(this.søgBox);
            this.RegistrerNavn.Controls.Add(this.søgKnap);
            this.RegistrerNavn.Controls.Add(this.nyLabel);
            this.RegistrerNavn.Controls.Add(this.navnLabel);
            this.RegistrerNavn.Controls.Add(this.byLabel);
            this.RegistrerNavn.Controls.Add(this.byBox);
            this.RegistrerNavn.Controls.Add(this.postnrLabel);
            this.RegistrerNavn.Controls.Add(this.postnrBox);
            this.RegistrerNavn.Controls.Add(this.adresseLabel);
            this.RegistrerNavn.Controls.Add(this.adresseBox);
            this.RegistrerNavn.Controls.Add(this.efterNavn);
            this.RegistrerNavn.Controls.Add(this.efterNavnBox);
            this.RegistrerNavn.Controls.Add(this.forNavnBox);
            this.RegistrerNavn.Controls.Add(this.gemKnap);
            this.RegistrerNavn.Location = new System.Drawing.Point(2, -10);
            this.RegistrerNavn.Name = "RegistrerNavn";
            this.RegistrerNavn.Size = new System.Drawing.Size(1092, 468);
            this.RegistrerNavn.TabIndex = 0;
            this.RegistrerNavn.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(868, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(158, 253);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(293, 23);
            this.emailBox.TabIndex = 7;
            // 
            // næsteKnap
            // 
            this.næsteKnap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.næsteKnap.Location = new System.Drawing.Point(498, 386);
            this.næsteKnap.Name = "næsteKnap";
            this.næsteKnap.Size = new System.Drawing.Size(570, 62);
            this.næsteKnap.TabIndex = 27;
            this.næsteKnap.TabStop = false;
            this.næsteKnap.Text = "Næste 15";
            this.næsteKnap.UseVisualStyleBackColor = false;
            this.næsteKnap.Click += new System.EventHandler(this.næsteKnap_Click);
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telLabel.Location = new System.Drawing.Point(17, 224);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(53, 21);
            this.telLabel.TabIndex = 26;
            this.telLabel.Text = "Mobil:";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(158, 226);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(293, 23);
            this.telBox.TabIndex = 6;
            // 
            // dataKomplet
            // 
            this.dataKomplet.FullRowSelect = true;
            this.dataKomplet.GridLines = true;
            this.dataKomplet.Location = new System.Drawing.Point(498, 51);
            this.dataKomplet.Name = "dataKomplet";
            this.dataKomplet.Size = new System.Drawing.Size(570, 329);
            this.dataKomplet.TabIndex = 24;
            this.dataKomplet.TabStop = false;
            this.dataKomplet.UseCompatibleStateImageBehavior = false;
            this.dataKomplet.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "* = Ikke nødvendig";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lejlighed: *";
            // 
            // lejBox
            // 
            this.lejBox.Location = new System.Drawing.Point(158, 147);
            this.lejBox.Name = "lejBox";
            this.lejBox.Size = new System.Drawing.Size(293, 23);
            this.lejBox.TabIndex = 3;
            // 
            // visKnap
            // 
            this.visKnap.Location = new System.Drawing.Point(498, 386);
            this.visKnap.Name = "visKnap";
            this.visKnap.Size = new System.Drawing.Size(570, 62);
            this.visKnap.TabIndex = 17;
            this.visKnap.Text = "Vis brugere 1-15";
            this.visKnap.UseVisualStyleBackColor = true;
            this.visKnap.Click += new System.EventHandler(this.visKnap_Click);
            // 
            // søgLabel
            // 
            this.søgLabel.AutoSize = true;
            this.søgLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.søgLabel.Location = new System.Drawing.Point(17, 350);
            this.søgLabel.Name = "søgLabel";
            this.søgLabel.Size = new System.Drawing.Size(114, 21);
            this.søgLabel.TabIndex = 16;
            this.søgLabel.Text = "Søg i database:";
            // 
            // søgBox
            // 
            this.søgBox.Location = new System.Drawing.Point(159, 352);
            this.søgBox.Name = "søgBox";
            this.søgBox.Size = new System.Drawing.Size(293, 23);
            this.søgBox.TabIndex = 8;
            // 
            // søgKnap
            // 
            this.søgKnap.Location = new System.Drawing.Point(377, 381);
            this.søgKnap.Name = "søgKnap";
            this.søgKnap.Size = new System.Drawing.Size(75, 23);
            this.søgKnap.TabIndex = 14;
            this.søgKnap.TabStop = false;
            this.søgKnap.Text = "Søg";
            this.søgKnap.UseVisualStyleBackColor = true;
            this.søgKnap.Click += new System.EventHandler(this.søgKnap_Click);
            // 
            // nyLabel
            // 
            this.nyLabel.AutoSize = true;
            this.nyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nyLabel.Location = new System.Drawing.Point(184, 45);
            this.nyLabel.Name = "nyLabel";
            this.nyLabel.Size = new System.Drawing.Size(81, 21);
            this.nyLabel.TabIndex = 13;
            this.nyLabel.Text = "Ny bruger";
            // 
            // navnLabel
            // 
            this.navnLabel.AutoSize = true;
            this.navnLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navnLabel.Location = new System.Drawing.Point(16, 67);
            this.navnLabel.Name = "navnLabel";
            this.navnLabel.Size = new System.Drawing.Size(50, 21);
            this.navnLabel.TabIndex = 12;
            this.navnLabel.Text = "Navn:";
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.byLabel.Location = new System.Drawing.Point(17, 198);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(30, 21);
            this.byLabel.TabIndex = 11;
            this.byLabel.Text = "By:";
            // 
            // byBox
            // 
            this.byBox.Location = new System.Drawing.Point(158, 200);
            this.byBox.Name = "byBox";
            this.byBox.Size = new System.Drawing.Size(293, 23);
            this.byBox.TabIndex = 5;
            // 
            // postnrLabel
            // 
            this.postnrLabel.AutoSize = true;
            this.postnrLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postnrLabel.Location = new System.Drawing.Point(16, 171);
            this.postnrLabel.Name = "postnrLabel";
            this.postnrLabel.Size = new System.Drawing.Size(57, 21);
            this.postnrLabel.TabIndex = 9;
            this.postnrLabel.Text = "Postnr:";
            // 
            // postnrBox
            // 
            this.postnrBox.Location = new System.Drawing.Point(158, 174);
            this.postnrBox.Name = "postnrBox";
            this.postnrBox.Size = new System.Drawing.Size(293, 23);
            this.postnrBox.TabIndex = 4;
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adresseLabel.Location = new System.Drawing.Point(17, 120);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(68, 21);
            this.adresseLabel.TabIndex = 7;
            this.adresseLabel.Text = "Adresse:";
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(158, 121);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(293, 23);
            this.adresseBox.TabIndex = 2;
            // 
            // efterNavn
            // 
            this.efterNavn.AutoSize = true;
            this.efterNavn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.efterNavn.Location = new System.Drawing.Point(16, 93);
            this.efterNavn.Name = "efterNavn";
            this.efterNavn.Size = new System.Drawing.Size(79, 21);
            this.efterNavn.TabIndex = 5;
            this.efterNavn.Text = "Efternavn:";
            // 
            // efterNavnBox
            // 
            this.efterNavnBox.Location = new System.Drawing.Point(158, 95);
            this.efterNavnBox.Name = "efterNavnBox";
            this.efterNavnBox.Size = new System.Drawing.Size(293, 23);
            this.efterNavnBox.TabIndex = 1;
            // 
            // forNavnBox
            // 
            this.forNavnBox.Location = new System.Drawing.Point(158, 69);
            this.forNavnBox.Name = "forNavnBox";
            this.forNavnBox.Size = new System.Drawing.Size(293, 23);
            this.forNavnBox.TabIndex = 0;
            // 
            // gemKnap
            // 
            this.gemKnap.Location = new System.Drawing.Point(375, 282);
            this.gemKnap.Name = "gemKnap";
            this.gemKnap.Size = new System.Drawing.Size(75, 23);
            this.gemKnap.TabIndex = 10;
            this.gemKnap.TabStop = false;
            this.gemKnap.Text = "Gem";
            this.gemKnap.UseVisualStyleBackColor = true;
            this.gemKnap.Click += new System.EventHandler(this.gemKnap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.RegistrerNavn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMIS Database";
            this.RegistrerNavn.ResumeLayout(false);
            this.RegistrerNavn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RegistrerNavn;
        private TextBox forNavnBox;
        private Button gemKnap;
        private Label efterNavn;
        private TextBox efterNavnBox;
        private Label postnrLabel;
        private Label adresseLabel;
        private TextBox adresseBox;
        private Label byLabel;
        private TextBox byBox;
        private DateTimePicker dateTimePicker1;
        private Label navnLabel;
        private Button visKnap;
        private Label søgLabel;
        private TextBox søgBox;
        private Button søgKnap;
        private Label nyLabel;
        private Label label2;
        private Label label1;
        private TextBox lejBox;
        private ListView dataKomplet;
        private Label telLabel;
        private TextBox telBox;
        private Button næsteKnap;
        private TextBox postnrBox;
        private Label label3;
        private TextBox emailBox;
    }
}