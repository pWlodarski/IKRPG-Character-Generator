using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;

namespace IKRPG_Character_Generator {
    public partial class mForm : Form {
// All commented out lines of code will be removed in next update
//        private readonly string humanText = "Humans are by far the predominant race living in the Iron Kingdoms, and perhaps across Caen itself, as they have been observed on several continents. Mankind has been prevalent in western Immoren for as long as legends have been told, with civizations stretching back six thousand years and untold millennia before that as nomadic tribes. Humans are an adaptable and hardy race capable of broad range of careers and thriving in every geography, from the frozen northern mountants to the arid desert wastes. Humans have been at the forefront of invention and pioneering many of the technologies that the nations of the region rely upon, including alchemy and mechanika.\r\n\r\nThe fine Iron Kingdoms were the inheritors of the Thousand Cities Era, a time when countless pretty fiefdoms emerged across the region. This has given rise to a proliferation of human ethnicities and cultures, each proud of its history. Many of the peoples of western Immoren have distinct physical traits and can be recognized on sight.\r\n\r\nHumans come in a wide range of appearances, with great variance in skin pigmentation, height, hair and eye color, and body build. Most Immorese humans have pale or olive skin, but there are those who are exceptionally pale and others with very dark skin. Hair colors are usually shades of brown, but include black, red, lond, and many shades between. Humans identify with one another more by shared languages and nationality than by superficial physical distenctions.";
//        private readonly string[,] humanStats = new string[9, 4] {
//                                                {"5","7","8","8"}, // PHY
//                                                {"6","7","7","7"}, // SPD
//                                                {"4","6","7","8"}, // STR
//                                                {"3","5","6","7"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"4","5","6","7"}, // POI
//                                                {"3","5","6","7"}, // INT
//                                                {"*","4","6","8"}, // ARC
//                                                {"3","5","6","7"}  // PER
//                                            };
//        private readonly string dwarfText = "";
//        private readonly string[,] dwarfStats = new string[9, 4] {
//                                                {"6","7","7","8"}, // PHY
//                                                {"4","5","6","6"}, // SPD
//                                                {"5","6","7","8"}, // STR
//                                                {"3","5","6","7"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"3","4","5","6"}, // POI
//                                                {"4","5","6","7"}, // INT
//                                                {"*","4","6","7"}, // ARC
//                                                {"3","4","6","7"}  // PER
//                                            };
//        private readonly string gobberText = "";
//        private readonly string[,] gobberStats = new string[9, 4] {
//                                                {"4","6","7","7"}, // PHY
//                                                {"6","7","7","7"}, // SPD
//                                                {"3","4","5","6"}, // STR
//                                                {"4","5","6","7"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"3","5","6","7"}, // POI
//                                                {"3","4","5","6"}, // INT
//                                                {"-","-","-","-"}, // ARC
//                                                {"3","4","4","5"}  // PER
//                                            };
//        private readonly string iosanText = "";
//        private readonly string[,] iosanStats = new string[9, 4] {
//                                                {"5","7","7","7"}, // PHY
//                                                {"6","7","7","7"}, // SPD
//                                                {"4","5","6","7"}, // STR
//                                                {"3","5","6","7"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"4","5","6","7"}, // POI
//                                                {"4","6","6","7"}, // INT
//                                                {"*","4","6","8"}, // ARC
//                                                {"3","5","6","7"}  // PER
//                                            };
//        private readonly string nyssText = "";
//        private readonly string[,] nyssStats = new string[9, 4] {
//                                                {"5","7","7","8"}, // PHY
//                                                {"6","7","7","7"}, // SPD
//                                                {"4","6","7","8"}, // STR
//                                                {"4","5","6","7"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"4","5","6","7"}, // POI
//                                                {"3","5","6","6"}, // INT
//                                                {"*","4","6","7"}, // ARC
//                                                {"3","5","6","6"}  // PER
//                                            };
//        private readonly string ogrunText = "";
//        private readonly string[,] ogrunStats = new string[9, 4] {
//                                                {"6","7","8","9"}, // PHY
//                                                {"5","6","6","6"}, // SPD
//                                                {"6","8","9","10"}, // STR
//                                                {"3","5","5","6"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"3","4","5","6"}, // POI
//                                                {"3","5","5","6"}, // INT
//                                                {"-","-","-","-"}, // ARC
//                                                {"2","4","5","6"}  // PER
//                                            };
//        private readonly string trollkinText = "";
//        private readonly string[,] trollkinStats = new string[9, 4] {
//                                                {"6","8","9","10"}, // PHY
//                                                {"5","6","6","6"}, // SPD
//                                                {"5","7","8","9"}, // STR
//                                                {"3","5","6","7"}, // AGL
//                                                {"4","5","6","7"}, // PRW
//                                                {"2","4","5","6"}, // POI
//                                                {"3","4","5","6"}, // INT
//                                                {"*","4","6","7"}, // ARC
//                                                {"3","4","5","6"}  // PER
//                                            };
//        private race human = new race("Humans are by far the predominant race living in the Iron Kingdoms, and perhaps across Caen itself, as they have been observed on several continents. Mankind has been prevalent in western Immoren for as long as legends have been told, with civizations stretching back six thousand years and untold millennia before that as nomadic tribes. Humans are an adaptable and hardy race capable of broad range of careers and thriving in every geography, from the frozen northern mountants to the arid desert wastes. Humans have been at the forefront of invention and pioneering many of the technologies that the nations of the region rely upon, including alchemy and mechanika.\r\n\r\nThe fine Iron Kingdoms were the inheritors of the Thousand Cities Era, a time when countless pretty fiefdoms emerged across the region. This has given rise to a proliferation of human ethnicities and cultures, each proud of its history. Many of the peoples of western Immoren have distinct physical traits and can be recognized on sight.\r\n\r\nHumans come in a wide range of appearances, with great variance in skin pigmentation, height, hair and eye color, and body build. Most Immorese humans have pale or olive skin, but there are those who are exceptionally pale and others with very dark skin. Hair colors are usually shades of brown, but include black, red, lond, and many shades between. Humans identify with one another more by shared languages and nationality than by superficial physical distenctions.",
//            new string[9, 4] {{"5","7","8","8"},   // PHY
//                              {"6","7","7","7"},   // SPD
//                              {"4","6","7","8"},   // STR
//                              {"3","5","6","7"},   // AGL
//                              {"4","5","6","7"},   // PRW
//                              {"4","5","6","7"},   // POI
//                              {"3","5","6","7"},   // INT
//                              {"*","4","6","8"},   // ARC
//                              {"3","5","6","7"}}); // PER
//        private race dwarf = new race("",
//            new string[9, 4] {{"6","7","7","8"},   // PHY
//                              {"4","5","6","6"},   // SPD
//                              {"5","6","7","8"},   // STR
//                              {"3","5","6","7"},   // AGL
//                              {"4","5","6","7"},   // PRW
//                              {"3","4","5","6"},   // POI
//                              {"4","5","6","7"},   // INT
//                              {"*","4","6","7"},   // ARC
//                              {"3","4","6","7"}}); // PER
//        private race gobber = new race("",
//            new string[9, 4] {{"4","6","7","7"}, // PHY
//                              {"6","7","7","7"}, // SPD
//                              {"3","4","5","6"}, // STR
//                              {"4","5","6","7"}, // AGL
//                              {"4","5","6","7"}, // PRW
//                              {"3","5","6","7"}, // POI
//                              {"3","4","5","6"}, // INT
//                              {"-","-","-","-"}, // ARC
//                              {"3","4","4","5"}}); // PER
//        private race iosan = new race("",
//            new string[9, 4] {{"5","7","7","7"}, // PHY
//                              {"6","7","7","7"}, // SPD
//                              {"4","5","6","7"}, // STR
//                              {"3","5","6","7"}, // AGL
//                              {"4","5","6","7"}, // PRW
//                              {"4","5","6","7"}, // POI
//                              {"4","6","6","7"}, // INT
//                              {"*","4","6","8"}, // ARC
//                              {"3","5","6","7"}}); // PER
//        private race nyss = new race("",
//            new string[9, 4] {{"5","7","7","8"}, // PHY
//                              {"6","7","7","7"}, // SPD
//                              {"4","6","7","8"}, // STR
//                              {"4","5","6","7"}, // AGL
//                              {"4","5","6","7"}, // PRW
//                              {"4","5","6","7"}, // POI
//                              {"3","5","6","6"}, // INT
//                              {"*","4","6","7"}, // ARC
//                              {"3","5","6","6"}}); // PER
//        private race ogrun = new race("",
//            new string[9, 4] {{"6","7","8","9"}, // PHY
//                              {"5","6","6","6"}, // SPD
//                              {"6","8","9","10"}, // STR
//                              {"3","5","5","6"}, // AGL
//                              {"4","5","6","7"}, // PRW
//                              {"3","4","5","6"}, // POI
//                              {"3","5","5","6"}, // INT
//                              {"-","-","-","-"}, // ARC
//                              {"2","4","5","6"}}); // PER
//        private race trollkin = new race("",
//            new string[9, 4] {{"6","8","9","10"}, // PHY
//                              {"5","6","6","6"}, // SPD
//                              {"5","7","8","9"}, // STR
//                              {"3","5","6","7"}, // AGL
//                              {"4","5","6","7"}, // PRW
//                              {"2","4","5","6"}, // POI
//                              {"3","4","5","6"}, // INT
//                              {"*","4","6","7"}, // ARC
//                              {"3","4","5","6"}}); // PER
        private List<race> rList = new List<race>();
        private int selectedRaceIndex = (int)race.Race.HUMAN;
        private int selectedArchetypeIndex = (int)archetype.Archetypes.GIFTED;

