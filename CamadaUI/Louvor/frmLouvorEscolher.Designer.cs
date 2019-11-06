namespace CamadaUI.Louvor
{
	partial class frmLouvorEscolher
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
			this.lblVersiculo = new System.Windows.Forms.Label();
			this.btnVoltar = new Glass.GlassButton();
			this.txtProcura = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstListagem = new ComponentOwl.BetterListView.BetterListView();
			this.clnIDLouvor = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnTitulo = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnNota = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.btnEscolher = new System.Windows.Forms.Button();
			this.btnMinimizer = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
			this.lblTitulo.Size = new System.Drawing.Size(310, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Escolher | Pesquisar Louvor";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(778, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMinimizer);
			this.panel1.Size = new System.Drawing.Size(818, 50);
			this.panel1.Controls.SetChildIndex(this.btnClose, 0);
			this.panel1.Controls.SetChildIndex(this.lblTitulo, 0);
			this.panel1.Controls.SetChildIndex(this.btnMinimizer, 0);
			// 
			// lblVersiculo
			// 
			this.lblVersiculo.AutoSize = true;
			this.lblVersiculo.BackColor = System.Drawing.Color.Transparent;
			this.lblVersiculo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersiculo.Location = new System.Drawing.Point(75, 70);
			this.lblVersiculo.Name = "lblVersiculo";
			this.lblVersiculo.Size = new System.Drawing.Size(265, 29);
			this.lblVersiculo.TabIndex = 2;
			this.lblVersiculo.Text = "Escolha o Louvor...";
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.AliceBlue;
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnVoltar.ForeColor = System.Drawing.Color.Black;
			this.btnVoltar.Image = global::CamadaUI.Properties.Resources.back;
			this.btnVoltar.InnerBorderColor = System.Drawing.Color.Transparent;
			this.btnVoltar.Location = new System.Drawing.Point(9, 61);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.OuterBorderColor = System.Drawing.Color.Transparent;
			this.btnVoltar.ShineColor = System.Drawing.Color.Linen;
			this.btnVoltar.Size = new System.Drawing.Size(65, 49);
			this.btnVoltar.TabIndex = 1;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// txtProcura
			// 
			this.txtProcura.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProcura.Location = new System.Drawing.Point(12, 147);
			this.txtProcura.Name = "txtProcura";
			this.txtProcura.Size = new System.Drawing.Size(430, 33);
			this.txtProcura.TabIndex = 4;
			this.txtProcura.TextChanged += new System.EventHandler(this.txtProcura_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Digite o Título ou Número do Louvor";
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
			this.lstListagem.Location = new System.Drawing.Point(12, 191);
			this.lstListagem.MultiSelect = false;
			this.lstListagem.Name = "lstListagem";
			this.lstListagem.Size = new System.Drawing.Size(794, 344);
			this.lstListagem.TabIndex = 5;
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
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.accept;
			this.btnEscolher.Location = new System.Drawing.Point(668, 541);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(138, 45);
			this.btnEscolher.TabIndex = 6;
			this.btnEscolher.Text = "&Escolher";
			this.btnEscolher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEscolher.UseVisualStyleBackColor = true;
			this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
			// 
			// btnMinimizer
			// 
			this.btnMinimizer.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimizer.FlatAppearance.BorderSize = 0;
			this.btnMinimizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnMinimizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnMinimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizer.Image = global::CamadaUI.Properties.Resources.DropdownIcon;
			this.btnMinimizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnMinimizer.Location = new System.Drawing.Point(738, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 50);
			this.btnMinimizer.TabIndex = 3;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInserir.Image = global::CamadaUI.Properties.Resources.accept;
			this.btnInserir.Location = new System.Drawing.Point(524, 541);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(138, 45);
			this.btnInserir.TabIndex = 6;
			this.btnInserir.Text = "&Inserir";
			this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// frmLouvorEscolher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(818, 593);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.btnEscolher);
			this.Controls.Add(this.lstListagem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProcura);
			this.Controls.Add(this.lblVersiculo);
			this.Controls.Add(this.btnVoltar);
			this.KeyPreview = true;
			this.Name = "frmLouvorEscolher";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.frmLouvorEscolher_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLouvorEscolher_FormClosed);
			this.Shown += new System.EventHandler(this.frmLouvorEscolher_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorEscolher_KeyDown);
			this.Controls.SetChildIndex(this.btnVoltar, 0);
			this.Controls.SetChildIndex(this.lblVersiculo, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.txtProcura, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lstListagem, 0);
			this.Controls.SetChildIndex(this.btnEscolher, 0);
			this.Controls.SetChildIndex(this.btnInserir, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblVersiculo;
		private Glass.GlassButton btnVoltar;
		private System.Windows.Forms.TextBox txtProcura;
		private System.Windows.Forms.Label label1;
		private ComponentOwl.BetterListView.BetterListView lstListagem;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnIDLouvor;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnTitulo;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnNota;
		private System.Windows.Forms.Button btnEscolher;
		internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.Button btnInserir;
	}
}
