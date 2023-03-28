using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpark
{
    public partial class CarSection : Form
    {
        public CarSection()
        {
            InitializeComponent();
        }

        private void CarSection_Load(object sender, EventArgs e)
        {

        }
        public void MarkCheckbox(int sectionNumber)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox && control.Name == "checkBox" + sectionNumber.ToString())
                {
                    ((CheckBox)control).Checked = true;
                    break;
                }
            }
        }
        
    }
}
