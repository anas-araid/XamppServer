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

namespace XamppServer
{
    public partial class frmServer : Form
    {
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
                object configurazione = INISerializer.INISerializer.deserializeObject(configPath);
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
            if (!checkPath(projectPath, 0) && !checkPath(xamppPath, 1))
            {
                MessageBox.Show("Errore: Configurazione o xampp non trovato.");
                return;
            }
            
        }
        private void btnNuovo_Click(object sender, EventArgs e)
        {
            getDataFromForm();
        }
    }
    public class Config
    {
        public string xamppDir { get; set; }
        public string projectDir { get; set; }
    }
}
