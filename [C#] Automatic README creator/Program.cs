using System;
using System.Diagnostics;
using System.IO;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

static class README_Creator
{
    public static void Main()
    {
        // Repository details
        //
        // Just open your repository and check the URL, copy the details like this:
        // github.com/(GitHubUsername)/(RepositoryName)
        //
        // You can find your branch here, but most likely it will just be 'main':
        // github.com/Cryakl/Ultimate-RAT-Collection/branches
        string GithubUsername = "Cryakl";
        string RepositoryName = "Ultimate-RAT-Collection";
        string Branch = "main";

        // Base URL for raw GitHub content, I don't think you'll need to change this.
        string BaseUrl = $"https://raw.githubusercontent.com/{GithubUsername}/{RepositoryName}/refs/heads/{Branch}";

        // Get current working directory (I'm assuming you're going to run this .exe in the repos root directory.)
        string Folder = Directory.GetCurrentDirectory();

        // Start recursive processing
        ProcessFolder(Folder, BaseUrl, Folder);

        // Optionally, you can pause at the end, but I don't do this.
        //Console.WriteLine("Finished batch creation of README's, press any key to exit!");
        //Console.ReadKey();

        // Also, optionally, you can just make it delete itself at the end.
        // Most likely you're just going to be moving this exe in and out of your root so this is fine.
        //string ExePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        //ProcessStartInfo SelfDelete = new ProcessStartInfo();
        //SelfDelete.Arguments = "/C choice /C Y /N /D Y /T 5 & Del " + ExePath;
        //SelfDelete.WindowStyle = ProcessWindowStyle.Hidden;
        //SelfDelete.CreateNoWindow = true;
        //SelfDelete.FileName = "cmd.exe";
        //Process.Start(SelfDelete);
    }

    public static void ProcessFolder(string FolderPath, string BaseUrl, string RepoRoot)
    {
        // If you want to name your screenshots differently, here.
        string ScreenshotFilename = "Screenshot.png";
        string ScreenshotPath = Path.Combine(FolderPath, ScreenshotFilename);

        // We only want to create a README if a screenshot actually exists in a folder.
        if (File.Exists(ScreenshotPath))
        {
            // Calculate relative path from repository root.
            string RelativePath = FolderPath.Substring(RepoRoot.Length).TrimStart(Path.DirectorySeparatorChar);
            string EncodedPath = HttpUtility.UrlPathEncode(RelativePath.Replace(@"\", "/"));

            // Construct the raw GitHub image URL.
            string ImageURL = $"{BaseUrl}/{EncodedPath}/{ScreenshotFilename}";
            string READMEPath = Path.Combine(FolderPath, "README.md");

            // We also don't want to overwrite READMEs that already exist.
            if (!File.Exists(READMEPath))
            {
                string READMEContent = $"![Screenshot]({ImageURL})" + Environment.NewLine;
                File.WriteAllText(READMEPath, READMEContent);
                Console.WriteLine($"Generated README.md for {RelativePath}");
            }
            else
                Console.WriteLine($"Skipped writing to existing README.md in {RelativePath}");
        }

        // Go into every deeper folder and do the same thing.
        foreach (string SubFolder in Directory.GetDirectories(FolderPath))
            ProcessFolder(SubFolder, BaseUrl, RepoRoot);
    }
}
