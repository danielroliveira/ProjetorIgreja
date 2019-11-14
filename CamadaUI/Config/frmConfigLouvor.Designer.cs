namespace CamadaUI.Config
{
	partial class frmConfigLouvor
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
			this.lstPastas = new ComponentOwl.BetterListView.BetterListView();
			this.clnFolder = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInserirFolder = new System.Windows.Forms.Button();
			this.btnRemoverCategoria = new System.Windows.Forms.Button();
			this.btnPesquisaLouvores = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lstCategorias = new ComponentOwl.BetterListView.BetterListView();
			this.clnCategoria = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInserirCategoria = new System.Windows.Forms.Button();
			this.btnRemoverFolder = new System.Windows.Forms.Button();
			this.pnlPastas = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnFechar = new System.Windows.Forms.Button();
			this.pgbLouvores = new System.Windows.Forms.ProgressBar();
			this.btnPastaBackup = new System.Windows.Forms.Button();
			this.btnBackupDB = new System.Windows.Forms.Button();
			this.btnBackupProjecoes = new System.Windows.Forms.Button();
			this.lblPastaBackup = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.chkBackupAuto = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstPastas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).BeginInit();
			this.pnlPastas.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.SlateGray;
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 4);
			this.lblTitulo.Size = new System.Drawing.Size(704, 30);
			this.lblTitulo.Text = "Configuração dos Louvores";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.SlateGray;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(704, 0);
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(744, 30);
			// 
			// lstPastas
			// 
			this.lstPastas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstPastas.Columns.Add(this.clnFolder);
			this.lstPastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPastas.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.None;
			this.lstPastas.HideSelectionMode = ComponentOwl.BetterListView.BetterListViewHideSelectionMode.KeepSelection;
			this.lstPastas.Location = new System.Drawing.Point(15, 41);
			this.lstPastas.Name = "lstPastas";
			this.lstPastas.Size = new System.Drawing.Size(685, 89);
			this.lstPastas.TabIndex = 1;
			// 
			// clnFolder
			// 
			this.clnFolder.DisplayMember = "LouvorFolder";
			this.clnFolder.MinimumWidth = 100;
			this.clnFolder.Name = "clnFolder";
			this.clnFolder.Text = "Pastas de Pesquisa";
			this.clnFolder.ValueMember = "IDLouvorFolder";
			this.clnFolder.Width = 650;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pastas de Pesquisa das Projeções:";
			// 
			// btnInserirFolder
			// 
			this.btnInserirFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnInserirFolder.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInserirFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnInserirFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnInserirFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserirFolder.Image = global::CamadaUI.Properties.Resources.add_24x24;
			this.btnInserirFolder.Location = new System.Drawing.Point(15, 141);
			this.btnInserirFolder.Name = "btnInserirFolder";
			this.btnInserirFolder.Size = new System.Drawing.Size(150, 36);
			this.btnInserirFolder.TabIndex = 3;
			this.btnInserirFolder.Text = "Inserir Pasta";
			this.btnInserirFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInserirFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserirFolder.UseVisualStyleBackColor = true;
			this.btnInserirFolder.Click += new System.EventHandler(this.btnInserirFolder_Click);
			// 
			// btnRemoverCategoria
			// 
			this.btnRemoverCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoverCategoria.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRemoverCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnRemoverCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnRemoverCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverCategoria.Image = global::CamadaUI.Properties.Resources.delete_24px;
			this.btnRemoverCategoria.Location = new System.Drawing.Point(167, 228);
			this.btnRemoverCategoria.Name = "btnRemoverCategoria";
			this.btnRemoverCategoria.Size = new System.Drawing.Size(140, 36);
			this.btnRemoverCategoria.TabIndex = 3;
			this.btnRemoverCategoria.Text = "Remover";
			this.btnRemoverCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemoverCategoria.UseVisualStyleBackColor = true;
			this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
			// 
			// btnPesquisaLouvores
			// 
			this.btnPesquisaLouvores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPesquisaLouvores.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnPesquisaLouvores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnPesquisaLouvores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnPesquisaLouvores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisaLouvores.Image = global::CamadaUI.Properties.Resources.refresh_24;
			this.btnPesquisaLouvores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPesquisaLouvores.Location = new System.Drawing.Point(327, 141);
			this.btnPesquisaLouvores.Name = "btnPesquisaLouvores";
			this.btnPesquisaLouvores.Size = new System.Drawing.Size(179, 36);
			this.btnPesquisaLouvores.TabIndex = 3;
			this.btnPesquisaLouvores.Text = "Pesquisar Louvores";
			this.btnPesquisaLouvores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPesquisaLouvores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPesquisaLouvores.UseVisualStyleBackColor = true;
			this.btnPesquisaLouvores.Click += new System.EventHandler(this.btnPesquisaLouvores_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::CamadaUI.Properties.Resources.refresh_24;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(512, 141);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 36);
			this.button1.TabIndex = 3;
			this.button1.Text = "Verificar Arquivos";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lstCategorias
			// 
			this.lstCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstCategorias.Columns.Add(this.clnCategoria);
			this.lstCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCategorias.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.None;
			this.lstCategorias.HideSelectionMode = ComponentOwl.BetterListView.BetterListViewHideSelectionMode.KeepSelection;
			this.lstCategorias.LabelEditModeItems = ComponentOwl.BetterListView.BetterListViewLabelEditMode.Text;
			this.lstCategorias.Location = new System.Drawing.Point(14, 41);
			this.lstCategorias.Name = "lstCategorias";
			this.lstCategorias.Size = new System.Drawing.Size(293, 176);
			this.lstCategorias.TabIndex = 1;
			this.lstCategorias.AfterLabelEdit += new ComponentOwl.BetterListView.BetterListViewLabelEditEventHandler(this.lstCategorias_AfterLabelEdit);
			this.lstCategorias.BeforeLabelEdit += new ComponentOwl.BetterListView.BetterListViewLabelEditCancelEventHandler(this.lstCategorias_BeforeLabelEdit);
			// 
			// clnCategoria
			// 
			this.clnCategoria.DisplayMember = "Categoria";
			this.clnCategoria.MinimumWidth = 100;
			this.clnCategoria.Name = "clnCategoria";
			this.clnCategoria.Text = "Pastas de Pesquisa";
			this.clnCategoria.ValueMember = "IDCategoria";
			this.clnCategoria.Width = 265;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Categorias de Louvor:";
			// 
			// btnInserirCategoria
			// 
			this.btnInserirCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInserirCategoria.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInserirCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnInserirCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnInserirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserirCategoria.Image = global::CamadaUI.Properties.Resources.add_24x24;
			this.btnInserirCategoria.Location = new System.Drawing.Point(14, 228);
			this.btnInserirCategoria.Name = "btnInserirCategoria";
			this.btnInserirCategoria.Size = new System.Drawing.Size(140, 36);
			this.btnInserirCategoria.TabIndex = 3;
			this.btnInserirCategoria.Text = "Inserir";
			this.btnInserirCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInserirCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserirCategoria.UseVisualStyleBackColor = true;
			this.btnInserirCategoria.Click += new System.EventHandler(this.btnInserirCategoria_Click);
			// 
			// btnRemoverFolder
			// 
			this.btnRemoverFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoverFolder.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRemoverFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnRemoverFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnRemoverFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverFolder.Image = global::CamadaUI.Properties.Resources.delete_24px;
			this.btnRemoverFolder.Location = new System.Drawing.Point(171, 141);
			this.btnRemoverFolder.Name = "btnRemoverFolder";
			this.btnRemoverFolder.Size = new System.Drawing.Size(150, 36);
			this.btnRemoverFolder.TabIndex = 3;
			this.btnRemoverFolder.Text = "Remover Pasta";
			this.btnRemoverFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemoverFolder.UseVisualStyleBackColor = true;
			this.btnRemoverFolder.Click += new System.EventHandler(this.btnRemoverFolder_Click);
			// 
			// pnlPastas
			// 
			this.pnlPastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.pnlPastas.Controls.Add(this.btnRemoverFolder);
			this.pnlPastas.Controls.Add(this.btnInserirFolder);
			this.pnlPastas.Controls.Add(this.label1);
			this.pnlPastas.Controls.Add(this.lstPastas);
			this.pnlPastas.Controls.Add(this.btnPesquisaLouvores);
			this.pnlPastas.Controls.Add(this.button1);
			this.pnlPastas.Location = new System.Drawing.Point(14, 45);
			this.pnlPastas.Name = "pnlPastas";
			this.pnlPastas.Size = new System.Drawing.Size(716, 188);
			this.pnlPastas.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.panel2.Controls.Add(this.btnRemoverCategoria);
			this.panel2.Controls.Add(this.btnInserirCategoria);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.lstCategorias);
			this.panel2.Location = new System.Drawing.Point(14, 250);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(321, 275);
			this.panel2.TabIndex = 5;
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.Fechar_24x24;
			this.btnFechar.Location = new System.Drawing.Point(590, 532);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(140, 40);
			this.btnFechar.TabIndex = 3;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pgbLouvores
			// 
			this.pgbLouvores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pgbLouvores.Location = new System.Drawing.Point(14, 537);
			this.pgbLouvores.Name = "pgbLouvores";
			this.pgbLouvores.Size = new System.Drawing.Size(570, 30);
			this.pgbLouvores.TabIndex = 6;
			this.pgbLouvores.Visible = false;
			// 
			// btnPastaBackup
			// 
			this.btnPastaBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPastaBackup.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnPastaBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnPastaBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnPastaBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPastaBackup.Image = global::CamadaUI.Properties.Resources.folder_accept;
			this.btnPastaBackup.Location = new System.Drawing.Point(86, 97);
			this.btnPastaBackup.Name = "btnPastaBackup";
			this.btnPastaBackup.Size = new System.Drawing.Size(208, 36);
			this.btnPastaBackup.TabIndex = 3;
			this.btnPastaBackup.Text = "&Definir Pasta de Backup";
			this.btnPastaBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPastaBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPastaBackup.UseVisualStyleBackColor = true;
			this.btnPastaBackup.Click += new System.EventHandler(this.btnPastaBackup_Click);
			// 
			// btnBackupDB
			// 
			this.btnBackupDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackupDB.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnBackupDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnBackupDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupDB.Image = global::CamadaUI.Properties.Resources.backup_24;
			this.btnBackupDB.Location = new System.Drawing.Point(86, 139);
			this.btnBackupDB.Name = "btnBackupDB";
			this.btnBackupDB.Size = new System.Drawing.Size(208, 36);
			this.btnBackupDB.TabIndex = 3;
			this.btnBackupDB.Text = " &Backup BD";
			this.btnBackupDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBackupDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackupDB.UseVisualStyleBackColor = true;
			// 
			// btnBackupProjecoes
			// 
			this.btnBackupProjecoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackupProjecoes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnBackupProjecoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnBackupProjecoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnBackupProjecoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupProjecoes.Image = global::CamadaUI.Properties.Resources.backup_24;
			this.btnBackupProjecoes.Location = new System.Drawing.Point(86, 181);
			this.btnBackupProjecoes.Name = "btnBackupProjecoes";
			this.btnBackupProjecoes.Size = new System.Drawing.Size(208, 36);
			this.btnBackupProjecoes.TabIndex = 3;
			this.btnBackupProjecoes.Text = " Backup &Projeções";
			this.btnBackupProjecoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBackupProjecoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackupProjecoes.UseVisualStyleBackColor = true;
			this.btnBackupProjecoes.Click += new System.EventHandler(this.btnBackupProjecoes_Click);
			// 
			// lblPastaBackup
			// 
			this.lblPastaBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.lblPastaBackup.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPastaBackup.Location = new System.Drawing.Point(357, 312);
			this.lblPastaBackup.Name = "lblPastaBackup";
			this.lblPastaBackup.Size = new System.Drawing.Size(367, 28);
			this.lblPastaBackup.TabIndex = 7;
			this.lblPastaBackup.Text = "c:\\Usuarios\\Documentos\\Projetor\\";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Pasta de Backup:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.panel3.Controls.Add(this.chkBackupAuto);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.btnBackupProjecoes);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.btnBackupDB);
			this.panel3.Controls.Add(this.btnPastaBackup);
			this.panel3.Location = new System.Drawing.Point(350, 250);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(379, 275);
			this.panel3.TabIndex = 8;
			// 
			// chkBackupAuto
			// 
			this.chkBackupAuto.AutoSize = true;
			this.chkBackupAuto.Location = new System.Drawing.Point(25, 237);
			this.chkBackupAuto.Name = "chkBackupAuto";
			this.chkBackupAuto.Size = new System.Drawing.Size(326, 23);
			this.chkBackupAuto.TabIndex = 8;
			this.chkBackupAuto.Text = "Fazer Backup automático das novas projeções";
			this.chkBackupAuto.UseVisualStyleBackColor = true;
			this.chkBackupAuto.CheckedChanged += new System.EventHandler(this.chkBackupAuto_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(212, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Salvar Arquivos | Backup:";
			// 
			// frmConfigLouvor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.lblPastaBackup);
			this.Controls.Add(this.pgbLouvores);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlPastas);
			this.Controls.Add(this.panel3);
			this.Name = "frmConfigLouvor";
			this.Load += new System.EventHandler(this.frmConfigLouvor_Load);
			this.Controls.SetChildIndex(this.panel3, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.pnlPastas, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.pgbLouvores, 0);
			this.Controls.SetChildIndex(this.lblPastaBackup, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstPastas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).EndInit();
			this.pnlPastas.ResumeLayout(false);
			this.pnlPastas.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ComponentOwl.BetterListView.BetterListView lstPastas;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnFolder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInserirFolder;
		private System.Windows.Forms.Button btnRemoverCategoria;
		private System.Windows.Forms.Button btnPesquisaLouvores;
		private System.Windows.Forms.Button button1;
		private ComponentOwl.BetterListView.BetterListView lstCategorias;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnInserirCategoria;
		private System.Windows.Forms.Button btnRemoverFolder;
		private System.Windows.Forms.Panel pnlPastas;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnFechar;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnCategoria;
		private System.Windows.Forms.ProgressBar pgbLouvores;
		private System.Windows.Forms.Button btnPastaBackup;
		private System.Windows.Forms.Button btnBackupDB;
		private System.Windows.Forms.Button btnBackupProjecoes;
		private System.Windows.Forms.Label lblPastaBackup;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkBackupAuto;
	}
}
