﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Builder.Death_Guard
{
    public class Template
    {
        public Template() { }

        public void LoadTemplate(string code, Panel panel)
        {
            GroupBox groupbox = new GroupBox();

            switch (code)
            {
                #region case "1m2k_pc"
                case "1m2k_pc":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311,25);

                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 60);

                    panel.Controls["cbOption2"].Visible = true;
                    panel.Controls["cbOption2"].Location = new System.Drawing.Point(311, 91);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(298, 130);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(294, 157);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(296, 180);

                    panel.Controls["lblPsyker"].Visible = true;
                    panel.Controls["lblPsyker"].Location = new System.Drawing.Point(86, 126);

                    panel.Controls["clbPsyker"].Visible = true;
                    panel.Controls["clbPsyker"].Location = new System.Drawing.Point(85, 149);

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(290, 266);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(294, 289);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(294, 211);

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(294, 235);
                    break;
                #endregion
                #region case "2m_c"
                case "2m_c":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["lblOption2"].Visible = true;
                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption2"].Visible = true;
                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(311, 59);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(100, 105);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(96, 132);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(98, 155);

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(293, 160);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(297, 184);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(293, 106);

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(297, 129);
                    break;
                #endregion
                #region case "c"
                case "c":
                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(92, 25);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(88, 52);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(90, 75);  

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(294, 28); //298, 82

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(298, 51); //298, 106

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(298, 82);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(298, 106);


                    break;
                #endregion
                #region case "1m_c"
                case "1m_c":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(92, 64);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(88, 91);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(90, 114);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(294, 67); //294, 67

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(298, 90); //298,90

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(298, 121);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(298, 145);
                    break;
                #endregion
                #region case "2m_pc"
                case "2m_pc":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["lblOption2"].Visible = true;
                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption2"].Visible = true;
                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(311, 59);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(298, 111);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(294, 138);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(294, 161);

                    panel.Controls["lblPsyker"].Visible = true;
                    panel.Controls["lblPsyker"].Location = new System.Drawing.Point(86, 107);

                    panel.Controls["clbPsyker"].Visible = true;
                    panel.Controls["clbPsyker"].Location = new System.Drawing.Point(85, 130);

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(290, 247);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(294, 270);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(294, 192);

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(294, 216);
                    break;
                #endregion
                #region case "1k_pc"
                case "1k_pc":
                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(90, 25);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(298, 56);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(294, 83);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(294, 106);

                    panel.Controls["lblPsyker"].Visible = true;
                    panel.Controls["lblPsyker"].Location = new System.Drawing.Point(86, 52);

                    panel.Controls["clbPsyker"].Visible = true;
                    panel.Controls["clbPsyker"].Location = new System.Drawing.Point(85, 75);

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(290, 192);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(294, 215);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(294, 137);

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(294, 161);
                    break;
                #endregion
                #region case "ncp"
                case "ncp":
                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(298, 33);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(294, 60);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(294, 83);

                    panel.Controls["lblPsyker"].Visible = true;
                    panel.Controls["lblPsyker"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["clbPsyker"].Visible = true;
                    panel.Controls["clbPsyker"].Location = new System.Drawing.Point(85, 52);
                    break;
                #endregion
                #region case "nc"
                case "nc":
                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(281, 29);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(279, 55);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(281, 78);
                    break;
                #endregion
                #region case "1m1k_c"
                case "1m1k_c":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 60);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(87, 87);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(83, 114);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(85, 137);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(293, 91); //294, 67

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(293, 113); //298,90

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(293, 145);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(293, 168);
                    break;
                #endregion
                #region case "2m1k_c"
                case "2m1k_c":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["lblOption2"].Visible = true;
                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption2"].Visible = true;
                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(311, 59);

                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 93);

                    panel.Controls["cbWarlord"].Visible = true;
                    panel.Controls["cbWarlord"].Location = new System.Drawing.Point(87, 116);

                    panel.Controls["lblWarlord"].Visible = true;
                    panel.Controls["lblWarlord"].Location = new System.Drawing.Point(83, 143);

                    panel.Controls["cmbWarlord"].Visible = true;
                    panel.Controls["cmbWarlord"].Location = new System.Drawing.Point(85, 166);

                    panel.Controls["lblRelic"].Visible = true;
                    panel.Controls["lblRelic"].Location = new System.Drawing.Point(293, 120); //294, 67

                    panel.Controls["cmbRelic"].Visible = true;
                    panel.Controls["cmbRelic"].Location = new System.Drawing.Point(293, 142); //298,90

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(293, 174);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(293, 197);

                    break;
                #endregion

                #region case "1m"
                case "1m":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);
                    break;
                #endregion
                #region case "2m"
                case "2m":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["lblOption2"].Visible = true;
                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption2"].Visible = true;
                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(311, 59);

                    break;
                #endregion
                #region case "1m1k"
                case "1m1k":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 60);

                    break;
                #endregion
                #region case "2m1k"
                case "2m1k":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["lblOption2"].Visible = true;
                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption2"].Visible = true;
                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(311, 59);

                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 93);

                    break;
                #endregion
                #region case "3m"
                case "3m":
                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 25);

                    panel.Controls["lblOption2"].Visible = true;
                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption2"].Visible = true;
                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(311, 59);

                    panel.Controls["lblOption3"].Visible = true;
                    panel.Controls["lblOption3"].Location = new System.Drawing.Point(86, 97);

                    panel.Controls["cmbOption3"].Visible = true;
                    panel.Controls["cmbOption3"].Location = new System.Drawing.Point(311, 93);

                    break;
                #endregion
                #region case "2k"
                case "2k":
                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 60);

                    panel.Controls["cbOption2"].Visible = true;
                    panel.Controls["cbOption2"].Location = new System.Drawing.Point(311, 90);

                    break;
                #endregion
                #region case "1k"
                case "1k":
                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(311, 60);

                    break;
                #endregion

                #region case "N"
                case "N":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);
                    break;
                #endregion
                #region case "NS(2k)"
                case "NS(2k)":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["gbUnitLeader"].Visible = true;
                    panel.Controls["gbUnitLeader"].Location = new System.Drawing.Point(90, 59);
                    panel.Controls["gbUnitLeader"].Size = new System.Drawing.Size(359, 108);

                    groupbox = panel.Controls["gbUnitLeader"] as GroupBox;

                    groupbox.Controls["cbLeaderOption1"].Visible = true;
                    groupbox.Controls["cbLeaderOption1"].Location = new System.Drawing.Point(25, 37);

                    groupbox.Controls["cbLeaderOption2"].Visible = true;
                    groupbox.Controls["cbLeaderOption2"].Location = new System.Drawing.Point(25, 63);

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(86, 170);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(90, 193);
                    break;
                #endregion
                #region case "3N"
                case "3N":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lblnud1"].Visible = true;
                    panel.Controls["lblnud1"].Location = new System.Drawing.Point(126, 61);

                    panel.Controls["nudOption1"].Visible = true;
                    panel.Controls["nudOption1"].Location = new System.Drawing.Point(283, 59);

                    panel.Controls["lblnud2"].Visible = true;
                    panel.Controls["lblnud2"].Location = new System.Drawing.Point(126, 93);

                    panel.Controls["nudOption2"].Visible = true;
                    panel.Controls["nudOption2"].Location = new System.Drawing.Point(283, 91);
                    break;
                #endregion
                #region case "N1m"
                case "N1m":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lblOption1"].Visible = true;
                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(86, 63);

                    panel.Controls["cmbOption1"].Visible = true;
                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(311, 59);
                    break;
                #endregion
                #region case "4N"
                case "4N":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lblnud1"].Visible = true;
                    panel.Controls["lblnud1"].Location = new System.Drawing.Point(126, 61);

                    panel.Controls["nudOption1"].Visible = true;
                    panel.Controls["nudOption1"].Location = new System.Drawing.Point(283, 59);

                    panel.Controls["lblnud2"].Visible = true;
                    panel.Controls["lblnud2"].Location = new System.Drawing.Point(126, 93);

                    panel.Controls["nudOption2"].Visible = true;
                    panel.Controls["nudOption2"].Location = new System.Drawing.Point(283, 91);

                    panel.Controls["lblnud3"].Visible = true;
                    panel.Controls["lblnud3"].Location = new System.Drawing.Point(126, 125);

                    panel.Controls["nudOption3"].Visible = true;
                    panel.Controls["nudOption3"].Location = new System.Drawing.Point(283, 123);
                    break;
                #endregion
                #region case "5N"
                case "5N":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lblnud1"].Visible = true;
                    panel.Controls["lblnud1"].Location = new System.Drawing.Point(126, 61);

                    panel.Controls["nudOption1"].Visible = true;
                    panel.Controls["nudOption1"].Location = new System.Drawing.Point(283, 59);

                    panel.Controls["lblnud2"].Visible = true;
                    panel.Controls["lblnud2"].Location = new System.Drawing.Point(126, 93);

                    panel.Controls["nudOption2"].Visible = true;
                    panel.Controls["nudOption2"].Location = new System.Drawing.Point(283, 91);

                    panel.Controls["lblnud3"].Visible = true;
                    panel.Controls["lblnud3"].Location = new System.Drawing.Point(126, 125);

                    panel.Controls["nudOption3"].Visible = true;
                    panel.Controls["nudOption3"].Location = new System.Drawing.Point(283, 123);

                    panel.Controls["lblnud4"].Visible = true;
                    panel.Controls["lblnud4"].Location = new System.Drawing.Point(126, 157);

                    panel.Controls["nudOption4"].Visible = true;
                    panel.Controls["nudOption4"].Location = new System.Drawing.Point(283, 155);
                    break;
                #endregion
                #region case "N1kS(1m)"
                case "N1kS(1m)":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["cbOption1"].Visible = true;
                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(90, 66);

                    panel.Controls["gbUnitLeader"].Visible = true;
                    panel.Controls["gbUnitLeader"].Location = new System.Drawing.Point(90, 96);
                    panel.Controls["gbUnitLeader"].Size = new System.Drawing.Size(426, 77);

                    groupbox = panel.Controls["gbUnitLeader"] as GroupBox;


                    groupbox.Controls["gb_lblOption1"].Visible = true;
                    groupbox.Controls["gb_lblOption1"].Location = new System.Drawing.Point(6, 34);

                    groupbox.Controls["gb_cmbOption1"].Visible = true;
                    groupbox.Controls["gb_cmbOption1"].Location = new System.Drawing.Point(231, 31);

                    panel.Controls["lblFactionupgrade"].Location = new System.Drawing.Point(86, 170);

                    panel.Controls["cmbFactionupgrade"].Location = new System.Drawing.Point(90, 193);
                    break;
                #endregion

                #region case "NL2m1k"
                case "NL2m1k":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lbModelSelect"].Visible = true;
                    panel.Controls["lbModelSelect"].Location = new System.Drawing.Point(39, 77);
                    panel.Controls["lbModelSelect"].Size = new System.Drawing.Size(194, 344);

                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(239, 127);

                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(282, 150);

                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(239, 184);

                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(282, 207);

                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(243, 241);

                    panel.Controls["lblFactionUpgrade"].Location = new System.Drawing.Point(239, 268);

                    panel.Controls["cmbFactionUpgrade"].Location = new System.Drawing.Point(243, 291);
                    break;
                #endregion
                #region case "NL2m3k"
                case "NL2m3k":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lbModelSelect"].Visible = true;
                    panel.Controls["lbModelSelect"].Location = new System.Drawing.Point(39, 97);
                    panel.Controls["lbModelSelect"].Size = new System.Drawing.Size(194, 344);

                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(239, 97);

                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(282, 120);

                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(239, 151);

                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(282, 174);

                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(243, 153);

                    panel.Controls["cbOption2"].Location = new System.Drawing.Point(243, 183);

                    panel.Controls["cbOption3"].Location = new System.Drawing.Point(243, 208);

                    panel.Controls["lblFactionUpgrade"].Location = new System.Drawing.Point(239, 235);

                    panel.Controls["cmbFactionUpgrade"].Location = new System.Drawing.Point(243, 258);
                    break;
                #endregion
                #region case "NL3k"
                case "NL3k":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lbModelSelect"].Visible = true;
                    panel.Controls["lbModelSelect"].Location = new System.Drawing.Point(39, 97);
                    panel.Controls["lbModelSelect"].Size = new System.Drawing.Size(194, 344);

                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(243, 126);

                    panel.Controls["cbOption2"].Location = new System.Drawing.Point(243, 156);

                    panel.Controls["cbOption3"].Location = new System.Drawing.Point(243, 186);

                    panel.Controls["lblFactionUpgrade"].Location = new System.Drawing.Point(239, 213);

                    panel.Controls["cmbFactionUpgrade"].Location = new System.Drawing.Point(243, 236);
                    break;
                #endregion
                #region case "NL2m"
                case "NL2m":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lbModelSelect"].Visible = true;
                    panel.Controls["lbModelSelect"].Location = new System.Drawing.Point(39, 77);
                    panel.Controls["lbModelSelect"].Size = new System.Drawing.Size(194, 344);

                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(239, 127);

                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(282, 150);

                    panel.Controls["lblOption2"].Location = new System.Drawing.Point(239, 184);

                    panel.Controls["cmbOption2"].Location = new System.Drawing.Point(282, 207);

                    panel.Controls["lblFactionUpgrade"].Location = new System.Drawing.Point(239, 268);

                    panel.Controls["cmbFactionUpgrade"].Location = new System.Drawing.Point(243, 291);
                    break;
                #endregion
                #region case "NL1m1k"
                case "NL1m1k":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lbModelSelect"].Visible = true;
                    panel.Controls["lbModelSelect"].Location = new System.Drawing.Point(39, 77);
                    panel.Controls["lbModelSelect"].Size = new System.Drawing.Size(194, 344);

                    panel.Controls["lblOption1"].Location = new System.Drawing.Point(239, 127);

                    panel.Controls["cmbOption1"].Location = new System.Drawing.Point(282, 150);

                    panel.Controls["cbOption1"].Location = new System.Drawing.Point(243, 184);

                    panel.Controls["lblFactionUpgrade"].Location = new System.Drawing.Point(239, 268);

                    panel.Controls["cmbFactionUpgrade"].Location = new System.Drawing.Point(243, 291);
                    break;
                #endregion

                #region case "cultist"
                case "cultist":
                    panel.Controls["lblNumModels"].Visible = true;
                    panel.Controls["lblNumModels"].Location = new System.Drawing.Point(86, 29);

                    panel.Controls["nudUnitSize"].Visible = true;
                    panel.Controls["nudUnitSize"].Location = new System.Drawing.Point(243, 27);

                    panel.Controls["lblnud1"].Visible = true;
                    panel.Controls["lblnud1"].Location = new System.Drawing.Point(126, 61);

                    panel.Controls["nudOption1"].Visible = true;
                    panel.Controls["nudOption1"].Location = new System.Drawing.Point(283, 59);

                    panel.Controls["lblnud2"].Visible = true;
                    panel.Controls["lblnud2"].Location = new System.Drawing.Point(126, 93);

                    panel.Controls["nudOption2"].Visible = true;
                    panel.Controls["nudOption2"].Location = new System.Drawing.Point(283, 91);

                    panel.Controls["lblExtra1"].Visible = true;
                    panel.Controls["lblExtra1"].Location = new System.Drawing.Point(86, 130);

                    panel.Controls["lblnud3"].Visible = true;
                    panel.Controls["lblnud3"].Location = new System.Drawing.Point(126, 162);

                    panel.Controls["nudOption3"].Visible = true;
                    panel.Controls["nudOption3"].Location = new System.Drawing.Point(283, 162);

                    panel.Controls["lblnud4"].Visible = true;
                    panel.Controls["lblnud4"].Location = new System.Drawing.Point(126, 194);

                    panel.Controls["nudOption4"].Visible = true;
                    panel.Controls["nudOption4"].Location = new System.Drawing.Point(283, 194);

                    panel.Controls["gbUnitLeader"].Visible = true;
                    panel.Controls["gbUnitLeader"].Location = new System.Drawing.Point(90, 231);
                    panel.Controls["gbUnitLeader"].Size = new System.Drawing.Size(359, 153);

                    groupbox = panel.Controls["gbUnitLeader"] as GroupBox;

                    groupbox.Controls["gb_lblOption1"].Visible = true;
                    groupbox.Controls["gb_lblOption1"].Location = new System.Drawing.Point(6, 30);

                    groupbox.Controls["gb_cmbOption1"].Visible = true;
                    groupbox.Controls["gb_cmbOption1"].Location = new System.Drawing.Point(20, 53);

                    groupbox.Controls["gb_lblFactionupgrade"].Location = new System.Drawing.Point(16, 87);

                    groupbox.Controls["gb_cmbFactionupgrade"].Location = new System.Drawing.Point(20, 110);
                    break;
                    #endregion

            }
        }
    }
}