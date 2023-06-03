using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CNPOPSOFT.Controls
{
    public partial class VistaClock : UserControl
    {
        Timer timer = new Timer();
        Timer timer2 = new Timer();
        int h, m, s;
        float secondAngel = 0f;

        public enum VistaClockStyle
        {
            Silver, Black, Red, Flower
        }

        #region Properties

        private bool showSecond = true;
        /// <summary>
        /// specify the second hand is visible or not.
        /// </summary>
        public bool ShowSecond
        {
            get { return showSecond; }
            set { showSecond = value; this.Invalidate(); }
        }

        private bool secondSpring = true;
        /// <summary>
        /// specify the spring affect is on/off.
        /// </summary>
        public bool SecondSpring
        {
            get { return secondSpring; }
            set { secondSpring = value; this.Invalidate(); }
        }

        private VistaClockStyle style = VistaClockStyle.Silver;
        /// <summary>
        /// Clock visual type
        /// </summary>
        public VistaClockStyle Style
        {
            get { return style; }
            set { style = value; this.Invalidate(); }
        }

        private CustomRectangle positionRect = new CustomRectangle();
        /// <summary>
        /// position rectangle
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CustomRectangle PositionRect
        {
            get { return positionRect; }
            set { positionRect = value; this.Invalidate(); }
        }

        #region ReadOnly Properties

        private Image Image
        {
            get
            {
                if (style == VistaClockStyle.Black)
                    return global::CNPOPSOFT.Controls.Properties.Resources.trad;
                else if (style == VistaClockStyle.Silver)
                    return global::CNPOPSOFT.Controls.Properties.Resources.system;
                else if (style == VistaClockStyle.Red)
                    return global::CNPOPSOFT.Controls.Properties.Resources.modern;
                else
                    return global::CNPOPSOFT.Controls.Properties.Resources.flower;
            }
        }

        private Image ImageH
        {
            get
            {
                if (style == VistaClockStyle.Black)
                    return global::CNPOPSOFT.Controls.Properties.Resources.trad_h;
                else if (style == VistaClockStyle.Silver)
                    return global::CNPOPSOFT.Controls.Properties.Resources.system_h;
                else if (style == VistaClockStyle.Red)
                    return global::CNPOPSOFT.Controls.Properties.Resources.modern_h;
                else
                    return global::CNPOPSOFT.Controls.Properties.Resources.flower_h;
            }
        }

        private Image ImageM
        {
            get
            {
                if (style == VistaClockStyle.Black)
                    return global::CNPOPSOFT.Controls.Properties.Resources.trad_m;
                else if (style == VistaClockStyle.Silver)
                    return global::CNPOPSOFT.Controls.Properties.Resources.system_m;
                else if (style == VistaClockStyle.Red)
                    return global::CNPOPSOFT.Controls.Properties.Resources.modern_m;
                else
                    return global::CNPOPSOFT.Controls.Properties.Resources.flower_m;
            }
        }

        private Image ImageS
        {
            get
            {
                if (style == VistaClockStyle.Black)
                    return global::CNPOPSOFT.Controls.Properties.Resources.trad_s;
                else if (style == VistaClockStyle.Silver)
                    return global::CNPOPSOFT.Controls.Properties.Resources.system_s;
                else if (style == VistaClockStyle.Red)
                    return global::CNPOPSOFT.Controls.Properties.Resources.modern_s;
                else
                    return global::CNPOPSOFT.Controls.Properties.Resources.flower_s;
            }
        }

        private Image ImageDot
        {
            get
            {
                if (style == VistaClockStyle.Black)
                    return global::CNPOPSOFT.Controls.Properties.Resources.trad_dot;
                else if (style == VistaClockStyle.Silver)
                    return global::CNPOPSOFT.Controls.Properties.Resources.system_dot;
                else if (style == VistaClockStyle.Red)
                    return global::CNPOPSOFT.Controls.Properties.Resources.modern_dot;
                else
                    return global::CNPOPSOFT.Controls.Properties.Resources.flower_dot;
            }
        }

        private Image ImageHighlight
        {
            get
            {
                if (style == VistaClockStyle.Black)
                    return global::CNPOPSOFT.Controls.Properties.Resources.trad_highlights;
                else if (style == VistaClockStyle.Silver)
                    return global::CNPOPSOFT.Controls.Properties.Resources.system_highlights;
                else if (style == VistaClockStyle.Red)
                    return global::CNPOPSOFT.Controls.Properties.Resources.modern_highlights;
                else
                    return global::CNPOPSOFT.Controls.Properties.Resources.flower_highlights;
            }
        }
        #endregion
        #endregion

        #region Methods

        public VistaClock()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;

            timer.Interval = 1000;
            timer.Enabled = true;
            timer2.Interval = 30;
            timer2.Enabled = false;

            this.MouseUp += new MouseEventHandler(VistaClock_MouseUp);
            this.Paint += new PaintEventHandler(Clock_Paint);
            this.Resize += new EventHandler(Clock_Resize);
            timer.Tick += new EventHandler(timer_Tick);
            timer2.Tick += new EventHandler(timer2_Tick);

            Clock_Resize(this, null);
            timer_Tick(timer, null);
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            secondAngel = s / 60f * 360f;
            this.Invalidate(positionRect.ToRectangle());
            timer2.Enabled = false;
        }

        void VistaClock_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuShowSpring.Checked = secondSpring;
                mnuShowSecond.Checked = showSecond;
                contextMenuStrip1.Show(this, e.Location);
            }
        }

        void Clock_Resize(object sender, EventArgs e)
        {
            if (positionRect == null) positionRect = new CustomRectangle(); 
            positionRect.Width = (int)Image.Width;
            positionRect.Height = (int)Image.Height;
            positionRect.Top = (int)(this.ClientSize.Height < Image.Height ? 0 : (this.ClientSize.Height - Image.Height) / 2f);
            positionRect.Left = (int)(this.ClientSize.Width < Image.Width ? 0 : (this.ClientSize.Width - Image.Width) / 2f);

            this.Invalidate();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (DesignMode) return;
            UpdateDateTime();

            if (showSecond)
            {
                if (!secondSpring)
                    secondAngel = s / 60f * 360f;
                else
                    secondAngel = s / 60f * 360f + 4;
            }

            if (showSecond && secondSpring) timer2.Enabled = true;

            this.Invalidate(positionRect.ToRectangle());
        }

        private void UpdateDateTime()
        {
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;
        }

        void Clock_Paint(object sender, PaintEventArgs e)
        {
            //Draw Background
            e.Graphics.DrawImage(Image, positionRect.ToRectangle());

            //Hour
            e.Graphics.TranslateTransform(positionRect.X + positionRect.Width / 2f, positionRect.Y + positionRect.Height / 2f);
            e.Graphics.RotateTransform(h / 12f * 360 + m / 60f * 360f / 12f);
            e.Graphics.DrawImage(ImageH, -6.5f, -64.5f, 13, 129);
            //Minute
            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(positionRect.X + positionRect.Width / 2f, positionRect.Y + positionRect.Height / 2f);
            e.Graphics.RotateTransform(m / 60f * 360);
            e.Graphics.DrawImage(ImageM, -6.5f, -64.5f, 13, 129);
            //Second
            if (showSecond)
            {
                e.Graphics.ResetTransform();
                e.Graphics.TranslateTransform(positionRect.X + positionRect.Width / 2f, positionRect.Y + positionRect.Height / 2f);
                e.Graphics.RotateTransform(secondAngel);
                e.Graphics.DrawImage(ImageS, -6.5f, -64.5f, 13, 129);
            }
            //Dot
            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(positionRect.X + positionRect.Width / 2f, positionRect.Y + positionRect.Height / 2f);
            e.Graphics.DrawImage(ImageDot, -6.5f, -64.5f, 13, 129);
            e.Graphics.ResetTransform();

            //Glass affect
            e.Graphics.DrawImage(ImageHighlight, positionRect.ToPointF());
        }


        #endregion

        #region Menu Event Handler

        private void mnuSilver_Click(object sender, EventArgs e)
        {
            style = VistaClockStyle.Silver;
            this.Invalidate();
        }

        private void mnuBlack_Click(object sender, EventArgs e)
        {
            style = VistaClockStyle.Black;
            this.Invalidate();
        }

        private void mnuRed_Click(object sender, EventArgs e)
        {
            style = VistaClockStyle.Red;
            this.Invalidate();
        }

        private void mnuFlower_Click(object sender, EventArgs e)
        {
            style = VistaClockStyle.Flower;
            this.Invalidate();
        }

        private void mnuShowSecond_Click(object sender, EventArgs e)
        {
            mnuShowSecond.Checked = !mnuShowSecond.Checked;
            showSecond = mnuShowSecond.Checked;
            this.Invalidate();
        }

        private void mnuShowSpring_Click(object sender, EventArgs e)
        {
            mnuShowSpring.Checked = !mnuShowSpring.Checked;
            secondSpring = mnuShowSpring.Checked;
            this.Invalidate();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            mnuBlack.Checked = (style == VistaClockStyle.Black);
            mnuFlower.Checked = (style == VistaClockStyle.Flower);
            mnuRed.Checked = (style == VistaClockStyle.Red);
            mnuSilver.Checked = (style == VistaClockStyle.Silver);
            mnuShowSecond.Checked = showSecond;
            mnuShowSpring.Checked = secondSpring;
        }

        #endregion

    }
}
