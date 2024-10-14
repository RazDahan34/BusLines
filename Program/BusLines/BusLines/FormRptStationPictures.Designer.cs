namespace BusLines
{
    partial class FormRptStationPictures
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
            this.label2 = new System.Windows.Forms.Label();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lineNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromStation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toStation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(624, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "מסלול קו";
            // 
            // myToolTip
            // 
            this.myToolTip.Active = false;
            // 
            // lineNumber
            // 
            this.lineNumber.AutoSize = true;
            this.lineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lineNumber.Location = new System.Drawing.Point(502, 37);
            this.lineNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(99, 32);
            this.lineNumber.TabIndex = 5;
            this.lineNumber.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1181, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ": תחנת מקור";
            // 
            // fromStation
            // 
            this.fromStation.Location = new System.Drawing.Point(850, 43);
            this.fromStation.Name = "fromStation";
            this.fromStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromStation.Size = new System.Drawing.Size(315, 26);
            this.fromStation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = ":תחנת יעד";
            // 
            // toStation
            // 
            this.toStation.Location = new System.Drawing.Point(78, 43);
            this.toStation.Name = "toStation";
            this.toStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toStation.Size = new System.Drawing.Size(294, 26);
            this.toStation.TabIndex = 9;
            // 
            // FormRptStationPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1321, 728);
            this.Controls.Add(this.toStation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRptStationPictures";
            this.Text = "FormRptStationPictures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Label lineNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toStation;
    }
}