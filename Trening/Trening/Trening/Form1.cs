using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treningBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.treningDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treningDataSet.Trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.treningDataSet.Trening);

        }
    }
}
