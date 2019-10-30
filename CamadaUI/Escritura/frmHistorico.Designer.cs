﻿namespace CamadaUI.Escritura
{
	partial class frmHistorico
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvListagem = new CamadaUI.Controls.ctrlDataGridView();
			this.clnReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnEscritura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(150, 0);
			this.lblTitulo.Size = new System.Drawing.Size(259, 32);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Histórico de Leitura";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(409, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 32);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Size = new System.Drawing.Size(449, 32);
			// 
			// dgvListagem
			// 
			this.dgvListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListagem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListagem.ColumnHeadersVisible = false;
			this.dgvListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnReferencia,
            this.clnEscritura});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListagem.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.Location = new System.Drawing.Point(12, 46);
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.Size = new System.Drawing.Size(425, 434);
			this.dgvListagem.TabIndex = 1;
			this.dgvListagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagem_CellClick);
			this.dgvListagem.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagem_CellMouseEnter);
			this.dgvListagem.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagem_CellMouseLeave);
			this.dgvListagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListagem_KeyDown);
			// 
			// clnReferencia
			// 
			this.clnReferencia.HeaderText = "Referência";
			this.clnReferencia.Name = "clnReferencia";
			// 
			// clnEscritura
			// 
			this.clnEscritura.HeaderText = "Texto";
			this.clnEscritura.Name = "clnEscritura";
			this.clnEscritura.Width = 290;
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.Fechar_24x24;
			this.btnFechar.Location = new System.Drawing.Point(271, 486);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(166, 35);
			this.btnFechar.TabIndex = 3;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Visible = false;
			this.btnFechar.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
			this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Image = global::CamadaUI.Properties.Resources.delete_page_24px;
			this.btnLimpar.Location = new System.Drawing.Point(12, 486);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(166, 35);
			this.btnLimpar.TabIndex = 2;
			this.btnLimpar.Text = "&Limpar Histórico";
			this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Visible = false;
			// 
			// frmHistorico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(449, 529);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.dgvListagem);
			this.KeyPreview = true;
			this.Name = "frmHistorico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Load += new System.EventHandler(this.frmHistorico_Load);
			this.Shown += new System.EventHandler(this.frmHistorico_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmHistorico_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHistorico_KeyDown);
			this.Resize += new System.EventHandler(this.frmHistorico_Resize);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.btnLimpar, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CamadaUI.Controls.ctrlDataGridView dgvListagem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnReferencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnEscritura;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnLimpar;
	}
}