using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDBForm
{
    public partial class InsertForm : Form
    {
        private ContextDB _context = null;
        public InsertForm()
        {
            InitializeComponent();
            _context = new ContextDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var price = txtPrice.Text; // all value are string

            ProductEntity entity = new ProductEntity() { 
                Product = txtProduct.Text,
                Price = Double.Parse(price),
                Descriptions = txtDesp.Text,
            };

            _context.Add(entity);
            _context.SaveChanges();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
