using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BackupWatcher.ViewModel;

namespace BackupWatcher
{
    public partial class Form1 : Form
    {
        const string FILENAME_FORMAT = "Nash Backup {0:dd-MM-yyyy HH-mm-ss}.sql";
        const string PATTERN = @"Nash Backup ([\d\-\s]+).sql";
        private readonly MainViewModel viewModel;

        public Form1()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            Load += (sender, args) =>
            {
                directoryDisplay.DataBindings.Add("Text", viewModel, "CaminhoDiretorio");
                logDisplay.DataBindings.Add("Text", viewModel, "Log");
            };
        }

        private void Button1Click(object sender, EventArgs e)
        {
            directoryWatcher.Created -= DirectoryWatcherOnCreated;
            folderDialog.ShowDialog();
            directoryWatcher.Filter = "*.sql";
            directoryWatcher.Path = viewModel.CaminhoDiretorio = folderDialog.SelectedPath;
            directoryWatcher.Created += DirectoryWatcherOnCreated;
        }

        private void DirectoryWatcherOnCreated(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            var fileCreated = fileSystemEventArgs.FullPath;
            var directoryName = Path.GetDirectoryName(fileCreated);
            var newLine = Environment.NewLine;
            var fileInfo = new FileInfo(fileCreated);
            var newName = string.Format(FILENAME_FORMAT, fileInfo.CreationTime);
            var destFileName = Path.Combine(directoryName, newName);

            viewModel.Log += string.Format("Arquivo: {0} foi criado{1}", fileCreated, newLine);
            fileInfo.MoveTo(destFileName);
            viewModel.Log += string.Format("Arquivo: {0} foi renomeado para {1}{2}", fileCreated, destFileName, newLine);

            foreach (var file in Directory.EnumerateFiles(directoryName, "*.bat"))
            {
                string content;
                using (var streamReader = new StreamReader(file))
                    content = streamReader.ReadToEnd();

                var match = Regex.Match(content, PATTERN);
                if (match.Success)
                {
                    viewModel.Log += string.Format("Arquivo: {0} vai ser alterado{1}", file, newLine);
                    content = Regex.Replace(content, PATTERN, newName);
                    using (var streamWriter = new FileStream(file, FileMode.Create))
                    {
                        var bytes = Encoding.Default.GetBytes(content);
                        streamWriter.Write(bytes, 0, bytes.Length);
                    }
                }
            }
        }
    }
}