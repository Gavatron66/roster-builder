﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Builder.Death_Guard
{
    public class BiologusPutrifier : Datasheets
    {
        DeathGuard repo = new DeathGuard();
        public BiologusPutrifier()
        {
            DEFAULT_POINTS = 65;
            UnitSize = 1;
            TemplateCode = "c";
            Points = DEFAULT_POINTS;
            Keywords.AddRange(new string[]
            {
                "CHAOS", "NURGLE", "HERETIC ASTARTES", "DEATH GUARD", "<PLAGUE COMPANY>",
                "INFANTRY", "CHARACTER", "BUBONIC ASTARTES", "FOETID VIRION", "BIOLOGUS PUTRIFIER"
            });
        }
        public override void LoadDatasheets(Panel panel, Faction f)
        {
            repo = f as DeathGuard;
            Template.LoadTemplate(TemplateCode, panel);

            ComboBox cmb = panel.Controls["cmbWarlord"] as ComboBox;
            CheckBox cb = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbFaction = panel.Controls["cmbFactionupgrade"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;

            if (isWarlord)
            {
                cb.Checked = true;
                cmb.Enabled = true;
                cmb.SelectedText = WarlordTrait;
            }
            else
            {
                cb.Checked = false;
                cmb.Enabled = false;
            }

            cmbFaction.Items.Clear();
            cmbFaction.Items.AddRange(repo.GetFactionUpgrades(Keywords).ToArray());

            if (Factionupgrade != null)
            {
                cmbFaction.SelectedIndex = cmbFaction.Items.IndexOf(Factionupgrade);
            }
            else
            {
                cmbFaction.SelectedIndex = 0;
            }

            cmbRelic.Items.Clear();
            cmbRelic.Items.AddRange(repo.GetRelics(Keywords).ToArray());

            if (Relic != null)
            {
                cmbRelic.SelectedIndex = cmbRelic.Items.IndexOf(Relic);
            }
            else
            {
                cmbRelic.SelectedIndex = -1;
            }

            panel.Controls["lblFactionupgrade"].Visible = true;
            panel.Controls["cmbFactionupgrade"].Visible = true;
        }

        public override void SaveDatasheets(int code, Panel panel)
        {
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox warlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox factionud = panel.Controls["cmbFactionupgrade"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;

            switch (code)
            {
                case 25:
                    if (cbWarlord.Checked)
                    {
                        isWarlord = true;
                    }
                    else { isWarlord = false; }
                    break;
                case 15:
                    if (warlord.SelectedIndex != -1)
                    {
                        WarlordTrait = warlord.SelectedItem.ToString();
                    }
                    else
                    {
                        WarlordTrait = string.Empty;
                    }

                    break;
                case 16:
                    Factionupgrade = factionud.Text;
                    break;
                case 17:
                    Relic = cmbRelic.SelectedItem.ToString();
                    break;
            }

            Points = DEFAULT_POINTS;

            Points += repo.GetFactionUpgradePoints(Factionupgrade);
        }


        public override string ToString()
        {
            return "Biologus Putrifier - " + Points + "pts";
        }

        public override Datasheets CreateUnit()
        {
            return new BiologusPutrifier();
        }
    }
}