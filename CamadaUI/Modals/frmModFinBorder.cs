
using System.Drawing;
using System.Windows.Forms;

namespace CamadaUI.Modals
{
	public partial class frmModFinBorder : Form
	{
		int Px;
		int Py;
		bool mover;

		public frmModFinBorder()
		{
			InitializeComponent();
			Handler_MouseMove();
			Handler_MouseUp();
			Handler_MouseDown();
		}

		// CONSTRUIR UMA BORDA NO FORMULÁRIO
		//-------------------------------------------------------------------------------------------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			Rectangle rect = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
			Pen pen = new Pen(Color.SlateGray, 3);

			e.Graphics.DrawRectangle(pen, rect);
		}


		// MOVER O FORMULÁRIO SEM BORDA
		//-------------------------------------------------------------------------------------------------
		private void Painel_MouseDown(object sender, MouseEventArgs e)
		{
			Px = Cursor.Position.X - Left;

			if (this.IsMdiChild)
				Py = Cursor.Position.Y - Top + Screen.PrimaryScreen.WorkingArea.Height - Parent.ClientSize.Height + 3;
			else
				frmPrincipal f = Application.OpenForms[0];
				Py = Cursor.Position.Y - Top + Screen.PrimaryScreen.WorkingArea.Height - frmPrincipal.ClientSize.Height + panel1.Height - 10;

			mover = true;
		}

		private void Painel_MouseUp(object sender, MouseEventArgs e)
		{
			mover = false;
		}

		private void Painel_MouseMove(object sender, MouseEventArgs e)
		{
			Control c = (Control)sender;

			if (mover == true)
				Location = PointToScreen(new Point(MousePosition.X - Location.X - Px, MousePosition.Y - Location.Y - Py));
		}


		// HANDLERS ADICONA MOVE NOS CONTROLES DO PAINEL
		//-------------------------------------------------------------------------------------------------
		internal void Handler_MouseMove()
		{
			// adiciona o Handler no Painel
			panel1.MouseMove += Painel_MouseMove;
			// adiciona o Handler em todos os controles do painel
			foreach (Control c in panel1.Controls)
				c.MouseMove += Painel_MouseMove;
		}

		internal void Handler_MouseUp()
		{
			// --- adiciona o Handler no Painel
			panel1.MouseUp += Painel_MouseUp;
			// -- adiciona o Handler em todos os controles do painel
			foreach (Control c in panel1.Controls)
				c.MouseUp += Painel_MouseUp;
		}

		internal void Handler_MouseDown()
		{
			// --- adiciona o Handler no Painel
			panel1.MouseDown += Painel_MouseDown;
			// -- adiciona o Handler em todos os controles do painel
			foreach (Control c in panel1.Controls)
				c.MouseDown += Painel_MouseDown;
		}
	}
}
