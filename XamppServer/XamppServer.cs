using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using INISerializer;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace XamppServer
{
    public partial class frmServer : Form
    {
        public string configPath = "";
        public string xamppPath = "";
        public string projectPath = "";

        public Config configurazione = new Config();
        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            //Config configurazione = new Config();
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/configurazione.ini";
            if (checkPath(path, 0))
            {
                getDataFromConfig(path);
            }
            else
            {
                grbServer.Enabled = false;
            }
        }
        // type 0=file 1=dir
        public bool checkPath(string path, int type)
        {
            return (type == 0) ? File.Exists(path) : Directory.Exists(path);
             /*
            if (type == 0)
            {
                return File.Exists(path);
            }
            else
            {
                return Directory.Exists(path);
            }*/
        }
        public void getDataFromForm()
        {
            String xamppPath = edtXampp.Text;
            String projectPath = edtProject.Text;
            if (xamppPath == "" || projectPath == ""){
                MessageBox.Show("Errore: Riempire tutti i campi.");
                return;
            }
            if (!checkPath(projectPath, 1) && !checkPath(xamppPath, 1))
            {
                MessageBox.Show("Errore: Configurazione o xampp non trovato.");
                return;
            }
            //Config configurazione = new Config();
            configurazione.projectDir = projectPath;
            configurazione.xamppDir = xamppPath;
            grbServer.Enabled = createConfigFile(); ;
        }
        public bool createConfigFile()
        {
            try
            {
                var serializeConf = INISerializer.INISerializer.SerializeObject(configurazione, "config");
                var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/configurazione.ini";
                
                FileStream fileStream = File.Create(path);
                fileStream.Close();
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(serializeConf);

                    //tw.WriteLine("[config]");
                    //tw.WriteLine("xampp=" + configurazione.xamppDir);
                    //tw.WriteLine("project=" + configurazione.projectDir);
                }
                lblPath.Text = path;                
            }
            catch(Exception e){
                MessageBox.Show("Errore: creazione file");
                MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }
        public void getDataFromConfig(string path){
            //object loadConfig = INISerializer.INISerializer.deserializeObject(path);
            var xamppPath = INISerializer.INISerializer.IniReadValue("config", "xamppDir", path);
            var projectPath = INISerializer.INISerializer.IniReadValue("config", "projectDir", path);
            if (xamppPath == "" || projectPath == "")
            {
                MessageBox.Show("Errore: Configurazione incompleta.");
                return;
            }
            if (!checkPath(projectPath, 1) && !checkPath(xamppPath, 1))
            {
                MessageBox.Show("Errore configurazione: i percorsi non sono validi.");
                return;
            }
            configurazione.xamppDir = xamppPath;
            configurazione.projectDir = projectPath;
            edtXampp.Text = configurazione.xamppDir;
            edtProject.Text = configurazione.projectDir;
            grbServer.Enabled = true;
            lblPath.Text = path;
        }
        private void btnNuovo_Click(object sender, EventArgs e)
        {
            getDataFromForm();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            openConf();
        }
        private void openConf()
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "INI File (*.ini)|*ini";
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            this.configPath = dlg.FileName;
            getDataFromConfig(configPath);
        }
        private void edtXampp_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog()){
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK){
                    this.xamppPath = fbd.SelectedPath;
                    edtXampp.Text = this.xamppPath;
                }
            }
        }

        private void edtProject_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = this.xamppPath;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.projectPath = fbd.SelectedPath;
                    edtProject.Text = this.projectPath;
                }
            }
        }

        public void openXampp()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = configurazione.xamppDir + @"\xampp_start.exe";
            startInfo.CreateNoWindow = true;
            Process.Start(startInfo);
            System.Threading.Thread.Sleep(1500);

            string projectName = configurazione.projectDir;
            int htdocsIndex = projectName.IndexOf("htdocs") + "htdocs".Count();
            if (htdocsIndex == -1)
            {
                MessageBox.Show("Errore: progetto non trovato su xampp.");
                return;
            }
            string project = "";
            try
            {
                project = projectName.Substring(htdocsIndex);
            }
            catch(Exception e){
                MessageBox.Show(e.ToString());
                return;
            }
            //Regex rgx = new Regex(".*? htdocs");
            //string result = rgx.Match(configurazione.projectDir).Value;

            try
            {
                Process.Start("chrome.exe", @"localhost/" + project);
            }catch(Exception e){
                Process.Start(@"localhost/" + project);
            }
        }
        public void closeXampp()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = configurazione.xamppDir + @"\xampp_stop.exe";
            //startInfo.CreateNoWindow = true;
            Process.Start(startInfo);
            
            /*var processInfo = new ProcessStartInfo("cmd.exe", "/c " + configurazione.xamppDir + "\xampp_start.exe");
            //Do not create command propmpt window 
            processInfo.CreateNoWindow = false;
            //Do not use shell execution
            processInfo.UseShellExecute = false;
            //Redirects error and output of the process (command prompt).
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            //start a new process
            var process = Process.Start(processInfo);
            //wait until process is running
            process.WaitForExit();
            //reads output and error of command prompt to string.
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();*/
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openXampp();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeXampp();
        }

        private void menuNuovo_Click(object sender, EventArgs e)
        {
            getDataFromForm();
        }

        private void menuApri_Click(object sender, EventArgs e)
        {
            openConf();
        }

        private void menuEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAvvia_Click(object sender, EventArgs e)
        {
            openXampp();
        }

        private void menuChiudi_Click(object sender, EventArgs e)
        {
            closeXampp();
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anas Araid Copyright 2018", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class Config
    {
        public string xamppDir { get; set; }
        public string projectDir { get; set; }
    }
}
