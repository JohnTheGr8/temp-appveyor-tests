﻿using System.Collections.Generic;
using System.Windows.Controls;

namespace Flow.Launcher.Plugin.Sys
{
    public partial class SysSettings : UserControl
    {
        public SysSettings(List<Result> Results)
        {
            InitializeComponent();

            foreach (var Result in Results)
            {
                lbxCommands.Items.Add(Result);
            }
        }
    }
}
