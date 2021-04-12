using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculoLomo
{
	public partial class Form1 : Form
	{
		public					Form1()
		{
			InitializeComponent();
		}

		private void			Form1_Load(object sender, EventArgs e)
		{
			comboBox_Papel.Items.AddRange(new object[] { "Estucado", "Offset", "Offset Volumen" });
			comboBox_Encuad.Items.AddRange(new object[] { "Hilo", "Fresado" });
		}
		private void			TextChanged_NPag(object sender, EventArgs e)
		{
			if ((textBox_NumPag.Text.Trim() != string.Empty) && (textBox_NumPag.Text.All(char.IsDigit)))
			{
				int np = int.Parse(textBox_NumPag.Text);
				if (np % 4 != 0)
					errorProvider1.SetError(textBox_NumPag, "El número de páginas debe ser múltiplo de 4.");
				else
					errorProvider1.SetError(textBox_NumPag, "");
			}
			else
				errorProvider1.SetError(textBox_NumPag, "Introduzca solamente números.");
		}

		private void			TextChanged_Gramaje(object sender, EventArgs e)
		{
			if ((textBox_Gramaje.Text.Trim() != string.Empty) && textBox_Gramaje.Text.All(char.IsDigit))
				errorProvider1.SetError(textBox_Gramaje, "");
			else
				errorProvider1.SetError(textBox_Gramaje, "Introduzca solamente números.");
		}

		private string			operacionLomo(int npag, int grms, double mano)
		{
			double res = ((npag / 2) * grms * mano) / 1000;
			res = Math.Round(res * 2, MidpointRounding.AwayFromZero) / 2;
			return (res.ToString() + " mm");
		}

		private string			calcularLomo()
		{
			int npag = int.Parse(textBox_NumPag.Text);
			int grms = int.Parse(textBox_Gramaje.Text);
			switch ((comboBox_Encuad.SelectedIndex * 10) + comboBox_Papel.SelectedIndex)
			{
				case 0:
					return (operacionLomo(npag, grms, 0.94));			// Enc: 0(Hilo) + Papel: 0(Estucado)
				case 1:
					return (operacionLomo(npag, grms, 1.24));			// Enc: 0(Hilo) + Papel: 1(Offset)
				case 2:
					return (operacionLomo(npag, grms, 1.48));			// Enc: 0(Hilo) + Papel: 2(Offset Volumen)
				case 10:
					return (operacionLomo(npag, grms, 1));				// Enc: 10(Fresado) + Papel: 0(Estucado)
				case 11:
					return (operacionLomo(npag, grms, 1.28));			// Enc: 10(Fresado) + Papel: 1(Offset)
				case 12:
					return (operacionLomo(npag, grms, 1.52));			// Enc: 10(Fresado) + Papel: 2(Offset Volumen)
			}
			return null;
		}
		private void			btnCalc(object sender, EventArgs e)
		{
			label_Result.Text = calcularLomo();
		}

	}
}
