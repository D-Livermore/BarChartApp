using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarChartApp
{
    public partial class BarChartControl : UserControl
    {
        private float[] _data;
        private const int XAxisOffset = 200; 
        private const int MaxBarHeight = 200; 

        public BarChartControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }

      
        public void SetData(float[] data)
        {
            _data = data;
            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_data == null || _data.Length == 0) return;

            Graphics g = e.Graphics;
            float maxValue = Math.Max(1, MaxAbsoluteValue(_data)); 
            float barWidth = (this.Width - 40) / _data.Length; 

           
            float xAxisY = this.Height - XAxisOffset; 
            g.DrawLine(Pens.Black, 30, xAxisY, this.Width - 10, xAxisY); 
            g.DrawLine(Pens.Black, 30, 10, 30, xAxisY); 

           
            for (int i = 0; i < _data.Length; i++)
            {
                float height = (_data[i] / maxValue) * MaxBarHeight; 
                Brush brush = new SolidBrush(Color.FromArgb(255, (i * 50) % 255, (i * 100) % 255, (i * 150) % 255));
                float xPosition = 30 + i * barWidth;

                if (_data[i] >= 0)
                {
                  
                    g.FillRectangle(brush, xPosition, xAxisY - height, barWidth - 5, height);
                    g.DrawRectangle(Pens.Black, xPosition, xAxisY - height, barWidth - 5, height); 
                }
                else
                {
                    
                    g.FillRectangle(brush, xPosition, xAxisY, barWidth - 5, -height); 
                    g.DrawRectangle(Pens.Black, xPosition, xAxisY, barWidth - 5, -height);
                }
            }

            
            for (int i = 0; i < _data.Length; i++)
            {
                g.DrawString(i.ToString(), this.Font, Brushes.Black, 30 + i * barWidth, xAxisY + 5);
            }
        }

        private float MaxAbsoluteValue(float[] data)
        {
            float max = Math.Abs(data[0]);
            for (int i = 1; i < data.Length; i++)
            {
                if (Math.Abs(data[i]) > max)
                {
                    max = Math.Abs(data[i]);
                }
            }
            return max;
        }
    }
}
