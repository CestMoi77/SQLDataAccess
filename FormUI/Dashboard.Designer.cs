namespace FormUI
{
    partial class Dashboard
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
            this.searchButton = new System.Windows.Forms.Button();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.PeopleFoundListbox = new System.Windows.Forms.ListBox();
            this.LastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(379, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 49);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(289, 43);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(245, 29);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // PeopleFoundListbox
            // 
            this.PeopleFoundListbox.FormattingEnabled = true;
            this.PeopleFoundListbox.ItemHeight = 24;
            this.PeopleFoundListbox.Location = new System.Drawing.Point(137, 195);
            this.PeopleFoundListbox.Name = "PeopleFoundListbox";
            this.PeopleFoundListbox.Size = new System.Drawing.Size(421, 220);
            this.PeopleFoundListbox.TabIndex = 2;
            this.PeopleFoundListbox.SelectedIndexChanged += new System.EventHandler(this.PeopleFoundListbox_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(149, 47);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(101, 25);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "LastName";
            this.LastName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.PeopleFoundListbox);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.searchButton);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.ListBox PeopleFoundListbox;
        private System.Windows.Forms.Label LastName;
    }
}

