namespace ClickerGame
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
            this.components = new System.ComponentModel.Container();
            this.lblPointsTotal = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBuyUpgrade1 = new System.Windows.Forms.Button();
            this.lblUpgrade1Name = new System.Windows.Forms.Label();
            this.lblUpgrade1owned = new System.Windows.Forms.Label();
            this.lblPointsPerSecond = new System.Windows.Forms.Label();
            this.lblUpgrade1Cost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPointsTotal
            // 
            this.lblPointsTotal.AutoSize = true;
            this.lblPointsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsTotal.Location = new System.Drawing.Point(30, 27);
            this.lblPointsTotal.Name = "lblPointsTotal";
            this.lblPointsTotal.Size = new System.Drawing.Size(205, 55);
            this.lblPointsTotal.TabIndex = 0;
            this.lblPointsTotal.Text = "0 Points";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.Location = new System.Drawing.Point(1003, 574);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(249, 217);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBuyUpgrade1
            // 
            this.btnBuyUpgrade1.Location = new System.Drawing.Point(254, 166);
            this.btnBuyUpgrade1.Name = "btnBuyUpgrade1";
            this.btnBuyUpgrade1.Size = new System.Drawing.Size(195, 63);
            this.btnBuyUpgrade1.TabIndex = 2;
            this.btnBuyUpgrade1.Text = "Buy";
            this.btnBuyUpgrade1.UseVisualStyleBackColor = true;
            this.btnBuyUpgrade1.Click += new System.EventHandler(this.btnBuyUpgrade1_Click);
            // 
            // lblUpgrade1Name
            // 
            this.lblUpgrade1Name.AutoSize = true;
            this.lblUpgrade1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1Name.Location = new System.Drawing.Point(40, 166);
            this.lblUpgrade1Name.Name = "lblUpgrade1Name";
            this.lblUpgrade1Name.Size = new System.Drawing.Size(121, 25);
            this.lblUpgrade1Name.TabIndex = 3;
            this.lblUpgrade1Name.Text = "Upgrade 1";
            // 
            // lblUpgrade1owned
            // 
            this.lblUpgrade1owned.AutoSize = true;
            this.lblUpgrade1owned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1owned.Location = new System.Drawing.Point(456, 166);
            this.lblUpgrade1owned.Name = "lblUpgrade1owned";
            this.lblUpgrade1owned.Size = new System.Drawing.Size(104, 25);
            this.lblUpgrade1owned.TabIndex = 4;
            this.lblUpgrade1owned.Text = "0 Owend";
            // 
            // lblPointsPerSecond
            // 
            this.lblPointsPerSecond.AutoSize = true;
            this.lblPointsPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsPerSecond.Location = new System.Drawing.Point(40, 86);
            this.lblPointsPerSecond.Name = "lblPointsPerSecond";
            this.lblPointsPerSecond.Size = new System.Drawing.Size(58, 20);
            this.lblPointsPerSecond.TabIndex = 5;
            this.lblPointsPerSecond.Text = "0 pp/s";
            // 
            // lblUpgrade1Cost
            // 
            this.lblUpgrade1Cost.AutoSize = true;
            this.lblUpgrade1Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1Cost.Location = new System.Drawing.Point(456, 204);
            this.lblUpgrade1Cost.Name = "lblUpgrade1Cost";
            this.lblUpgrade1Cost.Size = new System.Drawing.Size(81, 25);
            this.lblUpgrade1Cost.TabIndex = 6;
            this.lblUpgrade1Cost.Text = "Cost : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 803);
            this.Controls.Add(this.lblUpgrade1Cost);
            this.Controls.Add(this.lblPointsPerSecond);
            this.Controls.Add(this.lblUpgrade1owned);
            this.Controls.Add(this.lblUpgrade1Name);
            this.Controls.Add(this.btnBuyUpgrade1);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.lblPointsTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPointsTotal;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnBuyUpgrade1;
        private System.Windows.Forms.Label lblUpgrade1Name;
        private System.Windows.Forms.Label lblUpgrade1owned;
        private System.Windows.Forms.Label lblPointsPerSecond;
        private System.Windows.Forms.Label lblUpgrade1Cost;
    }
}

