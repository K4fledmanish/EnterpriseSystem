using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibrary
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void mediaLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MediaForm mf = new MediaForm();
            mf.MdiParent = this;
            mf.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
