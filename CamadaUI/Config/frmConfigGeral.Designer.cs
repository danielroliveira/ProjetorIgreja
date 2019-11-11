﻿namespace CamadaUI.Config
{
	partial class frmConfigGeral
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
			this.btnInserirFolder = new System.Windows.Forms.Button();
			this.btnRemoverFolder = new System.Windows.Forms.Button();
			this.pnlPastas = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLimparHistoricoLeitura = new System.Windows.Forms.Button();
			this.btnLimparHistoricoHinos = new System.Windows.Forms.Button();
			this.btnLimparHistoricoLouvor = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.pnlPastas.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.SlateGray;
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 4);
			this.lblTitulo.Size = new System.Drawing.Size(704, 30);
			this.lblTitulo.Text = "Configuração Geral";
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
			// btnInserirFolder
			// 
			this.btnInserirFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInserirFolder.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnInserirFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnInserirFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnInserirFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInserirFolder.Image = global::CamadaUI.Properties.Resources.add_24x24;
			this.btnInserirFolder.Location = new System.Drawing.Point(484, 531);
			this.btnInserirFolder.Name = "btnInserirFolder";
			this.btnInserirFolder.Size = new System.Drawing.Size(121, 36);
			this.btnInserirFolder.TabIndex = 3;
			this.btnInserirFolder.Text = "Inserir";
			this.btnInserirFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInserirFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserirFolder.UseVisualStyleBackColor = true;
			// 
			// btnRemoverFolder
			// 
			this.btnRemoverFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemoverFolder.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnRemoverFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnRemoverFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnRemoverFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoverFolder.Image = global::CamadaUI.Properties.Resources.delete_24px;
			this.btnRemoverFolder.Location = new System.Drawing.Point(611, 531);
			this.btnRemoverFolder.Name = "btnRemoverFolder";
			this.btnRemoverFolder.Size = new System.Drawing.Size(121, 36);
			this.btnRemoverFolder.TabIndex = 3;
			this.btnRemoverFolder.Text = "Remover";
			this.btnRemoverFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemoverFolder.UseVisualStyleBackColor = true;
			// 
			// pnlPastas
			// 
			this.pnlPastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.pnlPastas.Controls.Add(this.label1);
			this.pnlPastas.Controls.Add(this.btnLimparHistoricoLeitura);
			this.pnlPastas.Controls.Add(this.btnLimparHistoricoHinos);
			this.pnlPastas.Controls.Add(this.btnLimparHistoricoLouvor);
			this.pnlPastas.Location = new System.Drawing.Point(12, 45);
			this.pnlPastas.Name = "pnlPastas";
			this.pnlPastas.Size = new System.Drawing.Size(285, 181);
			this.pnlPastas.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(93, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Históricos:";
			// 
			// btnLimparHistoricoLeitura
			// 
			this.btnLimparHistoricoLeitura.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLimparHistoricoLeitura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnLimparHistoricoLeitura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnLimparHistoricoLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparHistoricoLeitura.Image = global::CamadaUI.Properties.Resources.delete_page_24px;
			this.btnLimparHistoricoLeitura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLimparHistoricoLeitura.Location = new System.Drawing.Point(18, 128);
			this.btnLimparHistoricoLeitura.Name = "btnLimparHistoricoLeitura";
			this.btnLimparHistoricoLeitura.Size = new System.Drawing.Size(245, 36);
			this.btnLimparHistoricoLeitura.TabIndex = 3;
			this.btnLimparHistoricoLeitura.Text = "&Limpar Histórico de Leitura";
			this.btnLimparHistoricoLeitura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimparHistoricoLeitura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimparHistoricoLeitura.UseVisualStyleBackColor = true;
			this.btnLimparHistoricoLeitura.Click += new System.EventHandler(this.btnLimparHistoricoLeitura_Click);
			// 
			// btnLimparHistoricoHinos
			// 
			this.btnLimparHistoricoHinos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLimparHistoricoHinos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnLimparHistoricoHinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnLimparHistoricoHinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparHistoricoHinos.Image = global::CamadaUI.Properties.Resources.delete_page_24px;
			this.btnLimparHistoricoHinos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLimparHistoricoHinos.Location = new System.Drawing.Point(18, 86);
			this.btnLimparHistoricoHinos.Name = "btnLimparHistoricoHinos";
			this.btnLimparHistoricoHinos.Size = new System.Drawing.Size(245, 36);
			this.btnLimparHistoricoHinos.TabIndex = 3;
			this.btnLimparHistoricoHinos.Text = "&Limpar Histórico de Hinos";
			this.btnLimparHistoricoHinos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimparHistoricoHinos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimparHistoricoHinos.UseVisualStyleBackColor = true;
			this.btnLimparHistoricoHinos.Click += new System.EventHandler(this.btnLimparHistoricoHinos_Click);
			// 
			// btnLimparHistoricoLouvor
			// 
			this.btnLimparHistoricoLouvor.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLimparHistoricoLouvor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnLimparHistoricoLouvor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnLimparHistoricoLouvor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparHistoricoLouvor.Image = global::CamadaUI.Properties.Resources.delete_page_24px;
			this.btnLimparHistoricoLouvor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnLimparHistoricoLouvor.Location = new System.Drawing.Point(18, 44);
			this.btnLimparHistoricoLouvor.Name = "btnLimparHistoricoLouvor";
			this.btnLimparHistoricoLouvor.Size = new System.Drawing.Size(245, 36);
			this.btnLimparHistoricoLouvor.TabIndex = 3;
			this.btnLimparHistoricoLouvor.Text = "&Limpar Histórico de Louvor";
			this.btnLimparHistoricoLouvor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimparHistoricoLouvor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimparHistoricoLouvor.UseVisualStyleBackColor = true;
			this.btnLimparHistoricoLouvor.Click += new System.EventHandler(this.btnLimparHistoricoLouvor_Click);
			// 
			// frmConfigGeral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.pnlPastas);
			this.Controls.Add(this.btnRemoverFolder);
			this.Controls.Add(this.btnInserirFolder);
			this.Name = "frmConfigGeral";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnInserirFolder, 0);
			this.Controls.SetChildIndex(this.btnRemoverFolder, 0);
			this.Controls.SetChildIndex(this.pnlPastas, 0);
			this.panel1.ResumeLayout(false);
			this.pnlPastas.ResumeLayout(false);
			this.pnlPastas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnInserirFolder;
		private System.Windows.Forms.Button btnRemoverFolder;
		private System.Windows.Forms.Panel pnlPastas;
		private System.Windows.Forms.Button btnLimparHistoricoLouvor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLimparHistoricoLeitura;
		private System.Windows.Forms.Button btnLimparHistoricoHinos;
	}
}
