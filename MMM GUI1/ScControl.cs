using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Calculations;
using System.Globalization;

namespace MMM_GUI1
{
    public partial class ScControl : UserControl
    {
        const bool TESTMODE = true;
        const double ZOOM = 0.1;
        const double OFFSETX = 0.1;
        const double OFFSETY = 0.085;
        const int UNITSX = 8;
        const int UNITSY = 5;
        string fstring;
        double A;
        double a;
        double m;
        double k;
        double stop;
        double step;
        double currMinVal;
        double currMaxVal;
        double currMinArg;
        double currMaxArg;
        SysData sys;
        string err;
        bool inputOK;
        bool valsOK;
        bool argsOK;
        CoordTranslator translator;
        readonly List<bool> drawnGraphs = Enumerable.Repeat(false, 5).ToList();
        private static readonly CultureInfo enUS = new CultureInfo("en-US");
        private static readonly Dictionary<int, Color> graphIdxToColor = new Dictionary<int, Color>
        {
            {0, Color.Red },
            {1, Color.Green },
            {2, Color.Blue },
            {3, Color.Orange },
            {4, Color.Magenta }
        };
        [Flags]
        private enum Updates
        { 
            RANGES = 0b1, 
            VALTEXT = 0b10, 
            ARGTEXT = 0b100, 
            TRANSLATOR = 0b1000,
            GRAPH = 0b10000,
            ALL = RANGES | VALTEXT| ARGTEXT | TRANSLATOR | GRAPH
        }
        private enum Directions
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
            CENTER,
        }

        public ScControl()
        {
            InitializeComponent();
            checkBoxViewU.Tag = 0;
            checkBoxViewE.Tag = 1;
            checkBoxViewY.Tag = 2;
            checkBoxViewX1.Tag = 3;
            checkBoxViewX2.Tag = 4;
            checkBoxViewU.ForeColor = graphIdxToColor[0];
            checkBoxViewE.ForeColor = graphIdxToColor[1];
            checkBoxViewY.ForeColor = graphIdxToColor[2];
            checkBoxViewX1.ForeColor = graphIdxToColor[3];
            checkBoxViewX2.ForeColor = graphIdxToColor[4];
            buttonMoveDown.Tag = Directions.DOWN;
            buttonMoveUp.Tag = Directions.UP;
            buttonMoveLeft.Tag = Directions.LEFT;
            buttonMoveRight.Tag = Directions.RIGHT;
            buttonMoveCenter.Tag = Directions.CENTER;
            buttonZoomIn.Tag = ZOOM;
            buttonZoomOut.Tag = -ZOOM / (1 - 2 * ZOOM);
            inputOK = false;
            valsOK = true;
            argsOK = true;
            err = "";
            Update(Updates.VALTEXT | Updates.ARGTEXT);
            if (TESTMODE)
            {
                textBoxInputFunction.Text = "step(t-1)";
                textBoxStopTime.Text = "10";
                textBoxTimestep.Text = "0.01";
                textBoxParamA.Text = "1";
                textBoxParamK.Text = "1";
                textBoxParamA2.Text = "1";
                textBoxParamM.Text = "1";
            }
        }

