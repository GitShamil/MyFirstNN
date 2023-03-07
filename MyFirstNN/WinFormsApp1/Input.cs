using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;
using System.IO;

namespace WinFormsApp1
{
    class Input
    {
        public (double[], double)[] _trainset = new (double[], double)[]//да-да, массив кортежей из 2 массивов
          {
          };

        public (double[], double)[] Trainset { get => _trainset; }//такие няшные свойства нынче в C# 7
        public Form1 form;
        public static Input GetInput1(Form1 form)
        {

            Input input = new();
            List<(double[], double)> mas = new();
            string[] files1 =Directory.GetFiles("One");
            for (int i = 0; i < files1.Length; i++)
            {
                List<double> frames= GetFrames(files1[i]);        
                mas.Add((frames.ToArray(), 1));
            }
            string[] files2 = Directory.GetFiles("Two");
            for (int i = 0; i < files2.Length; i++)
            {
                List<double> frames = GetFrames(files2[i]);
                mas.Add((frames.ToArray(), 0));
            }
            string[] files3 = Directory.GetFiles("Three");
            for (int i = 0; i < files3.Length; i++)
            {
                List<double> frames = GetFrames(files3[i]);
                mas.Add((frames.ToArray(), 0));
            }
            var k = mas.ToArray();
         // Shuffle(k);
            input._trainset = k;
            input.form = form;
            return input;
        }
        public static Input GetInput2(Form1 form)
        {

            Input input = new();
            List<(double[], double)> mas = new();
            string[] files1 = Directory.GetFiles("One");
            for (int i = 0; i < files1.Length; i++)
            {
                List<double> frames = GetFrames(files1[i]);
                mas.Add((frames.ToArray(), 0));
            }
            string[] files2 = Directory.GetFiles("Two");
            for (int i = 0; i < files2.Length; i++)
            {
                List<double> frames = GetFrames(files2[i]);
                mas.Add((frames.ToArray(), 1));
            }
            string[] files3 = Directory.GetFiles("Three");
            for (int i = 0; i < files3.Length; i++)
            {
                List<double> frames = GetFrames(files3[i]);
                mas.Add((frames.ToArray(), 0));
            }
            var k = mas.ToArray();
            // Shuffle(k);
            input._trainset = k;
            input.form = form;
            return input;
        }

        public static Input GetInput3(Form1 form)
        {

            Input input = new();
            List<(double[], double)> mas = new();
            string[] files1 = Directory.GetFiles("One");
            for (int i = 0; i < files1.Length; i++)
            {
                List<double> frames = GetFrames(files1[i]);
                mas.Add((frames.ToArray(), 0));
            }
            string[] files2 = Directory.GetFiles("Two");
            for (int i = 0; i < files2.Length; i++)
            {
                List<double> frames = GetFrames(files2[i]);
                mas.Add((frames.ToArray(), 0));
            }
            string[] files3 = Directory.GetFiles("Three");
            for (int i = 0; i < files3.Length; i++)
            {
                List<double> frames = GetFrames(files3[i]);
                mas.Add((frames.ToArray(), 1));
            }
            var k = mas.ToArray();
            // Shuffle(k);
            input._trainset = k;
            input.form = form;
            return input;
        }

        private static List<double> GetFrames(string filename)
        {
            List<float[]> samples = new();
            using (WaveFileReader wave = new(filename))
            {
                for (int g = 0; g < wave.SampleCount; g++)
                {
                    samples.Add(wave.ReadNextSampleFrame());
                }
            }
            List<double> frames = new();
            for (int j = 0; j < 50; j++)
            {
                double sum = 0;
                for (int g = j * samples.Count / 51; g < (j + 2) * samples.Count / 51; g++)
                {
                    sum += samples[g][0] * samples[g][0];
                }
                sum = Math.Sqrt(sum * 500 / (samples.Count));
                frames.Add(sum);
            }
            return frames;
        }

        public static void Shuffle<T>(T[] arr)
        {
            Random rand = new Random();

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
        public static Input GetInput2nj(Form1 form)
        {
            Input input = new();
            List<(double[], double)> mas = new();
               List<double> frames = GetFrames("Example/exampl.wav");
            mas.Add((frames.ToArray(), 1));             
            input._trainset = mas.ToArray();
            input.form = form;
            return input;
        }
    }
}
