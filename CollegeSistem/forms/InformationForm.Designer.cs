namespace CollegeSistem.forms
{
    partial class InformationForm
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
            label_profet = new Label();
            label_cursPrice = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label_getFromS = new Label();
            textBox_num = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_profet
            // 
            label_profet.AutoSize = true;
            label_profet.Location = new Point(445, 317);
            label_profet.Name = "label_profet";
            label_profet.Size = new Size(0, 20);
            label_profet.TabIndex = 0;
            // 
            // label_cursPrice
            // 
            label_cursPrice.AutoSize = true;
            label_cursPrice.Location = new Point(445, 176);
            label_cursPrice.Name = "label_cursPrice";
            label_cursPrice.Size = new Size(0, 20);
            label_cursPrice.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(681, 317);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "רווח באחוזים";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 245);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "תשלומים על הקורס";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 176);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "מחיר הקורס";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 75);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "הכנס מספר קורס";
            // 
            // label_getFromS
            // 
            label_getFromS.AutoSize = true;
            label_getFromS.Location = new Point(473, 245);
            label_getFromS.Name = "label_getFromS";
            label_getFromS.Size = new Size(0, 20);
            label_getFromS.TabIndex = 6;
            // 
            // textBox_num
            // 
            textBox_num.Location = new Point(340, 121);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(125, 27);
            textBox_num.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(142, 121);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "בדיקה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 464);
            Controls.Add(button1);
            Controls.Add(textBox_num);
            Controls.Add(label_getFromS);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label_cursPrice);
            Controls.Add(label_profet);
            Name = "InformationForm";
            Text = "InformationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_profet;
        private Label label_cursPrice;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label_getFromS;
        private TextBox textBox_num;
        private Button button1;
    }
}