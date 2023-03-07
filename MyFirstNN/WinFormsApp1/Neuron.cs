using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Neuron
    {
        public Neuron(List<Neuron> neurons)
        {
            if (neurons != null)
            {
                Random rand = new();
                Dictionary<Neuron, double> ties = new();
                foreach (var item in neurons)
                {
                    ties.Add(item, rand.NextDouble() * 2 - 1);
                }
                Ties = ties;
            }
        }

        public double outSignale = 0;
        public void CalculateSignale()
        {
            if (Ties != null)
            {
                outSignale = 0;
                foreach (var item in Ties)
                {
                    outSignale += item.Value * item.Key.outSignale;
                }
                outSignale = ActivateFunc(outSignale);

            }
        }

        public static  double ActivateFunc(double signale)
        {
            return 1 / (1 + Math.Exp(-signale));
        }

        public Dictionary<Neuron, double> Ties { get; }
    }
}
