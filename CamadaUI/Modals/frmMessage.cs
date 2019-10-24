using System;
using System.Drawing;
using System.Windows.Forms;
using CamadaUI.Properties;
using static CamadaUI.Modals.frmMessage;

namespace CamadaUI.Modals
{
	public partial class frmMessage : frmModFinBorder
	{
		public enum DialogType	{ SIM_NAO, OK, OK_CANCELAR, SIM_NAO_CANCELAR }
		public enum DialogIcon { Question, Information, Exclamation, Warning }
		public enum DialogDefaultButton { First, Second, Third }

		private DialogType _dialogType;
		private DialogIcon _icon;
		private DialogDefaultButton _defaultButton = DialogDefaultButton.First;

		public frmMessage(
			string Mensagem, 
			string Titulo, 
			DialogType dialogType,
			DialogIcon Icon,
			DialogDefaultButton defaultButton = DialogDefaultButton.First)
		{
			InitializeComponent();

			// --- DEFINE FONT SIZE OS MESSAGE
			if (Mensagem.Length >= 180 && Mensagem.Length < 240)
				lblMensagem.Font = new Font("Calibri", 12.5F, FontStyle.Regular, GraphicsUnit.Point, Convert.ToByte(0));
			else if (Mensagem.Length >= 240)
				lblMensagem.Font = new Font("Calibri", 11.5F, FontStyle.Regular, GraphicsUnit.Point, Convert.ToByte(0));
			 
			lblTitulo.Text = Titulo;
			lblMensagem.Text = Mensagem;
			
			propIcon = Icon;
			propDialogType = dialogType;
			
			// --- Define Default Button
			if (defaultButton != DialogDefaultButton.First)
				_defaultButton = defaultButton;
		}

		// ON SHOW
		private void frmMessage_Shown(object sender, EventArgs e)
		{
			if (_defaultButton == DialogDefaultButton.First) {
				btnSim.Focus();
			}
			else if(_defaultButton == DialogDefaultButton.Second)
			{
				if(btnNao.Visible) btnNao.Focus();
			}
			else if (_defaultButton == DialogDefaultButton.Third)
			{
				if(btnCancel.Visible) btnCancel.Focus();
			}
		}

		public DialogType propDialogType
		{
			get => _dialogType;
			set
			{
				_dialogType = value;

				switch (_dialogType)
				{
					case DialogType.SIM_NAO:
						btnCancel.Visible = false;
						btnSim.Text = "Sim";
						btnSim.DialogResult = DialogResult.Yes;
						btnNao.Text = "Não";
						btnNao.DialogResult = DialogResult.No;
						break;
					case DialogType.OK:
						btnCancel.Visible = false;
						btnNao.Visible = false;
						btnSim.Text = "OK";
						btnSim.DialogResult = DialogResult.OK;
						break;
					case DialogType.OK_CANCELAR:
						btnCancel.Visible = false;
						btnSim.Text = "OK";
						btnSim.DialogResult = DialogResult.OK;
						btnNao.Text = "Cancelar";
						btnNao.DialogResult = DialogResult.Cancel;
						break;
					case DialogType.SIM_NAO_CANCELAR:
						btnCancel.Visible = true;
						btnSim.Text = "Sim";
						btnSim.DialogResult = DialogResult.Yes;
						btnNao.Text = "Não";
						btnNao.DialogResult = DialogResult.No;
						btnCancel.Text = "Cancelar";
						btnCancel.DialogResult = DialogResult.Cancel;
						break;
					default:
						btnCancel.Visible = false;
						btnNao.Visible = false;
						btnSim.Text = "OK";
						btnSim.DialogResult = DialogResult.OK;
						break;
				}
			}
		}

		public DialogIcon propIcon
		{
			get => _icon;
			set
			{
				_icon = value;

				switch (_icon)
				{
					case DialogIcon.Question:
						picLogo.Image = Resources.icon_question;
						panel1.BackColor = Color.FromArgb(0, 56, 140);
						break;
					case DialogIcon.Information:
						picLogo.Image = Resources.icon_information;
						panel1.BackColor = Color.FromArgb(23, 128, 34);
						break;
					case DialogIcon.Exclamation:
						picLogo.Image = Resources.icon_exclamation;
						panel1.BackColor = Color.FromArgb(245, 121, 0);
						break;
					case DialogIcon.Warning:
						picLogo.Image = Resources.icon_warning;
						panel1.BackColor = Color.FromArgb(164, 21, 21);
						break;
					default:
						picLogo.Image = Resources.icon_information;
						panel1.BackColor = Color.FromArgb(23, 128, 34);
						break;
				}
			}
		}

		// ON CLOSE
		private void btnClose_Click(object sender, EventArgs e)
		{
			switch (_dialogType)
			{
				case DialogType.SIM_NAO:
					DialogResult = DialogResult.No;
					break;
				case DialogType.OK:
					DialogResult = DialogResult.OK;
					break;
				case DialogType.OK_CANCELAR:
					DialogResult = DialogResult.Cancel;
					break;
				case DialogType.SIM_NAO_CANCELAR:
					DialogResult = DialogResult.Cancel;
					break;
				default:
					DialogResult = DialogResult.OK;
					break;
			}

			Close();

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

	}

	public static class AbrirDialogMessage
	{

		public static DialogResult AbrirDialog
			(string Message,
			string Title,
			DialogType Type,
			DialogIcon Icon,
			DialogDefaultButton DefaultButton = DialogDefaultButton.First)
		{
			using (frmMessage f = new frmMessage(Message, Title, Type, Icon, DefaultButton))
			{
				f.ShowDialog();
				return f.DialogResult;
			}
		}
	}
}
