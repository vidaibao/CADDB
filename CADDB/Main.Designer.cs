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
            this.button1 = new System.Windows.Forms.Button();
            this.btnRetrieveAnhDrawBlocksNoAttribute = new System.Windows.Forms.Button();
            this.btnRetrieveDrawPLines = new System.Windows.Forms.Button();
            this.btnRetrieveMTexts = new System.Windows.Forms.Button();
            this.btnRetrieveLines = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateBlocksWithAttributes = new System.Windows.Forms.Button();
            this.btnUpdateBlocksNoAttribute = new System.Windows.Forms.Button();
            this.btnUpdatePLines = new System.Windows.Forms.Button();
            this.btnUpdateMTexts = new System.Windows.Forms.Button();
            this.btnUpdateLines = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBlocksWithAttributes = new System.Windows.Forms.Button();
            this.btnDeleteBlocksNoAttribute = new System.Windows.Forms.Button();
            this.btnDeletePLines = new System.Windows.Forms.Button();
            this.btnDeleteMTexts = new System.Windows.Forms.Button();
            this.btnDeleteLines = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnRetrieveAnhDrawBlocksNoAttribute);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(17, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retrieve Draw Blocks With Attributes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRetrieveAnhDrawBlocksNoAttribute
            // 
            this.btnRetrieveAnhDrawBlocksNoAttribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRetrieveAnhDrawBlocksNoAttribute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRetrieveAnhDrawBlocksNoAttribute.Location = new System.Drawing.Point(17, 201);
            this.btnRetrieveAnhDrawBlocksNoAttribute.Name = "btnRetrieveAnhDrawBlocksNoAttribute";
            this.btnRetrieveAnhDrawBlocksNoAttribute.Size = new System.Drawing.Size(150, 50);
            this.btnRetrieveAnhDrawBlocksNoAttribute.TabIndex = 3;
            this.btnRetrieveAnhDrawBlocksNoAttribute.Text = "Retrieve Draw Blocks No Attribute";
            this.btnRetrieveAnhDrawBlocksNoAttribute.UseVisualStyleBackColor = false;
            this.btnRetrieveAnhDrawBlocksNoAttribute.Click += new System.EventHandler(this.btnRetrieveAnhDrawBlocksNoAttribute_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateBlocksWithAttributes);
            this.groupBox3.Controls.Add(this.btnUpdateBlocksNoAttribute);
            this.groupBox3.Controls.Add(this.btnUpdatePLines);
            this.groupBox3.Controls.Add(this.btnUpdateMTexts);
            this.groupBox3.Controls.Add(this.btnUpdateLines);
            this.groupBox3.Location = new System.Drawing.Point(433, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 329);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // btnUpdateBlocksWithAttributes
            // 
            this.btnUpdateBlocksWithAttributes.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateBlocksWithAttributes.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateBlocksWithAttributes.Location = new System.Drawing.Point(17, 260);
            this.btnUpdateBlocksWithAttributes.Name = "btnUpdateBlocksWithAttributes";
            this.btnUpdateBlocksWithAttributes.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateBlocksWithAttributes.TabIndex = 4;
            this.btnUpdateBlocksWithAttributes.Text = "Update Draw Blocks With Attributes";
            this.btnUpdateBlocksWithAttributes.UseVisualStyleBackColor = false;
            // 
            // btnUpdateBlocksNoAttribute
            // 
            this.btnUpdateBlocksNoAttribute.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateBlocksNoAttribute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateBlocksNoAttribute.Location = new System.Drawing.Point(17, 201);
            this.btnUpdateBlocksNoAttribute.Name = "btnUpdateBlocksNoAttribute";
            this.btnUpdateBlocksNoAttribute.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateBlocksNoAttribute.TabIndex = 3;
            this.btnUpdateBlocksNoAttribute.Text = "Update Draw Blocks No Attribute";
            this.btnUpdateBlocksNoAttribute.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePLines
            // 
            this.btnUpdatePLines.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdatePLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdatePLines.Location = new System.Drawing.Point(17, 141);
            this.btnUpdatePLines.Name = "btnUpdatePLines";
            this.btnUpdatePLines.Size = new System.Drawing.Size(149, 49);
            this.btnUpdatePLines.TabIndex = 2;
            this.btnUpdatePLines.Text = "Update Draw PLines";
            this.btnUpdatePLines.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMTexts
            // 
            this.btnUpdateMTexts.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateMTexts.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateMTexts.Location = new System.Drawing.Point(17, 84);
            this.btnUpdateMTexts.Name = "btnUpdateMTexts";
            this.btnUpdateMTexts.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateMTexts.TabIndex = 1;
            this.btnUpdateMTexts.Text = "Update MTexts";
            this.btnUpdateMTexts.UseVisualStyleBackColor = false;
            // 
            // btnUpdateLines
            // 
            this.btnUpdateLines.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdateLines.Location = new System.Drawing.Point(17, 28);
            this.btnUpdateLines.Name = "btnUpdateLines";
            this.btnUpdateLines.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateLines.TabIndex = 0;
            this.btnUpdateLines.Text = "Update Lines in DB";
            this.btnUpdateLines.UseVisualStyleBackColor = false;
            this.btnUpdateLines.Click += new System.EventHandler(this.btnUpdateLines_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteBlocksWithAttributes);
            this.groupBox4.Controls.Add(this.btnDeleteBlocksNoAttribute);
            this.groupBox4.Controls.Add(this.btnDeletePLines);
            this.groupBox4.Controls.Add(this.btnDeleteMTexts);
            this.groupBox4.Controls.Add(this.btnDeleteLines);
            this.groupBox4.Location = new System.Drawing.Point(642, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 329);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // btnDeleteBlocksWithAttributes
            // 
            this.btnDeleteBlocksWithAttributes.BackColor = System.Drawing.Color.Cyan;
            this.btnDeleteBlocksWithAttributes.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDeleteBlocksWithAttributes.Location = new System.Drawing.Point(17, 260);
            this.btnDeleteBlocksWithAttributes.Name = "btnDeleteBlocksWithAttributes";
            this.btnDeleteBlocksWithAttributes.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteBlocksWithAttributes.TabIndex = 4;
            this.btnDeleteBlocksWithAttributes.Text = "Delete Blocks With Attributes";
            this.btnDeleteBlocksWithAttributes.UseVisualStyleBackColor = false;
            this.btnDeleteBlocksWithAttributes.Click += new System.EventHandler(this.btnDeleteBlocksWithAttributes_Click);
            // 
            // btnDeleteBlocksNoAttribute
            // 
            this.btnDeleteBlocksNoAttribute.BackColor = System.Drawing.Color.Cyan;
            this.btnDeleteBlocksNoAttribute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDeleteBlocksNoAttribute.Location = new System.Drawing.Point(17, 201);
            this.btnDeleteBlocksNoAttribute.Name = "btnDeleteBlocksNoAttribute";
            this.btnDeleteBlocksNoAttribute.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteBlocksNoAttribute.TabIndex = 3;
            this.btnDeleteBlocksNoAttribute.Text = "Delete Blocks No Attribute";
            this.btnDeleteBlocksNoAttribute.UseVisualStyleBackColor = false;
            this.btnDeleteBlocksNoAttribute.Click += new System.EventHandler(this.btnDeleteBlocksNoAttribute_Click);
            // 
            // btnDeletePLines
            // 
            this.btnDeletePLines.BackColor = System.Drawing.Color.Cyan;
            this.btnDeletePLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDeletePLines.Location = new System.Drawing.Point(17, 141);
            this.btnDeletePLines.Name = "btnDeletePLines";
            this.btnDeletePLines.Size = new System.Drawing.Size(149, 49);
            this.btnDeletePLines.TabIndex = 2;
            this.btnDeletePLines.Text = "Delete PLines";
            this.btnDeletePLines.UseVisualStyleBackColor = false;
            this.btnDeletePLines.Click += new System.EventHandler(this.btnDeletePLines_Click);
            // 
            // btnDeleteMTexts
            // 
            this.btnDeleteMTexts.BackColor = System.Drawing.Color.Cyan;
            this.btnDeleteMTexts.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDeleteMTexts.Location = new System.Drawing.Point(17, 84);
            this.btnDeleteMTexts.Name = "btnDeleteMTexts";
            this.btnDeleteMTexts.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteMTexts.TabIndex = 1;
            this.btnDeleteMTexts.Text = "Delete MTexts";
            this.btnDeleteMTexts.UseVisualStyleBackColor = false;
            this.btnDeleteMTexts.Click += new System.EventHandler(this.btnDeleteMTexts_Click);
            // 
            // btnDeleteLines
            // 
            this.btnDeleteLines.BackColor = System.Drawing.Color.Cyan;
            this.btnDeleteLines.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDeleteLines.Location = new System.Drawing.Point(17, 28);
            this.btnDeleteLines.Name = "btnDeleteLines";
            this.btnDeleteLines.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteLines.TabIndex = 0;
            this.btnDeleteLines.Text = "Delete Lines in DB";
            this.btnDeleteLines.UseVisualStyleBackColor = false;
            this.btnDeleteLines.Click += new System.EventHandler(this.btnDeleteLines_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 408);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRetrieveAnhDrawBlocksNoAttribute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateBlocksWithAttributes;
        private System.Windows.Forms.Button btnUpdateBlocksNoAttribute;
        private System.Windows.Forms.Button btnUpdatePLines;
        private System.Windows.Forms.Button btnUpdateMTexts;
        private System.Windows.Forms.Button btnUpdateLines;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteBlocksWithAttributes;
        private System.Windows.Forms.Button btnDeleteBlocksNoAttribute;
        private System.Windows.Forms.Button btnDeletePLines;
        private System.Windows.Forms.Button btnDeleteMTexts;
        private System.Windows.Forms.Button btnDeleteLines;
    }
}