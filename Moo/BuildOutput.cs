﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yalamo.Gui.Dock;

namespace Moo
{
    public partial class BuildOutput : DockContent
    {
        public BuildOutput()
        {
            InitializeComponent();
        }
        public void SetOutputContent(string content)
        {
            this.Content.Text = content;
        }
        public  void AppendContent(string content)
        {
            this.Content.Text += content;
        }
               
    
    }
}
