using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class Main_Board : Form
    {
        public Main_Board()
        {
            InitializeComponent();
        }

        private void Main_Board_Load(object sender, EventArgs e)
        {
            string path = @"\\H0526SFS03\Home$\Students\3858387797\Documents\BattleShips";
            string Statpath = @"Stats.txt";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else if (!File.Exists(path + Statpath))
            {
                File.Create(path + Statpath);
            }


        }
    }
}
