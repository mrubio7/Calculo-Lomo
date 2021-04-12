
namespace CalculoLomo
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button_Calculo = new System.Windows.Forms.Button();
			this.textBox_NumPag = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox_Papel = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox_Encuad = new System.Windows.Forms.ComboBox();
			this.textBox_Gramaje = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label_Result = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// button_Calculo
			// 
			this.button_Calculo.AccessibleName = "calcBtn";
			this.button_Calculo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.button_Calculo.Location = new System.Drawing.Point(210, 209);
			this.button_Calculo.Name = "button_Calculo";
			this.button_Calculo.Size = new System.Drawing.Size(84, 24);
			this.button_Calculo.TabIndex = 0;
			this.button_Calculo.Tag = "btCalc";
			this.button_Calculo.Text = "Calcular";
			this.button_Calculo.UseVisualStyleBackColor = true;
			this.button_Calculo.Click += new System.EventHandler(this.btnCalc);
			// 
			// textBox_NumPag
			// 
			this.textBox_NumPag.AccessibleName = "nPagTextBox";
			this.textBox_NumPag.Location = new System.Drawing.Point(124, 29);
			this.textBox_NumPag.Name = "textBox_NumPag";
			this.textBox_NumPag.Size = new System.Drawing.Size(170, 23);
			this.textBox_NumPag.TabIndex = 1;
			this.textBox_NumPag.TextChanged += new System.EventHandler(this.TextChanged_NPag);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nº de páginas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Papel";
			// 
			// comboBox_Papel
			// 
			this.comboBox_Papel.AccessibleName = "papelSelectBox";
			this.comboBox_Papel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Papel.FormattingEnabled = true;
			this.comboBox_Papel.Location = new System.Drawing.Point(40, 88);
			this.comboBox_Papel.Name = "comboBox_Papel";
			this.comboBox_Papel.Size = new System.Drawing.Size(254, 23);
			this.comboBox_Papel.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Encuadernación";
			// 
			// comboBox_Encuad
			// 
			this.comboBox_Encuad.AccessibleName = "encSelectBox";
			this.comboBox_Encuad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Encuad.FormattingEnabled = true;
			this.comboBox_Encuad.Location = new System.Drawing.Point(39, 209);
			this.comboBox_Encuad.Name = "comboBox_Encuad";
			this.comboBox_Encuad.Size = new System.Drawing.Size(155, 23);
			this.comboBox_Encuad.TabIndex = 7;
			// 
			// textBox_Gramaje
			// 
			this.textBox_Gramaje.AccessibleName = "grsTextBox";
			this.textBox_Gramaje.Location = new System.Drawing.Point(39, 147);
			this.textBox_Gramaje.Name = "textBox_Gramaje";
			this.textBox_Gramaje.Size = new System.Drawing.Size(254, 23);
			this.textBox_Gramaje.TabIndex = 8;
			this.textBox_Gramaje.TextChanged += new System.EventHandler(this.TextChanged_Gramaje);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Gramaje";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 246);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Lomo: ";
			// 
			// label_Result
			// 
			this.label_Result.AccessibleName = "Result";
			this.label_Result.AutoSize = true;
			this.label_Result.Location = new System.Drawing.Point(89, 246);
			this.label_Result.Name = "label_Result";
			this.label_Result.Size = new System.Drawing.Size(0, 15);
			this.label_Result.TabIndex = 11;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label6.Location = new System.Drawing.Point(310, -2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "v 2.0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(337, 278);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label_Result);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_Gramaje);
			this.Controls.Add(this.comboBox_Encuad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_Papel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_NumPag);
			this.Controls.Add(this.button_Calculo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Calcular Lomo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Calculo;
		private System.Windows.Forms.TextBox textBox_NumPag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_Papel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_Encuad;
		private System.Windows.Forms.TextBox textBox_Gramaje;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_Result;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label6;
	}
}

