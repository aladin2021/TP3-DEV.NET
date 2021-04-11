namespace TP3_DEV.NET
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsaisie = new System.Windows.Forms.Label();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.txt_saisie = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btn1to2 = new System.Windows.Forms.Button();
            this.btnAll1to2 = new System.Windows.Forms.Button();
            this.btnAll2to1 = new System.Windows.Forms.Button();
            this.btn2to1 = new System.Windows.Forms.Button();
            this.btn1_effacer = new System.Windows.Forms.Button();
            this.btn1_effacertout = new System.Windows.Forms.Button();
            this.btn2_effacer = new System.Windows.Forms.Button();
            this.btn2_effacertout = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsaisie
            // 
            this.lblsaisie.AutoSize = true;
            this.lblsaisie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaisie.ForeColor = System.Drawing.Color.Red;
            this.lblsaisie.Location = new System.Drawing.Point(33, 36);
            this.lblsaisie.Name = "lblsaisie";
            this.lblsaisie.Size = new System.Drawing.Size(128, 18);
            this.lblsaisie.TabIndex = 0;
            this.lblsaisie.Text = "Saisie un texte ";
            this.lblsaisie.Click += new System.EventHandler(this.lblsaisie_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(415, 31);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(116, 23);
            this.btn_Ajouter.TabIndex = 1;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // txt_saisie
            // 
            this.txt_saisie.Location = new System.Drawing.Point(187, 34);
            this.txt_saisie.Name = "txt_saisie";
            this.txt_saisie.Size = new System.Drawing.Size(198, 20);
            this.txt_saisie.TabIndex = 2;
            this.txt_saisie.TextChanged += new System.EventHandler(this.txt_saisie_TextChanged);
            // 
            // lst1
            // 
            this.lst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst1.ForeColor = System.Drawing.Color.Maroon;
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(12, 81);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(200, 124);
            this.lst1.TabIndex = 3;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // lst2
            // 
            this.lst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 15;
            this.lst2.Location = new System.Drawing.Point(378, 81);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(220, 124);
            this.lst2.TabIndex = 4;
            this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
            // 
            // btn1to2
            // 
            this.btn1to2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1to2.ForeColor = System.Drawing.Color.Maroon;
            this.btn1to2.Location = new System.Drawing.Point(247, 85);
            this.btn1to2.Name = "btn1to2";
            this.btn1to2.Size = new System.Drawing.Size(98, 23);
            this.btn1to2.TabIndex = 5;
            this.btn1to2.Text = ">";
            this.btn1to2.UseVisualStyleBackColor = true;
            this.btn1to2.Click += new System.EventHandler(this.btn1to2_Click);
            // 
            // btnAll1to2
            // 
            this.btnAll1to2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll1to2.ForeColor = System.Drawing.Color.Maroon;
            this.btnAll1to2.Location = new System.Drawing.Point(247, 114);
            this.btnAll1to2.Name = "btnAll1to2";
            this.btnAll1to2.Size = new System.Drawing.Size(98, 23);
            this.btnAll1to2.TabIndex = 6;
            this.btnAll1to2.Text = ">>";
            this.btnAll1to2.UseVisualStyleBackColor = true;
            this.btnAll1to2.Click += new System.EventHandler(this.btnAll1to2_Click);
            // 
            // btnAll2to1
            // 
            this.btnAll2to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll2to1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAll2to1.Location = new System.Drawing.Point(247, 143);
            this.btnAll2to1.Name = "btnAll2to1";
            this.btnAll2to1.Size = new System.Drawing.Size(98, 23);
            this.btnAll2to1.TabIndex = 7;
            this.btnAll2to1.Text = "<<";
            this.btnAll2to1.UseVisualStyleBackColor = true;
            this.btnAll2to1.Click += new System.EventHandler(this.btnAll2to1_Click);
            // 
            // btn2to1
            // 
            this.btn2to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2to1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2to1.Location = new System.Drawing.Point(247, 172);
            this.btn2to1.Name = "btn2to1";
            this.btn2to1.Size = new System.Drawing.Size(98, 23);
            this.btn2to1.TabIndex = 8;
            this.btn2to1.Text = "<";
            this.btn2to1.UseVisualStyleBackColor = true;
            this.btn2to1.Click += new System.EventHandler(this.btn2to1_Click);
            // 
            // btn1_effacer
            // 
            this.btn1_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_effacer.ForeColor = System.Drawing.Color.Maroon;
            this.btn1_effacer.Location = new System.Drawing.Point(12, 224);
            this.btn1_effacer.Name = "btn1_effacer";
            this.btn1_effacer.Size = new System.Drawing.Size(89, 23);
            this.btn1_effacer.TabIndex = 9;
            this.btn1_effacer.Text = "Effacer";
            this.btn1_effacer.UseVisualStyleBackColor = true;
            this.btn1_effacer.Click += new System.EventHandler(this.btn1_effacer_Click);
            // 
            // btn1_effacertout
            // 
            this.btn1_effacertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_effacertout.ForeColor = System.Drawing.Color.Maroon;
            this.btn1_effacertout.Location = new System.Drawing.Point(120, 224);
            this.btn1_effacertout.Name = "btn1_effacertout";
            this.btn1_effacertout.Size = new System.Drawing.Size(92, 23);
            this.btn1_effacertout.TabIndex = 10;
            this.btn1_effacertout.Text = "Effacer Tout";
            this.btn1_effacertout.UseVisualStyleBackColor = true;
            this.btn1_effacertout.Click += new System.EventHandler(this.btn1_effacertout_Click);
            // 
            // btn2_effacer
            // 
            this.btn2_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_effacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2_effacer.Location = new System.Drawing.Point(378, 224);
            this.btn2_effacer.Name = "btn2_effacer";
            this.btn2_effacer.Size = new System.Drawing.Size(97, 23);
            this.btn2_effacer.TabIndex = 11;
            this.btn2_effacer.Text = "Effacer ()";
            this.btn2_effacer.UseVisualStyleBackColor = true;
            this.btn2_effacer.Click += new System.EventHandler(this.btn2_effacer_Click);
            // 
            // btn2_effacertout
            // 
            this.btn2_effacertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_effacertout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2_effacertout.Location = new System.Drawing.Point(507, 224);
            this.btn2_effacertout.Name = "btn2_effacertout";
            this.btn2_effacertout.Size = new System.Drawing.Size(91, 23);
            this.btn2_effacertout.TabIndex = 12;
            this.btn2_effacertout.Text = "Effacer Tout ()";
            this.btn2_effacertout.UseVisualStyleBackColor = true;
            this.btn2_effacertout.Click += new System.EventHandler(this.btn2_effacertout_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitter.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_quitter.Location = new System.Drawing.Point(247, 275);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(106, 38);
            this.btn_quitter.TabIndex = 13;
            this.btn_quitter.Text = "Quitter tp3";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(743, 325);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn2_effacertout);
            this.Controls.Add(this.btn2_effacer);
            this.Controls.Add(this.btn1_effacertout);
            this.Controls.Add(this.btn1_effacer);
            this.Controls.Add(this.btn2to1);
            this.Controls.Add(this.btnAll2to1);
            this.Controls.Add(this.btnAll1to2);
            this.Controls.Add(this.btn1to2);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.txt_saisie);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.lblsaisie);
            this.Name = "Form1";
            this.Text = "tp3 dev.net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsaisie;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox txt_saisie;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btn1to2;
        private System.Windows.Forms.Button btnAll1to2;
        private System.Windows.Forms.Button btnAll2to1;
        private System.Windows.Forms.Button btn2to1;
        private System.Windows.Forms.Button btn1_effacer;
        private System.Windows.Forms.Button btn1_effacertout;
        private System.Windows.Forms.Button btn2_effacer;
        private System.Windows.Forms.Button btn2_effacertout;
        private System.Windows.Forms.Button btn_quitter;
    }
}

