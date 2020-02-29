using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;


namespace SiteCheker
{
    [RunInstaller(true)]
    public partial class siteworkerinstaller : Installer
    {
        public siteworkerinstaller()
        {
            InitializeComponent();
        }
    }
}
