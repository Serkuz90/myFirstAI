using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAI
{
    public class Neuron
    {
        public double output;

        List<double> inputs = new List<double>();
        List<double> weights = new List<double>();
        //public Neuron(List<double> someInputs)
        //{
        //    inputs.AddRange(someInputs.ToArray());
        //}

        public Neuron(List<double> someInputs, List<double> someWeights)
        {
            inputs.AddRange(someInputs.ToArray());
            weights.AddRange(someWeights.ToArray());
        }

        public Neuron(List<InputNeuron> inputNeurons, List<double> someWeights)
        {
            for (int i = 0; i < inputNeurons.Count; i++)
            {
                inputs.Add(inputNeurons[i].input);
                
            }
            weights.AddRange(someWeights.ToArray());
        }



        //public double WeightSum(List<double> inputs, List<double> weights) // Взвешанная сумма
        //{
        //    double sum = 0;
        //    for (int i = 0; i <= inputs.Count; i++)
        //    {
        //        sum = sum + (inputs[i] * weights[i]);
        //    }

        //    return sum;
        //}

        public double WeightSum() // Взвешанная сумма
        {
            double sum = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum = sum + (inputs[i] * weights[i]);
            }

            return sum;
        }


        public double ActivationFunc(double sum) //Функция активации
        {
            //double activationFuncResult = 1 / (1 + Math.Exp(-alpha * sum));
            double activationFuncResult = sum / (1 + Math.Abs(sum));

            return activationFuncResult;
        }
    }
}
