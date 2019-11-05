using CamadaBLL;
using CamadaDTO;
using ComponentOwl.BetterListView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Louvor
{
	public partial class frmLouvorEscolher : Modals.frmModFinBorder
	{
		private List<clLouvor> ListLouvor = null;

		private Image imgFav1;
		private Image imgFav2;
		private Image imgFav3;
		private Image imgFav4;
		private Image imgFav5;
		// public clHarpaHino HinoEscolhido = null; // hino escolhido
		
		#region NEW AND PROPERTIES

		// SUB NEW
		public frmLouvorEscolher()
		{
			InitializeComponent();

			// define Origem and Images
			DefineImageList();

			// get data
			GetHinos();
			lstListagem.DataSource = ListLouvor;
			FormataListagem();

			// define height size from Screen Height
			//int WorkAreaH = Screen.PrimaryScreen.WorkingArea.Size.Height;
			//Size = new Size(Size.Width, (int)Math.Ceiling(WorkAreaH * (0.9)) );
			
		}

		private void frmLouvorEscolher_Shown(object sender, EventArgs e)
		{
			txtProcura.Focus();
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
		private void GetHinos()
		{

			string path = @"E:\Desktop\Igreja Membresia\Projetor\Projeção Louvores\Louvores Igreja";

			ListLouvor = DisplayDriveDirectories(path);

			/* try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// Get
				HarpaBLL hBLL = new HarpaBLL(_formOrigem.DBPath);

				if (txtProcura.Text.IsNumeric())
				{

				}

				ListLouvor = hBLL.GetHinosList();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a lista de Hinos..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			} */
		}

		public List<clLouvor> DisplayDriveDirectories(string drivePath)
		{
			List<clLouvor> list = new List<clLouvor>();

			if (Directory.Exists(drivePath))
			{
				foreach (String dirPath in Directory.GetDirectories(drivePath))
					DisplayDriveDirectories(dirPath);

				DirectoryInfo dir = new DirectoryInfo(drivePath);

				int numFiles = dir.GetFiles().Length;
				int ID = 0;

				foreach (FileInfo file in dir.GetFiles())
				{
					if(file.Extension == ".pps" || file.Extension == ".ppsx")
					{
						clLouvor louvor = new clLouvor(ID);
						louvor.Titulo = file.Name;
						louvor.ProjecaoPath = file.FullName;

						ID += 1;
						list.Add(louvor);
					}
				}

				return list;

				//Response.Output.WriteLine("<br>{0} : {1} files.", drivePath, numFiles);
			}
			else
			{
				return list;
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
			clnTitulo.Width = 600;
			clnTitulo.AllowResize = false;

			//clnNota.ValueMember = "Classificacao";
			clnNota.Width = 170;
			clnNota.AllowResize = false;
			clnNota.AlignHorizontalImage = BetterListViewImageAlignmentHorizontal.BeforeTextCenter;

			lstListagem.SearchSettings = new BetterListViewSearchSettings(BetterListViewSearchMode.PrefixOrSubstring,
																		  BetterListViewSearchOptions.UpdateSearchHighlight,
																		  new int[] { 0, 1, 2 });
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

			int Cl = Convert.ToInt32(eventArgs.Item.SubItems[2].Value);

			if (Cl == 1)
			{
				eventArgs.Item.SubItems[2].Image = imgFav1;
			}
			else if (Cl == 2)
			{
				eventArgs.Item.SubItems[2].Image = imgFav2;
			}
			else if (Cl == 3)
			{
				eventArgs.Item.SubItems[2].Image = imgFav3;
			}
			else if (Cl == 4)
			{
				eventArgs.Item.SubItems[2].Image = imgFav4;
			}
			else if (Cl == 5)
			{
				eventArgs.Item.SubItems[2].Image = imgFav5;
			}
		}

		// ESCOLHER HINO
		private void lstListagem_ItemActivate(object sender, BetterListViewItemActivateEventArgs eventArgs)
		{
			EscolherHino();
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
			EscolherHino();
		}

		// ESCOLHER HINO
		//-------------------------------------------------------------------------------------------------
		private void EscolherHino()
		{
			clLouvor louvor = ListLouvor.Find(l => l.IDLouvor == (int)lstListagem.SelectedItems[0].Value);

			System.Diagnostics.Process.Start(louvor.ProjecaoPath);

			/* if(lstListagem.SelectedItems.Count == 0)
			{
				AbrirDialog("Favor selecionar um Hino na listagem antes de Escolher...",
					"Escolher Hino", DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			int IDHino = (int)lstListagem.SelectedItems[0].Value;
			clHarpaHino Hino = ListLouvor.Find(h => h.IDHino == IDHino);

			HinoEscolhido = Hino;
			DialogResult = DialogResult.OK; */
		}
		

		#endregion

		#region OTHER FUNCTIONS

		private void frmLouvorEscolher_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnClose_Click(sender, e);
			}
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

		// PROCURAR HINO PELO TITULO: TEXT CHANGE
		// =============================================================================
		private void txtProcura_TextChanged(object sender, EventArgs e)
		{
			ProcurarHinoTxt();
			BetterListViewItemCollection itemsFound;

			if( txtProcura.Text.Length > 0)
			{
				itemsFound = lstListagem.FindItemsWithText(txtProcura.Text);
			}
			else
			{
				lstListagem.FindItemsWithText("?");
				lstListagem.SelectedItems.Clear();
			}
		}

		// PROCURAR HINO PELO TITULO
		// =============================================================================
		private void ProcurarHinoTxt()
		{
			if(txtProcura.TextLength > 0 && txtProcura.Text.Substring(0, 1).IsNumeric())
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
			if(H.IDLouvor == Convert.ToInt32(txtProcura.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
