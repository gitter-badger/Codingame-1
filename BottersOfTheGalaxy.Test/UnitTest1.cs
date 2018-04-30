﻿using System;
using NUnit.Framework;

namespace BottersOfTheGalaxy.Test
{
    [TestFixture]
    public class UnitTest1
    {
        //[TestCase("0\n19\nBUSH 682 720 50\nBUSH 1238 720 50\nBUSH 238 380 50\nBUSH 1682 380 50\nBUSH 787 380 50\nBUSH 1133 380 50\nBUSH 88 330 50\nBUSH 1832 330 50\nBUSH 856 76 50\nBUSH 1064 76 50\nBUSH 1740 123 50\nBUSH 180 123 50\nBUSH 1018 273 50\nBUSH 902 273 50\nBUSH 756 178 50\nBUSH 1164 178 50\nSPAWN 94 266 0\nSPAWN 960 199 0\nSPAWN 1826 266 0\n23\nBronze_Gadget_4 147 0 0 0 0 0 0 3 0\nGolden_Blade_14 569 6 847 847 0 0 0 0 0\nSilver_Blade_10 468 71 0 0 0 0 0 0 0\nLegendary_Gadget_16 1496 0 2124 2124 0 0 0 27 0\nmana_potion 25 0 0 0 50 0 0 0 1\nBronze_Gadget_1 34 0 0 0 68 68 0 0 0\nLegendary_Gadget_19 1122 0 1204 1204 0 0 0 13 0\nxxl_potion 330 0 500 0 0 0 0 0 1\nBronze_Blade_2 120 10 0 0 100 100 0 0 0\nBronze_Boots_3 120 9 0 0 0 0 16 0 0\nLegendary_Blade_18 1264 8 2500 2500 0 0 0 0 0\nBronze_Boots_5 82 0 0 0 0 0 9 1 0\nSilver_Blade_8 229 33 0 0 0 0 0 0 0\nSilver_Blade_9 175 18 0 0 0 0 0 1 0\nSilver_Gadget_6 450 0 57 57 100 100 0 8 0\nGolden_Boots_11 843 42 174 174 100 100 150 0 0\nGolden_Gadget_15 834 0 0 0 100 100 0 19 0\nLegendary_Boots_20 1330 87 244 244 100 100 150 12 0\nlarger_potion 70 0 100 0 0 0 0 0 1\nSilver_Boots_7 415 0 180 180 0 0 20 5 0\nGolden_Blade_13 877 148 0 0 0 0 0 0 0\nGolden_Blade_12 903 6 1020 1020 100 100 0 6 0\nLegendary_Boots_17 1045 0 0 0 100 100 138 16 0\n252\n252\n2\n14\n1 0 TOWER 100 540 400 3000 3000 0 100 0 0 0 0 0 0 0 0 0 - 1 0\n2 1 TOWER 1820 540 400 3000 3000 0 100 0 0 0 0 0 0 0 0 0 - 1 0\n3 0 HERO 200 590 110 1380 1380 0 80 200 0 300 0 0 0 100 100 1 DEADPOOL 1 0\n4 1 HERO 1720 590 130 1400 1400 0 65 200 0 300 0 0 0 155 155 2 VALKYRIE 1 0\n5 0 HERO 200 490 130 1400 1400 0 65 200 0 300 0 0 0 155 155 2 VALKYRIE 1 0\n6 1 HERO 1720 490 270 820 820 0 60 200 0 300 0 0 0 200 200 2 IRONMAN 1 0\n7 0 UNIT 160 490 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n8 0 UNIT 160 540 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n9 0 UNIT 160 590 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n10 0 UNIT 110 490 300 250 250 0 35 150 0 50 0 0 0 0 0 0 - 1 0\n11 1 UNIT 1760 490 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n12 1 UNIT 1760 540 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n13 1 UNIT 1760 590 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n14 1 UNIT 1810 490 300 250 250 0 35 150 0 50 0 0 0 0 0 0 - 1 0\n")]
        [TestCase("1\n21\nBUSH 175 720 50\nBUSH 1745 720 50\nBUSH 566 720 50\nBUSH 1354 720 50\nBUSH 804 720 50\nBUSH 1116 720 50\nBUSH 361 380 50\nBUSH 1559 380 50\nBUSH 870 380 50\nBUSH 1050 380 50\nBUSH 887 53 50\nBUSH 1033 53 50\nBUSH 1017 167 50\nBUSH 903 167 50\nBUSH 1204 141 50\nBUSH 716 141 50\nBUSH 701 270 50\nBUSH 1219 270 50\nSPAWN 743 167 0\nSPAWN 960 224 0\nSPAWN 1177 167 0\n23\nBronze_Gadget_2 116 0 169 169 0 0 0 0 0\nBronze_Gadget_4 150 0 94 94 76 76 0 1 0\nmana_potion 25 0 0 0 50 0 0 0 1\nBronze_Blade_5 140 13 0 0 0 0 0 1 0\nLegendary_Gadget_18 1112 0 2311 2311 100 100 0 0 0\nxxl_potion 326 0 500 0 0 0 0 0 1\nGolden_Gadget_13 490 0 0 0 0 0 0 11 0\nBronze_Blade_3 180 5 0 0 100 100 0 2 0\nGolden_Gadget_11 927 0 325 325 0 0 0 20 0\nBronze_Blade_1 134 19 0 0 0 0 0 0 0\nSilver_Blade_7 214 31 0 0 0 0 0 0 0\nLegendary_Boots_16 1147 0 1770 1770 0 0 150 0 0\nLegendary_Blade_20 1077 20 2034 2034 0 0 0 0 0\nSilver_Boots_8 453 0 0 0 100 100 126 0 0\nSilver_Boots_10 233 0 0 0 100 100 54 0 0\nSilver_Boots_9 477 4 0 0 0 0 140 0 0\nGolden_Boots_14 907 0 927 927 0 0 150 0 0\nGolden_Boots_12 874 0 768 768 100 100 150 0 0\nSilver_Boots_6 350 0 0 0 100 100 91 0 0\nGolden_Boots_15 614 29 0 0 0 0 141 0 0\nlarger_potion 70 0 100 0 0 0 0 0 1\nLegendary_Boots_19 1200 0 0 0 100 100 150 45 0\nLegendary_Boots_17 978 0 0 0 0 0 148 16 0\n335\n335\n2\n14\n1 0 TOWER 100 540 400 3000 3000 0 190 0 0 0 0 0 0 0 0 0 - 1 0\n2 1 TOWER 1820 540 400 3000 3000 0 190 0 0 0 0 0 0 0 0 0 - 1 0\n3 0 HERO 200 590 245 955 955 0 50 200 0 300 0 0 0 300 300 2 DOCTOR_STRANGE 1 0\n4 1 HERO 1720 590 270 820 820 0 60 200 0 300 0 0 0 200 200 2 IRONMAN 1 0\n5 0 HERO 200 490 270 820 820 0 60 200 0 300 0 0 0 200 200 2 IRONMAN 1 0\n6 1 HERO 1720 490 130 1400 1400 0 65 200 0 300 0 0 0 155 155 2 VALKYRIE 1 0\n7 0 UNIT 160 490 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n8 0 UNIT 160 540 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n9 0 UNIT 160 590 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n10 0 UNIT 110 490 300 250 250 0 35 150 0 50 0 0 0 0 0 0 - 1 0\n11 1 UNIT 1760 490 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n12 1 UNIT 1760 540 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n13 1 UNIT 1760 590 90 400 400 0 25 150 0 30 0 0 0 0 0 0 - 1 0\n14 1 UNIT 1810 490 300 250 250 0 35 150 0 50 0 0 0 0 0 0 - 1 0\n")]
        public void RunGame(string data)
        {
            var game = new Player();
            game.DebugMain(data);
        }
    }
}
