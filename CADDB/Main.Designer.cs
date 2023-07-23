namespace CADDB
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadBlocksWithAttributes = new System.Windows.Forms.Button();
            this.btnLoadBlockNoAttribute = new System.Windows.Forms.Button();
            this.btnLoadPlines = new System.Windows.Forms.Button();
            this.btnLoadMText = new System.Windows.Forms.Button();
            this.btnLoadLines = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetrieveMTexts = new System.Windows.Forms.Button();
            this.btnRetrieveLines = new System.Windows.Forms.Button();
            this.btnRetrieveDrawPLines = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadBlocksWithAttributes);
            this.groupBox1.Controls.Add(this.btnLoadBlockNoAttribute);
            this.groupBox1.Controls.Add(this.btnLoadPlines);
            this.groupBox1.Controls.Add(this.btnLoadMText);
            this.groupBox1.Controls.Add(this.btnLoadLines);
            this.groupBox1.Location = new System.Drawing.Point(33, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // btnLoadBlocksWithAttributes
            // 
            this.btnLoadBlocksWithAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadBlocksWithAttributes.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadBlocksWithAttributes.Location = new System.Drawing.Point(13, 260);
            this.btnLoadBlocksWithAttributes.Name = "btnLoadBlocksWithAttributes";
            this.btnLoadBlocksWithAttributes.Size = new System.Drawing.Size(150, 50);
            this.btnLoadBlocksWithAttributes.TabIndex = 3;
            this.btnLoadBlocksWithAttributes.Text = "Load Blocks With Attributes";
            this.btnLoadBlocksWithAttributes.UseVisualStyleBackColor = false;
            this.btnLoadBlocksWithAttributes.Click += new System.EventHandler(this.btnLoadBlocksWithAttributes_Click);
            // 
            // btnLoadBlockNoAttribute
            // 
            this.btnLoadBlockNoAttribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadBlockNoAttribute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadBlockNoAttribute.Location = new System.Drawing.Point(13, 201);
            this.btnLoadBlockNoAttribute.Name = "btnLoadBlockNoAttribute";
            this.btnLoadBlockNoAttribute.Size = new System.Drawing.Size(150, 50);
            this.btnLoadBlockNoAttribute.TabIndex = 2;
            this.btnLoadBlockNoAttribute.Text = "Load Blocks No Attribute";
            this.btnLoadBlockNoAttribute.UseVisualStyleBackColor = false;
            this.btnLoadBlockNoAttribute.Click += new System.EventHandler(this.btnLoadBlockNoAttribute_Click);
            // 
            // btnLoadPlines
            // 
            this.btnLoadPlines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadPlines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadPlines.Location = new System.Drawing.Point(13, 141);
            this.btnLoadPlines.Name = "btnLoadPlines";
            this.btnLoadPlines.Size = new System.Drawing.Size(150, 50);
            this.btnLoadPlines.TabIndex = 1;
            this.btnLoadPlines.Text = "Load Polylines";
            this.btnLoadPlines.UseVisualStyleBackColor = false;
            this.btnLoadPlines.Click += new System.EventHandler(this.btnLoadPlines_Click);
            // 
            // btnLoadMText
            // 
            this.btnLoadMText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadMText.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadMText.Location = new System.Drawing.Point(13, 83);
            this.btnLoadMText.Name = "btnLoadMText";
            this.btnLoadMText.Size = new System.Drawing.Size(150, 50);
            this.btnLoadMText.TabIndex = 1;
            this.btnLoadMText.Text = "Load MTexts";
            this.btnLoadMText.UseVisualStyleBackColor = false;
            this.btnLoadMText.Click += new System.EventHandler(this.btnLoadMText_Click);
            // 
            // btnLoadLines
            // 
            this.btnLoadLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadLines.Location = new System.Drawing.Point(13, 26);
            this.btnLoadLines.Name = "btnLoadLines";
            this.btnLoadLines.Size = new System.Drawing.Size(150, 50);
            this.btnLoadLines.TabIndex = 0;
            this.btnLoadLines.Text = "Load Lines";
            this.btnLoadLines.UseVisualStyleBackColor = false;
            this.btnLoadLines.Click += new System.EventHandler(this.btnLoadLines_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(31, 371);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(11, 12);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetrieveDrawPLines);
            this.groupBox2.Controls.Add(this.btnRetrieveMTexts);
            this.groupBox2.Controls.Add(this.btnRetrieveLines);
            this.groupBox2.Location = new System.Drawing.Point(227, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retrieve";
            // 
            // btnRetrieveMTexts
            // 
            this.btnRetrieveMTexts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRetrieveMTexts.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRetrieveMTexts.Location = new System.Drawing.Point(17, 84);
            this.btnRetrieveMTexts.Name = "btnRetrieveMTexts";
            this.btnRetrieveMTexts.Size = new System.Drawing.Size(150, 50);
            this.btnRetrieveMTexts.TabIndex = 1;
            this.btnRetrieveMTexts.Text = "Retrieve MTexts";
            this.btnRetrieveMTexts.UseVisualStyleBackColor = false;
            this.btnRetrieveMTexts.Click += new System.EventHandler(this.btnRetrieveMTexts_Click);
            // 
            // btnRetrieveLines
            // 
            this.btnRetrieveLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRetrieveLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRetrieveLines.Location = new System.Drawing.Point(17, 28);
            this.btnRetrieveLines.Name = "btnRetrieveLines";
            this.btnRetrieveLines.Size = new System.Drawing.Size(150, 50);
            this.btnRetrieveLines.TabIndex = 0;
            this.btnRetrieveLines.Text = "Retrive Lines from DB";
            this.btnRetrieveLines.UseVisualStyleBackColor = false;
            this.btnRetrieveLines.Click += new System.EventHandler(this.btnRetrieveLines_Click);
            // 
            // btnRetrieveDrawPLines
            // 
            this.btnRetrieveDrawPLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRetrieveDrawPLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRetrieveDrawPLines.Location = new System.Drawing.Point(17, 141);
            this.btnRetrieveDrawPLines.Name = "btnRetrieveDrawPLines";
            this.btnRetrieveDrawPLines.Size = new System.Drawing.Size(149, 49);
            this.btnRetrieveDrawPLines.TabIndex = 2;
            this.btnRetrieveDrawPLines.Text = "Retrieve Draw PLines";
            this.btnRetrieveDrawPLines.UseVisualStyleBackColor = false;
            this.btnRetrieveDrawPLines.Click += new System.EventHandler(this.btnRetrieveDrawPLines_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadLines;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLoadMText;
        private System.Windows.Forms.Button btnLoadPlines;
        private System.Windows.Forms.Button btnLoadBlockNoAttribute;
        private System.Windows.Forms.Button btnLoadBlocksWithAttributes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRetrieveLines;
        private System.Windows.Forms.Button btnRetrieveMTexts;
        private System.Windows.Forms.Button btnRetrieveDrawPLines;
    }
}