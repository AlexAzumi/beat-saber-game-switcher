using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BeatSaberGameSwitcher
{

  public partial class SetupWindow : Form
  {
    // Regex
    Regex gamePathRegex = new Regex(@"(.*)(Beat Saber.exe)$");
    // Variables
    private string gameVanillaPath;
    private string gameModdedPath;

    public SetupWindow()
    {
      InitializeComponent();
    }

    private void vanillaPathBtn_Click(object sender, EventArgs e)
    {
      gameVanillaPath = GetPath("Select the vanilla Beat Saber folder");

      if (string.IsNullOrWhiteSpace(gameVanillaPath))
      {
        MessageBox.Show("The selected path is not valid", "Error", MessageBoxButtons.OK);
        return;
      }

      this.vanillaPathTB.Text = gameVanillaPath;
    }

    private void moddedPathBtn_Click(object sender, EventArgs e)
    {
      gameModdedPath = GetPath("Select the modded Beat Saber folder");

      if (string.IsNullOrWhiteSpace(gameModdedPath))
      {
        MessageBox.Show("The selected path is not valid", "Error", MessageBoxButtons.OK);
        return;
      }

      this.moddedPathTB.Text = gameModdedPath;
    }

    /// <summary>
    /// Gets the path of the selected folder
    /// </summary>
    /// <returns><c>string</c> - Complete path of the selected folder. <c>null</c> will be returned if not canceld</returns>
    private string GetPath(string dialogDescription)
    {
      using (var fbd = new FolderBrowserDialog())
      {
        fbd.Description = dialogDescription;
        DialogResult result = fbd.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        {
          string[] files = Directory.GetFiles(fbd.SelectedPath);

          foreach (string file in files)
          {
            bool isFolder = gamePathRegex.IsMatch(file);

            Console.WriteLine(file, isFolder);

            if (isFolder)
            {
              return fbd.SelectedPath;
            }

          }

          return null;
        }
        else
        {
          return null;
        }
      }
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
      if (gameVanillaPath != null && gameModdedPath != null)
      {
        Properties.Settings.Default["GameVanillaPath"] = gameVanillaPath;
        Properties.Settings.Default["GameModdedPath"] = gameModdedPath;

        Properties.Settings.Default.Save();

        this.Close();
      }
      else
      {
        MessageBox.Show("First assign the correct game folders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void SetupWindow_Load(object sender, EventArgs e)
    {
      gameVanillaPath = Properties.Settings.Default.GameVanillaPath;
      gameModdedPath = Properties.Settings.Default.GameModdedPath;
      // Update text inputs
      this.vanillaPathTB.Text = gameVanillaPath;
      this.moddedPathTB.Text = gameModdedPath;
    }
  }
}
