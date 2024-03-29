﻿namespace CamadaUI
{
    partial class frmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.mnuPrincipal = new System.Windows.Forms.ToolStrip();
			this.btnSair = new System.Windows.Forms.ToolStripButton();
			this.btnBiblia = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnLouvores = new System.Windows.Forms.ToolStripButton();
			this.btnHarpa = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimizer = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.mnuPrincipal.SuspendLayout();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuPrincipal
			// 
			this.mnuPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mnuPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.btnBiblia,
            this.toolStripSeparator1,
            this.btnLouvores,
            this.btnHarpa,
            this.toolStripSplitButton1});
			this.mnuPrincipal.Location = new System.Drawing.Point(0, 40);
			this.mnuPrincipal.Name = "mnuPrincipal";
			this.mnuPrincipal.Size = new System.Drawing.Size(1110, 56);
			this.mnuPrincipal.TabIndex = 0;
			this.mnuPrincipal.Text = "toolStrip1";
			// 
			// btnSair
			// 
			this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnSair.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Image = global::CamadaUI.Properties.Resources.sair_32;
			this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSair.Margin = new System.Windows.Forms.Padding(5);
			this.btnSair.Name = "btnSair";
			this.btnSair.Padding = new System.Windows.Forms.Padding(5);
			this.btnSair.Size = new System.Drawing.Size(85, 46);
			this.btnSair.Text = "&Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.ToolTipText = "Sair do Aplicativo";
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnBiblia
			// 
			this.btnBiblia.Image = global::CamadaUI.Properties.Resources.biblia_32;
			this.btnBiblia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnBiblia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBiblia.Margin = new System.Windows.Forms.Padding(5);
			this.btnBiblia.Name = "btnBiblia";
			this.btnBiblia.Padding = new System.Windows.Forms.Padding(5);
			this.btnBiblia.Size = new System.Drawing.Size(229, 46);
			this.btnBiblia.Text = "Leitura Bíblica";
			this.btnBiblia.Click += new System.EventHandler(this.btnBiblia_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
			// 
			// btnLouvores
			// 
			this.btnLouvores.Image = global::CamadaUI.Properties.Resources.NotasColor_32;
			this.btnLouvores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnLouvores.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLouvores.Margin = new System.Windows.Forms.Padding(5);
			this.btnLouvores.Name = "btnLouvores";
			this.btnLouvores.Padding = new System.Windows.Forms.Padding(5);
			this.btnLouvores.Size = new System.Drawing.Size(127, 46);
			this.btnLouvores.Text = "Louvores";
			this.btnLouvores.Click += new System.EventHandler(this.btnLouvores_Click);
			// 
			// btnHarpa
			// 
			this.btnHarpa.Image = global::CamadaUI.Properties.Resources.NotasColor_32;
			this.btnHarpa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnHarpa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHarpa.Margin = new System.Windows.Forms.Padding(5);
			this.btnHarpa.Name = "btnHarpa";
			this.btnHarpa.Padding = new System.Windows.Forms.Padding(5);
			this.btnHarpa.Size = new System.Drawing.Size(156, 46);
			this.btnHarpa.Text = "Harpa Cristã";
			this.btnHarpa.Click += new System.EventHandler(this.btnHarpa_Click);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.Image = global::CamadaUI.Properties.Resources.agenda_32;
			this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(117, 53);
			this.toolStripSplitButton1.Text = "Avisos";
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.SlateGray;
			this.pnlTop.Controls.Add(this.lblTitulo);
			this.pnlTop.Controls.Add(this.btnClose);
			this.pnlTop.Controls.Add(this.btnMinimizer);
			this.pnlTop.Controls.Add(this.btnConfig);
			this.pnlTop.Controls.Add(this.mnuPrincipal);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(1110, 96);
			this.pnlTop.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::CamadaUI.Properties.Resources.CloseIcon;
			this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnClose.Location = new System.Drawing.Point(1070, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 11;
			this.btnClose.TabStop = false;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnMinimizer
			// 
			this.btnMinimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizer.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizer.FlatAppearance.BorderSize = 0;
			this.btnMinimizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnMinimizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnMinimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizer.Image = global::CamadaUI.Properties.Resources.DropdownIcon;
			this.btnMinimizer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnMinimizer.Location = new System.Drawing.Point(1030, 0);
			this.btnMinimizer.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimizer.Name = "btnMinimizer";
			this.btnMinimizer.Size = new System.Drawing.Size(40, 40);
			this.btnMinimizer.TabIndex = 11;
			this.btnMinimizer.TabStop = false;
			this.btnMinimizer.UseVisualStyleBackColor = false;
			this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
			// 
			// btnConfig
			// 
			this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfig.BackColor = System.Drawing.Color.Transparent;
			this.btnConfig.FlatAppearance.BorderSize = 0;
			this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
			this.btnConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnConfig.Location = new System.Drawing.Point(990, 0);
			this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(40, 40);
			this.btnConfig.TabIndex = 11;
			this.btnConfig.TabStop = false;
			this.btnConfig.UseVisualStyleBackColor = false;
			this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
			this.lblTitulo.Size = new System.Drawing.Size(167, 32);
			this.lblTitulo.TabIndex = 12;
			this.lblTitulo.Text = "Titulo da Igreja";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1110, 732);
			this.Controls.Add(this.pnlTop);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.mnuPrincipal.ResumeLayout(false);
			this.mnuPrincipal.PerformLayout();
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnBiblia;
        private System.Windows.Forms.ToolStripButton btnLouvores;
        private System.Windows.Forms.ToolStripButton btnHarpa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlTop;
        internal System.Windows.Forms.Button btnConfig;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnMinimizer;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.Label lblTitulo;
	}
}

