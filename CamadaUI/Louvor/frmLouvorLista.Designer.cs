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
			this.mnuLinguagens = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miRC = new System.Windows.Forms.ToolStripMenuItem();
			this.miRA = new System.Windows.Forms.ToolStripMenuItem();
			this.miNVI = new System.Windows.Forms.ToolStripMenuItem();
			this.miFiel = new System.Windows.Forms.ToolStripMenuItem();
			this.miNTLH = new System.Windows.Forms.ToolStripMenuItem();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnEscolher = new System.Windows.Forms.Button();
			this.lstListagem = new ComponentOwl.BetterListView.BetterListView();
			this.clnIDLouvor = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnTitulo = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnNota = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProcura = new System.Windows.Forms.TextBox();
			this.lblVersiculo = new System.Windows.Forms.Label();
			this.btnVoltar = new Glass.GlassButton();
			this.pnlTop.SuspendLayout();
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
			this.btnClose.Location = new System.Drawing.Point(933, 0);
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
			this.btnMinimizer.Location = new System.Drawing.Point(893, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 40);
			this.btnMinimizer.TabIndex = 2;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			// 
			// mnuLinguagens
			// 
			this.mnuLinguagens.Name = "mnuLinguagens";
			this.mnuLinguagens.Size = new System.Drawing.Size(61, 4);
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
			// btnInserir
			// 
			this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInserir.Image = global::CamadaUI.Properties.Resources.accept;
			this.btnInserir.Location = new System.Drawing.Point(679, 569);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(138, 45);
			this.btnInserir.TabIndex = 12;
			this.btnInserir.Text = "&Inserir";
			this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.accept;
			this.btnEscolher.Location = new System.Drawing.Point(823, 569);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(138, 45);
			this.btnEscolher.TabIndex = 13;
			this.btnEscolher.Text = "&Escolher";
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
			this.lstListagem.Columns.Add(this.clnNota);
			this.lstListagem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstListagem.Location = new System.Drawing.Point(12, 180);
			this.lstListagem.MultiSelect = false;
			this.lstListagem.Name = "lstListagem";
			this.lstListagem.Size = new System.Drawing.Size(949, 380);
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
			// clnNota
			// 
			this.clnNota.AlignHorizontal = ComponentOwl.BetterListView.TextAlignmentHorizontal.Center;
			this.clnNota.AlignHorizontalImage = ComponentOwl.BetterListView.BetterListViewImageAlignmentHorizontal.OverlayCenter;
			this.clnNota.Name = "clnNota";
			this.clnNota.Text = "Classificação";
			this.clnNota.Width = 180;
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
			this.ClientSize = new System.Drawing.Size(973, 623);
			this.Controls.Add(this.btnInserir);
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
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Panel pnlTop;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.ContextMenuStrip mnuLinguagens;
		private System.Windows.Forms.ToolStripMenuItem miRC;
		private System.Windows.Forms.ToolStripMenuItem miRA;
		private System.Windows.Forms.ToolStripMenuItem miNVI;
		private System.Windows.Forms.ToolStripMenuItem miFiel;
		private System.Windows.Forms.ToolStripMenuItem miNTLH;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.Button btnEscolher;
		private ComponentOwl.BetterListView.BetterListView lstListagem;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnIDLouvor;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnTitulo;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnNota;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProcura;
		private System.Windows.Forms.Label lblVersiculo;
		private Glass.GlassButton btnVoltar;
	}
}