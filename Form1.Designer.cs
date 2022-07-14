
namespace Kolko_i_krzyżyk
{
    partial class Menu
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
            this.PlayerVsPlayer = new System.Windows.Forms.Button();
            this.PlayerVsComputer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_it = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerVsPlayer
            // 
            this.PlayerVsPlayer.Location = new System.Drawing.Point(12, 51);
            this.PlayerVsPlayer.Name = "PlayerVsPlayer";
            this.PlayerVsPlayer.Size = new System.Drawing.Size(247, 23);
            this.PlayerVsPlayer.TabIndex = 0;
            this.PlayerVsPlayer.Text = "Gracz kontra gracz";
            this.PlayerVsPlayer.UseVisualStyleBackColor = true;
            this.PlayerVsPlayer.Click += new System.EventHandler(this.PlayerVsPlayer_Click);
            // 
            // PlayerVsComputer
            // 
            this.PlayerVsComputer.Location = new System.Drawing.Point(265, 51);
            this.PlayerVsComputer.Name = "PlayerVsComputer";
            this.PlayerVsComputer.Size = new System.Drawing.Size(242, 23);
            this.PlayerVsComputer.TabIndex = 1;
            this.PlayerVsComputer.Text = "Gracz kontra komputer";
            this.PlayerVsComputer.UseVisualStyleBackColor = true;
            this.PlayerVsComputer.Click += new System.EventHandler(this.PlayerVsComputer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz tryb rozgrywki";
            // 
            // Close_it
            // 
            this.Close_it.Location = new System.Drawing.Point(137, 85);
            this.Close_it.Name = "Close_it";
            this.Close_it.Size = new System.Drawing.Size(247, 23);
            this.Close_it.TabIndex = 3;
            this.Close_it.Text = "Zamknij aplikacje";
            this.Close_it.UseVisualStyleBackColor = true;
            this.Close_it.Click += new System.EventHandler(this.Close_it_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 120);
            this.Controls.Add(this.Close_it);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerVsComputer);
            this.Controls.Add(this.PlayerVsPlayer);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerVsPlayer;
        private System.Windows.Forms.Button PlayerVsComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_it;
    }
}

