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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void movieTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Users_Load(object sender, EventArgs e)
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
    }
}
