using System.Windows.Forms;

namespace CamadaUI.Controls
{
	public partial class ctrlDataGridView : DataGridView
	{
		public ctrlDataGridView()
		{
			InitializeComponent();
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			Keys key = keyData & Keys.KeyCode;

			if (key == Keys.Enter)
			{
				base.OnKeyDown(new KeyEventArgs(keyData));
				return true;
			}
			else
				return base.ProcessDialogKey(keyData);
		}


	}
}
