using System.Drawing;
using System.Windows.Forms;

namespace GraphicEx
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
            this.plMain = new System.Windows.Forms.Panel();
            this.bth_line = new System.Windows.Forms.Button();
            this.rectLineButton = new System.Windows.Forms.Button();
            this.filledRectButton = new System.Windows.Forms.Button();
            this.elipseLineButton = new System.Windows.Forms.Button();
            this.filledElipButton = new System.Windows.Forms.Button();
            this.penColor = new System.Windows.Forms.ColorDialog();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.brushColor = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnArc = new System.Windows.Forms.Button();
            this.arcAngleBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.polygonNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.penColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcAngleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonNum)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.Beige;
            this.plMain.Location = new System.Drawing.Point(323, 15);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(699, 523);
            this.plMain.TabIndex = 0;
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            this.plMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseWheel);
            // 
            // bth_line
            // 
            this.bth_line.Location = new System.Drawing.Point(39, 15);
            this.bth_line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bth_line.Name = "bth_line";
            this.bth_line.Size = new System.Drawing.Size(232, 42);
            this.bth_line.TabIndex = 1;
            this.bth_line.Text = "Line";
            this.bth_line.UseVisualStyleBackColor = true;
            this.bth_line.Click += new System.EventHandler(this.btnDuongThang_Click);
            // 
            // rectLineButton
            // 
            this.rectLineButton.Location = new System.Drawing.Point(39, 64);
            this.rectLineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rectLineButton.Name = "rectLineButton";
            this.rectLineButton.Size = new System.Drawing.Size(113, 42);
            this.rectLineButton.TabIndex = 2;
            this.rectLineButton.Text = "Khung CN";
            this.rectLineButton.UseVisualStyleBackColor = true;
            this.rectLineButton.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // filledRectButton
            // 
            this.filledRectButton.Location = new System.Drawing.Point(159, 64);
            this.filledRectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filledRectButton.Name = "filledRectButton";
            this.filledRectButton.Size = new System.Drawing.Size(111, 42);
            this.filledRectButton.TabIndex = 2;
            this.filledRectButton.Text = "Hình CN";
            this.filledRectButton.UseVisualStyleBackColor = true;
            this.filledRectButton.Click += new System.EventHandler(this.btnFilledRect_Click);
            // 
            // elipseLineButton
            // 
            this.elipseLineButton.Location = new System.Drawing.Point(37, 113);
            this.elipseLineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elipseLineButton.Name = "elipseLineButton";
            this.elipseLineButton.Size = new System.Drawing.Size(115, 42);
            this.elipseLineButton.TabIndex = 2;
            this.elipseLineButton.Text = "Đường Eclipse";
            this.elipseLineButton.UseVisualStyleBackColor = true;
            this.elipseLineButton.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // filledElipButton
            // 
            this.filledElipButton.Location = new System.Drawing.Point(157, 113);
            this.filledElipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filledElipButton.Name = "filledElipButton";
            this.filledElipButton.Size = new System.Drawing.Size(112, 42);
            this.filledElipButton.TabIndex = 2;
            this.filledElipButton.Text = "Hình Eclipse";
            this.filledElipButton.UseVisualStyleBackColor = true;
            this.filledElipButton.Click += new System.EventHandler(this.btnFilledEclipse_Click);
            // 
            // brushColorButton
            // 
            this.brushColorButton.BackColor = System.Drawing.Color.Black;
            this.brushColorButton.Location = new System.Drawing.Point(208, 316);
            this.brushColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(61, 49);
            this.brushColorButton.TabIndex = 3;
            this.brushColorButton.UseVisualStyleBackColor = false;
            this.brushColorButton.Click += new System.EventHandler(this.btnBrushColor);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(40, 420);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(232, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 10;
            // 
            // btnArc
            // 
            this.btnArc.Location = new System.Drawing.Point(39, 166);
            this.btnArc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(71, 42);
            this.btnArc.TabIndex = 5;
            this.btnArc.Text = "Arc";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // arcAngleBar
            // 
            this.arcAngleBar.Location = new System.Drawing.Point(117, 166);
            this.arcAngleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arcAngleBar.Maximum = 360;
            this.arcAngleBar.Name = "arcAngleBar";
            this.arcAngleBar.Size = new System.Drawing.Size(153, 56);
            this.arcAngleBar.TabIndex = 4;
            this.arcAngleBar.Value = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Polygon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 265);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Filled Polygon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFilledPolygon_Click);
            // 
            // polygonNum
            // 
            this.polygonNum.Location = new System.Drawing.Point(116, 250);
            this.polygonNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.polygonNum.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.polygonNum.Name = "polygonNum";
            this.polygonNum.Size = new System.Drawing.Size(153, 22);
            this.polygonNum.TabIndex = 6;
            this.polygonNum.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(117, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Vertex";
            // 
            // penColorButton
            // 
            this.penColorButton.BackColor = System.Drawing.Color.Black;
            this.penColorButton.Location = new System.Drawing.Point(93, 316);
            this.penColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(59, 49);
            this.penColorButton.TabIndex = 3;
            this.penColorButton.UseVisualStyleBackColor = false;
            this.penColorButton.Click += new System.EventHandler(this.btnPenColor);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pen Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(160, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brush Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.ItemHeight = 29;
            this.comboBox.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "DashDot", "DashDotDot" });
            this.comboBox.Location = new System.Drawing.Point(41, 373);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(229, 37);
            this.comboBox.TabIndex = 8;
            // 
            // groupBTN
            // 
            this.groupBTN.Enabled = false;
            this.groupBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBTN.Location = new System.Drawing.Point(41, 479);
            this.groupBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBTN.Name = "groupBTN";
            this.groupBTN.Size = new System.Drawing.Size(229, 58);
            this.groupBTN.TabIndex = 9;
            this.groupBTN.Text = "GROUP!";
            this.groupBTN.UseVisualStyleBackColor = true;
            this.groupBTN.Click += new System.EventHandler(this.groupBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBTN);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.polygonNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.arcAngleBar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.penColorButton);
            this.Controls.Add(this.brushColorButton);
            this.Controls.Add(this.filledElipButton);
            this.Controls.Add(this.elipseLineButton);
            this.Controls.Add(this.filledRectButton);
            this.Controls.Add(this.rectLineButton);
            this.Controls.Add(this.bth_line);
            this.Controls.Add(this.plMain);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcAngleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button groupBTN;

        private System.Windows.Forms.ComboBox comboBox;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ColorDialog penColor;

        private System.Windows.Forms.Button penColorButton;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown polygonNum;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TrackBar arcAngleBar;

        private System.Windows.Forms.Button btnArc;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.ColorDialog brushColor;
        private System.Windows.Forms.Button brushColorButton;

        private System.Windows.Forms.Button elipseLineButton;
        private System.Windows.Forms.Button filledElipButton;

        private System.Windows.Forms.Button filledRectButton;

        private System.Windows.Forms.Button rectLineButton;

        private System.Windows.Forms.Button bth_line;

        private System.Windows.Forms.Panel plMain;

        #endregion
    }
}