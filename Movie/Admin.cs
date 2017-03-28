using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void movieTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.MovieT' table. You can move, or remove it, as needed.
            this.movieTTableAdapter.Fill(this.database1DataSet.MovieT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.movieTBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.movieTBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.releaseDateTextBox.Visible = false;
            iDTextBox.ReadOnly = false;
            genreTextBox.ReadOnly = false;
            soldTextBox.ReadOnly = false;
            titleTextBox.ReadOnly = false;
            descriptionTextBox.ReadOnly = false;
            ratingTextBox.ReadOnly = false;
            picture_PathTextBox.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieTBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.database1DataSet.MovieT);
            this.releaseDateTextBox.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.movieTBindingSource.RemoveCurrent();
            this.Validate();
            this.movieTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(database1DataSet);

        }
    }
}
