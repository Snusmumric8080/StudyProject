using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Scripts
{
    public class Calс
    {
        // 1 блок 
        public double skat_width { get; set; }
        public double profnastil_list_row { get; set; }
        public double calc_row_obresetka { get; set; }
        public double calc_obresetka { get; set; }
        public double total_cost { get; set; }
        public double cost_profnastil { get; set; }
        public double calc_insulation { get; set; }
        public double calc_barrier { get; set; }
        public double calc_cost_obresetka { get; set; }
        public double profnastil_lenght { get; set; }
        public double profnastil_list_max { get; set; }
        public double profnastil_lenght_min { get; set; }

        public string Сalculation(string roof_type, double house_lenght, double house_width, double degree, double cover, string profnastil, string barrier, string insulation)
        {
            var text = "";
            var pol_sh = 0.0;
            var cost_oc = 0.0;
            var cost_poliestr = 0.0;
            var cost_pural = 0.0;
            var cost_texture = 0.0;
            var sves = 0.0;
            var obresetka = 0.0;
            var degree_type = 0.0;
            cost_profnastil = 0;

            switch (profnastil)
            {

                case "1":
                    pol_sh = 1.125;
                    cost_oc = 165;
                    cost_poliestr = 212;
                    cost_pural = 307;
                    cost_texture = 491;
                    sves = 0.1;
                    if (degree < 15)
                    {
                        obresetka = 0.01;
                    }
                    else
                    {
                        obresetka = 0.5;
                    }
                    break;

                case "2":
                    pol_sh = 1.125;
                    cost_oc = 183;
                    cost_poliestr = 226;
                    cost_pural = 420;
                    cost_texture = 501;
                    sves = 0.1;
                    if (degree < 15)
                    {
                        obresetka = 0.01;
                    }
                    else
                    {
                        obresetka = 0.5;
                    }
                    break;

                case "3":
                    pol_sh = 1.125;
                    cost_oc = 263;
                    cost_poliestr = 382;
                    cost_pural = 487;
                    cost_texture = 592;
                    sves = 0.1;
                    if (degree < 15)
                    {
                        obresetka = 0.01;
                    }
                    else
                    {
                        obresetka = 0.5;
                    }

                    break;

                case "4":
                    pol_sh = 1;
                    cost_oc = 163;
                    cost_poliestr = 201;
                    cost_pural = 296;
                    cost_texture = 482;
                    sves = 0.1;
                    if (degree < 15)
                    {
                        obresetka = 0.3;
                    }
                    else
                    {
                        obresetka = 0.65;
                    }
                    break;

                case "5":
                    pol_sh = 1;
                    cost_oc = 192;
                    cost_poliestr = 252;
                    cost_pural = 341;
                    cost_texture = 450;
                    sves = 0.1;
                    if (degree < 15)
                    {
                        obresetka = 0.3;
                    }
                    else
                    {
                        obresetka = 0.65;
                    }
                    break;

                case "6":
                    pol_sh = 1;
                    cost_oc = 239;
                    cost_poliestr = 311;
                    cost_pural = 409;
                    cost_texture = 502;
                    sves = 0.1;
                    if (degree < 15)
                    {
                        obresetka = 0.3;
                    }
                    else
                    {
                        obresetka = 0.65;
                    }
                    break;

                case "7":
                    pol_sh = 1;
                    cost_oc = 164;
                    cost_poliestr = 207;
                    cost_pural = 303;
                    cost_texture = 402;
                    sves = 0.25;
                    if (degree < 15)
                    {
                        obresetka = 0.5;
                    }
                    else
                    {
                        obresetka = 1;
                    }
                    break;

                case "8":
                    pol_sh = 1;
                    cost_oc = 203;
                    cost_poliestr = 252;
                    cost_pural = 348;
                    cost_texture = 451;
                    sves = 0.25;
                    if (degree < 15)
                    {
                        obresetka = 0.5;
                    }
                    else
                    {
                        obresetka = 1;
                    }
                    break;

                case "9":
                    pol_sh = 1;
                    cost_oc = 237;
                    cost_poliestr = 311;
                    cost_pural = 409;
                    cost_texture = 490;
                    sves = 0.25;
                    if (degree < 15)
                    {
                        obresetka = 0.5;
                    }
                    else
                    {
                        obresetka = 1;
                    }
                    break;

                case "10":
                    pol_sh = 1;
                    cost_oc = 161;
                    cost_poliestr = 207;
                    cost_pural = 310;
                    cost_texture = 408;
                    sves = 0.25;
                    if (degree < 15)
                    {
                        obresetka = 0.5;
                    }
                    else
                    {
                        obresetka = 1;
                    }
                    break;

                case "11":
                    pol_sh = 1;
                    cost_oc = 195;
                    cost_poliestr = 263;
                    cost_pural = 368;
                    cost_texture = 465;
                    sves = 0.25;
                    if (degree < 15)
                    {
                        obresetka = 0.5;
                    }
                    else
                    {
                        obresetka = 1;
                    }
                    break;

                case "12":
                    pol_sh = 1;
                    cost_oc = 234;
                    cost_poliestr = 311;
                    cost_pural = 320;
                    cost_texture = 419;
                    sves = 0.25;
                    if (degree < 15)
                    {
                        obresetka = 0.5;
                    }
                    else
                    {
                        obresetka = 1;
                    }
                    break;

                case "13":
                    pol_sh = 0.845;
                    cost_oc = 277;
                    cost_poliestr = 367;
                    cost_pural = 476;
                    cost_texture = 581;
                    sves = 0.25;
                    obresetka = 3;
                    break;

                case "14":
                    pol_sh = 0.845;
                    cost_oc = 309;
                    cost_poliestr = 415;
                    cost_pural = 520;
                    cost_texture = 623;
                    sves = 0.25;
                    obresetka = 3;
                    break;

                case "15":
                    pol_sh = 0.845;
                    cost_oc = 347;
                    cost_poliestr = 463;
                    cost_pural = 580;
                    cost_texture = 684;
                    sves = 0.25;
                    obresetka = 3;
                    break;
            }
            if (degree < 15)
            {
                degree_type = 0.2;
            }
            else if (degree < 30)
            {
                degree_type = 0.15;
            }
            else
            {
                degree_type = 0.1;
            }
            var max_length = 6;

            if (roof_type == "1")
            {
                skat_width = Math.Ceiling((house_width / Math.Cos(degree * 0.01745) + sves) * 100);
                skat_width = skat_width / 100;
                var skat_lenght = Convert.ToInt32(house_lenght) + 2 * sves;
                profnastil_list_row = Math.Ceiling(skat_lenght / pol_sh);
                calc_row_obresetka = Math.Ceiling(skat_width / (obresetka + 0.05));
                calc_obresetka = Math.Ceiling(calc_row_obresetka * skat_lenght / 3);
                calc_cost_obresetka = Math.Ceiling(calc_obresetka * 50);
                var skat_S = skat_width * skat_lenght;
                calc_barrier = Math.Ceiling(Convert.ToDouble(barrier.ToString()) * skat_S);
                calc_insulation = Math.Ceiling(Convert.ToDouble(insulation.ToString()) * skat_S);
                if (skat_width < max_length)
                {
                    if (cover == 1)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_oc);
                    }
                    else if (cover == 2)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_poliestr);
                    }
                    else if (cover == 3)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_pural);
                    }
                    else if (cover == 4)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_texture);
                    }
                    total_cost = cost_profnastil + calc_insulation + calc_barrier + calc_cost_obresetka;
                    text = "1";
                }
                else
                {
                    profnastil_lenght = max_length - degree_type;
                    var row = Convert.ToInt32(skat_width / profnastil_lenght) - 1;
                    var last2row = skat_width - row * profnastil_lenght;
                    profnastil_list_max = profnastil_list_row * row;
                    var i = last2row / profnastil_lenght;
                    profnastil_lenght_min = profnastil_lenght;
                    while ((i - Convert.ToInt32(i)) < 0.7)
                    {
                        profnastil_lenght_min = Math.Ceiling((profnastil_lenght_min - 0.5) * 100) / 100;
                        i = last2row / profnastil_lenght_min;
                    }
                    if (cover == 1)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_oc + profnastil_lenght_min * profnastil_list_row * 2 * cost_oc);
                    }
                    else if (cover == 2)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_poliestr + profnastil_lenght_min * profnastil_list_row * 2 * cost_poliestr);
                    }
                    else if (cover == 3)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_pural + profnastil_lenght_min * profnastil_list_row * 2 * cost_pural);
                    }
                    else if (cover == 4)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_texture + profnastil_lenght_min * profnastil_list_row * 2 * cost_texture);
                    }
                    total_cost = cost_profnastil + calc_insulation + calc_barrier + calc_cost_obresetka;
                    text = "2";
                }
            }
            else if (roof_type == "2")
            {
                house_width = house_width / 2;
                skat_width = Math.Ceiling((house_width / Math.Cos(degree * 0.01745) + sves) * 100);
                skat_width = skat_width / 100;
                var skat_lenght = Convert.ToInt32(house_lenght) + 2 * sves;
                profnastil_list_row = Math.Ceiling(skat_lenght / pol_sh);
                calc_row_obresetka = Math.Ceiling(skat_width / (obresetka + 0.05)) * 2;
                calc_obresetka = Math.Ceiling(calc_row_obresetka * skat_lenght / 3);
                calc_cost_obresetka = Math.Ceiling(calc_obresetka * 50);
                var skat_S = skat_width * skat_lenght * 2;
                calc_barrier = Math.Ceiling(Convert.ToDouble(barrier.ToString()) * skat_S);
                calc_insulation = Math.Ceiling(Convert.ToDouble(insulation.ToString()) * skat_S);
                if (skat_width < max_length)
                {
                    if (cover == 1)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_oc * 2);
                    }
                    else if (cover == 2)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_poliestr * 2);
                    }
                    else if (cover == 3)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_pural * 2);
                    }
                    else if (cover == 4)
                    {
                        cost_profnastil = Math.Ceiling(skat_width * profnastil_list_row * cost_texture * 2);
                    }
                    total_cost = cost_profnastil + calc_insulation + calc_barrier + calc_cost_obresetka;
                    text = "3";
                }
                else
                {
                    profnastil_lenght = max_length - degree_type;
                    var row = (Convert.ToInt32(skat_width / profnastil_lenght) - 1) * 2;
                    var last2row = skat_width - row * profnastil_lenght;
                    profnastil_list_max = profnastil_list_row * row;
                    var i = last2row / profnastil_lenght;
                    profnastil_lenght_min = profnastil_lenght;
                    while ((i - Convert.ToInt32(i)) < 0.7)
                    {
                        profnastil_lenght_min = Math.Ceiling((profnastil_lenght_min - 0.5) * 100) / 100;
                        i = last2row / profnastil_lenght_min;
                    }
                    if (cover == 1)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_oc + profnastil_lenght_min * profnastil_list_row * 2 * cost_oc);
                    }
                    else if (cover == 2)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_poliestr + profnastil_lenght_min * profnastil_list_row * 2 * cost_poliestr);
                    }
                    else if (cover == 3)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_pural + profnastil_lenght_min * profnastil_list_row * 2 * cost_pural);
                    }
                    else if (cover == 4)
                    {
                        cost_profnastil = Math.Ceiling(profnastil_lenght * profnastil_list_max * cost_texture + profnastil_lenght_min * profnastil_list_row * 2 * cost_texture);
                    }
                    total_cost = cost_profnastil + calc_insulation + calc_barrier + calc_cost_obresetka;
                    text = "4";
                }
            }
            return text;
        }
    }
}