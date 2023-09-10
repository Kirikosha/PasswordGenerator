using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PasswordGenerator.Controls;

public class RoundedButton : Button
{
    private Color color = Color.FromArgb(53, 53, 53);
    private int borderRadius = 40;
    private int borderSize = 0;

    public Color Color { get => color;
        set
        {
            color = value;
            this.Invalidate();
        }
        }
    public int BorderRadius { get => borderRadius;
        set
        {
            borderRadius = value;
            this.Invalidate();
        }
    }
    public int BorderSize { get => borderSize;
        set
        {
            borderSize = value;
            this.Invalidate();
        }
    }

    public RoundedButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Size = new Size(150, 40);
        this.BackColor = Color.FromArgb(35, 35, 35);
        this.ForeColor = Color.White;
    }


    private GraphicsPath GetFigurePath(RectangleF rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
        path.CloseFigure();

        return path;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        RectangleF rectSurf = new RectangleF(0, 0, this.Width, this.Height);
        RectangleF rectSmSurf = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

        if(borderRadius > 2)
        {
            using (GraphicsPath pathSurface = GetFigurePath(rectSurf, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectSmSurf, borderRadius - 1))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBordSurface = new Pen(color, borderSize))
            {
                penBordSurface.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);

                pevent.Graphics.DrawPath(penSurface, pathSurface);

                if(borderSize >= 1)
                {
                    pevent.Graphics.DrawPath(penBordSurface, pathBorder);
                }
            }
        }
        else
        {
            this.Region = new Region(rectSurf);
            if(borderSize >= 1)
            {
                using (Pen penBorder = new Pen(color, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
    }

    private void Container_BackColorChanged(object? sender, EventArgs e)
    {
        if (this.DesignMode)
        {
            this.Invalidate();
        }
    }
}
