using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculoLomo
{
	public partial class Index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected string operacionLomo(int npag, int grms, double mano)
		{
			double res = ((npag / 2) * grms * mano) / 1000;
			res = Math.Round(res * 2, MidpointRounding.AwayFromZero) / 2;
			return ("Lomo: " + res.ToString() + " mm");
		}

		protected string manage_calc()
		{
			int npag = int.Parse(TextBox_NPag.Text);
			int grms = int.Parse(TextBox_Gramaje.Text);
			switch ((DropDownList_Enc.SelectedIndex * 10) + DropDownList_Papel.SelectedIndex)
			{
				case 0:
					return (operacionLomo(npag, grms, 0.94));           // Enc: 0(Hilo) + Papel: 0(Estucado)
				case 1:
					return (operacionLomo(npag, grms, 1.24));           // Enc: 0(Hilo) + Papel: 1(Offset)
				case 2:
					return (operacionLomo(npag, grms, 1.48));           // Enc: 0(Hilo) + Papel: 2(Offset Volumen)
				case 10:
					return (operacionLomo(npag, grms, 1));              // Enc: 10(Fresado) + Papel: 0(Estucado)
				case 11:
					return (operacionLomo(npag, grms, 1.28));           // Enc: 10(Fresado) + Papel: 1(Offset)
				case 12:
					return (operacionLomo(npag, grms, 1.52));           // Enc: 10(Fresado) + Papel: 2(Offset Volumen)
			}
			return null;
		}

		protected void OnClick_Calcular(object sender, EventArgs e)
		{
			if (ulong.Parse(TextBox_NPag.Text) > 10000)
				Result.Text = "¿¡CÓMO QUE " + ulong.Parse(TextBox_NPag.Text) + " PÁGINAS!? 😅";
			else if (ulong.Parse(TextBox_Gramaje.Text) > 1000)
				Result.Text = "¿¡CÓMO QUE " + ulong.Parse(TextBox_Gramaje.Text) + " GRAMOS!? 😅";
			else if (DropDownList_Enc.SelectedIndex == 0 && int.Parse(TextBox_NPag.Text) % 4 != 0)
				Result.Text = "El Nº de páginas debe ser múltiplo de 4";
			else
				Result.Text = manage_calc();
		}
	}
}