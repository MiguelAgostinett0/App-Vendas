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

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lv_lista.View = View.Details;
            lv_lista.GridLines = true;
            lv_lista.FullRowSelect = true;

            lv_lista.Columns.Add("Código", 100, HorizontalAlignment.Left);
            lv_lista.Columns.Add("Descrição", 100, HorizontalAlignment.Left);
            lv_lista.Columns.Add("Unidade", 100, HorizontalAlignment.Left);
            lv_lista.Columns.Add("Valor", 100, HorizontalAlignment.Left);
            lv_lista.Columns.Add("Quantidade em estoque", 100, HorizontalAlignment.Left);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.ShowDialog();
        }

        private void lv_lista_DoubleClick(object sender, EventArgs e)
        {

        }


        private void lv_lista_ItemActivate(object sender, EventArgs e)
        {
            String des = lv_lista.SelectedItems[0].SubItems[0].Text;
            String cod = lv_lista.SelectedItems[0].SubItems[1].Text;
            String uni = lv_lista.SelectedItems[0].SubItems[2].Text;
            String vv = lv_lista.SelectedItems[0].SubItems[3].Text;
            String qnt = lv_lista.SelectedItems[0].SubItems[4].Text;

            textBox1.Text = des;
            textBox2.Text = cod;
            textBox3.Text = uni;
            textBox4.Text = vv;
            textBox5.Text = qnt;

            Form1 form1 = new Form1(this);
            form1.ShowDialog();
        }

        private void lv_lista_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                for (int i = lv_lista.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem li = lv_lista.SelectedItems[i];
                    lv_lista.Items.Remove(li);
                }

            var total = 0m;
            for (int i = 0; i < lv_lista.Items.Count; i++)
            {
                total += decimal.Parse(lv_lista.Items[i].SubItems[3].Text);
            }
            var ttl = 0m;
            for (int i = 0; i < lv_lista.Items.Count; i++)
            {
                ttl += decimal.Parse(lv_lista.Items[i].SubItems[4].Text);
            }

            label1.Text = total.ToString("N2");
            label2.Text = ttl.ToString("N2");
        }
    }
}
