namespace CollegeSistem.forms
{
    partial class home_page
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
            button_addtopic = new Button();
            button_addcurse = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_addtopic
            // 
            button_addtopic.Location = new Point(280, 193);
            button_addtopic.Name = "button_addtopic";
            button_addtopic.Size = new Size(256, 93);
            button_addtopic.TabIndex = 0;
            button_addtopic.Text = "הוסף נושא";
            button_addtopic.UseVisualStyleBackColor = true;
            button_addtopic.Click += button_addtopic_Click;
            // 
            // button_addcurse
            // 
            button_addcurse.Location = new Point(280, 50);
            button_addcurse.Name = "button_addcurse";
            button_addcurse.Size = new Size(256, 95);
            button_addcurse.TabIndex = 1;
            button_addcurse.Text = "צור קורס";
            button_addcurse.UseVisualStyleBackColor = true;
            button_addcurse.Click += button_addcurse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(280, 336);
            button1.Name = "button1";
            button1.Size = new Size(256, 90);
            button1.TabIndex = 2;
            button1.Text = "מידע";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_addcurse);
            Controls.Add(button_addtopic);
            Name = "home_page";
            Text = "home_page";
            ResumeLayout(false);
        }

        #endregion

        private Button button_addtopic;
        private Button button_addcurse;
        private Button button1;
    }
}