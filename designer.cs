using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;

namespace test_2
{
    class designer : Panel
    {
        private Color _firstFillColor;
        private Color _secondFillColor;
        private LinearGradientMode _gradientDiraction;

        [Description("Первый цвет для град заполнения"), DefaultValue(typeof(Color), "")]

        public Color ColorFillFirst
        {
            get => _firstFillColor;
            set => _firstFillColor = value;
        }

        [Description("Второй цвет для град заполнения"), DefaultValue(typeof(Color), "")]

        public Color ColorFillSecond
        {
            get => _secondFillColor;
            set => _secondFillColor = value;
        }

        [Description("Тип напрваления шрад"), DefaultValue(LinearGradientMode.ForwardDiagonal)]

        public LinearGradientMode GradientDirection
        {
            get => _gradientDiraction;
            set => _gradientDiraction = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var lgb = new LinearGradientBrush(ClientRectangle, _firstFillColor, _secondFillColor, _gradientDiraction);
            var graphics = e.Graphics;
            graphics.FillRectangle(lgb, ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            base.OnPaint(e);
        }
    }
}
