using System.Windows.Forms;
using System.Drawing;

namespace Software2
{
    public class CustomForm : Form
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            this.BackColor = Color.CadetBlue;
            this.ForeColor = Control.DefaultForeColor;
        }
    }
}
