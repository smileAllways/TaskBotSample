﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBotSample.Util;

namespace TaskBotSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyLog.Log.Debug("Test");
        }
    }
}
