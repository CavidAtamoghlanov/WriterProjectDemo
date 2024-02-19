using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreDemoProject.Controllers
{
    public class ClassEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44339/api/Default");
            var jsonString = await response.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ClassEmployee>>(jsonString);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(ClassEmployee employee)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(employee);
            var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44339/api/Default", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44339/api/Default/" + id);

            if (response.IsSuccessStatusCode)
            {

                var jsonString = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ClassEmployee>(jsonString);
                return View(values);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> EditEmployee(ClassEmployee employee)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(employee);
            var stringContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44339/api/Default/", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync("https://localhost:44339/api/Default/" + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
