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
            this.btnBuyBuilding1 = new System.Windows.Forms.Button();
            this.lblBuilding1Name = new System.Windows.Forms.Label();
            this.lblBuilding1owned = new System.Windows.Forms.Label();
            this.lblPointsPerSecond = new System.Windows.Forms.Label();
            this.lblBuilding1Cost = new System.Windows.Forms.Label();
            this.lblBuilding2Cost = new System.Windows.Forms.Label();
            this.lblBuilding2owned = new System.Windows.Forms.Label();
            this.lblBuilding2Name = new System.Windows.Forms.Label();
            this.btnBuyBuilding2 = new System.Windows.Forms.Button();
            this.lblBuilding1production = new System.Windows.Forms.Label();
            this.lblBuilding2production = new System.Windows.Forms.Label();
            this.lblUpgrade1Effect = new System.Windows.Forms.Label();
            this.lblUpgrade1Cost = new System.Windows.Forms.Label();
            this.lblUpgrade1Owned = new System.Windows.Forms.Label();
            this.lblUpgrade1Name = new System.Windows.Forms.Label();
            this.btnBuyUpgrade1 = new System.Windows.Forms.Button();
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
            this.btnClickMe.Location = new System.Drawing.Point(1115, 611);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(300, 300);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBuyBuilding1
            // 
            this.btnBuyBuilding1.Location = new System.Drawing.Point(254, 166);
            this.btnBuyBuilding1.Name = "btnBuyBuilding1";
            this.btnBuyBuilding1.Size = new System.Drawing.Size(195, 63);
            this.btnBuyBuilding1.TabIndex = 2;
            this.btnBuyBuilding1.Text = "Buy";
            this.btnBuyBuilding1.UseVisualStyleBackColor = true;
            this.btnBuyBuilding1.Click += new System.EventHandler(this.btnBuyBuilding1_Click);
            // 
            // lblBuilding1Name
            // 
            this.lblBuilding1Name.AutoSize = true;
            this.lblBuilding1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding1Name.Location = new System.Drawing.Point(40, 166);
            this.lblBuilding1Name.Name = "lblBuilding1Name";
            this.lblBuilding1Name.Size = new System.Drawing.Size(117, 25);
            this.lblBuilding1Name.TabIndex = 3;
            this.lblBuilding1Name.Text = "Building 1";
            // 
            // lblBuilding1owned
            // 
            this.lblBuilding1owned.AutoSize = true;
            this.lblBuilding1owned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding1owned.Location = new System.Drawing.Point(40, 204);
            this.lblBuilding1owned.Name = "lblBuilding1owned";
            this.lblBuilding1owned.Size = new System.Drawing.Size(104, 25);
            this.lblBuilding1owned.TabIndex = 4;
            this.lblBuilding1owned.Text = "0 Owned";
            // 
            // lblPointsPerSecond
            // 
            this.lblPointsPerSecond.AutoSize = true;
            this.lblPointsPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsPerSecond.Location = new System.Drawing.Point(40, 86);
            this.lblPointsPerSecond.Name = "lblPointsPerSecond";
            this.lblPointsPerSecond.Size = new System.Drawing.Size(67, 24);
            this.lblPointsPerSecond.TabIndex = 5;
            this.lblPointsPerSecond.Text = "0 pp/s";
            // 
            // lblBuilding1Cost
            // 
            this.lblBuilding1Cost.AutoSize = true;
            this.lblBuilding1Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding1Cost.Location = new System.Drawing.Point(456, 204);
            this.lblBuilding1Cost.Name = "lblBuilding1Cost";
            this.lblBuilding1Cost.Size = new System.Drawing.Size(81, 25);
            this.lblBuilding1Cost.TabIndex = 6;
            this.lblBuilding1Cost.Text = "Cost : ";
            // 
            // lblBuilding2Cost
            // 
            this.lblBuilding2Cost.AutoSize = true;
            this.lblBuilding2Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding2Cost.Location = new System.Drawing.Point(456, 289);
            this.lblBuilding2Cost.Name = "lblBuilding2Cost";
            this.lblBuilding2Cost.Size = new System.Drawing.Size(81, 25);
            this.lblBuilding2Cost.TabIndex = 10;
            this.lblBuilding2Cost.Tag = "";
            this.lblBuilding2Cost.Text = "Cost : ";
            // 
            // lblBuilding2owned
            // 
            this.lblBuilding2owned.AutoSize = true;
            this.lblBuilding2owned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding2owned.Location = new System.Drawing.Point(40, 289);
            this.lblBuilding2owned.Name = "lblBuilding2owned";
            this.lblBuilding2owned.Size = new System.Drawing.Size(104, 25);
            this.lblBuilding2owned.TabIndex = 9;
            this.lblBuilding2owned.Text = "0 Owned";
            // 
            // lblBuilding2Name
            // 
            this.lblBuilding2Name.AutoSize = true;
            this.lblBuilding2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding2Name.Location = new System.Drawing.Point(40, 251);
            this.lblBuilding2Name.Name = "lblBuilding2Name";
            this.lblBuilding2Name.Size = new System.Drawing.Size(117, 25);
            this.lblBuilding2Name.TabIndex = 8;
            this.lblBuilding2Name.Text = "Building 2";
            // 
            // btnBuyBuilding2
            // 
            this.btnBuyBuilding2.Location = new System.Drawing.Point(254, 251);
            this.btnBuyBuilding2.Name = "btnBuyBuilding2";
            this.btnBuyBuilding2.Size = new System.Drawing.Size(195, 63);
            this.btnBuyBuilding2.TabIndex = 7;
            this.btnBuyBuilding2.Text = "Buy";
            this.btnBuyBuilding2.UseVisualStyleBackColor = true;
            this.btnBuyBuilding2.Click += new System.EventHandler(this.btnBuyBuilding2_Click);
            // 
            // lblBuilding1production
            // 
            this.lblBuilding1production.AutoSize = true;
            this.lblBuilding1production.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding1production.Location = new System.Drawing.Point(456, 166);
            this.lblBuilding1production.Name = "lblBuilding1production";
            this.lblBuilding1production.Size = new System.Drawing.Size(77, 25);
            this.lblBuilding1production.TabIndex = 11;
            this.lblBuilding1production.Text = "0 pp/s";
            // 
            // lblBuilding2production
            // 
            this.lblBuilding2production.AutoSize = true;
            this.lblBuilding2production.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding2production.Location = new System.Drawing.Point(456, 251);
            this.lblBuilding2production.Name = "lblBuilding2production";
            this.lblBuilding2production.Size = new System.Drawing.Size(77, 25);
            this.lblBuilding2production.TabIndex = 12;
            this.lblBuilding2production.Text = "0 pp/s";
            // 
            // lblUpgrade1Effect
            // 
            this.lblUpgrade1Effect.AutoSize = true;
            this.lblUpgrade1Effect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1Effect.Location = new System.Drawing.Point(1153, 166);
            this.lblUpgrade1Effect.Name = "lblUpgrade1Effect";
            this.lblUpgrade1Effect.Size = new System.Drawing.Size(239, 25);
            this.lblUpgrade1Effect.TabIndex = 17;
            this.lblUpgrade1Effect.Text = "Effect : 2x Production";
            // 
            // lblUpgrade1Cost
            // 
            this.lblUpgrade1Cost.AutoSize = true;
            this.lblUpgrade1Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1Cost.Location = new System.Drawing.Point(1153, 204);
            this.lblUpgrade1Cost.Name = "lblUpgrade1Cost";
            this.lblUpgrade1Cost.Size = new System.Drawing.Size(81, 25);
            this.lblUpgrade1Cost.TabIndex = 16;
            this.lblUpgrade1Cost.Text = "Cost : ";
            // 
            // lblUpgrade1Owned
            // 
            this.lblUpgrade1Owned.AutoSize = true;
            this.lblUpgrade1Owned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1Owned.Location = new System.Drawing.Point(737, 204);
            this.lblUpgrade1Owned.Name = "lblUpgrade1Owned";
            this.lblUpgrade1Owned.Size = new System.Drawing.Size(104, 25);
            this.lblUpgrade1Owned.TabIndex = 15;
            this.lblUpgrade1Owned.Text = "0 Owned";
            // 
            // lblUpgrade1Name
            // 
            this.lblUpgrade1Name.AutoSize = true;
            this.lblUpgrade1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgrade1Name.Location = new System.Drawing.Point(737, 166);
            this.lblUpgrade1Name.Name = "lblUpgrade1Name";
            this.lblUpgrade1Name.Size = new System.Drawing.Size(121, 25);
            this.lblUpgrade1Name.TabIndex = 14;
            this.lblUpgrade1Name.Text = "Upgrade 1";
            // 
            // btnBuyUpgrade1
            // 
            this.btnBuyUpgrade1.Location = new System.Drawing.Point(951, 166);
            this.btnBuyUpgrade1.Name = "btnBuyUpgrade1";
            this.btnBuyUpgrade1.Size = new System.Drawing.Size(195, 63);
            this.btnBuyUpgrade1.TabIndex = 13;
            this.btnBuyUpgrade1.Text = "Buy";
            this.btnBuyUpgrade1.UseVisualStyleBackColor = true;
            this.btnBuyUpgrade1.Click += new System.EventHandler(this.btnBuyUpgrade1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 923);
            this.Controls.Add(this.lblUpgrade1Effect);
            this.Controls.Add(this.lblUpgrade1Cost);
            this.Controls.Add(this.lblUpgrade1Owned);
            this.Controls.Add(this.lblUpgrade1Name);
            this.Controls.Add(this.btnBuyUpgrade1);
            this.Controls.Add(this.lblBuilding2production);
            this.Controls.Add(this.lblBuilding1production);
            this.Controls.Add(this.lblBuilding2Cost);
            this.Controls.Add(this.lblBuilding2owned);
            this.Controls.Add(this.lblBuilding2Name);
            this.Controls.Add(this.btnBuyBuilding2);
            this.Controls.Add(this.lblBuilding1Cost);
            this.Controls.Add(this.lblPointsPerSecond);
            this.Controls.Add(this.lblBuilding1owned);
            this.Controls.Add(this.lblBuilding1Name);
            this.Controls.Add(this.btnBuyBuilding1);
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
        private System.Windows.Forms.Button btnBuyBuilding1;
        private System.Windows.Forms.Label lblBuilding1Name;
        private System.Windows.Forms.Label lblBuilding1owned;
        private System.Windows.Forms.Label lblPointsPerSecond;
        private System.Windows.Forms.Label lblBuilding1Cost;
        private System.Windows.Forms.Label lblBuilding2Cost;
        private System.Windows.Forms.Label lblBuilding2owned;
        private System.Windows.Forms.Label lblBuilding2Name;
        private System.Windows.Forms.Button btnBuyBuilding2;
        private System.Windows.Forms.Label lblBuilding1production;
        private System.Windows.Forms.Label lblBuilding2production;
        private System.Windows.Forms.Label lblUpgrade1Effect;
        private System.Windows.Forms.Label lblUpgrade1Cost;
        private System.Windows.Forms.Label lblUpgrade1Owned;
        private System.Windows.Forms.Label lblUpgrade1Name;
        private System.Windows.Forms.Button btnBuyUpgrade1;
    }
}

