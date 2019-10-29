namespace CamadaUI.Escritura
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvListagem = new System.Windows.Forms.DataGridView();
			this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnEscritura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(122, 0);
			this.lblTitulo.Size = new System.Drawing.Size(259, 35);
			this.lblTitulo.Text = "Histórico de Leitura";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(381, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 35);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(421, 35);
			// 
			// dgvListagem
			// 
			this.dgvListagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnEndereco,
            this.clnEscritura});
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.Location = new System.Drawing.Point(12, 92);
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.Size = new System.Drawing.Size(397, 353);
			this.dgvListagem.TabIndex = 1;
			// 
			// clnEndereco
			// 
			this.clnEndereco.HeaderText = "Histórico";
			this.clnEndereco.Name = "clnEndereco";
			// 
			// clnEscritura
			// 
			this.clnEscritura.HeaderText = "Texto";
			this.clnEscritura.Name = "clnEscritura";
			this.clnEscritura.Width = 270;
			// 
			// frmHistorico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(421, 499);
			this.Controls.Add(this.dgvListagem);
			this.Name = "frmHistorico";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListagem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnEscritura;
	}
}
