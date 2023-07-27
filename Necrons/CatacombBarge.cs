﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Builder.Necrons
{
    public class CatacombBarge : Datasheets
    {
        Necrons repo = new Necrons();
        public CatacombBarge()
        {
            DEFAULT_POINTS = 145;
            Points = DEFAULT_POINTS;
            TemplateCode = "2m1k_c";
            Weapons.Add("Gauss Cannon");
            Weapons.Add("Staff of Light");
            Weapons.Add("");
            Keywords.AddRange(new string[]
            {
                "NECRONS", "<DYNASTY>",
                "VEHICLE", "CHARACTER", "QUANTUM SHIELDING", "NOBLE", "OVERLORD", "FLY",
                "CATACOMB COMMAND BARGE"
            });
        }

        public override Datasheets CreateUnit()
        {
            return new CatacombBarge();
        }

        public override void LoadDatasheets(Panel panel, Faction f)
        {
            repo = f as Necrons;
            Template.LoadTemplate(TemplateCode, panel);

            ComboBox cmbOption1 = panel.Controls["cmbOption1"] as ComboBox;
            ComboBox cmbOption2 = panel.Controls["cmbOption2"] as ComboBox;
            CheckBox cbOption1 = panel.Controls["cbOption1"] as CheckBox;
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbWarlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;

            cmbOption1.Items.Clear();
            cmbOption1.Items.AddRange(new string[]
            {
                "Gauss Cannon",
                "Tesla Cannon"
            });
            cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf(Weapons[0]);

            cmbOption2.Items.Clear();
            cmbOption2.Items.AddRange(new string[]
            {
                "Hyperphase Sword",
                "Staff of Light",
                "Voidblade",
                "Warscythe"
            });
            cmbOption2.SelectedIndex = cmbOption2.Items.IndexOf(Weapons[1]);

            cbOption1.Text = "Resurrection Orb";
            if (Weapons[2] == "Resurrection Orb")
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
        }

        public override void SaveDatasheets(int code, Panel panel)
        {
            //Gauss Cannon +5
            //Resurrection Orb +30
            //Warscythe +5
            ComboBox cmbOption1 = panel.Controls["cmbOption1"] as ComboBox;
            ComboBox cmbOption2 = panel.Controls["cmbOption2"] as ComboBox;
            CheckBox cbOption1 = panel.Controls["cbOption1"] as CheckBox;
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbWarlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;

            switch (code)
            {
                case 11:
                    Weapons[0] = cmbOption1.SelectedItem.ToString();
                    break;
                case 12:
                    Weapons[1] = cmbOption2.SelectedItem.ToString();
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
                case 17:
                    Relic = cmbRelic.SelectedItem.ToString();

                    if (cmbRelic.SelectedItem.ToString() == "Blood Scythe")
                    {
                        cmbOption2.SelectedIndex = cmbOption2.Items.IndexOf("Warscythe");
                        cmbOption2.Enabled = false;
                    }
                    else
                    {
                        cmbOption2.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Solar Staff")
                    {
                        cmbOption2.SelectedIndex = cmbOption2.Items.IndexOf("Staff of Light");
                        cmbOption2.Enabled = false;
                    }
                    else
                    {
                        cmbOption2.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Orb of Eternity")
                    {
                        cbOption1.Checked = true;
                        cbOption1.Enabled = false;
                    }
                    else
                    {
                        cbOption1.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Voidreaper")
                    {
                        cmbOption2.SelectedIndex = cmbOption2.Items.IndexOf("Warscythe");
                        cmbOption2.Enabled = false;
                    }
                    else
                    {
                        cmbOption2.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Voltaic Staff")
                    {
                        cmbOption2.SelectedIndex = cmbOption2.Items.IndexOf("Staff of Light");
                        cmbOption2.Enabled = false;
                    }
                    else
                    {
                        cmbOption2.Enabled = true;
                    }
                    break;
                case 21:
                    if (cbOption1.Checked)
                    {
                        Weapons[2] = cbOption1.Text;
                    }
                    else
                    {
                        Weapons[2] = "";
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

            if (Weapons.Contains("Gauss Cannon"))
            {
                Points += 5;
            }

            if (Weapons.Contains("Warscythe"))
            {
                Points += 5;
            }

            if (Weapons.Contains("Resurrection Orb"))
            {
                Points += 30;
            }
        }

        public override string ToString()
        {
            return "Catacomb Command Barge - " + Points + "pts";
        }
    }
}