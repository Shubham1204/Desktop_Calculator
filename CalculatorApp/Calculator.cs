﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        MenuStrip menuStrip1 = new MenuStrip();
        ToolStripMenuItem fileToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem standardToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem scienctificToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem editToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem copyToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem pasteToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem exitToolStripMenuItem1 = new ToolStripMenuItem();
        ToolStripMenuItem helpToolStripMenuItem = new ToolStripMenuItem();
        TextBox inputTxtbox = new TextBox();
        Button mcBtn = new Button();
        Button mrBtn = new Button();
        Button mPlusBtn = new Button();
        Button mMinusBtn = new Button();
        Button escapeBtn = new Button();
        Button AcBtn = new Button();
        Button cBtn = new Button();
        Button rootBtn = new Button();
        Button oneBtn = new Button();
        Button twoBtn = new Button();
        Button modBtn = new Button();
        Button fourBtn = new Button();
        Button fiveBtn = new Button();
        Button sixBtn = new Button();
        Button equalBtn = new Button();
        Button zeroBtn = new Button();
        Button dotBtn = new Button();
        Button msBtn = new Button();
        Button plusMinusBtn = new Button();
        Button divBtn = new Button();
        Button mulBtn = new Button();
        Button plusBtn = new Button();
        Button threeBtn = new Button();
        Button sevenBtn = new Button();
        Button eightBtn = new Button();
        Button nineBtn = new Button();
        Button minusBtn = new Button();
        Button oneDivXBtn = new Button();
        Label label1 = new Label();

        public Calculator()
        {
            InitializeComponent();

            // menuStrip1
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";


            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scienctificToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";


            // standardToolStripMenuItem
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.standardToolStripMenuItem.Text = "Standard";


            // scienctificToolStripMenuItem
            this.scienctificToolStripMenuItem.Name = "scienctificToolStripMenuItem";
            this.scienctificToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.scienctificToolStripMenuItem.Text = "Scienctific";


            // editToolStripMenuItem
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";


            // copyToolStripMenuItem
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.copyToolStripMenuItem.Text = "Copy";


            // pasteToolStripMenuItem
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.pasteToolStripMenuItem.Text = "Paste";


            // exitToolStripMenuItem1
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem1.Text = "Exit";


            // helpToolStripMenuItem
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";


            // inputTxtbox
            this.inputTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTxtbox.Location = new System.Drawing.Point(12, 44);
            this.inputTxtbox.Multiline = true;
            this.inputTxtbox.Name = "inputTxtbox";
            this.inputTxtbox.Size = new System.Drawing.Size(349, 57);
            this.inputTxtbox.TabIndex = 1;
            this.inputTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;


            // mcBtn
            this.mcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcBtn.Location = new System.Drawing.Point(12, 117);
            this.mcBtn.Name = "mcBtn";
            this.mcBtn.Size = new System.Drawing.Size(65, 50);
            this.mcBtn.TabIndex = 2;
            this.mcBtn.Text = "MC";
            this.mcBtn.UseVisualStyleBackColor = true;


            // mrBtn
            this.mrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtn.Location = new System.Drawing.Point(83, 117);
            this.mrBtn.Name = "mrBtn";
            this.mrBtn.Size = new System.Drawing.Size(65, 50);
            this.mrBtn.TabIndex = 2;
            this.mrBtn.Text = "MR";
            this.mrBtn.UseVisualStyleBackColor = true;


            // msBtn
            this.msBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBtn.Location = new System.Drawing.Point(154, 117);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(65, 50);
            this.msBtn.TabIndex = 2;
            this.msBtn.Text = "MS";
            this.msBtn.UseVisualStyleBackColor = true;



            //mPlusBtn
            this.mPlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPlusBtn.Location = new System.Drawing.Point(225, 117);
            this.mPlusBtn.Name = "mPlusBtn";
            this.mPlusBtn.Size = new System.Drawing.Size(65, 50);
            this.mPlusBtn.TabIndex = 2;
            this.mPlusBtn.Text = "M+";
            this.mPlusBtn.UseVisualStyleBackColor = true;


            // mMinusBtn
            this.mMinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMinusBtn.Location = new System.Drawing.Point(296, 117);
            this.mMinusBtn.Name = "mMinusBtn";
            this.mMinusBtn.Size = new System.Drawing.Size(65, 50);
            this.mMinusBtn.TabIndex = 2;
            this.mMinusBtn.Text = "M-";
            this.mMinusBtn.UseVisualStyleBackColor = true;


            // escapeBtn
            this.escapeBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.escapeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.escapeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapeBtn.Location = new System.Drawing.Point(12, 173);
            this.escapeBtn.Name = "escapeBtn";
            this.escapeBtn.Size = new System.Drawing.Size(65, 50);
            this.escapeBtn.TabIndex = 2;
            this.escapeBtn.Text = "←";
            this.escapeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.escapeBtn.UseVisualStyleBackColor = true;


            // ACBtn
            this.AcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcBtn.Location = new System.Drawing.Point(83, 173);
            this.AcBtn.Name = "AcBtn";
            this.AcBtn.Size = new System.Drawing.Size(65, 50);
            this.AcBtn.TabIndex = 2;
            this.AcBtn.Text = "AC";
            this.AcBtn.UseVisualStyleBackColor = true;


            // cBtn
            this.cBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtn.Location = new System.Drawing.Point(154, 173);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(65, 50);
            this.cBtn.TabIndex = 2;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;

            // plusMinusBtn
            this.plusMinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinusBtn.Location = new System.Drawing.Point(225, 173);
            this.plusMinusBtn.Name = "plusMinusBtn";
            this.plusMinusBtn.Size = new System.Drawing.Size(65, 50);
            this.plusMinusBtn.TabIndex = 2;
            this.plusMinusBtn.Text = "±";
            this.plusMinusBtn.UseVisualStyleBackColor = true;


            // rootBtn
            this.rootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBtn.Location = new System.Drawing.Point(296, 173);
            this.rootBtn.Name = "rootBtn";
            this.rootBtn.Size = new System.Drawing.Size(65, 50);
            this.rootBtn.TabIndex = 2;
            this.rootBtn.Text = "√";
            this.rootBtn.UseVisualStyleBackColor = true;


            // oneBtn
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(12, 229);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(65, 50);
            this.oneBtn.TabIndex = 2;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;


            // twoBtn
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(83, 229);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(65, 50);
            this.twoBtn.TabIndex = 2;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;


            // threeBtn
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(154, 229);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(65, 50);
            this.threeBtn.TabIndex = 2;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;


            // divBtn
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(225, 229);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(65, 50);
            this.divBtn.TabIndex = 2;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;


            // modBtn
            this.modBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtn.Location = new System.Drawing.Point(296, 229);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(65, 50);
            this.modBtn.TabIndex = 2;
            this.modBtn.Text = "%";
            this.modBtn.UseVisualStyleBackColor = true;


            // fourBtn
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(12, 285);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(65, 50);
            this.fourBtn.TabIndex = 2;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;


            // fiveBtn
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(83, 285);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(65, 50);
            this.fiveBtn.TabIndex = 2;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;


            // sixBtn
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(154, 285);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(65, 50);
            this.sixBtn.TabIndex = 2;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;


            // mulBtn
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.Location = new System.Drawing.Point(225, 285);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(65, 50);
            this.mulBtn.TabIndex = 2;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;

            // oneDivXBtn
            this.oneDivXBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDivXBtn.Location = new System.Drawing.Point(296, 285);
            this.oneDivXBtn.Name = "oneDivXBtn";
            this.oneDivXBtn.Size = new System.Drawing.Size(65, 50);
            this.oneDivXBtn.TabIndex = 2;
            this.oneDivXBtn.Text = "1/x";
            this.oneDivXBtn.UseVisualStyleBackColor = true;


            // sevenBtn
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(12, 340);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(65, 50);
            this.sevenBtn.TabIndex = 2;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;


            // eightBtn
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(83, 341);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(65, 50);
            this.eightBtn.TabIndex = 2;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;


            // nineBtn
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(154, 340);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(65, 50);
            this.nineBtn.TabIndex = 2;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;


            // minusBtn
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(225, 341);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(65, 50);
            this.minusBtn.TabIndex = 2;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;



            // zeroBtn
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(12, 396);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(136, 50);
            this.zeroBtn.TabIndex = 2;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;


            // dotBtn
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.Location = new System.Drawing.Point(154, 396);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(65, 50);
            this.dotBtn.TabIndex = 2;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;


            // plusBtn
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(225, 396);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(65, 50);
            this.plusBtn.TabIndex = 2;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;


            // equalBtn
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(296, 340);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(65, 106);
            this.equalBtn.TabIndex = 2;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;



            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;







            // Calc
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.rootBtn);
            this.Controls.Add(this.mMinusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.oneDivXBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.plusMinusBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.AcBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.msBtn);
            this.Controls.Add(this.mPlusBtn);
            this.Controls.Add(this.escapeBtn);
            this.Controls.Add(this.mrBtn);
            this.Controls.Add(this.mcBtn);
            this.Controls.Add(this.inputTxtbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;

        }

    }
}