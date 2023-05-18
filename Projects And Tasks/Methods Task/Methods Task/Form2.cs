using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Methods_Task
{
    public partial class Form2 : Form
    {
        double Size = 0;
        public Form2()
        {
            InitializeComponent();



        }

        int NumProject = Form1.numberProject;
        int NumCondtion = Form1.numberCondtion;


        double[] array = new double[(Form1.numberCondtion * Form1.numberProject)];

        List<double> list = new List<double>();
        List<double> list2 = new List<double>();


        private void Form2_Load(object sender, EventArgs e)
        {
            for (int j = 1; j < NumCondtion + 1; j++)
            {
                dataGridView1.Columns.Add("Condition" + j, "Condition :>" + j);
            }

            for (int i = 1; i < NumProject + 1; i++)
            {
                dataGridView1.Rows.Add("Project :>" + i);
            }

        }


       

        double big = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            
            groupBox2.Text = "Pick The Max Value For Or Each Alternative";

            list.Clear();
            list2.Clear();
            dataGridView2.Rows.Clear();

            dataGridView2.Columns.Add("Condition", "Value");

            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    big = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());

                    list.Add(big);
                }
                list2.Add(list.Max());

                //dataGridView2.Rows.Add("Project => " + (k + 1) + " -Max Value => " + list.Max());

                dataGridView2.Rows.Add("Project => " + (k+1));
                dataGridView2.Rows[k].Cells[1].Value = list.Max();

                list.Clear();
            }

            label1.Text ="Then Pick The Alternative With Max Payoff " + list2.Max().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            groupBox2.Text = "Pick The Min Value For Or Each Alternative";

            list.Clear();
            list2.Clear();
            dataGridView2.Rows.Clear();

            dataGridView2.Columns.Add("Condition", "Value");

            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    big = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());

                    list.Add(big);
                }
                list2.Add(list.Min());

                //dataGridView2.Rows.Add("Project => " + (k + 1) + " -Max Value => " + list.Max());

                dataGridView2.Rows.Add("Project => " + (k + 1));
                dataGridView2.Rows[k].Cells[1].Value = list.Min();

                list.Clear();
            }

            label1.Text = "Then Pick The Alternative With Min Payoff " + list2.Max().ToString();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

        
}

