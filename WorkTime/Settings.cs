﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WorkTime
{
    public partial class Settings : Form
    {
        private Form1 parent;
        private string url;
        const string INILocation = "\\settings.ini";
        private INIManager iniManager;

        public Settings(Form1 _parent)
        {
            InitializeComponent();
            iniManager = new INIManager(Directory.GetCurrentDirectory() + INILocation);
            parent = _parent;
            LoadURLfromINI();
            TextBoxURL.Text = url;
        }


        private void LoadURLToINI()
        {
            iniManager.WritePrivateString("web", "site", url);
        }

        private void LoadURLfromINI()
        {
            url = iniManager.GetPrivateString("web", "site");
        }

        private bool IsURLValid()
        {
            return parent.IsURLValid(url);
        }

        public string GetURL()
        {
            return url;
        }

     
        private void Settings_Shown(object sender, EventArgs e)
        {
            ShowAllIsOK();
        }

        private void TextBoxURL_TextChanged(object sender, EventArgs e)
        {
            url = TextBoxURL.Text;
            ShowAllIsOK();
        }

        private void ShowAllIsOK()
        {
            bool result = IsURLValid();
            ButtonAccept.Enabled = result;
            if (result)
            {
                labelValidity.ForeColor = Color.Green;
                labelValidity.Text = "Ссылка действительна.";
            }
            else
            {
                labelValidity.ForeColor = Color.Red;
                labelValidity.Text = "Ссылка недействительна.";
            }
        }


        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            url = TextBoxURL.Text;
            LoadURLToINI();
            parent.InitializeCalendar();
            this.Close();
        }
        
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
