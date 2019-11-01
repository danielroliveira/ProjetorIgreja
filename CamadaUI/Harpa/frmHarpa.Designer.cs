namespace CamadaUI.Harpa
{
    partial class frmHarpa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHarpa));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimizer = new System.Windows.Forms.Button();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.lblHinoNumero = new System.Windows.Forms.Label();
			this.lblHinoTitulo = new System.Windows.Forms.Label();
			this.pnlNav = new System.Windows.Forms.Panel();
			this.lblNavegacao = new System.Windows.Forms.Label();
			this.btnNext = new MBGlassStyleButton.MBGlassButton();
			this.btnPrev = new MBGlassStyleButton.MBGlassButton();
			this.btnLinguagens = new MBGlassStyleButton.MBGlassButton();
			this.pnlHistorico = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnHistorico = new System.Windows.Forms.Button();
			this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
			this.txtEstrofe = new CamadaUI.Controls.TextBox_unclick();
			this.pnlTop.SuspendLayout();
			this.pnlInfo.SuspendLayout();
			this.pnlNav.SuspendLayout();
			this.pnlHistorico.SuspendLayout();
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
			this.pnlTop.TabIndex = 6;
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
			this.lblTitulo.Size = new System.Drawing.Size(245, 40);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Harpa Cristã Louvores";
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
			this.btnClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmHarpa_PreviewKeyDown);
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
			this.btnMinimizer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmHarpa_PreviewKeyDown);
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.Gainsboro;
			this.pnlInfo.Controls.Add(this.lblHinoNumero);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlInfo.Location = new System.Drawing.Point(0, 40);
			this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(973, 60);
			this.pnlInfo.TabIndex = 7;
			// 
			// lblHinoNumero
			// 
			this.lblHinoNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblHinoNumero.BackColor = System.Drawing.Color.Gainsboro;
			this.lblHinoNumero.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHinoNumero.Location = new System.Drawing.Point(605, 7);
			this.lblHinoNumero.Name = "lblHinoNumero";
			this.lblHinoNumero.Size = new System.Drawing.Size(363, 45);
			this.lblHinoNumero.TabIndex = 0;
			this.lblHinoNumero.Text = "Harpa Cristã - 01";
			this.lblHinoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblHinoTitulo
			// 
			this.lblHinoTitulo.AutoSize = true;
			this.lblHinoTitulo.BackColor = System.Drawing.Color.Gainsboro;
			this.lblHinoTitulo.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHinoTitulo.Location = new System.Drawing.Point(31, 47);
			this.lblHinoTitulo.Name = "lblHinoTitulo";
			this.lblHinoTitulo.Size = new System.Drawing.Size(247, 45);
			this.lblHinoTitulo.TabIndex = 1;
			this.lblHinoTitulo.Text = "Hino Titulo";
			// 
			// pnlNav
			// 
			this.pnlNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlNav.Controls.Add(this.lblNavegacao);
			this.pnlNav.Controls.Add(this.btnNext);
			this.pnlNav.Controls.Add(this.btnPrev);
			this.pnlNav.Location = new System.Drawing.Point(700, 575);
			this.pnlNav.Name = "pnlNav";
			this.pnlNav.Size = new System.Drawing.Size(262, 40);
			this.pnlNav.TabIndex = 1;
			this.pnlNav.TabStop = true;
			// 
			// lblNavegacao
			// 
			this.lblNavegacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNavegacao.Location = new System.Drawing.Point(63, 11);
			this.lblNavegacao.Name = "lblNavegacao";
			this.lblNavegacao.Size = new System.Drawing.Size(136, 19);
			this.lblNavegacao.TabIndex = 2;
			this.lblNavegacao.Text = "Ver. 1 de 1";
			this.lblNavegacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNext
			// 
			this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnNext.BackColor = System.Drawing.Color.Transparent;
			this.btnNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnNext.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnNext.FlatAppearance.BorderSize = 0;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Image = global::CamadaUI.Properties.Resources.Next_32px;
			this.btnNext.ImageSize = new System.Drawing.Size(24, 24);
			this.btnNext.Location = new System.Drawing.Point(216, 3);
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
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHarpa_KeyDown);
			this.btnNext.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmHarpa_PreviewKeyDown);
			// 
			// btnPrev
			// 
			this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnPrev.BackColor = System.Drawing.Color.Transparent;
			this.btnPrev.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnPrev.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnPrev.FlatAppearance.BorderSize = 0;
			this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrev.Image = global::CamadaUI.Properties.Resources.Previous_32px;
			this.btnPrev.ImageSize = new System.Drawing.Size(24, 24);
			this.btnPrev.Location = new System.Drawing.Point(3, 3);
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
			this.btnPrev.UseVisualStyleBackColor = false;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			this.btnPrev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHarpa_KeyDown);
			this.btnPrev.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmHarpa_PreviewKeyDown);
			// 
			// btnLinguagens
			// 
			this.btnLinguagens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLinguagens.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.ToDown;
			this.btnLinguagens.BackColor = System.Drawing.Color.Transparent;
			this.btnLinguagens.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.btnLinguagens.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
			this.btnLinguagens.TabIndex = 0;
			this.btnLinguagens.Text = "Procura";
			this.btnLinguagens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLinguagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLinguagens.UseVisualStyleBackColor = false;
			this.btnLinguagens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHarpa_KeyDown);
			// 
			// pnlHistorico
			// 
			this.pnlHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(171)))), ((int)(((byte)(205)))));
			this.pnlHistorico.Controls.Add(this.label1);
			this.pnlHistorico.Controls.Add(this.btnHistorico);
			this.pnlHistorico.Location = new System.Drawing.Point(753, 100);
			this.pnlHistorico.Name = "pnlHistorico";
			this.pnlHistorico.Size = new System.Drawing.Size(220, 32);
			this.pnlHistorico.TabIndex = 62;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label1.Size = new System.Drawing.Size(175, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Histórico de Hinos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnHistorico
			// 
			this.btnHistorico.BackColor = System.Drawing.Color.Transparent;
			this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnHistorico.FlatAppearance.BorderSize = 0;
			this.btnHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHistorico.Image = global::CamadaUI.Properties.Resources.DropdownIcon;
			this.btnHistorico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnHistorico.Location = new System.Drawing.Point(180, 0);
			this.btnHistorico.Margin = new System.Windows.Forms.Padding(0);
			this.btnHistorico.Name = "btnHistorico";
			this.btnHistorico.Size = new System.Drawing.Size(40, 32);
			this.btnHistorico.TabIndex = 1;
			this.btnHistorico.TabStop = false;
			this.btnHistorico.UseVisualStyleBackColor = false;
			this.btnHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHarpa_KeyDown);
			// 
			// pnlItems
			// 
			this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlItems.Location = new System.Drawing.Point(168, 572);
			this.pnlItems.Name = "pnlItems";
			this.pnlItems.Size = new System.Drawing.Size(458, 43);
			this.pnlItems.TabIndex = 63;
			// 
			// txtEstrofe
			// 
			this.txtEstrofe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEstrofe.BackColor = System.Drawing.SystemColors.Control;
			this.txtEstrofe.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEstrofe.Font = new System.Drawing.Font("Ezra SIL", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstrofe.HideSelection = false;
			this.txtEstrofe.Location = new System.Drawing.Point(12, 113);
			this.txtEstrofe.Multiline = true;
			this.txtEstrofe.Name = "txtEstrofe";
			this.txtEstrofe.SelectionHighlightEnabled = false;
			this.txtEstrofe.ShortcutsEnabled = false;
			this.txtEstrofe.Size = new System.Drawing.Size(949, 453);
			this.txtEstrofe.TabIndex = 60;
			this.txtEstrofe.TabStop = false;
			this.txtEstrofe.Text = "Hino Estrofe";
			this.txtEstrofe.TextChanged += new System.EventHandler(this.txtEstrofe_SizeChanged);
			this.txtEstrofe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHarpa_KeyDown);
			this.txtEstrofe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstrofe_KeyPress);
			this.txtEstrofe.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmHarpa_PreviewKeyDown);
			// 
			// frmHarpa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 623);
			this.Controls.Add(this.pnlItems);
			this.Controls.Add(this.pnlHistorico);
			this.Controls.Add(this.btnLinguagens);
			this.Controls.Add(this.pnlNav);
			this.Controls.Add(this.lblHinoTitulo);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.txtEstrofe);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmHarpa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmHarpa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.frmHarpa_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHarpa_KeyDown);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmHarpa_PreviewKeyDown);
			this.pnlTop.ResumeLayout(false);
			this.pnlInfo.ResumeLayout(false);
			this.pnlNav.ResumeLayout(false);
			this.pnlHistorico.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlTop;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Label lblHinoTitulo;
		internal System.Windows.Forms.Panel pnlNav;
		internal System.Windows.Forms.Label lblNavegacao;
		private MBGlassStyleButton.MBGlassButton btnPrev;
		private MBGlassStyleButton.MBGlassButton btnNext;
		private System.Windows.Forms.Label lblHinoNumero;
		private Controls.TextBox_unclick txtEstrofe;
		internal MBGlassStyleButton.MBGlassButton btnLinguagens;
		private System.Windows.Forms.Label label1;
		protected internal System.Windows.Forms.Button btnHistorico;
		public System.Windows.Forms.Panel pnlHistorico;
		private System.Windows.Forms.FlowLayoutPanel pnlItems;
	}
}