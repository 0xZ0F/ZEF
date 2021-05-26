
namespace ZEF
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_GetProcess = new System.Windows.Forms.Button();
            this.txt_Console = new System.Windows.Forms.TextBox();
            this.txt_ProcName = new System.Windows.Forms.TextBox();
            this.btn_ShowModules = new System.Windows.Forms.Button();
            this.txt_ModuleName = new System.Windows.Forms.TextBox();
            this.btn_GetModule = new System.Windows.Forms.Button();
            this.txt_CMD = new System.Windows.Forms.TextBox();
            this.lbl_CMD = new System.Windows.Forms.Label();
            this.lbl_ProcessName = new System.Windows.Forms.Label();
            this.lbl_ModuleName = new System.Windows.Forms.Label();
            this.txt_ProcID = new System.Windows.Forms.TextBox();
            this.lbl_ProcessID = new System.Windows.Forms.Label();
            this.txt_ReadAddress = new System.Windows.Forms.TextBox();
            this.btn_ReadMemory = new System.Windows.Forms.Button();
            this.btn_ProcessInfo = new System.Windows.Forms.Button();
            this.btn_ModuleInfo = new System.Windows.Forms.Button();
            this.lbl_ReadAddress = new System.Windows.Forms.Label();
            this.txt_ReadAmount = new System.Windows.Forms.TextBox();
            this.lbl_ReadAmount = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Console = new System.Windows.Forms.TabPage();
            this.tab_Process = new System.Windows.Forms.TabPage();
            this.tab_Module = new System.Windows.Forms.TabPage();
            this.txt_Process = new System.Windows.Forms.TextBox();
            this.txt_Module = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tab_Console.SuspendLayout();
            this.tab_Process.SuspendLayout();
            this.tab_Module.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GetProcess
            // 
            this.btn_GetProcess.Location = new System.Drawing.Point(12, 470);
            this.btn_GetProcess.Name = "btn_GetProcess";
            this.btn_GetProcess.Size = new System.Drawing.Size(145, 42);
            this.btn_GetProcess.TabIndex = 1;
            this.btn_GetProcess.Text = "Get Process";
            this.btn_GetProcess.UseVisualStyleBackColor = true;
            this.btn_GetProcess.Click += new System.EventHandler(this.btn_GetProcess_Click);
            // 
            // txt_Console
            // 
            this.txt_Console.AcceptsReturn = true;
            this.txt_Console.AcceptsTab = true;
            this.txt_Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Console.Location = new System.Drawing.Point(0, 0);
            this.txt_Console.Multiline = true;
            this.txt_Console.Name = "txt_Console";
            this.txt_Console.ReadOnly = true;
            this.txt_Console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Console.Size = new System.Drawing.Size(1118, 385);
            this.txt_Console.TabIndex = 1;
            // 
            // txt_ProcName
            // 
            this.txt_ProcName.AcceptsReturn = true;
            this.txt_ProcName.AcceptsTab = true;
            this.txt_ProcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProcName.Location = new System.Drawing.Point(161, 476);
            this.txt_ProcName.Name = "txt_ProcName";
            this.txt_ProcName.Size = new System.Drawing.Size(350, 31);
            this.txt_ProcName.TabIndex = 0;
            this.txt_ProcName.Text = "notepad";
            this.txt_ProcName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ProcName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_GetProcess_KeyDown);
            this.txt_ProcName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_GetProcess_KeyUp);
            // 
            // btn_ShowModules
            // 
            this.btn_ShowModules.Location = new System.Drawing.Point(12, 518);
            this.btn_ShowModules.Name = "btn_ShowModules";
            this.btn_ShowModules.Size = new System.Drawing.Size(145, 42);
            this.btn_ShowModules.TabIndex = 2;
            this.btn_ShowModules.Text = "Show Modules";
            this.btn_ShowModules.UseVisualStyleBackColor = true;
            this.btn_ShowModules.Click += new System.EventHandler(this.btn_ShowModules_Click);
            // 
            // txt_ModuleName
            // 
            this.txt_ModuleName.AcceptsReturn = true;
            this.txt_ModuleName.AcceptsTab = true;
            this.txt_ModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModuleName.Location = new System.Drawing.Point(310, 524);
            this.txt_ModuleName.Name = "txt_ModuleName";
            this.txt_ModuleName.Size = new System.Drawing.Size(350, 31);
            this.txt_ModuleName.TabIndex = 3;
            this.txt_ModuleName.Text = "notepad.exe";
            this.txt_ModuleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_GetModule
            // 
            this.btn_GetModule.Location = new System.Drawing.Point(161, 518);
            this.btn_GetModule.Name = "btn_GetModule";
            this.btn_GetModule.Size = new System.Drawing.Size(145, 42);
            this.btn_GetModule.TabIndex = 4;
            this.btn_GetModule.Text = "Get Module";
            this.btn_GetModule.UseVisualStyleBackColor = true;
            this.btn_GetModule.Click += new System.EventHandler(this.btn_GetModule_Click);
            // 
            // txt_CMD
            // 
            this.txt_CMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMD.Location = new System.Drawing.Point(69, 429);
            this.txt_CMD.Name = "txt_CMD";
            this.txt_CMD.Size = new System.Drawing.Size(1069, 22);
            this.txt_CMD.TabIndex = 5;
            this.txt_CMD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CMD_KeyDown);
            this.txt_CMD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_CMD_KeyUp);
            // 
            // lbl_CMD
            // 
            this.lbl_CMD.Location = new System.Drawing.Point(12, 430);
            this.lbl_CMD.Name = "lbl_CMD";
            this.lbl_CMD.Size = new System.Drawing.Size(57, 20);
            this.lbl_CMD.TabIndex = 6;
            this.lbl_CMD.Text = "Command:";
            this.lbl_CMD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProcessName
            // 
            this.lbl_ProcessName.Location = new System.Drawing.Point(163, 461);
            this.lbl_ProcessName.Name = "lbl_ProcessName";
            this.lbl_ProcessName.Size = new System.Drawing.Size(348, 13);
            this.lbl_ProcessName.TabIndex = 7;
            this.lbl_ProcessName.Text = "Process Name";
            this.lbl_ProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ModuleName
            // 
            this.lbl_ModuleName.Location = new System.Drawing.Point(312, 511);
            this.lbl_ModuleName.Name = "lbl_ModuleName";
            this.lbl_ModuleName.Size = new System.Drawing.Size(348, 13);
            this.lbl_ModuleName.TabIndex = 8;
            this.lbl_ModuleName.Text = "Module Name";
            this.lbl_ModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ProcID
            // 
            this.txt_ProcID.AcceptsReturn = true;
            this.txt_ProcID.AcceptsTab = true;
            this.txt_ProcID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProcID.Location = new System.Drawing.Point(517, 476);
            this.txt_ProcID.Name = "txt_ProcID";
            this.txt_ProcID.Size = new System.Drawing.Size(143, 31);
            this.txt_ProcID.TabIndex = 9;
            this.txt_ProcID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ProcID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_GetProcess_KeyDown);
            this.txt_ProcID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_GetProcess_KeyUp);
            // 
            // lbl_ProcessID
            // 
            this.lbl_ProcessID.Location = new System.Drawing.Point(517, 461);
            this.lbl_ProcessID.Name = "lbl_ProcessID";
            this.lbl_ProcessID.Size = new System.Drawing.Size(143, 13);
            this.lbl_ProcessID.TabIndex = 10;
            this.lbl_ProcessID.Text = "Process ID";
            this.lbl_ProcessID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ReadAddress
            // 
            this.txt_ReadAddress.AcceptsReturn = true;
            this.txt_ReadAddress.AcceptsTab = true;
            this.txt_ReadAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadAddress.Location = new System.Drawing.Point(161, 572);
            this.txt_ReadAddress.Name = "txt_ReadAddress";
            this.txt_ReadAddress.Size = new System.Drawing.Size(350, 31);
            this.txt_ReadAddress.TabIndex = 11;
            this.txt_ReadAddress.Text = "0x0000";
            this.txt_ReadAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ReadMemory
            // 
            this.btn_ReadMemory.Location = new System.Drawing.Point(12, 566);
            this.btn_ReadMemory.Name = "btn_ReadMemory";
            this.btn_ReadMemory.Size = new System.Drawing.Size(145, 42);
            this.btn_ReadMemory.TabIndex = 12;
            this.btn_ReadMemory.Text = "Read Memory";
            this.btn_ReadMemory.UseVisualStyleBackColor = true;
            this.btn_ReadMemory.Click += new System.EventHandler(this.btn_ReadMemory_Click);
            // 
            // btn_ProcessInfo
            // 
            this.btn_ProcessInfo.Location = new System.Drawing.Point(666, 470);
            this.btn_ProcessInfo.Name = "btn_ProcessInfo";
            this.btn_ProcessInfo.Size = new System.Drawing.Size(145, 42);
            this.btn_ProcessInfo.TabIndex = 13;
            this.btn_ProcessInfo.Text = "Process Info";
            this.btn_ProcessInfo.UseVisualStyleBackColor = true;
            this.btn_ProcessInfo.Click += new System.EventHandler(this.btn_ProcessInfo_Click);
            // 
            // btn_ModuleInfo
            // 
            this.btn_ModuleInfo.Location = new System.Drawing.Point(666, 518);
            this.btn_ModuleInfo.Name = "btn_ModuleInfo";
            this.btn_ModuleInfo.Size = new System.Drawing.Size(145, 42);
            this.btn_ModuleInfo.TabIndex = 14;
            this.btn_ModuleInfo.Text = "Module Info";
            this.btn_ModuleInfo.UseVisualStyleBackColor = true;
            // 
            // lbl_ReadAddress
            // 
            this.lbl_ReadAddress.Location = new System.Drawing.Point(163, 559);
            this.lbl_ReadAddress.Name = "lbl_ReadAddress";
            this.lbl_ReadAddress.Size = new System.Drawing.Size(350, 13);
            this.lbl_ReadAddress.TabIndex = 15;
            this.lbl_ReadAddress.Text = "Address";
            this.lbl_ReadAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ReadAmount
            // 
            this.txt_ReadAmount.AcceptsReturn = true;
            this.txt_ReadAmount.AcceptsTab = true;
            this.txt_ReadAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadAmount.Location = new System.Drawing.Point(517, 572);
            this.txt_ReadAmount.Name = "txt_ReadAmount";
            this.txt_ReadAmount.Size = new System.Drawing.Size(143, 31);
            this.txt_ReadAmount.TabIndex = 16;
            this.txt_ReadAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ReadAmount
            // 
            this.lbl_ReadAmount.Location = new System.Drawing.Point(517, 559);
            this.lbl_ReadAmount.Name = "lbl_ReadAmount";
            this.lbl_ReadAmount.Size = new System.Drawing.Size(143, 13);
            this.lbl_ReadAmount.TabIndex = 17;
            this.lbl_ReadAmount.Text = "Amount to Read";
            this.lbl_ReadAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Console);
            this.tabControl.Controls.Add(this.tab_Process);
            this.tabControl.Controls.Add(this.tab_Module);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1126, 411);
            this.tabControl.TabIndex = 18;
            // 
            // tab_Console
            // 
            this.tab_Console.Controls.Add(this.txt_Console);
            this.tab_Console.Location = new System.Drawing.Point(4, 22);
            this.tab_Console.Name = "tab_Console";
            this.tab_Console.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Console.Size = new System.Drawing.Size(1118, 385);
            this.tab_Console.TabIndex = 0;
            this.tab_Console.Text = "Console";
            this.tab_Console.UseVisualStyleBackColor = true;
            // 
            // tab_Process
            // 
            this.tab_Process.Controls.Add(this.txt_Process);
            this.tab_Process.Location = new System.Drawing.Point(4, 22);
            this.tab_Process.Name = "tab_Process";
            this.tab_Process.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Process.Size = new System.Drawing.Size(1118, 385);
            this.tab_Process.TabIndex = 1;
            this.tab_Process.Text = "Process";
            this.tab_Process.UseVisualStyleBackColor = true;
            // 
            // tab_Module
            // 
            this.tab_Module.Controls.Add(this.txt_Module);
            this.tab_Module.Location = new System.Drawing.Point(4, 22);
            this.tab_Module.Name = "tab_Module";
            this.tab_Module.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Module.Size = new System.Drawing.Size(1118, 385);
            this.tab_Module.TabIndex = 2;
            this.tab_Module.Text = "Module";
            this.tab_Module.UseVisualStyleBackColor = true;
            // 
            // txt_Process
            // 
            this.txt_Process.AcceptsReturn = true;
            this.txt_Process.AcceptsTab = true;
            this.txt_Process.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Process.Location = new System.Drawing.Point(0, 0);
            this.txt_Process.Multiline = true;
            this.txt_Process.Name = "txt_Process";
            this.txt_Process.ReadOnly = true;
            this.txt_Process.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Process.Size = new System.Drawing.Size(1118, 385);
            this.txt_Process.TabIndex = 2;
            // 
            // txt_Module
            // 
            this.txt_Module.AcceptsReturn = true;
            this.txt_Module.AcceptsTab = true;
            this.txt_Module.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Module.Location = new System.Drawing.Point(0, 0);
            this.txt_Module.Multiline = true;
            this.txt_Module.Name = "txt_Module";
            this.txt_Module.ReadOnly = true;
            this.txt_Module.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Module.Size = new System.Drawing.Size(1118, 385);
            this.txt_Module.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 770);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbl_ReadAmount);
            this.Controls.Add(this.txt_ReadAmount);
            this.Controls.Add(this.lbl_ReadAddress);
            this.Controls.Add(this.btn_ModuleInfo);
            this.Controls.Add(this.btn_ProcessInfo);
            this.Controls.Add(this.txt_ReadAddress);
            this.Controls.Add(this.btn_ReadMemory);
            this.Controls.Add(this.lbl_ProcessID);
            this.Controls.Add(this.txt_ProcID);
            this.Controls.Add(this.lbl_ModuleName);
            this.Controls.Add(this.lbl_ProcessName);
            this.Controls.Add(this.lbl_CMD);
            this.Controls.Add(this.txt_CMD);
            this.Controls.Add(this.txt_ModuleName);
            this.Controls.Add(this.btn_GetModule);
            this.Controls.Add(this.btn_ShowModules);
            this.Controls.Add(this.txt_ProcName);
            this.Controls.Add(this.btn_GetProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "ZEF";
            this.tabControl.ResumeLayout(false);
            this.tab_Console.ResumeLayout(false);
            this.tab_Console.PerformLayout();
            this.tab_Process.ResumeLayout(false);
            this.tab_Process.PerformLayout();
            this.tab_Module.ResumeLayout(false);
            this.tab_Module.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetProcess;
        private System.Windows.Forms.TextBox txt_Console;
        private System.Windows.Forms.TextBox txt_ProcName;
        private System.Windows.Forms.Button btn_ShowModules;
        private System.Windows.Forms.TextBox txt_ModuleName;
        private System.Windows.Forms.Button btn_GetModule;
        private System.Windows.Forms.TextBox txt_CMD;
        private System.Windows.Forms.Label lbl_CMD;
        private System.Windows.Forms.Label lbl_ProcessName;
        private System.Windows.Forms.Label lbl_ModuleName;
        private System.Windows.Forms.TextBox txt_ProcID;
        private System.Windows.Forms.Label lbl_ProcessID;
        private System.Windows.Forms.TextBox txt_ReadAddress;
        private System.Windows.Forms.Button btn_ReadMemory;
        private System.Windows.Forms.Button btn_ProcessInfo;
        private System.Windows.Forms.Button btn_ModuleInfo;
        private System.Windows.Forms.Label lbl_ReadAddress;
        private System.Windows.Forms.TextBox txt_ReadAmount;
        private System.Windows.Forms.Label lbl_ReadAmount;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Console;
        private System.Windows.Forms.TabPage tab_Process;
        private System.Windows.Forms.TabPage tab_Module;
        private System.Windows.Forms.TextBox txt_Process;
        private System.Windows.Forms.TextBox txt_Module;
    }
}

