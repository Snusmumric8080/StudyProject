using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using WebApplication6.Scripts;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            
          /*  var time = DateTime.Now;
            ViewBag.Greeting = time;*/
            return View();
        }

        public ViewResult Materials()
        {

            /*  var time = DateTime.Now;
              ViewBag.Greeting = time;*/
            return View();
        }

        public ViewResult Contacts()
        {

            /*  var time = DateTime.Now;
              ViewBag.Greeting = time;*/
            return View();
        }
        public ViewResult ViewEmail()
        {

           
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }
        //4
        public ActionResult FeedBack4(string email, string profnastil_lenght4, string profnastil_list_max4, string profnastil_lenght_min4, string profnastil_list_row4, string calc_row_obresetka4, string calc_obresetka4, string calc_cost_obresetka4, string calc_barrier4, string calc_insulation4, string cost_profnastil4, string total_cost4)
        {
            FeedBack feedback = new FeedBack();
            feedback.Subkject = "Подсчеты";
            feedback.text = String.Format($"<p>Количество материалов:</strong></p>" +
                $"<p>Количество листов длиной <strong>{profnastil_lenght4}</strong> м равно: <strong>{profnastil_list_max4} шт</strong>.</p>" +
                $"<p>Количество листов для двух последних рядов длиной <strong>{profnastil_lenght_min4}</strong> м равно <strong>{profnastil_list_row4} шт</strong>.</p>" +
                $"<p>Количество рядов обрешетки: <strong>{calc_row_obresetka4}</strong>." +
                $"Количество брусков 50х50 длиной 3 м: <strong>{calc_obresetka4} шт</strong>.</p>" +
                $"<br/><p><strong>Стоимость материалов:</strong></p>" +
                $"<p>Стоимость брусьев обрешетки составит: <strong>{calc_cost_obresetka4} рублей</strong>.</p>" +
                $"<p>Стоимость выбранной пароизоляции и гидроизоляции составит: <strong>{calc_barrier4} рублей</strong>.</p>" +
                $"<p>Расчет утеплителя сделан для слоя, толщиной в 200 мм. Его стоимость составит: <strong>{calc_insulation4} рублей</strong>.</p>" +
                $"<p>Стоимость необходимого количества листов профнастила: <strong>{cost_profnastil4} рублей</strong>.</p>" +
                $"<p><strong>Итого стоимость материалов для кровли составит: {total_cost4} рублей</strong>.</p>");
            Emailer.Send(email, feedback.Subkject, feedback.text);
            return RedirectToAction("Index");
        }
            //3
            public ActionResult FeedBack3(string email, string skat_width3, string profnastil_list_row3, string calc_row_obresetka3, string calc_obresetka3, string calc_cost_obresetka3, string calc_barrier3, string calc_insulation3, string cost_profnastil3, string total_cost3)
        {
            FeedBack feedback = new FeedBack();
            feedback.Subkject = "Подсчеты";
            feedback.text = String.Format($"<p>Количество материалов:</strong></p>" +
                $"<p>Поскольку ширина ската меньше максимальной длины листа профнастила, его можно положить в один ряд. " +
                $"Для этого необходимы листы длиной <strong>{skat_width3} м.</strong> в количестве <strong>{profnastil_list_row3} шт</strong>.</p>" +
                $"<p>Количество рядов обрешетки: <strong>{calc_row_obresetka3}</strong>. Количество брусков 50х50 длиной 3 м: <strong>{calc_obresetka3} шт</strong>.</p>" +
                $"<br/><p><strong>Стоимость материалов:</strong></p>" +
                $"<p>Стоимость брусьев обрешетки составит: <strong>{calc_cost_obresetka3} рублей</strong>.</p>" +
                $"<p>Стоимость выбранной пароизоляции и гидроизоляции составит: <strong>{calc_barrier3} рублей</strong>.</p>" +
                $"<p>Расчет утеплителя сделан для слоя, толщиной в 200 мм. Его стоимость составит: <strong>{calc_insulation3} рублей</strong>.</p>" +
                $"<p>Стоимость необходимого количества листов профнастила: <strong>{cost_profnastil3} рублей</strong>.</p>" +
                $"<p><strong>Итого стоимость материалов для кровли составит: {total_cost3} рублей</strong>.</p>");
            Emailer.Send(email, feedback.Subkject, feedback.text);
            return RedirectToAction("Index");
        }
        //2
        public ActionResult FeedBack2(string email, string profnastil_lenght2, string profnastil_list_max2, string profnastil_lenght_min2, string profnastil_list_row2, string Calc_row_obresetka2, string Calc_obresetka2, string Calc_cost_obresetka2, string calc_barrier2, string Calc_insulation2, string Cost_profnastil2, string Total_cost2)
        {
            FeedBack feedback = new FeedBack();
            feedback.Subkject = "Подсчеты";
            feedback.text = String.Format($"<p>Количество материалов:</strong></p>" +
                $"<p>Количество листов длиной <strong>{profnastil_lenght2}</strong> м равно: <strong>{profnastil_list_max2} шт</strong>.</p>" +
                $"<p>Количество листов для двух последних рядов длиной <strong>{profnastil_lenght_min2}</strong> м равно <strong>{profnastil_list_row2}+'шт</strong>.</p>" +
                $"<p>Количество рядов обрешетки: <strong>{Calc_row_obresetka2}</strong>. Количество брусков 50х50 длиной 3 м: <strong>{Calc_obresetka2} шт</strong>.</p>" +
                $"<br/><p><strong>Стоимость материалов:</strong></p>" +
                $"<p>Стоимость брусьев обрешетки составит: <strong>{Calc_cost_obresetka2} рублей</strong>.</p>" +
                $"<p>Стоимость выбранной пароизоляции и гидроизоляции составит: <strong>{calc_barrier2} рублей</strong>.</p>" +
                $"<p>Расчет утеплителя сделан для слоя, толщиной в 200 мм. Его стоимость составит: <strong>{Calc_insulation2} рублей</strong>.</p>" +
                $"<p>Стоимость необходимого количества листов профнастила: <strong>{Cost_profnastil2} рублей</strong>.</p>" +
                $"<p><strong>Итого стоимость материалов для кровли составит: {Total_cost2} рублей</strong>.</p>");
            Emailer.Send(email, feedback.Subkject, feedback.text);
            return RedirectToAction("Index");
        }

        //1
            public ActionResult FeedBack(string email, string Skat_width1, string Profnastil_list_row1, string Calc_row_obresetka1, string Calc_obresetka1, string Calc_cost_obresetka1, string calc_barrier1, string Calc_insulation1, string Cost_profnastil1, string Total_cost1)
        { 
            FeedBack feedback = new FeedBack();
            feedback.Subkject = "Подсчеты";
            feedback.text = String.Format($"<p> Количество материалов:</strong></p><p>" +
                $"Поскольку ширина ската меньше максимальной длины листа профнастила, его можно положить в один ряд. Для этого необходимы листы длиной <strong>{Skat_width1} м.</strong> в количестве <strong>{Profnastil_list_row1} шт</strong>.</p>" +
                $"<p>Количество рядов обрешетки: <strong>{Calc_row_obresetka1}</strong>. Количество брусков 50х50 длиной 3 м: <strong>{Calc_obresetka1} шт</strong>.</p>" +
                $"<br/><p><strong>Стоимость материалов:</strong></p>" +
                $"<p>Стоимость брусьев обрешетки составит: <strong>{Calc_cost_obresetka1}рублей</strong>.</p><p>Стоимость выбранной пароизоляции и гидроизоляции составит: <strong>{calc_barrier1}рублей</strong>.</p>" +
                $"<p>Расчет утеплителя сделан для слоя, толщиной в 200 мм. Его стоимость составит: <strong>{Calc_insulation1} рублей</strong>.</p><p>Стоимость необходимого количества листов профнастила: <strong>{Cost_profnastil1} рублей</strong>.</p>" +
                $"<br/><p><strong>Итого стоимость материалов для кровли составит: {Total_cost1} рублей</strong>.</p> ");
            Emailer.Send(email, feedback.Subkject, feedback.text);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ViewResult PostEntry(string roof_type, double house_length, double house_width, double degree, double cover, string profnastil, string barrier, string insulation)
        {
            Calс calс = new Calс();
           string text = calс.Сalculation(roof_type, house_length, house_width, degree, cover, profnastil, barrier, insulation);
            switch (text)
            {
                case "1":
                    ViewBag.Skat_width = calс.skat_width;
                    ViewBag.Profnastil_list_row = calс.profnastil_list_row;
                    ViewBag.Calc_row_obresetka = calс.calc_row_obresetka;
                    ViewBag.Calc_obresetka = calс.calc_obresetka;
                    ViewBag.Calc_cost_obresetka = calс.calc_cost_obresetka;
                    ViewBag.Calc_barrier = calс.calc_barrier;
                    ViewBag.Calc_insulation = calс.calc_insulation;
                    ViewBag.Cost_profnastil = calс.cost_profnastil;
                    ViewBag.Total_cost = calс.total_cost;
                
                    return View("~/Views/Home/PostEntry1.cshtml");
                case "2":
                    ViewBag.Skat_width = calс.skat_width;
                    ViewBag.Profnastil_list_row = calс.profnastil_list_row;
                    ViewBag.Calc_row_obresetka = calс.calc_row_obresetka;
                    ViewBag.Calc_obresetka = calс.calc_obresetka;
                    ViewBag.Calc_cost_obresetka = calс.calc_cost_obresetka;
                    ViewBag.Calc_barrier = calс.calc_barrier;
                    ViewBag.Calc_insulation = calс.calc_insulation;
                    ViewBag.Cost_profnastil = calс.cost_profnastil;
                    ViewBag.Total_cost = calс.total_cost;

                    return View("~/Views/Home/PostEntry2.cshtml");
                case "3":
                    ViewBag.Skat_width = calс.skat_width;
                    ViewBag.Profnastil_list_row = calс.profnastil_list_row;
                    ViewBag.Calc_row_obresetka = calс.calc_row_obresetka;
                    ViewBag.Calc_obresetka = calс.calc_obresetka;
                    ViewBag.Calc_cost_obresetka = calс.calc_cost_obresetka;
                    ViewBag.Calc_barrier = calс.calc_barrier;
                    ViewBag.Calc_insulation = calс.calc_insulation;
                    ViewBag.Cost_profnastil = calс.cost_profnastil;
                    ViewBag.Total_cost = calс.total_cost;

                    return View("~/Views/Home/PostEntry3.cshtml");
                case "4":
                    ViewBag.Skat_width = calс.skat_width;
                    ViewBag.Profnastil_list_row = calс.profnastil_list_row;
                    ViewBag.Calc_row_obresetka = calс.calc_row_obresetka;
                    ViewBag.Calc_obresetka = calс.calc_obresetka;
                    ViewBag.Calc_cost_obresetka = calс.calc_cost_obresetka;
                    ViewBag.Calc_barrier = calс.calc_barrier;
                    ViewBag.Calc_insulation = calс.calc_insulation;
                    ViewBag.Cost_profnastil = calс.cost_profnastil;
                    ViewBag.Total_cost = calс.total_cost;

                    return View("~/Views/Home/PostEntry4.cshtml");

            }
            return View("~/Views/Home/Index.cshtml");   
        }
        public JsonResult GetData()
        {
            // создадим список данных
            List<Station> stations = new List<Station>();
            stations.Add(new Station()
            {
                Id = 1,
                PlaceName = "Монте-аво",
                GeoLat = 51.544902,
                GeoLong = 46.021941,
                Traffic = 1.0
            });
            return Json(stations, JsonRequestBehavior.AllowGet);
        }
    }
}