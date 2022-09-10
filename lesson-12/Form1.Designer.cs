namespace lesson_12
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
            this.NumbInput = new System.Windows.Forms.ListBox();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.Msg = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.ListBox();
            this.Stepbtn = new System.Windows.Forms.Button();
            this.Full_OP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumbInput
            // 
            this.NumbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NumbInput.FormattingEnabled = true;
            this.NumbInput.ItemHeight = 31;
            this.NumbInput.Location = new System.Drawing.Point(339, 12);
            this.NumbInput.Name = "NumbInput";
            this.NumbInput.Size = new System.Drawing.Size(227, 562);
            this.NumbInput.TabIndex = 2;
            this.NumbInput.SelectedIndexChanged += new System.EventHandler(this.Numbinput);
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextInput.Location = new System.Drawing.Point(17, 12);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(316, 564);
            this.TextInput.TabIndex = 3;
            this.TextInput.TextChanged += new System.EventHandler(this.Textinput);
            // 
            // Msg
            // 
            this.Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Msg.Location = new System.Drawing.Point(12, 579);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(321, 62);
            this.Msg.TabIndex = 4;
            this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Output.FormattingEnabled = true;
            this.Output.ItemHeight = 31;
            this.Output.Location = new System.Drawing.Point(600, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(227, 562);
            this.Output.TabIndex = 5;
            // 
            // Stepbtn
            // 
            this.Stepbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Stepbtn.Location = new System.Drawing.Point(339, 580);
            this.Stepbtn.Name = "Stepbtn";
            this.Stepbtn.Size = new System.Drawing.Size(227, 69);
            this.Stepbtn.TabIndex = 6;
            this.Stepbtn.Text = "Step";
            this.Stepbtn.UseVisualStyleBackColor = true;
            this.Stepbtn.Click += new System.EventHandler(this.Step);
            // 
            // Full_OP
            // 
            this.Full_OP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Full_OP.Location = new System.Drawing.Point(600, 580);
            this.Full_OP.Name = "Full_OP";
            this.Full_OP.Size = new System.Drawing.Size(227, 69);
            this.Full_OP.TabIndex = 7;
            this.Full_OP.Text = "Full sequence";
            this.Full_OP.UseVisualStyleBackColor = true;
            this.Full_OP.Click += new System.EventHandler(this.FullOP);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 674);
            this.Controls.Add(this.Full_OP);
            this.Controls.Add(this.Stepbtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.NumbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox NumbInput;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Button Stepbtn;
        private System.Windows.Forms.Button Full_OP;
    }
}

