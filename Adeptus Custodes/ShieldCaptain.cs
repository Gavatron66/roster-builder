﻿using Roster_Builder.Adeptus_Custodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Builder.Adeptus_Custodes
{
    public class ShieldCaptain : Datasheets
    {
        AdeptusCustodes repo = new AdeptusCustodes();
        public ShieldCaptain()
        {
            DEFAULT_POINTS = 110;
            TemplateCode = "1m1k_c";
            Points = DEFAULT_POINTS;
            Weapons.Add("Guardian Spear");
            Weapons.Add("");
            Keywords.AddRange(new string[]
            {
                "IMPERIUM", "ADEPTUS CUSTODES", "<SHIELD HOST>",
                "INFANTRY", "CHARACTER", "GUARDIAN", "SHIELD-CAPTAIN"
            });
        }

        public override Datasheets CreateUnit()
        {
            return new ShieldCaptain();
        }

        public override void LoadDatasheets(Panel panel, Faction f)
        {
            Template.LoadTemplate(TemplateCode, panel);

            ComboBox cmbOption1 = panel.Controls["cmbOption1"] as ComboBox;
            CheckBox cbOption1 = panel.Controls["cbOption1"] as CheckBox;
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbWarlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;
            ComboBox cmbFactionupgrade = panel.Controls["cmbFactionupgrade"] as ComboBox;

            cmbOption1.Items.Clear();
            cmbOption1.Items.AddRange(new string[]
            {
                "Castellan Axe",
                "Guardian Spear",
                "Sentinel Blade and Praesidium Shield"
            });
            cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf(Weapons[0]);

            cbOption1.Text = "Misericordia";
            if (Weapons[1] == "Misericordia")
            {
                cbOption1.Checked = true;
            }
            else
            {
                cbOption1.Checked = false;
            }

            if (isWarlord)
            {
                cbWarlord.Checked = true;
                cmbWarlord.Enabled = true;
                cmbWarlord.SelectedText = WarlordTrait;
            }
            else
            {
                cbWarlord.Checked = false;
                cmbWarlord.Enabled = false;
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
            cmbFactionupgrade.Visible = true;
            cmbFactionupgrade.Items.Clear();
            cmbFactionupgrade.Items.AddRange(repo.GetFactionUpgrades(Keywords).ToArray());

            if (Factionupgrade != null)
            {
                cmbFactionupgrade.SelectedIndex = cmbFactionupgrade.Items.IndexOf(Factionupgrade);
            }
            else
            {
                cmbFactionupgrade.SelectedIndex = 0;
            }
        }

        public override void SaveDatasheets(int code, Panel panel)
        {
            ComboBox cmbOption1 = panel.Controls["cmbOption1"] as ComboBox;
            CheckBox cbOption1 = panel.Controls["cbOption1"] as CheckBox;
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbWarlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;
            ComboBox cmbFactionupgrade = panel.Controls["cmbFactionupgrade"] as ComboBox;

            switch (code)
            {
                case 11:
                    Weapons[0] = cmbOption1.SelectedItem.ToString();
                    if (Weapons[0] == "Sentinel Blade and Praesidium Shield")
                    {
                        cbOption1.Enabled = false;
                        cbOption1.Checked = false;
                    } else
                    {
                        cbOption1.Enabled = true;
                    }
                    break;
                case 15:
                    if (cmbWarlord.SelectedIndex != -1)
                    {
                        WarlordTrait = cmbWarlord.SelectedItem.ToString();
                    }
                    else
                    {
                        WarlordTrait = string.Empty;
                    }
                    break;
                case 16:
                    Factionupgrade = cmbFactionupgrade.Text;
                    break;
                case 17:
                    Relic = cmbRelic.SelectedItem.ToString();

                    if(cmbRelic.SelectedItem.ToString() == "Gatekeeper")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Guardian Spear");
                        cmbOption1.Enabled = false;
                    } else
                    {
                        cmbOption1.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Veiled Blade")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Sentinel Blade and Praesidium Shield");
                        cmbOption1.Enabled = false;
                    }
                    else
                    {
                        cmbOption1.Enabled = true;
                    }
                    break;
                case 21:
                    if (cbOption1.Checked)
                    {
                        Weapons[1] = cbOption1.Text;
                    }
                    else
                    {
                        Weapons[1] = "";
                    }
                    break;
                case 25:
                    if (cbWarlord.Checked)
                    {
                        this.isWarlord = true;
                    }
                    else { this.isWarlord = false; }
                    break;
            }

            Points = DEFAULT_POINTS;

            if (Weapons.Contains("Misericordia"))
            {
                Points += 5;
            }

            if (Weapons.Contains("Sentinel Blade and Praesidium Shield"))
            {
                Points += 10;
            }

            Points += repo.GetFactionUpgradePoints(Factionupgrade);
        }

        public override string ToString()
        {
            return "Shield-Captain - " + Points + "pts";
        }
    }
}