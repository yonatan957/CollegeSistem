namespace CollegeSistem.forms
{
    partial class CreateTopic
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
            textBox_Tname = new TextBox();
            textBox_CID = new TextBox();
            textBox_TID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button_addTopic = new Button();
            textBox_hours = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox_Tname
            // 
            textBox_Tname.Location = new Point(293, 249);
            textBox_Tname.Name = "textBox_Tname";
            textBox_Tname.Size = new Size(263, 27);
            textBox_Tname.TabIndex = 0;
            // 
            // textBox_CID
            // 
            textBox_CID.Location = new Point(293, 150);
            textBox_CID.Name = "textBox_CID";
            textBox_CID.Size = new Size(263, 27);
            textBox_CID.TabIndex = 1;
            // 
            // textBox_TID
            // 
            textBox_TID.Location = new Point(293, 63);
            textBox_TID.Name = "textBox_TID";
            textBox_TID.Size = new Size(263, 27);
            textBox_TID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(680, 256);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "שם הנושא";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(675, 157);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "מספר קורס";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 63);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "מספר מורה";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(734, 412);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(42, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "חזרה";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button_addTopic
            // 
            button_addTopic.Location = new Point(31, 403);
            button_addTopic.Name = "button_addTopic";
            button_addTopic.Size = new Size(94, 29);
            button_addTopic.TabIndex = 7;
            button_addTopic.Text = "אישור";
            button_addTopic.UseVisualStyleBackColor = true;
            button_addTopic.Click += button_addTopic_Click;
            // 
            // textBox_hours
            // 
            textBox_hours.Location = new Point(293, 343);
            textBox_hours.Name = "textBox_hours";
            textBox_hours.Size = new Size(263, 27);
            textBox_hours.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(671, 346);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "מספר שעות";
            // 
            // CreateTopic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox_hours);
            Controls.Add(button_addTopic);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_TID);
            Controls.Add(textBox_CID);
            Controls.Add(textBox_Tname);
            Name = "CreateTopic";
            Text = "CreateTopic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Tname;
        private TextBox textBox_CID;
        private TextBox textBox_TID;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button_addTopic;
        private TextBox textBox_hours;
        private Label label4;
    }
}