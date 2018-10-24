using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNet.NeuronalNetwork
{
    class InputNeuron : Neuron
    {
        #region fields
        private float _Value = 0;
        #endregion

        #region methods
        public void SetValue(float value)
        {
            _Value = value;
        }
        #endregion

        #region overridden methods
        public override float GetValue()
        {
            return _Value;
        }
        #endregion


    }
}
