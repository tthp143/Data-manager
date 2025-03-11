namespace quiz
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            NameTextbox = new TextBox();
            ST_ID_Text = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBox1 = new ComboBox();
            label1 = new Label();
            GpxText = new TextBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ข้อมูลอาจารย์ = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ข้อมูลอาจารย์.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(312, 208);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 39);
            button1.TabIndex = 0;
            button1.Text = "Add Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(184, 102);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 84);
            button2.TabIndex = 1;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(32, 145);
            NameTextbox.Margin = new Padding(3, 4, 3, 4);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(114, 27);
            NameTextbox.TabIndex = 2;
            NameTextbox.TextChanged += textBox1_TextChanged;
            // 
            // ST_ID_Text
            // 
            ST_ID_Text.Location = new Point(168, 145);
            ST_ID_Text.Margin = new Padding(3, 4, 3, 4);
            ST_ID_Text.Name = "ST_ID_Text";
            ST_ID_Text.Size = new Size(114, 27);
            ST_ID_Text.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Architecture", "Art", "Business", "ComputerScience" });
            comboBox1.Location = new Point(32, 214);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(241, 26);
            label1.TabIndex = 6;
            label1.Text = "Lastest Information";
            // 
            // GpxText
            // 
            GpxText.Location = new Point(299, 145);
            GpxText.Margin = new Padding(3, 4, 3, 4);
            GpxText.Name = "GpxText";
            GpxText.Size = new Size(114, 27);
            GpxText.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Dr_John", "Dr_Emily", "Prof_Michael", "Dr_Linda" });
            comboBox2.Location = new Point(168, 214);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(114, 28);
            comboBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 33);
            label2.Name = "label2";
            label2.Size = new Size(143, 26);
            label2.TabIndex = 9;
            label2.Text = "Most Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 117);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 117);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 11;
            label4.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 117);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 12;
            label5.Text = "Gpx";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 189);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Major";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 189);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 14;
            label7.Text = "Advisor";
            label7.Click += label7_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Dr_John", "Dr_Emily", "Prof_Michael" });
            comboBox3.Location = new Point(43, 130);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(114, 28);
            comboBox3.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 196);
            label8.Name = "label8";
            label8.Size = new Size(139, 26);
            label8.TabIndex = 16;
            label8.Text = "Professor :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(ST_ID_Text);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(NameTextbox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(GpxText);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(529, 274);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(132, 53);
            label9.Name = "label9";
            label9.Size = new Size(247, 26);
            label9.TabIndex = 21;
            label9.Text = "Student Information";
            label9.Click += label9_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(953, 144);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(261, 325);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(607, 144);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(278, 325);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // ข้อมูลอาจารย์
            // 
            ข้อมูลอาจารย์.Controls.Add(label10);
            ข้อมูลอาจารย์.Controls.Add(button2);
            ข้อมูลอาจารย์.Controls.Add(comboBox3);
            ข้อมูลอาจารย์.Controls.Add(label8);
            ข้อมูลอาจารย์.Location = new Point(90, 311);
            ข้อมูลอาจารย์.Margin = new Padding(3, 4, 3, 4);
            ข้อมูลอาจารย์.Name = "ข้อมูลอาจารย์";
            ข้อมูลอาจารย์.Padding = new Padding(3, 4, 3, 4);
            ข้อมูลอาจารย์.Size = new Size(337, 457);
            ข้อมูลอาจารย์.TabIndex = 20;
            ข้อมูลอาจารย์.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 38);
            label10.Name = "label10";
            label10.Size = new Size(273, 26);
            label10.TabIndex = 22;
            label10.Text = "Professor Information";
            // 
            // label11
            // 
            label11.AutoEllipsis = true;
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(665, 114);
            label11.Name = "label11";
            label11.Size = new Size(143, 26);
            label11.TabIndex = 10;
            label11.Text = "Most Score";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(959, 114);
            label12.Name = "label12";
            label12.Size = new Size(241, 26);
            label12.TabIndex = 7;
            label12.Text = "Lastest Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1315, 798);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(ข้อมูลอาจารย์);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ข้อมูลอาจารย์.ResumeLayout(false);
            ข้อมูลอาจารย์.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox NameTextbox;
        private TextBox ST_ID_Text;
        private BindingSource bindingSource1;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox GpxText;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox3;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox ข้อมูลอาจารย์;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
