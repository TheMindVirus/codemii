﻿/* This file is part of the libWiiSharp - WAD UnPacker Example
 * Copyright (C) 2009 Leathl
 * 
 * libWiiSharp is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * libWiiSharp is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
 
namespace WAD_UnPacker_Example
{
    partial class WAD_UnPacker_Example
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUnpack = new System.Windows.Forms.TabPage();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.cbUnpackCidName = new System.Windows.Forms.CheckBox();
            this.btnUnpackOutputBrowse = new System.Windows.Forms.Button();
            this.btnUnpackInputBrowse = new System.Windows.Forms.Button();
            this.tbUnpackOutput = new System.Windows.Forms.TextBox();
            this.tbUnpackInput = new System.Windows.Forms.TextBox();
            this.lbUnpackOutput = new System.Windows.Forms.Label();
            this.lbUnpackInput = new System.Windows.Forms.Label();
            this.tabPack = new System.Windows.Forms.TabPage();
            this.btnPack = new System.Windows.Forms.Button();
            this.cbPackFakesign = new System.Windows.Forms.CheckBox();
            this.btnPackOutputBrowse = new System.Windows.Forms.Button();
            this.btnPackInputBrowse = new System.Windows.Forms.Button();
            this.tbPackOutput = new System.Windows.Forms.TextBox();
            this.tbPackInput = new System.Windows.Forms.TextBox();
            this.lbPackOutput = new System.Windows.Forms.Label();
            this.lbPackInput = new System.Windows.Forms.Label();
            this.pbUnpackProgress = new System.Windows.Forms.ProgressBar();
            this.pbPackProgress = new System.Windows.Forms.ProgressBar();
            this.tabControl.SuspendLayout();
            this.tabUnpack.SuspendLayout();
            this.tabPack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUnpack);
            this.tabControl.Controls.Add(this.tabPack);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(338, 190);
            this.tabControl.TabIndex = 0;
            // 
            // tabUnpack
            // 
            this.tabUnpack.Controls.Add(this.pbUnpackProgress);
            this.tabUnpack.Controls.Add(this.btnUnpack);
            this.tabUnpack.Controls.Add(this.cbUnpackCidName);
            this.tabUnpack.Controls.Add(this.btnUnpackOutputBrowse);
            this.tabUnpack.Controls.Add(this.btnUnpackInputBrowse);
            this.tabUnpack.Controls.Add(this.tbUnpackOutput);
            this.tabUnpack.Controls.Add(this.tbUnpackInput);
            this.tabUnpack.Controls.Add(this.lbUnpackOutput);
            this.tabUnpack.Controls.Add(this.lbUnpackInput);
            this.tabUnpack.Location = new System.Drawing.Point(4, 22);
            this.tabUnpack.Name = "tabUnpack";
            this.tabUnpack.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnpack.Size = new System.Drawing.Size(330, 164);
            this.tabUnpack.TabIndex = 0;
            this.tabUnpack.Text = "Unpack";
            this.tabUnpack.UseVisualStyleBackColor = true;
            // 
            // btnUnpack
            // 
            this.btnUnpack.Location = new System.Drawing.Point(11, 123);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(311, 28);
            this.btnUnpack.TabIndex = 4;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // cbUnpackCidName
            // 
            this.cbUnpackCidName.AutoSize = true;
            this.cbUnpackCidName.Location = new System.Drawing.Point(11, 89);
            this.cbUnpackCidName.Name = "cbUnpackCidName";
            this.cbUnpackCidName.Size = new System.Drawing.Size(142, 17);
            this.cbUnpackCidName.TabIndex = 3;
            this.cbUnpackCidName.Text = "Use Content ID as name";
            this.cbUnpackCidName.UseVisualStyleBackColor = true;
            this.cbUnpackCidName.CheckedChanged += new System.EventHandler(this.cbUnpackCidName_CheckedChanged);
            // 
            // btnUnpackOutputBrowse
            // 
            this.btnUnpackOutputBrowse.Location = new System.Drawing.Point(297, 49);
            this.btnUnpackOutputBrowse.Name = "btnUnpackOutputBrowse";
            this.btnUnpackOutputBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnUnpackOutputBrowse.TabIndex = 2;
            this.btnUnpackOutputBrowse.Text = "...";
            this.btnUnpackOutputBrowse.UseVisualStyleBackColor = true;
            this.btnUnpackOutputBrowse.Click += new System.EventHandler(this.btnUnpackOutputBrowse_Click);
            // 
            // btnUnpackInputBrowse
            // 
            this.btnUnpackInputBrowse.Location = new System.Drawing.Point(297, 16);
            this.btnUnpackInputBrowse.Name = "btnUnpackInputBrowse";
            this.btnUnpackInputBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnUnpackInputBrowse.TabIndex = 2;
            this.btnUnpackInputBrowse.Text = "...";
            this.btnUnpackInputBrowse.UseVisualStyleBackColor = true;
            this.btnUnpackInputBrowse.Click += new System.EventHandler(this.btnUnpackInputBrowse_Click);
            // 
            // tbUnpackOutput
            // 
            this.tbUnpackOutput.Location = new System.Drawing.Point(85, 49);
            this.tbUnpackOutput.Name = "tbUnpackOutput";
            this.tbUnpackOutput.ReadOnly = true;
            this.tbUnpackOutput.Size = new System.Drawing.Size(206, 20);
            this.tbUnpackOutput.TabIndex = 1;
            // 
            // tbUnpackInput
            // 
            this.tbUnpackInput.Location = new System.Drawing.Point(85, 16);
            this.tbUnpackInput.Name = "tbUnpackInput";
            this.tbUnpackInput.ReadOnly = true;
            this.tbUnpackInput.Size = new System.Drawing.Size(206, 20);
            this.tbUnpackInput.TabIndex = 1;
            // 
            // lbUnpackOutput
            // 
            this.lbUnpackOutput.AutoSize = true;
            this.lbUnpackOutput.Location = new System.Drawing.Point(8, 53);
            this.lbUnpackOutput.Name = "lbUnpackOutput";
            this.lbUnpackOutput.Size = new System.Drawing.Size(58, 13);
            this.lbUnpackOutput.TabIndex = 0;
            this.lbUnpackOutput.Text = "Output Dir:";
            // 
            // lbUnpackInput
            // 
            this.lbUnpackInput.AutoSize = true;
            this.lbUnpackInput.Location = new System.Drawing.Point(8, 20);
            this.lbUnpackInput.Name = "lbUnpackInput";
            this.lbUnpackInput.Size = new System.Drawing.Size(63, 13);
            this.lbUnpackInput.TabIndex = 0;
            this.lbUnpackInput.Text = "Input WAD:";
            // 
            // tabPack
            // 
            this.tabPack.Controls.Add(this.pbPackProgress);
            this.tabPack.Controls.Add(this.btnPack);
            this.tabPack.Controls.Add(this.cbPackFakesign);
            this.tabPack.Controls.Add(this.btnPackOutputBrowse);
            this.tabPack.Controls.Add(this.btnPackInputBrowse);
            this.tabPack.Controls.Add(this.tbPackOutput);
            this.tabPack.Controls.Add(this.tbPackInput);
            this.tabPack.Controls.Add(this.lbPackOutput);
            this.tabPack.Controls.Add(this.lbPackInput);
            this.tabPack.Location = new System.Drawing.Point(4, 22);
            this.tabPack.Name = "tabPack";
            this.tabPack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPack.Size = new System.Drawing.Size(330, 164);
            this.tabPack.TabIndex = 1;
            this.tabPack.Text = "Pack";
            this.tabPack.UseVisualStyleBackColor = true;
            // 
            // btnPack
            // 
            this.btnPack.Location = new System.Drawing.Point(11, 123);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(311, 28);
            this.btnPack.TabIndex = 12;
            this.btnPack.Text = "Pack";
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // cbPackFakesign
            // 
            this.cbPackFakesign.AutoSize = true;
            this.cbPackFakesign.Location = new System.Drawing.Point(11, 89);
            this.cbPackFakesign.Name = "cbPackFakesign";
            this.cbPackFakesign.Size = new System.Drawing.Size(69, 17);
            this.cbPackFakesign.TabIndex = 11;
            this.cbPackFakesign.Text = "Fakesign";
            this.cbPackFakesign.UseVisualStyleBackColor = true;
            this.cbPackFakesign.CheckedChanged += new System.EventHandler(this.cbPackFakesign_CheckedChanged);
            // 
            // btnPackOutputBrowse
            // 
            this.btnPackOutputBrowse.Location = new System.Drawing.Point(297, 49);
            this.btnPackOutputBrowse.Name = "btnPackOutputBrowse";
            this.btnPackOutputBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnPackOutputBrowse.TabIndex = 9;
            this.btnPackOutputBrowse.Text = "...";
            this.btnPackOutputBrowse.UseVisualStyleBackColor = true;
            this.btnPackOutputBrowse.Click += new System.EventHandler(this.btnPackOutputBrowse_Click);
            // 
            // btnPackInputBrowse
            // 
            this.btnPackInputBrowse.Location = new System.Drawing.Point(297, 16);
            this.btnPackInputBrowse.Name = "btnPackInputBrowse";
            this.btnPackInputBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnPackInputBrowse.TabIndex = 10;
            this.btnPackInputBrowse.Text = "...";
            this.btnPackInputBrowse.UseVisualStyleBackColor = true;
            this.btnPackInputBrowse.Click += new System.EventHandler(this.btnPackInputBrowse_Click);
            // 
            // tbPackOutput
            // 
            this.tbPackOutput.Location = new System.Drawing.Point(85, 49);
            this.tbPackOutput.Name = "tbPackOutput";
            this.tbPackOutput.ReadOnly = true;
            this.tbPackOutput.Size = new System.Drawing.Size(206, 20);
            this.tbPackOutput.TabIndex = 7;
            // 
            // tbPackInput
            // 
            this.tbPackInput.Location = new System.Drawing.Point(85, 16);
            this.tbPackInput.Name = "tbPackInput";
            this.tbPackInput.ReadOnly = true;
            this.tbPackInput.Size = new System.Drawing.Size(206, 20);
            this.tbPackInput.TabIndex = 8;
            // 
            // lbPackOutput
            // 
            this.lbPackOutput.AutoSize = true;
            this.lbPackOutput.Location = new System.Drawing.Point(8, 53);
            this.lbPackOutput.Name = "lbPackOutput";
            this.lbPackOutput.Size = new System.Drawing.Size(71, 13);
            this.lbPackOutput.TabIndex = 5;
            this.lbPackOutput.Text = "Output WAD:";
            // 
            // lbPackInput
            // 
            this.lbPackInput.AutoSize = true;
            this.lbPackInput.Location = new System.Drawing.Point(8, 20);
            this.lbPackInput.Name = "lbPackInput";
            this.lbPackInput.Size = new System.Drawing.Size(50, 13);
            this.lbPackInput.TabIndex = 6;
            this.lbPackInput.Text = "Input Dir:";
            // 
            // pbUnpackProgress
            // 
            this.pbUnpackProgress.Location = new System.Drawing.Point(11, 123);
            this.pbUnpackProgress.Name = "pbUnpackProgress";
            this.pbUnpackProgress.Size = new System.Drawing.Size(311, 28);
            this.pbUnpackProgress.TabIndex = 5;
            this.pbUnpackProgress.Visible = false;
            // 
            // pbPackProgress
            // 
            this.pbPackProgress.Location = new System.Drawing.Point(11, 123);
            this.pbPackProgress.Name = "pbPackProgress";
            this.pbPackProgress.Size = new System.Drawing.Size(311, 28);
            this.pbPackProgress.TabIndex = 13;
            this.pbPackProgress.Visible = false;
            // 
            // WAD_UnPacker_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 190);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WAD_UnPacker_Example";
            this.Text = "libWiiSharp - WAD UnPacker Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WAD_UnPacker_Example_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabUnpack.ResumeLayout(false);
            this.tabUnpack.PerformLayout();
            this.tabPack.ResumeLayout(false);
            this.tabPack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUnpack;
        private System.Windows.Forms.TabPage tabPack;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.CheckBox cbUnpackCidName;
        private System.Windows.Forms.Button btnUnpackOutputBrowse;
        private System.Windows.Forms.Button btnUnpackInputBrowse;
        private System.Windows.Forms.TextBox tbUnpackOutput;
        private System.Windows.Forms.TextBox tbUnpackInput;
        private System.Windows.Forms.Label lbUnpackOutput;
        private System.Windows.Forms.Label lbUnpackInput;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.Button btnPackOutputBrowse;
        private System.Windows.Forms.Button btnPackInputBrowse;
        private System.Windows.Forms.TextBox tbPackOutput;
        private System.Windows.Forms.TextBox tbPackInput;
        private System.Windows.Forms.Label lbPackOutput;
        private System.Windows.Forms.Label lbPackInput;
        private System.Windows.Forms.CheckBox cbPackFakesign;
        private System.Windows.Forms.ProgressBar pbUnpackProgress;
        private System.Windows.Forms.ProgressBar pbPackProgress;
    }
}

