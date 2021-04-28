
namespace DrawApp
{
    partial class PenProps
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancleButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.StyleComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.PenWidthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.PenStyleLabel = new System.Windows.Forms.Label();
            this.PenColorLabel = new System.Windows.Forms.Label();
            this.PenWidthLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancleButton);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.StyleComboBox);
            this.panel1.Controls.Add(this.ColorComboBox);
            this.panel1.Controls.Add(this.PenWidthNumUpDown);
            this.panel1.Controls.Add(this.PenStyleLabel);
            this.panel1.Controls.Add(this.PenColorLabel);
            this.panel1.Controls.Add(this.PenWidthLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 222);
            this.panel1.TabIndex = 1;
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(245, 187);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(75, 23);
            this.CancleButton.TabIndex = 6;
            this.CancleButton.Text = "Cancel";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(157, 187);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Dotted"});
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dot",
            "Dash",
            "Dash Dot",
            ""});
            this.StyleComboBox.Location = new System.Drawing.Point(156, 120);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(114, 23);
            this.StyleComboBox.TabIndex = 5;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ColorComboBox.DisplayMember = "Black";
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Aqua",
            "Blue",
            "BlueViolet",
            "Gray",
            "Green",
            "Orange",
            "Red"});
            this.ColorComboBox.Location = new System.Drawing.Point(157, 68);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(114, 23);
            this.ColorComboBox.TabIndex = 4;
            // 
            // PenWidthNumUpDown
            // 
            this.PenWidthNumUpDown.Location = new System.Drawing.Point(157, 17);
            this.PenWidthNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PenWidthNumUpDown.Name = "PenWidthNumUpDown";
            this.PenWidthNumUpDown.Size = new System.Drawing.Size(113, 23);
            this.PenWidthNumUpDown.TabIndex = 3;
            this.PenWidthNumUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // PenStyleLabel
            // 
            this.PenStyleLabel.AutoSize = true;
            this.PenStyleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PenStyleLabel.Location = new System.Drawing.Point(15, 118);
            this.PenStyleLabel.Name = "PenStyleLabel";
            this.PenStyleLabel.Size = new System.Drawing.Size(66, 20);
            this.PenStyleLabel.TabIndex = 2;
            this.PenStyleLabel.Text = "Pen style";
            // 
            // PenColorLabel
            // 
            this.PenColorLabel.AutoSize = true;
            this.PenColorLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PenColorLabel.Location = new System.Drawing.Point(12, 71);
            this.PenColorLabel.Name = "PenColorLabel";
            this.PenColorLabel.Size = new System.Drawing.Size(70, 20);
            this.PenColorLabel.TabIndex = 1;
            this.PenColorLabel.Text = "Pen color";
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.AutoSize = true;
            this.PenWidthLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PenWidthLabel.Location = new System.Drawing.Point(12, 19);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(73, 20);
            this.PenWidthLabel.TabIndex = 0;
            this.PenWidthLabel.Text = "Pen width";
            // 
            // PenProps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 221);
            this.Controls.Add(this.panel1);
            this.Name = "PenProps";
            this.Text = "Pen Properties";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PenColorLabel;
        private System.Windows.Forms.Label PenWidthLabel;
        private System.Windows.Forms.Label PenStyleLabel;
        private System.Windows.Forms.NumericUpDown PenWidthNumUpDown;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.ComboBox StyleComboBox;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Button OkButton;
    }
}