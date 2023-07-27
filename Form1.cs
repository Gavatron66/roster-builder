﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roster_Builder.Death_Guard;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Roster_Builder.Necrons;
using Roster_Builder.Adeptus_Custodes;

namespace Roster_Builder
{
    public partial class Form1 : Form
    {
        List<Datasheets> roster = new List<Datasheets>();
        int currentIndex = -1;
        Faction units;
        bool isLoading = false;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1030, 590);

            #region Setting up the Form
            lbRoster.Visible = false;
            lbUnits.Visible = false;
            panel1.Size = new System.Drawing.Size(593, 463);
            panel1.Visible = false;
            lblEditingUnit.Text = string.Empty;
            lblPoints.Text = string.Empty;
            lblCurrentPoints.Visible = false;
            btnAddToRoster.Visible = false;
            btnRemove.Visible = false;
            btnSave.Visible = false;

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Visible = false;
            }

            for(int i = 0; i < gbUnitLeader.Controls.Count; i++)
            {
                gbUnitLeader.Controls[i].Visible = false;
            }

            cmbSelectFaction.Items.Clear();
            cmbSelectFaction.Items.AddRange(new Faction[]
            {
                new AdeptusCustodes(),
                new DeathGuard(),
                new Necrons.Necrons(),
            });

            #endregion
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {

            lbRoster.Visible = true;
            lbUnits.Visible = true;
            panel1.Visible = true;
            MenuPanel.Visible = false;
            btnRemove.Visible = true;
            btnAddToRoster.Visible = true;
            lblCurrentPoints.Visible = true;
            btnSave.Visible = true;
            btnSave.BringToFront();
            gbCustomSubfaction.Visible = false;

            if(!isLoading)
            {
                units = cmbSelectFaction.SelectedItem as Faction;
            }

            List<Datasheets> datasheets = units.GetDatasheets();

            lblSubfaction.Text = "Select a " + units.subFactionName + " :";
            subFactionupdate();
            List<string> powers = units.GetPsykerPowers();

            foreach (var power in powers)
            {
                clbPsyker.Items.Add(power);
            }

            panel1.Controls["lblFactionUpgrade"].Text = units.factionUpgradeName;

            List<string> subFactions = units.GetSubFactions();
            foreach (var subfaction in subFactions)
            {
                cmbSubFaction.Items.Add(subfaction);
            }

            foreach (Datasheets item in datasheets)
            {
                lbUnits.Items.Add(item);
            }

            if(!isLoading)
            {
                lbRoster.Items.Add(units.subFactionName);
                updateLBRoster();
            }

            if(!isLoading)
            {
                cmbCustomSub1.Items.Clear();
                cmbCustomSub2.Items.Clear();
            }

            if(cmbSubFaction.Items.Contains("<Custom>"))
            {
                List<string> customList1 = units.GetCustomSubfactionList1();
                List<string> customList2 = units.GetCustomSubfactionList2();

                foreach(var custom1 in customList1)
                {
                    cmbCustomSub1.Items.Add(custom1);
                }
                foreach (var custom2 in customList2)
                {
                    cmbCustomSub2.Items.Add(custom2);
                }
            }
        }

        private void btnAddToRoster_Click(object sender, EventArgs e)
        {
            if (lbUnits.SelectedIndex >= 0)
            {
                if(lbUnits.SelectedItem is Datasheets)
                {
                    Datasheets newUnit = lbUnits.SelectedItem as Datasheets;
                    roster.Add(newUnit.CreateUnit());
                }

                updateLBRoster();
            }
        }

        private void updateLBRoster()
        {
            object zeroItem = lbRoster.Items[0];
            lbRoster.Items.Clear();

            lbRoster.Items.Add(zeroItem);
            for (int i = 0; i < roster.Count; i++)
            {
                lbRoster.Items.Add(roster[i].ToString());
            }

            int pts = 0;

            for (int i = 0; i < roster.Count; i++)
            {
                pts += roster[i].Points;
            }

            lblPoints.Text = pts + " / " + txtSelectPoints.Text;
            if (currentIndex >= 0)
            {
                lblEditingUnit.Text = "Currently Editing: " + roster[currentIndex].ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentIndex < 0) return;
            roster.RemoveAt(currentIndex);
            currentIndex = -1;

            updateLBRoster();
            lblEditingUnit.Text = string.Empty;

            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
                control.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Visible = false;
            }

            lbRoster.SelectedIndex = -1;
        }

        private void nudUnitSize_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(30, panel1);
            updateLBRoster();
        }

        private void cmbOption1_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(11, panel1);
            updateLBRoster();
        }

        private void cmbOption2_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(12, panel1);
            updateLBRoster();
        }

        private void lbRoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
                control.Enabled = true;
            }

            foreach(Control control in gbUnitLeader.Controls)
            {
                control.Visible = false;
                control.Enabled = true;
            }

            if (lbRoster.SelectedIndex == 0)
            {
                panelSubFaction.Visible = true;
                lblEditingUnit.Text = string.Empty;
                currentIndex = -10;
                return;
            }

            if (lbRoster.SelectedIndex == -1 || lbRoster.SelectedIndex == currentIndex + 1)
            {
                if(currentIndex == -10) { panelSubFaction.Visible = true; return; }
                if(lbRoster.SelectedIndex == -1) { return; }
            }

            currentIndex = lbRoster.SelectedIndex-1;

            roster[currentIndex].LoadDatasheets(panel1, units);

            roster[currentIndex].SaveDatasheets(-1, panel1);

            if (currentIndex >= 0)
            {
                lblEditingUnit.Text = "Currently Editing: " + roster[currentIndex].ToString();
            }
        }

        private void cbOption1_CheckedChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(21, panel1);
            updateLBRoster();
        }

        private void cbOption2_CheckedChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(22, panel1);
            updateLBRoster();
        }

        private void cbWarlord_CheckedChanged(object sender, EventArgs e)
        {
            if(cbWarlord.Checked)
            {
                cmbWarlord.Enabled = true;
                roster[currentIndex].SaveDatasheets(25, panel1);
            }
            else
            {
                cmbWarlord.Enabled = false;
                cmbWarlord.Text = string.Empty;
                roster[currentIndex].SaveDatasheets(25, panel1);
            }
            
        }

        private void cmbWarlord_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(15, panel1);
        }

        private void cmbFactionupgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFactionupgrade.SelectedIndex != -1)
            {
                roster[currentIndex].SaveDatasheets(16, panel1);
            }
            updateLBRoster() ;
        }

        private void clbPsyker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(clbPsyker.SelectedIndex != -1)
            {
                roster[currentIndex].SaveDatasheets(60, panel1);
            }
        }

        private void cmbSubFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            units.currentSubFaction = cmbSubFaction.SelectedItem.ToString();
            lbRoster.Items.RemoveAt(0);
            lbRoster.Items.Insert(0, units.subFactionName + ": " + units.currentSubFaction);
            subFactionupdate();
        }

        private void subFactionupdate()
        {
            cmbWarlord.Items.Clear();
            List<string> traits = units.GetWarlordTraits();
            foreach (var trait in traits)
            {
                cmbWarlord.Items.Add(trait);
            }

            if (cmbSubFaction.SelectedItem as string == "<Custom>")
            {
                gbCustomSubfaction.Visible = true;
            } else
            {
                gbCustomSubfaction.Visible = false;
            }

        }
        private void cmbOption3_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(13, panel1);
            updateLBRoster();
        }

        private void cmbOption4_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(14, panel1);
            updateLBRoster();
        }

        private void cbLeaderOption1_CheckedChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(421, panel1);
            updateLBRoster();
        }

        private void cbLeaderOption2_CheckedChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(422, panel1);
            updateLBRoster();
        }

        private void clbPsyker_DoubleClick(object sender, EventArgs e)
        {
            if (clbPsyker.SelectedIndex != -1)
            {
                roster[currentIndex].SaveDatasheets(60, panel1);
            }
        }

        private void gb_cmbOption1_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(411, panel1);
            updateLBRoster();
        }

        private void nudOption1_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(31, panel1);
            updateLBRoster();
        }
        private void nudOption2_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(32, panel1);
            updateLBRoster();
        }
        private void nudOption3_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(33, panel1);
            updateLBRoster();
        }
        private void nudOption4_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(34, panel1);
            updateLBRoster();
        }

        private void gb_cmbFactionupgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(416, panel1);
            updateLBRoster();
        }

        private void lbModelSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(61, panel1);
            updateLBRoster();
        }

        private void cbOption3_CheckedChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(23, panel1);
            updateLBRoster();
        }

        private void cmbRelic_SelectedIndexChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(17, panel1);
            updateLBRoster();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "json";
            sfd.ShowDialog();

            if(cmbSubFaction.SelectedItem.ToString() == "<Custom>")
            {
                roster[0].Keywords.Add(cmbCustomSub1.SelectedItem.ToString());
                roster[0].Keywords.Add(cmbCustomSub2.SelectedItem.ToString());
                roster[0].Keywords.Add(cmbSubFaction.SelectedItem.ToString());
            } else
            {
                roster[0].Keywords.Add(cmbSubFaction.SelectedItem.ToString());
            }

            string savePath = sfd.FileName;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize<List<Datasheets>>(roster, options);
            File.WriteAllText(savePath, json);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            string path = ofd.FileName;
            string json = File.ReadAllText(path);

            var newRoster = JsonSerializer.Deserialize<List<Datasheets>>(json);

            foreach ( Faction faction in cmbSelectFaction.Items)
            {
                List<Datasheets> datasheets = faction.GetDatasheets();
                Type[] types = new Type[datasheets.Count];
                
                for(int i = 0; i < datasheets.Count; i++)
                {
                    types[i] = datasheets[i].GetType();
                }

                if (types.Contains(newRoster[0].GetType()))
                {
                    isLoading = true;
                    units = faction;
                }
            }

            btnBegin.PerformClick();

            roster = newRoster;

            lbRoster.Items.Insert(0, units.subFactionName);

            if (newRoster[0].Keywords.Last() == "<Custom>")
            {
                cmbSubFaction.SelectedIndex = cmbSubFaction.Items.IndexOf(roster[0].Keywords.Last());
                cmbCustomSub2.SelectedIndex = cmbCustomSub2.Items.IndexOf(roster[0].Keywords[roster[0].Keywords.Count - 2]);
                cmbCustomSub1.SelectedIndex = cmbCustomSub1.Items.IndexOf(roster[0].Keywords[roster[0].Keywords.Count - 3]);

                roster[0].Keywords.RemoveRange(roster[0].Keywords.Count - 3, 3);
            } else
            {
                cmbSubFaction.SelectedIndex = cmbSubFaction.Items.IndexOf(roster[0].Keywords.Last());

                roster[0].Keywords.RemoveAt(roster[0].Keywords.Count - 1);
            }

            updateLBRoster();
        }

        private void nudOption5_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(35, panel1);
            updateLBRoster();
        }

        private void nudOption6_ValueChanged(object sender, EventArgs e)
        {
            roster[currentIndex].SaveDatasheets(36, panel1);
            updateLBRoster();
        }
    }
}