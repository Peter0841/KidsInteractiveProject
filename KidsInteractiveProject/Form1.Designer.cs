namespace KidsInteractiveProject
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
            this.tblCodeArea = new System.Windows.Forms.TableLayoutPanel();
            this.pbFoward = new System.Windows.Forms.PictureBox();
            this.pbBackward = new System.Windows.Forms.PictureBox();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.lblList = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCodeArea
            // 
            this.tblCodeArea.ColumnCount = 5;
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tblCodeArea.Location = new System.Drawing.Point(12, 280);
            this.tblCodeArea.Name = "tblCodeArea";
            this.tblCodeArea.RowCount = 1;
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCodeArea.Size = new System.Drawing.Size(610, 151);
            this.tblCodeArea.TabIndex = 0;
            // 
            // pbFoward
            // 
            this.pbFoward.Image = ((System.Drawing.Image)(resources.GetObject("pbFoward.Image")));
            this.pbFoward.Location = new System.Drawing.Point(12, 25);
            this.pbFoward.Name = "pbFoward";
            this.pbFoward.Size = new System.Drawing.Size(111, 58);
            this.pbFoward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoward.TabIndex = 1;
            this.pbFoward.TabStop = false;
            this.pbFoward.Tag = "Right";
            this.pbFoward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbBackward
            // 
            this.pbBackward.Image = ((System.Drawing.Image)(resources.GetObject("pbBackward.Image")));
            this.pbBackward.Location = new System.Drawing.Point(12, 89);
            this.pbBackward.Name = "pbBackward";
            this.pbBackward.Size = new System.Drawing.Size(111, 57);
            this.pbBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackward.TabIndex = 2;
            this.pbBackward.TabStop = false;
            this.pbBackward.Tag = "Left";
            this.pbBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbUp
            // 
            this.pbUp.Image = ((System.Drawing.Image)(resources.GetObject("pbUp.Image")));
            this.pbUp.Location = new System.Drawing.Point(12, 152);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(111, 58);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUp.TabIndex = 3;
            this.pbUp.TabStop = false;
            this.pbUp.Tag = "Up";
            this.pbUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbDown
            // 
            this.pbDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDown.Image")));
            this.pbDown.Location = new System.Drawing.Point(12, 216);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(111, 58);
            this.pbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDown.TabIndex = 4;
            this.pbDown.TabStop = false;
            this.pbDown.Tag = "Down";
            this.pbDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(129, 25);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(109, 13);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "Movement Sequence";
            // 
            // table
            // 
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.27273F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72727F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.table.Location = new System.Drawing.Point(334, 25);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.58823F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.41177F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.table.Size = new System.Drawing.Size(454, 249);
            this.table.TabIndex = 6;
            // 
            // runButton
            // 
            this.runButton.Image = ((System.Drawing.Image)(resources.GetObject("runButton.Image")));
            this.runButton.Location = new System.Drawing.Point(628, 280);
            this.runButton.Name = "runButton";
            this.runButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.runButton.Size = new System.Drawing.Size(160, 151);
            this.runButton.TabIndex = 7;
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.runButton_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Code Blocks";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, -1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Grid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.table);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.pbBackward);
            this.Controls.Add(this.pbFoward);
            this.Controls.Add(this.tblCodeArea);
            this.Name = "Form1";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCodeArea;
        private System.Windows.Forms.PictureBox pbFoward;
        private System.Windows.Forms.PictureBox pbBackward;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

