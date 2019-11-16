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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miLouvorDuplicado = new System.Windows.Forms.ToolStripMenuItem();
			this.miOcultarDaLista = new System.Windows.Forms.ToolStripMenuItem();
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
			this.pnlHistorico = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnHistorico = new System.Windows.Forms.Button();
			this.btnProcurar = new System.Windows.Forms.Button();
			this.txtIDCategoria = new System.Windows.Forms.TextBox();
			this.rbtAtivo = new System.Windows.Forms.RadioButton();
			this.rbtOculto = new System.Windows.Forms.RadioButton();
			this.rbtDuplicado = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlSituacao = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCategoriaEscolher = new System.Windows.Forms.Button();
			this.clnFileOK = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.pnlTop.SuspendLayout();
			this.mnuLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).BeginInit();
			this.pnlHistorico.SuspendLayout();
			this.pnlSituacao.SuspendLayout();
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
			this.pnlTop.Size = new System.Drawing.Size(1218, 40);
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
			this.lblTitulo.Size = new System.Drawing.Size(316, 40);
			this.lblTitulo.TabIndex = 0;
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
			this.btnClose.Location = new System.Drawing.Point(1178, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 2;
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
			this.btnMinimizer.Location = new System.Drawing.Point(1138, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 40);
			this.btnMinimizer.TabIndex = 1;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			// 
			// mnuLista
			// 
			this.mnuLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditarLouvor,
            this.miDefinirTom,
            this.toolStripSeparator1,
            this.miLouvorDuplicado,
            this.miOcultarDaLista});
			this.mnuLista.Name = "mnuLinguagens";
			this.mnuLista.Size = new System.Drawing.Size(191, 106);
			this.mnuLista.Opening += new System.ComponentModel.CancelEventHandler(this.mnuLista_Opening);
			// 
			// miEditarLouvor
			// 
			this.miEditarLouvor.Image = global::CamadaUI.Properties.Resources.editar_16;
			this.miEditarLouvor.Name = "miEditarLouvor";
			this.miEditarLouvor.Size = new System.Drawing.Size(190, 24);
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
			this.miDefinirTom.Size = new System.Drawing.Size(190, 24);
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
			// 
			// miLouvorDuplicado
			// 
			this.miLouvorDuplicado.Image = global::CamadaUI.Properties.Resources.warning;
			this.miLouvorDuplicado.Name = "miLouvorDuplicado";
			this.miLouvorDuplicado.Size = new System.Drawing.Size(190, 24);
			this.miLouvorDuplicado.Text = "Louvor Duplicado";
			this.miLouvorDuplicado.Click += new System.EventHandler(this.miLouvorDuplicado_Click);
			// 
			// miOcultarDaLista
			// 
			this.miOcultarDaLista.Image = global::CamadaUI.Properties.Resources.cancelar_24;
			this.miOcultarDaLista.Name = "miOcultarDaLista";
			this.miOcultarDaLista.Size = new System.Drawing.Size(190, 24);
			this.miOcultarDaLista.Text = "Ocultar da Lista";
			this.miOcultarDaLista.Click += new System.EventHandler(this.miOcultarDaLista_Click);
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
			this.btnEditar.TabIndex = 10;
			this.btnEditar.Text = "&Editar Louvor";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.miEditarLouvor_Click);
			this.btnEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorLista_KeyDown);
			// 
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.projetar_32;
			this.btnEscolher.Location = new System.Drawing.Point(994, 569);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(212, 45);
			this.btnEscolher.TabIndex = 11;
			this.btnEscolher.Text = " &Projetar Louvor";
			this.btnEscolher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEscolher.UseVisualStyleBackColor = true;
			this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
			this.btnEscolher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorLista_KeyDown);
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
			this.lstListagem.Columns.Add(this.clnFileOK);
			this.lstListagem.ContextMenuStrip = this.mnuLista;
			this.lstListagem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstListagem.Location = new System.Drawing.Point(12, 180);
			this.lstListagem.MultiSelect = false;
			this.lstListagem.Name = "lstListagem";
			this.lstListagem.Size = new System.Drawing.Size(1194, 380);
			this.lstListagem.TabIndex = 9;
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
			this.label1.TabIndex = 1;
			this.label1.Text = "Digite o Título ou Número do Louvor";
			// 
			// txtProcura
			// 
			this.txtProcura.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProcura.Location = new System.Drawing.Point(12, 136);
			this.txtProcura.Name = "txtProcura";
			this.txtProcura.Size = new System.Drawing.Size(396, 33);
			this.txtProcura.TabIndex = 2;
			this.txtProcura.Tag = "Nenhum louvor encontrado, pressione DEL";
			this.txtProcura.TextChanged += new System.EventHandler(this.txtProcura_TextChanged);
			this.txtProcura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcura_KeyDown);
			this.txtProcura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcura_KeyPress);
			// 
			// lblVersiculo
			// 
			this.lblVersiculo.AutoSize = true;
			this.lblVersiculo.BackColor = System.Drawing.Color.Transparent;
			this.lblVersiculo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersiculo.Location = new System.Drawing.Point(75, 59);
			this.lblVersiculo.Name = "lblVersiculo";
			this.lblVersiculo.Size = new System.Drawing.Size(265, 29);
			this.lblVersiculo.TabIndex = 14;
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
			this.btnVoltar.TabIndex = 13;
			this.btnVoltar.TabStop = false;
			this.btnVoltar.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlHistorico
			// 
			this.pnlHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(171)))), ((int)(((byte)(205)))));
			this.pnlHistorico.Controls.Add(this.label2);
			this.pnlHistorico.Controls.Add(this.btnHistorico);
			this.pnlHistorico.Location = new System.Drawing.Point(981, 40);
			this.pnlHistorico.Name = "pnlHistorico";
			this.pnlHistorico.Size = new System.Drawing.Size(237, 32);
			this.pnlHistorico.TabIndex = 12;
			this.pnlHistorico.Visible = false;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Right;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(4, 0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.label2.Size = new System.Drawing.Size(193, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "Histórico de Louvores";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Click += new System.EventHandler(this.label1_Click);
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
			this.btnHistorico.Location = new System.Drawing.Point(197, 0);
			this.btnHistorico.Margin = new System.Windows.Forms.Padding(0);
			this.btnHistorico.Name = "btnHistorico";
			this.btnHistorico.Size = new System.Drawing.Size(40, 32);
			this.btnHistorico.TabIndex = 1;
			this.btnHistorico.TabStop = false;
			this.btnHistorico.UseVisualStyleBackColor = false;
			this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
			// 
			// btnProcurar
			// 
			this.btnProcurar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcurar.Image = global::CamadaUI.Properties.Resources.search_peq;
			this.btnProcurar.Location = new System.Drawing.Point(414, 136);
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(129, 33);
			this.btnProcurar.TabIndex = 3;
			this.btnProcurar.Tag = "Cliqui aqui para procurar...";
			this.btnProcurar.Text = "&Procurar";
			this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProcurar.UseVisualStyleBackColor = true;
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			this.btnProcurar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorLista_KeyDown);
			// 
			// txtIDCategoria
			// 
			this.txtIDCategoria.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDCategoria.Location = new System.Drawing.Point(562, 136);
			this.txtIDCategoria.Name = "txtIDCategoria";
			this.txtIDCategoria.Size = new System.Drawing.Size(289, 33);
			this.txtIDCategoria.TabIndex = 5;
			this.txtIDCategoria.Tag = "Pressione (+) para escolher categoria, ou (DEL) para limpar";
			this.txtIDCategoria.Visible = false;
			this.txtIDCategoria.Enter += new System.EventHandler(this.txtIDCategoria_Enter);
			this.txtIDCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDCategoria_KeyDown);
			this.txtIDCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCategoria_KeyPress);
			// 
			// rbtAtivo
			// 
			this.rbtAtivo.AutoSize = true;
			this.rbtAtivo.Checked = true;
			this.rbtAtivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtAtivo.Location = new System.Drawing.Point(11, 6);
			this.rbtAtivo.Name = "rbtAtivo";
			this.rbtAtivo.Size = new System.Drawing.Size(68, 22);
			this.rbtAtivo.TabIndex = 0;
			this.rbtAtivo.TabStop = true;
			this.rbtAtivo.Text = "Ativo";
			this.rbtAtivo.UseVisualStyleBackColor = true;
			this.rbtAtivo.CheckedChanged += new System.EventHandler(this.rbtSituacao_CheckedChanged);
			// 
			// rbtOculto
			// 
			this.rbtOculto.AutoSize = true;
			this.rbtOculto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtOculto.Location = new System.Drawing.Point(89, 6);
			this.rbtOculto.Name = "rbtOculto";
			this.rbtOculto.Size = new System.Drawing.Size(79, 22);
			this.rbtOculto.TabIndex = 1;
			this.rbtOculto.Text = "Oculto";
			this.rbtOculto.UseVisualStyleBackColor = true;
			this.rbtOculto.CheckedChanged += new System.EventHandler(this.rbtSituacao_CheckedChanged);
			// 
			// rbtDuplicado
			// 
			this.rbtDuplicado.AutoSize = true;
			this.rbtDuplicado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtDuplicado.Location = new System.Drawing.Point(177, 6);
			this.rbtDuplicado.Name = "rbtDuplicado";
			this.rbtDuplicado.Size = new System.Drawing.Size(106, 22);
			this.rbtDuplicado.TabIndex = 2;
			this.rbtDuplicado.Text = "Duplicado";
			this.rbtDuplicado.UseVisualStyleBackColor = true;
			this.rbtDuplicado.CheckedChanged += new System.EventHandler(this.rbtSituacao_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(559, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Filtrar Categoria (+)";
			// 
			// pnlSituacao
			// 
			this.pnlSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(217)))), ((int)(((byte)(233)))));
			this.pnlSituacao.Controls.Add(this.rbtDuplicado);
			this.pnlSituacao.Controls.Add(this.rbtOculto);
			this.pnlSituacao.Controls.Add(this.rbtAtivo);
			this.pnlSituacao.Location = new System.Drawing.Point(912, 136);
			this.pnlSituacao.Name = "pnlSituacao";
			this.pnlSituacao.Size = new System.Drawing.Size(294, 33);
			this.pnlSituacao.TabIndex = 8;
			this.pnlSituacao.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(908, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Situação:";
			// 
			// btnCategoriaEscolher
			// 
			this.btnCategoriaEscolher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCategoriaEscolher.Location = new System.Drawing.Point(857, 136);
			this.btnCategoriaEscolher.Name = "btnCategoriaEscolher";
			this.btnCategoriaEscolher.Size = new System.Drawing.Size(37, 33);
			this.btnCategoriaEscolher.TabIndex = 6;
			this.btnCategoriaEscolher.TabStop = false;
			this.btnCategoriaEscolher.Tag = "Cliqui aqui para escolher a Categoria...";
			this.btnCategoriaEscolher.Text = "...";
			this.btnCategoriaEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCategoriaEscolher.UseVisualStyleBackColor = true;
			this.btnCategoriaEscolher.Click += new System.EventHandler(this.btnCategoriaEscolher_Click);
			this.btnCategoriaEscolher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorLista_KeyDown);
			// 
			// clnFileOK
			// 
			this.clnFileOK.DisplayMember = "FileOK";
			this.clnFileOK.MaximumWidth = 0;
			this.clnFileOK.Name = "clnFileOK";
			this.clnFileOK.Text = "FileOK";
			this.clnFileOK.ValueMember = "FileOK";
			this.clnFileOK.Width = 0;
			// 
			// frmLouvorLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1218, 623);
			this.Controls.Add(this.pnlSituacao);
			this.Controls.Add(this.txtIDCategoria);
			this.Controls.Add(this.pnlHistorico);
			this.Controls.Add(this.btnCategoriaEscolher);
			this.Controls.Add(this.btnProcurar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEscolher);
			this.Controls.Add(this.lstListagem);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProcura);
			this.Controls.Add(this.lblVersiculo);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.pnlTop);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmLouvorLista";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLouvorLista";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.frmLouvorLista_Activated);
			this.Shown += new System.EventHandler(this.frmLouvorLista_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorLista_KeyDown);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmLouvorLista_PreviewKeyDown);
			this.pnlTop.ResumeLayout(false);
			this.mnuLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).EndInit();
			this.pnlHistorico.ResumeLayout(false);
			this.pnlSituacao.ResumeLayout(false);
			this.pnlSituacao.PerformLayout();
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
		public System.Windows.Forms.Panel pnlHistorico;
		private System.Windows.Forms.Label label2;
		protected internal System.Windows.Forms.Button btnHistorico;
		private System.Windows.Forms.Button btnProcurar;
		private System.Windows.Forms.ToolStripMenuItem miLouvorDuplicado;
		private System.Windows.Forms.ToolStripMenuItem miOcultarDaLista;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TextBox txtIDCategoria;
		private System.Windows.Forms.RadioButton rbtOculto;
		private System.Windows.Forms.RadioButton rbtAtivo;
		private System.Windows.Forms.RadioButton rbtDuplicado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnlSituacao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCategoriaEscolher;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnFileOK;
	}
}