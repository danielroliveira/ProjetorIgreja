
using System.Drawing;
using System.Windows.Forms;

namespace CamadaUI.Modals
{
	public partial class frmModConfig : Form
	{
		int Px;
		int Py;
		bool mover;

		public frmModConfig()
		{
			InitializeComponent();
			//Handler_MouseMove();
			//Handler_MouseUp();
			//Handler_MouseDown();
		}

		// MOVER O FORMULÁRIO SEM BORDA
		//-------------------------------------------------------------------------------------------------
		private void Painel_MouseDown(object sender, MouseEventArgs e)
		{
			Px = Cursor.Position.X - Left;

			if (IsMdiChild)
				Py = Cursor.Position.Y - Top + Screen.PrimaryScreen.WorkingArea.Height - Parent.ClientSize.Height + 3;
			else
			{
				Py = Cursor.Position.Y - Top;
			}

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
