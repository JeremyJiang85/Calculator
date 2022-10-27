namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_dispay_top = new System.Windows.Forms.TextBox();
            this.tb_dispay_bottom = new System.Windows.Forms.TextBox();
            this.btn_AC = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_changeSign = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_dispay_top
            // 
            this.tb_dispay_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dispay_top.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_dispay_top.Location = new System.Drawing.Point(12, 12);
            this.tb_dispay_top.Name = "tb_dispay_top";
            this.tb_dispay_top.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_dispay_top.Size = new System.Drawing.Size(318, 40);
            this.tb_dispay_top.TabIndex = 0;
            // 
            // tb_dispay_bottom
            // 
            this.tb_dispay_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dispay_bottom.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_dispay_bottom.Location = new System.Drawing.Point(12, 58);
            this.tb_dispay_bottom.Name = "tb_dispay_bottom";
            this.tb_dispay_bottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_dispay_bottom.Size = new System.Drawing.Size(318, 40);
            this.tb_dispay_bottom.TabIndex = 1;
            // 
            // btn_AC
            // 
            this.btn_AC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_AC.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AC.Location = new System.Drawing.Point(12, 104);
            this.btn_AC.Name = "btn_AC";
            this.btn_AC.Size = new System.Drawing.Size(75, 75);
            this.btn_AC.TabIndex = 2;
            this.btn_AC.Text = "AC";
            this.btn_AC.UseVisualStyleBackColor = false;
            this.btn_AC.Click += new System.EventHandler(this.btn_AC_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_back.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.Location = new System.Drawing.Point(93, 104);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 75);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "->";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_divide.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_divide.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_divide.Location = new System.Drawing.Point(255, 104);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 75);
            this.btn_divide.TabIndex = 5;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = false;
            // 
            // btn_changeSign
            // 
            this.btn_changeSign.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_changeSign.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_changeSign.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_changeSign.Location = new System.Drawing.Point(174, 104);
            this.btn_changeSign.Name = "btn_changeSign";
            this.btn_changeSign.Size = new System.Drawing.Size(75, 75);
            this.btn_changeSign.TabIndex = 4;
            this.btn_changeSign.Text = "+/-";
            this.btn_changeSign.UseVisualStyleBackColor = false;
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_multiply.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_multiply.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_multiply.Location = new System.Drawing.Point(255, 185);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 75);
            this.btn_multiply.TabIndex = 9;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_9.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_9.Location = new System.Drawing.Point(174, 185);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 75);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_8.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_8.Location = new System.Drawing.Point(93, 185);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 75);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_7.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_7.Location = new System.Drawing.Point(12, 185);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 75);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_minus.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_minus.Location = new System.Drawing.Point(255, 266);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 75);
            this.btn_minus.TabIndex = 13;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_6.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_6.Location = new System.Drawing.Point(174, 266);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 75);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_5.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_5.Location = new System.Drawing.Point(93, 266);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 75);
            this.btn_5.TabIndex = 11;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_4.Location = new System.Drawing.Point(12, 266);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 75);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_equal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_equal.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_equal.Location = new System.Drawing.Point(255, 428);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 75);
            this.btn_equal.TabIndex = 17;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_point.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_point.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_point.Location = new System.Drawing.Point(174, 428);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(75, 75);
            this.btn_point.TabIndex = 16;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_0.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_0.Location = new System.Drawing.Point(12, 428);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(155, 75);
            this.btn_0.TabIndex = 14;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_plus.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_plus.Location = new System.Drawing.Point(255, 347);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 75);
            this.btn_plus.TabIndex = 21;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_3.Location = new System.Drawing.Point(174, 347);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 75);
            this.btn_3.TabIndex = 20;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_2.Location = new System.Drawing.Point(93, 347);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 75);
            this.btn_2.TabIndex = 19;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_1.Location = new System.Drawing.Point(12, 347);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 75);
            this.btn_1.TabIndex = 18;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 517);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_changeSign);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_AC);
            this.Controls.Add(this.tb_dispay_bottom);
            this.Controls.Add(this.tb_dispay_top);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dispay_top;
        private System.Windows.Forms.TextBox tb_dispay_bottom;
        private System.Windows.Forms.Button btn_AC;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_changeSign;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
    }
}

