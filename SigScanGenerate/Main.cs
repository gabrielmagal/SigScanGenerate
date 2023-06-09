using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigScanGenerate
{
    public partial class Main : Form
    {
        private Sig SigGenerate(string aob)
        {
            Sig tmpSig = new Sig();
            string[] bytes = aob.Split(' ');
            foreach (string b in bytes)
            {
                if (b.Contains('?'))
                {
                    tmpSig.pattern += "\\x00";
                    tmpSig.mask += "?";
                }
                else
                {
                    tmpSig.pattern += "\\x" + b;
                    tmpSig.mask += "x";
                }
            }
            return tmpSig;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Sig sig = SigGenerate(txbAob.Text);
            txbPattern.Text = sig.pattern;
            txbMask.Text = sig.mask;
        }

        private void btnCopyPattern_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txbPattern.Text);
        }

        private void btnCopyMask_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txbMask.Text);
        }

        private void btnExportSig_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"\"{txbPattern.Text}\",\"{txbMask.Text}\"");
        }
    }
}
