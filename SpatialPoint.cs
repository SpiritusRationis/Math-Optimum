using System;

namespace Optimum
{
    internal class SpatialPoint
    {
        private double[] vector;
        private int spatial;
        public SpatialPoint(double[] point)
        {
            this.vector = point;
            spatial = point.Length;
        }

        public SpatialPoint(int spatial)
        {
            if (spatial < 1)
            {
                throw new Exception("Error of spatial");
            }
            else
            {
                this.spatial = spatial;
                vector = new double[spatial];

                for (int i = 0; i < spatial; i++)
                {
                    vector[i] = 0;
                }
            }
        }
        public double[] GetPoint()
        {
            return this.vector;
        }
        public int GetSpatial()
        {
            return spatial;
        }
        public static SpatialPoint operator +(SpatialPoint point_1, SpatialPoint point_2)
        {
            if (point_1.spatial == point_2.spatial)
            {
                double[] NewPoint = new double[point_1.spatial];
                for (int i = 0; i < NewPoint.Length; i++)
                {
                    NewPoint[i] = point_1.vector[i] + point_2.vector[i];
                }
                return new SpatialPoint(NewPoint);
            }
            else
            {
                throw new Exception("Spatial error!");
            }
        }
        public static SpatialPoint operator -(SpatialPoint point_1, SpatialPoint point_2)
        {
            if (point_1.spatial == point_2.spatial)
            {
                double[] NewPoint = new double[point_1.spatial];
                for (int i = 0; i < NewPoint.Length; i++)
                {
                    NewPoint[i] = point_1.vector[i] - point_2.vector[i];
                }
                return new SpatialPoint(NewPoint);
            }
            else
            {
                throw new Exception("Spatial error!");
            }
        }
        public static SpatialPoint operator *(double k, SpatialPoint point)
        {
            double[] NewPoint = new double[point.spatial];
            for (int i = 0; i < NewPoint.Length; i++)
            {
                NewPoint[i] = k * point.vector[i];
            }
            return new SpatialPoint(NewPoint);
        }
        public static SpatialPoint operator *(SpatialPoint point, double k)
        {
            double[] NewPoint = new double[point.spatial];
            for (int i = 0; i < NewPoint.Length; i++)
            {
                NewPoint[i] = k * point.vector[i];
            }
            return new SpatialPoint(NewPoint);
        }
        public static SpatialPoint operator /(SpatialPoint point, double k)
        {
            double[] NewPoint = new double[point.spatial];
            for (int i = 0; i < NewPoint.Length; i++)
            {
                NewPoint[i] = point.vector[i] / k;
            }
            return new SpatialPoint(NewPoint);
        }
        public override String ToString()
        {
            String s = "(";
            for (int i = 0; i < spatial; i++)
            {
                s += vector[i].ToString();
                if (i == spatial - 1)
                    break;
                s += "; ";
            }
            s += ")";
            return s;
        }
    }
}
