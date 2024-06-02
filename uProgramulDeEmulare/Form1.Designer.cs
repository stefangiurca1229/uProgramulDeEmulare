namespace uProgramulDeEmulare
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
            mpm_view = new DataGridView();
            uAdr = new DataGridViewTextBoxColumn();
            label = new DataGridViewTextBoxColumn();
            sbus = new DataGridViewTextBoxColumn();
            dbus = new DataGridViewTextBoxColumn();
            opAlu = new DataGridViewTextBoxColumn();
            rbus = new DataGridViewTextBoxColumn();
            opMem = new DataGridViewTextBoxColumn();
            otherOp = new DataGridViewTextBoxColumn();
            succesor = new DataGridViewTextBoxColumn();
            index = new DataGridViewTextBoxColumn();
            tnf = new DataGridViewTextBoxColumn();
            jump = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mpm_view).BeginInit();
            SuspendLayout();
            // 
            // mpm_view
            // 
            mpm_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mpm_view.Columns.AddRange(new DataGridViewColumn[] { uAdr, label, sbus, dbus, opAlu, rbus, opMem, otherOp, succesor, index, tnf, jump });
            mpm_view.Location = new Point(45, 12);
            mpm_view.Name = "mpm_view";
            mpm_view.RowHeadersWidth = 51;
            mpm_view.RowTemplate.Height = 29;
            mpm_view.Size = new Size(1569, 455);
            mpm_view.TabIndex = 0;
            // 
            // uAdr
            // 
            uAdr.HeaderText = "uAdr";
            uAdr.MinimumWidth = 6;
            uAdr.Name = "uAdr";
            uAdr.Width = 125;
            // 
            // label
            // 
            label.HeaderText = "label";
            label.MinimumWidth = 6;
            label.Name = "label";
            label.Width = 125;
            // 
            // sbus
            // 
            sbus.HeaderText = "sbus";
            sbus.MinimumWidth = 6;
            sbus.Name = "sbus";
            sbus.Width = 125;
            // 
            // dbus
            // 
            dbus.HeaderText = "dbus";
            dbus.MinimumWidth = 6;
            dbus.Name = "dbus";
            dbus.Width = 125;
            // 
            // opAlu
            // 
            opAlu.HeaderText = "opAlu";
            opAlu.MinimumWidth = 6;
            opAlu.Name = "opAlu";
            opAlu.Width = 125;
            // 
            // rbus
            // 
            rbus.HeaderText = "rbus";
            rbus.MinimumWidth = 6;
            rbus.Name = "rbus";
            rbus.Width = 125;
            // 
            // opMem
            // 
            opMem.HeaderText = "opMem";
            opMem.MinimumWidth = 6;
            opMem.Name = "opMem";
            opMem.Width = 125;
            // 
            // otherOp
            // 
            otherOp.HeaderText = "otherOp";
            otherOp.MinimumWidth = 6;
            otherOp.Name = "otherOp";
            otherOp.Width = 125;
            // 
            // succesor
            // 
            succesor.HeaderText = "succesor";
            succesor.MinimumWidth = 6;
            succesor.Name = "succesor";
            succesor.Width = 125;
            // 
            // index
            // 
            index.HeaderText = "index";
            index.MinimumWidth = 6;
            index.Name = "index";
            index.Width = 125;
            // 
            // tnf
            // 
            tnf.HeaderText = "tnf";
            tnf.MinimumWidth = 6;
            tnf.Name = "tnf";
            tnf.Width = 125;
            // 
            // jump
            // 
            jump.HeaderText = "jump";
            jump.MinimumWidth = 6;
            jump.Name = "jump";
            jump.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 584);
            Controls.Add(mpm_view);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mpm_view).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView mpm_view;
        private DataGridViewTextBoxColumn uAdr;
        private DataGridViewTextBoxColumn label;
        private DataGridViewTextBoxColumn sbus;
        private DataGridViewTextBoxColumn dbus;
        private DataGridViewTextBoxColumn opAlu;
        private DataGridViewTextBoxColumn rbus;
        private DataGridViewTextBoxColumn opMem;
        private DataGridViewTextBoxColumn otherOp;
        private DataGridViewTextBoxColumn succesor;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn tnf;
        private DataGridViewTextBoxColumn jump;
    }
}