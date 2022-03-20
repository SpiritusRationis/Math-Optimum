using System;
using System.Collections.Generic;
using info.lundin.math;

namespace Optimum
{
    internal class Function
    {
        private string Func;
        private List<string> VarName;
        private List<double> VarValue;
        public Function(Data data)
        {
            Func = data.Function;
            VarName = data.VarName;
            VarValue = data.VarValue;
        }

        public void SetValues(List<double> Value)
        {
            if (this.VarValue.Count == Value.Count)
            {
                this.VarValue.Clear();

                foreach (double value in Value)
                {
                    this.VarValue.Add(value);
                }
            }
        }
        public void SetValue(int index, double value)
        {
            if (index >= 0 && index < this.VarValue.Count)
            {
                this.VarValue[index] = value;
            }
        }

        public List<double> GetValues()
        {
            return this.VarValue;
        }

        public double GetValue(int index)
        {
            return this.VarValue[index];
        }

        public SpatialPoint GetSpatialPoint()
        {
            double[] point = new double[this.VarValue.Count];
            for (int i = 0; i < point.Length; i++)
            {
                point[i] = this.VarValue[i];
            }
            return new SpatialPoint(point);
        }

        public double f(SpatialPoint point)
        {
            try
            {
                ExpressionParser expressionParser = new ExpressionParser();

                for (int i = 0; i < VarValue.Count; i++)
                {
                    expressionParser.Values.Add(VarName[i], point.GetPoint()[i]);
                }

                expressionParser.Parse(Func);
                Expression expression = expressionParser.Expressions[Func];
                return expressionParser.EvalExpression(expression);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

        }
    }
}
