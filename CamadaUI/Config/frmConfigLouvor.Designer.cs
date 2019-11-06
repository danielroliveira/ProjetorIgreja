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
			this.lstListagem = new ComponentOwl.BetterListView.BetterListView();
			this.clnFolder = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInserirFolder = new System.Windows.Forms.Button();
			this.btnRemoverFolder = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).BeginInit();
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
			// lstListagem
			// 
			this.lstListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstListagem.Columns.Add(this.clnFolder);
			this.lstListagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstListagem.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.None;
			this.lstListagem.Location = new System.Drawing.Point(28, 68);
			this.lstListagem.Name = "lstListagem";
			this.lstListagem.Size = new System.Drawing.Size(338, 296);
			this.lstListagem.TabIndex = 1;
			// 
			// clnFolder
			// 
			this.clnFolder.DisplayMember = "LouvorFolder";
			this.clnFolder.MinimumWidth = 100;
			this.clnFolder.Name = "clnFolder";
			this.clnFolder.Text = "Pastas de Pesquisa";
			this.clnFolder.ValueMember = "IDLouvorFolder";
			this.clnFolder.Width = 300;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Pastas de Pesquisa das Projeções:";
			// 
			// btnInserirFolder
			// 
			this.btnInserirFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnInserirFolder.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnInserirFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnInserirFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnInserirFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserirFolder.Image = global::CamadaUI.Properties.Resources.add_24x24;
			this.btnInserirFolder.Location = new System.Drawing.Point(28, 370);
			this.btnInserirFolder.Name = "btnInserirFolder";
			this.btnInserirFolder.Size = new System.Drawing.Size(121, 36);
			this.btnInserirFolder.TabIndex = 3;
			this.btnInserirFolder.Text = "Inserir";
			this.btnInserirFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInserirFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserirFolder.UseVisualStyleBackColor = true;
			this.btnInserirFolder.Click += new System.EventHandler(this.btnInserirFolder_Click);
			// 
			// btnRemoverFolder
			// 
			this.btnRemoverFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemoverFolder.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnRemoverFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnRemoverFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnRemoverFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverFolder.Image = global::CamadaUI.Properties.Resources.delete_24px;
			this.btnRemoverFolder.Location = new System.Drawing.Point(247, 370);
			this.btnRemoverFolder.Name = "btnRemoverFolder";
			this.btnRemoverFolder.Size = new System.Drawing.Size(121, 36);
			this.btnRemoverFolder.TabIndex = 3;
			this.btnRemoverFolder.Text = "Remover";
			this.btnRemoverFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemoverFolder.UseVisualStyleBackColor = true;
			this.btnRemoverFolder.Click += new System.EventHandler(this.btnRemoverFolder_Click);
			// 
			// frmConfigLouvor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.btnRemoverFolder);
			this.Controls.Add(this.btnInserirFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstListagem);
			this.Name = "frmConfigLouvor";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lstListagem, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.btnInserirFolder, 0);
			this.Controls.SetChildIndex(this.btnRemoverFolder, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstListagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComponentOwl.BetterListView.BetterListView lstListagem;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnFolder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInserirFolder;
		private System.Windows.Forms.Button btnRemoverFolder;
	}
}
