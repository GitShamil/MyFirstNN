using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Layer
    {

        public Layer(List<Neuron> neurons)
        {
            Neurons = neurons;
        }

        public List<Neuron> Neurons { get; }
    }
}
