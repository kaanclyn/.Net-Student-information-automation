namespace netsunu
{
    partial class Form3
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
            button2 = new Button();
            button7 = new Button();
            label2 = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 291);
            button2.Name = "button2";
            button2.Size = new Size(290, 43);
            button2.TabIndex = 103;
            button2.Text = "Başarıya göre sıralama";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(14, 241);
            button7.Name = "button7";
            button7.Size = new Size(290, 43);
            button7.TabIndex = 102;
            button7.Text = "Numaraya Göre Sıralama";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cornsilk;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(418, 9);
            label2.Name = "label2";
            label2.Size = new Size(319, 38);
            label2.TabIndex = 107;
            label2.Text = "Öğrenci Takip Sistemi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Cornsilk;
            label11.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(62, 195);
            label11.Name = "label11";
            label11.Size = new Size(202, 29);
            label11.TabIndex = 108;
            label11.Text = "Öğrencileri Sırala";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Indigo;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(326, 120);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(799, 424);
            listBox1.TabIndex = 109;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(661, 602);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(153, 41);
            button5.TabIndex = 106;
            button5.Text = "Çıkış";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 341);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(290, 42);
            button3.TabIndex = 104;
            button3.Text = "Başarı notuna göre filtrele";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(586, 552);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(290, 42);
            button4.TabIndex = 105;
            button4.Text = "Öğrenci Ekle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1146, 665);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button7;
        private Label label2;
        private Label label11;
        private ListBox listBox1;
        private Button button5;
        private Button button3;
        private Button button4;
    }
}