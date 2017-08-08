using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Allow managed code to call unmanaged functions that are implemented in a DLL
using System.Runtime.InteropServices;

namespace testCSharpInterface
{
    public partial class Form1 : Form
    {
        private double c = 10;

        [DllImport("C:\\testCreateDLLcpp\\Debug\\MathFuncsDll.dll", CallingConvention = CallingConvention.Cdecl)]
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
    }
}