using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Allow managed code to call unmanaged functions that are implemented in a DLL
using System.Runtime.InteropServices;
namespace CsharpwinformClient
{
    public partial class Form1 : Form
    {
        private double c = 10;
        [DllImport(@"C:\Users\iali\Documents\visual studio 2015\Projects\Win32Project1\Debug\MathFuncDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = Add(c, c);
            label2.Text = c.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
