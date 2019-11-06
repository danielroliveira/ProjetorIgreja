namespace CamadaUI.Config
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
			this.panel1.SuspendLayout();
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
			// 
			// frmConfigGeral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.btnRemoverFolder);
			this.Controls.Add(this.btnInserirFolder);
			this.Name = "frmConfigGeral";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnInserirFolder, 0);
			this.Controls.SetChildIndex(this.btnRemoverFolder, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnInserirFolder;
		private System.Windows.Forms.Button btnRemoverFolder;
	}
}
