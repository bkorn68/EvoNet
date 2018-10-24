using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNet.NeuronalNetwork
{
    public abstract class Neuron
    {
        #region methods
        public abstract float GetValue();

        public static float Sigmoid(float x)
        {
            float et = (float)Math.Pow(Math.E, x);
            return et / (1 + et);
        }
        #endregion

    }
}
