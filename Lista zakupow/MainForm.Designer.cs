
namespace Lista_zakupow
{
    partial class MainForm
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
            this.produktBox = new System.Windows.Forms.TextBox();
            this.wagaBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.produktHeader = new System.Windows.Forms.ColumnHeader();
            this.wagaHeader = new System.Windows.Forms.ColumnHeader();
            this.wagaLacznieHeader = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // produktBox
            // 
            this.produktBox.Location = new System.Drawing.Point(12, 30);
            this.produktBox.Name = "produktBox";
            this.produktBox.Size = new System.Drawing.Size(100, 23);
            this.produktBox.TabIndex = 0;
            // 
            // wagaBox
            // 
            this.wagaBox.Location = new System.Drawing.Point(12, 89);
            this.wagaBox.Name = "wagaBox";
            this.wagaBox.Size = new System.Drawing.Size(100, 23);
            this.wagaBox.TabIndex = 1;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(12, 118);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.produktHeader,
            this.wagaHeader,
            this.wagaLacznieHeader});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(118, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 426);
            this.listView1.TabIndex = 3;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // produktHeader
            // 
            this.produktHeader.Text = "Produkt";
            this.produktHeader.Width = 150;
            // 
            // wagaHeader
            // 
            this.wagaHeader.Text = "Waga";
            this.wagaHeader.Width = 100;
            // 
            // wagaLacznieHeader
            // 
            this.wagaLacznieHeader.Text = "I+Ł";
            this.wagaLacznieHeader.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Waga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.wagaBox);
            this.Controls.Add(this.produktBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator zakupów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox produktBox;
        private System.Windows.Forms.TextBox wagaBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader produktHeader;
        private System.Windows.Forms.ColumnHeader wagaHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader wagaLacznieHeader;
    }
}

