﻿namespace WindowsFormApplication
{
    partial class Form1
    {

        ///

        /// Required designer variable.///


        private System.ComponentModel.IContainer components = null;

        ///

        /// Clean up any resources being used.///


        /// true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        ///

        /// Required method for Designer support - do not modify/// the contents of this method with the code editor.///


        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbOne = new System.Windows.Forms.TabPage();
            this.lblZeidelInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTwo = new System.Windows.Forms.TabPage();
            this.lbl = new System.Windows.Forms.Label();
            this.lblIterationsInfo = new System.Windows.Forms.Label();
            this.lblIterationsSolve = new System.Windows.Forms.Label();
            this.btnIterations = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.choletskyBtnSolve = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbOne.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbTwo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tbOne);
            this.tabControl1.Controls.Add(this.tbTwo);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 288);
            this.tabControl1.TabIndex = 0;
            //
            // tbOne
            //
            this.tbOne.Controls.Add(this.lblZeidelInfo);
            this.tbOne.Controls.Add(this.label5);
            this.tbOne.Controls.Add(this.btnCompute);
            this.tbOne.Controls.Add(this.groupBox1);
            this.tbOne.Location = new System.Drawing.Point(4, 22);
            this.tbOne.Name = "tbOne";
            this.tbOne.Padding = new System.Windows.Forms.Padding(3);
            this.tbOne.Size = new System.Drawing.Size(645, 262);
            this.tbOne.TabIndex = 0;
            this.tbOne.Text = "Zeydel's Method";
            this.tbOne.UseVisualStyleBackColor = true;
            //
            // lblZeidelInfo
            //
            this.lblZeidelInfo.AutoSize = true;
            this.lblZeidelInfo.Location = new System.Drawing.Point(129, 217);
            this.lblZeidelInfo.Name = "lblZeidelInfo";
            this.lblZeidelInfo.Size = new System.Drawing.Size(0, 13);
            this.lblZeidelInfo.TabIndex = 4;
            this.lblZeidelInfo.Visible = false;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 194);
            this.label5.MinimumSize = new System.Drawing.Size(280, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 50);
            this.label5.TabIndex = 3;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnCompute
            //
            this.btnCompute.Location = new System.Drawing.Point(17, 208);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Solve";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Area";
            //
            // textBox4
            //
            this.textBox4.Location = new System.Drawing.Point(290, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIterations_KeyPress);
            //
            // textBox3
            //
            this.textBox3.Location = new System.Drawing.Point(290, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRelaxation_KeyPress);
            //
            // textBox2
            //
            this.textBox2.Location = new System.Drawing.Point(290, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMatrix_KeyPress);
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(290, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRight_KeyPress);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input number of iterations";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coefficient Matrix Input";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Free members input";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of equations";
            //
            // tbTwo
            //
            this.tbTwo.Controls.Add(this.lbl);
            this.tbTwo.Controls.Add(this.lblIterationsInfo);
            this.tbTwo.Controls.Add(this.lblIterationsSolve);
            this.tbTwo.Controls.Add(this.btnIterations);
            this.tbTwo.Controls.Add(this.groupBox2);
            this.tbTwo.Location = new System.Drawing.Point(4, 22);
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tbTwo.Size = new System.Drawing.Size(645, 262);
            this.tbTwo.TabIndex = 1;
            this.tbTwo.Text = "Iteration method";
            this.tbTwo.UseVisualStyleBackColor = true;
            //
            // lbl
            //
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(131, 206);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Visible = false;
            //
            // lblIterationsInfo
            //
            this.lblIterationsInfo.AutoSize = true;
            this.lblIterationsInfo.Location = new System.Drawing.Point(131, 206);
            this.lblIterationsInfo.Name = "lblIterationsInfo";
            this.lblIterationsInfo.Size = new System.Drawing.Size(0, 13);
            this.lblIterationsInfo.TabIndex = 6;
            this.lblIterationsInfo.Visible = false;
            //
            // lblIterationsSolve
            //
            this.lblIterationsSolve.AutoSize = true;
            this.lblIterationsSolve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIterationsSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterationsSolve.Location = new System.Drawing.Point(341, 192);
            this.lblIterationsSolve.MinimumSize = new System.Drawing.Size(280, 50);
            this.lblIterationsSolve.Name = "lblIterationsSolve";
            this.lblIterationsSolve.Size = new System.Drawing.Size(280, 50);
            this.lblIterationsSolve.TabIndex = 5;
            this.lblIterationsSolve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnIterations
            //
            this.btnIterations.Location = new System.Drawing.Point(19, 206);
            this.btnIterations.Name = "btnIterations";
            this.btnIterations.Size = new System.Drawing.Size(75, 23);
            this.btnIterations.TabIndex = 4;
            this.btnIterations.Text = "Solve";
            this.btnIterations.UseVisualStyleBackColor = true;
            this.btnIterations.Click += new System.EventHandler(this.btnIterations_Click);
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(19, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data entry block";
            //
            // textBox7
            //
            this.textBox7.Location = new System.Drawing.Point(290, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(63, 20);
            this.textBox7.TabIndex = 7;
            //
            // textBox8
            //
            this.textBox8.Location = new System.Drawing.Point(290, 84);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 20);
            this.textBox8.TabIndex = 6;
            //
            // textBox9
            //
            this.textBox9.Location = new System.Drawing.Point(290, 55);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(283, 20);
            this.textBox9.TabIndex = 5;
            //
            // textBox10
            //
            this.textBox10.Location = new System.Drawing.Point(290, 30);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(63, 20);
            this.textBox10.TabIndex = 4;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enter number of iterations";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Coefficient Matrix Input";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Enter Free Members";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enter number of equations";
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(645, 262);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "The Cholesky decomposition";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.choletskyBtnSolve);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(20, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 225);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data entry block corresponding: L*L^T = A : Square, symmetrical, and positive";
            //
            // label15
            //
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(467, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Answer (L):";
            //
            // textBox13
            //
            this.textBox13.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox13.Location = new System.Drawing.Point(369, 55);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(247, 101);
            this.textBox13.TabIndex = 12;
            //
            // choletskyBtnSolve
            //
            this.choletskyBtnSolve.Location = new System.Drawing.Point(15, 164);
            this.choletskyBtnSolve.Name = "choletskyBtnSolve";
            this.choletskyBtnSolve.Size = new System.Drawing.Size(75, 23);
            this.choletskyBtnSolve.TabIndex = 11;
            this.choletskyBtnSolve.Text = "Solve";
            this.choletskyBtnSolve.UseVisualStyleBackColor = true;
            this.choletskyBtnSolve.Click += new System.EventHandler(this.choletskyBtnSolve_Click);
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(109, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Fourth row";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Third row";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Second row";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "First row";
            //
            // textBox12
            //
            this.textBox12.Location = new System.Drawing.Point(199, 136);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(134, 20);
            this.textBox12.TabIndex = 6;
            //
            // textBox11
            //
            this.textBox11.Location = new System.Drawing.Point(199, 109);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(134, 20);
            this.textBox11.TabIndex = 5;
            //
            // textBox6
            //
            this.textBox6.Location = new System.Drawing.Point(199, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 20);
            this.textBox6.TabIndex = 4;
            //
            // textBox5
            //
            this.textBox5.Location = new System.Drawing.Point(199, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 20);
            this.textBox5.TabIndex = 3;
            //
            // radioButton2
            //
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(280, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4 Rows (4X4)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            //
            // radioButton1
            //
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(190, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3 Rows (3X3)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Size of the Matrix";
            //
            // btnExit
            //
            this.btnExit.Location = new System.Drawing.Point(12, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(586, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reference";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 346);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsFormApplication ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbOne.ResumeLayout(false);
            this.tbOne.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbTwo.ResumeLayout(false);
            this.tbTwo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbOne;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbTwo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIterationsSolve;
        private System.Windows.Forms.Button btnIterations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIterationsInfo;
        private System.Windows.Forms.Label lblZeidelInfo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button choletskyBtnSolve;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;

    }
}

