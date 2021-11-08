using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MMM_GUI1
{
    class CoordTranslator
    {
        const double padding_coef_arg = 0;
        const double padding_coef_val = 0;
        double ay;
        double by;
        double ax;
        double bx;
        double x;
        double y;
        public CoordTranslator(double min_val, double max_val, double min_arg, double max_arg, double width, double height)
        {
            double padding_val = (max_val - min_val) * padding_coef_val;
            double padding_arg = (max_arg - min_arg) * padding_coef_arg;
            min_val -= padding_val;
            max_val += padding_val;
            min_arg -= padding_arg;
            max_arg += padding_arg;
            ax = min_arg != max_arg ? width / (max_arg - min_arg) : 0;
            bx = min_arg != max_arg ? -ax * min_arg : width / 2;
            ay = min_val != max_val ? height / (min_val - max_val) : 0;
            by = min_val != max_val ? -ay * max_val : height / 2;
            x = min_arg;
            y = min_val;
        }

        public PointF Translate(PointF input_point)
        {
            PointF result = new PointF
            {
                X = (float)(input_point.X * ax + bx),
                Y = (float)(input_point.Y * ay + by)
            };
            return result;
        }

        public double TranslateX(double X)
        {
            return X * ax + bx;
        }

        public double TranslateY(double Y)
        {
            return Y * ay + by;
        }

        public PointF ReverseTranslate(PointF input_point)
        {
            PointF result = new PointF
            {
                X = ax != 0 ? (float)((input_point.X - bx) / ax) : (float)x,
                Y = ay != 0 ? (float)((input_point.Y - by) / ay) : (float)y
            };
            return result;
        }

        public double ReverseTranslateX(double X)
        {
            return ax != 0 ? (X - bx) / ax : x;
        }

        public double ReverseTranslateY(double Y)
        {
            return ay != 0 ? (Y - by) / ay : y;
        }
    }
}
