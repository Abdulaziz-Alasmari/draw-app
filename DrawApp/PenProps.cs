using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawApp
{
    public partial class PenProps : Form
    {
        private Pen newPen;

        public Pen NewPen
        {
            get { return newPen; }
        }

        public PenProps()
        {
            InitializeComponent();
            this.ColorComboBox.SelectedIndex = 0;
            this.StyleComboBox.SelectedIndex = 0;
            this.PenWidthNumUpDown.Value = 3;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            newPen = new Pen(
                Color.FromName((string)this.ColorComboBox.SelectedItem),
                (float)this.PenWidthNumUpDown.Value
                );
            NewPen.DashStyle = setDashStyle();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private DashStyle setDashStyle() 
        {
            switch (this.StyleComboBox.SelectedIndex) 
            {
                case 3:
                    return DashStyle.DashDot;
                case 2:
                    return  DashStyle.Dash;
                case 1:
                    return DashStyle.Dot;
                default:
                    return DashStyle.Solid;
            }
        }

    }
}
