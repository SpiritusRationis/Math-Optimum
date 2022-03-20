using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum
{
    internal class NelderMeadMethod
    {
        private double alpha, beta, gamma, lambda;
        private SpatialPoint[] simplex;
        private Function Func;
        private string Description;
        private double Epseelon;
        private SpatialPoint[] Result;
        private bool _cancelled;

        public NelderMeadMethod(Data data, double epseelon, double alpha = 1, double beta = 0.5, double gamma = 2, double lambda = 1)
        {
            Func = new Function(data);
            Epseelon = epseelon;
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
            this.lambda = lambda;
            simplex = new SpatialPoint[data.VarName.Count + 1];
            simplex[0] = Func.GetSpatialPoint();
        }

        public void MethodOfNelderMead()
        {
            SpatialPoint C, R, E, S;
            GetSimplex();
            SpatialPoint[] CurrentSimplex = simplex;
            int IterationNumber = 0;

            try
            {
                while (true)
                {
                    AddDescription(IterationNumber, CurrentSimplex);

                    C = null;
                    R = null;
                    E = null;
                    S = null;

                    CurrentSimplex = Sort(CurrentSimplex);

                    C = GetCenterOfGravity(CurrentSimplex); // центр тяжести
                    R = (1 + alpha) * C - alpha * CurrentSimplex[CurrentSimplex.Length - 1];    //отражение

                    if (Func.f(R) < Func.f(CurrentSimplex[0]))
                    {
                        E = gamma * R + (1 - gamma) * C;

                        if (Func.f(E) < Func.f(R))
                        {
                            CurrentSimplex[CurrentSimplex.Length - 1] = E;
                        }
                        else
                        {
                            CurrentSimplex[CurrentSimplex.Length - 1] = R;
                        }

                        if (GetSigma(CurrentSimplex) < Epseelon)
                            break;
                    }
                    else
                    {
                        if (Func.f(R) < Func.f(CurrentSimplex[CurrentSimplex.Length - 2]))
                        {
                            CurrentSimplex[CurrentSimplex.Length - 1] = R;

                            if (GetSigma(CurrentSimplex) < Epseelon)
                                break;
                        }
                        else
                        {
                            if (Func.f(R) < Func.f(CurrentSimplex[simplex.Length - 1]))
                            {
                                SpatialPoint tmp = CurrentSimplex[simplex.Length - 1];
                                CurrentSimplex[simplex.Length - 1] = R;
                                R = tmp;

                                if (GetSigma(CurrentSimplex) < Epseelon)
                                    break;
                            }
                            else
                            {
                                S = beta * CurrentSimplex[simplex.Length - 1] + (1 - beta) * C;

                                if (Func.f(S) < Func.f(CurrentSimplex[simplex.Length - 1]))
                                {
                                    CurrentSimplex[simplex.Length - 1] = S;
                                }
                                else
                                {

                                    for (int i = 1; i < simplex.Length; i++)    // перерасчет симплекса
                                    {
                                        CurrentSimplex[i] = CurrentSimplex[0] + (CurrentSimplex[i] - CurrentSimplex[0]) / 2;
                                    }
                                }
                            }
                        }
                    }

                    if (_cancelled)
                        break;
                    IterationNumber++;
                }

                CurrentSimplex = Sort(CurrentSimplex);
                Result = CurrentSimplex;
                Completed(_cancelled);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cancel();
                Result = null;
                Description = null;
                Completed(_cancelled);
            }

 
        }

        public string GetDescription()
        {
            return Description;
        }

        public SpatialPoint[] GetResult()
        {
            return Result;
        }

        public void Cancel()
        {
            _cancelled = true;
        }

        public event Action<bool> Completed;

        private void GetSimplex()
        {
            double[] delta = GetDelta();
            for (int i = 1; i < simplex[0].GetSpatial() + 1; i++)
            {
                double[] p = new double[simplex[0].GetSpatial()];
                for (int j = 0; j < simplex[0].GetSpatial(); j++)
                {
                    if (j == i - 1)
                    {
                        p[j] = simplex[0].GetPoint()[j] + delta[1];
                    }
                    else
                    {
                        p[j] = simplex[0].GetPoint()[j] + delta[0];
                    }
                    simplex[i] = new SpatialPoint(p);
                }
            }

        }
        private double[] GetDelta()
        {
            double[] delta = new double[2];
            delta[0] = (Math.Sqrt(simplex[0].GetSpatial() + 1) + simplex[0].GetSpatial() - 1) * lambda / (simplex[0].GetSpatial() * Math.Sqrt(2));
            delta[1] = (Math.Sqrt(simplex[0].GetSpatial() + 1) - 1) * lambda / (simplex[0].GetSpatial() * Math.Sqrt(2));
            return delta;
        }


        private SpatialPoint[] Sort(SpatialPoint[] simplex)
        {
            SpatialPoint[] result = simplex;
            SpatialPoint tmp;
            for (int i = 0; i < simplex.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < simplex.Length - (i + 1); j++)
                {
                    if (Func.f(simplex[j]) > Func.f(simplex[j + 1]))
                    {
                        flag = false;
                        tmp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = tmp;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            return result;
        }

        private SpatialPoint GetCenterOfGravity(SpatialPoint[] simplex)
        {
            SpatialPoint result = simplex[0] - simplex[0];

            for (int i = 0; i < simplex.Length - 1; i++)
            {
                result += simplex[i];
            }

            return result / (simplex.Length - 1);

        }

        private double GetSigma(SpatialPoint[] simplex)
        {
            double avg = 0;
            double sigma = 0;

            for (int i = 0; i < simplex.Length; i++)
            {
                avg += Func.f(simplex[i]);
            }

            avg /= simplex.Length;

            for (int i = 0; i < simplex.Length; i++)
            {
                sigma += Math.Pow(Func.f(simplex[i]) - avg, 2);
            }
           
            return Math.Sqrt(sigma / simplex.Length);
        }

        private void AddDescription(int index, SpatialPoint[] simplex)
        {
            Description += "/------------------------------------------------/";
            Description += Environment.NewLine;
            Description += "Iteration: " + index.ToString();
            Description += Environment.NewLine;

            for (int i = 0; i < simplex.Length; i++)
            {
                Description += simplex[i].ToString() + Environment.NewLine;
            }

            Description += "F[" + index.ToString() + "] (min) = " + Func.f(simplex[0]).ToString() + Environment.NewLine;
            Description += "Iteration " + index.ToString() + " completed" + Environment.NewLine;
            Description += "/------------------------------------------------/";
            Description += Environment.NewLine;
            Description += Environment.NewLine;
        }
    }
}