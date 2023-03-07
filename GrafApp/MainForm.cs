using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafApp
{
    public interface IMainForm 
    {

    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            string pathDefoult;
            pathDefoult = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            labelPathLoad.Text = pathDefoult;
            labelPathSave.Text = pathDefoult;
        }
    }
}
