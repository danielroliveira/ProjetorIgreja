namespace CamadaUI.Louvor
{
	partial class frmLouvorHistorico
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvListagem = new CamadaUI.Controls.ctrlDataGridView();
			this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnDataRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFechar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(269, 0);
			this.lblTitulo.Size = new System.Drawing.Size(191, 32);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Histórico de Louvores";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(460, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 32);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Size = new System.Drawing.Size(500, 32);
			// 
			// dgvListagem
			// 
			this.dgvListagem.AllowUserToAddRows = false;
			this.dgvListagem.AllowUserToDeleteRows = false;
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
            this.clnID,
            this.clnTitulo,
            this.clnDataRef});
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
			this.dgvListagem.ReadOnly = true;
			this.dgvListagem.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvListagem.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.Size = new System.Drawing.Size(476, 434);
			this.dgvListagem.TabIndex = 1;
			this.dgvListagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagem_CellClick);
			this.dgvListagem.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagem_CellMouseEnter);
			this.dgvListagem.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagem_CellMouseLeave);
			this.dgvListagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListagem_KeyDown);
			// 
			// clnID
			// 
			this.clnID.HeaderText = "Numero";
			this.clnID.Name = "clnID";
			this.clnID.ReadOnly = true;
			this.clnID.Visible = false;
			this.clnID.Width = 70;
			// 
			// clnTitulo
			// 
			this.clnTitulo.HeaderText = "Titulo";
			this.clnTitulo.Name = "clnTitulo";
			this.clnTitulo.ReadOnly = true;
			this.clnTitulo.Width = 320;
			// 
			// clnDataRef
			// 
			this.clnDataRef.HeaderText = "Quando";
			this.clnDataRef.Name = "clnDataRef";
			this.clnDataRef.ReadOnly = true;
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.Fechar_24x24;
			this.btnFechar.Location = new System.Drawing.Point(322, 486);
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
			// frmLouvorHistorico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(500, 529);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.dgvListagem);
			this.KeyPreview = true;
			this.Name = "frmLouvorHistorico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Load += new System.EventHandler(this.frmLouvorHistorico_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLouvorHistorico_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLouvorHistorico_KeyDown);
			this.Resize += new System.EventHandler(this.frmLouvorHistorico_Resize);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CamadaUI.Controls.ctrlDataGridView dgvListagem;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnDataRef;
	}
}
