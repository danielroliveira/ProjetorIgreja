namespace CamadaUI
{
    partial class frmLeitura
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeitura));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimizer = new System.Windows.Forms.Button();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblLinguagem = new System.Windows.Forms.Label();
			this.lblLivro = new System.Windows.Forms.Label();
			this.pnlNav = new System.Windows.Forms.Panel();
			this.btnLast = new MBGlassStyleButton.MBGlassButton();
			this.lblNavegacao = new System.Windows.Forms.Label();
			this.btnNext = new MBGlassStyleButton.MBGlassButton();
			this.btnFirst = new MBGlassStyleButton.MBGlassButton();
			this.btnPrev = new MBGlassStyleButton.MBGlassButton();
			this.mnuLinguagens = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miRC = new System.Windows.Forms.ToolStripMenuItem();
			this.miRA = new System.Windows.Forms.ToolStripMenuItem();
			this.miNVI = new System.Windows.Forms.ToolStripMenuItem();
			this.miFiel = new System.Windows.Forms.ToolStripMenuItem();
			this.miNTLH = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLinguagens = new MBGlassStyleButton.MBGlassButton();
			this.txtEscritura = new CamadaUI.Controls.TextBox_unclick();
			this.pnlTop.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.pnlNav.SuspendLayout();
			this.mnuLinguagens.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.SlateGray;
			this.pnlTop.Controls.Add(this.lblTitulo);
			this.pnlTop.Controls.Add(this.btnClose);
			this.pnlTop.Controls.Add(this.btnMinimizer);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(973, 40);
			this.pnlTop.TabIndex = 0;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
			this.lblTitulo.Size = new System.Drawing.Size(172, 40);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Leitura Bíblica";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::CamadaUI.Properties.Resources.CloseIcon;
			this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnClose.Location = new System.Drawing.Point(933, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 0;
			this.btnClose.TabStop = false;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			this.btnClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// btnMinimizer
			// 
			this.btnMinimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizer.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizer.FlatAppearance.BorderSize = 0;
			this.btnMinimizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnMinimizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnMinimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizer.Image = global::CamadaUI.Properties.Resources.DropdownIcon;
			this.btnMinimizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnMinimizer.Location = new System.Drawing.Point(893, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 40);
			this.btnMinimizer.TabIndex = 2;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			this.btnMinimizer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.Gainsboro;
			this.pnlInfo.Controls.Add(this.lblLinguagem);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlInfo.Location = new System.Drawing.Point(0, 40);
			this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(973, 60);
			this.pnlInfo.TabIndex = 0;
			// 
			// lblLinguagem
			// 
			this.lblLinguagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLinguagem.BackColor = System.Drawing.Color.Gainsboro;
			this.lblLinguagem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLinguagem.Location = new System.Drawing.Point(468, 7);
			this.lblLinguagem.Name = "lblLinguagem";
			this.lblLinguagem.Size = new System.Drawing.Size(496, 45);
			this.lblLinguagem.TabIndex = 0;
			this.lblLinguagem.Text = "Linguagem";
			this.lblLinguagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLivro
			// 
			this.lblLivro.AutoSize = true;
			this.lblLivro.BackColor = System.Drawing.Color.Gainsboro;
			this.lblLivro.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLivro.Location = new System.Drawing.Point(31, 47);
			this.lblLivro.Name = "lblLivro";
			this.lblLivro.Size = new System.Drawing.Size(257, 45);
			this.lblLivro.TabIndex = 1;
			this.lblLivro.Text = "Livro Nome";
			// 
			// pnlNav
			// 
			this.pnlNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlNav.Controls.Add(this.btnLast);
			this.pnlNav.Controls.Add(this.lblNavegacao);
			this.pnlNav.Controls.Add(this.btnNext);
			this.pnlNav.Controls.Add(this.btnFirst);
			this.pnlNav.Controls.Add(this.btnPrev);
			this.pnlNav.Location = new System.Drawing.Point(632, 575);
			this.pnlNav.Name = "pnlNav";
			this.pnlNav.Size = new System.Drawing.Size(330, 40);
			this.pnlNav.TabIndex = 3;
			// 
			// btnLast
			// 
			this.btnLast.BackColor = System.Drawing.Color.Transparent;
			this.btnLast.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnLast.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnLast.FlatAppearance.BorderSize = 0;
			this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLast.Image = global::CamadaUI.Properties.Resources.Last_32px;
			this.btnLast.ImageSize = new System.Drawing.Size(24, 24);
			this.btnLast.Location = new System.Drawing.Point(285, 3);
			this.btnLast.Margin = new System.Windows.Forms.Padding(1);
			this.btnLast.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnLast.Name = "btnLast";
			this.btnLast.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
			this.btnLast.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
			this.btnLast.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnLast.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLast.Radius = 10;
			this.btnLast.Size = new System.Drawing.Size(42, 35);
			this.btnLast.TabIndex = 4;
			this.btnLast.TabStop = false;
			this.btnLast.UseVisualStyleBackColor = false;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			this.btnLast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLeitura_KeyDown);
			this.btnLast.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// lblNavegacao
			// 
			this.lblNavegacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNavegacao.Location = new System.Drawing.Point(93, 11);
			this.lblNavegacao.Name = "lblNavegacao";
			this.lblNavegacao.Size = new System.Drawing.Size(140, 19);
			this.lblNavegacao.TabIndex = 2;
			this.lblNavegacao.Text = "Ver. 1 de 1";
			this.lblNavegacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Transparent;
			this.btnNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnNext.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnNext.FlatAppearance.BorderSize = 0;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Image = global::CamadaUI.Properties.Resources.Next_32px;
			this.btnNext.ImageSize = new System.Drawing.Size(24, 24);
			this.btnNext.Location = new System.Drawing.Point(242, 3);
			this.btnNext.Margin = new System.Windows.Forms.Padding(1);
			this.btnNext.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnNext.Name = "btnNext";
			this.btnNext.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
			this.btnNext.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
			this.btnNext.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnNext.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnNext.Radius = 10;
			this.btnNext.Size = new System.Drawing.Size(42, 35);
			this.btnNext.TabIndex = 3;
			this.btnNext.TabStop = false;
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLeitura_KeyDown);
			this.btnNext.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// btnFirst
			// 
			this.btnFirst.BackColor = System.Drawing.Color.Transparent;
			this.btnFirst.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnFirst.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnFirst.FlatAppearance.BorderSize = 0;
			this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFirst.Image = global::CamadaUI.Properties.Resources.First_32px;
			this.btnFirst.ImageSize = new System.Drawing.Size(24, 24);
			this.btnFirst.Location = new System.Drawing.Point(3, 3);
			this.btnFirst.Margin = new System.Windows.Forms.Padding(1);
			this.btnFirst.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
			this.btnFirst.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
			this.btnFirst.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnFirst.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnFirst.Radius = 10;
			this.btnFirst.Size = new System.Drawing.Size(42, 35);
			this.btnFirst.TabIndex = 0;
			this.btnFirst.TabStop = false;
			this.btnFirst.UseVisualStyleBackColor = false;
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			this.btnFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLeitura_KeyDown);
			this.btnFirst.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// btnPrev
			// 
			this.btnPrev.BackColor = System.Drawing.Color.Transparent;
			this.btnPrev.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnPrev.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnPrev.FlatAppearance.BorderSize = 0;
			this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrev.Image = global::CamadaUI.Properties.Resources.Previous_32px;
			this.btnPrev.ImageSize = new System.Drawing.Size(24, 24);
			this.btnPrev.Location = new System.Drawing.Point(47, 3);
			this.btnPrev.Margin = new System.Windows.Forms.Padding(1);
			this.btnPrev.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
			this.btnPrev.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
			this.btnPrev.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnPrev.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnPrev.Radius = 10;
			this.btnPrev.Size = new System.Drawing.Size(42, 35);
			this.btnPrev.TabIndex = 1;
			this.btnPrev.TabStop = false;
			this.btnPrev.UseVisualStyleBackColor = false;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			this.btnPrev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLeitura_KeyDown);
			this.btnPrev.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// mnuLinguagens
			// 
			this.mnuLinguagens.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mnuLinguagens.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuLinguagens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRC,
            this.miRA,
            this.miNVI,
            this.miFiel,
            this.miNTLH});
			this.mnuLinguagens.Name = "mnuLinguagens";
			this.mnuLinguagens.Size = new System.Drawing.Size(440, 194);
			this.mnuLinguagens.Opening += new System.ComponentModel.CancelEventHandler(this.mnuLinguagens_Opening);
			// 
			// miRC
			// 
			this.miRC.BackColor = System.Drawing.Color.Moccasin;
			this.miRC.Image = global::CamadaUI.Properties.Resources.bibliaicon_peq;
			this.miRC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.miRC.Name = "miRC";
			this.miRC.Size = new System.Drawing.Size(439, 38);
			this.miRC.Tag = "3";
			this.miRC.Text = "RC - Almeida Revista e Corrigida";
			this.miRC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.miRC.Click += new System.EventHandler(this.miLinguagem_Click);
			// 
			// miRA
			// 
			this.miRA.BackColor = System.Drawing.Color.WhiteSmoke;
			this.miRA.Image = global::CamadaUI.Properties.Resources.bibliaicon_peq;
			this.miRA.Name = "miRA";
			this.miRA.Size = new System.Drawing.Size(439, 38);
			this.miRA.Tag = "4";
			this.miRA.Text = "RA - Almeira Revista e Atualizada";
			this.miRA.Click += new System.EventHandler(this.miLinguagem_Click);
			// 
			// miNVI
			// 
			this.miNVI.BackColor = System.Drawing.Color.WhiteSmoke;
			this.miNVI.Image = global::CamadaUI.Properties.Resources.bibliaicon_peq;
			this.miNVI.Name = "miNVI";
			this.miNVI.Size = new System.Drawing.Size(439, 38);
			this.miNVI.Tag = "2";
			this.miNVI.Text = "NVI - Nova Versão Internacional";
			this.miNVI.Click += new System.EventHandler(this.miLinguagem_Click);
			// 
			// miFiel
			// 
			this.miFiel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.miFiel.Image = global::CamadaUI.Properties.Resources.bibliaicon_peq;
			this.miFiel.Name = "miFiel";
			this.miFiel.Size = new System.Drawing.Size(439, 38);
			this.miFiel.Tag = "1";
			this.miFiel.Text = "ACF - Almeida Corrigida Fiel";
			this.miFiel.Click += new System.EventHandler(this.miLinguagem_Click);
			// 
			// miNTLH
			// 
			this.miNTLH.BackColor = System.Drawing.Color.WhiteSmoke;
			this.miNTLH.Image = global::CamadaUI.Properties.Resources.bibliaicon_peq;
			this.miNTLH.Name = "miNTLH";
			this.miNTLH.Size = new System.Drawing.Size(439, 38);
			this.miNTLH.Tag = "5";
			this.miNTLH.Text = "NTLH - Nova Tradução da Linguagem de Hoje";
			this.miNTLH.Click += new System.EventHandler(this.miLinguagem_Click);
			// 
			// btnLinguagens
			// 
			this.btnLinguagens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLinguagens.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.ToDown;
			this.btnLinguagens.BackColor = System.Drawing.Color.Transparent;
			this.btnLinguagens.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnLinguagens.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnLinguagens.ContextMenuStrip = this.mnuLinguagens;
			this.btnLinguagens.FlatAppearance.BorderSize = 0;
			this.btnLinguagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLinguagens.Image = global::CamadaUI.Properties.Resources.search_peq;
			this.btnLinguagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLinguagens.ImageSize = new System.Drawing.Size(24, 24);
			this.btnLinguagens.Location = new System.Drawing.Point(12, 575);
			this.btnLinguagens.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnLinguagens.Name = "btnLinguagens";
			this.btnLinguagens.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
			this.btnLinguagens.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
			this.btnLinguagens.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnLinguagens.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLinguagens.Size = new System.Drawing.Size(150, 40);
			this.btnLinguagens.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.Yes;
			this.btnLinguagens.SplitDistance = 30;
			this.btnLinguagens.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Right;
			this.btnLinguagens.TabIndex = 2;
			this.btnLinguagens.Text = "Procura";
			this.btnLinguagens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLinguagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLinguagens.UseVisualStyleBackColor = false;
			this.btnLinguagens.Click += new System.EventHandler(this.btnLinguagens_Click);
			// 
			// txtEscritura
			// 
			this.txtEscritura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEscritura.BackColor = System.Drawing.SystemColors.Control;
			this.txtEscritura.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEscritura.Font = new System.Drawing.Font("Ezra SIL", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEscritura.HideSelection = false;
			this.txtEscritura.Location = new System.Drawing.Point(12, 113);
			this.txtEscritura.Multiline = true;
			this.txtEscritura.Name = "txtEscritura";
			this.txtEscritura.ShortcutsEnabled = false;
			this.txtEscritura.Size = new System.Drawing.Size(949, 453);
			this.txtEscritura.TabIndex = 4;
			this.txtEscritura.TabStop = false;
			this.txtEscritura.Text = "Escritura Bíblica";
			this.txtEscritura.TextChanged += new System.EventHandler(this.txtEscritura_SizeChanged);
			this.txtEscritura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLeitura_KeyDown);
			this.txtEscritura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEscritura_KeyPress);
			this.txtEscritura.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			// 
			// frmLeitura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 623);
			this.Controls.Add(this.btnLinguagens);
			this.Controls.Add(this.pnlNav);
			this.Controls.Add(this.lblLivro);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.txtEscritura);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmLeitura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLeitura";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLeitura_KeyDown);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLeitura_PreviewKeyDown);
			this.pnlTop.ResumeLayout(false);
			this.pnlInfo.ResumeLayout(false);
			this.pnlNav.ResumeLayout(false);
			this.mnuLinguagens.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlTop;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlInfo;
		private Controls.TextBox_unclick txtEscritura;
		private System.Windows.Forms.Label lblLivro;
		internal System.Windows.Forms.Panel pnlNav;
		internal System.Windows.Forms.Label lblNavegacao;
		private MBGlassStyleButton.MBGlassButton btnFirst;
		private MBGlassStyleButton.MBGlassButton btnPrev;
		private MBGlassStyleButton.MBGlassButton btnNext;
		private MBGlassStyleButton.MBGlassButton btnLast;
		private MBGlassStyleButton.MBGlassButton btnLinguagens;
		private System.Windows.Forms.ContextMenuStrip mnuLinguagens;
		private System.Windows.Forms.ToolStripMenuItem miRC;
		private System.Windows.Forms.ToolStripMenuItem miRA;
		private System.Windows.Forms.ToolStripMenuItem miNVI;
		private System.Windows.Forms.ToolStripMenuItem miFiel;
		private System.Windows.Forms.ToolStripMenuItem miNTLH;
		private System.Windows.Forms.Label lblLinguagem;
	}
}