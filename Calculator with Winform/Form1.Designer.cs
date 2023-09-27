namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            equal = new Button();
            clean = new Button();
            n0 = new Button();
            devide = new Button();
            multipy = new Button();
            dif = new Button();
            sum = new Button();
            Box = new TextBox();
            point = new Button();
            SuspendLayout();
            // 
            // n1
            // 
            n1.BackColor = Color.Gray;
            n1.ForeColor = SystemColors.ControlLightLight;
            n1.Location = new Point(157, 444);
            n1.Name = "n1";
            n1.Size = new Size(150, 46);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = Color.Gray;
            n2.ForeColor = SystemColors.ControlLightLight;
            n2.Location = new Point(368, 444);
            n2.Name = "n2";
            n2.Size = new Size(150, 46);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.BackColor = Color.Gray;
            n3.ForeColor = SystemColors.ControlLightLight;
            n3.Location = new Point(574, 444);
            n3.Name = "n3";
            n3.Size = new Size(150, 46);
            n3.TabIndex = 2;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n4
            // 
            n4.BackColor = Color.Gray;
            n4.ForeColor = SystemColors.ControlLightLight;
            n4.Location = new Point(157, 347);
            n4.Name = "n4";
            n4.Size = new Size(150, 46);
            n4.TabIndex = 3;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.BackColor = Color.Gray;
            n5.ForeColor = SystemColors.ControlLightLight;
            n5.Location = new Point(368, 347);
            n5.Name = "n5";
            n5.Size = new Size(150, 46);
            n5.TabIndex = 4;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.BackColor = Color.Gray;
            n6.ForeColor = SystemColors.ControlLightLight;
            n6.Location = new Point(574, 347);
            n6.Name = "n6";
            n6.Size = new Size(150, 46);
            n6.TabIndex = 5;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n7
            // 
            n7.BackColor = Color.Gray;
            n7.ForeColor = SystemColors.ControlLightLight;
            n7.Location = new Point(157, 248);
            n7.Name = "n7";
            n7.Size = new Size(150, 46);
            n7.TabIndex = 6;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.BackColor = Color.Gray;
            n8.ForeColor = SystemColors.ControlLightLight;
            n8.Location = new Point(368, 248);
            n8.Name = "n8";
            n8.Size = new Size(150, 46);
            n8.TabIndex = 7;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.BackColor = Color.Gray;
            n9.ForeColor = SystemColors.ControlLightLight;
            n9.Location = new Point(574, 248);
            n9.Name = "n9";
            n9.Size = new Size(150, 46);
            n9.TabIndex = 8;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.CornflowerBlue;
            equal.ForeColor = SystemColors.ControlLightLight;
            equal.Location = new Point(819, 536);
            equal.Name = "equal";
            equal.Size = new Size(150, 46);
            equal.TabIndex = 9;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // clean
            // 
            clean.BackColor = Color.FromArgb(192, 64, 0);
            clean.ForeColor = SystemColors.ControlLightLight;
            clean.Location = new Point(157, 536);
            clean.Name = "clean";
            clean.Size = new Size(150, 46);
            clean.TabIndex = 10;
            clean.Text = "C";
            clean.UseVisualStyleBackColor = false;
            clean.Click += clean_Click;
            // 
            // n0
            // 
            n0.BackColor = Color.Gray;
            n0.ForeColor = SystemColors.ControlLightLight;
            n0.Location = new Point(368, 536);
            n0.Name = "n0";
            n0.Size = new Size(150, 46);
            n0.TabIndex = 11;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // devide
            // 
            devide.BackColor = Color.CadetBlue;
            devide.ForeColor = SystemColors.ControlLightLight;
            devide.Location = new Point(819, 248);
            devide.Name = "devide";
            devide.Size = new Size(150, 46);
            devide.TabIndex = 12;
            devide.Text = "/";
            devide.UseVisualStyleBackColor = false;
            devide.Click += devide_Click;
            // 
            // multipy
            // 
            multipy.BackColor = Color.CadetBlue;
            multipy.ForeColor = SystemColors.ControlLightLight;
            multipy.Location = new Point(819, 319);
            multipy.Name = "multipy";
            multipy.Size = new Size(150, 46);
            multipy.TabIndex = 13;
            multipy.Text = "*";
            multipy.UseVisualStyleBackColor = false;
            multipy.Click += multipy_Click;
            // 
            // dif
            // 
            dif.BackColor = Color.CadetBlue;
            dif.ForeColor = SystemColors.ControlLightLight;
            dif.Location = new Point(819, 393);
            dif.Name = "dif";
            dif.Size = new Size(150, 46);
            dif.TabIndex = 14;
            dif.Text = "-";
            dif.UseVisualStyleBackColor = false;
            dif.Click += dif_Click;
            // 
            // sum
            // 
            sum.BackColor = Color.CadetBlue;
            sum.ForeColor = SystemColors.ControlLightLight;
            sum.Location = new Point(819, 463);
            sum.Name = "sum";
            sum.Size = new Size(150, 46);
            sum.TabIndex = 15;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = false;
            sum.Click += sum_Click;
            // 
            // Box
            // 
            Box.BackColor = Color.DarkSeaGreen;
            Box.ForeColor = SystemColors.WindowText;
            Box.Location = new Point(368, 96);
            Box.Name = "Box";
            Box.Size = new Size(356, 39);
            Box.TabIndex = 16;
            Box.TextChanged += Box_TextChanged;
            // 
            // point
            // 
            point.BackColor = Color.Gray;
            point.ForeColor = SystemColors.ControlLightLight;
            point.Location = new Point(574, 536);
            point.Name = "point";
            point.Size = new Size(150, 46);
            point.TabIndex = 17;
            point.Text = ".";
            point.UseVisualStyleBackColor = false;
            point.Click += point_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1194, 636);
            Controls.Add(point);
            Controls.Add(n6);
            Controls.Add(Box);
            Controls.Add(sum);
            Controls.Add(dif);
            Controls.Add(multipy);
            Controls.Add(devide);
            Controls.Add(n0);
            Controls.Add(clean);
            Controls.Add(equal);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button equal;
        private Button clean;
        private Button n0;
        private Button devide;
        private Button multipy;
        private Button dif;
        private Button sum;
        private TextBox Box;
        private Button point;
    }
}