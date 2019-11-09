namespace CamadaUI.Louvor
{
	partial class frmLouvorEditar
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
			this.lblProjecaoPath = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbIDCategoria = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAtivo = new System.Windows.Forms.Button();
			this.pctFav1 = new System.Windows.Forms.PictureBox();
			this.pctFav2 = new System.Windows.Forms.PictureBox();
			this.pctFav3 = new System.Windows.Forms.PictureBox();
			this.pctFav4 = new System.Windows.Forms.PictureBox();
			this.pctFav5 = new System.Windows.Forms.PictureBox();
			this.pnlFavorito = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblEscolhidoCount = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pnlAtivo = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctFav1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav5)).BeginInit();
			this.pnlFavorito.SuspendLayout();
			this.pnlAtivo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(422, 0);
			this.lblTitulo.Size = new System.Drawing.Size(172, 50);
			this.lblTitulo.Text = "Editar Louvor";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(594, 0);
			this.btnClose.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(634, 50);
			// 
			// lblProjecaoPath
			// 
			this.lblProjecaoPath.BackColor = System.Drawing.SystemColors.Control;
			this.lblProjecaoPath.Font = new System.Drawing.Font("Pathway Gothic One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProjecaoPath.Location = new System.Drawing.Point(12, 85);
			this.lblProjecaoPath.Name = "lblProjecaoPath";
			this.lblProjecaoPath.Size = new System.Drawing.Size(611, 28);
			this.lblProjecaoPath.TabIndex = 8;
			this.lblProjecaoPath.Text = "c:\\Usuarios\\Documentos\\Projetor\\";
			this.lblProjecaoPath.TextChanged += new System.EventHandler(this.lblProjecaoPath_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Localização do Arquivo:";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitulo.Location = new System.Drawing.Point(16, 152);
			this.txtTitulo.MaxLength = 100;
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(597, 31);
			this.txtTitulo.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Título / Nome do Louvor:";
			// 
			// cmbIDCategoria
			// 
			this.cmbIDCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIDCategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbIDCategoria.FormattingEnabled = true;
			this.cmbIDCategoria.Location = new System.Drawing.Point(16, 222);
			this.cmbIDCategoria.Name = "cmbIDCategoria";
			this.cmbIDCategoria.Size = new System.Drawing.Size(319, 31);
			this.cmbIDCategoria.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Categoria do Louvor:";
			// 
			// btnAtivo
			// 
			this.btnAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAtivo.FlatAppearance.BorderSize = 0;
			this.btnAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtivo.Image = global::CamadaUI.Properties.Resources.Switch_ON_PEQ;
			this.btnAtivo.Location = new System.Drawing.Point(29, 3);
			this.btnAtivo.Name = "btnAtivo";
			this.btnAtivo.Size = new System.Drawing.Size(174, 43);
			this.btnAtivo.TabIndex = 12;
			this.btnAtivo.Text = "Louvor Ativo";
			this.btnAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAtivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAtivo.UseVisualStyleBackColor = true;
			this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
			// 
			// pctFav1
			// 
			this.pctFav1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctFav1.Image = global::CamadaUI.Properties.Resources.favorite_64;
			this.pctFav1.Location = new System.Drawing.Point(6, 25);
			this.pctFav1.Name = "pctFav1";
			this.pctFav1.Size = new System.Drawing.Size(44, 40);
			this.pctFav1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctFav1.TabIndex = 13;
			this.pctFav1.TabStop = false;
			this.pctFav1.Tag = "1";
			this.pctFav1.Click += new System.EventHandler(this.picFav_Click);
			// 
			// pctFav2
			// 
			this.pctFav2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctFav2.Image = global::CamadaUI.Properties.Resources.favorite_64;
			this.pctFav2.Location = new System.Drawing.Point(50, 25);
			this.pctFav2.Name = "pctFav2";
			this.pctFav2.Size = new System.Drawing.Size(44, 40);
			this.pctFav2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctFav2.TabIndex = 13;
			this.pctFav2.TabStop = false;
			this.pctFav2.Tag = "2";
			this.pctFav2.Click += new System.EventHandler(this.picFav_Click);
			// 
			// pctFav3
			// 
			this.pctFav3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctFav3.Image = global::CamadaUI.Properties.Resources.favorite_64;
			this.pctFav3.Location = new System.Drawing.Point(94, 25);
			this.pctFav3.Name = "pctFav3";
			this.pctFav3.Size = new System.Drawing.Size(44, 40);
			this.pctFav3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctFav3.TabIndex = 13;
			this.pctFav3.TabStop = false;
			this.pctFav3.Tag = "3";
			this.pctFav3.Click += new System.EventHandler(this.picFav_Click);
			// 
			// pctFav4
			// 
			this.pctFav4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctFav4.Image = global::CamadaUI.Properties.Resources.favorite_64_disable;
			this.pctFav4.Location = new System.Drawing.Point(138, 25);
			this.pctFav4.Name = "pctFav4";
			this.pctFav4.Size = new System.Drawing.Size(44, 40);
			this.pctFav4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctFav4.TabIndex = 13;
			this.pctFav4.TabStop = false;
			this.pctFav4.Tag = "4";
			this.pctFav4.Click += new System.EventHandler(this.picFav_Click);
			// 
			// pctFav5
			// 
			this.pctFav5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pctFav5.Image = global::CamadaUI.Properties.Resources.favorite_64_disable;
			this.pctFav5.Location = new System.Drawing.Point(182, 25);
			this.pctFav5.Name = "pctFav5";
			this.pctFav5.Size = new System.Drawing.Size(44, 40);
			this.pctFav5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctFav5.TabIndex = 13;
			this.pctFav5.TabStop = false;
			this.pctFav5.Tag = "5";
			this.pctFav5.Click += new System.EventHandler(this.picFav_Click);
			// 
			// pnlFavorito
			// 
			this.pnlFavorito.BackColor = System.Drawing.Color.Linen;
			this.pnlFavorito.Controls.Add(this.pctFav1);
			this.pnlFavorito.Controls.Add(this.pctFav5);
			this.pnlFavorito.Controls.Add(this.pctFav2);
			this.pnlFavorito.Controls.Add(this.pctFav4);
			this.pnlFavorito.Controls.Add(this.pctFav3);
			this.pnlFavorito.Controls.Add(this.label4);
			this.pnlFavorito.Location = new System.Drawing.Point(380, 201);
			this.pnlFavorito.Name = "pnlFavorito";
			this.pnlFavorito.Size = new System.Drawing.Size(233, 70);
			this.pnlFavorito.TabIndex = 14;
			this.pnlFavorito.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFavorito_Paint);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "Favorito:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 277);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Quantas vezes foi escolhido:";
			// 
			// lblEscolhidoCount
			// 
			this.lblEscolhidoCount.BackColor = System.Drawing.SystemColors.Control;
			this.lblEscolhidoCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEscolhidoCount.Location = new System.Drawing.Point(12, 299);
			this.lblEscolhidoCount.Name = "lblEscolhidoCount";
			this.lblEscolhidoCount.Size = new System.Drawing.Size(185, 28);
			this.lblEscolhidoCount.TabIndex = 8;
			this.lblEscolhidoCount.Text = "10 Vezes";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalvar.Enabled = false;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Image = global::CamadaUI.Properties.Resources.salvar_24;
			this.btnSalvar.Location = new System.Drawing.Point(139, 353);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(158, 45);
			this.btnSalvar.TabIndex = 15;
			this.btnSalvar.Text = "&Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Image = global::CamadaUI.Properties.Resources.cancelar_24;
			this.btnCancelar.Location = new System.Drawing.Point(303, 353);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(158, 45);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// pnlAtivo
			// 
			this.pnlAtivo.BackColor = System.Drawing.Color.Linen;
			this.pnlAtivo.Controls.Add(this.btnAtivo);
			this.pnlAtivo.Location = new System.Drawing.Point(380, 279);
			this.pnlAtivo.Name = "pnlAtivo";
			this.pnlAtivo.Size = new System.Drawing.Size(233, 49);
			this.pnlAtivo.TabIndex = 16;
			this.pnlAtivo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFavorito_Paint);
			// 
			// frmLouvorEditar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(634, 412);
			this.Controls.Add(this.pnlAtivo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.pnlFavorito);
			this.Controls.Add(this.cmbIDCategoria);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.lblEscolhidoCount);
			this.Controls.Add(this.lblProjecaoPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Name = "frmLouvorEditar";
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.lblProjecaoPath, 0);
			this.Controls.SetChildIndex(this.lblEscolhidoCount, 0);
			this.Controls.SetChildIndex(this.txtTitulo, 0);
			this.Controls.SetChildIndex(this.cmbIDCategoria, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.pnlFavorito, 0);
			this.Controls.SetChildIndex(this.btnSalvar, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.Controls.SetChildIndex(this.pnlAtivo, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctFav1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctFav5)).EndInit();
			this.pnlFavorito.ResumeLayout(false);
			this.pnlFavorito.PerformLayout();
			this.pnlAtivo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProjecaoPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbIDCategoria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAtivo;
		private System.Windows.Forms.PictureBox pctFav1;
		private System.Windows.Forms.PictureBox pctFav2;
		private System.Windows.Forms.PictureBox pctFav3;
		private System.Windows.Forms.PictureBox pctFav4;
		private System.Windows.Forms.PictureBox pctFav5;
		private System.Windows.Forms.Panel pnlFavorito;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblEscolhidoCount;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel pnlAtivo;
	}
}
