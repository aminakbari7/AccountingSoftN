using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoftN
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if(this.treeView1.Visible==true)this.treeView1.Visible = false;
            else this.treeView1.Visible = true;
            if(this.panel3.Visible==true)this.panel3.Visible = false;
            else this.panel3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text=DateTime.Now.ToShortDateString() + " | "+DateTime.Now.ToLongTimeString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string fn;
                fn = Application.StartupPath+"\\Data\\Pic\\"+this.comboBox1.SelectedIndex.ToString()+".jpg";
                this.BackgroundImage=Image.FromFile(fn);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.treeView1.SelectedNode.Name== "Customers")
            {
                Accounting.CustomerForm f = new Accounting.CustomerForm();
                f.Show();
            }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
           

        }
    }
}
