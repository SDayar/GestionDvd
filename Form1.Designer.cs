namespace gestionDvd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAjoutDvd = new System.Windows.Forms.Button();
            this.btnSupprDvd = new System.Windows.Forms.Button();
            this.btnModifDvd = new System.Windows.Forms.Button();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDurée = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnSupprGenre = new System.Windows.Forms.Button();
            this.btnAjoutgenre = new System.Windows.Forms.Button();
            this.txtAjtGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstActeur = new System.Windows.Forms.ListBox();
            this.btnAjoutActeurDvd = new System.Windows.Forms.Button();
            this.btnSupprActeurDvd = new System.Windows.Forms.Button();
            this.cboActeur = new System.Windows.Forms.ComboBox();
            this.btnSupprActeur = new System.Windows.Forms.Button();
            this.btnAjoutActeur = new System.Windows.Forms.Button();
            this.txtActeur = new System.Windows.Forms.TextBox();
            this.photoact = new System.Windows.Forms.PictureBox();
            this.Acteur = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.lstDvd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblavis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutDvd
            // 
            this.btnAjoutDvd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjoutDvd.Location = new System.Drawing.Point(388, 36);
            this.btnAjoutDvd.Name = "btnAjoutDvd";
            this.btnAjoutDvd.Size = new System.Drawing.Size(269, 51);
            this.btnAjoutDvd.TabIndex = 3;
            this.btnAjoutDvd.Text = "Ajouter dvd (sans les acteurs)";
            this.btnAjoutDvd.UseVisualStyleBackColor = false;
            this.btnAjoutDvd.Click += new System.EventHandler(this.btnAjoutDvd_Click);
            // 
            // btnSupprDvd
            // 
            this.btnSupprDvd.BackColor = System.Drawing.Color.Red;
            this.btnSupprDvd.Location = new System.Drawing.Point(388, 110);
            this.btnSupprDvd.Name = "btnSupprDvd";
            this.btnSupprDvd.Size = new System.Drawing.Size(269, 46);
            this.btnSupprDvd.TabIndex = 4;
            this.btnSupprDvd.Text = "Supprimer Dvd";
            this.btnSupprDvd.UseVisualStyleBackColor = false;
            this.btnSupprDvd.Click += new System.EventHandler(this.btnSupprDvd_Click);
            // 
            // btnModifDvd
            // 
            this.btnModifDvd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModifDvd.Location = new System.Drawing.Point(388, 166);
            this.btnModifDvd.Name = "btnModifDvd";
            this.btnModifDvd.Size = new System.Drawing.Size(269, 55);
            this.btnModifDvd.TabIndex = 5;
            this.btnModifDvd.Text = "Modification ";
            this.btnModifDvd.UseVisualStyleBackColor = false;
            this.btnModifDvd.Click += new System.EventHandler(this.btnModifDvd_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(1065, 8);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(368, 29);
            this.txtTitre.TabIndex = 6;
            this.txtTitre.TextChanged += new System.EventHandler(this.txtTitre_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(957, 6);
            this.label2.MaximumSize = new System.Drawing.Size(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titre :";
            // 
            // txtDurée
            // 
            this.txtDurée.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDurée.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurée.Location = new System.Drawing.Point(1065, 42);
            this.txtDurée.Name = "txtDurée";
            this.txtDurée.Size = new System.Drawing.Size(368, 29);
            this.txtDurée.TabIndex = 8;
            this.txtDurée.TextChanged += new System.EventHandler(this.txtDurée_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(938, 36);
            this.label3.MaximumSize = new System.Drawing.Size(220, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Durée :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(932, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genre  :";
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(1121, 83);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(292, 29);
            this.cboGenre.TabIndex = 11;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenre_SelectedIndexChanged);
            // 
            // btnSupprGenre
            // 
            this.btnSupprGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprGenre.AutoSize = true;
            this.btnSupprGenre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprGenre.BackColor = System.Drawing.Color.Red;
            this.btnSupprGenre.Location = new System.Drawing.Point(1436, 83);
            this.btnSupprGenre.Name = "btnSupprGenre";
            this.btnSupprGenre.Size = new System.Drawing.Size(79, 26);
            this.btnSupprGenre.TabIndex = 12;
            this.btnSupprGenre.Text = "Supprimer";
            this.btnSupprGenre.UseVisualStyleBackColor = false;
            this.btnSupprGenre.Click += new System.EventHandler(this.btnSupprGenre_Click);
            // 
            // btnAjoutgenre
            // 
            this.btnAjoutgenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutgenre.AutoSize = true;
            this.btnAjoutgenre.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjoutgenre.Location = new System.Drawing.Point(1436, 122);
            this.btnAjoutgenre.Name = "btnAjoutgenre";
            this.btnAjoutgenre.Size = new System.Drawing.Size(89, 29);
            this.btnAjoutgenre.TabIndex = 13;
            this.btnAjoutgenre.Text = "Ajouter";
            this.btnAjoutgenre.UseVisualStyleBackColor = false;
            this.btnAjoutgenre.Click += new System.EventHandler(this.btnAjoutgenre_Click);
            // 
            // txtAjtGenre
            // 
            this.txtAjtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAjtGenre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAjtGenre.Location = new System.Drawing.Point(1121, 122);
            this.txtAjtGenre.Name = "txtAjtGenre";
            this.txtAjtGenre.Size = new System.Drawing.Size(292, 29);
            this.txtAjtGenre.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1089, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Acteurs et Actrices :";
            // 
            // lstActeur
            // 
            this.lstActeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActeur.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActeur.FormattingEnabled = true;
            this.lstActeur.ItemHeight = 25;
            this.lstActeur.Location = new System.Drawing.Point(1094, 195);
            this.lstActeur.Name = "lstActeur";
            this.lstActeur.Size = new System.Drawing.Size(232, 179);
            this.lstActeur.TabIndex = 16;
            this.lstActeur.SelectedIndexChanged += new System.EventHandler(this.lstActeur_SelectedIndexChanged);
            // 
            // btnAjoutActeurDvd
            // 
            this.btnAjoutActeurDvd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutActeurDvd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjoutActeurDvd.Location = new System.Drawing.Point(1436, 209);
            this.btnAjoutActeurDvd.Name = "btnAjoutActeurDvd";
            this.btnAjoutActeurDvd.Size = new System.Drawing.Size(40, 24);
            this.btnAjoutActeurDvd.TabIndex = 17;
            this.btnAjoutActeurDvd.Text = "+";
            this.btnAjoutActeurDvd.UseVisualStyleBackColor = false;
            this.btnAjoutActeurDvd.Click += new System.EventHandler(this.btnAjoutActeurDvd_Click);
            // 
            // btnSupprActeurDvd
            // 
            this.btnSupprActeurDvd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprActeurDvd.BackColor = System.Drawing.Color.Red;
            this.btnSupprActeurDvd.Location = new System.Drawing.Point(1436, 261);
            this.btnSupprActeurDvd.Name = "btnSupprActeurDvd";
            this.btnSupprActeurDvd.Size = new System.Drawing.Size(40, 24);
            this.btnSupprActeurDvd.TabIndex = 18;
            this.btnSupprActeurDvd.Text = "- ";
            this.btnSupprActeurDvd.UseVisualStyleBackColor = false;
            this.btnSupprActeurDvd.Click += new System.EventHandler(this.btnSupprActeurDvd_Click);
            // 
            // cboActeur
            // 
            this.cboActeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActeur.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActeur.FormattingEnabled = true;
            this.cboActeur.Location = new System.Drawing.Point(1167, 513);
            this.cboActeur.Name = "cboActeur";
            this.cboActeur.Size = new System.Drawing.Size(266, 29);
            this.cboActeur.TabIndex = 19;
            // 
            // btnSupprActeur
            // 
            this.btnSupprActeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprActeur.AutoSize = true;
            this.btnSupprActeur.BackColor = System.Drawing.Color.Red;
            this.btnSupprActeur.Location = new System.Drawing.Point(1446, 511);
            this.btnSupprActeur.Name = "btnSupprActeur";
            this.btnSupprActeur.Size = new System.Drawing.Size(90, 31);
            this.btnSupprActeur.TabIndex = 20;
            this.btnSupprActeur.Text = "Supprimer";
            this.btnSupprActeur.UseVisualStyleBackColor = false;
            this.btnSupprActeur.Click += new System.EventHandler(this.btnSupprActeur_Click);
            // 
            // btnAjoutActeur
            // 
            this.btnAjoutActeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutActeur.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjoutActeur.Location = new System.Drawing.Point(1446, 588);
            this.btnAjoutActeur.Name = "btnAjoutActeur";
            this.btnAjoutActeur.Size = new System.Drawing.Size(90, 29);
            this.btnAjoutActeur.TabIndex = 21;
            this.btnAjoutActeur.Text = "Ajouter";
            this.btnAjoutActeur.UseVisualStyleBackColor = false;
            this.btnAjoutActeur.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtActeur
            // 
            this.txtActeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActeur.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActeur.Location = new System.Drawing.Point(1167, 588);
            this.txtActeur.Name = "txtActeur";
            this.txtActeur.Size = new System.Drawing.Size(267, 29);
            this.txtActeur.TabIndex = 22;
            // 
            // photoact
            // 
            this.photoact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.photoact.Location = new System.Drawing.Point(845, 195);
            this.photoact.Name = "photoact";
            this.photoact.Size = new System.Drawing.Size(219, 242);
            this.photoact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoact.TabIndex = 24;
            this.photoact.TabStop = false;
            // 
            // Acteur
            // 
            this.Acteur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Acteur.AutoSize = true;
            this.Acteur.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acteur.Location = new System.Drawing.Point(849, 440);
            this.Acteur.Name = "Acteur";
            this.Acteur.Size = new System.Drawing.Size(80, 32);
            this.Acteur.TabIndex = 25;
            this.Acteur.Text = "Label";
            // 
            // photo
            // 
            this.photo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.photo.Location = new System.Drawing.Point(331, 300);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(457, 405);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 23;
            this.photo.TabStop = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // lstDvd
            // 
            this.lstDvd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDvd.FormattingEnabled = true;
            this.lstDvd.HorizontalScrollbar = true;
            this.lstDvd.ItemHeight = 27;
            this.lstDvd.Location = new System.Drawing.Point(12, 42);
            this.lstDvd.Name = "lstDvd";
            this.lstDvd.Size = new System.Drawing.Size(340, 166);
            this.lstDvd.TabIndex = 1;
            this.lstDvd.SelectedIndexChanged += new System.EventHandler(this.lstDvd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des DVD";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(12, 300);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(302, 272);
            this.txtDesc.TabIndex = 27;
            this.txtDesc.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 36);
            this.label6.TabIndex = 28;
            this.label6.Text = "Synopsis :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 658);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblavis
            // 
            this.lblavis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblavis.AutoSize = true;
            this.lblavis.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavis.ForeColor = System.Drawing.Color.Lime;
            this.lblavis.Location = new System.Drawing.Point(863, 678);
            this.lblavis.Name = "lblavis";
            this.lblavis.Size = new System.Drawing.Size(0, 27);
            this.lblavis.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1628, 774);
            this.Controls.Add(this.lblavis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDvd);
            this.Controls.Add(this.photoact);
            this.Controls.Add(this.Acteur);
            this.Controls.Add(this.txtActeur);
            this.Controls.Add(this.btnAjoutActeur);
            this.Controls.Add(this.btnSupprActeur);
            this.Controls.Add(this.cboActeur);
            this.Controls.Add(this.btnSupprActeurDvd);
            this.Controls.Add(this.btnAjoutActeurDvd);
            this.Controls.Add(this.lstActeur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAjtGenre);
            this.Controls.Add(this.btnAjoutgenre);
            this.Controls.Add(this.btnSupprGenre);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDurée);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.btnModifDvd);
            this.Controls.Add(this.btnSupprDvd);
            this.Controls.Add(this.btnAjoutDvd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion DVD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjoutDvd;
        private System.Windows.Forms.Button btnSupprDvd;
        private System.Windows.Forms.Button btnModifDvd;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDurée;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnSupprGenre;
        private System.Windows.Forms.Button btnAjoutgenre;
        private System.Windows.Forms.TextBox txtAjtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstActeur;
        private System.Windows.Forms.Button btnAjoutActeurDvd;
        private System.Windows.Forms.Button btnSupprActeurDvd;
        private System.Windows.Forms.ComboBox cboActeur;
        private System.Windows.Forms.Button btnSupprActeur;
        private System.Windows.Forms.Button btnAjoutActeur;
        private System.Windows.Forms.TextBox txtActeur;
        private System.Windows.Forms.PictureBox photoact;
        private System.Windows.Forms.Label Acteur;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.ListBox lstDvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblavis;
    }
}

