using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CamadaUI
{
	public enum DialogType { SIM_NAO, OK, OK_CANCELAR, SIM_NAO_CANCELAR }
	public enum DialogIcon { Question, Information, Exclamation, Warning }
	public enum DialogDefaultButton { First, Second, Third }

	static class Utilidades
	{
		// MESSAGE DIALOG BOX
		// =============================================================================
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
		// =============================================================================
		public static bool IsNumeric(this string text) => double.TryParse(text, out _);

		// RESIZE FONT SIZE LABEL TO FIT ALL TEXT
		// =============================================================================
		public static void ResizeFontLabel(Label myLabel)
		{
			Font lblFont = new Font(myLabel.Font.FontFamily, myLabel.Font.Size, myLabel.Font.Style);

			while (myLabel.Width < TextRenderer.MeasureText(myLabel.Text, lblFont).Width)
			{
				myLabel.Font = new Font(myLabel.Font.FontFamily, myLabel.Font.Size - 0.5F, myLabel.Font.Style);
				lblFont = new Font(myLabel.Font.FontFamily, myLabel.Font.Size, myLabel.Font.Style);
			}
		}
			   
	}

}
