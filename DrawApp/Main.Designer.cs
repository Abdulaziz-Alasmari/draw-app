
namespace DrawApp
{
    partial class Main
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
            this.panelActionsContainer = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.penPropButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelActionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionsContainer
            // 
            this.panelActionsContainer.Controls.Add(this.button6);
            this.panelActionsContainer.Controls.Add(this.penPropButton);
            this.panelActionsContainer.Controls.Add(this.button4);
            this.panelActionsContainer.Controls.Add(this.button3);
            this.panelActionsContainer.Controls.Add(this.button2);
            this.panelActionsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActionsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelActionsContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActionsContainer.Name = "panelActionsContainer";
            this.panelActionsContainer.Size = new System.Drawing.Size(124, 338);
            this.panelActionsContainer.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 88);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 22);
            this.button6.TabIndex = 4;
            this.button6.Text = "Clear Whiteboard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // penPropButton
            // 
            this.penPropButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.penPropButton.Location = new System.Drawing.Point(0, 66);
            this.penPropButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penPropButton.Name = "penPropButton";
            this.penPropButton.Size = new System.Drawing.Size(124, 22);
            this.penPropButton.TabIndex = 3;
            this.penPropButton.Text = "Pen Properties";
            this.penPropButton.UseVisualStyleBackColor = true;
            this.penPropButton.Click += new System.EventHandler(this.penPropButton_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 44);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 22);
            this.button4.TabIndex = 2;
            this.button4.Text = "Line";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 22);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 22);
            this.button3.TabIndex = 1;
            this.button3.Text = "Circle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 22);
            this.button2.TabIndex = 0;
            this.button2.Text = "Square";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(124, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 338);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelActionsContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Draw App";
            this.panelActionsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActionsContainer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button penPropButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}