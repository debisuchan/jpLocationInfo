using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpLocationInfo
{
    public partial class ChiikiInfo : Form
    {
        public Boolean l_hokkaido = false; //北海道
        public Boolean l_tohoku = false; //東北
        public Boolean l_kanto = false; //関東
        public Boolean l_chubu = false; //中部
        public Boolean l_kinki = false; //近畿
        public Boolean l_chugoku = false; //中国
        public Boolean l_shikoku = false; //四国
        public Boolean l_kyuoki = false; //九州沖縄

        public Boolean debugging = false; //デバック有無

        public ChiikiInfo()
        {
            InitializeComponent();
            debugLog.Visible = false;
            debugReset.Visible = false;
        }

        private void debug_Click(object sender, EventArgs e)
        {
            if (debugging == true)
            {
                ChiikiInfo.ActiveForm.ClientSize = new Size(1264, 681);
                debugLog.Visible = false;
                debugReset.Visible = false;
                debugging = false;
                //debugLog.Items.Add("デバックが無効");
            }
            else
            {
                ChiikiInfo.ActiveForm.ClientSize = new Size(1634, 681);
                debugLog.Visible = true;
                debugReset.Visible = true;
                debugging = true;
                //debugLog.Items.Add("デバックが有効");
            }
        }

        private void Hokkaido_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Hokkaido_Click");
            //l_hokkaido = true;
            //l_tohoku = false;
            //l_kanto = false;
            //l_chubu = false;
            //l_kinki = false;
            //l_chugoku = false;
            //l_shikoku = false;
            //l_kyuoki = false;
        }

        private void Tohoku_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Tohoku_Click");
        }

        private void Kanto_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Kanto_Click");
        }

        private void Chubu_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Chubu_Click");
        }

        private void Kinki_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Kinki_Click");
        }

        private void Chugoku_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Chugoku_Click");
        }

        private void Shikoku_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Shikoku_Click");
        }

        private void Kyuoki_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: Kyuoki_Click");
        }

        private void searchMode_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: searchMode_Click");
        }

        private void back_Click(object sender, EventArgs e)
        {
            debugLog.Items.Add("BUTTON CLICK EVENT: back_Click");
        }

        private void debugReset_Click(object sender, EventArgs e)
        {
            debugLog.Items.Clear();
        }
        public void resetSelection()
        {
            debugLog.Items.Add("EVENT: resetSelection - 選択された情報がリセットされました。");
            locationOfSelection.Text = "選択された位置はこっちらに表示されます。";
        }
    }
}
