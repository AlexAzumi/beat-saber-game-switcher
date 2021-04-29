using System;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;

namespace BeatSaberGameSwitcher
{
  public partial class MainWindow : Form
  {
    enum Version { Vanilla, Modded, Unknown };
    // Parameters
    private string GAME_FOLDER = "Beat Saber";
    private string GAME_FOLDER_VANILLA = "Beat Saber_vanilla";
    private string GAME_FOLDER_MODDED = "Beat Saber_modded";
    // Regex
    Regex originalPathRegex = new Regex(@"(.*)(Beat Saber)$");
    Regex vanillaPathRegex = new Regex(@"(.*)(Beat Saber_vanilla)$");
    Regex moddedPathRegex = new Regex(@"(.*)(Beat Saber_modded)$");
    // Variables
    private SetupWindow setupWindow;
    private string gameVanillaPath;
    private string gameModdedPath;
    private Version currentVersion;
    private DirectoryInfo baseDirectory;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void MainWindow_Shown(object sender, EventArgs e)
    {
      setupWindow = new SetupWindow();
      setupWindow.FormClosed += new FormClosedEventHandler(OnSetupClosed);

      if (!GetAppSettings())
      {
        setupWindow.ShowDialog();
      }
      else
      {
        CheckSelectedVersion();
      }
    }

    /// <summary>
    /// Checks if the set up window did save the new settings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnSetupClosed(object sender, FormClosedEventArgs e)
    {
      if (!GetAppSettings())
      {
        Application.Exit();
      }
    }

    /// <summary>
    /// Gets all the app settings stored
    /// </summary>
    /// <returns>`true` if the settings where loaded correctly</returns>
    private bool GetAppSettings()
    {
      try
      {
        gameVanillaPath = Properties.Settings.Default["GameVanillaPath"].ToString();
        gameModdedPath = Properties.Settings.Default["GameModdedPath"].ToString();

        if (string.IsNullOrWhiteSpace(gameVanillaPath) || string.IsNullOrWhiteSpace(gameModdedPath))
        {
          return false;
        }

        return true;
      }
      catch (SettingsPropertyNotFoundException ex)
      {
        Console.WriteLine(ex);
        return false;
      }
    }

    /// <summary>
    /// Checks witch version of the game is active.
    /// </summary>
    private void CheckSelectedVersion()
    {
      // Check if the vanilla or modded game folder exists
      baseDirectory = Directory.GetParent(gameVanillaPath);
      string basePath = Path.Combine(baseDirectory.ToString(), GAME_FOLDER);
      string vanillaPath = Path.Combine(baseDirectory.ToString(), GAME_FOLDER_VANILLA);
      string moddedPath = Path.Combine(baseDirectory.ToString(), GAME_FOLDER_MODDED);

      if (Directory.Exists(vanillaPath))
      {
        Console.WriteLine("Vanilla game: Backed up");
        // Override configuration
        Properties.Settings.Default.GameVanillaPath = vanillaPath;
        Properties.Settings.Default.Save();
        gameVanillaPath = vanillaPath;
      }
      else if (Directory.Exists(moddedPath))
      {
        Console.WriteLine("Modded game: Backed up");
        // Override configuration
        Properties.Settings.Default.GameVanillaPath = moddedPath;
        Properties.Settings.Default.Save();
        gameModdedPath = moddedPath;
      }

      bool isVanillaBackedup = vanillaPathRegex.IsMatch(gameVanillaPath);
      bool isModdedBackedup = moddedPathRegex.IsMatch(gameModdedPath);

      if (Directory.Exists(basePath) && isVanillaBackedup)
      {
        currentVersion = Version.Modded;
        switchGameBtn.Text = "Switch to Vanilla";
      }
      else if (Directory.Exists(basePath) && isModdedBackedup)
      {
        currentVersion = Version.Vanilla;
        switchGameBtn.Text = "Switch to Modded";
      }
      else
      {
        if (Directory.Exists(vanillaPath) || Directory.Exists(moddedPath))
        {
          switchGameBtn.Text = "No active versions. Click here to assign one";
        }
        else
        {
          switchGameBtn.Text = "Game not found";
        }
        currentVersion = Version.Unknown;
      }

      currentVersionL.Text = currentVersion.ToString();
    }

    private void switchGameBtn_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure you want to change the game version?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.No)
      {
        return;
      }

      if (currentVersion == Version.Vanilla)
      {
        Console.WriteLine("Switching to Modded game...");
        ChangeGameVersion(Version.Modded);
      }
      else if (currentVersion == Version.Modded)
      {
        Console.WriteLine("Switching to Vanilla game...");
        ChangeGameVersion(Version.Vanilla);
      }
      else
      {
        Console.WriteLine("Defining game version...");
      }
    }

    /// <summary>
    /// Changes the game current version
    /// </summary>
    /// <param name="targetVersion">Version that wants to be switched to</param>
    private void ChangeGameVersion(Version targetVersion)
    {
      string basePath = Path.Combine(baseDirectory.ToString(), GAME_FOLDER);
      string moddedPath = Path.Combine(baseDirectory.ToString(), GAME_FOLDER_MODDED);
      string vanillaPath = Path.Combine(baseDirectory.ToString(), GAME_FOLDER_VANILLA);

      if (Directory.Exists(basePath))
      {
        string backupTargetPath = targetVersion == Version.Vanilla ? moddedPath : vanillaPath;
        // Rename base game
        if (Directory.Exists(backupTargetPath))
        {
          MessageBox.Show(String.Format("The folder '{0}' already exists. Please remove it or assign correctly the game paths", backupTargetPath), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        else
        {
          Directory.Move(basePath, backupTargetPath);
          Properties.Settings.Default.GameModdedPath = backupTargetPath;
        }
      }

      string targetPath = targetVersion == Version.Vanilla ? vanillaPath : moddedPath;
      // Rename modded path to base path
      Directory.Move(targetPath, basePath);
      // Update settings
      currentVersion = targetVersion;
      Properties.Settings.Default[targetVersion == Version.Vanilla ? "GameVanillaPath" : "GameModdedPath"] = basePath;
      Properties.Settings.Default.Save();
      // Update labels
      currentVersionL.Text = currentVersion.ToString();
      switchGameBtn.Text = String.Format("Switch to {0}", targetVersion == Version.Vanilla ? "Modded" : "Vanilla");
      // Show successfull message
      MessageBox.Show(String.Format("The game switch to the {0} version correctly", targetVersion.ToString()), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
