using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Net
    {
        public Net(List<Layer> layers)
        {
            Layers = layers;
        }

        public List<Layer> Layers { get; }

        public void Train(Input input)
        {

            for (int k = 0; k < 20000/(input.Trainset.Length+1); k++)
            {
                for (int i = 0; i < input.Trainset.Length; i++)
                {
                    for (int g = 0; g < Layers[0].Neurons.Count; g++)
                    {
                        Layers[0].Neurons[g].outSignale = input.Trainset[i].Item1[g];
                    }
                    foreach (var layer in Layers)
                    {
                        foreach (var neuron in layer.Neurons)
                        {
                            neuron.CalculateSignale();
                        }
                    }
                    ChangeTies(Layers[Layers.Count - 1].Neurons[0], Layers[Layers.Count - 1].Neurons[0].outSignale - input.Trainset[i].Item2);
                }

            }
            for (int i = 0; i < input.Trainset.Length; i++)
            {
                for (int g = 0; g < Layers[0].Neurons.Count; g++)
                {
                    Layers[0].Neurons[g].outSignale = input.Trainset[i].Item1[g];
                }
                foreach (var layer in Layers)
                {
                    foreach (var neuron in layer.Neurons)
                    {
                        neuron.CalculateSignale();
                    }
                }
                input.form.richTextBox1.Text +=i+" "+ Layers[Layers.Count - 1].Neurons[0].outSignale + Environment.NewLine;
            }
        }


        private void ChangeTies(Neuron neuron, double error)
        {
            if (neuron.Ties == null)
                return;
            double weights_delta = error * neuron.outSignale * (1 - neuron.outSignale);
            foreach (var item in neuron.Ties.Keys)
            {
                neuron.Ties[item] -= item.outSignale * weights_delta * 0.5;
                ChangeTies(item, neuron.Ties[item] * weights_delta);
            }
        }

        public static Net GetNet()
        {
            List<Layer> layers = new();
            List<Neuron> neurons1 = new();
            for (int i = 0; i < 50; i++)
            {
                neurons1.Add(new Neuron(null));
            }
            layers.Add(new Layer(neurons1));
            List<Neuron> neurons2 = new();
            for (int i = 0; i < 8; i++)
            {
                neurons2.Add(new Neuron(neurons1));
            }
            layers.Add(new Layer(neurons2));
            List<Neuron> neurons3 = new();
            for (int i = 0; i < 3; i++)
            {
                neurons3.Add(new Neuron(neurons2));
            }
            layers.Add(new Layer(neurons3));
            List<Neuron> neurons4 = new();
            for (int i = 0; i < 1; i++)
            {
                neurons4.Add(new Neuron(neurons3));
            }
            layers.Add(new Layer(neurons4));
            Net net = new(layers);
            return net;
        }
        public double Check(Input input)
        {

                for (int g = 0; g < Layers[0].Neurons.Count; g++)
                {
                    Layers[0].Neurons[g].outSignale = input.Trainset[0].Item1[g];
                }
                foreach (var layer in Layers)
                {
                    foreach (var neuron in layer.Neurons)
                    {
                        neuron.CalculateSignale();
                    }
                }
                return Layers[Layers.Count - 1].Neurons[0].outSignale;
            //   input.form.richTextBox1.Text =  Layers[Layers.Count - 1].Neurons[0].outSignale + Environment.NewLine;
        }
    }
}
