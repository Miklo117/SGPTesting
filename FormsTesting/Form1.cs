using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGPControlLibrary;

namespace FormsTesting
{
    public partial class Form1 : Form
    {
        TestClass dataList;
        public Form1()
        {
            InitializeComponent();
            dataList = new TestClass();
            dataList.InitDb();
            
            sgpControl1.HiddenColumns.Add("Id");
            sgpControl1.DataSource = dataList;
            MinimumSize = new Size(sgpControl1.MinimumSize.Width + 15, sgpControl1.MinimumSize.Height);
        }
    }
}


