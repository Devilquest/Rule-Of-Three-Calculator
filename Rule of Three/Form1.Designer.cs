namespace Rule_of_Three
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label xLabel;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label equalLabel;
			System.Windows.Forms.ToolTip clearButtonToolTip;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.clearButton = new System.Windows.Forms.Button();
			this.a_TextBoxPanel = new System.Windows.Forms.Panel();
			this.a_TextBox = new System.Windows.Forms.TextBox();
			this.b_TextBoxPanel = new System.Windows.Forms.Panel();
			this.b_TextBox = new System.Windows.Forms.TextBox();
			this.c_TextBoxPanel = new System.Windows.Forms.Panel();
			this.c_TextBox = new System.Windows.Forms.TextBox();
			this.a_Label = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.c_b_Label = new System.Windows.Forms.Label();
			xLabel = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			equalLabel = new System.Windows.Forms.Label();
			clearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.a_TextBoxPanel.SuspendLayout();
			this.b_TextBoxPanel.SuspendLayout();
			this.c_TextBoxPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// xLabel
			// 
			xLabel.AutoSize = true;
			xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			xLabel.Location = new System.Drawing.Point(12, 108);
			xLabel.Name = "xLabel";
			xLabel.Size = new System.Drawing.Size(29, 20);
			xLabel.TabIndex = 12;
			xLabel.Text = "x =";
			// 
			// label2
			// 
			label2.BackColor = System.Drawing.Color.Black;
			label2.Location = new System.Drawing.Point(38, 118);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(218, 1);
			label2.TabIndex = 13;
			// 
			// equalLabel
			// 
			equalLabel.AutoSize = true;
			equalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			equalLabel.Location = new System.Drawing.Point(254, 108);
			equalLabel.Name = "equalLabel";
			equalLabel.Size = new System.Drawing.Size(18, 20);
			equalLabel.TabIndex = 14;
			equalLabel.Text = "=";
			// 
			// clearButtonToolTip
			// 
			clearButtonToolTip.ToolTipTitle = "Clear (C)";
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(150, 55);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(117, 22);
			this.clearButton.TabIndex = 4;
			this.clearButton.TabStop = false;
			this.clearButton.Text = "&Clear";
			clearButtonToolTip.SetToolTip(this.clearButton, "Clear the calculator inputs.");
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// a_TextBoxPanel
			// 
			this.a_TextBoxPanel.Controls.Add(this.a_TextBox);
			this.a_TextBoxPanel.Location = new System.Drawing.Point(12, 12);
			this.a_TextBoxPanel.Name = "a_TextBoxPanel";
			this.a_TextBoxPanel.Size = new System.Drawing.Size(127, 32);
			this.a_TextBoxPanel.TabIndex = 0;
			// 
			// a_TextBox
			// 
			this.a_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a_TextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.a_TextBox.Location = new System.Drawing.Point(5, 5);
			this.a_TextBox.MaxLength = 14;
			this.a_TextBox.Name = "a_TextBox";
			this.a_TextBox.Size = new System.Drawing.Size(117, 22);
			this.a_TextBox.TabIndex = 0;
			this.a_TextBox.Text = "a";
			this.a_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.a_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.a_TextBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.a_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.a_TextBox.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// b_TextBoxPanel
			// 
			this.b_TextBoxPanel.Controls.Add(this.b_TextBox);
			this.b_TextBoxPanel.Location = new System.Drawing.Point(145, 12);
			this.b_TextBoxPanel.Name = "b_TextBoxPanel";
			this.b_TextBoxPanel.Size = new System.Drawing.Size(127, 32);
			this.b_TextBoxPanel.TabIndex = 1;
			// 
			// b_TextBox
			// 
			this.b_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_TextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.b_TextBox.Location = new System.Drawing.Point(5, 5);
			this.b_TextBox.MaxLength = 14;
			this.b_TextBox.Name = "b_TextBox";
			this.b_TextBox.Size = new System.Drawing.Size(117, 22);
			this.b_TextBox.TabIndex = 1;
			this.b_TextBox.Text = "b";
			this.b_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.b_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.b_TextBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.b_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.b_TextBox.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// c_TextBoxPanel
			// 
			this.c_TextBoxPanel.Controls.Add(this.c_TextBox);
			this.c_TextBoxPanel.Location = new System.Drawing.Point(12, 50);
			this.c_TextBoxPanel.Name = "c_TextBoxPanel";
			this.c_TextBoxPanel.Size = new System.Drawing.Size(127, 32);
			this.c_TextBoxPanel.TabIndex = 2;
			// 
			// c_TextBox
			// 
			this.c_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_TextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.c_TextBox.Location = new System.Drawing.Point(5, 5);
			this.c_TextBox.MaxLength = 14;
			this.c_TextBox.Name = "c_TextBox";
			this.c_TextBox.Size = new System.Drawing.Size(117, 22);
			this.c_TextBox.TabIndex = 2;
			this.c_TextBox.Text = "c";
			this.c_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.c_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.c_TextBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.c_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.c_TextBox.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// a_Label
			// 
			this.a_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.a_Label.Location = new System.Drawing.Point(35, 120);
			this.a_Label.Name = "a_Label";
			this.a_Label.Size = new System.Drawing.Size(217, 20);
			this.a_Label.TabIndex = 8;
			this.a_Label.Text = "a";
			this.a_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// resultLabel
			// 
			this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.resultLabel.AutoEllipsis = true;
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(12, 144);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(260, 27);
			this.resultLabel.TabIndex = 9;
			this.resultLabel.Text = "Result";
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// c_b_Label
			// 
			this.c_b_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_b_Label.Location = new System.Drawing.Point(35, 97);
			this.c_b_Label.Name = "c_b_Label";
			this.c_b_Label.Size = new System.Drawing.Size(217, 20);
			this.c_b_Label.TabIndex = 11;
			this.c_b_Label.Text = "c * b";
			this.c_b_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 181);
			this.Controls.Add(label2);
			this.Controls.Add(xLabel);
			this.Controls.Add(this.c_b_Label);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.a_Label);
			this.Controls.Add(this.c_TextBoxPanel);
			this.Controls.Add(this.b_TextBoxPanel);
			this.Controls.Add(this.a_TextBoxPanel);
			this.Controls.Add(equalLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Rule Of Three Calculator";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.a_TextBoxPanel.ResumeLayout(false);
			this.a_TextBoxPanel.PerformLayout();
			this.b_TextBoxPanel.ResumeLayout(false);
			this.b_TextBoxPanel.PerformLayout();
			this.c_TextBoxPanel.ResumeLayout(false);
			this.c_TextBoxPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel a_TextBoxPanel;
        private System.Windows.Forms.TextBox a_TextBox;
        private System.Windows.Forms.Panel b_TextBoxPanel;
        private System.Windows.Forms.TextBox b_TextBox;
        private System.Windows.Forms.Panel c_TextBoxPanel;
        private System.Windows.Forms.TextBox c_TextBox;
        private System.Windows.Forms.Label a_Label;
        private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Label c_b_Label;
	}
}

