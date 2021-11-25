using System;
using System.IO;
using Xamarin.Forms;

namespace Notes.Views
{
    
    public partial class NotesPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.LocalApplicationData), "notes.txt");
        public NotesPage()
        {
            InitializeComponent();
            //read the file 
            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);
            }
        }
        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //save the file
            File.WriteAllText(_fileName, editor.Text);
        }
        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            //delete the file 
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;
        }
       
    }
}