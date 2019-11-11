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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvListagem = new CamadaUI.Controls.ctrlDataGridView();
			this.clnReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnEscritura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFechar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(151, 0);
			this.lblTitulo.Size = new System.Drawing.Size(259, 32);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Histórico de Leitura";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(410, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 32);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Size = new System.Drawing.Size(450, 32);
			// 
			// dgvListagem
			// 
			this.dgvListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListagem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListagem.ColumnHeadersVisible = false;
			this.dgvListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnReferencia,
            this.clnEscritura});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListagem.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.Location = new System.Drawing.Point(12, 46);
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.Size = new System.Drawing.Size(426, 434);
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
			this.btnFechar.Location = new System.Drawing.Point(272, 486);
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
			// frmHistorico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(450, 529);
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
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CamadaUI.Controls.ctrlDataGridView dgvListagem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnReferencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnEscritura;
		private System.Windows.Forms.Button btnFechar;
	}
}
