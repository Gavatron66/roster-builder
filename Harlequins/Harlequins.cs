﻿using Roster_Builder.Death_Guard;
using Roster_Builder.Space_Marines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roster_Builder.Harlequins
{
    public class Harlequins : Faction
    {
        public Harlequins()
        {
            subFactionName = "<Saedath>";
            currentSubFaction = string.Empty;
            factionUpgradeName = "Pivotal Roles";
            StratagemList.AddRange(new string[]
            {
                "Stratagem: Champion of the Aeldari",
                "Stratagem: Treasures of the Aeldari",
                "Stratagem: Favoured of the Laughing God"
            });
        }

        public override List<string> GetCustomSubfactionList1()
        {
            return new List<string>();
        }

        public override List<string> GetCustomSubfactionList2()
        {
            return new List<string>();
        }

        public override List<Datasheets> GetDatasheets()
        {
            return new List<Datasheets>()
            {
                //---------- HQ ----------
                //new TroupeMaster(),
                //new Shadowseer(),
                //---------- Troops ----------
                //new Troupe(),
                //---------- Elites ----------
                //new DeathJester(),
                //new Solitaire(),
                //---------- Fast Attack ----------
                //new Skyweavers(),
                //---------- Heavy Support ----------
                //new Voidweavers(),
                //---------- Transport ----------
                //new Starweaver(),
                //---------- Fortification ----------
                //new WebwayGate()
            };
        }

        public override int GetFactionUpgradePoints(string upgrade)
        {
            int points = 0;

            string[] thirty = new string[]
            {
                "Agent of Pandemonium (+30 pts)"
            };

            string[] twentyfive = new string[]
            {
                "Queen of Shards (+25 pts)",
                "Mirror Architect (+25 pts)"
            };

            string[] twenty = new string[]
            {
                "Prince of Light (+20 pts)",
                "Veiled King (+20 pts)",
                "Lord of Crytal Bones (+20 pts)",
                "Rift Ghoul (+20 pts)",
                "Prince of Sins (+20 pts)",
                "Thirsting Darkness (+20 pts)",
                "Gloom Spider (+20 pts)"
            };

            string[] fifteen = new string[]
            {
                "Harvester of Torment (+15 pts)",
                "Spectre of Despair (+15 pts)"
            };

            if (thirty.Contains(upgrade))
            {
                points += 30;
            }
            else if (twentyfive.Contains(upgrade))
            {
                points += 25;
            }
            else if (twenty.Contains(upgrade))
            {
                points += 20;
            }
            else if (fifteen.Contains(upgrade))
            {
                points += 15;
            }

            return points;
        }

        public override List<string> GetFactionUpgrades(List<string> keywords)
        {
            List<string> upgrades = new List<string>() { "(None)" };

            if(keywords.Contains("TROUPE MASTER"))
            {
                upgrades.AddRange(new string[]
                {
                    "Prince of Light (+20 pts)",
                    "Queen of Shards (+25 pts)",
                    "Veiled King (+20 pts)"
                });
            }

            if(keywords.Contains("DEATH JESTER"))
            {
                upgrades.AddRange(new string[]
                {
                    "Harvester of Torment (+15 pts)",
                    "Lord of Crystal Bones (+20 pts)",
                    "Rift Ghoul (+20 pts)"
                });
            }

            if(keywords.Contains("SOLITAIRE"))
            {
                upgrades.AddRange(new string[]
                {
                    "Prince of Sins (+20 pts)",
                    "Spectre of Despair (+15 pts)",
                    "Thirsting Darkness (+20 pts)"
                });
            }

            if(keywords.Contains("SHADOWSEER"))
            {
                upgrades.AddRange(new string[]
                {
                    "Agent of Pandemonium (+30 pts)",
                    "Gloom Sphere (+20 pts)",
                    "Mirror Architect (+25 pts)"
                });
            }

            return upgrades;
        }

        public override bool GetIfEnabled(int index)
        {
            return true;
        }

        public override List<string> GetPsykerPowers(string keywords)
        {
            return new List<string>()
            {
                "Twilight Pathways",
                "Fog of Dreams",
                "Mirror of Minds",
                "Veil of Tears",
                "Shards of Light",
                "Webway Dance"
            };
        }

        public override List<string> GetRelics(List<string> keywords)
        {
            List<string> relics = new List<string>() { "(None)" };

            relics.Add("The Storied Sword");
            relics.Add("The Suit of Hidden Knives");
            relics.Add("Crescendo");
            relics.Add("Cegorah's Rose");
            relics.Add("The Starmist Raiment");
            relics.Add("The Laughing God's Eye");

            return relics;
        }

        public override List<string> GetSubFactions()
        {
            return new List<string>
            {
                "Light",
                "Dark",
                "Twilight"
            };
        }

        public override List<string> GetWarlordTraits(string keyword)
        {
            return new List<string>()
            {
                "Favour of Cegorach",
                "Fractal Storm",
                "A Foot in the Future"
            };
        }

        public override void SetPoints(int points)
        {
        }

        public override string ToString()
        {
            return "Harlequins";
        }
    }
}
