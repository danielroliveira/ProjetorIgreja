namespace CamadaUI.Louvor
{
    partial class frmLouvorLista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLouvorLista));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimizer = new System.Windows.Forms.Button();
			this.mnuLista = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miEditarLouvor = new System.Windows.Forms.ToolStripMenuItem();
			this.miDefinirTom = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom1 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom5 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom6 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom7 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom8 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom9 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom10 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom11 = new System.Windows.Forms.ToolStripMenuItem();
			this.miTom12 = new System.Windows.Forms.ToolStripMenuItem();
			this.miRC = new System.Windows.Forms.ToolStripMenuItem();
			this.miRA = new System.Windows.Forms.ToolStripMenuItem();
			this.miNVI = new System.Windows.Forms.ToolStripMenuItem();
			this.miFiel = new System.Windows.Forms.ToolStripMenuItem();
			this.miNTLH = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEscolher = new System.Windows.Forms.Button();
			this.lstListagem = new ComponentOwl.BetterListView.BetterListView();
			this.clnIDLouvor = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnTitulo = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnCategoria = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnNota = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnTomDesc = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProcura = new System.Windows.Forms.TextBox();
			this.lblVersiculo = new System.Windows.Forms.Label();
			this.btnVoltar = new Glass.GlassButton();
			this.pnlTop.SuspendLayout();
			this.mnuLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).BeginInit();
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
			this.pnlTop.Size = new System.Drawing.Size(1142, 40);
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
			this.lblTitulo.Size = new System.Drawing.Size(316, 40);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Escolher | Pesquisar Louvor";
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
			this.btnClose.Location = new System.Drawing.Point(1102, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 0;
			this.btnClose.TabStop = false;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
			this.btnMinimizer.Location = new System.Drawing.Point(1062, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 40);
			this.btnMinimizer.TabIndex = 2;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			// 
			// mnuLista
			// 
			this.mnuLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditarLouvor,
            this.miDefinirTom});
			this.mnuLista.Name = "mnuLinguagens";
			this.mnuLista.Size = new System.Drawing.Size(164, 52);
			this.mnuLista.Opening += new System.ComponentModel.CancelEventHandler(this.mnuLista_Opening);
			// 
			// miEditarLouvor
			// 
			this.miEditarLouvor.Image = global::CamadaUI.Properties.Resources.editar_16;
			this.miEditarLouvor.Name = "miEditarLouvor";
			this.miEditarLouvor.Size = new System.Drawing.Size(163, 24);
			this.miEditarLouvor.Text = "Editar Louvor";
			this.miEditarLouvor.Click += new System.EventHandler(this.miEditarLouvor_Click);
			// 
			// miDefinirTom
			// 
			this.miDefinirTom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTom1,
            this.miTom2,
            this.miTom3,
            this.miTom4,
            this.miTom5,
            this.miTom6,
            this.miTom7,
            this.miTom8,
            this.miTom9,
            this.miTom10,
            this.miTom11,
            this.miTom12});
			this.miDefinirTom.Image = global::CamadaUI.Properties.Resources.notamusical_16;
			this.miDefinirTom.Name = "miDefinirTom";
			this.miDefinirTom.Size = new System.Drawing.Size(163, 24);
			this.miDefinirTom.Text = "Definir TOM";
			// 
			// miTom1
			// 
			this.miTom1.Name = "miTom1";
			this.miTom1.Size = new System.Drawing.Size(247, 24);
			this.miTom1.Tag = "1";
			this.miTom1.Text = "A ou Am (Lá)";
			this.miTom1.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom2
			// 
			this.miTom2.Name = "miTom2";
			this.miTom2.Size = new System.Drawing.Size(247, 24);
			this.miTom2.Tag = "2";
			this.miTom2.Text = "Bb ou Bbm (Sí Bemol)";
			this.miTom2.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom3
			// 
			this.miTom3.Name = "miTom3";
			this.miTom3.Size = new System.Drawing.Size(247, 24);
			this.miTom3.Tag = "3";
			this.miTom3.Text = "B ou Bm (Sí)";
			this.miTom3.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom4
			// 
			this.miTom4.Name = "miTom4";
			this.miTom4.Size = new System.Drawing.Size(247, 24);
			this.miTom4.Tag = "4";
			this.miTom4.Text = "C ou Cm (Dó)";
			this.miTom4.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom5
			// 
			this.miTom5.Name = "miTom5";
			this.miTom5.Size = new System.Drawing.Size(247, 24);
			this.miTom5.Tag = "5";
			this.miTom5.Text = "C# ou C#m (Dó Sustenido)";
			this.miTom5.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom6
			// 
			this.miTom6.Name = "miTom6";
			this.miTom6.Size = new System.Drawing.Size(247, 24);
			this.miTom6.Tag = "6";
			this.miTom6.Text = "D ou Dm (Ré)";
			this.miTom6.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom7
			// 
			this.miTom7.Name = "miTom7";
			this.miTom7.Size = new System.Drawing.Size(247, 24);
			this.miTom7.Tag = "7";
			this.miTom7.Text = "Eb ou Ebm (Mí Bemol)";
			this.miTom7.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom8
			// 
			this.miTom8.Name = "miTom8";
			this.miTom8.Size = new System.Drawing.Size(247, 24);
			this.miTom8.Tag = "8";
			this.miTom8.Text = "E ou Em (Mí)";
			this.miTom8.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom9
			// 
			this.miTom9.Name = "miTom9";
			this.miTom9.Size = new System.Drawing.Size(247, 24);
			this.miTom9.Tag = "9";
			this.miTom9.Text = "F ou Fm (Fá)";
			this.miTom9.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom10
			// 
			this.miTom10.Name = "miTom10";
			this.miTom10.Size = new System.Drawing.Size(247, 24);
			this.miTom10.Tag = "10";
			this.miTom10.Text = "F# ou F#m (Fá Sustenido)";
			this.miTom10.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom11
			// 
			this.miTom11.Name = "miTom11";
			this.miTom11.Size = new System.Drawing.Size(247, 24);
			this.miTom11.Tag = "11";
			this.miTom11.Text = "G ou Gm (Sol)";
			this.miTom11.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miTom12
			// 
			this.miTom12.Name = "miTom12";
			this.miTom12.Size = new System.Drawing.Size(247, 24);
			this.miTom12.Tag = "12";
			this.miTom12.Text = "Ab (Lá Bemol)";
			this.miTom12.Click += new System.EventHandler(this.DefineTom_Click);
			// 
			// miRC
			// 
			this.miRC.Name = "miRC";
			this.miRC.Size = new System.Drawing.Size(32, 19);
			// 
			// miRA
			// 
			this.miRA.Name = "miRA";
			this.miRA.Size = new System.Drawing.Size(32, 19);
			// 
			// miNVI
			// 
			this.miNVI.Name = "miNVI";
			this.miNVI.Size = new System.Drawing.Size(32, 19);
			// 
			// miFiel
			// 
			this.miFiel.Name = "miFiel";
			this.miFiel.Size = new System.Drawing.Size(32, 19);
			// 
			// miNTLH
			// 
			this.miNTLH.Name = "miNTLH";
			this.miNTLH.Size = new System.Drawing.Size(32, 19);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEditar.Image = global::CamadaUI.Properties.Resources.editar_24;
			this.btnEditar.Location = new System.Drawing.Point(12, 569);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(181, 45);
			this.btnEditar.TabIndex = 12;
			this.btnEditar.Text = "&Editar Louvor";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.miEditarLouvor_Click);
			// 
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.projetar_32;
			this.btnEscolher.Location = new System.Drawing.Point(918, 569);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(212, 45);
			this.btnEscolher.TabIndex = 13;
			this.btnEscolher.Text = " &Projetar Louvor";
			this.btnEscolher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEscolher.UseVisualStyleBackColor = true;
			this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
			// 
			// lstListagem
			// 
			this.lstListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstListagem.Columns.Add(this.clnIDLouvor);
			this.lstListagem.Columns.Add(this.clnTitulo);
			this.lstListagem.Columns.Add(this.clnCategoria);
			this.lstListagem.Columns.Add(this.clnNota);
			this.lstListagem.Columns.Add(this.clnTomDesc);
			this.lstListagem.ContextMenuStrip = this.mnuLista;
			this.lstListagem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstListagem.Location = new System.Drawing.Point(12, 180);
			this.lstListagem.MultiSelect = false;
			this.lstListagem.Name = "lstListagem";
			this.lstListagem.Size = new System.Drawing.Size(1118, 380);
			this.lstListagem.TabIndex = 11;
			this.lstListagem.ItemActivate += new ComponentOwl.BetterListView.BetterListViewItemActivateEventHandler(this.lstListagem_ItemActivate);
			this.lstListagem.DrawColumnHeader += new ComponentOwl.BetterListView.BetterListViewDrawColumnHeaderEventHandler(this.lstListagem_DrawColumnHeader);
			this.lstListagem.DrawItem += new ComponentOwl.BetterListView.BetterListViewDrawItemEventHandler(this.lstListagem_DrawItem);
			// 
			// clnIDLouvor
			// 
			this.clnIDLouvor.Name = "clnIDLouvor";
			this.clnIDLouvor.Text = "Num.";
			this.clnIDLouvor.Width = 70;
			// 
			// clnTitulo
			// 
			this.clnTitulo.Name = "clnTitulo";
			this.clnTitulo.Text = "Titulo";
			this.clnTitulo.Width = 500;
			// 
			// clnCategoria
			// 
			this.clnCategoria.Name = "clnCategoria";
			this.clnCategoria.Text = "Categoria";
			this.clnCategoria.Width = 200;
			// 
			// clnNota
			// 
			this.clnNota.AlignHorizontal = ComponentOwl.BetterListView.TextAlignmentHorizontal.Center;
			this.clnNota.AlignHorizontalImage = ComponentOwl.BetterListView.BetterListViewImageAlignmentHorizontal.OverlayCenter;
			this.clnNota.Name = "clnNota";
			this.clnNota.Text = "Classificação";
			this.clnNota.Width = 180;
			// 
			// clnTomDesc
			// 
			this.clnTomDesc.AlignHorizontal = ComponentOwl.BetterListView.TextAlignmentHorizontal.Center;
			this.clnTomDesc.Name = "clnTomDesc";
			this.clnTomDesc.Text = "Tom";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Digite o Título ou Número do Louvor";
			// 
			// txtProcura
			// 
			this.txtProcura.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProcura.Location = new System.Drawing.Point(12, 136);
			this.txtProcura.Name = "txtProcura";
			this.txtProcura.Size = new System.Drawing.Size(430, 33);
			this.txtProcura.TabIndex = 10;
			this.txtProcura.TextChanged += new System.EventHandler(this.txtProcura_TextChanged);
			// 
			// lblVersiculo
			// 
			this.lblVersiculo.AutoSize = true;
			this.lblVersiculo.BackColor = System.Drawing.Color.Transparent;
			this.lblVersiculo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersiculo.Location = new System.Drawing.Point(75, 59);
			this.lblVersiculo.Name = "lblVersiculo";
			this.lblVersiculo.Size = new System.Drawing.Size(265, 29);
			this.lblVersiculo.TabIndex = 8;
			this.lblVersiculo.Text = "Escolha o Louvor...";
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.AliceBlue;
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnVoltar.ForeColor = System.Drawing.Color.Black;
			this.btnVoltar.Image = global::CamadaUI.Properties.Resources.back;
			this.btnVoltar.InnerBorderColor = System.Drawing.Color.Transparent;
			this.btnVoltar.Location = new System.Drawing.Point(9, 50);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.OuterBorderColor = System.Drawing.Color.Transparent;
			this.btnVoltar.ShineColor = System.Drawing.Color.Linen;
			this.btnVoltar.Size = new System.Drawing.Size(65, 49);
			this.btnVoltar.TabIndex = 7;
			this.btnVoltar.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmLouvorLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1142, 623);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEscolher);
			this.Controls.Add(this.lstListagem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProcura);
			this.Controls.Add(this.lblVersiculo);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.pnlTop);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmLouvorLista";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLouvorLista";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.frmLouvorLista_Activated);
			this.pnlTop.ResumeLayout(false);
			this.mnuLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlTop;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.ContextMenuStrip mnuLista;
		private System.Windows.Forms.ToolStripMenuItem miRC;
		private System.Windows.Forms.ToolStripMenuItem miRA;
		private System.Windows.Forms.ToolStripMenuItem miNVI;
		private System.Windows.Forms.ToolStripMenuItem miFiel;
		private System.Windows.Forms.ToolStripMenuItem miNTLH;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEscolher;
		private ComponentOwl.BetterListView.BetterListView lstListagem;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnIDLouvor;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnTitulo;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnNota;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProcura;
		private System.Windows.Forms.Label lblVersiculo;
		private Glass.GlassButton btnVoltar;
		private System.Windows.Forms.ToolStripMenuItem miEditarLouvor;
		private System.Windows.Forms.ToolStripMenuItem miDefinirTom;
		private System.Windows.Forms.ToolStripMenuItem miTom1;
		private System.Windows.Forms.ToolStripMenuItem miTom2;
		private System.Windows.Forms.ToolStripMenuItem miTom3;
		private System.Windows.Forms.ToolStripMenuItem miTom4;
		private System.Windows.Forms.ToolStripMenuItem miTom5;
		private System.Windows.Forms.ToolStripMenuItem miTom6;
		private System.Windows.Forms.ToolStripMenuItem miTom7;
		private System.Windows.Forms.ToolStripMenuItem miTom8;
		private System.Windows.Forms.ToolStripMenuItem miTom9;
		private System.Windows.Forms.ToolStripMenuItem miTom10;
		private System.Windows.Forms.ToolStripMenuItem miTom11;
		private System.Windows.Forms.ToolStripMenuItem miTom12;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnTomDesc;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnCategoria;
	}
}