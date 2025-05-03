namespace AutoClickProject
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 55);
            button1.Name = "button1";
            button1.Size = new Size(149, 69);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += startAutoClicker;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Modo Preciso", "Modo Variado" });
            comboBox1.Location = new Point(172, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedValue = "Modo Preciso";
            // ;
            // trackBar1
            // 
            trackBar1.Location = new Point(172, 257);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(149, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 25;
            trackBar1.Value = 0;
            trackBar1.ValueChanged += label2toTrackbar;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10F);
            label1.Location = new Point(172, 219);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 3;
            label1.Text = "Clicks Per Second";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(266, 219);
            label2.Name = "label2";
            label2.Font = new Font("Arial", 15F,FontStyle.Bold);
            label2.Size = new Size(35, 35);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 517);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
    }
}
