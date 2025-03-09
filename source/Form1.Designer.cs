namespace charkys_mupen64plus_launching_utility;

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

    #region Windows Designer Generated Code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    /// 

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        editRomPathButton = new Button();
        romPathBox = new TextBox();
        goTimeButton = new Button();
        selectedGameBox = new TextBox();
        romsBox = new ListBox();
        editParamsBox = new TextBox();
        saveParamsButton = new Button();
        clearParamsButton = new Button();
        versionDisplay = new Label();
        browsePathToRoms = new FolderBrowserDialog();
        SuspendLayout();
        // 
        // editRomPathButton
        // 
        editRomPathButton.Location = new Point(12, 35);
        editRomPathButton.Name = "editRomPathButton";
        editRomPathButton.Size = new Size(111, 23);
        editRomPathButton.TabIndex = 0;
        editRomPathButton.Text = "Edit ROM Path";
        editRomPathButton.UseVisualStyleBackColor = true;
        editRomPathButton.Click += editRomPathButton_Click;
        // 
        // romPathBox
        // 
        romPathBox.Enabled = false;
        romPathBox.Location = new Point(12, 6);
        romPathBox.Name = "romPathBox";
        romPathBox.Size = new Size(170, 23);
        romPathBox.TabIndex = 1;
        romPathBox.TextChanged += romPathBox_TextChanged;
        // 
        // goTimeButton
        // 
        goTimeButton.Location = new Point(543, 35);
        goTimeButton.Name = "goTimeButton";
        goTimeButton.Size = new Size(111, 23);
        goTimeButton.TabIndex = 2;
        goTimeButton.Text = "Launch Mupen";
        goTimeButton.UseVisualStyleBackColor = true;
        goTimeButton.Click += goTimeButton_Click;
        // 
        // selectedGameBox
        // 
        selectedGameBox.Enabled = false;
        selectedGameBox.Location = new Point(484, 6);
        selectedGameBox.Name = "selectedGameBox";
        selectedGameBox.Size = new Size(170, 23);
        selectedGameBox.TabIndex = 3;
        selectedGameBox.TextChanged += selectedGameBox_TextChanged;
        // 
        // romsBox
        // 
        romsBox.FormattingEnabled = true;
        romsBox.Location = new Point(12, 64);
        romsBox.Name = "romsBox";
        romsBox.Size = new Size(642, 319);
        romsBox.TabIndex = 4;
        romsBox.SelectedIndexChanged += romsBox_SelectedIndexChanged;
        // 
        // editParamsBox
        // 
        editParamsBox.Location = new Point(12, 389);
        editParamsBox.Multiline = true;
        editParamsBox.Name = "editParamsBox";
        editParamsBox.Size = new Size(642, 144);
        editParamsBox.TabIndex = 5;
        editParamsBox.TextChanged += editParamsBox_TextChanged;
        // 
        // saveParamsButton
        // 
        saveParamsButton.Location = new Point(12, 539);
        saveParamsButton.Name = "saveParamsButton";
        saveParamsButton.Size = new Size(75, 23);
        saveParamsButton.TabIndex = 6;
        saveParamsButton.Text = "Save";
        saveParamsButton.UseVisualStyleBackColor = true;
        saveParamsButton.Click += saveParamsButton_Click;
        // 
        // clearParamsButton
        // 
        clearParamsButton.Location = new Point(93, 539);
        clearParamsButton.Name = "clearParamsButton";
        clearParamsButton.Size = new Size(75, 23);
        clearParamsButton.TabIndex = 7;
        clearParamsButton.Text = "Clear";
        clearParamsButton.UseVisualStyleBackColor = true;
        clearParamsButton.Click += clearParamsButton_Click;
        // 
        // versionDisplay
        // 
        versionDisplay.AutoSize = true;
        versionDisplay.Location = new Point(616, 543);
        versionDisplay.Name = "versionDisplay";
        versionDisplay.Size = new Size(38, 15);
        versionDisplay.TabIndex = 8;
        versionDisplay.Text = "label1";
        versionDisplay.Click += versionDisplay_Click;
        // 
        // Form1
        // 
        ClientSize = new Size(666, 567);
        Controls.Add(versionDisplay);
        Controls.Add(clearParamsButton);
        Controls.Add(saveParamsButton);
        Controls.Add(editParamsBox);
        Controls.Add(romsBox);
        Controls.Add(selectedGameBox);
        Controls.Add(goTimeButton);
        Controls.Add(romPathBox);
        Controls.Add(editRomPathButton);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        Text = "Charky's mupen64plus Launching Utility";
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private Button editRomPathButton;
    private TextBox romPathBox;
    private Button goTimeButton;
    private TextBox selectedGameBox;
    private ListBox romsBox;
    private TextBox editParamsBox;
    private Button saveParamsButton;
    private Button clearParamsButton;
    private Label versionDisplay;
    private FolderBrowserDialog browsePathToRoms;
}
