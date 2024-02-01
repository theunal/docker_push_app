namespace DockerPush
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
            btn = new Button();
            image_txt = new TextBox();
            list_box = new ListBox();
            hub_txt = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(739, 12);
            btn.Name = "btn";
            btn.Size = new Size(114, 27);
            btn.TabIndex = 0;
            btn.Text = "Gönder";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // image_txt
            // 
            image_txt.Location = new Point(12, 12);
            image_txt.Name = "image_txt";
            image_txt.PlaceholderText = "image name";
            image_txt.Size = new Size(374, 27);
            image_txt.TabIndex = 1;
            // 
            // list_box
            // 
            list_box.FormattingEnabled = true;
            list_box.Location = new Point(12, 45);
            list_box.Name = "list_box";
            list_box.Size = new Size(1007, 664);
            list_box.TabIndex = 2;
            // 
            // hub_txt
            // 
            hub_txt.Location = new Point(392, 12);
            hub_txt.Name = "hub_txt";
            hub_txt.PlaceholderText = "hub name";
            hub_txt.Size = new Size(204, 27);
            hub_txt.TabIndex = 3;
            hub_txt.Text = "nordisglobal";
            // 
            // button2
            // 
            button2.Location = new Point(859, 12);
            button2.Name = "button2";
            button2.Size = new Size(160, 27);
            button2.TabIndex = 4;
            button2.Text = "Log Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 716);
            Controls.Add(button2);
            Controls.Add(hub_txt);
            Controls.Add(list_box);
            Controls.Add(image_txt);
            Controls.Add(btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private TextBox image_txt;
        private ListBox list_box;
        private TextBox hub_txt;
        private Button button2;
    }
}
