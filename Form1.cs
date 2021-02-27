using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace _171180002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            //prosesler alınıyor ve listboxa ekleniyor...
            string prosesler;

            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                prosesler = theprocess.ProcessName;
                prosesler_listbox.Items.Add(prosesler);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //SHOWS NUMBER OF THREADS...
        private void sahipOlduğuİplikSayısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (Equals(theprocess.ProcessName, prosesler_listbox.SelectedItem) == true)
                {
                    MessageBox.Show("Number of threads:" + Convert.ToString(theprocess.Threads.Count));

                }
            }
        }

        //SHOWS MEMORY USAGE...
        private void bellekKullanımMiktarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (Equals(theprocess.ProcessName, prosesler_listbox.SelectedItem) == true)
                {
                    float bellekkullanimmiktari = Convert.ToSingle((theprocess.WorkingSet64 / 1024) / 1024);
                    MessageBox.Show("Memory usage amount in MB:" + Convert.ToString(bellekkullanimmiktari));

                }
            }
        }

        //SHOWS PROCESSOR USAGE (PERCENT)...
        private void işlemciKullanımYüzdesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
                if (Equals(theprocess.ProcessName, prosesler_listbox.SelectedItem) == true)
                {
                    
                   PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Privileged Time", "_Total");
                    for(int i=0; i < 2;i++)
                    {
                        Thread.Sleep(1000);
                        MessageBox.Show("Processor Usage: %" + (theCPUCounter.NextValue()/10));
    
                    }
                    
                }
        }


        //PROCESS KILLER
        private void buProsesiÖldürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();


            foreach (Process theprocess in processlist)
            {

                if (Equals(theprocess.ProcessName, prosesler_listbox.SelectedItem) == true)
                {
                    theprocess.Kill();
                    MessageBox.Show("Killing the process is success!");
                }
                

            }
        }
    }
}
 