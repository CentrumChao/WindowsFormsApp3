using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class testList
        {
            public double x { get; set; }
            public double y { get; set; }
            public double total { get; set; }
           // public List<string> z { get; set; }
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            var aa = new List<testList>();
           
            var bb = "2";
            var cc = 0;

            var dd = new List<double>();

            dd.Add(0.1);

            for (int i = 1; i<=9;i++)
            {
                for(int j=1; j<=9; j++)
                {                   
                    aa.Add(new testList { x = i, y = j, total=i*j});
                    bb = bb + aa[cc].x.ToString()+"*"+aa[cc].y.ToString()+"="+aa[cc].total.ToString()+'\t';
                    cc++;
                }
                bb = bb + '\n';
                
                //aa.Add(new testList { x = i, y = i, z = new List<string>() });
                //aa[i].z.Add(i.ToString());
                //MessageBox.Show(aa[i].x.ToString());
                //MessageBox.Show(aa[i].z[0]);
            }
            MessageBox.Show(bb);


        }
    }
}
