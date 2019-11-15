namespace CamadaUI.Louvor
{
	partial class frmCategoriaEscolher
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEscolher = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lstCategorias = new ComponentOwl.BetterListView.BetterListView();
			this.clnCategoria = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(53, 0);
			this.lblTitulo.Text = "Escolha a Categoria";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(312, 0);
			this.btnClose.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(352, 50);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Image = global::CamadaUI.Properties.Resources.delete_24px;
			this.btnCancelar.Location = new System.Drawing.Point(200, 313);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(140, 36);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEscolher.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEscolher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnEscolher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.accept;
			this.btnEscolher.Location = new System.Drawing.Point(12, 313);
			this.btnEscolher.Margin = new System.Windows.Forms.Padding(6);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(140, 36);
			this.btnEscolher.TabIndex = 7;
			this.btnEscolher.Text = "Escolher";
			this.btnEscolher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEscolher.UseVisualStyleBackColor = true;
			this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Categorias de Louvor:";
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
			this.lstCategorias.Location = new System.Drawing.Point(12, 85);
			this.lstCategorias.Name = "lstCategorias";
			this.lstCategorias.Size = new System.Drawing.Size(328, 217);
			this.lstCategorias.TabIndex = 4;
			this.lstCategorias.ItemActivate += new ComponentOwl.BetterListView.BetterListViewItemActivateEventHandler(this.lstCategorias_ItemActivate);
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
			// frmCategoriaEscolher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(352, 362);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEscolher);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstCategorias);
			this.Name = "frmCategoriaEscolher";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lstCategorias, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.btnEscolher, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEscolher;
		private System.Windows.Forms.Label label2;
		private ComponentOwl.BetterListView.BetterListView lstCategorias;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnCategoria;
	}
}
