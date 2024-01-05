﻿using Roster_Builder.Death_Guard;
using Roster_Builder.Space_Marines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Builder.Aeldari
{
    public class WarlockSkyrunners : Datasheets
    {
        decimal witchblades;
        decimal singingSpears;

        public WarlockSkyrunners()
        {
            DEFAULT_POINTS = 40;
            UnitSize = 1;
            Points = DEFAULT_POINTS * UnitSize + 20;
            TemplateCode = "3N_p";
            Keywords.AddRange(new string[]
            {
                "AELDARI", "ASURYANI", "<CRAFTWORLD>",
                "BIKER", "FLY", "PSYKER", "WARLOCKS", "WARLOCK SKYRUNNERS"
            });
            PsykerPowers = new string[1] { string.Empty };
            Role = "Elites";

            witchblades = 1;
            singingSpears = 0;
        }

        public override Datasheets CreateUnit()
        {
            return new WarlockSkyrunners();
        }

        public override void LoadDatasheets(Panel panel, Faction f)
        {
            repo = f as Aeldari;
            Template.LoadTemplate(TemplateCode, panel);

            Label lblPsyker = panel.Controls["lblPsyker"] as Label;
            CheckedListBox clbPsyker = panel.Controls["clbPsyker"] as CheckedListBox;
            NumericUpDown nudUnitSize = panel.Controls["nudUnitSize"] as NumericUpDown;
            NumericUpDown nudOption1 = panel.Controls["nudOption1"] as NumericUpDown;
            NumericUpDown nudOption2 = panel.Controls["nudOption2"] as NumericUpDown;

            Label lblnud1 = panel.Controls["lblnud1"] as Label;
            Label lblnud2 = panel.Controls["lblnud2"] as Label;

            lblnud1.Text = "Singing Spears (+5 pts):";
            lblnud1.Location = new System.Drawing.Point(lblnud1.Location.X - 20, lblnud1.Location.Y);
            lblnud2.Text = "Witchblades:";
            lblnud2.Location = new System.Drawing.Point(lblnud2.Location.X + 45, lblnud2.Location.Y);

            int currentSize = UnitSize;
            nudUnitSize.Minimum = 1;
            nudUnitSize.Value = nudUnitSize.Minimum;
            nudUnitSize.Maximum = 3;
            nudUnitSize.Value = currentSize;

            nudOption1.Minimum = 0;
            nudOption1.Value = 0;
            nudOption1.Maximum = 3;
            nudOption1.Value = singingSpears;

            nudOption2.Minimum = 0;
            nudOption2.Value = 0;
            nudOption2.Maximum = 3;
            nudOption2.Value = witchblades;

            List<string> psykerpowers = new List<string>();
            psykerpowers = repo.GetPsykerPowers("Battle");
            clbPsyker.Items.Clear();
            foreach (string power in psykerpowers)
            {
                clbPsyker.Items.Add(power);
            }

            if (UnitSize < 3)
            {
                lblPsyker.Text = "Select one of the following:";
                clbPsyker.ClearSelected();
                for (int i = 0; i < clbPsyker.Items.Count; i++)
                {
                    clbPsyker.SetItemChecked(i, false);
                }

                if (PsykerPowers[0] != string.Empty)
                {
                    clbPsyker.SetItemChecked(clbPsyker.Items.IndexOf(PsykerPowers[0]), true);
                }
            }
            else
            {
                lblPsyker.Text = "Select two of the following:";
                clbPsyker.ClearSelected();
                for (int i = 0; i < clbPsyker.Items.Count; i++)
                {
                    clbPsyker.SetItemChecked(i, false);
                }

                if (PsykerPowers[0] != string.Empty)
                {
                    clbPsyker.SetItemChecked(clbPsyker.Items.IndexOf(PsykerPowers[0]), true);
                    clbPsyker.SetItemChecked(clbPsyker.Items.IndexOf(PsykerPowers[1]), true);
                }
            }
        }

        public override void SaveDatasheets(int code, Panel panel)
        {
            Label lblPsyker = panel.Controls["lblPsyker"] as Label;
            CheckedListBox clbPsyker = panel.Controls["clbPsyker"] as CheckedListBox;
            NumericUpDown nudUnitSize = panel.Controls["nudUnitSize"] as NumericUpDown;
            NumericUpDown nudOption1 = panel.Controls["nudOption1"] as NumericUpDown;
            NumericUpDown nudOption2 = panel.Controls["nudOption2"] as NumericUpDown;

            switch (code)
            {
                case 30:
                    int oldSize = UnitSize;
                    UnitSize = int.Parse(nudUnitSize.Value.ToString());

                    if (UnitSize > oldSize)
                    {
                        nudOption2.Value += UnitSize - oldSize;
                    }

                    if (UnitSize < oldSize)
                    {
                        if (nudOption2.Value >= oldSize - UnitSize)
                        {
                            nudOption2.Value -= oldSize - UnitSize;
                        }
                        else
                        {
                            nudOption1.Value -= oldSize - UnitSize;
                        }
                    }

                    if (UnitSize >= 3)
                    {
                        lblPsyker.Text = "Select two of the following:";
                        string[] temp = new string[2] { PsykerPowers[0], string.Empty };
                        PsykerPowers = temp;
                    }
                    else if (UnitSize < 3 && PsykerPowers.Length == 2)
                    {
                        lblPsyker.Text = "Select one of the following:";
                        if (PsykerPowers[1] != string.Empty)
                        {
                            clbPsyker.SetItemChecked(clbPsyker.Items.IndexOf(PsykerPowers[1]), false);
                        }
                        string[] temp = new string[1] { PsykerPowers[0] };
                        PsykerPowers = temp;
                    }
                    break;
                case 31:
                    if (nudOption1.Value == 0)
                    {
                        break;
                    }
                    else if (nudOption1.Value + nudOption2.Value <= nudUnitSize.Value)
                    {
                        singingSpears = nudOption1.Value;
                    }
                    else
                    {
                        nudOption1.Value -= 1;
                    }
                    break;
                case 32:
                    if (nudOption2.Value == 0)
                    {
                        break;
                    }
                    else if (nudOption1.Value + nudOption2.Value <= nudUnitSize.Value)
                    {
                        witchblades = nudOption2.Value;
                    }
                    else
                    {
                        nudOption2.Value -= 1;
                    }
                    break;
                case 60:
                    if (UnitSize >= 3)
                    {
                        if (clbPsyker.CheckedItems.Count < 2)
                        {
                            break;
                        }
                        else if (clbPsyker.CheckedItems.Count == 2)
                        {
                            PsykerPowers[0] = clbPsyker.CheckedItems[0] as string;
                            PsykerPowers[1] = clbPsyker.CheckedItems[1] as string;
                        }
                        else
                        {
                            clbPsyker.SetItemChecked(clbPsyker.SelectedIndex, false);
                        }
                    }
                    else
                    {
                        if (clbPsyker.CheckedItems.Count < 1)
                        {
                            break;
                        }
                        else if (clbPsyker.CheckedItems.Count == 1)
                        {
                            PsykerPowers[0] = clbPsyker.CheckedItems[0] as string;
                        }
                        else
                        {
                            clbPsyker.SetItemChecked(clbPsyker.SelectedIndex, false);
                        }
                    }
                    break;
                default: break;
            }

            Points = DEFAULT_POINTS * UnitSize;
            if (UnitSize == 1)
            {
                Points = 65;
            }

            Points += repo.GetFactionUpgradePoints(Factionupgrade);

            Points += Convert.ToInt32(singingSpears * 5);
        }

        public override string ToString()
        {
            return "Warlock Skyrunners - " + Points + "pts";
        }
    }
}