namespace MMM_GUI1
{
    partial class ScControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScControl));
            this.graphArea = new System.Windows.Forms.Panel();
            this.InputSettingsBox = new System.Windows.Forms.GroupBox();
            this.textBoxTimestep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStopTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputFunction = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SystemBox = new System.Windows.Forms.GroupBox();
            this.textBoxParamA2 = new System.Windows.Forms.TextBox();
            this.textBoxParamA = new System.Windows.Forms.TextBox();
            this.textBoxParamK = new System.Windows.Forms.TextBox();
            this.textBoxParamM = new System.Windows.Forms.TextBox();
            this.labelCursor = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.ViewBox = new System.Windows.Forms.GroupBox();
            this.checkBoxViewX2 = new System.Windows.Forms.CheckBox();
            this.checkBoxViewX1 = new System.Windows.Forms.CheckBox();
            this.checkBoxViewY = new System.Windows.Forms.CheckBox();
            this.checkBoxViewE = new System.Windows.Forms.CheckBox();
            this.checkBoxViewU = new System.Windows.Forms.CheckBox();
            this.NavBox = new System.Windows.Forms.GroupBox();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveCenter = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.RangeBox = new System.Windows.Forms.GroupBox();
            this.buttonValSet = new System.Windows.Forms.Button();
            this.buttonArgSet = new System.Windows.Forms.Button();
            this.checkBoxValAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxArgAuto = new System.Windows.Forms.CheckBox();
            this.textBoxValMax = new System.Windows.Forms.TextBox();
            this.textBoxValMin = new System.Windows.Forms.TextBox();
            this.textBoxArgMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxArgMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.InputSettingsBox.SuspendLayout();
            this.SystemBox.SuspendLayout();
            this.ViewBox.SuspendLayout();
            this.NavBox.SuspendLayout();
            this.RangeBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphArea
            // 
            this.graphArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphArea.Location = new System.Drawing.Point(17, 292);
            this.graphArea.Margin = new System.Windows.Forms.Padding(4);
            this.graphArea.Name = "graphArea";
            this.graphArea.Size = new System.Drawing.Size(1494, 486);
            this.graphArea.TabIndex = 0;
            this.graphArea.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphArea_Paint);
            this.graphArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphArea_MouseMove);
            // 
            // InputSettingsBox
            // 
            this.InputSettingsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InputSettingsBox.Controls.Add(this.textBoxTimestep);
            this.InputSettingsBox.Controls.Add(this.label3);
            this.InputSettingsBox.Controls.Add(this.textBoxStopTime);
            this.InputSettingsBox.Controls.Add(this.label2);
            this.InputSettingsBox.Controls.Add(this.label1);
            this.InputSettingsBox.Controls.Add(this.textBoxInputFunction);
            this.InputSettingsBox.Location = new System.Drawing.Point(7, 6);
            this.InputSettingsBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.InputSettingsBox.Name = "InputSettingsBox";
            this.InputSettingsBox.Padding = new System.Windows.Forms.Padding(4);
            this.InputSettingsBox.Size = new System.Drawing.Size(307, 212);
            this.InputSettingsBox.TabIndex = 1;
            this.InputSettingsBox.TabStop = false;
            this.InputSettingsBox.Text = "Input Settings:";
            // 
            // textBoxTimestep
            // 
            this.textBoxTimestep.Location = new System.Drawing.Point(8, 142);
            this.textBoxTimestep.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimestep.Name = "textBoxTimestep";
            this.textBoxTimestep.Size = new System.Drawing.Size(153, 22);
            this.textBoxTimestep.TabIndex = 5;
            this.textBoxTimestep.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxTimestep.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timestep:";
            // 
            // textBoxStopTime
            // 
            this.textBoxStopTime.Location = new System.Drawing.Point(8, 92);
            this.textBoxStopTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStopTime.Name = "textBoxStopTime";
            this.textBoxStopTime.Size = new System.Drawing.Size(153, 22);
            this.textBoxStopTime.TabIndex = 3;
            this.textBoxStopTime.TextChanged += new System.EventHandler(this.TextBoxStopTime_TextChanged);
            this.textBoxStopTime.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxStopTime.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input function:";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // textBoxInputFunction
            // 
            this.textBoxInputFunction.Location = new System.Drawing.Point(8, 44);
            this.textBoxInputFunction.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputFunction.Name = "textBoxInputFunction";
            this.textBoxInputFunction.Size = new System.Drawing.Size(289, 22);
            this.textBoxInputFunction.TabIndex = 0;
            this.textBoxInputFunction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFunctionTextBox_KeyDown);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(17, 252);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 28);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // SystemBox
            // 
            this.SystemBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SystemBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SystemBox.BackgroundImage")));
            this.SystemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SystemBox.Controls.Add(this.textBoxParamA2);
            this.SystemBox.Controls.Add(this.textBoxParamA);
            this.SystemBox.Controls.Add(this.textBoxParamK);
            this.SystemBox.Controls.Add(this.textBoxParamM);
            this.SystemBox.Location = new System.Drawing.Point(328, 6);
            this.SystemBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SystemBox.Name = "SystemBox";
            this.SystemBox.Padding = new System.Windows.Forms.Padding(4);
            this.SystemBox.Size = new System.Drawing.Size(507, 212);
            this.SystemBox.TabIndex = 2;
            this.SystemBox.TabStop = false;
            this.SystemBox.Text = "System Parameters:";
            // 
            // textBoxParamA2
            // 
            this.textBoxParamA2.Location = new System.Drawing.Point(336, 82);
            this.textBoxParamA2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParamA2.Name = "textBoxParamA2";
            this.textBoxParamA2.Size = new System.Drawing.Size(65, 22);
            this.textBoxParamA2.TabIndex = 3;
            this.textBoxParamA2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxParamA2.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // textBoxParamA
            // 
            this.textBoxParamA.Location = new System.Drawing.Point(323, 57);
            this.textBoxParamA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParamA.Name = "textBoxParamA";
            this.textBoxParamA.Size = new System.Drawing.Size(65, 22);
            this.textBoxParamA.TabIndex = 2;
            this.textBoxParamA.TextChanged += new System.EventHandler(this.TextBoxParamA_TextChanged);
            this.textBoxParamA.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxParamA.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // textBoxParamK
            // 
            this.textBoxParamK.Location = new System.Drawing.Point(186, 58);
            this.textBoxParamK.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParamK.Name = "textBoxParamK";
            this.textBoxParamK.Size = new System.Drawing.Size(33, 22);
            this.textBoxParamK.TabIndex = 1;
            this.textBoxParamK.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxParamK.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // textBoxParamM
            // 
            this.textBoxParamM.Location = new System.Drawing.Point(246, 123);
            this.textBoxParamM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParamM.Name = "textBoxParamM";
            this.textBoxParamM.Size = new System.Drawing.Size(65, 22);
            this.textBoxParamM.TabIndex = 0;
            this.textBoxParamM.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxParamM.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // labelCursor
            // 
            this.labelCursor.AutoSize = true;
            this.labelCursor.Location = new System.Drawing.Point(477, 258);
            this.labelCursor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCursor.Name = "labelCursor";
            this.labelCursor.Size = new System.Drawing.Size(16, 17);
            this.labelCursor.TabIndex = 7;
            this.labelCursor.Text = "?";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(125, 252);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 28);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ViewBox
            // 
            this.ViewBox.Controls.Add(this.checkBoxViewX2);
            this.ViewBox.Controls.Add(this.checkBoxViewX1);
            this.ViewBox.Controls.Add(this.checkBoxViewY);
            this.ViewBox.Controls.Add(this.checkBoxViewE);
            this.ViewBox.Controls.Add(this.checkBoxViewU);
            this.ViewBox.Location = new System.Drawing.Point(849, 6);
            this.ViewBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Padding = new System.Windows.Forms.Padding(4);
            this.ViewBox.Size = new System.Drawing.Size(93, 212);
            this.ViewBox.TabIndex = 3;
            this.ViewBox.TabStop = false;
            this.ViewBox.Text = "View:";
            // 
            // checkBoxViewX2
            // 
            this.checkBoxViewX2.AutoSize = true;
            this.checkBoxViewX2.Location = new System.Drawing.Point(9, 122);
            this.checkBoxViewX2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewX2.Name = "checkBoxViewX2";
            this.checkBoxViewX2.Size = new System.Drawing.Size(58, 21);
            this.checkBoxViewX2.TabIndex = 4;
            this.checkBoxViewX2.Text = "x2(t)";
            this.checkBoxViewX2.UseVisualStyleBackColor = true;
            this.checkBoxViewX2.CheckedChanged += new System.EventHandler(this.CheckBoxView_CheckedChanged);
            // 
            // checkBoxViewX1
            // 
            this.checkBoxViewX1.AutoSize = true;
            this.checkBoxViewX1.Location = new System.Drawing.Point(9, 96);
            this.checkBoxViewX1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewX1.Name = "checkBoxViewX1";
            this.checkBoxViewX1.Size = new System.Drawing.Size(58, 21);
            this.checkBoxViewX1.TabIndex = 3;
            this.checkBoxViewX1.Text = "x1(t)";
            this.checkBoxViewX1.UseVisualStyleBackColor = true;
            this.checkBoxViewX1.CheckedChanged += new System.EventHandler(this.CheckBoxView_CheckedChanged);
            // 
            // checkBoxViewY
            // 
            this.checkBoxViewY.AutoSize = true;
            this.checkBoxViewY.Location = new System.Drawing.Point(9, 70);
            this.checkBoxViewY.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewY.Name = "checkBoxViewY";
            this.checkBoxViewY.Size = new System.Drawing.Size(51, 21);
            this.checkBoxViewY.TabIndex = 2;
            this.checkBoxViewY.Text = "y(t)";
            this.checkBoxViewY.UseVisualStyleBackColor = true;
            this.checkBoxViewY.CheckedChanged += new System.EventHandler(this.CheckBoxView_CheckedChanged);
            // 
            // checkBoxViewE
            // 
            this.checkBoxViewE.AutoSize = true;
            this.checkBoxViewE.Location = new System.Drawing.Point(9, 44);
            this.checkBoxViewE.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewE.Name = "checkBoxViewE";
            this.checkBoxViewE.Size = new System.Drawing.Size(52, 21);
            this.checkBoxViewE.TabIndex = 1;
            this.checkBoxViewE.Text = "e(t)";
            this.checkBoxViewE.UseVisualStyleBackColor = true;
            this.checkBoxViewE.CheckedChanged += new System.EventHandler(this.CheckBoxView_CheckedChanged);
            // 
            // checkBoxViewU
            // 
            this.checkBoxViewU.AutoSize = true;
            this.checkBoxViewU.Location = new System.Drawing.Point(9, 18);
            this.checkBoxViewU.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewU.Name = "checkBoxViewU";
            this.checkBoxViewU.Size = new System.Drawing.Size(52, 21);
            this.checkBoxViewU.TabIndex = 0;
            this.checkBoxViewU.Text = "u(t)";
            this.checkBoxViewU.UseVisualStyleBackColor = true;
            this.checkBoxViewU.CheckedChanged += new System.EventHandler(this.CheckBoxView_CheckedChanged);
            // 
            // NavBox
            // 
            this.NavBox.Controls.Add(this.buttonZoomIn);
            this.NavBox.Controls.Add(this.label12);
            this.NavBox.Controls.Add(this.label11);
            this.NavBox.Controls.Add(this.buttonZoomOut);
            this.NavBox.Controls.Add(this.buttonMoveDown);
            this.NavBox.Controls.Add(this.buttonMoveRight);
            this.NavBox.Controls.Add(this.buttonMoveCenter);
            this.NavBox.Controls.Add(this.buttonMoveLeft);
            this.NavBox.Controls.Add(this.buttonMoveUp);
            this.NavBox.Location = new System.Drawing.Point(956, 6);
            this.NavBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NavBox.Name = "NavBox";
            this.NavBox.Padding = new System.Windows.Forms.Padding(4);
            this.NavBox.Size = new System.Drawing.Size(128, 212);
            this.NavBox.TabIndex = 4;
            this.NavBox.TabStop = false;
            this.NavBox.Text = "Navigation:";
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZoomIn.Location = new System.Drawing.Point(49, 174);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(29, 27);
            this.buttonZoomIn.TabIndex = 9;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.ButtonZoom_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Zoom:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Move:";
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZoomOut.Location = new System.Drawing.Point(12, 174);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(29, 27);
            this.buttonZoomOut.TabIndex = 5;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.ButtonZoom_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoveDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMoveDown.Location = new System.Drawing.Point(49, 117);
            this.buttonMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(29, 27);
            this.buttonMoveDown.TabIndex = 4;
            this.buttonMoveDown.Text = "v";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(87, 82);
            this.buttonMoveRight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(29, 27);
            this.buttonMoveRight.TabIndex = 3;
            this.buttonMoveRight.Text = ">";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonMoveCenter
            // 
            this.buttonMoveCenter.Location = new System.Drawing.Point(49, 82);
            this.buttonMoveCenter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveCenter.Name = "buttonMoveCenter";
            this.buttonMoveCenter.Size = new System.Drawing.Size(29, 27);
            this.buttonMoveCenter.TabIndex = 2;
            this.buttonMoveCenter.Text = "0";
            this.buttonMoveCenter.UseVisualStyleBackColor = true;
            this.buttonMoveCenter.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(12, 82);
            this.buttonMoveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(29, 27);
            this.buttonMoveLeft.TabIndex = 1;
            this.buttonMoveLeft.Text = "<";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMoveUp.Location = new System.Drawing.Point(49, 48);
            this.buttonMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(29, 27);
            this.buttonMoveUp.TabIndex = 0;
            this.buttonMoveUp.Text = "⌃";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // RangeBox
            // 
            this.RangeBox.Controls.Add(this.buttonValSet);
            this.RangeBox.Controls.Add(this.buttonArgSet);
            this.RangeBox.Controls.Add(this.checkBoxValAuto);
            this.RangeBox.Controls.Add(this.checkBoxArgAuto);
            this.RangeBox.Controls.Add(this.textBoxValMax);
            this.RangeBox.Controls.Add(this.textBoxValMin);
            this.RangeBox.Controls.Add(this.textBoxArgMax);
            this.RangeBox.Controls.Add(this.label9);
            this.RangeBox.Controls.Add(this.label8);
            this.RangeBox.Controls.Add(this.label7);
            this.RangeBox.Controls.Add(this.label6);
            this.RangeBox.Controls.Add(this.label5);
            this.RangeBox.Controls.Add(this.textBoxArgMin);
            this.RangeBox.Controls.Add(this.label4);
            this.RangeBox.Location = new System.Drawing.Point(1098, 6);
            this.RangeBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RangeBox.Name = "RangeBox";
            this.RangeBox.Padding = new System.Windows.Forms.Padding(4);
            this.RangeBox.Size = new System.Drawing.Size(295, 212);
            this.RangeBox.TabIndex = 5;
            this.RangeBox.TabStop = false;
            this.RangeBox.Text = "Ranges:";
            // 
            // buttonValSet
            // 
            this.buttonValSet.Location = new System.Drawing.Point(53, 161);
            this.buttonValSet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValSet.Name = "buttonValSet";
            this.buttonValSet.Size = new System.Drawing.Size(80, 28);
            this.buttonValSet.TabIndex = 14;
            this.buttonValSet.Text = "Set";
            this.buttonValSet.UseVisualStyleBackColor = true;
            this.buttonValSet.Click += new System.EventHandler(this.ButtonValSet_Click);
            // 
            // buttonArgSet
            // 
            this.buttonArgSet.Location = new System.Drawing.Point(53, 78);
            this.buttonArgSet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArgSet.Name = "buttonArgSet";
            this.buttonArgSet.Size = new System.Drawing.Size(80, 28);
            this.buttonArgSet.TabIndex = 13;
            this.buttonArgSet.Text = "Set";
            this.buttonArgSet.UseVisualStyleBackColor = true;
            this.buttonArgSet.Click += new System.EventHandler(this.ButtonArgSet_Click);
            // 
            // checkBoxValAuto
            // 
            this.checkBoxValAuto.AutoSize = true;
            this.checkBoxValAuto.Checked = true;
            this.checkBoxValAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxValAuto.Location = new System.Drawing.Point(160, 166);
            this.checkBoxValAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxValAuto.Name = "checkBoxValAuto";
            this.checkBoxValAuto.Size = new System.Drawing.Size(59, 21);
            this.checkBoxValAuto.TabIndex = 12;
            this.checkBoxValAuto.Text = "Auto";
            this.checkBoxValAuto.UseVisualStyleBackColor = true;
            this.checkBoxValAuto.CheckedChanged += new System.EventHandler(this.CheckBoxValAuto_CheckedChanged);
            // 
            // checkBoxArgAuto
            // 
            this.checkBoxArgAuto.AutoSize = true;
            this.checkBoxArgAuto.Checked = true;
            this.checkBoxArgAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxArgAuto.Location = new System.Drawing.Point(161, 82);
            this.checkBoxArgAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxArgAuto.Name = "checkBoxArgAuto";
            this.checkBoxArgAuto.Size = new System.Drawing.Size(59, 21);
            this.checkBoxArgAuto.TabIndex = 11;
            this.checkBoxArgAuto.Text = "Auto";
            this.checkBoxArgAuto.UseVisualStyleBackColor = true;
            this.checkBoxArgAuto.CheckedChanged += new System.EventHandler(this.CheckBoxArgAuto_CheckedChanged);
            // 
            // textBoxValMax
            // 
            this.textBoxValMax.Location = new System.Drawing.Point(204, 129);
            this.textBoxValMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValMax.Name = "textBoxValMax";
            this.textBoxValMax.Size = new System.Drawing.Size(79, 22);
            this.textBoxValMax.TabIndex = 10;
            this.textBoxValMax.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxValMax.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // textBoxValMin
            // 
            this.textBoxValMin.Location = new System.Drawing.Point(53, 129);
            this.textBoxValMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxValMin.Name = "textBoxValMin";
            this.textBoxValMin.Size = new System.Drawing.Size(79, 22);
            this.textBoxValMin.TabIndex = 9;
            this.textBoxValMin.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxValMin.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // textBoxArgMax
            // 
            this.textBoxArgMax.Location = new System.Drawing.Point(204, 44);
            this.textBoxArgMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArgMax.Name = "textBoxArgMax";
            this.textBoxArgMax.Size = new System.Drawing.Size(79, 22);
            this.textBoxArgMax.TabIndex = 7;
            this.textBoxArgMax.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxArgMax.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Values:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Max:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Min:";
            // 
            // textBoxArgMin
            // 
            this.textBoxArgMin.Location = new System.Drawing.Point(53, 45);
            this.textBoxArgMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArgMin.Name = "textBoxArgMin";
            this.textBoxArgMin.Size = new System.Drawing.Size(79, 22);
            this.textBoxArgMin.TabIndex = 1;
            this.textBoxArgMin.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.textBoxArgMin.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arguments:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.InputSettingsBox);
            this.flowLayoutPanel1.Controls.Add(this.SystemBox);
            this.flowLayoutPanel1.Controls.Add(this.ViewBox);
            this.flowLayoutPanel1.Controls.Add(this.NavBox);
            this.flowLayoutPanel1.Controls.Add(this.RangeBox);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 16);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1441, 229);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 228);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 123);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 257);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Cursor Position:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ScControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelCursor);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.graphArea);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScControl";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Size = new System.Drawing.Size(1529, 794);
            this.Resize += new System.EventHandler(this.ScControl_Resize);
            this.InputSettingsBox.ResumeLayout(false);
            this.InputSettingsBox.PerformLayout();
            this.SystemBox.ResumeLayout(false);
            this.SystemBox.PerformLayout();
            this.ViewBox.ResumeLayout(false);
            this.ViewBox.PerformLayout();
            this.NavBox.ResumeLayout(false);
            this.NavBox.PerformLayout();
            this.RangeBox.ResumeLayout(false);
            this.RangeBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel graphArea;
        private System.Windows.Forms.GroupBox InputSettingsBox;
        private System.Windows.Forms.GroupBox SystemBox;
        private System.Windows.Forms.GroupBox ViewBox;
        private System.Windows.Forms.GroupBox NavBox;
        private System.Windows.Forms.GroupBox RangeBox;
        private System.Windows.Forms.TextBox textBoxInputFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimestep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStopTime;
        private System.Windows.Forms.TextBox textBoxParamA;
        private System.Windows.Forms.TextBox textBoxParamK;
        private System.Windows.Forms.TextBox textBoxParamM;
        private System.Windows.Forms.TextBox textBoxParamA2;
        private System.Windows.Forms.CheckBox checkBoxViewY;
        private System.Windows.Forms.CheckBox checkBoxViewE;
        private System.Windows.Forms.CheckBox checkBoxViewU;
        private System.Windows.Forms.CheckBox checkBoxViewX2;
        private System.Windows.Forms.CheckBox checkBoxViewX1;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveCenter;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArgMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxArgMax;
        private System.Windows.Forms.TextBox textBoxValMin;
        private System.Windows.Forms.TextBox textBoxValMax;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelCursor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.CheckBox checkBoxArgAuto;
        private System.Windows.Forms.Button buttonArgSet;
        private System.Windows.Forms.CheckBox checkBoxValAuto;
        private System.Windows.Forms.Button buttonValSet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
