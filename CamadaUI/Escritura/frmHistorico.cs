using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CamadaDTO;
using CamadaBLL;
using static CamadaUI.Utilidades;

namespace CamadaUI.Escritura
{
	public partial class frmHistorico : Modals.frmModFinBorder
	{
		private List<clHistorico> HistoricoList;
		private frmLeitura _formOrigem;

		public frmHistorico(frmLeitura formOrigem)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
		}

		private void GetHistorico()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				VersiculoBLL vBLL = new VersiculoBLL(_formOrigem.DBPath);
				HistoricoList = vBLL.GetHistorico();

			}
			catch (Exception ex)
			{
				AbrirDialog("Ocorreu uma execeção ao obter a lista de Histórico \n" +
					ex.Message, "Excecão", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

	}
}
