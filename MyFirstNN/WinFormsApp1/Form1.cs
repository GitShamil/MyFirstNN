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
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Net> nets;
        GetRecord record;
        Random rand = new();
        public Form1()
        {
            InitializeComponent();
        }


        private void Teach_Click(object sender, EventArgs e)
        {
            List<Net> nets = new List<Net>();
            nets.Add(Net.GetNet());
            nets.Add(Net.GetNet());
            nets.Add(Net.GetNet());
            this.nets = nets;
            nets[0].Train(Input.GetInput1(this));
            nets[1].Train(Input.GetInput2(this));
            nets[2].Train(Input.GetInput3(this));
        }
        private void Check_Click(object sender, EventArgs e)
        {
            List<double> vs = new();
            foreach (var net in nets)
            {
                vs.Add(net.Check(Input.GetInput2nj(this)));
            }
            double max = 0;
            int ind = 0;
            for (int i = 0; i < vs.Count; i++)
            {
                if (vs[i] > max)
                {
                    max = vs[i];
                    ind = i;
                }
            }
            richTextBox1.Text = $"Слово {ind + 1}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ForRecording_Click(object sender, EventArgs e)
        {
            record = new GetRecord("One/"+rand.Next(100000)+".wav");
            record.StartRecord();
        }

        private void AgainstRecording_Click(object sender, EventArgs e)
        {
            record = new GetRecord("Two/" + rand.Next(100000) + ".wav");
            record.StartRecord();
        }

        private void StopRecording_Click(object sender, EventArgs e)
        {
            record.EndRecord();
        }

        private void ExampleRecording_Click(object sender, EventArgs e)
        {
            record = new GetRecord("Example/exampl.wav");
            record.StartRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            record = new GetRecord("Three/" + rand.Next(100000) + ".wav");
            record.StartRecord();
        }
    }
}
