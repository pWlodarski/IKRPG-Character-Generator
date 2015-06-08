using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKRPG_Character_Generator {
    public partial class mForm : Form {
        private readonly string humanText = "Humans are by far the predominant race living in the Iron Kingdoms, and perhaps across Caen itself, as they have been observed on several continents. Mankind has been prevalent in western Immoren for as long as legends have been told, with civizations stretching back six thousand years and untold millennia before that as nomadic tribes. Humans are an adaptable and hardy race capable of broad range of careers and thriving in every geography, from the frozen northern mountants to the arid desert wastes. Humans have been at the forefront of invention and pioneering many of the technologies that the nations of the region rely upon, including alchemy and mechanika.\r\n\r\nThe fine Iron Kingdoms were the inheritors of the Thousand Cities Era, a time when countless pretty fiefdoms emerged across the region. This has given rise to a proliferation of human ethnicities and cultures, each proud of its history. Many of the peoples of western Immoren have distinct physical traits and can be recognized on sight.\r\n\r\nHumans come in a wide range of appearances, with great variance in skin pigmentation, height, hair and eye color, and body build. Most Immorese humans have pale or olive skin, but there are those who are exceptionally pale and others with very dark skin. Hair colors are usually shades of brown, but include black, red, lond, and many shades between. Humans identify with one another more by shared languages and nationality than by superficial physical distenctions.";
        private readonly string[,] humanStats = new string[9,4] {
                                                {"5","7","8","8"}, // PHY
                                                {"6","7","7","7"}, // SPD
                                                {"4","6","7","8"}, // STR
                                                {"3","5","6","7"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"4","5","6","7"}, // POI
                                                {"3","5","6","7"}, // INT
                                                {"*","4","6","8"}, // ARC
                                                {"3","5","6","7"}  // PER
                                            };
        private readonly string dwarfText = "";
        private readonly string[,] dwarfStats = new string[9,4] {
                                                {"6","7","7","8"}, // PHY
                                                {"4","5","6","6"}, // SPD
                                                {"5","6","7","8"}, // STR
                                                {"3","5","6","7"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"3","4","5","6"}, // POI
                                                {"4","5","6","7"}, // INT
                                                {"*","4","6","7"}, // ARC
                                                {"3","4","6","7"}  // PER
                                            };
        private readonly string gobberText = "";
        private readonly string[,] gobberStats = new string[9,4] {
                                                {"4","6","7","7"}, // PHY
                                                {"6","7","7","7"}, // SPD
                                                {"3","4","5","6"}, // STR
                                                {"4","5","6","7"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"3","5","6","7"}, // POI
                                                {"3","4","5","6"}, // INT
                                                {"-","-","-","-"}, // ARC
                                                {"3","4","4","5"}  // PER
                                            };
        private readonly string iosanText = "";
        private readonly string[,] iosanStats = new string[9,4] {
                                                {"5","7","7","7"}, // PHY
                                                {"6","7","7","7"}, // SPD
                                                {"4","5","6","7"}, // STR
                                                {"3","5","6","7"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"4","5","6","7"}, // POI
                                                {"4","6","6","7"}, // INT
                                                {"*","4","6","8"}, // ARC
                                                {"3","5","6","7"}  // PER
                                            };
        private readonly string nyssText = "";
        private readonly string[,] nyssStats = new string[9,4] {
                                                {"5","7","7","8"}, // PHY
                                                {"6","7","7","7"}, // SPD
                                                {"4","6","7","8"}, // STR
                                                {"4","5","6","7"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"4","5","6","7"}, // POI
                                                {"3","5","6","6"}, // INT
                                                {"*","4","6","7"}, // ARC
                                                {"3","5","6","6"}  // PER
                                            };
        private readonly string ogrunText = "";
        private readonly string[,] ogrunStats = new string[9,4] {
                                                {"6","7","8","9"}, // PHY
                                                {"5","6","6","6"}, // SPD
                                                {"6","8","9","10"}, // STR
                                                {"3","5","5","6"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"3","4","5","6"}, // POI
                                                {"3","5","5","6"}, // INT
                                                {"-","-","-","-"}, // ARC
                                                {"2","4","5","6"}  // PER
                                            };
        private readonly string trollkinText = "";
        private readonly string[,] trollkinStats = new string[9,4] {
                                                {"6","8","9","10"}, // PHY
                                                {"5","6","6","6"}, // SPD
                                                {"5","7","8","9"}, // STR
                                                {"3","5","6","7"}, // AGL
                                                {"4","5","6","7"}, // PRW
                                                {"2","4","5","6"}, // POI
                                                {"3","4","5","6"}, // INT
                                                {"*","4","6","7"}, // ARC
                                                {"3","4","5","6"}  // PER
                                            };

        public mForm() {
            InitializeComponent();
            raceSelection.Text = "Human";
        }

        private void raceSelectionChanged(object sender, EventArgs e) {
            string selected = raceSelection.SelectedItem.ToString();
            if ( selected.Equals("Human") ) {
                humanSelected();
            } else if ( selected.Equals("Dwarf") ) {
                dwarfSelected();
            } else if ( selected.Equals("Gobber") ) {
                gobberSelected();
            } else if ( selected.Equals("Iosan") ) {
                iosanSelected();
            } else if ( selected.Equals("Nyss") ) {
                nyssSelected();
            } else if ( selected.Equals("Ogrun") ) {
                ogrunSelected();
            } else if ( selected.Equals("Trollkin") ) {
                trollkinSelected();
            }
        }

        private void humanSelected() {
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
        }

        private void raceSelection_MouseWheel(object sender, MouseEventArgs e) {
            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}
