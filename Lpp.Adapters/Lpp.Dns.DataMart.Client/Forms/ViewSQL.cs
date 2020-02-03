﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lpp.Dns.DataMart.Client
{
    public partial class ViewSQL : Form
    {
        public IList<string> Sql { get; set; }
        public ViewSQL()
        {
            InitializeComponent();
        }

        private void ViewSQL_Load(object sender, EventArgs e)
        {
            foreach (string statement in Sql)
            {
                tbSQL.Text = statement + "\n\n";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
