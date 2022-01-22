namespace Paint1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.filter1 = new System.Windows.Forms.Button();
            this.filter2 = new System.Windows.Forms.Button();
            this.checkFill = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.figureTriangle = new System.Windows.Forms.Button();
            this.figureCircle = new System.Windows.Forms.Button();
            this.figureSquare = new System.Windows.Forms.Button();
            this.pointPolygon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fill = new System.Windows.Forms.Button();
            this.colorBt = new System.Windows.Forms.Button();
            this.trackBrush = new System.Windows.Forms.TrackBar();
            this.cleanBt = new System.Windows.Forms.Button();
            this.brushTool = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.rastr = new System.Windows.Forms.Panel();
            this.Drag = new System.Windows.Forms.Button();
            this.change_figure = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.clBtn_vec = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.rastr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.panel6);
            this.panel.Controls.Add(this.checkFill);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1045, 90);
            this.panel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.filter1);
            this.panel6.Controls.Add(this.filter2);
            this.panel6.Location = new System.Drawing.Point(432, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 66);
            this.panel6.TabIndex = 9;
            // 
            // filter1
            // 
            this.filter1.BackColor = System.Drawing.Color.Silver;
            this.filter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filter1.FlatAppearance.BorderSize = 0;
            this.filter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter1.Location = new System.Drawing.Point(4, 4);
            this.filter1.Margin = new System.Windows.Forms.Padding(4);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(148, 26);
            this.filter1.TabIndex = 3;
            this.filter1.Text = "Черно-белый";
            this.filter1.UseVisualStyleBackColor = false;
            this.filter1.Click += new System.EventHandler(this.filter1_Click);
            // 
            // filter2
            // 
            this.filter2.BackColor = System.Drawing.Color.Khaki;
            this.filter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.filter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter2.FlatAppearance.BorderSize = 0;
            this.filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter2.Location = new System.Drawing.Point(4, 33);
            this.filter2.Margin = new System.Windows.Forms.Padding(4);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(148, 25);
            this.filter2.TabIndex = 5;
            this.filter2.Text = "Сепия";
            this.filter2.UseVisualStyleBackColor = false;
            this.filter2.Click += new System.EventHandler(this.filter2_Click);
            // 
            // checkFill
            // 
            this.checkFill.AutoSize = true;
            this.checkFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFill.FlatAppearance.BorderSize = 0;
            this.checkFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFill.Location = new System.Drawing.Point(283, 50);
            this.checkFill.Margin = new System.Windows.Forms.Padding(4);
            this.checkFill.Name = "checkFill";
            this.checkFill.Size = new System.Drawing.Size(107, 29);
            this.checkFill.TabIndex = 8;
            this.checkFill.Text = "Заливка";
            this.checkFill.UseVisualStyleBackColor = true;
            this.checkFill.CheckedChanged += new System.EventHandler(this.checkFill_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.figureTriangle);
            this.panel2.Controls.Add(this.figureCircle);
            this.panel2.Controls.Add(this.figureSquare);
            this.panel2.Controls.Add(this.pointPolygon);
            this.panel2.Location = new System.Drawing.Point(277, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 31);
            this.panel2.TabIndex = 7;
            // 
            // figureTriangle
            // 
            this.figureTriangle.BackColor = System.Drawing.Color.White;
            this.figureTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureTriangle.BackgroundImage")));
            this.figureTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figureTriangle.FlatAppearance.BorderSize = 0;
            this.figureTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureTriangle.Location = new System.Drawing.Point(96, 4);
            this.figureTriangle.Margin = new System.Windows.Forms.Padding(4);
            this.figureTriangle.Name = "figureTriangle";
            this.figureTriangle.Size = new System.Drawing.Size(23, 21);
            this.figureTriangle.TabIndex = 7;
            this.figureTriangle.UseVisualStyleBackColor = false;
            this.figureTriangle.Click += new System.EventHandler(this.figureTriangle_Click);
            // 
            // figureCircle
            // 
            this.figureCircle.BackColor = System.Drawing.Color.White;
            this.figureCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureCircle.BackgroundImage")));
            this.figureCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figureCircle.FlatAppearance.BorderSize = 0;
            this.figureCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureCircle.Location = new System.Drawing.Point(65, 4);
            this.figureCircle.Margin = new System.Windows.Forms.Padding(4);
            this.figureCircle.Name = "figureCircle";
            this.figureCircle.Size = new System.Drawing.Size(23, 21);
            this.figureCircle.TabIndex = 6;
            this.figureCircle.UseVisualStyleBackColor = false;
            this.figureCircle.Click += new System.EventHandler(this.figureCircle_Click);
            // 
            // figureSquare
            // 
            this.figureSquare.BackColor = System.Drawing.Color.White;
            this.figureSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureSquare.BackgroundImage")));
            this.figureSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureSquare.FlatAppearance.BorderSize = 0;
            this.figureSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureSquare.Location = new System.Drawing.Point(4, 4);
            this.figureSquare.Margin = new System.Windows.Forms.Padding(4);
            this.figureSquare.Name = "figureSquare";
            this.figureSquare.Size = new System.Drawing.Size(23, 21);
            this.figureSquare.TabIndex = 3;
            this.figureSquare.UseVisualStyleBackColor = false;
            this.figureSquare.Click += new System.EventHandler(this.figureSquare_Click);
            // 
            // pointPolygon
            // 
            this.pointPolygon.BackColor = System.Drawing.Color.White;
            this.pointPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pointPolygon.BackgroundImage")));
            this.pointPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pointPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pointPolygon.FlatAppearance.BorderSize = 0;
            this.pointPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointPolygon.Location = new System.Drawing.Point(35, 4);
            this.pointPolygon.Margin = new System.Windows.Forms.Padding(4);
            this.pointPolygon.Name = "pointPolygon";
            this.pointPolygon.Size = new System.Drawing.Size(23, 21);
            this.pointPolygon.TabIndex = 5;
            this.pointPolygon.UseVisualStyleBackColor = false;
            this.pointPolygon.Click += new System.EventHandler(this.pointPolygon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fill);
            this.panel1.Controls.Add(this.colorBt);
            this.panel1.Controls.Add(this.trackBrush);
            this.panel1.Controls.Add(this.cleanBt);
            this.panel1.Controls.Add(this.brushTool);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 67);
            this.panel1.TabIndex = 6;
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.Color.White;
            this.fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill.BackgroundImage")));
            this.fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fill.FlatAppearance.BorderSize = 0;
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill.Location = new System.Drawing.Point(4, 32);
            this.fill.Margin = new System.Windows.Forms.Padding(4);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(23, 21);
            this.fill.TabIndex = 5;
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // colorBt
            // 
            this.colorBt.BackColor = System.Drawing.Color.Black;
            this.colorBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBt.FlatAppearance.BorderSize = 0;
            this.colorBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBt.Location = new System.Drawing.Point(33, 4);
            this.colorBt.Margin = new System.Windows.Forms.Padding(4);
            this.colorBt.Name = "colorBt";
            this.colorBt.Size = new System.Drawing.Size(23, 21);
            this.colorBt.TabIndex = 1;
            this.colorBt.UseVisualStyleBackColor = false;
            this.colorBt.Click += new System.EventHandler(this.colorBt_Click);
            // 
            // trackBrush
            // 
            this.trackBrush.AutoSize = false;
            this.trackBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrush.Location = new System.Drawing.Point(64, 4);
            this.trackBrush.Margin = new System.Windows.Forms.Padding(4);
            this.trackBrush.Name = "trackBrush";
            this.trackBrush.Size = new System.Drawing.Size(168, 46);
            this.trackBrush.TabIndex = 2;
            this.trackBrush.ValueChanged += new System.EventHandler(this.trackBrush_ValueChanged);
            // 
            // cleanBt
            // 
            this.cleanBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanBt.BackgroundImage")));
            this.cleanBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cleanBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBt.FlatAppearance.BorderSize = 0;
            this.cleanBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBt.Location = new System.Drawing.Point(33, 32);
            this.cleanBt.Margin = new System.Windows.Forms.Padding(4);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(23, 21);
            this.cleanBt.TabIndex = 1;
            this.cleanBt.UseVisualStyleBackColor = true;
            this.cleanBt.Click += new System.EventHandler(this.cleanBt_Click);
            // 
            // brushTool
            // 
            this.brushTool.BackColor = System.Drawing.Color.White;
            this.brushTool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushTool.BackgroundImage")));
            this.brushTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brushTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brushTool.FlatAppearance.BorderSize = 0;
            this.brushTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushTool.Location = new System.Drawing.Point(4, 4);
            this.brushTool.Margin = new System.Windows.Forms.Padding(4);
            this.brushTool.Name = "brushTool";
            this.brushTool.Size = new System.Drawing.Size(23, 21);
            this.brushTool.TabIndex = 4;
            this.brushTool.UseVisualStyleBackColor = false;
            this.brushTool.Click += new System.EventHandler(this.brushTool_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.ErrorImage = null;
            this.canvas.Location = new System.Drawing.Point(0, 97);
            this.canvas.Margin = new System.Windows.Forms.Padding(4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1045, 796);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.DoubleClick += new System.EventHandler(this.canvas_DoubleClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAs,
            this.load});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(208, 26);
            this.SaveAs.Text = "Сохранить как...";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(208, 26);
            this.load.Text = "Загрузить...";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // rastr
            // 
            this.rastr.Controls.Add(this.panel);
            this.rastr.Controls.Add(this.canvas);
            this.rastr.Location = new System.Drawing.Point(16, 33);
            this.rastr.Margin = new System.Windows.Forms.Padding(4);
            this.rastr.Name = "rastr";
            this.rastr.Size = new System.Drawing.Size(1045, 886);
            this.rastr.TabIndex = 2;
            // 
            // Drag
            // 
            this.Drag.BackColor = System.Drawing.Color.White;
            this.Drag.FlatAppearance.BorderSize = 0;
            this.Drag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drag.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drag.Location = new System.Drawing.Point(517, 18);
            this.Drag.Margin = new System.Windows.Forms.Padding(4);
            this.Drag.Name = "Drag";
            this.Drag.Size = new System.Drawing.Size(133, 47);
            this.Drag.TabIndex = 9;
            this.Drag.Text = "Drag";
            this.Drag.UseVisualStyleBackColor = false;
            // 
            // change_figure
            // 
            this.change_figure.BackColor = System.Drawing.Color.White;
            this.change_figure.FlatAppearance.BorderSize = 0;
            this.change_figure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_figure.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_figure.Location = new System.Drawing.Point(389, 18);
            this.change_figure.Margin = new System.Windows.Forms.Padding(4);
            this.change_figure.Name = "change_figure";
            this.change_figure.Size = new System.Drawing.Size(133, 47);
            this.change_figure.TabIndex = 8;
            this.change_figure.Text = "Change";
            this.change_figure.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(65, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 21);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.White;
            this.square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square.BackgroundImage")));
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Location = new System.Drawing.Point(4, 4);
            this.square.Margin = new System.Windows.Forms.Padding(4);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(23, 21);
            this.square.TabIndex = 3;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(33, 4);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 21);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(64, 4);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 46);
            this.trackBar1.TabIndex = 2;
            // 
            // clBtn_vec
            // 
            this.clBtn_vec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clBtn_vec.BackgroundImage")));
            this.clBtn_vec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clBtn_vec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clBtn_vec.FlatAppearance.BorderSize = 0;
            this.clBtn_vec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clBtn_vec.Location = new System.Drawing.Point(4, 32);
            this.clBtn_vec.Margin = new System.Windows.Forms.Padding(4);
            this.clBtn_vec.Name = "clBtn_vec";
            this.clBtn_vec.Size = new System.Drawing.Size(23, 21);
            this.clBtn_vec.TabIndex = 1;
            this.clBtn_vec.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(4, 4);
            this.line.Margin = new System.Windows.Forms.Padding(4);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(23, 21);
            this.line.TabIndex = 4;
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(608, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поворот 90°";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 934);
            this.Controls.Add(this.rastr);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rastr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button cleanBt;
        private System.Windows.Forms.Button colorBt;
        private System.Windows.Forms.Button figureSquare;
        private System.Windows.Forms.Button brushTool;
        private System.Windows.Forms.Button pointPolygon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button figureCircle;
        public System.Windows.Forms.TrackBar trackBrush;
        private System.Windows.Forms.Button figureTriangle;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.CheckBox checkFill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.Panel rastr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button clBtn_vec;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button change_figure;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Drag;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button filter1;
        private System.Windows.Forms.Button filter2;
        private System.Windows.Forms.Button button1;
    }
}

