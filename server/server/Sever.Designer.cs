namespace server
{
    partial class Sever
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(80, 39);
            this.txtChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(947, 359);
            this.txtChat.TabIndex = 11;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(1088, 79);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 52);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(892, 448);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(135, 60);
            this.btnGui.TabIndex = 12;
            this.btnGui.Text = "Send";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1088, 212);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 52);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(80, 448);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(787, 60);
            this.txtMessage.TabIndex = 14;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 648);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sever";
            this.Text = "Sever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

