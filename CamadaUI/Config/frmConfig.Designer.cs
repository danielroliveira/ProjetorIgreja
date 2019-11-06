namespace CamadaUI.Config
{
	partial class frmConfig
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
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.line1 = new AwesomeShapeControl.Line();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAvisos = new System.Windows.Forms.Button();
			this.btnLeitura = new System.Windows.Forms.Button();
			this.btnGeral = new System.Windows.Forms.Button();
			this.btnHarpa = new System.Windows.Forms.Button();
			this.btnLouvores = new System.Windows.Forms.Button();
			this.pnlCorpo = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.pnlMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Text = "Configuração do Sistema";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Goldenrod;
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.pnlMenu.Controls.Add(this.line1);
			this.pnlMenu.Controls.Add(this.label1);
			this.pnlMenu.Controls.Add(this.btnAvisos);
			this.pnlMenu.Controls.Add(this.btnLeitura);
			this.pnlMenu.Controls.Add(this.btnGeral);
			this.pnlMenu.Controls.Add(this.btnHarpa);
			this.pnlMenu.Controls.Add(this.btnLouvores);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMenu.Location = new System.Drawing.Point(0, 50);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(200, 579);
			this.pnlMenu.TabIndex = 1;
			// 
			// line1
			// 
			this.line1.EndPoint = new System.Drawing.Point(166, 5);
			this.line1.LineColor = System.Drawing.Color.DarkGray;
			this.line1.LineWidth = 3F;
			this.line1.Location = new System.Drawing.Point(14, 44);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(171, 10);
			this.line1.StartPoint = new System.Drawing.Point(5, 5);
			this.line1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkGray;
			this.label1.Location = new System.Drawing.Point(64, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU";
			// 
			// btnAvisos
			// 
			this.btnAvisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnAvisos.FlatAppearance.BorderSize = 0;
			this.btnAvisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnAvisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnAvisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAvisos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAvisos.ForeColor = System.Drawing.Color.White;
			this.btnAvisos.Location = new System.Drawing.Point(1, 306);
			this.btnAvisos.Name = "btnAvisos";
			this.btnAvisos.Size = new System.Drawing.Size(198, 55);
			this.btnAvisos.TabIndex = 0;
			this.btnAvisos.Text = "Avisos";
			this.btnAvisos.UseVisualStyleBackColor = false;
			this.btnAvisos.Click += new System.EventHandler(this.btnAvisos_Click);
			// 
			// btnLeitura
			// 
			this.btnLeitura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnLeitura.FlatAppearance.BorderSize = 0;
			this.btnLeitura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnLeitura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLeitura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLeitura.ForeColor = System.Drawing.Color.White;
			this.btnLeitura.Location = new System.Drawing.Point(1, 245);
			this.btnLeitura.Name = "btnLeitura";
			this.btnLeitura.Size = new System.Drawing.Size(198, 55);
			this.btnLeitura.TabIndex = 0;
			this.btnLeitura.Text = "Leitura Bíblica";
			this.btnLeitura.UseVisualStyleBackColor = false;
			this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
			// 
			// btnGeral
			// 
			this.btnGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnGeral.FlatAppearance.BorderSize = 0;
			this.btnGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGeral.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGeral.ForeColor = System.Drawing.Color.White;
			this.btnGeral.Location = new System.Drawing.Point(1, 62);
			this.btnGeral.Name = "btnGeral";
			this.btnGeral.Size = new System.Drawing.Size(198, 55);
			this.btnGeral.TabIndex = 0;
			this.btnGeral.Text = "Geral";
			this.btnGeral.UseVisualStyleBackColor = false;
			this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
			// 
			// btnHarpa
			// 
			this.btnHarpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnHarpa.FlatAppearance.BorderSize = 0;
			this.btnHarpa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnHarpa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnHarpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHarpa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHarpa.ForeColor = System.Drawing.Color.White;
			this.btnHarpa.Location = new System.Drawing.Point(1, 184);
			this.btnHarpa.Name = "btnHarpa";
			this.btnHarpa.Size = new System.Drawing.Size(198, 55);
			this.btnHarpa.TabIndex = 0;
			this.btnHarpa.Text = "Hinos da Harpa";
			this.btnHarpa.UseVisualStyleBackColor = false;
			this.btnHarpa.Click += new System.EventHandler(this.btnHarpa_Click);
			// 
			// btnLouvores
			// 
			this.btnLouvores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnLouvores.FlatAppearance.BorderSize = 0;
			this.btnLouvores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnLouvores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnLouvores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLouvores.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLouvores.ForeColor = System.Drawing.Color.White;
			this.btnLouvores.Location = new System.Drawing.Point(1, 123);
			this.btnLouvores.Name = "btnLouvores";
			this.btnLouvores.Size = new System.Drawing.Size(198, 55);
			this.btnLouvores.TabIndex = 0;
			this.btnLouvores.Text = "Louvores";
			this.btnLouvores.UseVisualStyleBackColor = false;
			this.btnLouvores.Click += new System.EventHandler(this.btnLouvores_Click);
			// 
			// pnlCorpo
			// 
			this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCorpo.Location = new System.Drawing.Point(200, 50);
			this.pnlCorpo.Name = "pnlCorpo";
			this.pnlCorpo.Size = new System.Drawing.Size(744, 579);
			this.pnlCorpo.TabIndex = 2;
			// 
			// frmConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(944, 629);
			this.Controls.Add(this.pnlCorpo);
			this.Controls.Add(this.pnlMenu);
			this.Name = "frmConfig";
			this.TopMost = true;
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.pnlMenu, 0);
			this.Controls.SetChildIndex(this.pnlCorpo, 0);
			this.panel1.ResumeLayout(false);
			this.pnlMenu.ResumeLayout(false);
			this.pnlMenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Button btnLouvores;
		private System.Windows.Forms.Panel pnlCorpo;
		private System.Windows.Forms.Label label1;
		private AwesomeShapeControl.Line line1;
		private System.Windows.Forms.Button btnLeitura;
		private System.Windows.Forms.Button btnGeral;
		private System.Windows.Forms.Button btnHarpa;
		private System.Windows.Forms.Button btnAvisos;
	}
}
