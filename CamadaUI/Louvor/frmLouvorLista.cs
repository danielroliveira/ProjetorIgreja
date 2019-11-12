using CamadaBLL;
using CamadaDTO;
using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Louvor
{
	public partial class frmLouvorLista : Form
	{
		private List<clLouvor> ListLouvor = null;
		private string[] MensagemInicial = null;
		private LouvorBLL lBLL = null;
		public string DBPath;
		private int? IDLouvorEscolhido = null;
		bool TextProcuraChanged = false;

		private Image imgFav1;
		private Image imgFav2;
		private Image imgFav3;
		private Image imgFav4;
		private Image imgFav5;
		private Image TomSel = Properties.Resources.select_24;
		
		#region NEW AND PROPERTIES

		// SUB NEW
		public frmLouvorLista()
		{
			InitializeComponent();

			// Ampulheta ON
			Cursor.Current = Cursors.WaitCursor;

			// define Origem and Images
			DefineImageList();
			DBPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjetorDB.mdb");
			lBLL = new LouvorBLL(DBPath);

			// get data
			GetLouvores();
			FormataListagem();
		}

		private void frmLouvorLista_Shown(object sender, EventArgs e)
		{
			txtProcura.Focus();
			if (MensagemInicial != null)
			{
				AbrirDialog(MensagemInicial[0], MensagemInicial[1],
					DialogType.OK, DialogIcon.Exclamation);
			}

			pnlHistorico.Visible = true;

			// Ampulheta OFF
			Cursor.Current = Cursors.Default;
		}

		private void DefineImageList()
		{
			imgFav1 = Properties.Resources.Favorito1;
			imgFav2 = Properties.Resources.Favorito2;
			imgFav3 = Properties.Resources.Favorito3;
			imgFav4 = Properties.Resources.Favorito4;
			imgFav5 = Properties.Resources.Favorito5;
		}

		#endregion

		#region GET DATA

		// GET LIST HINOS
		// =============================================================================
		private void GetLouvores()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// Get
				ListLouvor = lBLL.GetLouvorList();

				// define List DataSource
				lstListagem.DataSource = ListLouvor;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a lista de Louvores..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				if (this.IsAccessible)
				{
					// --- Ampulheta OFF
					Cursor.Current = Cursors.Default;
				}
			}
		}


		#endregion

		#region LISTAGEM

		// --- FORMATA LISTAGEM DE CLIENTE
		private void FormataListagem()
		{
			lstListagem.MultiSelect = false;
			lstListagem.HideSelection = false;

			clnIDLouvor.ValueMember = "IDLouvor";
			clnIDLouvor.Width = 70;
			clnIDLouvor.AllowResize = false;

			clnTitulo.DisplayMember = "Titulo";
			clnTitulo.ValueMember = "Titulo";
			clnTitulo.Width = 500;
			clnTitulo.AllowResize = false;

			clnCategoria.DisplayMember = "Categoria";
			clnCategoria.ValueMember = "IDCategoria";
			clnCategoria.Width = 300;
			clnCategoria.AllowResize = false;

			clnNota.ValueMember = "Favorito";
			clnNota.Width = 170;
			clnNota.AllowResize = false;
			clnNota.AlignHorizontalImage = BetterListViewImageAlignmentHorizontal.BeforeTextCenter;

			clnTomDesc.DisplayMember = "TomCifra";
			clnTomDesc.ValueMember = "Tom";
			clnTomDesc.Width = 120;
			clnTomDesc.AllowResize = false;
			

			lstListagem.SearchSettings = new BetterListViewSearchSettings(BetterListViewSearchMode.PrefixOrSubstring,
																		  BetterListViewSearchOptions.UpdateSearchHighlight,
																		  new int[] { 1 });
		}

		private void lstListagem_DrawColumnHeader(object sender, BetterListViewDrawColumnHeaderEventArgs eventArgs)
		{
			if (eventArgs.ColumnHeaderBounds.BoundsOuter.Width > 0 && eventArgs.ColumnHeaderBounds.BoundsOuter.Height > 0)
			{
				Brush brush = new LinearGradientBrush(
					eventArgs.ColumnHeaderBounds.BoundsOuter,
					Color.Transparent,
					Color.FromArgb(64, Color.SteelBlue),
					LinearGradientMode.Vertical);

				Pen p = new Pen(Color.SlateGray, 2);

				eventArgs.Graphics.FillRectangle(brush, eventArgs.ColumnHeaderBounds.BoundsOuter);

				eventArgs.Graphics.DrawLine(p, eventArgs.ColumnHeaderBounds.BoundsOuter.X,
							eventArgs.ColumnHeaderBounds.BoundsOuter.Height,
							eventArgs.ColumnHeaderBounds.BoundsOuter.Width + eventArgs.ColumnHeaderBounds.BoundsOuter.X,
							eventArgs.ColumnHeaderBounds.BoundsOuter.Height);

				brush.Dispose();
				p.Dispose();

			}
		}

		private void lstListagem_DrawItem(object sender, BetterListViewDrawItemEventArgs eventArgs)
		{

			eventArgs.Item.Text = $"{eventArgs.Item.Value:000}";

			eventArgs.Item.SubItems[4].AlignHorizontal = TextAlignmentHorizontal.Center;

			int Cl = Convert.ToInt32(eventArgs.Item.SubItems[3].Value);

			if (Cl == 1)
			{
				eventArgs.Item.SubItems[3].Image = imgFav1;
			}
			else if (Cl == 2)
			{
				eventArgs.Item.SubItems[3].Image = imgFav2;
			}
			else if (Cl == 3)
			{
				eventArgs.Item.SubItems[3].Image = imgFav3;
			}
			else if (Cl == 4)
			{
				eventArgs.Item.SubItems[3].Image = imgFav4;
			}
			else if (Cl == 5)
			{
				eventArgs.Item.SubItems[3].Image = imgFav5;
			}
		}

		// ESCOLHER HINO
		private void lstListagem_ItemActivate(object sender, BetterListViewItemActivateEventArgs eventArgs)
		{
			btnEscolher_Click(sender, new EventArgs());
		}

		#endregion

		#region BUTTONS FUNCTION

		// BTN VOLTAR ETAPA
		// =============================================================================
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			btnClose_Click(sender, e);
		}

		// CLOSE FORM
		// ---------------------------------------------------------------------------
		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.OpenForms["frmPrincipal"].Visible = true;
			Close();
		}

		// BTN ESCOLHER
		// ---------------------------------------------------------------------------
		private void btnEscolher_Click(object sender, EventArgs e)
		{
			if (lstListagem.SelectedItems.Count == 0)
			{
				AbrirDialog("Favor selecionar um Hino na listagem antes de Escolher...",
					"Escolher Hino", DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			clLouvor louvor = ListLouvor.Find(l => l.IDLouvor == (int)lstListagem.SelectedItems[0].Value);

			ProjetarLouvor(louvor);
		}

		// ESCOLHER HINO
		//-------------------------------------------------------------------------------------------------
		public void ProjetarLouvor(clLouvor louvor)
		{
			string louvorPath = louvor.ProjecaoPath;

			// verifica a existencia do DIR
			if (!File.Exists(louvorPath))
			{
				AbrirDialog("O arquivo de projeção relacionado ao louvor : \n" + 
					louvor.Titulo +
					"\n foi removido ou excluído do sua pasta de origem...",
					"Arquivo não Encontrado", DialogType.OK, DialogIcon.Exclamation);
				try
				{
					// --- Ampulheta ON
					Cursor.Current = Cursors.WaitCursor;
					lBLL.UpdateFileOKLouvor(louvor.IDLouvor, false);
					louvor.FileOK = false;
				}
				catch (Exception ex)
				{
					AbrirDialog("Uma exceção ocorreu ao Atualizar a situação do arquivo..." + "\n" +
								ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				}
				finally
				{
					// --- Ampulheta OFF
					Cursor.Current = Cursors.Default;
				}

				return;
			}
			else if(File.Exists(louvorPath) && !louvor.FileOK)
			{
				try
				{
					// --- Ampulheta ON
					Cursor.Current = Cursors.WaitCursor;
					lBLL.UpdateFileOKLouvor(louvor.IDLouvor, false);
					louvor.FileOK = true;
				}
				catch (Exception ex)
				{
					AbrirDialog("Uma exceção ocorreu ao Atualizar a situação do Louvor..." + "\n" +
								ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				}
				finally
				{
					// --- Ampulheta OFF
					Cursor.Current = Cursors.Default;
				}

			}

			IDLouvorEscolhido = louvor.IDLouvor;
			System.Diagnostics.Process.Start(louvor.ProjecaoPath);

			//MessageBox.Show("voltei");

			/* 
			int IDHino = (int)lstListagem.SelectedItems[0].Value;
			clHarpaHino Hino = ListLouvor.Find(h => h.IDHino == IDHino);

			HinoEscolhido = Hino;
			DialogResult = DialogResult.OK; */

			/*

			using PowerPoint = Microsoft.Office.Interop.PowerPoint;

			PowerPoint.Application oPPT;
			PowerPoint.Presentations objPresSet;

			//the location of your powerpoint presentation
			string strPres;
			strPres = @"mpPres.ppt";
			//Create an instance of PowerPoint.
			oPPT = new PowerPoint.ApplicationClass();
			// Show PowerPoint to the user.
			oPPT.Visible = Microsoft.Office.Core.MsoTriState.msoTrue;

			objPresSet = oPPT.Presentations ;

			//open the presentation
			objPres = objPresSet.Open ( strPres,MsoTriState.msoFalse ,
			MsoTriState.msoTrue ,MsoTriState.msoTrue );

			*/
		}

		// MINIMIZE
		//-------------------------------------------------------------------------------------------------
		private void btnMinimizer_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		#endregion

		#region OTHER FUNCTIONS

		// ASK USER ADD COUNT ESCOLHIDO
		// =============================================================================
		private void frmLouvorLista_Activated(object sender, EventArgs e)
		{
			if (IDLouvorEscolhido == null)
			{
				return;
			}

			clLouvor louvor = ListLouvor.Find(l => l.IDLouvor == IDLouvorEscolhido);

			DialogResult resp = AbrirDialog("Deseja adicionar Louvor ao histórico?",
				"Louvor Escolhido", DialogType.SIM_NAO, DialogIcon.Question);

			if (resp == DialogResult.No)
			{
				IDLouvorEscolhido = null;
				return;
			}

			AddLouvorHistorico(louvor);

		}

		#endregion

		#region VISUAL EFFECTS

		private void frmLouvorEscolher_Activated(object sender, EventArgs e)
		{
			/* Panel pnl = (Panel)_formOrigem.Controls["pnlTop"];
			pnl.BackColor = Color.Silver; */
		}

		private void frmLouvorEscolher_FormClosed(object sender, FormClosedEventArgs e)
		{
			/* Panel pnl = (Panel)_formOrigem.Controls["pnlTop"];
			pnl.BackColor = Properties.Settings.Default.PanelTopColor; */
		}




		#endregion

		#region PROCURA TEXT

		// PROCURAR HINO PELO TITULO: TEXT CHANGE
		// =============================================================================
		private void btnProcurar_Click(object sender, EventArgs e)
		{
			// Ampulheta ON
			Cursor.Current = Cursors.WaitCursor;

			ProcurarHinoTxt();
			if(lstListagem.Items.Count == 0)
			{
				ShowToolTip(txtProcura);
			}

			if (txtProcura.Text.Length > 0)
			{
				BetterListViewItemCollection itemsFound;
				itemsFound = lstListagem.FindItemsWithText(txtProcura.Text);
			}
			else
			{
				lstListagem.FindItemsWithText("?");
				lstListagem.SelectedItems.Clear();
			}

			// Ampulheta OFF
			Cursor.Current = Cursors.Default;
		}
		
		// PROCURAR HINO PELO TITULO
		// =============================================================================
		private void ProcurarHinoTxt()
		{
			if (txtProcura.TextLength > 0 && txtProcura.Text.Substring(0, 1).IsNumeric())
			{
				lstListagem.DataSource = ListLouvor.FindAll(FiltroID);
			}
			else
			{
				lstListagem.DataSource = ListLouvor.FindAll(FiltroTitulo);
			}
		}

		// DELEGATE FUNCTION
		// ---------------------------------------------------------------------------
		private bool FiltroTitulo(clLouvor H)
		{
			if (H.Titulo.ToLower().Contains(txtProcura.Text.ToLower()))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// DELEGATE FUNCTION
		// ---------------------------------------------------------------------------
		private bool FiltroID(clLouvor H)
		{
			if (H.IDLouvor == Convert.ToInt32(txtProcura.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion
			   		 	  	  
		#region MENU LISTAGEM

		// EDIT HINO FIELDS
		// =============================================================================
		private void miEditarLouvor_Click(object sender, EventArgs e)
		{
			if(lstListagem.SelectedItems.Count == 0)
			{
				return;
			}

			// get selected Louvor
			int selID = (int)lstListagem.SelectedItems[0].Value;
			clLouvor selLouvor = ListLouvor.Find(l => l.IDLouvor == selID);

			// open frmLouvorEditar
			try
			{
				using (frmLouvorEditar frm = new frmLouvorEditar(selLouvor, this) )
				{
					frm.ShowDialog();
					if(frm.DialogResult == DialogResult.OK)
					{
						lstListagem.SelectedItems[0].SubItems[1].Text = selLouvor.Titulo;
						lstListagem.SelectedItems[0].SubItems[2].Text = selLouvor.Categoria;
					}
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao abrir o formulário de Edição..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}


		}




		// DEFINE COLOR OF SELECTED TOM WHEN OPEN MENU STRIP
		// =============================================================================
		private void mnuLista_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// get TOM atual
			byte? TomAtual = (byte?)lstListagem.SelectedItems[0].SubItems[4].Value;

			foreach (ToolStripMenuItem item in miDefinirTom.DropDownItems)
			{
				if (Convert.ToByte(item.Tag) == TomAtual)
				{
					item.BackColor = Color.Moccasin;
					item.Image = TomSel;
				}
				else
				{
					item.BackColor = Color.WhiteSmoke;
					item.Image = null;
				}
			}

		}

		// DEFINE TOM OF SELECTED ITEM
		// =============================================================================
		private void DefineTom_Click(object sender, EventArgs e)
		{
			// get selected Louvor
			int selID = (int)lstListagem.SelectedItems[0].Value;
			clLouvor selLouvor = ListLouvor.Find(l => l.IDLouvor == selID);

			ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

			selLouvor.Tom = Convert.ToByte(tsm.Tag);
			lstListagem.SelectedItems[0].SubItems[4].Text = selLouvor.TomCifra;

			// save in DB
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				lBLL.UpdateTomLouvor(selLouvor.IDLouvor, (byte)selLouvor.Tom);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Definir novo Tom do Louvor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		#endregion
			   		 	  	  	   
		#region PANEL HISTORICO

		private void AddLouvorHistorico(clLouvor louvor)
		{
			// ADD Louvor Escolhido Count
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				lBLL.AddEscolhidoLouvor(louvor.IDLouvor);
				louvor.EscolhidoCount += 1;
				IDLouvorEscolhido = null;
			}
			catch (Exception ex)
			{
				IDLouvorEscolhido = null;
				AbrirDialog("Uma exceção ocorreu ao Acrescentar o número de escolhido..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
			
			// add in HISTORICO if selected different Hino
			try
			{
				lBLL.AddHistorico((int)louvor.IDLouvor);
			}
			catch (Exception ex)
			{
				AbrirDialog("Um exceção ocorreu ao salvar Histórico \n" + ex.Message,
					"Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}

		private void btnHistorico_Click(object sender, EventArgs e)
		{
			OpenHistorico();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			OpenHistorico();
		}

		// OPEN HISTORICO FORM
		private void OpenHistorico()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				pnlHistorico.Width = 450;
				pnlHistorico.Location = new Point(ClientSize.Width - 450, 40);

				using (frmLouvorHistorico frm = new frmLouvorHistorico(this))
				{
					frm.ShowDialog();
				}

				pnlHistorico.Visible = true;
				Timer tmr = new Timer();
				tmr.Interval = 1;
				tmr.Tick += Tmr_Tick;
				tmr.Start();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir o histórico de Louvor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void Tmr_Tick(object sender, EventArgs e)
		{
			if (pnlHistorico.Width <= 237)
			{
				pnlHistorico.Width = 237;
				Timer tmr = (Timer)sender;
				tmr.Stop();
			}

			pnlHistorico.Width -= 5;
			pnlHistorico.Location = new Point(pnlHistorico.Location.X + 5, pnlHistorico.Location.Y);
			pnlHistorico.Refresh();
		}


		#endregion

		#region TOOLTIP

		private void ShowToolTip(Control controle)
		{
			//Cria a ToolTip e associa com o Form container.
			ToolTip toolTip1 = new ToolTip()
			{
				AutoPopDelay = 2000, // Define o delay para a ToolTip
				InitialDelay = 2000,
				ReshowDelay = 500,
				IsBalloon = true,
				UseAnimation = true,
				UseFading = true
			};
			
			if(controle.Tag.ToString() == "") 
			{
				toolTip1.Show("Clique aqui...", controle, controle.Width - 30, -40, 2000);
			}
			else 
			{
				toolTip1.Show(controle.Tag.ToString(), controle, controle.Width - 30, -40, 2000);
			}
		}

		// SHOW TOOLTIP ON TEXT CHANGE
		private void txtProcura_TextChanged(object sender, EventArgs e)
		{
			TextProcuraChanged = true;
			ShowToolTip((Control)btnProcurar);
		}

		#endregion

		// TECLA (ENTER) EXECUTE PROCURA
		// =============================================================================
		private void txtProcura_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;

				if (TextProcuraChanged)
				{
					btnProcurar_Click(sender, e);
					TextProcuraChanged = false;
				}
				else
				{
					btnEscolher_Click(sender, new EventArgs());
				}
			}
			else if(e.KeyCode == Keys.Delete)
			{
				txtProcura.Clear();
				txtProcura.Refresh();
				btnProcurar_Click(sender, e);
				TextProcuraChanged = false;
			}
			else
			{
				frmLouvorLista_KeyDown(sender, e);
			}
		}

		// SHORTCUTS NAVEGACAO BY ESTROFES
		// =============================================================================
		private void frmLouvorLista_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				//--- verifica se o combo não está aberto
				//If cmbAtivo.DroppedDown = True Then Exit Sub

				e.Handled = true;

				if (lstListagem.Items.Count > 0)
				{
					if (lstListagem.SelectedItems.Count > 0)
					{
						int i = lstListagem.SelectedItems[0].Index;

						lstListagem.Items[i].Selected = false;

						if (i == 0)
						{
							i = lstListagem.Items.Count;
						}

						lstListagem.Items[i - 1].Selected = true;
						lstListagem.EnsureVisible(i - 1);
					}
					else
					{
						lstListagem.Items[0].Selected = true;
						lstListagem.EnsureVisible(0);
					}
				}

			}
			else if (e.KeyCode == Keys.Down)
			{
				e.Handled = true;

				if (lstListagem.Items.Count > 0)
				{
					if (lstListagem.SelectedItems.Count > 0)
					{
						int i = lstListagem.SelectedItems[0].Index;

						lstListagem.Items[i].Selected = false;

						if (i == lstListagem.Items.Count - 1)
						{
							i = -1;
						}

						lstListagem.Items[i + 1].Selected = true;
						lstListagem.EnsureVisible(i + 1);
					}
					else
					{
						lstListagem.Items[0].Selected = true;
					}
				}

			}
			else if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnClose_Click(sender, e);
			}
			else if (e.KeyCode == Keys.H)
			{
				e.Handled = true;
				OpenHistorico();
			}
		}

		private void frmLouvorLista_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}
	}
}
