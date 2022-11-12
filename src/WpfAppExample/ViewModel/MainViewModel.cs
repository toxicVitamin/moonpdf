using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppExample.ViewModel
{
    public class MainViewModel : Base.BaseViewModel
    {

        public MainViewModel()
        {
            OpenCommand = new Base.RelayCommand(OnOpenCommandExecuted, CanOpenCommandExecute);
            OpenFileCommand = new Base.RelayCommand(OnOpenFileCommandExecuted, CanOpenFileCommandExecute);
        }

        private byte[] data = null;

        public byte[] Data
        {
            get { return data; }
            set { data = value; OnPropertyChanged(nameof(Data)); }
        }

        private string title = "";

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(nameof(Title)); }
        }



        #region OpenCommand
        public ICommand OpenCommand { get; set; }

        private bool CanOpenCommandExecute(object o) => true;

        private void OnOpenCommandExecuted(object o)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog { Title = "Select PDF file...", DefaultExt = ".pdf", Filter = "PDF file (.pdf)|*.pdf", CheckFileExists = true };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    Title = Path.GetFileName(dlg.FileName);
                    //pdfPanel.OpenFile(dlg.FileName);
                    Data = File.ReadAllBytes(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An error occured: " + ex.Message));
                }
            }
        }

        #endregion OpenCommand

        #region OpenFileCommand

        public ICommand OpenFileCommand { get; set; }

        private bool CanOpenFileCommandExecute(object o) => true;

        private void OnOpenFileCommandExecuted(object o)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog { Title = "Select PDF file...", DefaultExt = ".pdf", Filter = "PDF file (.pdf)|*.pdf", CheckFileExists = true };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    //pdfPanel.OpenFile(dlg.FileName);

                    Title = Path.GetFileName(dlg.FileName);

                    Data = File.ReadAllBytes(dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An error occured: " + ex.Message));
                }
            }
        }

        #endregion OpenComOpenFileCommandmand
    }
}
