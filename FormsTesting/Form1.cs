using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsTesting.Models;
using SGPControlLibrary;

namespace FormsTesting
{
    public partial class Form1 : Form
    {
        SGPControlObject objectManager;
        Cliente model = new Cliente();
        public Form1()
        {
            objectManager = new SGPControlObject();



            List<string> from = new List<string>();
            from.Add("Clientes");
            List<string> hidden = new List<string>();
            this.sgpControl1 = new SGPControl(objectManager.DefineColumns(model), from, hidden, objectManager);

            InitializeComponent();
            sgpControl1.DataSource = objectManager;
            MinimumSize = new Size(sgpControl1.MinimumSize.Width + 15, sgpControl1.MinimumSize.Height);
        }
    }
}