        private void InitGraphics(Graphics g)
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
        private void DrawGraphs(PaintEventArgs e)
        {
            InitGraphics(e.Graphics);
            List<Dictionary<double,double>> rawDatas = new List<Dictionary<double, double>> { sys.U, sys.E, sys.Y, sys.X1, sys.X2 };
            var points = rawDatas.Where((rawData, idx) => drawnGraphs[idx]).Select(a => a.Select(b => translator.Translate(new PointF((float)b.Key, (float)b.Value))));
            var pens = graphIdxToColor.Where((rawData, idx) => drawnGraphs[idx]).Select(a=>a.Value).Select(b=>new Pen(b));
            foreach (Pen pen in pens)
            {
                pen.Width = 2f;
            }
            for (int i = 0; i < pens.Count(); i++)
            {
                e.Graphics.DrawLines(pens.ToArray()[i], points.ToArray()[i].ToArray());
            }
        }
        private void DrawAxes(PaintEventArgs e)
        {
            var brush = new SolidBrush(Color.Black);
            var font = new Font("Arial", 8);
            Pen pen = new Pen(Color.Black);
            pen.Width = 1.5f;
            InitGraphics(e.Graphics);
            var scaleVal = getScale(currMinVal, currMaxVal, UNITSY);
            var scaleArg = getScale(currMinArg, currMaxArg, UNITSX);
            var pointsVal = scaleVal.Select(b=> new PointF(0.0f, (float)translator.TranslateY(b)));
            var pointsArg = scaleArg.Select(b => new PointF((float)translator.TranslateX(b), graphArea.Height));
            e.Graphics.DrawLine(pen, 0.0f, graphArea.Height, graphArea.Width, graphArea.Height);
            e.Graphics.DrawLine(pen, 0.0f, graphArea.Height, 0.0f, 0.0f);
            int i = 0;
            foreach (PointF p in pointsVal)
            {
                e.Graphics.DrawLine(pen, p, new PointF(p.X + 5.0f, p.Y));
                e.Graphics.DrawString(scaleVal[i].ToString("G2", enUS), font, brush, new PointF(p.X, p.Y - font.Size*1.6f));
                i++;
            }
            i = 0;
            foreach (PointF p in pointsArg)
            {
                e.Graphics.DrawLine(pen, p, new PointF(p.X, p.Y - 5.0f));
                if ((p.X > 0.1 * graphArea.Width / UNITSX || scaleArg[i] != scaleVal[i]) && p.X != 0.0f) e.Graphics.DrawString(scaleArg[i].ToString("G2", enUS), font, brush, new PointF(p.X, p.Y - font.Size * 1.7f));
                i++;
            }
        }
        private void DrawGrid(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray);
            pen.Width = 1.5f;
            InitGraphics(e.Graphics);
            var pointsVal = getScale(currMinVal, currMaxVal, UNITSY).Select(b => new PointF(0.0f, (float)translator.TranslateY(b)));
            var pointsArg = getScale(currMinArg, currMaxArg, UNITSX).Select(b => new PointF((float)translator.TranslateX(b), graphArea.Height));
            e.Graphics.DrawLine(pen, 0.0f, graphArea.Height, graphArea.Width, graphArea.Height);
            e.Graphics.DrawLine(pen, 0.0f, graphArea.Height, 0.0f, 0.0f);
            foreach (PointF p in pointsVal)
            {
                e.Graphics.DrawLine(pen, p, new PointF(graphArea.Width, p.Y));
            }
            foreach (PointF p in pointsArg)
            {
                e.Graphics.DrawLine(pen, p, new PointF(p.X, 0));
            }
        }

        private void UpdateTranslator()
        {
            if (sys != null) //drawnGraphs.Aggregate((a, b) => a || b) && 
            {
                translator = new CoordTranslator(currMinVal, currMaxVal, currMinArg, currMaxArg, graphArea.Width, graphArea.Height - 2);
            }
        }
        private void UpdateRanges()
        {
            currMinArg = checkBoxArgAuto.Checked ? GetMinArg() : currMinArg;
            currMaxArg = checkBoxArgAuto.Checked ? GetMaxArg() : currMaxArg;
            currMinVal = checkBoxValAuto.Checked ? GetMinVal() : currMinVal;
            currMaxVal = checkBoxValAuto.Checked ? GetMaxVal() : currMaxVal;
        }
        private void UpdateRangeTextBoxes(bool arg = true, bool val = true)
        {
            if (arg)
            {
                textBoxArgMin.Text = currMinArg.ToString("F03", enUS);
                textBoxArgMax.Text = currMaxArg.ToString("F03", enUS);
            }
            if (val)
            {
                textBoxValMin.Text = currMinVal.ToString("F03", enUS);
                textBoxValMax.Text = currMaxVal.ToString("F03", enUS);
            }

        }
        private void Update(Updates what)
        {
            foreach (Updates up in Enum.GetValues(typeof(Updates)).Cast<Updates>().Where(update => (update & what) == update))
            {
                switch (up)
                {
                    case Updates.RANGES:
                        UpdateRanges();
                        break;
                    case Updates.VALTEXT:
                        UpdateRangeTextBoxes(false, true);
                        break;
                    case Updates.ARGTEXT:
                        UpdateRangeTextBoxes(true, false);
                        break;
                    case Updates.TRANSLATOR:
                        UpdateTranslator();
                        break;
                    case Updates.GRAPH:
                        graphArea.Refresh();
                        break;
                }
            }
        }

        private void GraphArea_Paint(object sender, PaintEventArgs e)
        {
            if (EverythingOK())
            {
                DrawGrid(e);
                DrawGraphs(e);
                DrawAxes(e);
            }
            else
            {
                var brush = new SolidBrush(Color.Red);
                var drawFont = new Font("Consolas", 16);
                e.Graphics.DrawString(err, drawFont, brush, 0.0f, 0.0f);
            }
        }

        private void ScControl_Resize(object sender, EventArgs e)
        {
            Update(Updates.GRAPH | Updates.TRANSLATOR);
        }

        private void InputFunctionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fstring = textBoxInputFunction.Text;
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                fstring = textBoxInputFunction.Text;
                stop = double.Parse(textBoxStopTime.Text, NumberStyles.Float, enUS);
                step = double.Parse(textBoxTimestep.Text, NumberStyles.Float, enUS);
                A = double.Parse(textBoxParamA.Text, NumberStyles.Float, enUS);
                a = double.Parse(textBoxParamA2.Text, NumberStyles.Float, enUS);
                m = double.Parse(textBoxParamM.Text, NumberStyles.Float, enUS);
                k = double.Parse(textBoxParamK.Text, NumberStyles.Float, enUS);
                try
                {
                    sys = new SysData(m, k, A, a, stop, step, fstring);
                    err = "Input set correctly, but there are still some problems with other fields";
                    inputOK = true;
                    Update(Updates.ALL);
                }
                catch (SysData.SysDataException ex)
                {
                    err = ex.Message;
                    inputOK = false;
                    Update(Updates.GRAPH);
                }
            }
            catch (FormatException)
            {
                ValidateChildren();
                err = "One of the fields is empty or not a number!";
                inputOK = false;
                Update(Updates.GRAPH);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxParamA.Text = "";
            textBoxParamA2.Text = "";
            textBoxParamM.Text = "";
            textBoxParamK.Text = "";
            textBoxStopTime.Text = "";
            textBoxTimestep.Text = "";
            textBoxInputFunction.Text = "";
            sys = null;
            inputOK = false;
            err = "";
            Update(Updates.GRAPH);
        }

        private void GraphArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (EverythingOK())
            {
                var p = translator.ReverseTranslate(new PointF(e.X, e.Y));
                labelCursor.Text = p.X.ToString() + ';' + p.Y.ToString();
            }    
        }

        private void CheckBoxView_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            drawnGraphs[(int)cb.Tag] = cb.Checked;
            try
            { 
                Update(Updates.ALL);
            }
            catch (NullReferenceException)
            {
                err = "Cannot show any graphs, input has not been set!";
                Update(Updates.GRAPH);
            }
        }

        
        private double GetMinVal()
        {
            if (drawnGraphs.Aggregate((a, b) => a || b))
            {
                List<List<double>> Vals = new List<List<double>> { sys.U.Values.ToList(), sys.E.Values.ToList(), sys.Y.Values.ToList(), sys.X1.Values.ToList(), sys.X2.Values.ToList() };
                return Vals.Where((val, idx) => drawnGraphs[idx]).Select(a => a.Aggregate(double.MaxValue, Math.Min)).Aggregate(double.MaxValue, Math.Min);
            }
            return 0;
        }
        private double GetMaxVal()
        {
            if (drawnGraphs.Aggregate((a, b) => a || b))
            {
                List<List<double>> Vals = new List<List<double>> { sys.U.Values.ToList(), sys.E.Values.ToList(), sys.Y.Values.ToList(), sys.X1.Values.ToList(), sys.X2.Values.ToList() };
                return Vals.Where((val, idx) => drawnGraphs[idx]).Select(a => a.Aggregate(-double.MaxValue, Math.Max)).Aggregate(-double.MaxValue, Math.Max);
            }
            return 0;
        }
        private double GetMinArg()
        {
            return sys.U.Keys.Aggregate(double.MaxValue, Math.Min);
        }
        private double GetMaxArg()
        {
            return sys.U.Keys.Aggregate(-double.MaxValue, Math.Max);
        }



        private void ButtonArgSet_Click(object sender, EventArgs e)
        {
            
            try
            {
                currMinArg = double.Parse(textBoxArgMin.Text, NumberStyles.Float, enUS);
                currMaxArg = double.Parse(textBoxArgMax.Text, NumberStyles.Float, enUS);
                checkBoxArgAuto.Checked = false;
                err = "Argument range set correctly, but there are still some problems with other fields";
                argsOK = true;
                Update(Updates.ALL);
            }
            catch (FormatException)
            {
                err = "Min or max argument is empty or not a number!";
                argsOK = false;
                Update(Updates.GRAPH);
            }
            catch (NullReferenceException)
            {
                err = "Argument range set correctly, but input has not been set!";
                argsOK = true;
                Update(Updates.GRAPH);
            }
        }

        private void ButtonValSet_Click(object sender, EventArgs e)
        {
            try
            {
                currMinVal = double.Parse(textBoxValMin.Text, NumberStyles.Float, enUS);
                currMaxVal = double.Parse(textBoxValMax.Text, NumberStyles.Float, enUS);
                checkBoxValAuto.Checked = false;
                err = "Value range set correctly, but there are still some problems with other fields";
                valsOK = true;
                Update(Updates.ALL);
            }
            catch (FormatException)
            {
                err = "Min or max argument is empty or not a number!";
                valsOK = false;
                Update(Updates.GRAPH);
            }
            catch (NullReferenceException)
            {
                err = "Value range set correctly, but input has not been set!";
                valsOK = true;
                Update(Updates.GRAPH);
            }
        }

        private void CheckBoxArgAuto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxArgAuto.Checked)
                {
                    Update(Updates.RANGES | Updates.ARGTEXT | Updates.TRANSLATOR | Updates.GRAPH);
                }
            }
            catch (NullReferenceException)
            {
                err = "Cannot calculate automatic argument range, input has not been set!";
                Update(Updates.GRAPH);
            }
        }

        private void CheckBoxValAuto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxValAuto.Checked)
                {
                    Update(Updates.RANGES | Updates.VALTEXT | Updates.TRANSLATOR | Updates.GRAPH);
                }
            }
            catch (NullReferenceException)
            {
                err = "Cannot calculate automatic value range, input has not been set!";
                Update(Updates.GRAPH);
            }
        }

        private void MoveRange(Directions dir)
        {
            double offsetArg = (currMaxArg - currMinArg) * OFFSETX;
            double offsetVal = (currMaxVal - currMinVal) * OFFSETY;
            switch (dir)
            {
                case Directions.UP:
                    currMaxVal += offsetVal;
                    currMinVal += offsetVal;
                    checkBoxValAuto.Checked = false;
                    break;
                case Directions.DOWN:
                    currMaxVal -= offsetVal;
                    currMinVal -= offsetVal;
                    checkBoxValAuto.Checked = false;
                    break;
                case Directions.LEFT:
                    currMaxArg -= offsetArg;
                    currMinArg -= offsetArg;
                    checkBoxArgAuto.Checked = false;
                    break;
                case Directions.RIGHT:
                    currMaxArg += offsetArg;
                    currMinArg += offsetArg;
                    checkBoxArgAuto.Checked = false;
                    break;
                case Directions.CENTER:
                    checkBoxValAuto.Checked = true;
                    checkBoxArgAuto.Checked = true;
                    break;
            }
        }

        private void ZoomRange (double zoom)
        {
            double offsetArg = (currMaxArg - currMinArg) * zoom;
            double offsetVal = (currMaxVal - currMinVal) * zoom;
            currMaxVal -= offsetVal;
            currMinVal += offsetVal;
            currMaxArg -= offsetArg;
            currMinArg += offsetArg;
            checkBoxValAuto.Checked = false;
            checkBoxArgAuto.Checked = false;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            try
            {
                var cb = (Button)sender;
                MoveRange((Directions)cb.Tag);
                Update(Updates.ALL);
            }
            catch (NullReferenceException)
            {
                err = "Input has not been set!";
                Update(Updates.GRAPH);
            }
            
        }

        private void ButtonZoom_Click(object sender, EventArgs e)
        {
            try
            {
                var cb = (Button)sender;
                ZoomRange((double)cb.Tag);
                Update(Updates.ALL);
            }
            catch (NullReferenceException)
            {
                err = "Input has not been set!";
                Update(Updates.GRAPH);
            }
        }

        private bool EverythingOK()
        {
            return inputOK && (valsOK || checkBoxValAuto.Checked) && (argsOK || checkBoxArgAuto.Checked);
        }

        private List<double> getScale(double min, double max, int n)
        {
            List<double> res = new List<double>();
            if (max == min)
            {
                res.Add(max);
                return res;
            }
            double start;
            double i;
            double unit = (max - min) / n;
            int powVal = 0;
            if (unit >= 10)
            {
                while (unit >= 10)
                {
                    powVal++;
                    unit /= 10;
                }
            }
            else if (unit < 1 && unit > 0)
            {
                while (unit < 1)
                {
                    powVal--;
                    unit *= 10;
                }
            }
            unit = Math.Round(unit);
            unit *= Math.Pow(10, powVal);
            
            if (max * min <= 0) start = 0;
            else  start = unit * n * Math.Sign(max);
            i = start;
            while (i < max)
            {
                res.Add(i);
                i += unit;
            }
            i = start;
            while (i >= min)
            {
                res.Add(i);
                i -= unit;
            }

            return res.Distinct().OrderBy(c => c).ToList();
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
      
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            string errmsg = "";
            TextBox a = (TextBox)sender;
            if (!double.TryParse(a.Text, NumberStyles.Float, enUS, out double s))
            {
                if (a.Text.Length == 0)
                {
                    errmsg = "This field cannot be empty";
                }
                else if (a.Text.Contains(','))
                {
                    errmsg = "Please use \".\" as a floating point";
                }
                else
                {
                    errmsg = "This field must be a number";
                }
            }
            errorProvider1.SetError(a, errmsg);
        }

        private void TextBoxStopTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxParamA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}