using System.Windows.Forms;

namespace SpeedClick
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnApply = new Button();
            BtnReset = new Button();
            TxtKey = new TextBox();
            TmrL = new Timer(components);
            TmrR = new Timer(components);
            TxtInterval = new TextBox();
            BtnDeActive = new Button();
            CbLeftRight = new CheckBox();
            TmrKeys = new Timer(components);
            TxtLog = new TextBox();
            BtnPActive = new Button();
            SuspendLayout();
            // 
            // BtnApply
            // 
            BtnApply.Location = new System.Drawing.Point(119, 141);
            BtnApply.Margin = new Padding(4, 3, 4, 3);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new System.Drawing.Size(94, 27);
            BtnApply.TabIndex = 0;
            BtnApply.Text = "Übernehmen";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // BtnReset
            // 
            BtnReset.Location = new System.Drawing.Point(219, 194);
            BtnReset.Margin = new Padding(4, 3, 4, 3);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new System.Drawing.Size(98, 27);
            BtnReset.TabIndex = 1;
            BtnReset.Text = "Zurücksetzen";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // TxtKey
            // 
            TxtKey.Location = new System.Drawing.Point(107, 81);
            TxtKey.Margin = new Padding(4, 3, 4, 3);
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new System.Drawing.Size(116, 23);
            TxtKey.TabIndex = 2;
            TxtKey.TextChanged += TxtKey_TextChanged;
            // 
            // TmrL
            // 
            TmrL.Tick += TmrL_Tick;
            // 
            // TmrR
            // 
            TmrR.Tick += TmrR_Tick;
            // 
            // TxtInterval
            // 
            TxtInterval.Location = new System.Drawing.Point(107, 111);
            TxtInterval.Margin = new Padding(4, 3, 4, 3);
            TxtInterval.Name = "TxtInterval";
            TxtInterval.Size = new System.Drawing.Size(116, 23);
            TxtInterval.TabIndex = 3;
            TxtInterval.TextChanged += TxtInterval_TextChanged;
            // 
            // BtnDeActive
            // 
            BtnDeActive.Location = new System.Drawing.Point(14, 194);
            BtnDeActive.Margin = new Padding(4, 3, 4, 3);
            BtnDeActive.Name = "BtnDeActive";
            BtnDeActive.Size = new System.Drawing.Size(98, 27);
            BtnDeActive.TabIndex = 4;
            BtnDeActive.Text = "Aktivieren";
            BtnDeActive.UseVisualStyleBackColor = true;
            BtnDeActive.Click += BtnDeActive_Click;
            // 
            // CbLeftRight
            // 
            CbLeftRight.AutoSize = true;
            CbLeftRight.Location = new System.Drawing.Point(107, 14);
            CbLeftRight.Margin = new Padding(4, 3, 4, 3);
            CbLeftRight.Name = "CbLeftRight";
            CbLeftRight.Size = new System.Drawing.Size(116, 19);
            CbLeftRight.TabIndex = 5;
            CbLeftRight.Text = "rechte Maustaste";
            CbLeftRight.UseVisualStyleBackColor = true;
            // 
            // TmrKeys
            // 
            TmrKeys.Enabled = true;
            TmrKeys.Interval = 5;
            TmrKeys.Tick += TmrKeys_Tick;
            // 
            // TxtLog
            // 
            TxtLog.Location = new System.Drawing.Point(107, 247);
            TxtLog.Margin = new Padding(4, 3, 4, 3);
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new System.Drawing.Size(116, 23);
            TxtLog.TabIndex = 6;
            TxtLog.Visible = false;
            // 
            // BtnPActive
            // 
            BtnPActive.Location = new System.Drawing.Point(119, 183);
            BtnPActive.Margin = new Padding(4, 3, 4, 3);
            BtnPActive.Name = "BtnPActive";
            BtnPActive.Size = new System.Drawing.Size(88, 46);
            BtnPActive.TabIndex = 7;
            BtnPActive.Text = "Prüfung aktivieren";
            BtnPActive.UseVisualStyleBackColor = true;
            BtnPActive.Click += BtnPActive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(331, 302);
            Controls.Add(BtnPActive);
            Controls.Add(TxtLog);
            Controls.Add(CbLeftRight);
            Controls.Add(BtnDeActive);
            Controls.Add(TxtInterval);
            Controls.Add(TxtKey);
            Controls.Add(BtnReset);
            Controls.Add(BtnApply);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Speed-Click";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnApply;
        private Button BtnReset;
        private TextBox TxtKey;
        private Timer TmrL;
        private Timer TmrR;
        private TextBox TxtInterval;
        private Button BtnDeActive;
        private CheckBox CbLeftRight;
        private Timer TmrKeys;
        private TextBox TxtLog;
        private Button BtnPActive;
    }
}
