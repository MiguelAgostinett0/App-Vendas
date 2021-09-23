using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1(Form2 frm2)
        { 
            InitializeComponent();
            form2 = frm2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_des.Text = form2.textBox2.Text;
            tb_cod.Text = form2.textBox1.Text;
            tb_uni.Text = form2.textBox3.Text;
            tb_vv.Text = form2.textBox4.Text;
            tb_qnt.Text = form2.textBox5.Text;
        }

        private void add(string des, string cod, string uni, string vv, string qnt)
        {
            String[] row = { des, cod, uni, vv, qnt };
            ListViewItem ite = new ListViewItem(row);

            form2.lv_lista.Items.Add(ite);            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira uma descrição", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o código", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a unidade", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o valor da venda", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a quantidade em estoque", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            add(tb_cod.Text, tb_des.Text, tb_uni.Text, tb_vv.Text, tb_qnt.Text);

            tb_des.Text = "";
            tb_cod.Text = "";
            tb_uni.Text = "";
            tb_vv.Text = "";
            tb_qnt.Text = "";

            var total = 0m;
            for (int i = 0; i < form2.lv_lista.Items.Count; i++)
            {
                total += decimal.Parse(form2.lv_lista.Items[i].SubItems[3].Text);
            }

            var ttl = 0m;
            for (int i = 0; i < form2.lv_lista.Items.Count; i++)
            {
                ttl += decimal.Parse(form2.lv_lista.Items[i].SubItems[4].Text);
            }

            form2.label1.Text = total.ToString("N2");
            form2.label2.Text = ttl.ToString("N2");

            form2.Refresh();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira uma descrição", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o código", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a unidade", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o valor da venda", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tb_des.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a quantidade em estoque", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListView.SelectedListViewItemCollection produto = this.form2.lv_lista.SelectedItems;
            foreach (ListViewItem item in produto)
            {
                item.SubItems[0].Text = tb_cod.Text;    
                item.SubItems[1].Text = tb_des.Text;
                item.SubItems[2].Text = tb_uni.Text;
                item.SubItems[3].Text = tb_vv.Text;
                item.SubItems[4].Text = tb_qnt.Text;
            }

            tb_des.Text = "";
            tb_cod.Text = "";
            tb_uni.Text = "";
            tb_vv.Text = "";
            tb_qnt.Text = "";

            var ttl = 0m;
            var total = 0m;
            for (int i = 0; i < form2.lv_lista.Items.Count; i++)
            {
                total += decimal.Parse(form2.lv_lista.Items[i].SubItems[3].Text); 
                ttl += decimal.Parse(form2.lv_lista.Items[i].SubItems[4].Text);
            }

            form2.label1.Text = total.ToString("N2");
            form2.label2.Text = ttl.ToString("N2");
            form2.Refresh();
            Close();
        }
    }
}
