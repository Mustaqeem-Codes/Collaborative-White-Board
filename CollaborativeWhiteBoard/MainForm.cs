using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CollaborativeWhiteBoard
{
    public partial class MainForm : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private List<Tuple<Point, Point, Color, int>> lines = new List<Tuple<Point, Point, Color, int>>();
        private Color currentColor = Color.Black;
        private int currentThickness = 2;
        private Bitmap? drawingBitmap;
        private Graphics? drawingGraphics;

        public MainForm()
        {
            InitializeComponent();
            InitializeDrawingArea();
        }

        private void InitializeDrawingArea()
        {
            // Create a bitmap for the drawing area
            drawingBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            drawingGraphics = Graphics.FromImage(drawingBitmap);
            drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            drawingGraphics.Clear(Color.White);
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
            }
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                if (drawingGraphics != null)
                {
                    using (Pen pen = new Pen(currentColor, currentThickness))
                    {
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        drawingGraphics.DrawLine(pen, previousPoint, e.Location);
                    }
                    
                    lines.Add(new Tuple<Point, Point, Color, int>(previousPoint, e.Location, currentColor, currentThickness));
                    previousPoint = e.Location;
                    drawingPanel.Invalidate();
                }
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            if (drawingBitmap != null)
            {
                e.Graphics.DrawImage(drawingBitmap, 0, 0);
            }
        }

        private void BtnBlack_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            UpdateColorIndicator();
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
            UpdateColorIndicator();
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
            UpdateColorIndicator();
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
            UpdateColorIndicator();
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
            UpdateColorIndicator();
        }

        private void UpdateColorIndicator()
        {
            colorIndicatorPanel.BackColor = currentColor;
        }

        private void BtnThin_Click(object sender, EventArgs e)
        {
            currentThickness = 2;
            UpdateThicknessIndicator();
        }

        private void BtnMedium_Click(object sender, EventArgs e)
        {
            currentThickness = 5;
            UpdateThicknessIndicator();
        }

        private void BtnThick_Click(object sender, EventArgs e)
        {
            currentThickness = 10;
            UpdateThicknessIndicator();
        }

        private void UpdateThicknessIndicator()
        {
            lblThicknessValue.Text = currentThickness.ToString() + "px";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the board?", "Clear Board", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lines.Clear();
                if (drawingGraphics != null)
                {
                    drawingGraphics.Clear(Color.White);
                }
                drawingPanel.Invalidate();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveDialog.Title = "Save Drawing";
                saveDialog.FileName = "whiteboard_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK && drawingBitmap != null)
                {
                    try
                    {
                        drawingBitmap.Save(saveDialog.FileName);
                        MessageBox.Show("Drawing saved successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
                openDialog.Title = "Load Drawing";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image loadedImage = Image.FromFile(openDialog.FileName);
                        
                        // Clear existing drawing
                        lines.Clear();
                        
                        if (drawingGraphics != null)
                        {
                            drawingGraphics.Clear(Color.White);
                            drawingGraphics.DrawImage(loadedImage, 0, 0, drawingPanel.Width, drawingPanel.Height);
                        }
                        
                        drawingPanel.Invalidate();
                        MessageBox.Show("Drawing loaded successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading file: " + ex.Message, "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (drawingPanel.Width > 0 && drawingPanel.Height > 0)
            {
                // Create new bitmap with new size
                Bitmap newBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
                Graphics newGraphics = Graphics.FromImage(newBitmap);
                newGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                newGraphics.Clear(Color.White);

                // Copy old drawing if exists
                if (drawingBitmap != null && drawingGraphics != null)
                {
                    newGraphics.DrawImage(drawingBitmap, 0, 0);
                    drawingGraphics.Dispose();
                    drawingBitmap.Dispose();
                }

                drawingBitmap = newBitmap;
                drawingGraphics = newGraphics;
                drawingPanel.Invalidate();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (drawingGraphics != null)
            {
                drawingGraphics.Dispose();
            }
            if (drawingBitmap != null)
            {
                drawingBitmap.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}
