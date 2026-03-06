namespace MyBusinessCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(428, 89);
            label1.Name = "label1";
            label1.Size = new Size(122, 46);
            label1.TabIndex = 1;
            label1.Text = "김재서";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(428, 191);
            label2.Name = "label2";
            label2.Size = new Size(240, 31);
            label2.TabIndex = 2;
            label2.Text = "수원대 컴퓨터SW학과";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(428, 287);
            label3.Name = "label3";
            label3.Size = new Size(261, 31);
            label3.TabIndex = 3;
            label3.Text = "23010114@suwon.ac.kr";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(428, 459);
            button1.Name = "button1";
            button1.Size = new Size(175, 54);
            button1.TabIndex = 4;
            button1.Text = "GitHub";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(428, 376);
            label4.Name = "label4";
            label4.Size = new Size(175, 31);
            label4.TabIndex = 5;
            label4.Text = "010-3058-4820";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(98, 538);
            button2.Name = "button2";
            button2.Size = new Size(191, 53);
            button2.TabIndex = 6;
            button2.Text = "사진 변경";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(428, 538);
            button3.Name = "button3";
            button3.Size = new Size(175, 40);
            button3.TabIndex = 7;
            button3.Text = "배경색상 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 603);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "MyBusinessCard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}
