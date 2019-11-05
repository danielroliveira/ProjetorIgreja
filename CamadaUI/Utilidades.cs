using System.Windows.Forms;

namespace CamadaUI
{
	public enum DialogType { SIM_NAO, OK, OK_CANCELAR, SIM_NAO_CANCELAR }
	public enum DialogIcon { Question, Information, Exclamation, Warning }
	public enum DialogDefaultButton { First, Second, Third }

	static class Utilidades
	{
		public static DialogResult AbrirDialog
			(string Message,
			string Title,
			DialogType Type = DialogType.OK,
			DialogIcon Icon = DialogIcon.Information,
			DialogDefaultButton DefaultButton = DialogDefaultButton.First)
		{
			using (frmMessage f = new frmMessage(Message, Title, Type, Icon, DefaultButton))
			{
				f.ShowDialog();
				return f.DialogResult;
			}
		}

		// VERIFY IS STRING CAN CHANGE TO NUMERIC
		public static bool IsNumeric(this string text) => double.TryParse(text, out _);

	}

}
