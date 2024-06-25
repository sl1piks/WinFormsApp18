using System.Windows.Forms;
using System;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        private List<Button>listButt;  
        public Form1()
        {
            InitializeComponent();
            listButt = new List<Button>()
            {
                button1, button2, button3, button4, button5
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            listButt = listButt.OrderBy(x => gg(x.Location.X, x.Location.Y)).ToList();
            for (int i = 0; i < listButt.Count; i++) listButt[i].Text = i.ToString();

        }
        private double gg(int x, int y) => Math.Sqrt(x*x + y*y);
    }
}
