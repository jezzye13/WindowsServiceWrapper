using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceWrapper
{
    public partial class Service1 : ServiceBase
    {
        private Process m_process;
        private readonly string m_executablePath = @"V:\MCServerSoft\mcss.exe";

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            m_process = Process.Start(m_executablePath);
        }

        protected override void OnStop()
        {
            m_process.Kill();
        }
    }
}
