using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;

namespace neiro1
{
    public partial class Form1 : Form
    {
        Getrecord record;
        int name = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonForFirstWord_Click(object sender, EventArgs e)
        {
            MakeRecord();
        }

        private void buttonForSecondWord_Click(object sender, EventArgs e)
        {
            MakeRecord();
        }

        private void buttonForThirdWord_Click(object sender, EventArgs e)
        {
            MakeRecord();
        }
        private void MakeRecord()
        {
                record = new Getrecord("exampl");
                record.StartRecord();

            name++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            record.EndRecord();
        }
    }
}
