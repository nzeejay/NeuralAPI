using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualisationClient {
    public partial class Main : Form {
        public List<float> ErrorHistory = new List<float>();

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            iniTrainPane();
            ErrorIni();

        }

        private void ErrorIni() {
            trackErrorScale.Tag = new { track = trackErrorScale, label = lblErrorScale, YPos = tbErrorYPos };
            tbErrorYPos.Tag = new { track = tbErrorYPos };
            errorGraph.linkErrorList(ref ErrorHistory);
        }

        private int currentKey = -1;

        private void keyDown(object sender, KeyEventArgs e) {
            currentKey = e.KeyValue;
        }

        private void keyUp(object sender, KeyEventArgs e) {
            currentKey = -1;
        }
    }
}
