namespace PureQuantamWinFormsApp
{
    partial class DashboardForm
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
            this.textBoxDeviceId = new System.Windows.Forms.TextBox();
            this.btnShowDeviceId = new System.Windows.Forms.Button();
            this.textRand32 = new System.Windows.Forms.TextBox();
            this.btnRandInt32 = new System.Windows.Forms.Button();
            this.btnRandUniform = new System.Windows.Forms.Button();
            this.textBoxRandUniform = new System.Windows.Forms.TextBox();
            this.btnRandNormal = new System.Windows.Forms.Button();
            this.textBoxRandNormal = new System.Windows.Forms.TextBox();
            this.btnRandBytes = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRuntimeInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiagnostics = new System.Windows.Forms.Button();
            this.btnTestMatrix = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxDeviceId
            // 
            this.textBoxDeviceId.Location = new System.Drawing.Point(474, 49);
            this.textBoxDeviceId.Name = "textBoxDeviceId";
            this.textBoxDeviceId.Size = new System.Drawing.Size(135, 20);
            this.textBoxDeviceId.TabIndex = 0;
            // 
            // btnShowDeviceId
            // 
            this.btnShowDeviceId.Location = new System.Drawing.Point(474, 12);
            this.btnShowDeviceId.Name = "btnShowDeviceId";
            this.btnShowDeviceId.Size = new System.Drawing.Size(135, 23);
            this.btnShowDeviceId.TabIndex = 1;
            this.btnShowDeviceId.Text = "Show Device ID";
            this.btnShowDeviceId.UseVisualStyleBackColor = true;
            this.btnShowDeviceId.Click += new System.EventHandler(this.btnShowDeviceId_Click);
            // 
            // textRand32
            // 
            this.textRand32.Location = new System.Drawing.Point(128, 141);
            this.textRand32.Name = "textRand32";
            this.textRand32.Size = new System.Drawing.Size(265, 20);
            this.textRand32.TabIndex = 2;
            // 
            // btnRandInt32
            // 
            this.btnRandInt32.Location = new System.Drawing.Point(12, 141);
            this.btnRandInt32.Name = "btnRandInt32";
            this.btnRandInt32.Size = new System.Drawing.Size(100, 23);
            this.btnRandInt32.TabIndex = 3;
            this.btnRandInt32.Text = "RandInt32";
            this.btnRandInt32.UseVisualStyleBackColor = true;
            this.btnRandInt32.Click += new System.EventHandler(this.btnRandInt32_Click);
            // 
            // btnRandUniform
            // 
            this.btnRandUniform.Location = new System.Drawing.Point(12, 214);
            this.btnRandUniform.Name = "btnRandUniform";
            this.btnRandUniform.Size = new System.Drawing.Size(100, 23);
            this.btnRandUniform.TabIndex = 4;
            this.btnRandUniform.Text = "RandUniform";
            this.btnRandUniform.UseVisualStyleBackColor = true;
            this.btnRandUniform.Click += new System.EventHandler(this.btnRandUniform_Click);
            // 
            // textBoxRandUniform
            // 
            this.textBoxRandUniform.Location = new System.Drawing.Point(128, 217);
            this.textBoxRandUniform.Name = "textBoxRandUniform";
            this.textBoxRandUniform.Size = new System.Drawing.Size(265, 20);
            this.textBoxRandUniform.TabIndex = 5;
            // 
            // btnRandNormal
            // 
            this.btnRandNormal.Location = new System.Drawing.Point(13, 287);
            this.btnRandNormal.Name = "btnRandNormal";
            this.btnRandNormal.Size = new System.Drawing.Size(99, 23);
            this.btnRandNormal.TabIndex = 6;
            this.btnRandNormal.Text = "RandNormal";
            this.btnRandNormal.UseVisualStyleBackColor = true;
            this.btnRandNormal.Click += new System.EventHandler(this.btnRandNormal_Click);
            // 
            // textBoxRandNormal
            // 
            this.textBoxRandNormal.Location = new System.Drawing.Point(128, 287);
            this.textBoxRandNormal.Name = "textBoxRandNormal";
            this.textBoxRandNormal.Size = new System.Drawing.Size(265, 20);
            this.textBoxRandNormal.TabIndex = 7;
            // 
            // btnRandBytes
            // 
            this.btnRandBytes.Location = new System.Drawing.Point(573, 266);
            this.btnRandBytes.Name = "btnRandBytes";
            this.btnRandBytes.Size = new System.Drawing.Size(215, 61);
            this.btnRandBytes.TabIndex = 8;
            this.btnRandBytes.Text = "RandBytes";
            this.btnRandBytes.UseVisualStyleBackColor = true;
            this.btnRandBytes.Click += new System.EventHandler(this.btnRandBytes_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(474, 94);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 27);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Hardware";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRuntimeInfo
            // 
            this.btnRuntimeInfo.Location = new System.Drawing.Point(474, 130);
            this.btnRuntimeInfo.Name = "btnRuntimeInfo";
            this.btnRuntimeInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRuntimeInfo.Size = new System.Drawing.Size(135, 41);
            this.btnRuntimeInfo.TabIndex = 10;
            this.btnRuntimeInfo.Text = "Runtime Information";
            this.btnRuntimeInfo.UseVisualStyleBackColor = true;
            this.btnRuntimeInfo.Click += new System.EventHandler(this.btnRuntimeInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Buffers";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDiagnostics
            // 
            this.btnDiagnostics.Location = new System.Drawing.Point(653, 130);
            this.btnDiagnostics.Name = "btnDiagnostics";
            this.btnDiagnostics.Size = new System.Drawing.Size(135, 41);
            this.btnDiagnostics.TabIndex = 12;
            this.btnDiagnostics.Text = "Diagnostics";
            this.btnDiagnostics.UseVisualStyleBackColor = true;
            this.btnDiagnostics.Click += new System.EventHandler(this.btnDiagnostics_Click);
            // 
            // btnTestMatrix
            // 
            this.btnTestMatrix.Location = new System.Drawing.Point(631, 12);
            this.btnTestMatrix.Name = "btnTestMatrix";
            this.btnTestMatrix.Size = new System.Drawing.Size(157, 46);
            this.btnTestMatrix.TabIndex = 13;
            this.btnTestMatrix.Text = "Test Generate Matrix";
            this.btnTestMatrix.UseVisualStyleBackColor = true;
            this.btnTestMatrix.Click += new System.EventHandler(this.btnTestMatrix_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1032, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 554);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 745);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTestMatrix);
            this.Controls.Add(this.btnDiagnostics);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRuntimeInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRandBytes);
            this.Controls.Add(this.textBoxRandNormal);
            this.Controls.Add(this.btnRandNormal);
            this.Controls.Add(this.textBoxRandUniform);
            this.Controls.Add(this.btnRandUniform);
            this.Controls.Add(this.btnRandInt32);
            this.Controls.Add(this.textRand32);
            this.Controls.Add(this.btnShowDeviceId);
            this.Controls.Add(this.textBoxDeviceId);
            this.Name = "DashboardForm";
            this.Text = "Comscire Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDeviceId;
        private System.Windows.Forms.Button btnShowDeviceId;
        private System.Windows.Forms.TextBox textRand32;
        private System.Windows.Forms.Button btnRandInt32;
        private System.Windows.Forms.Button btnRandUniform;
        private System.Windows.Forms.TextBox textBoxRandUniform;
        private System.Windows.Forms.Button btnRandNormal;
        private System.Windows.Forms.TextBox textBoxRandNormal;
        private System.Windows.Forms.Button btnRandBytes;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRuntimeInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDiagnostics;
        private System.Windows.Forms.Button btnTestMatrix;
        private System.Windows.Forms.ListView listView1;
    }
}

