namespace Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shovelText = new System.Windows.Forms.TextBox();
            this.carrotText = new System.Windows.Forms.TextBox();
            this.radishText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxesLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.changebutton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.costSlabel = new System.Windows.Forms.Label();
            this.costRlabel = new System.Windows.Forms.Label();
            this.costClabel = new System.Windows.Forms.Label();
            this.showbutton = new System.Windows.Forms.Button();
            this.shovelLabel = new System.Windows.Forms.Label();
            this.raddishLabel = new System.Windows.Forms.Label();
            this.carrotLabel = new System.Windows.Forms.Label();
            this.neworderbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subtotaltitleLabel = new System.Windows.Forms.Label();
            this.taxtitleLabel = new System.Windows.Forms.Label();
            this.totaltitleLabel = new System.Windows.Forms.Label();
            this.tenderedtitleLabel = new System.Windows.Forms.Label();
            this.changetitleLabel = new System.Windows.Forms.Label();
            this.shoptitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shovelText
            // 
            this.shovelText.Location = new System.Drawing.Point(187, 42);
            this.shovelText.Name = "shovelText";
            this.shovelText.Size = new System.Drawing.Size(100, 20);
            this.shovelText.TabIndex = 0;
            // 
            // carrotText
            // 
            this.carrotText.Location = new System.Drawing.Point(187, 119);
            this.carrotText.Name = "carrotText";
            this.carrotText.Size = new System.Drawing.Size(100, 20);
            this.carrotText.TabIndex = 1;
            this.carrotText.Tag = "";
            // 
            // radishText
            // 
            this.radishText.Location = new System.Drawing.Point(187, 82);
            this.radishText.Name = "radishText";
            this.radishText.Size = new System.Drawing.Size(100, 20);
            this.radishText.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(172, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLabel.Location = new System.Drawing.Point(184, 264);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtotalLabel.Location = new System.Drawing.Point(184, 169);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subtotalLabel.TabIndex = 5;
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxesLabel
            // 
            this.taxesLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxesLabel.Location = new System.Drawing.Point(184, 217);
            this.taxesLabel.Name = "taxesLabel";
            this.taxesLabel.Size = new System.Drawing.Size(100, 23);
            this.taxesLabel.TabIndex = 6;
            this.taxesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(184, 307);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(100, 20);
            this.tenderedText.TabIndex = 7;
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(172, 333);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(115, 23);
            this.changebutton.TabIndex = 8;
            this.changebutton.Text = "Calculate Change";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeLabel.Location = new System.Drawing.Point(181, 359);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(103, 23);
            this.changeLabel.TabIndex = 9;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptLabel.Location = new System.Drawing.Point(385, 87);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(193, 262);
            this.receiptLabel.TabIndex = 10;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(190, 394);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(87, 23);
            this.printbutton.TabIndex = 11;
            this.printbutton.Text = "Print Receipt";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // costSlabel
            // 
            this.costSlabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.costSlabel.Location = new System.Drawing.Point(293, 42);
            this.costSlabel.Name = "costSlabel";
            this.costSlabel.Size = new System.Drawing.Size(64, 23);
            this.costSlabel.TabIndex = 12;
            this.costSlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costRlabel
            // 
            this.costRlabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.costRlabel.Location = new System.Drawing.Point(293, 82);
            this.costRlabel.Name = "costRlabel";
            this.costRlabel.Size = new System.Drawing.Size(64, 23);
            this.costRlabel.TabIndex = 13;
            this.costRlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costClabel
            // 
            this.costClabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.costClabel.Location = new System.Drawing.Point(293, 119);
            this.costClabel.Name = "costClabel";
            this.costClabel.Size = new System.Drawing.Size(64, 23);
            this.costClabel.TabIndex = 14;
            this.costClabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(54, 12);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(87, 23);
            this.showbutton.TabIndex = 15;
            this.showbutton.Text = "Show Prices";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // shovelLabel
            // 
            this.shovelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shovelLabel.Location = new System.Drawing.Point(62, 42);
            this.shovelLabel.Name = "shovelLabel";
            this.shovelLabel.Size = new System.Drawing.Size(100, 23);
            this.shovelLabel.TabIndex = 16;
            this.shovelLabel.Text = "Shovels";
            this.shovelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // raddishLabel
            // 
            this.raddishLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.raddishLabel.Location = new System.Drawing.Point(62, 79);
            this.raddishLabel.Name = "raddishLabel";
            this.raddishLabel.Size = new System.Drawing.Size(100, 23);
            this.raddishLabel.TabIndex = 17;
            this.raddishLabel.Text = "Raddishes";
            this.raddishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carrotLabel
            // 
            this.carrotLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.carrotLabel.Location = new System.Drawing.Point(62, 117);
            this.carrotLabel.Name = "carrotLabel";
            this.carrotLabel.Size = new System.Drawing.Size(100, 23);
            this.carrotLabel.TabIndex = 18;
            this.carrotLabel.Text = "Carrots";
            this.carrotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // neworderbutton
            // 
            this.neworderbutton.Location = new System.Drawing.Point(432, 371);
            this.neworderbutton.Name = "neworderbutton";
            this.neworderbutton.Size = new System.Drawing.Size(87, 23);
            this.neworderbutton.TabIndex = 19;
            this.neworderbutton.Text = "New Order";
            this.neworderbutton.UseVisualStyleBackColor = true;
            this.neworderbutton.Click += new System.EventHandler(this.neworderbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Shop.Properties.Resources._4714_jpg_wh1200;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-35, -640);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 1187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // subtotaltitleLabel
            // 
            this.subtotaltitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtotaltitleLabel.Location = new System.Drawing.Point(74, 169);
            this.subtotaltitleLabel.Name = "subtotaltitleLabel";
            this.subtotaltitleLabel.Size = new System.Drawing.Size(88, 23);
            this.subtotaltitleLabel.TabIndex = 21;
            this.subtotaltitleLabel.Text = "Subtotal";
            this.subtotaltitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxtitleLabel
            // 
            this.taxtitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxtitleLabel.Location = new System.Drawing.Point(74, 217);
            this.taxtitleLabel.Name = "taxtitleLabel";
            this.taxtitleLabel.Size = new System.Drawing.Size(88, 23);
            this.taxtitleLabel.TabIndex = 22;
            this.taxtitleLabel.Text = "Tax";
            this.taxtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totaltitleLabel
            // 
            this.totaltitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totaltitleLabel.Location = new System.Drawing.Point(74, 264);
            this.totaltitleLabel.Name = "totaltitleLabel";
            this.totaltitleLabel.Size = new System.Drawing.Size(88, 23);
            this.totaltitleLabel.TabIndex = 23;
            this.totaltitleLabel.Text = "Total";
            this.totaltitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedtitleLabel
            // 
            this.tenderedtitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tenderedtitleLabel.Location = new System.Drawing.Point(74, 300);
            this.tenderedtitleLabel.Name = "tenderedtitleLabel";
            this.tenderedtitleLabel.Size = new System.Drawing.Size(88, 23);
            this.tenderedtitleLabel.TabIndex = 24;
            this.tenderedtitleLabel.Text = "Tendered";
            this.tenderedtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changetitleLabel
            // 
            this.changetitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changetitleLabel.Location = new System.Drawing.Point(74, 359);
            this.changetitleLabel.Name = "changetitleLabel";
            this.changetitleLabel.Size = new System.Drawing.Size(88, 23);
            this.changetitleLabel.TabIndex = 25;
            this.changetitleLabel.Text = "Change";
            this.changetitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoptitleLabel
            // 
            this.shoptitleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shoptitleLabel.Location = new System.Drawing.Point(181, 9);
            this.shoptitleLabel.Name = "shoptitleLabel";
            this.shoptitleLabel.Size = new System.Drawing.Size(132, 23);
            this.shoptitleLabel.TabIndex = 26;
            this.shoptitleLabel.Text = "Joe\'s Shop";
            this.shoptitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.shoptitleLabel);
            this.Controls.Add(this.changetitleLabel);
            this.Controls.Add(this.tenderedtitleLabel);
            this.Controls.Add(this.totaltitleLabel);
            this.Controls.Add(this.taxtitleLabel);
            this.Controls.Add(this.subtotaltitleLabel);
            this.Controls.Add(this.neworderbutton);
            this.Controls.Add(this.carrotLabel);
            this.Controls.Add(this.raddishLabel);
            this.Controls.Add(this.shovelLabel);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.costClabel);
            this.Controls.Add(this.costRlabel);
            this.Controls.Add(this.costSlabel);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.taxesLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radishText);
            this.Controls.Add(this.carrotText);
            this.Controls.Add(this.shovelText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Joe\'s Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shovelText;
        private System.Windows.Forms.TextBox carrotText;
        private System.Windows.Forms.TextBox radishText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxesLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Label costSlabel;
        private System.Windows.Forms.Label costRlabel;
        private System.Windows.Forms.Label costClabel;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Label shovelLabel;
        private System.Windows.Forms.Label raddishLabel;
        private System.Windows.Forms.Label carrotLabel;
        private System.Windows.Forms.Button neworderbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label subtotaltitleLabel;
        private System.Windows.Forms.Label taxtitleLabel;
        private System.Windows.Forms.Label totaltitleLabel;
        private System.Windows.Forms.Label tenderedtitleLabel;
        private System.Windows.Forms.Label changetitleLabel;
        private System.Windows.Forms.Label shoptitleLabel;
    }
}

