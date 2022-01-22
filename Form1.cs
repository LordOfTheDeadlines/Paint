using PhotoEditor;
using PhotoEditor.Filters.Implementation;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Paint1
{
    public partial class Form1 : Form
    {
        IFill typeFill = null;
        IFigure contur = new Line();
        IFigureBuild figure = new Build(new Line(), new FillSolid());
        string flagFigure = "line";
        Bitmap bitmapImage, memoryBitmap;
        bool mouseDown = false, shift = false, autoFill = false;
        int firstPointX, firstPointY, prevPointX = -1, prevPointY = -1, memoryFirstPointX, memoryFirstPointY;
        CustomColorDialog colorDialog = new CustomColorDialog();
        Graphics RastrGraph;
        Button button = null;

        public Form1()
        {
            InitializeComponent();
            this.Height = 720;
            this.Width = 784;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= 0 && e.Location.X < bitmapImage.Width && e.Location.Y >= 0 && e.Location.Y < bitmapImage.Height)
            {
                if(mouseDown)
                {
                    switch (flagFigure)
                    {
                        case "brush":
                            DrawBrush(e);
                            break;
                        case "ppolygon":
                            return;
                        case "square":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                        case "circle":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                        case "triangle":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                        case "fpolygon":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                    }           
                }
                else
                {
                    if (flagFigure == "ppolygon" && prevPointX != -1 && prevPointY != -1) DrawFigureByPoint(e);
                } 
            }
        }

        private void DrawBrush(MouseEventArgs e)
        {
            figure = new Build(contur, typeFill);
            
            figure.MyBitmap = bitmapImage;
            figure.BuildFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y, shift);
            firstPointX = e.Location.X;
            firstPointY = e.Location.Y;
            canvas.Image = bitmapImage;
        }

        private void DrawFigureByPoint(MouseEventArgs e)
        {
            prevPointX = firstPointX;
            prevPointY = firstPointY;
            DrawFigure(prevPointX, prevPointY, e.Location.X, e.Location.Y);
        }


        private void DrawFigure(int x1, int y1, int x2, int y2) 
        {        
            CloneBitmap(out memoryBitmap);
            
            RastrGraph = Graphics.FromImage(memoryBitmap);
            Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
            figure = new Build(contur, typeFill);
            figure.MyBitmap = bitmap;
            figure.SetModify(colorDialog.fillColor, autoFill);
            figure.BuildFigure(x1, y1, x2, y2, shift);

            RastrGraph.DrawImage(figure.MyBitmap, 0, 0);
            canvas.Image = memoryBitmap;  
        }

        private void CloneBitmap(out Bitmap btm)
        {         
            Rectangle r = new Rectangle(0, 0, bitmapImage.Width-1, bitmapImage.Height-1 );
            btm =  bitmapImage.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);         
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            firstPointX = e.Location.X;
            firstPointY = e.Location.Y;
            if (flagFigure == "fillSolid")
            {
                FillCanvas(e);
            }
            
            if (flagFigure == "ppolygon" && prevPointX == -1 && prevPointY == -1)
            {
                CloneBitmap(out memoryBitmap);
                prevPointX = firstPointX;
                prevPointY = firstPointY;
                memoryFirstPointX = firstPointX;
                memoryFirstPointY = firstPointY;
            }
        }

        private void FillCanvas(MouseEventArgs e)
        {
            IFill typeFill = new FillSolid();
            typeFill.MyBitmap = bitmapImage;
            typeFill.Fill(e.X, e.Y, Brush.BrushColor);
            canvas.Image = typeFill.MyBitmap;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (memoryBitmap != null)
            {
                bitmapImage = memoryBitmap;
            }
            Brush.BrushColor = colorDialog.Color;
        }

        private void colorBt_Click(object sender, EventArgs e)
        {           
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                colorBt.BackColor = colorDialog.Color;
                Brush.BrushColor = colorDialog.Color;
            }
        }

        private void canvas_DoubleClick(object sender, EventArgs e)
        {
            if (flagFigure == "ppolygon")
            {
                DrawFigure(prevPointX, prevPointY, memoryFirstPointX, memoryFirstPointY);

                prevPointX = -1;
                prevPointY = -1;
            }
        }
       
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            shift = false;
        }
  
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                shift = true;
            }
        }

        private void trackBrush_ValueChanged(object sender, EventArgs e)
        {
            Brush.BrushThickness = trackBrush.Value + 1;
        }

        private void fill_Click(object sender, EventArgs e)
        {
            flagFigure = "fillSolid";
            typeFill = new FillSolid();
           
            ButtonChange(fill);
        }

        private void line_Click(object sender, EventArgs e)
        {
            ButtonChange(line);
        }


        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmapImage.Save(saveFileDialog1.OpenFile(), System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                //int width = image.Width;
                //int height = image.Height;
                int width = this.Width;
                int height = this.Height;
                openFileDialog1.Reset();
                bitmapImage = new Bitmap(image, width, height);
                canvas.Image = bitmapImage;
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            ButtonChange(button4);
        }


        private void square_Click(object sender, EventArgs e)
        {
            ButtonChange(square);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                button7.BackColor = colorDialog.Color;
            }
        }

        private void filter1_Click(object sender, EventArgs e)
        {
            if (canvas.Image != null)
            {
                BlackWhiteFilter filter = new BlackWhiteFilter();
                canvas.Image = filter.ChangeBitmapImage((Bitmap)canvas.Image);
            }
        }

        private void filter2_Click(object sender, EventArgs e)
        {
            if (canvas.Image != null)
            {
                SepiaFilter filter = new SepiaFilter();
                canvas.Image = filter.ChangeBitmapImage((Bitmap)canvas.Image);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Image = RotationAlgorithms.Rotate((Bitmap)canvas.Image, 90);
        }

        private void checkFill_CheckedChanged(object sender, EventArgs e)
        {
            if (!autoFill)
            {
                autoFill = true;
                typeFill = new FillSolid();
                
            } else
            {
                autoFill = false;
                typeFill = null;
                
            }
        }
        private void figureTriangle_Click(object sender, EventArgs e)
        {           
            contur = new Triangle();
            flagFigure = "triangle";
            ButtonChange(figureTriangle);
        }
        private void figureCircle_Click(object sender, EventArgs e)
        {
            contur = new Circle();
            flagFigure = "circle";
            ButtonChange(figureCircle);
        }
        private void figureSquare_Click(object sender, EventArgs e)
        {
            contur = new Square();
            flagFigure = "square";
            ButtonChange(figureSquare);
        }

        private void pointPolygon_Click(object sender, EventArgs e)
        {         
            contur = new Polygon();
            flagFigure = "ppolygon";
            ButtonChange(pointPolygon);
        }

        private void brushTool_Click(object sender, EventArgs e)
        {
            contur = new Line();
            flagFigure = "brush";
            ButtonChange(brushTool);
        }

        private void cleanBt_Click(object sender, EventArgs e)
        {

            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            memoryBitmap = bitmapImage;
            
            canvas.Image = bitmapImage;
        }    

        private void ButtonChange(Button master)
        {
            if (button == null)
            {
                master.BackColor = Color.Silver;
            }
            else
            {
                button.BackColor = Color.White;         
                master.BackColor = Color.Silver;
            }
            button = master;
        }
    }
}
