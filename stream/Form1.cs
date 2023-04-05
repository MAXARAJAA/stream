using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array1 = new int[] { 1, 2, 3, 5, 4 };
            int[] array2 = new int[] { 4, 5, 6, 1, 2 };
            int[] array3 = new int[] { 7, 8, 9, 4, 5 };

            SaveAsThread saveAsThread1 = new SaveAsThread(array1, "textfile1.txt");
            SaveAsThread saveAsThread2 = new SaveAsThread(array2, "textfile2.txt");
            SaveAsThread saveAsThread3 = new SaveAsThread(array3, "textfile3.txt");
            saveAsThread1.Start();
            saveAsThread2.Start();
            saveAsThread3.Start();
        }
    }
}
