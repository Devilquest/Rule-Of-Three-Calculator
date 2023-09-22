using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Rule_of_Three
{
	public partial class Form1 : Form
    {
		Color normalColor = SystemColors.Control, errorColor = Color.Red, gray = Color.DarkGray, black = Color.Black;

        decimal? numA = null, numB = null, numC = null;

		string bLabelText = "b", cLabelText = "c";

		public Form1()
        {
			#if DEBUG
				System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
			#endif

			InitializeComponent();
		}

		#region Calc
		private decimal? RuleOfThreeCalc()
        {
            if (numA != 0 && numA.HasValue && numB.HasValue && numC.HasValue)
				return (numC * numB) / numA;

			return null;
        }
		#endregion

		#region Ui
		/// <summary>
		/// Updates the number variables and change the UI according to textbox text
		/// </summary>
		/// <param name="boxName">Name of the textbox changed</param>
		/// <param name="boxText">Text in the changed textbox</param>
		/// <param name="d">Number in the textbox</param>
		/// <param name="error">Trigger error, if the textbox text is not a decimal</param>
		private void UpdateNumAndUI(string boxName, string boxText, decimal? d, bool error = false)
        {
            switch (boxName)
            {
                case "a_TextBox":
                    if (!error)
                    {
                        numA = d;
                        a_Label.Text = d.ToString();
                        a_TextBoxPanel.BackColor = normalColor;
					}
                    else if (boxText != string.Empty)
                    {
						a_TextBoxPanel.BackColor = errorColor;
                    }
                    else
                    {
                        numA = null;
                        a_TextBoxPanel.BackColor = normalColor;
						a_Label.Text = "a";
                    }
                    break;
                case "b_TextBox":
                    if (!error)
                    {
                        numB = d;
                        b_TextBoxPanel.BackColor = normalColor;
						bLabelText = d.ToString();
					}
                    else if (boxText != string.Empty)
                    {
                        b_TextBoxPanel.BackColor = errorColor;
                    }
                    else
                    {
                        numB = null;
                        b_TextBoxPanel.BackColor = normalColor;
						bLabelText = "b";
                    }
                    break;
                case "c_TextBox":
                    if (!error)
                    {
                        numC = d;
                        c_TextBoxPanel.BackColor = normalColor;
						cLabelText = d.ToString();
					}
                    else if (boxText != string.Empty)
                    {
                        c_TextBoxPanel.BackColor = errorColor;
                    }
                    else
                    {
                        numC = null;
                        c_TextBoxPanel.BackColor = normalColor;
						cLabelText = "c";
					}
                    break;
            }

			c_b_Label.Text = cLabelText + " * " + bLabelText;

			decimal? result = RuleOfThreeCalc();
			resultLabel.Text = result.HasValue ? Math.Round(result.Value, 5).ToString() : "Result";
		}

		/// <summary>
		/// Resets the given textbox
		/// </summary>
		/// <param name="box">TextBox Object</param>
		/// <param name="text">String to put in the textbox</param>
		private void ResetTextBox(TextBox box, string text)
		{
			box.Text = text;
			box.ForeColor = gray;
		}

		/// <summary>
		/// Resets the Calculator to initial state
		/// </summary>
		private void ResetCalculator()
		{
			//reset numbers
			numA = null;
			numB = null;
			numC = null;

			//reset textbox
			ResetTextBox(a_TextBox, "a");
			ResetTextBox(b_TextBox, "b");
			ResetTextBox(c_TextBox, "c");

			//reset result labels
			a_Label.Text = "a";
			bLabelText = "b";
			cLabelText = "c";
			c_b_Label.Text = cLabelText + " * " + bLabelText;

			//clear panel red color
			a_TextBoxPanel.BackColor = normalColor;
			b_TextBoxPanel.BackColor = normalColor;
			c_TextBoxPanel.BackColor = normalColor;
		}
		#endregion

		#region Events
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;
			box.ForeColor = black;

			//In case user paste something in textbox
			if (box.Text.IndexOf(",") > -1)
			{
				box.Text = box.Text.Replace(",", ".");
				box.SelectionStart = box.Text.Length;
				box.SelectionLength = 0;
			}

			if (decimal.TryParse(box.Text, NumberStyles.AllowDecimalPoint, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out decimal d) && d != 0)
				UpdateNumAndUI(box.Name, box.Text, d);
			else
				UpdateNumAndUI(box.Name, box.Text, null, true);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			switch (box.Name)
			{
				case "a_TextBox":
					if (!numA.HasValue)
						box.Text = "";
					break;
				case "b_TextBox":
					if (!numB.HasValue)
						box.Text = "";
					break;
				case "c_TextBox":
					if (!numC.HasValue)
						box.Text = "";
					break;
			}
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			if (string.IsNullOrWhiteSpace(box.Text))
			{
				switch (box.Name)
				{
					case "a_TextBox":
						ResetTextBox(box, "a");
						break;
					case "b_TextBox":
						ResetTextBox(box, "b");
						break;
					case "c_TextBox":
						ResetTextBox(box, "c");
						break;
				}
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.C)
				ResetCalculator();
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
				e.Handled = true;

			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
				e.Handled = true;
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			ResetCalculator();
		}
		#endregion
	}
}