using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Panel = System.Windows.Controls.Panel;

namespace cw3
{
    public partial class Form1 : Form
    {
        private double _k = 0;
        private int _pointCount = 1;
        private int _firstPoint = 0;
        private int _pointScale = 1;

        private INumericMethod _gaussion;
        private Action _gaussionAction;

        private INumericMethod _monteCarlo;
        private Action _monteCarlAction;

        private INumericMethod _rectangle;
        private Action _rectangleAction;

        private List<INumericMethod> _methods;
        private List<Action> _recalculationActions;

        public Form1()
        {
            _pointCount = 199;
            _firstPoint = -_pointCount / 2;
            _pointScale = (_pointCount + 1) / 2;
            InitializeComponent();
            errorField.Text = 0.00001.ToString();
            InitChart();
            InitMethods();
            InitRecalculationAction();
        }

        private void InitRecalculationAction()
        {
            _rectangleAction = () =>
            {
                if (RectChB.Checked)
                {
                    RectLabel.Text = _rectangle.ApplayTo(d => Function(d)).ToString();
                    return;
                }
                RectLabel.Text = "";
            };

            _gaussionAction = () =>
            {
                if (GaussianChB.Checked)
                {
                    GaussionResult.Text = _gaussion.ApplayTo(d => Function(d)).ToString();
                    return;
                }
                GaussionResult.Text = "";
            };

            _monteCarlAction = () =>
            {
                if (MonteCarloResultChB.Checked)
                {
                    MonteCarloResult.Text = _monteCarlo.ApplayTo(d => Function(d)).ToString();
                    return;
                }
                MonteCarloResult.Text = "";
            };
            this._recalculationActions = new List<Action>()
            {
                _gaussionAction,
                _monteCarlAction,
                _rectangleAction
            };
        }

        private void InitMethods()
        {
            double error = 0.01;
            Double.TryParse(errorField.Text, out error);

            _rectangle = new RectangleMethod()
            {
                LowerAge = -1,
                UpperAge = 1,
                ErorValue = error
            };

            _gaussion = new GauseMethod()
            {
                LowerAge = -1,
                UpperAge = 1,
                ErorValue = error
            };
            _monteCarlo = new MonteCarloMethod()
            {
                LowerAge = -1,
                UpperAge = 1,
                ErorValue = error
            };

            this._methods = new List<INumericMethod>()
                {
                    _gaussion,
                    _monteCarlo,
                    _rectangle
                }
                ;
        }

        private void InitChart()
        {
            Brush chartBack = new SolidColorBrush(Color.FromRgb(200, 80, 45));
            Chart.Background = chartBack;
            Chart.DataTooltip = null;
            Chart.Hoverable = false;

            Chart.AxisX.Clear();
            Axis axis = new Axis
            {
                Title = "X",
                Labels = Enumerable.Range(_firstPoint, _pointCount)
                    .Select(d => ((double) d / (double) _pointScale).ToString())
                    .ToList(),
                Separator = new Separator
                {
                    Visibility = Visibility.Collapsed
                }
            };
            Chart.AxisX.Add(axis);
            LineSeries s1 = new LineSeries
            {
                Title = "Function",
                Values = new ChartValues<ObservableValue>(),
                PointGeometry = null,
                Fill = new SolidColorBrush(Color.FromRgb(158, 45, 200)),
                StrokeThickness = 0,
            };
            LineSeries s2 = new LineSeries
            {
                Values = new ChartValues<ObservableValue>(),
                PointGeometry = null,
                Fill = chartBack,
                StrokeThickness = 0
            };
            Panel.SetZIndex(s1, -2);
            Panel.SetZIndex(s2, -1);
            Chart.Series = new SeriesCollection
            {
                s1,
                s2,
            };
            for (int i = 0; i < _pointCount; i++)
            {
                Chart.Series[0].Values.Add(new ObservableValue(0));
                Chart.Series[1].Values.Add(new ObservableValue(0));
            }
            UpdateChart();
        }

        private double Function(double x)
        {
            double ax = x * (2.6 + 0.04 * _k);
            return Math.Cos(ax) / ((0.3 + x * x) * Math.Sqrt(1 - x * x));
        }

        private void kParams_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar)
                         && !char.IsDigit(e.KeyChar))
                        || e.KeyChar == '-'
                        || e.KeyChar == '.'
                        || e.KeyChar == ',';
        }

        private void errorField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar)
                         && !char.IsDigit(e.KeyChar)
                         && ((e.KeyChar == ',' || e.KeyChar == '.') && e.KeyChar != System.Globalization.CultureInfo
                                 .CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0]))
                        || e.KeyChar == '-';
        }

        private void cartesianChart1_ChildChanged(object sender,
            System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
        }

        private void kParams_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(kParams.Text, out _k);
            this.UpdateChart();
            Recalculate();
        }

        private void Recalculate()
        {
            _recalculationActions?.ForEach(action => action());
        }

        private void UpdateChart()
        {
            for (int i = 0; i < _pointCount; i++)
            {
                double value = Function(((double) i + _firstPoint) / _pointScale);
                if (value > 0)
                {
                    ((ObservableValue) Chart.Series[0].Values[i]).Value = value;
                    ((ObservableValue) Chart.Series[1].Values[i]).Value = 0;
                }
                else
                {
                    ((ObservableValue) Chart.Series[0].Values[i]).Value = 0;
                    ((ObservableValue) Chart.Series[1].Values[i]).Value = value;
                }
            }
        }

        private void GaussianChB_CheckedChanged(object sender, EventArgs e)
        {
            _gaussionAction();
        }

        private void errorField_TextChanged(object sender, EventArgs e)
        {
            double error = 0.01;
            Double.TryParse(errorField.Text, out error);
            _methods?.ForEach(method => method.ErorValue = error);
            Recalculate();
        }

        private void MonteCarloResultChB_CheckedChanged(object sender, EventArgs e)
        {
            _monteCarlAction();
        }

        private void RectChB_CheckedChanged(object sender, EventArgs e)
        {
            _rectangleAction();
        }
    }
}