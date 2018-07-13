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
            txtTrainMinVal.Tag = new { text = txtTrainMinVal, track = trainMinValTrack };
            txtTrainStartVal.Tag = new { text = txtTrainStartVal, track = trainStartValTrack };
            trainMinValTrack.Tag = new { text = txtTrainMinVal, track = trainMinValTrack };
            trainStartValTrack.Tag = new { text = txtTrainStartVal, track = trainStartValTrack };
            trainDecayValTrack.Tag = new { text = txtTrainDecayVal, track = trainDecayValTrack };
            txtTrainDecayVal.Tag = new { text = txtTrainDecayVal, track = trainDecayValTrack };


            trainTextChange(txtTrainStartVal, null);
            trainTextChange(txtTrainMinVal, null);
            trainTextChange(txtTrainDecayVal, null);
        }

        private void trainBindTrackbars(object sender) {
            dynamic tag = ((TrackBar)sender).Tag;

            if (trainMinValTrack.Value > trainStartValTrack.Value 
                && tag.track == trainMinValTrack)
                trainStartValTrack.Value = trainMinValTrack.Value;

            if (trainMinValTrack.Value > trainStartValTrack.Value 
                && tag.track == trainStartValTrack)
                trainMinValTrack.Value = trainStartValTrack.Value;
        }

        private void trainTrackbar_ValueChanged(object sender, EventArgs e) {
            dynamic tag = ((TrackBar)sender).Tag;

            tag.text.Text = "" + TrainGetFloat(tag.track);

            trainBindTrackbars(sender);
        }

        private void trainText_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r')
                trainTextChange(sender, null);
        }

        private void trainTextChange(object sender, EventArgs e) {
            dynamic tag = ((TextBox)sender).Tag;

            var val = TrainGetFloat(tag.text.Text);

            tag.text.Text = "" + val;

            tag.track.Value = (int)(val * tag.track.Maximum);

            trainBindTrackbars(tag.track);
        }

        private float TrainGetFloat(TrackBar tb) {
            return (float)tb.Value / (tb.Maximum - tb.Minimum);
        }

        private float TrainGetFloat(string str) {
            float.TryParse(str, out float f);

            float max = Math.Max(0, f);
            float min = Math.Min(1, max);
            return min;
        }
    }
}