        public mForm() {
            InitializeComponent();
            Initialize_rList();
            raceSelection.SelectedItem = "Human";
            UpdateRaceTab();
            archetypeSelection.Text = "Gifted";
            previousArchetype = "Gifted";
        }

        /// <summary>
        /// populates the race list with the races and their stats
        /// </summary>
        private void Initialize_rList(){
            // Human
            rList.Add(new race("Humans are by far the predominant race living in the Iron Kingdoms, and perhaps across Caen itself, as they have been observed on several continents. Mankind has been prevalent in western Immoren for as long as legends have been told, with civizations stretching back six thousand years and untold millennia before that as nomadic tribes. Humans are an adaptable and hardy race capable of broad range of careers and thriving in every geography, from the frozen northern mountants to the arid desert wastes. Humans have been at the forefront of invention and pioneering many of the technologies that the nations of the region rely upon, including alchemy and mechanika.\r\n\r\nThe fine Iron Kingdoms were the inheritors of the Thousand Cities Era, a time when countless pretty fiefdoms emerged across the region. This has given rise to a proliferation of human ethnicities and cultures, each proud of its history. Many of the peoples of western Immoren have distinct physical traits and can be recognized on sight.\r\n\r\nHumans come in a wide range of appearances, with great variance in skin pigmentation, height, hair and eye color, and body build. Most Immorese humans have pale or olive skin, but there are those who are exceptionally pale and others with very dark skin. Hair colors are usually shades of brown, but include black, red, lond, and many shades between. Humans identify with one another more by shared languages and nationality than by superficial physical distenctions.",
                      new string[,] {{"5","7","8","8"},  // PHY
                                     {"6","7","7","7"},  // SPD
                                     {"4","6","7","8"},  // STR
                                     {"3","5","6","7"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"4","5","6","7"},  // POI
                                     {"3","5","6","7"},  // INT
                                     {"*","4","6","8"},  // ARC
                                     {"3","5","6","7"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.GIFTED,
                                                  archetype.Archetypes.INTELLECTUAL,
                                                  archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
            // Dwarf
            rList.Add(new race("",
                      new string[,] {{"6","7","7","8"},  // PHY
                                     {"4","5","6","6"},  // SPD
                                     {"5","6","7","8"},  // STR
                                     {"3","5","6","7"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"3","4","5","6"},  // POI
                                     {"4","5","6","7"},  // INT
                                     {"*","4","6","7"},  // ARC
                                     {"3","4","6","7"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.GIFTED,
                                                  archetype.Archetypes.INTELLECTUAL,
                                                  archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
            // Gobber
            rList.Add(new race("",
                      new string[,] {{"4","6","7","7"},  // PHY
                                     {"6","7","7","7"},  // SPD
                                     {"3","4","5","6"},  // STR
                                     {"4","5","6","7"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"3","5","6","7"},  // POI
                                     {"3","4","5","6"},  // INT
                                     {"-","-","-","-"},  // ARC
                                     {"3","4","4","5"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.INTELLECTUAL,
                                                  archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
            // Iosan
            rList.Add(new race("",
                      new string[,] {{"5","7","7","7"},  // PHY
                                     {"6","7","7","7"},  // SPD
                                     {"4","5","6","7"},  // STR
                                     {"3","5","6","7"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"4","5","6","7"},  // POI
                                     {"4","6","6","7"},  // INT
                                     {"*","4","6","8"},  // ARC
                                     {"3","5","6","7"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.GIFTED,
                                                  archetype.Archetypes.INTELLECTUAL,
                                                  archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
            // Nyss
            rList.Add(new race("",
                      new string[,] {{"5","7","7","8"},  // PHY
                                     {"6","7","7","7"},  // SPD
                                     {"4","6","7","8"},  // STR
                                     {"4","5","6","7"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"4","5","6","7"},  // POI
                                     {"3","5","6","6"},  // INT
                                     {"*","4","6","7"},  // ARC
                                     {"3","5","6","6"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.GIFTED,
                                                  archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
            // Ogrun
            rList.Add(new race("",
                      new string[,] {{"6","7","8","9"},  // PHY
                                     {"5","6","6","6"},  // SPD
                                     {"6","8","9","10"}, // STR
                                     {"3","5","5","6"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"3","4","5","6"},  // POI
                                     {"3","5","5","6"},  // INT
                                     {"-","-","-","-"},  // ARC
                                     {"2","4","5","6"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
            // Trollkin
            rList.Add(new race("",
                      new string[,] {{"6","8","9","10"}, // PHY
                                     {"5","6","6","6"},  // SPD
                                     {"5","7","8","9"},  // STR
                                     {"3","5","6","7"},  // AGL
                                     {"4","5","6","7"},  // PRW
                                     {"2","4","5","6"},  // POI
                                     {"3","4","5","6"},  // INT
                                     {"*","4","6","7"},  // ARC
                                     {"3","4","5","6"}}, // PER
                      new archetype.Archetypes[] {archetype.Archetypes.GIFTED,
                                                  archetype.Archetypes.MIGHTY,
                                                  archetype.Archetypes.SKILLED}));
        }

        private void raceSelectionChanged(object sender, EventArgs e) {
            this.selectedRaceIndex = raceSelection.SelectedIndex;
            UpdateRaceTab();
        }
        private string previousArchetype;
        private void archSelectionChanged(object sender, EventArgs e) {
            this.selectedArchetypeIndex = archetypeSelection.SelectedIndex;
            if ( rList[selectedRaceIndex].isValidArchetype((archetype.Archetypes)selectedArchetypeIndex) ) {
                previousArchetype = archetypeSelection.Text;
                if ( selectedArchetypeIndex.Equals((int)archetype.Archetypes.GIFTED) ) {
                    giftedSelected();
                } else if ( selectedArchetypeIndex.Equals((int)archetype.Archetypes.INTELLECTUAL) ) {
                    intellectualSelected();
                } else if ( selectedArchetypeIndex.Equals((int)archetype.Archetypes.MIGHTY) ) {
                    mightySelected();
                } else if ( selectedArchetypeIndex.Equals((int)archetype.Archetypes.SKILLED) ) {
                    skilledSelected();
                }
            } else {
                MessageBox.Show("The archetype is not valid for the race");
                archetypeSelection.Text = previousArchetype;
            }
        }

/*        private void humanSelected() {
            this.startingPHY.Text = this.humanStats[0, 0];
            this.startingSPD.Text = this.humanStats[1, 0];
            this.startingSTR.Text = this.humanStats[2, 0];
            this.startingAGL.Text = this.humanStats[3, 0];
            this.startingPRW.Text = this.humanStats[4, 0];
            this.startingPOI.Text = this.humanStats[5, 0];
            this.startingINT.Text = this.humanStats[6, 0];
            this.startingARC.Text = this.humanStats[7, 0];
            this.startingPER.Text = this.humanStats[8, 0];

            this.heroPHY.Text = this.humanStats[0, 1];
            this.heroSPD.Text = this.humanStats[1, 1];
            this.heroSTR.Text = this.humanStats[2, 1];
            this.heroAGL.Text = this.humanStats[3, 1];
            this.heroPRW.Text = this.humanStats[4, 1];
            this.heroPOI.Text = this.humanStats[5, 1];
            this.heroINT.Text = this.humanStats[6, 1];
            this.heroARC.Text = this.humanStats[7, 1];
            this.heroPER.Text = this.humanStats[8, 1];

            this.vetPHY.Text = this.humanStats[0, 2];
            this.vetSPD.Text = this.humanStats[1, 2];
            this.vetSTR.Text = this.humanStats[2, 2];
            this.vetAGL.Text = this.humanStats[3, 2];
            this.vetPOI.Text = this.humanStats[4, 2];
            this.vetPRW.Text = this.humanStats[5, 2];
            this.vetINT.Text = this.humanStats[6, 2];
            this.vetARC.Text = this.humanStats[7, 2];
            this.vetPER.Text = this.humanStats[8, 2];

            this.epicPHY.Text = this.humanStats[0, 3];
            this.epicSPD.Text = this.humanStats[1, 3];
            this.epicSTR.Text = this.humanStats[2, 3];
            this.epicAGL.Text = this.humanStats[3, 3];
            this.epicPOI.Text = this.humanStats[4, 3];
            this.epicPRW.Text = this.humanStats[5, 3];
            this.epicINT.Text = this.humanStats[6, 3];
            this.epicARC.Text = this.humanStats[7, 3];
            this.epicPER.Text = this.humanStats[8, 3];

            this.racialText.Text = this.humanText;
            this.startingPHY.Text = this.human.Stats[0, 0];
            this.startingSPD.Text = this.human.Stats[1, 0];
            this.startingSTR.Text = this.human.Stats[2, 0];
            this.startingAGL.Text = this.human.Stats[3, 0];
            this.startingPRW.Text = this.human.Stats[4, 0];
            this.startingPOI.Text = this.human.Stats[5, 0];
            this.startingINT.Text = this.human.Stats[6, 0];
            this.startingARC.Text = this.human.Stats[7, 0];
            this.startingPER.Text = this.human.Stats[8, 0];

            this.heroPHY.Text = this.human.Stats[0, 1];
            this.heroSPD.Text = this.human.Stats[1, 1];
            this.heroSTR.Text = this.human.Stats[2, 1];
            this.heroAGL.Text = this.human.Stats[3, 1];
            this.heroPRW.Text = this.human.Stats[4, 1];
            this.heroPOI.Text = this.human.Stats[5, 1];
            this.heroINT.Text = this.human.Stats[6, 1];
            this.heroARC.Text = this.human.Stats[7, 1];
            this.heroPER.Text = this.human.Stats[8, 1];

            this.vetPHY.Text = this.human.Stats[0, 2];
            this.vetSPD.Text = this.human.Stats[1, 2];
            this.vetSTR.Text = this.human.Stats[2, 2];
            this.vetAGL.Text = this.human.Stats[3, 2];
            this.vetPOI.Text = this.human.Stats[4, 2];
            this.vetPRW.Text = this.human.Stats[5, 2];
            this.vetINT.Text = this.human.Stats[6, 2];
            this.vetARC.Text = this.human.Stats[7, 2];
            this.vetPER.Text = this.human.Stats[8, 2];

            this.epicPHY.Text = this.human.Stats[0, 3];
            this.epicSPD.Text = this.human.Stats[1, 3];
            this.epicSTR.Text = this.human.Stats[2, 3];
            this.epicAGL.Text = this.human.Stats[3, 3];
            this.epicPOI.Text = this.human.Stats[4, 3];
            this.epicPRW.Text = this.human.Stats[5, 3];
            this.epicINT.Text = this.human.Stats[6, 3];
            this.epicARC.Text = this.human.Stats[7, 3];
            this.epicPER.Text = this.human.Stats[8, 3];

            this.racialText.Text = this.human.Text;
        }

        private void dwarfSelected() {
            this.startingPHY.Text = this.dwarfStats[0, 0];
            this.startingSPD.Text = this.dwarfStats[1, 0];
            this.startingSTR.Text = this.dwarfStats[2, 0];
            this.startingAGL.Text = this.dwarfStats[3, 0];
            this.startingPRW.Text = this.dwarfStats[4, 0];
            this.startingPOI.Text = this.dwarfStats[5, 0];
            this.startingINT.Text = this.dwarfStats[6, 0];
            this.startingARC.Text = this.dwarfStats[7, 0];
            this.startingPER.Text = this.dwarfStats[8, 0];

            this.heroPHY.Text = this.dwarfStats[0, 1];
            this.heroSPD.Text = this.dwarfStats[1, 1];
            this.heroSTR.Text = this.dwarfStats[2, 1];
            this.heroAGL.Text = this.dwarfStats[3, 1];
            this.heroPRW.Text = this.dwarfStats[4, 1];
            this.heroPOI.Text = this.dwarfStats[5, 1];
            this.heroINT.Text = this.dwarfStats[6, 1];
            this.heroARC.Text = this.dwarfStats[7, 1];
            this.heroPER.Text = this.dwarfStats[8, 1];

            this.vetPHY.Text = this.dwarfStats[0, 2];
            this.vetSPD.Text = this.dwarfStats[1, 2];
            this.vetSTR.Text = this.dwarfStats[2, 2];
            this.vetAGL.Text = this.dwarfStats[3, 2];
            this.vetPOI.Text = this.dwarfStats[4, 2];
            this.vetPRW.Text = this.dwarfStats[5, 2];
            this.vetINT.Text = this.dwarfStats[6, 2];
            this.vetARC.Text = this.dwarfStats[7, 2];
            this.vetPER.Text = this.dwarfStats[8, 2];

            this.epicPHY.Text = this.dwarfStats[0, 3];
            this.epicSPD.Text = this.dwarfStats[1, 3];
            this.epicSTR.Text = this.dwarfStats[2, 3];
            this.epicAGL.Text = this.dwarfStats[3, 3];
            this.epicPOI.Text = this.dwarfStats[4, 3];
            this.epicPRW.Text = this.dwarfStats[5, 3];
            this.epicINT.Text = this.dwarfStats[6, 3];
            this.epicARC.Text = this.dwarfStats[7, 3];
            this.epicPER.Text = this.dwarfStats[8, 3];

            this.racialText.Text = this.dwarfText;
            this.startingPHY.Text = this.dwarf.Stats[0, 0];
            this.startingSPD.Text = this.dwarf.Stats[1, 0];
            this.startingSTR.Text = this.dwarf.Stats[2, 0];
            this.startingAGL.Text = this.dwarf.Stats[3, 0];
            this.startingPRW.Text = this.dwarf.Stats[4, 0];
            this.startingPOI.Text = this.dwarf.Stats[5, 0];
            this.startingINT.Text = this.dwarf.Stats[6, 0];
            this.startingARC.Text = this.dwarf.Stats[7, 0];
            this.startingPER.Text = this.dwarf.Stats[8, 0];

            this.heroPHY.Text = this.dwarf.Stats[0, 1];
            this.heroSPD.Text = this.dwarf.Stats[1, 1];
            this.heroSTR.Text = this.dwarf.Stats[2, 1];
            this.heroAGL.Text = this.dwarf.Stats[3, 1];
            this.heroPRW.Text = this.dwarf.Stats[4, 1];
            this.heroPOI.Text = this.dwarf.Stats[5, 1];
            this.heroINT.Text = this.dwarf.Stats[6, 1];
            this.heroARC.Text = this.dwarf.Stats[7, 1];
            this.heroPER.Text = this.dwarf.Stats[8, 1];

            this.vetPHY.Text = this.dwarf.Stats[0, 2];
            this.vetSPD.Text = this.dwarf.Stats[1, 2];
            this.vetSTR.Text = this.dwarf.Stats[2, 2];
            this.vetAGL.Text = this.dwarf.Stats[3, 2];
            this.vetPOI.Text = this.dwarf.Stats[4, 2];
            this.vetPRW.Text = this.dwarf.Stats[5, 2];
            this.vetINT.Text = this.dwarf.Stats[6, 2];
            this.vetARC.Text = this.dwarf.Stats[7, 2];
            this.vetPER.Text = this.dwarf.Stats[8, 2];

            this.epicPHY.Text = this.dwarf.Stats[0, 3];
            this.epicSPD.Text = this.dwarf.Stats[1, 3];
            this.epicSTR.Text = this.dwarf.Stats[2, 3];
            this.epicAGL.Text = this.dwarf.Stats[3, 3];
            this.epicPOI.Text = this.dwarf.Stats[4, 3];
            this.epicPRW.Text = this.dwarf.Stats[5, 3];
            this.epicINT.Text = this.dwarf.Stats[6, 3];
            this.epicARC.Text = this.dwarf.Stats[7, 3];
            this.epicPER.Text = this.dwarf.Stats[8, 3];

            this.racialText.Text = this.dwarf.Text;
        }

        private void gobberSelected() {
            this.startingPHY.Text = this.gobberStats[0, 0];
            this.startingSPD.Text = this.gobberStats[1, 0];
            this.startingSTR.Text = this.gobberStats[2, 0];
            this.startingAGL.Text = this.gobberStats[3, 0];
            this.startingPRW.Text = this.gobberStats[4, 0];
            this.startingPOI.Text = this.gobberStats[5, 0];
            this.startingINT.Text = this.gobberStats[6, 0];
            this.startingARC.Text = this.gobberStats[7, 0];
            this.startingPER.Text = this.gobberStats[8, 0];

            this.heroPHY.Text = this.gobberStats[0, 1];
            this.heroSPD.Text = this.gobberStats[1, 1];
            this.heroSTR.Text = this.gobberStats[2, 1];
            this.heroAGL.Text = this.gobberStats[3, 1];
            this.heroPRW.Text = this.gobberStats[4, 1];
            this.heroPOI.Text = this.gobberStats[5, 1];
            this.heroINT.Text = this.gobberStats[6, 1];
            this.heroARC.Text = this.gobberStats[7, 1];
            this.heroPER.Text = this.gobberStats[8, 1];

            this.vetPHY.Text = this.gobberStats[0, 2];
            this.vetSPD.Text = this.gobberStats[1, 2];
            this.vetSTR.Text = this.gobberStats[2, 2];
            this.vetAGL.Text = this.gobberStats[3, 2];
            this.vetPOI.Text = this.gobberStats[4, 2];
            this.vetPRW.Text = this.gobberStats[5, 2];
            this.vetINT.Text = this.gobberStats[6, 2];
            this.vetARC.Text = this.gobberStats[7, 2];
            this.vetPER.Text = this.gobberStats[8, 2];

            this.epicPHY.Text = this.gobberStats[0, 3];
            this.epicSPD.Text = this.gobberStats[1, 3];
            this.epicSTR.Text = this.gobberStats[2, 3];
            this.epicAGL.Text = this.gobberStats[3, 3];
            this.epicPOI.Text = this.gobberStats[4, 3];
            this.epicPRW.Text = this.gobberStats[5, 3];
            this.epicINT.Text = this.gobberStats[6, 3];
            this.epicARC.Text = this.gobberStats[7, 3];
            this.epicPER.Text = this.gobberStats[8, 3];

            this.racialText.Text = this.gobberText;
            this.startingPHY.Text = this.gobber.Stats[0, 0];
            this.startingSPD.Text = this.gobber.Stats[1, 0];
            this.startingSTR.Text = this.gobber.Stats[2, 0];
            this.startingAGL.Text = this.gobber.Stats[3, 0];
            this.startingPRW.Text = this.gobber.Stats[4, 0];
            this.startingPOI.Text = this.gobber.Stats[5, 0];
            this.startingINT.Text = this.gobber.Stats[6, 0];
            this.startingARC.Text = this.gobber.Stats[7, 0];
            this.startingPER.Text = this.gobber.Stats[8, 0];

            this.heroPHY.Text = this.gobber.Stats[0, 1];
            this.heroSPD.Text = this.gobber.Stats[1, 1];
            this.heroSTR.Text = this.gobber.Stats[2, 1];
            this.heroAGL.Text = this.gobber.Stats[3, 1];
            this.heroPRW.Text = this.gobber.Stats[4, 1];
            this.heroPOI.Text = this.gobber.Stats[5, 1];
            this.heroINT.Text = this.gobber.Stats[6, 1];
            this.heroARC.Text = this.gobber.Stats[7, 1];
            this.heroPER.Text = this.gobber.Stats[8, 1];

            this.vetPHY.Text = this.gobber.Stats[0, 2];
            this.vetSPD.Text = this.gobber.Stats[1, 2];
            this.vetSTR.Text = this.gobber.Stats[2, 2];
            this.vetAGL.Text = this.gobber.Stats[3, 2];
            this.vetPOI.Text = this.gobber.Stats[4, 2];
            this.vetPRW.Text = this.gobber.Stats[5, 2];
            this.vetINT.Text = this.gobber.Stats[6, 2];
            this.vetARC.Text = this.gobber.Stats[7, 2];
            this.vetPER.Text = this.gobber.Stats[8, 2];

            this.epicPHY.Text = this.gobber.Stats[0, 3];
            this.epicSPD.Text = this.gobber.Stats[1, 3];
            this.epicSTR.Text = this.gobber.Stats[2, 3];
            this.epicAGL.Text = this.gobber.Stats[3, 3];
            this.epicPOI.Text = this.gobber.Stats[4, 3];
            this.epicPRW.Text = this.gobber.Stats[5, 3];
            this.epicINT.Text = this.gobber.Stats[6, 3];
            this.epicARC.Text = this.gobber.Stats[7, 3];
            this.epicPER.Text = this.gobber.Stats[8, 3];

            this.racialText.Text = this.gobber.Text;
        }

        private void iosanSelected() {
            this.startingPHY.Text = this.iosanStats[0, 0];
            this.startingSPD.Text = this.iosanStats[1, 0];
            this.startingSTR.Text = this.iosanStats[2, 0];
            this.startingAGL.Text = this.iosanStats[3, 0];
            this.startingPRW.Text = this.iosanStats[4, 0];
            this.startingPOI.Text = this.iosanStats[5, 0];
            this.startingINT.Text = this.iosanStats[6, 0];
            this.startingARC.Text = this.iosanStats[7, 0];
            this.startingPER.Text = this.iosanStats[8, 0];

            this.heroPHY.Text = this.iosanStats[0, 1];
            this.heroSPD.Text = this.iosanStats[1, 1];
            this.heroSTR.Text = this.iosanStats[2, 1];
            this.heroAGL.Text = this.iosanStats[3, 1];
            this.heroPRW.Text = this.iosanStats[4, 1];
            this.heroPOI.Text = this.iosanStats[5, 1];
            this.heroINT.Text = this.iosanStats[6, 1];
            this.heroARC.Text = this.iosanStats[7, 1];
            this.heroPER.Text = this.iosanStats[8, 1];

            this.vetPHY.Text = this.iosanStats[0, 2];
            this.vetSPD.Text = this.iosanStats[1, 2];
            this.vetSTR.Text = this.iosanStats[2, 2];
            this.vetAGL.Text = this.iosanStats[3, 2];
            this.vetPOI.Text = this.iosanStats[4, 2];
            this.vetPRW.Text = this.iosanStats[5, 2];
            this.vetINT.Text = this.iosanStats[6, 2];
            this.vetARC.Text = this.iosanStats[7, 2];
            this.vetPER.Text = this.iosanStats[8, 2];

            this.epicPHY.Text = this.iosanStats[0, 3];
            this.epicSPD.Text = this.iosanStats[1, 3];
            this.epicSTR.Text = this.iosanStats[2, 3];
            this.epicAGL.Text = this.iosanStats[3, 3];
            this.epicPOI.Text = this.iosanStats[4, 3];
            this.epicPRW.Text = this.iosanStats[5, 3];
            this.epicINT.Text = this.iosanStats[6, 3];
            this.epicARC.Text = this.iosanStats[7, 3];
            this.epicPER.Text = this.iosanStats[8, 3];

            this.racialText.Text = this.iosanText;
            this.startingPHY.Text = this.iosan.Stats[0, 0];
            this.startingSPD.Text = this.iosan.Stats[1, 0];
            this.startingSTR.Text = this.iosan.Stats[2, 0];
            this.startingAGL.Text = this.iosan.Stats[3, 0];
            this.startingPRW.Text = this.iosan.Stats[4, 0];
            this.startingPOI.Text = this.iosan.Stats[5, 0];
            this.startingINT.Text = this.iosan.Stats[6, 0];
            this.startingARC.Text = this.iosan.Stats[7, 0];
            this.startingPER.Text = this.iosan.Stats[8, 0];

            this.heroPHY.Text = this.iosan.Stats[0, 1];
            this.heroSPD.Text = this.iosan.Stats[1, 1];
            this.heroSTR.Text = this.iosan.Stats[2, 1];
            this.heroAGL.Text = this.iosan.Stats[3, 1];
            this.heroPRW.Text = this.iosan.Stats[4, 1];
            this.heroPOI.Text = this.iosan.Stats[5, 1];
            this.heroINT.Text = this.iosan.Stats[6, 1];
            this.heroARC.Text = this.iosan.Stats[7, 1];
            this.heroPER.Text = this.iosan.Stats[8, 1];

            this.vetPHY.Text = this.iosan.Stats[0, 2];
            this.vetSPD.Text = this.iosan.Stats[1, 2];
            this.vetSTR.Text = this.iosan.Stats[2, 2];
            this.vetAGL.Text = this.iosan.Stats[3, 2];
            this.vetPOI.Text = this.iosan.Stats[4, 2];
            this.vetPRW.Text = this.iosan.Stats[5, 2];
            this.vetINT.Text = this.iosan.Stats[6, 2];
            this.vetARC.Text = this.iosan.Stats[7, 2];
            this.vetPER.Text = this.iosan.Stats[8, 2];

            this.epicPHY.Text = this.iosan.Stats[0, 3];
            this.epicSPD.Text = this.iosan.Stats[1, 3];
            this.epicSTR.Text = this.iosan.Stats[2, 3];
            this.epicAGL.Text = this.iosan.Stats[3, 3];
            this.epicPOI.Text = this.iosan.Stats[4, 3];
            this.epicPRW.Text = this.iosan.Stats[5, 3];
            this.epicINT.Text = this.iosan.Stats[6, 3];
            this.epicARC.Text = this.iosan.Stats[7, 3];
            this.epicPER.Text = this.iosan.Stats[8, 3];

            this.racialText.Text = this.iosan.Text;
        }

        private void nyssSelected() {
            this.startingPHY.Text = this.nyssStats[0, 0];
            this.startingSPD.Text = this.nyssStats[1, 0];
            this.startingSTR.Text = this.nyssStats[2, 0];
            this.startingAGL.Text = this.nyssStats[3, 0];
            this.startingPRW.Text = this.nyssStats[4, 0];
            this.startingPOI.Text = this.nyssStats[5, 0];
            this.startingINT.Text = this.nyssStats[6, 0];
            this.startingARC.Text = this.nyssStats[7, 0];
            this.startingPER.Text = this.nyssStats[8, 0];

            this.heroPHY.Text = this.nyssStats[0, 1];
            this.heroSPD.Text = this.nyssStats[1, 1];
            this.heroSTR.Text = this.nyssStats[2, 1];
            this.heroAGL.Text = this.nyssStats[3, 1];
            this.heroPRW.Text = this.nyssStats[4, 1];
            this.heroPOI.Text = this.nyssStats[5, 1];
            this.heroINT.Text = this.nyssStats[6, 1];
            this.heroARC.Text = this.nyssStats[7, 1];
            this.heroPER.Text = this.nyssStats[8, 1];

            this.vetPHY.Text = this.nyssStats[0, 2];
            this.vetSPD.Text = this.nyssStats[1, 2];
            this.vetSTR.Text = this.nyssStats[2, 2];
            this.vetAGL.Text = this.nyssStats[3, 2];
            this.vetPOI.Text = this.nyssStats[4, 2];
            this.vetPRW.Text = this.nyssStats[5, 2];
            this.vetINT.Text = this.nyssStats[6, 2];
            this.vetARC.Text = this.nyssStats[7, 2];
            this.vetPER.Text = this.nyssStats[8, 2];

            this.epicPHY.Text = this.nyssStats[0, 3];
            this.epicSPD.Text = this.nyssStats[1, 3];
            this.epicSTR.Text = this.nyssStats[2, 3];
            this.epicAGL.Text = this.nyssStats[3, 3];
            this.epicPOI.Text = this.nyssStats[4, 3];
            this.epicPRW.Text = this.nyssStats[5, 3];
            this.epicINT.Text = this.nyssStats[6, 3];
            this.epicARC.Text = this.nyssStats[7, 3];
            this.epicPER.Text = this.nyssStats[8, 3];

            this.racialText.Text = this.nyssText;
            this.startingPHY.Text = this.nyss.Stats[0, 0];
            this.startingSPD.Text = this.nyss.Stats[1, 0];
            this.startingSTR.Text = this.nyss.Stats[2, 0];
            this.startingAGL.Text = this.nyss.Stats[3, 0];
            this.startingPRW.Text = this.nyss.Stats[4, 0];
            this.startingPOI.Text = this.nyss.Stats[5, 0];
            this.startingINT.Text = this.nyss.Stats[6, 0];
            this.startingARC.Text = this.nyss.Stats[7, 0];
            this.startingPER.Text = this.nyss.Stats[8, 0];

            this.heroPHY.Text = this.nyss.Stats[0, 1];
            this.heroSPD.Text = this.nyss.Stats[1, 1];
            this.heroSTR.Text = this.nyss.Stats[2, 1];
            this.heroAGL.Text = this.nyss.Stats[3, 1];
            this.heroPRW.Text = this.nyss.Stats[4, 1];
            this.heroPOI.Text = this.nyss.Stats[5, 1];
            this.heroINT.Text = this.nyss.Stats[6, 1];
            this.heroARC.Text = this.nyss.Stats[7, 1];
            this.heroPER.Text = this.nyss.Stats[8, 1];

            this.vetPHY.Text = this.nyss.Stats[0, 2];
            this.vetSPD.Text = this.nyss.Stats[1, 2];
            this.vetSTR.Text = this.nyss.Stats[2, 2];
            this.vetAGL.Text = this.nyss.Stats[3, 2];
            this.vetPOI.Text = this.nyss.Stats[4, 2];
            this.vetPRW.Text = this.nyss.Stats[5, 2];
            this.vetINT.Text = this.nyss.Stats[6, 2];
            this.vetARC.Text = this.nyss.Stats[7, 2];
            this.vetPER.Text = this.nyss.Stats[8, 2];

            this.epicPHY.Text = this.nyss.Stats[0, 3];
            this.epicSPD.Text = this.nyss.Stats[1, 3];
            this.epicSTR.Text = this.nyss.Stats[2, 3];
            this.epicAGL.Text = this.nyss.Stats[3, 3];
            this.epicPOI.Text = this.nyss.Stats[4, 3];
            this.epicPRW.Text = this.nyss.Stats[5, 3];
            this.epicINT.Text = this.nyss.Stats[6, 3];
            this.epicARC.Text = this.nyss.Stats[7, 3];
            this.epicPER.Text = this.nyss.Stats[8, 3];

            this.racialText.Text = this.nyss.Text;
        }

        private void ogrunSelected() {
            this.startingPHY.Text = this.ogrunStats[0, 0];
            this.startingSPD.Text = this.ogrunStats[1, 0];
            this.startingSTR.Text = this.ogrunStats[2, 0];
            this.startingAGL.Text = this.ogrunStats[3, 0];
            this.startingPRW.Text = this.ogrunStats[4, 0];
            this.startingPOI.Text = this.ogrunStats[5, 0];
            this.startingINT.Text = this.ogrunStats[6, 0];
            this.startingARC.Text = this.ogrunStats[7, 0];
            this.startingPER.Text = this.ogrunStats[8, 0];

            this.heroPHY.Text = this.ogrunStats[0, 1];
            this.heroSPD.Text = this.ogrunStats[1, 1];
            this.heroSTR.Text = this.ogrunStats[2, 1];
            this.heroAGL.Text = this.ogrunStats[3, 1];
            this.heroPRW.Text = this.ogrunStats[4, 1];
            this.heroPOI.Text = this.ogrunStats[5, 1];
            this.heroINT.Text = this.ogrunStats[6, 1];
            this.heroARC.Text = this.ogrunStats[7, 1];
            this.heroPER.Text = this.ogrunStats[8, 1];

            this.vetPHY.Text = this.ogrunStats[0, 2];
            this.vetSPD.Text = this.ogrunStats[1, 2];
            this.vetSTR.Text = this.ogrunStats[2, 2];
            this.vetAGL.Text = this.ogrunStats[3, 2];
            this.vetPOI.Text = this.ogrunStats[4, 2];
            this.vetPRW.Text = this.ogrunStats[5, 2];
            this.vetINT.Text = this.ogrunStats[6, 2];
            this.vetARC.Text = this.ogrunStats[7, 2];
            this.vetPER.Text = this.ogrunStats[8, 2];

            this.epicPHY.Text = this.ogrunStats[0, 3];
            this.epicSPD.Text = this.ogrunStats[1, 3];
            this.epicSTR.Text = this.ogrunStats[2, 3];
            this.epicAGL.Text = this.ogrunStats[3, 3];
            this.epicPOI.Text = this.ogrunStats[4, 3];
            this.epicPRW.Text = this.ogrunStats[5, 3];
            this.epicINT.Text = this.ogrunStats[6, 3];
            this.epicARC.Text = this.ogrunStats[7, 3];
            this.epicPER.Text = this.ogrunStats[8, 3];

            this.racialText.Text = this.ogrunText;
            this.startingPHY.Text = this.ogrun.Stats[0, 0];
            this.startingSPD.Text = this.ogrun.Stats[1, 0];
            this.startingSTR.Text = this.ogrun.Stats[2, 0];
            this.startingAGL.Text = this.ogrun.Stats[3, 0];
            this.startingPRW.Text = this.ogrun.Stats[4, 0];
            this.startingPOI.Text = this.ogrun.Stats[5, 0];
            this.startingINT.Text = this.ogrun.Stats[6, 0];
            this.startingARC.Text = this.ogrun.Stats[7, 0];
            this.startingPER.Text = this.ogrun.Stats[8, 0];

            this.heroPHY.Text = this.ogrun.Stats[0, 1];
            this.heroSPD.Text = this.ogrun.Stats[1, 1];
            this.heroSTR.Text = this.ogrun.Stats[2, 1];
            this.heroAGL.Text = this.ogrun.Stats[3, 1];
            this.heroPRW.Text = this.ogrun.Stats[4, 1];
            this.heroPOI.Text = this.ogrun.Stats[5, 1];
            this.heroINT.Text = this.ogrun.Stats[6, 1];
            this.heroARC.Text = this.ogrun.Stats[7, 1];
            this.heroPER.Text = this.ogrun.Stats[8, 1];

            this.vetPHY.Text = this.ogrun.Stats[0, 2];
            this.vetSPD.Text = this.ogrun.Stats[1, 2];
            this.vetSTR.Text = this.ogrun.Stats[2, 2];
            this.vetAGL.Text = this.ogrun.Stats[3, 2];
            this.vetPOI.Text = this.ogrun.Stats[4, 2];
            this.vetPRW.Text = this.ogrun.Stats[5, 2];
            this.vetINT.Text = this.ogrun.Stats[6, 2];
            this.vetARC.Text = this.ogrun.Stats[7, 2];
            this.vetPER.Text = this.ogrun.Stats[8, 2];

            this.epicPHY.Text = this.ogrun.Stats[0, 3];
            this.epicSPD.Text = this.ogrun.Stats[1, 3];
            this.epicSTR.Text = this.ogrun.Stats[2, 3];
            this.epicAGL.Text = this.ogrun.Stats[3, 3];
            this.epicPOI.Text = this.ogrun.Stats[4, 3];
            this.epicPRW.Text = this.ogrun.Stats[5, 3];
            this.epicINT.Text = this.ogrun.Stats[6, 3];
            this.epicARC.Text = this.ogrun.Stats[7, 3];
            this.epicPER.Text = this.ogrun.Stats[8, 3];

            this.racialText.Text = this.ogrun.Text;
        }

        private void trollkinSelected() {
            this.startingPHY.Text = this.trollkinStats[0, 0];
            this.startingSPD.Text = this.trollkinStats[1, 0];
            this.startingSTR.Text = this.trollkinStats[2, 0];
            this.startingAGL.Text = this.trollkinStats[3, 0];
            this.startingPRW.Text = this.trollkinStats[4, 0];
            this.startingPOI.Text = this.trollkinStats[5, 0];
            this.startingINT.Text = this.trollkinStats[6, 0];
            this.startingARC.Text = this.trollkinStats[7, 0];
            this.startingPER.Text = this.trollkinStats[8, 0];

            this.heroPHY.Text = this.trollkinStats[0, 1];
            this.heroSPD.Text = this.trollkinStats[1, 1];
            this.heroSTR.Text = this.trollkinStats[2, 1];
            this.heroAGL.Text = this.trollkinStats[3, 1];
            this.heroPRW.Text = this.trollkinStats[4, 1];
            this.heroPOI.Text = this.trollkinStats[5, 1];
            this.heroINT.Text = this.trollkinStats[6, 1];
            this.heroARC.Text = this.trollkinStats[7, 1];
            this.heroPER.Text = this.trollkinStats[8, 1];

            this.vetPHY.Text = this.trollkinStats[0, 2];
            this.vetSPD.Text = this.trollkinStats[1, 2];
            this.vetSTR.Text = this.trollkinStats[2, 2];
            this.vetAGL.Text = this.trollkinStats[3, 2];
            this.vetPOI.Text = this.trollkinStats[4, 2];
            this.vetPRW.Text = this.trollkinStats[5, 2];
            this.vetINT.Text = this.trollkinStats[6, 2];
            this.vetARC.Text = this.trollkinStats[7, 2];
            this.vetPER.Text = this.trollkinStats[8, 2];

            this.epicPHY.Text = this.trollkinStats[0, 3];
            this.epicSPD.Text = this.trollkinStats[1, 3];
            this.epicSTR.Text = this.trollkinStats[2, 3];
            this.epicAGL.Text = this.trollkinStats[3, 3];
            this.epicPOI.Text = this.trollkinStats[4, 3];
            this.epicPRW.Text = this.trollkinStats[5, 3];
            this.epicINT.Text = this.trollkinStats[6, 3];
            this.epicARC.Text = this.trollkinStats[7, 3];
            this.epicPER.Text = this.trollkinStats[8, 3];
        
            this.racialText.Text = this.trollkinText;
            this.startingPHY.Text = this.trollkin.Stats[0, 0];
            this.startingSPD.Text = this.trollkin.Stats[1, 0];
            this.startingSTR.Text = this.trollkin.Stats[2, 0];
            this.startingAGL.Text = this.trollkin.Stats[3, 0];
            this.startingPRW.Text = this.trollkin.Stats[4, 0];
            this.startingPOI.Text = this.trollkin.Stats[5, 0];
            this.startingINT.Text = this.trollkin.Stats[6, 0];
            this.startingARC.Text = this.trollkin.Stats[7, 0];
            this.startingPER.Text = this.trollkin.Stats[8, 0];

            this.heroPHY.Text = this.trollkin.Stats[0, 1];
            this.heroSPD.Text = this.trollkin.Stats[1, 1];
            this.heroSTR.Text = this.trollkin.Stats[2, 1];
            this.heroAGL.Text = this.trollkin.Stats[3, 1];
            this.heroPRW.Text = this.trollkin.Stats[4, 1];
            this.heroPOI.Text = this.trollkin.Stats[5, 1];
            this.heroINT.Text = this.trollkin.Stats[6, 1];
            this.heroARC.Text = this.trollkin.Stats[7, 1];
            this.heroPER.Text = this.trollkin.Stats[8, 1];

            this.vetPHY.Text = this.trollkin.Stats[0, 2];
            this.vetSPD.Text = this.trollkin.Stats[1, 2];
            this.vetSTR.Text = this.trollkin.Stats[2, 2];
            this.vetAGL.Text = this.trollkin.Stats[3, 2];
            this.vetPOI.Text = this.trollkin.Stats[4, 2];
            this.vetPRW.Text = this.trollkin.Stats[5, 2];
            this.vetINT.Text = this.trollkin.Stats[6, 2];
            this.vetARC.Text = this.trollkin.Stats[7, 2];
            this.vetPER.Text = this.trollkin.Stats[8, 2];

            this.epicPHY.Text = this.trollkin.Stats[0, 3];
            this.epicSPD.Text = this.trollkin.Stats[1, 3];
            this.epicSTR.Text = this.trollkin.Stats[2, 3];
            this.epicAGL.Text = this.trollkin.Stats[3, 3];
            this.epicPOI.Text = this.trollkin.Stats[4, 3];
            this.epicPRW.Text = this.trollkin.Stats[5, 3];
            this.epicINT.Text = this.trollkin.Stats[6, 3];
            this.epicARC.Text = this.trollkin.Stats[7, 3];
            this.epicPER.Text = this.trollkin.Stats[8, 3];

            this.racialText.Text = this.trollkin.Text;
        } */

        private void UpdateRaceTab() {
            race temp = rList[this.selectedRaceIndex];
            this.startingPHY.Text = temp.Stats[0, 0];
            this.startingSPD.Text = temp.Stats[1, 0];
            this.startingSTR.Text = temp.Stats[2, 0];
            this.startingAGL.Text = temp.Stats[3, 0];
            this.startingPRW.Text = temp.Stats[4, 0];
            this.startingPOI.Text = temp.Stats[5, 0];
            this.startingINT.Text = temp.Stats[6, 0];
            this.startingARC.Text = temp.Stats[7, 0];
            this.startingPER.Text = temp.Stats[8, 0];

            this.heroPHY.Text = temp.Stats[0, 1];
            this.heroSPD.Text = temp.Stats[1, 1];
            this.heroSTR.Text = temp.Stats[2, 1];
            this.heroAGL.Text = temp.Stats[3, 1];
            this.heroPRW.Text = temp.Stats[4, 1];
            this.heroPOI.Text = temp.Stats[5, 1];
            this.heroINT.Text = temp.Stats[6, 1];
            this.heroARC.Text = temp.Stats[7, 1];
            this.heroPER.Text = temp.Stats[8, 1];

            this.vetPHY.Text = temp.Stats[0, 2];
            this.vetSPD.Text = temp.Stats[1, 2];
            this.vetSTR.Text = temp.Stats[2, 2];
            this.vetAGL.Text = temp.Stats[3, 2];
            this.vetPOI.Text = temp.Stats[4, 2];
            this.vetPRW.Text = temp.Stats[5, 2];
            this.vetINT.Text = temp.Stats[6, 2];
            this.vetARC.Text = temp.Stats[7, 2];
            this.vetPER.Text = temp.Stats[8, 2];

            this.epicPHY.Text = temp.Stats[0, 3];
            this.epicSPD.Text = temp.Stats[1, 3];
            this.epicSTR.Text = temp.Stats[2, 3];
            this.epicAGL.Text = temp.Stats[3, 3];
            this.epicPOI.Text = temp.Stats[4, 3];
            this.epicPRW.Text = temp.Stats[5, 3];
            this.epicINT.Text = temp.Stats[6, 3];
            this.epicARC.Text = temp.Stats[7, 3];
            this.epicPER.Text = temp.Stats[8, 3];

            this.racialText.Text = temp.Text;
        }

        private void giftedSelected() {
            giftedFlowPanel.Visible = true;
            intellectualFlowPanel.Visible = false;
            mightFlowPanel.Visible = false;
            skilledFlowPanel.Visible = false;
            uncheckBoxes();
        }

        private void intellectualSelected() {
            giftedFlowPanel.Visible = false;
            intellectualFlowPanel.Visible = true;
            mightFlowPanel.Visible = false;
            skilledFlowPanel.Visible = false;
            uncheckBoxes();
        }

        private void mightySelected() {
            giftedFlowPanel.Visible = false;
            intellectualFlowPanel.Visible = false;
            mightFlowPanel.Visible = true;
            skilledFlowPanel.Visible = false;
            uncheckBoxes();
        }

        private void skilledSelected() {
            giftedFlowPanel.Visible = false;
            intellectualFlowPanel.Visible = false;
            mightFlowPanel.Visible = false;
            skilledFlowPanel.Visible = true;
            uncheckBoxes();
        }

        private void uncheckBoxes() {
            this.giftedAdditionalStudy.Checked = false;
            this.giftedCombatCaster.Checked = false;
            this.giftedFastCaster.Checked = false;
            this.giftedFeatDominator.Checked = false;
            this.giftedFeatPowerfulCaster.Checked = false;
            this.giftedFeatQuickCast.Checked = false;
            this.giftedFeatStrengthOfWill.Checked = false;
            this.giftedMagicSensitivity.Checked = false;
            this.giftedRuneReader.Checked = false;
            this.giftedWardingCircle.Checked = false;
            this.intelBattlefieldCoordination.Checked = false;
            this.intelFeatFlawlessTiming.Checked = false;
            this.intelFeatPrescient.Checked = false;
            this.intelFeatPerfectPlot.Checked = false;
            this.intelFeatPlanOfAction.Checked = false;
            this.intelFeatQuickThinking.Checked = false;
            this.intelFeatUnconventionalWarfare.Checked = false;
            this.intelGenius.Checked = false;
            this.intelHyperPerception.Checked = false;
            this.intelPhotographicMemory.Checked = false;
            this.mightBeatBack.Checked = false;
            this.mightFeatBackSwing.Checked = false;
            this.mightFeatBoundingLeap.Checked = false;
            this.mightFeatCounterCharge.Checked = false;
            this.mightFeatInvulnerable.Checked = false;
            this.mightFeatRevitalize.Checked = false;
            this.mightFeatShieldBreaker.Checked = false;
            this.mightFeatVendetta.Checked = false;
            this.mightRighteousAnger.Checked = false;
            this.mightTough.Checked = false;
            this.skillAmbidextrous.Checked = false;
            this.skillCagey.Checked = false;
            this.skillDeft.Checked = false;
            this.skillFeatDefensiveStrike.Checked = false;
            this.skillFeatDisarm.Checked = false;
            this.skillFeatSwashbuckler.Checked = false;
            this.skillFeatUntouchable.Checked = false;
            this.skillPreternaturaAwareness.Checked = false;
            this.skillSidestep.Checked = false;
            this.skillVirtuoso.Checked = false;
        }

        private void disableMouseWheel(object sender, MouseEventArgs e) {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private XmlDocument doc = new XmlDocument();
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream mStream = null;
            StringBuilder output = new StringBuilder();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "HOMEDIRECTORY";
            ofd.Filter = "eXtensible Markup Language file (*.xml)|*.xml";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if ( ofd.ShowDialog() == DialogResult.OK ) {
                try {
                    if ( (mStream = ofd.OpenFile()) != null ) {
/*                        using ( mStream ) {
                            using ( XmlReader reader = XmlReader.Create(mStream) ) {
                                XmlWriterSettings ws = new XmlWriterSettings();
                                ws.Indent = true;
                                using ( XmlWriter writer = XmlWriter.Create(output, ws) ) {
                                    // Parse the file and display each of the nodes.
                                    while ( reader.Read() ) {
                                        switch ( reader.NodeType ) {
                                            case XmlNodeType.Element:
                                                writer.WriteStartElement(reader.Name);
                                                break;
                                            case XmlNodeType.Text:
                                                writer.WriteString(reader.Value);
                                                break;
                                            case XmlNodeType.XmlDeclaration:
                                            case XmlNodeType.ProcessingInstruction:
                                                writer.WriteProcessingInstruction(reader.Name, reader.Value);
                                                break;
                                            case XmlNodeType.Comment:
                                                writer.WriteComment(reader.Value);
                                                break;
                                            case XmlNodeType.EndElement:
                                                writer.WriteFullEndElement();
                                                break;
                                        }
                                    }
                                }
                            }
                            MessageBox.Show(output.ToString());
                        } */
                        doc.Load(ofd.FileName);
                        XmlNode root = doc.DocumentElement;
                        XmlNode playerName = root.SelectSingleNode("/character/info/player");
                        if ( playerName.HasChildNodes ) {
                            playerNameText.Text = playerName.FirstChild.Value;
                        }
                        XmlNode characterName = root.SelectSingleNode("/character/info/name");
                        if ( characterName.HasChildNodes ) {
                            characterNameText.Text = characterName.FirstChild.Value;
                        }
                        XmlNode characterGender = root.SelectSingleNode("/character/info/gender");
                        if ( characterGender.HasChildNodes ) {
                            characterGenderText.Text = characterGender.FirstChild.Value;
                        }
                        XmlNode characterWeight = root.SelectSingleNode("/character/info/weight");
                        if ( characterWeight.HasChildNodes ) {
                            characterWeightText.Text = characterWeight.FirstChild.Value;
                        }
                        XmlNode characterHeight = root.SelectSingleNode("/character/info/height");
                        if ( characterHeight.HasChildNodes ) {
                            characterHeightText.Text = characterHeight.FirstChild.Value;
                        }
                        XmlNode characterFaith = root.SelectSingleNode("/character/info/faith");
                        if ( characterFaith.HasChildNodes ) {
                            characterFaithText.Text = characterFaith.FirstChild.Value;
                        }
                        XmlNode characterDefining = root.SelectSingleNode("/character/info/defining");
                        if ( characterDefining.HasChildNodes ) {
                            characterDefiningText.Text = characterDefining.FirstChild.Value;
                        }
                    }
                } catch ( Exception ex ) {
                    MessageBox.Show("Error. Could not read file from disk. Original Error: " + ex.Message);
                }
            }
        }
    }

    internal class race {
        public enum Race {
            HUMAN = 0, DWARF = 1, GOBBER = 2, IOSAN = 3, NYSS = 4,
            OGRUN = 5, TROLLKIN = 6
        }
        // Properties
        private string _text;
        private string[,] _stats;
        private List<archetype.Archetypes> _validArchetypes;
        // Constructors
        public race(string text, string[,] stats) {
            _text = text;
            _stats = new string[9, 4];
            Array.Copy(stats, _stats, 36);
        }
        public race(string text, string[,] stats, archetype.Archetypes[] archetypes) {
            _text = text;
            _stats = new string[9, 4];
            Array.Copy(stats, _stats, 36);
            _validArchetypes = new List<archetype.Archetypes>();
            for ( int i = 0; i < archetypes.Length; i++ ) {
                if ( !(_validArchetypes.Contains(archetypes[i])) ) {
                    _validArchetypes.Add(archetypes[i]);
                }
            }

        }
        public race(string text, string[,] stats, List<archetype.Archetypes> archetypes) {
            _text = text;
            _stats = new string[9, 4];
            Array.Copy(stats, _stats, 36);
            _validArchetypes = new List<archetype.Archetypes>();
            while ( archetypes.Count > 0 ) {
                archetype.Archetypes temp = archetypes.First();
                if ( !(_validArchetypes.Contains(temp)) ) {
                    _validArchetypes.Add(temp);
                }
                archetypes.Remove(temp);
            }
        }
        public race(race a) {
            this._text = a._text;
            this._stats = new string[9, 4];
            Array.Copy(a._stats, this._stats, 36);
            this._validArchetypes = new List<archetype.Archetypes>(a._validArchetypes);
        }
        // Accessors/Mutators
        public string Text { get { return _text; } set { _text = value; } }
        public string[,] Stats { get { return _stats; } set { Array.Copy(value, _stats, 36); } }
        public bool isValidArchetype(archetype.Archetypes a) { return _validArchetypes.Contains(a); }
        public bool addArchetype(archetype.Archetypes a) {
            bool returnVal = false;
            if ( _validArchetypes.Contains(a) ) {
                returnVal = false;
            } else {
                _validArchetypes.Add(a);
                returnVal = true;
            }
            return returnVal;
        }
    }

    internal class archetype {
        public enum Archetypes {
            GIFTED = 0, INTELLECTUAL = 1, MIGHTY = 2, SKILLED = 3
        }
    }

    internal class job {
        public enum Careers {
            ALCHEMIST = 0, ARCANE_MECHANIK = 1, ARCANIST = 2, ARISTOCRAT = 3,
            BOUNTY_HUNTER = 4, CUTTHROAT = 5, DUELIST = 6, EXPLORER = 7,
            FELL_CALLER = 8, FIELD_MECHANIK = 9, GUN_MAGE = 10, HIGHWAYMAN = 11,
            INVESTIGATOR = 12, IRON_FANG = 13, KNIGHT = 14, MAGE_HUNTER = 15,
            MAN_AT_ARMS = 16, MILITARY_OFFICER = 17, PIRATE = 18, PRIEST_MORROW = 19,
            PRIEST_MENOTH = 20, RIFLEMAN = 21, SOLDIER = 22, SORCERER_FIRE = 23,
            SORCERER_ICE = 24, SORCERER_STONE = 25, SORCERER_STORM = 26, SPY = 27,
            STORMBLADE = 28, THEIF = 29, TRENCHER = 30, WARCASTER = 31
        }
        // Properties
        private string _name;
        private List<Careers> _invalidSecondaryCareer;
        private bool _giftedRequired;
        private string _text;
        private List<abilities> _startingAbilities;
        private List<abilities> _careerAbilities;
        private List<skills> _startingSkills;
        private List<skills> _careerSkills;
    }

    internal class abilities {
        // Properties
        private string _name;
        private string _text;
        private List<Object> _prerequisite;
    }

    internal class skills {

    }
}
