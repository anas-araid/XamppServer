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
            String configPath = "config.ini";
            if (checkPath(configPath, 0))
            {
                //object newConfig = INISerializer.INISerializer.deserializeObject(configPath);
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
                var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/config.ini";
                
                FileStream fileStream = File.Create(path);
                fileStream.Close();
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(serializeConf);

                    //tw.WriteLine("[config]");
                    //tw.WriteLine("xampp=" + configurazione.xamppDir);
                    //tw.WriteLine("project=" + configurazione.projectDir);
                }
                
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
            var xamppDir = INISerializer.INISerializer.IniReadValue("config", "xamppDir", path);
            var projectDir = INISerializer.INISerializer.IniReadValue("config", "projectDir", path);
            if (xamppDir == "" || projectDir == "")
            {
                MessageBox.Show("Errore: Configurazione incompleta.");
                return;
            }
            if (!checkPath(projectPath, 1) && !checkPath(xamppPath, 1))
            {
                MessageBox.Show("Errore configurazione: i percorsi non sono validi.");
                return;
            }
            this.xamppPath = xamppDir;
            this.projectPath = projectDir;
            configurazione.xamppDir = xamppDir;
            configurazione.projectDir = projectDir;
            edtXampp.Text = configurazione.xamppDir;
            edtProject.Text = configurazione.projectDir;
        }
        private void btnNuovo_Click(object sender, EventArgs e)
        {
            getDataFromForm();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "INI File (*.ini)|*ini";
            if (dlg.ShowDialog() != DialogResult.OK){
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

        public void startApache()
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + configurazione.xamppDir + "\xampp_start.exe");
            //Do not create command propmpt window 
            processInfo.CreateNoWindow = true;
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
            string error = process.StandardError.ReadToEnd();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
        }
    }
    public class Config
    {
        public string xamppDir { get; set; }
        public string projectDir { get; set; }
    }
}
