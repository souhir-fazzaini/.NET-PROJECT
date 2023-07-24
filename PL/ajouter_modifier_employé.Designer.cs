
namespace GESTION_BIBLIOTHEQUES.PL
{
    partial class ajouter_modifier_employé
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
            this.id_employé = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nationnalité = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom_employé = new System.Windows.Forms.TextBox();
            this.nom_employé = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.motdepasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // id_employé
            // 
            this.id_employé.Location = new System.Drawing.Point(239, 74);
            this.id_employé.Multiline = true;
            this.id_employé.Name = "id_employé";
            this.id_employé.Size = new System.Drawing.Size(201, 27);
            this.id_employé.TabIndex = 41;
            this.id_employé.TextChanged += new System.EventHandler(this.id_employé_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id.Location = new System.Drawing.Point(99, 75);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(31, 26);
            this.id.TabIndex = 40;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(615, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 44);
            this.button2.TabIndex = 38;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(463, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(77, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nationnalité";
            // 
            // nationnalité
            // 
            this.nationnalité.Location = new System.Drawing.Point(250, 325);
            this.nationnalité.Multiline = true;
            this.nationnalité.Name = "nationnalité";
            this.nationnalité.Size = new System.Drawing.Size(201, 25);
            this.nationnalité.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(63, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "annee de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(100, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(99, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nom";
            // 
            // prenom_employé
            // 
            this.prenom_employé.Location = new System.Drawing.Point(249, 188);
            this.prenom_employé.Multiline = true;
            this.prenom_employé.Name = "prenom_employé";
            this.prenom_employé.Size = new System.Drawing.Size(201, 23);
            this.prenom_employé.TabIndex = 31;
            // 
            // nom_employé
            // 
            this.nom_employé.Location = new System.Drawing.Point(250, 117);
            this.nom_employé.Multiline = true;
            this.nom_employé.Name = "nom_employé";
            this.nom_employé.Size = new System.Drawing.Size(201, 27);
            this.nom_employé.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(121, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ajouter employé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(63, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "mot de passe";
            // 
            // motdepasse
            // 
            this.motdepasse.Location = new System.Drawing.Point(220, 383);
            this.motdepasse.Multiline = true;
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(201, 25);
            this.motdepasse.TabIndex = 43;
            // 
            // ajouter_modifier_employé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_employé);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nationnalité);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prenom_employé);
            this.Controls.Add(this.nom_employé);
            this.Controls.Add(this.label1);
            this.Name = "ajouter_modifier_employé";
            this.Text = "ajouter_modifier_employé";
            this.Load += new System.EventHandler(this.ajouter_modifier_employé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox id_employé;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox nationnalité;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox prenom_employé;
        public System.Windows.Forms.TextBox nom_employé;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox motdepasse;
        public System.Windows.Forms.Label id;
    }
}