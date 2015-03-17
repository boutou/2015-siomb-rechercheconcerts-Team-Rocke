namespace ZiKnCo.MoteurRechercheDeezer
{
    partial class FrmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoverFlow));
            this.iC3DAlbums = new CDI.IndexCard3D.IC3D();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panListeTitres = new System.Windows.Forms.Panel();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.lblTitres = new System.Windows.Forms.Label();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.panListeTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // iC3DAlbums
            // 
            this.iC3DAlbums.DisplayCards = 8;
            this.iC3DAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iC3DAlbums.Location = new System.Drawing.Point(0, -100);
            this.iC3DAlbums.Name = "iC3DAlbums";
            this.iC3DAlbums.Size = new System.Drawing.Size(598, 390);
            this.iC3DAlbums.TabIndex = 0;
            this.iC3DAlbums.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.iC3DAlbums_RenderText);
            this.iC3DAlbums.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.iC3DAlbums_IndexCardChanged);
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXsurY.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXsurY.Location = new System.Drawing.Point(530, 297);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(48, 13);
            this.lblXsurY.TabIndex = 1;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.MouseHover += new System.EventHandler(this.lblXsurY_MouseHover);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(12, 297);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(33, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre";
            // 
            // panListeTitres
            // 
            this.panListeTitres.Controls.Add(this.lstTitres);
            this.panListeTitres.Controls.Add(this.lblTitres);
            this.panListeTitres.Location = new System.Drawing.Point(458, -2);
            this.panListeTitres.Name = "panListeTitres";
            this.panListeTitres.Size = new System.Drawing.Size(132, 292);
            this.panListeTitres.TabIndex = 9;
            this.panListeTitres.Visible = false;
            // 
            // lstTitres
            // 
            this.lstTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(9, 22);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(120, 264);
            this.lstTitres.TabIndex = 1;
            this.lstTitres.Click += new System.EventHandler(this.lstTitres_Click);
            this.lstTitres.MouseLeave += new System.EventHandler(this.lstTitres_MouseLeave);
            // 
            // lblTitres
            // 
            this.lblTitres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitres.AutoSize = true;
            this.lblTitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitres.Location = new System.Drawing.Point(10, 1);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(115, 15);
            this.lblTitres.TabIndex = 0;
            this.lblTitres.Text = "Titres de l\'Album";
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(0, 322);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(590, 45);
            this.wmpLecteur.TabIndex = 10;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            // 
            // FrmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 368);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.panListeTitres);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.iC3DAlbums);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoverFlow";
            this.Text = "ZiK\'nCo : Affichage \"Cover Flow\"";
            this.Load += new System.EventHandler(this.frmCoverFlow_Load);
            this.panListeTitres.ResumeLayout(false);
            this.panListeTitres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDI.IndexCard3D.IC3D iC3DAlbums;
        private System.Windows.Forms.Label lblXsurY;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panListeTitres;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Label lblTitres;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
    }
}