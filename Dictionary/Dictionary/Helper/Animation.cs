using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary.Helper
{
    public static class Animation
    {
        public enum Position
        {
            Top,
            Left,
            Right,
            Bottom,
            Center
        }

        public static void slideToDestination(Control container, Control destination, Control control, Position position, int delay, Action onFinish)
        {
            int directionX;
            int directionY;

            switch (position)
            {
                case Position.Center:
                    directionX = destination.Left > control.Left ? 1 : -1;
                    directionY = destination.Top > control.Top ? 1 : -1;

                    new Task(() =>
                    {
                        while (control.Left != destination.Left || control.Top != destination.Top)
                        {
                            try
                            {
                                if (control.Left != destination.Left)
                                {
                                    container.Invoke((Action)delegate ()
                                    {
                                        control.Left += directionX;
                                    });
                                }
                                if (control.Top != destination.Top)
                                {
                                    container.Invoke((Action)delegate ()
                                    {
                                        control.Top += directionY;
                                    });
                                }
                                Thread.Sleep(delay);
                            }
                            catch
                            {
                                break;
                            }
                        }

                        if (onFinish != null) onFinish();

                    }).Start();
                    break;
                case Position.Bottom:
                    directionX = destination.Left > control.Left ? 1 : -1;
                    directionY = destination.Bottom > control.Top ? 1 : -1;

                    new Task(() =>
                    {
                        while (control.Left != destination.Left || control.Top != destination.Bottom)
                        {
                            try
                            {
                                if (control.Left != destination.Left)
                                {
                                    container.Invoke((Action)delegate ()
                                    {
                                        control.Left += directionX;
                                    });
                                }
                                if (control.Top != destination.Bottom)
                                {
                                    container.Invoke((Action)delegate ()
                                    {
                                        control.Top += directionY;
                                    });
                                }
                                Thread.Sleep(delay);
                            }
                            catch
                            {
                                break;
                            }
                        }

                        if (onFinish != null) 
                            onFinish();

                    }).Start();
                    break;
                default:
                    break;
            }
        }
    }
}
