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
        private void iniTrainPane() {
            txtTrainStartVal.Text = "0.4";
            txtTrainStartVal_Leave(null, null);
        }

        private void trainStartValTrack_ValueChanged(object sender, EventArgs e) {
            TrackBar send = ((TrackBar)sender);

            ((TextBox)send.Tag).Text = "" + TrainGetFloat(trainStartValTrack);

            if (trainMinValTrack.Value > trainStartValTrack.Value)
                trainMinValTrack.Value = trainStartValTrack.Value;
        }

        private void txtTrainStartVal_Leave(object sender, EventArgs e) {
            float val = TrainGetFloat(txtTrainStartVal.Text);

            txtTrainStartVal.Text = "" + val;
            trainStartValTrack.Value = (int)(val * (trainStartValTrack.Maximum - trainStartValTrack.Minimum));
        }

        private void txtTrainStartVal_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r')
                txtTrainStartVal_Leave(null, null);
        }

        private void trainMinValTrack_ValueChanged(object sender, EventArgs e) {
            txtTrainMinVal.Text = "" + TrainGetFloat(trainMinValTrack);

            if (trainMinValTrack.Value > trainStartValTrack.Value)
                trainStartValTrack.Value = trainMinValTrack.Value;
        }

        private void trainDecayValTrack_ValueChanged(object sender, EventArgs e) {
            txtTrainDecayVal.Text = "" + TrainGetFloat(trainDecayValTrack);
        }

        private float TrainGetFloat(TrackBar tb) {
            return (float)tb.Value / (tb.Maximum - tb.Minimum);
        }

        private float TrainGetFloat(string str) {
            float f = 0;

            float.TryParse(str, out f);

            float max = Math.Max(0, f);
            float min = Math.Min(1, max);
            return min;
        }
    }
}
