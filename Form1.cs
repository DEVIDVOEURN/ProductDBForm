using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ProductDBForm.ContextDB;

namespace ProductDBForm
{
    public partial class Form1 : Form
    {
        private ContextDB _context = null;
        public Form1()
        {
            InitializeComponent();
            _context = new ContextDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductEntity> products = _context.tbProduct.ToList<ProductEntity>();

            dataGridView1.DataSource = products;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();

            if(insertForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = null; // reset state of datagridview
                List<ProductEntity> products = _context.tbProduct.ToList<ProductEntity>();
                dataGridView1.DataSource = products;
            }
        }
    }
}
