using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen Eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;
        Color New_Color;
        ColorDialog colordialog = new ColorDialog();
        TextBox txtbox;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Pic.Width, Pic.Height);
            graphics=Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            Pic.Image = bitmap;
            txtbox = new TextBox();
            txtbox.Multiline = true;
            txtbox.BorderStyle = BorderStyle.None;
            txtbox.Visible = false;
            Controls.Add(txtbox); 
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if(paint)
            {
                if(index ==3)
                {
                    graphics.DrawEllipse(pen,cx,cy,sx,sy);
                }
                if(index ==4)
                {
                    graphics.DrawRectangle(pen,cx,cy,sx,sy);
                }
                if(index==5)
                {
                    graphics.DrawLine(pen,cx,cy,x,y);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            Pic.Image = bitmap;
            index = 0;
        }

        private void BtnPaint_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        static Point set_Point(PictureBox pictureBox, Point point)
        {
            float px = 1f * pictureBox.Width / pictureBox.Width;
            float py = 1f * pictureBox.Height / pictureBox.Height;
            return new Point((int)(point.X*px), (int)(point.Y*py));
        }
        private void Validate(Bitmap bitmap, Stack<Point> stack, int x, int y, Color Old_Color,Color New_Color)
        {
            Color cx = bitmap.GetPixel(x, y);  
            if(cx==Old_Color)
            {
                stack.Push(new Point(x, y));
                bitmap.SetPixel(x, y, New_Color);
            }
        }
        public void Fill(Bitmap bitmap, int x, int y, Color New_Color)
        {
            Color Old_Color = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x,y, New_Color);
            if(Old_Color==New_Color) { return; }

            while(pixel.Count > 0) 
            {
                Point point= (Point)pixel.Pop();
                if(point.X>0 && point.Y>0 && point.X<Width-1 && point.Y<Height-1)
                {
                    Validate(bitmap, pixel, point.X - 1, point.Y , Old_Color, New_Color);
                    Validate(bitmap, pixel, point.X , point.Y - 1, Old_Color, New_Color);
                    Validate(bitmap, pixel, point.X + 1, point.Y, Old_Color, New_Color);
                    Validate(bitmap, pixel, point.X , point.Y + 1, Old_Color, New_Color);
                }
            }
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index ==6)
            {
                Point point = set_Point(Pic, e.Location);
                Fill(bitmap, point.X, point.Y, New_Color);
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colordialog.ShowDialog();
            New_Color = colordialog.Color;
            Pic.BackColor = colordialog.Color;
            pen.Color = colordialog.Color;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bitmap.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bitmap.PixelFormat);
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void txtBox_Click(object sender, EventArgs e)
        {
            index = 7;
            if (index == 7)
            {
                txtbox.Location = new Point(cx, cy);
                txtbox.Size = new Size(sx, sy);
                txtbox.Visible = true;
                txtbox.Focus();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap loadedBitmap = new Bitmap(openFileDialog.FileName);
                    bitmap = new Bitmap(loadedBitmap);
                    graphics = Graphics.FromImage(bitmap);
                    Pic.Image = bitmap;
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            px= e.Location;

            cx = e.X;
            cy= e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if(index==2)
                {
                    px = e.Location;
                    graphics.DrawLine(Eraser, px, py);
                    py= px;
                }
            }
            Pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;
            if(index==3)
            {
                graphics.DrawEllipse(pen,cx,cy,sx,sy);
            }
            if(index==4)
            {
                graphics.DrawRectangle(pen,cx,cy,sx,sy);  
            }
            if(index==5)
            {
                graphics.DrawLine(pen,cx,cy,x,y);
            }
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void BtnElipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}
