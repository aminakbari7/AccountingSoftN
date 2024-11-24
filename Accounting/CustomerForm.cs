using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoftN.Accounting
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        Boolean is_del=false;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            save_cancel_buttom();
            this.customerTableAdapter1.Fill(this.ads1.Customer);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            save_cancel_buttom();
            this.bindingSource1.EndEdit();
            int rv;
            rv=this.customerTableAdapter1.Update(this.ads1.Customer);
            if(rv>0)
            {
                save_cancel_buttom();
                MessageBox.Show("hello");
            }


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            is_del = false;
            new_del_buttom();
            this.bindingSource1.AddNew();
        }
        private void  new_del_buttom()
        {
            this.AddButton.Enabled = false;
            this.EditButton.Enabled = false;
            this.DeleteButton.Enabled = false;

            this.SaveButton.Enabled = true;
            this.CancelButton.Enabled = true;
            this.dataGridView1.Enabled = false;
            
            if(is_del==false)
            {
                this.groupBox1.Enabled = true;
            }
            else
            {
                this.groupBox1.Enabled = false;
            }


        }
        private void save_cancel_buttom()
        {
            this.AddButton.Enabled = true;
            this.EditButton.Enabled = true;
            this.DeleteButton.Enabled = true;

            this.SaveButton.Enabled = false;
            this.CancelButton.Enabled = false;
            this.dataGridView1.Enabled = true;
            this.groupBox1.Enabled = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new_del_buttom();
        }

        private void DeleteButton_Click(object sender, EventArgs e)

        {
            is_del = true;
            new_del_buttom();
            this.bindingSource1.RemoveCurrent();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            save_cancel_buttom();
            this.bindingSource1.CancelEdit();
            this.ads1.Customer.RejectChanges();
        }
    }
}
