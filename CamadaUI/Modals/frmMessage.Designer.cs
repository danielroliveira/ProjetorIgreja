namespace CamadaUI
{
	partial class frmMessage
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
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.btnNao = new System.Windows.Forms.Button();
			this.btnSim = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblMensagem = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 4);
			this.lblTitulo.Size = new System.Drawing.Size(493, 35);
			this.lblTitulo.Text = "Titulo";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(503, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 35);
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(543, 35);
			// 
			// picLogo
			// 
			this.picLogo.Image = global::CamadaUI.Properties.Resources.icon_warning;
			this.picLogo.InitialImage = null;
			this.picLogo.Location = new System.Drawing.Point(15, 71);
			this.picLogo.Margin = new System.Windows.Forms.Padding(0);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(120, 130);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picLogo.TabIndex = 4;
			this.picLogo.TabStop = false;
			// 
			// btnNao
			// 
			this.btnNao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNao.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
			this.btnNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
			this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNao.Location = new System.Drawing.Point(412, 244);
			this.btnNao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnNao.Name = "btnNao";
			this.btnNao.Size = new System.Drawing.Size(118, 42);
			this.btnNao.TabIndex = 7;
			this.btnNao.Text = "Não";
			// 
			// btnSim
			// 
			this.btnSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
			this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSim.Location = new System.Drawing.Point(284, 244);
			this.btnSim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnSim.Name = "btnSim";
			this.btnSim.Size = new System.Drawing.Size(118, 42);
			this.btnSim.TabIndex = 6;
			this.btnSim.Text = "Sim";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(156, 244);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(118, 42);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblMensagem
			// 
			this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
			this.lblMensagem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.Location = new System.Drawing.Point(152, 43);
			this.lblMensagem.Margin = new System.Windows.Forms.Padding(0);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(378, 188);
			this.lblMensagem.TabIndex = 8;
			this.lblMensagem.Text = "Mensagem";
			this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 299);
			this.Controls.Add(this.btnNao);
			this.Controls.Add(this.btnSim);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.lblMensagem);
			this.Name = "frmMessage";
			this.Text = "frmMessage";
			this.Shown += new System.EventHandler(this.frmMessage_Shown);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lblMensagem, 0);
			this.Controls.SetChildIndex(this.picLogo, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(this.btnSim, 0);
			this.Controls.SetChildIndex(this.btnNao, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.PictureBox picLogo;
		internal System.Windows.Forms.Button btnNao;
		internal System.Windows.Forms.Button btnSim;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Label lblMensagem;
	}
}