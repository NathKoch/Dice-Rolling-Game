namespace Koch_OOP_KT3
{
    partial class NK_Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NK_Form1));
            this.NK_lbl_FirstP = new System.Windows.Forms.Label();
            this.NK_lbl_SecondP = new System.Windows.Forms.Label();
            this.NK_lbl_txtPoints1 = new System.Windows.Forms.Label();
            this.NK_lbl_txtPoints2 = new System.Windows.Forms.Label();
            this.NK_lbl_txtResult = new System.Windows.Forms.Label();
            this.NK_btn_StartNew = new System.Windows.Forms.Button();
            this.NK_btn_PlayFirst = new System.Windows.Forms.Button();
            this.NK_btn_PlaySecond = new System.Windows.Forms.Button();
            this.NK_lbl_Points1 = new System.Windows.Forms.Label();
            this.NK_lbl_Points2 = new System.Windows.Forms.Label();
            this.NK_lbl_Result = new System.Windows.Forms.Label();
            this.NK_imgList = new System.Windows.Forms.ImageList(this.components);
            this.NK_pic_FpD1 = new System.Windows.Forms.PictureBox();
            this.NK_pic_FpD2 = new System.Windows.Forms.PictureBox();
            this.NK_pic_SpD2 = new System.Windows.Forms.PictureBox();
            this.NK_pic_SpD1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_FpD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_FpD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_SpD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_SpD1)).BeginInit();
            this.SuspendLayout();
            // 
            // NK_lbl_FirstP
            // 
            this.NK_lbl_FirstP.AutoSize = true;
            this.NK_lbl_FirstP.ForeColor = System.Drawing.Color.DarkViolet;
            this.NK_lbl_FirstP.Location = new System.Drawing.Point(105, 62);
            this.NK_lbl_FirstP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NK_lbl_FirstP.Name = "NK_lbl_FirstP";
            this.NK_lbl_FirstP.Size = new System.Drawing.Size(166, 23);
            this.NK_lbl_FirstP.TabIndex = 0;
            this.NK_lbl_FirstP.Text = "First Player";
            // 
            // NK_lbl_SecondP
            // 
            this.NK_lbl_SecondP.AutoSize = true;
            this.NK_lbl_SecondP.ForeColor = System.Drawing.Color.DarkViolet;
            this.NK_lbl_SecondP.Location = new System.Drawing.Point(419, 62);
            this.NK_lbl_SecondP.Name = "NK_lbl_SecondP";
            this.NK_lbl_SecondP.Size = new System.Drawing.Size(179, 23);
            this.NK_lbl_SecondP.TabIndex = 1;
            this.NK_lbl_SecondP.Text = "Second Player";
            // 
            // NK_lbl_txtPoints1
            // 
            this.NK_lbl_txtPoints1.AutoSize = true;
            this.NK_lbl_txtPoints1.ForeColor = System.Drawing.Color.Red;
            this.NK_lbl_txtPoints1.Location = new System.Drawing.Point(141, 105);
            this.NK_lbl_txtPoints1.Name = "NK_lbl_txtPoints1";
            this.NK_lbl_txtPoints1.Size = new System.Drawing.Size(88, 23);
            this.NK_lbl_txtPoints1.TabIndex = 2;
            this.NK_lbl_txtPoints1.Text = "Points";
            // 
            // NK_lbl_txtPoints2
            // 
            this.NK_lbl_txtPoints2.AutoSize = true;
            this.NK_lbl_txtPoints2.ForeColor = System.Drawing.Color.Red;
            this.NK_lbl_txtPoints2.Location = new System.Drawing.Point(467, 105);
            this.NK_lbl_txtPoints2.Name = "NK_lbl_txtPoints2";
            this.NK_lbl_txtPoints2.Size = new System.Drawing.Size(88, 23);
            this.NK_lbl_txtPoints2.TabIndex = 3;
            this.NK_lbl_txtPoints2.Text = "Points";
            // 
            // NK_lbl_txtResult
            // 
            this.NK_lbl_txtResult.AutoSize = true;
            this.NK_lbl_txtResult.ForeColor = System.Drawing.Color.Maroon;
            this.NK_lbl_txtResult.Location = new System.Drawing.Point(115, 409);
            this.NK_lbl_txtResult.Name = "NK_lbl_txtResult";
            this.NK_lbl_txtResult.Size = new System.Drawing.Size(88, 23);
            this.NK_lbl_txtResult.TabIndex = 4;
            this.NK_lbl_txtResult.Text = "Result";
            // 
            // NK_btn_StartNew
            // 
            this.NK_btn_StartNew.BackColor = System.Drawing.Color.Green;
            this.NK_btn_StartNew.ForeColor = System.Drawing.Color.White;
            this.NK_btn_StartNew.Location = new System.Drawing.Point(243, 331);
            this.NK_btn_StartNew.Name = "NK_btn_StartNew";
            this.NK_btn_StartNew.Size = new System.Drawing.Size(207, 42);
            this.NK_btn_StartNew.TabIndex = 5;
            this.NK_btn_StartNew.Text = "Start New Game";
            this.NK_btn_StartNew.UseVisualStyleBackColor = false;
            this.NK_btn_StartNew.Click += new System.EventHandler(this.NK_btn_StartNew_Click);
            // 
            // NK_btn_PlayFirst
            // 
            this.NK_btn_PlayFirst.BackColor = System.Drawing.Color.Blue;
            this.NK_btn_PlayFirst.Enabled = false;
            this.NK_btn_PlayFirst.ForeColor = System.Drawing.Color.White;
            this.NK_btn_PlayFirst.Location = new System.Drawing.Point(96, 244);
            this.NK_btn_PlayFirst.Name = "NK_btn_PlayFirst";
            this.NK_btn_PlayFirst.Size = new System.Drawing.Size(175, 65);
            this.NK_btn_PlayFirst.TabIndex = 6;
            this.NK_btn_PlayFirst.Text = "First Player is playing";
            this.NK_btn_PlayFirst.UseVisualStyleBackColor = false;
            this.NK_btn_PlayFirst.Click += new System.EventHandler(this.NK_btn_PlayFirst_Click);
            // 
            // NK_btn_PlaySecond
            // 
            this.NK_btn_PlaySecond.BackColor = System.Drawing.Color.Blue;
            this.NK_btn_PlaySecond.Enabled = false;
            this.NK_btn_PlaySecond.ForeColor = System.Drawing.Color.White;
            this.NK_btn_PlaySecond.Location = new System.Drawing.Point(423, 244);
            this.NK_btn_PlaySecond.Name = "NK_btn_PlaySecond";
            this.NK_btn_PlaySecond.Size = new System.Drawing.Size(187, 65);
            this.NK_btn_PlaySecond.TabIndex = 7;
            this.NK_btn_PlaySecond.Text = "Second Player is playing";
            this.NK_btn_PlaySecond.UseVisualStyleBackColor = false;
            this.NK_btn_PlaySecond.Click += new System.EventHandler(this.NK_btn_PlaySecond_Click);
            // 
            // NK_lbl_Points1
            // 
            this.NK_lbl_Points1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_lbl_Points1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NK_lbl_Points1.Location = new System.Drawing.Point(133, 141);
            this.NK_lbl_Points1.Name = "NK_lbl_Points1";
            this.NK_lbl_Points1.Size = new System.Drawing.Size(106, 37);
            this.NK_lbl_Points1.TabIndex = 15;
            this.NK_lbl_Points1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NK_lbl_Points2
            // 
            this.NK_lbl_Points2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_lbl_Points2.ForeColor = System.Drawing.Color.Green;
            this.NK_lbl_Points2.Location = new System.Drawing.Point(458, 141);
            this.NK_lbl_Points2.Name = "NK_lbl_Points2";
            this.NK_lbl_Points2.Size = new System.Drawing.Size(106, 37);
            this.NK_lbl_Points2.TabIndex = 16;
            this.NK_lbl_Points2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NK_lbl_Result
            // 
            this.NK_lbl_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_lbl_Result.Location = new System.Drawing.Point(213, 402);
            this.NK_lbl_Result.Name = "NK_lbl_Result";
            this.NK_lbl_Result.Size = new System.Drawing.Size(273, 36);
            this.NK_lbl_Result.TabIndex = 21;
            this.NK_lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NK_imgList
            // 
            this.NK_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NK_imgList.ImageStream")));
            this.NK_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.NK_imgList.Images.SetKeyName(0, "dice-six-faces-one (1).png");
            this.NK_imgList.Images.SetKeyName(1, "dice-six-faces-two (1).png");
            this.NK_imgList.Images.SetKeyName(2, "dice-six-faces-three (1).png");
            this.NK_imgList.Images.SetKeyName(3, "dice-six-faces-four (1).png");
            this.NK_imgList.Images.SetKeyName(4, "dice-six-faces-five (1).png");
            this.NK_imgList.Images.SetKeyName(5, "dice-six-faces-six (1).png");
            // 
            // NK_pic_FpD1
            // 
            this.NK_pic_FpD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_pic_FpD1.Location = new System.Drawing.Point(133, 181);
            this.NK_pic_FpD1.Name = "NK_pic_FpD1";
            this.NK_pic_FpD1.Size = new System.Drawing.Size(50, 50);
            this.NK_pic_FpD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_FpD1.TabIndex = 22;
            this.NK_pic_FpD1.TabStop = false;
            this.NK_pic_FpD1.Visible = false;
            // 
            // NK_pic_FpD2
            // 
            this.NK_pic_FpD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_pic_FpD2.Location = new System.Drawing.Point(189, 181);
            this.NK_pic_FpD2.Name = "NK_pic_FpD2";
            this.NK_pic_FpD2.Size = new System.Drawing.Size(50, 50);
            this.NK_pic_FpD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_FpD2.TabIndex = 23;
            this.NK_pic_FpD2.TabStop = false;
            this.NK_pic_FpD2.Visible = false;
            // 
            // NK_pic_SpD2
            // 
            this.NK_pic_SpD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_pic_SpD2.Location = new System.Drawing.Point(514, 181);
            this.NK_pic_SpD2.Name = "NK_pic_SpD2";
            this.NK_pic_SpD2.Size = new System.Drawing.Size(50, 50);
            this.NK_pic_SpD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_SpD2.TabIndex = 25;
            this.NK_pic_SpD2.TabStop = false;
            this.NK_pic_SpD2.Visible = false;
            // 
            // NK_pic_SpD1
            // 
            this.NK_pic_SpD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NK_pic_SpD1.Location = new System.Drawing.Point(458, 181);
            this.NK_pic_SpD1.Name = "NK_pic_SpD1";
            this.NK_pic_SpD1.Size = new System.Drawing.Size(50, 50);
            this.NK_pic_SpD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NK_pic_SpD1.TabIndex = 24;
            this.NK_pic_SpD1.TabStop = false;
            this.NK_pic_SpD1.Visible = false;
            // 
            // NK_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 499);
            this.Controls.Add(this.NK_pic_SpD2);
            this.Controls.Add(this.NK_pic_SpD1);
            this.Controls.Add(this.NK_pic_FpD2);
            this.Controls.Add(this.NK_pic_FpD1);
            this.Controls.Add(this.NK_lbl_Result);
            this.Controls.Add(this.NK_lbl_Points2);
            this.Controls.Add(this.NK_lbl_Points1);
            this.Controls.Add(this.NK_btn_PlaySecond);
            this.Controls.Add(this.NK_btn_PlayFirst);
            this.Controls.Add(this.NK_btn_StartNew);
            this.Controls.Add(this.NK_lbl_txtResult);
            this.Controls.Add(this.NK_lbl_txtPoints2);
            this.Controls.Add(this.NK_lbl_txtPoints1);
            this.Controls.Add(this.NK_lbl_SecondP);
            this.Controls.Add(this.NK_lbl_FirstP);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NK_Form1";
            this.Text = "Dice";
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_FpD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_FpD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_SpD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NK_pic_SpD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NK_lbl_FirstP;
        private System.Windows.Forms.Label NK_lbl_SecondP;
        private System.Windows.Forms.Label NK_lbl_txtPoints1;
        private System.Windows.Forms.Label NK_lbl_txtPoints2;
        private System.Windows.Forms.Label NK_lbl_txtResult;
        private System.Windows.Forms.Button NK_btn_StartNew;
        private System.Windows.Forms.Button NK_btn_PlayFirst;
        private System.Windows.Forms.Button NK_btn_PlaySecond;
        private System.Windows.Forms.Label NK_lbl_Points1;
        private System.Windows.Forms.Label NK_lbl_Points2;
        private System.Windows.Forms.Label NK_lbl_Result;
        private System.Windows.Forms.ImageList NK_imgList;
        private System.Windows.Forms.PictureBox NK_pic_FpD1;
        private System.Windows.Forms.PictureBox NK_pic_FpD2;
        private System.Windows.Forms.PictureBox NK_pic_SpD2;
        private System.Windows.Forms.PictureBox NK_pic_SpD1;
    }
}

