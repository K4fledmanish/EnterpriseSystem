using DataControl;
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
    public partial class MediaForm : Form
    {
        public MediaForm()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            // Showing table datas in DataGrid
            MediaLibraryLogic mediaLibraryLogic = new MediaLibraryLogic();

            dataGridView.DataSource = mediaLibraryLogic.MediaList();
        }

        private void btngenre_Click(object sender, EventArgs e)
        {
            if (txtgenre.Text == "")
            {
                MessageBox.Show("Please input value");
            }
            else
            {



                MediaLibraryLogic libraryLogic = new MediaLibraryLogic();

                try
                {
                    dataGridView.DataSource = libraryLogic.ListByGenre(txtgenre.Text);
                }

                catch (Exception)
                {
                    // Showing null if the input User inserted is not in database.
                    dataGridView.DataSource = libraryLogic.ListByGenre("");
                }
                txtgenre.Clear();
            }
        }

        private void btnbudget_Click(object sender, EventArgs e)
        {
            if (txtbudget.Text == "")
            {
                MessageBox.Show("Please input value");
            }
            else
            {


                MediaLibraryLogic libraryLogic = new MediaLibraryLogic();
                try // try catch statement
                {
                    dataGridView.DataSource = libraryLogic.ListByBudget(Int32.Parse(txtbudget.Text));

                }
                catch (Exception )
                {
                    dataGridView.DataSource = libraryLogic.ListByBudget(0);

                }

                txtbudget.Clear();
            }
        }

        private void txtpublishyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpublishyear_Click(object sender, EventArgs e)
        {
            if (txtpublishyear.Text == "")
            {
                MessageBox.Show("Please input value");
            }
            else
            {


                MediaLibraryLogic libraryLogic = new MediaLibraryLogic();
                try // try catch statement
                {
                    dataGridView.DataSource = libraryLogic.ListByPublishYear(Int32.Parse(txtpublishyear.Text));

                }
                catch (Exception )
                {
                    dataGridView.DataSource = libraryLogic.ListByPublishYear(0);

                }
                txtpublishyear.Clear();
            }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
