using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BeatSaberGameSwitcher
{
  public partial class AboutWindow : Form
  {
    public AboutWindow()
    {
      InitializeComponent();
    }

    private void myNameLabel_Click(object sender, EventArgs e)
    {
      ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/AlexAzumi");
      Process.Start(sInfo);
    }
  }
}
