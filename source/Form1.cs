using System.Windows.Forms;

namespace charkys_mupen64plus_launching_utility;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        versionDisplay.Text = "1.0.0.0";

        StreamReader txt = new("__data__/__parameters__.dat");
        string line = txt.ReadToEnd();
        if (line == null)
        {
            editParamsBox.Text = "";
        }
        else
        {
            editParamsBox.Text = line;
        }
        txt.Close();

        StreamReader txt1 = new("__data__/__rompath__.dat");
        string line1 = txt1.ReadToEnd();
        if (line1 == null)
        {
            line1 = "";
        }
        else
        {
            DirectoryInfo dinfo = new DirectoryInfo(line1);
            FileInfo[] roms = dinfo.GetFiles();
            romPathBox.Text = line1;

            foreach (FileInfo file in roms)
            {
                romsBox.Items.Add(file.Name);
            }
        }

        txt1.Close();
    }



    private void editRomPathButton_Click(object sender, EventArgs e)
    {
        /// Get the folder containing the ROMS
        if (browsePathToRoms.ShowDialog() == DialogResult.OK)
        {
            DirectoryInfo dinfo = new DirectoryInfo(browsePathToRoms.SelectedPath);
            FileInfo[] roms = dinfo.GetFiles();
            romPathBox.Text = browsePathToRoms.SelectedPath;

            /// Write the selected path to file to store
            StreamWriter txt = new("__data__/__rompath__.dat");
            txt.Write(browsePathToRoms.SelectedPath);
            txt.Close();

            /// Populate the files in directory into listBox "RomSelectionBox"
            foreach (FileInfo file in roms)
            {
                romsBox.Items.Add(file.Name);
            }
        }
    }

    private void goTimeButton_Click(object sender, EventArgs e)
    {
        string cmnd;
        string game;
        string parameters;

        StreamReader txt = new("__data__/__parameters__.dat");
        string line = txt.ReadToEnd();
        parameters = line;
        txt.Close();

        StreamReader txt1 = new("__data__/__rompath__.dat");
        string line1 = txt1.ReadToEnd();
        game = line1 + "\\" + selectedGameBox.Text;
        txt1.Close();

        cmnd = "/C mupen64plus-ui-console.exe " + parameters + " " + "\"" + game + "\"";
        System.Diagnostics.Process.Start("CMD.exe", cmnd);

        ///System.Diagnostics.Process process = new System.Diagnostics.Process();
        ///System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        ///startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        ///startInfo.FileName = "cmd.exe";
        ///startInfo.Arguments = cmnd;
        ///process.StartInfo = startInfo;
        ///process.Start();
    }

    private void romPathBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void selectedGameBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void saveParamsButton_Click(object sender, EventArgs e)
    {
        StreamWriter txt = new("__data__/__parameters__.dat");
        txt.Write(editParamsBox.Text);
        txt.Close();
    }

    private void clearParamsButton_Click(object sender, EventArgs e)
    {
        editParamsBox.Text = "";
        StreamWriter txt = new("__data__/__parameters__.dat");
        txt.Write(editParamsBox.Text);
        txt.Close();
    }

    private void editParamsBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void romsBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedGameBox.Text = romsBox.Items[romsBox.SelectedIndex].ToString();
    }

    private void versionDisplay_Click(object sender, EventArgs e)
    {

    }
}