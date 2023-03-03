
namespace дз10
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
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(287, 90);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(174, 27);
            this.TopLevelMenu.TabIndex = 0;
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(287, 269);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(174, 27);
            this.SubItem.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(26, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(241, 409);
            this.treeView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(287, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "SubMenu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add SubMenu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

