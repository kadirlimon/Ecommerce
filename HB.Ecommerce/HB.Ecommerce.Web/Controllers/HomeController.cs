using HB.Ecommerce.Web.Common.Dto;
using HB.Ecommerce.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HB.Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _environment;
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IHostingEnvironment environment, IHttpClientFactory httpClient)
        {
            _logger = logger;
            this._environment = environment;
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            InputOutputViewModel inputOutputViewModel = GetInputOutputView();
            return View("Index", inputOutputViewModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [NonAction]
        public string ReadFileContent()
        {
            string filename = "inputfile.txt";
            string filePath = Path.Combine(_environment.WebRootPath, "files");
            string fileNameWithPath = Path.Combine(filePath, filename);
            string text = System.IO.File.ReadAllText(fileNameWithPath);
            return text;
        }

        [NonAction]
        public List<string> GetCommandList()
        {
            var readText = ReadFileContent();
            var txtReadCommandList = readText.Split("\r\n");
            var commandList = new List<string>();
            for (int i = 0; i < txtReadCommandList.Length; i++)
                commandList.Add(txtReadCommandList[i]);
            return commandList;
        }

        [NonAction]
        public InputOutputViewModel GetInputOutputView()
        {
            List<string> commandList = GetCommandList();

            InputOutputViewModel inputOutputViewModel = new InputOutputViewModel();
            inputOutputViewModel.Commands = commandList;
            inputOutputViewModel.Outputs = CommandRequests(commandList);
            return inputOutputViewModel;
        }


        public List<OutputData> CommandRequests(List<string> commandList)
        {
            List<OutputData> outputDatas = new List<OutputData>();
            OutputData outputData = new OutputData();

            Task<string> response = null;

            foreach (var command in commandList)
            {
                string[] commandParameters = command.Split(" ");

                switch (commandParameters[0])
                {
                    case "create_product":
                        ProductDto productDto = new ProductDto { ProductCode = commandParameters[1], Price = Convert.ToDecimal(commandParameters[2]), Stock = Convert.ToInt32(commandParameters[3]) };
                        response = Execute("product", productDto, "POST");
                        break;
                    case "create_campaign":
                        CampaignDto campaignDto = new CampaignDto { Name = commandParameters[1], ProductCode = commandParameters[2], Duration = Convert.ToInt32(commandParameters[3]), PriceManipulationLimit = Convert.ToDecimal(commandParameters[4]), TargetSalesCount = Convert.ToDecimal(commandParameters[5]) };
                        response = Execute("campaign", campaignDto, "POST");
                        break;
                    case "get_product_info":
                        response = Execute($"product/productinfo", commandParameters[1], "POST");
                        break;
                    case "increase_time":
                        response = Execute($"home/increasetime/{commandParameters[1]}", null, "POST");
                        break;
                    case "get_campaign_info":
                        response = Execute($"campaign/campaigninfo", commandParameters[1], "POST");
                        break;
                }

                outputDatas.Add(new OutputData { Command = command, Output = response.Result });
            }

            return outputDatas;
        }



        public async Task<string> Execute(string requestUri, object requestParameterObject, string httpMethod)
        {
            var _requestParameterObject = new StringContent(JsonConvert.SerializeObject(requestParameterObject), Encoding.UTF8, "application/json");

            var client = _httpClient.CreateClient("HB_Api");
            HttpResponseMessage httpResponse = null;
            switch (httpMethod)
            {
                case "GET":
                    httpResponse = await client.GetAsync(requestUri);
                    break;
                case "POST":
                    httpResponse = await client.PostAsync(requestUri, _requestParameterObject);
                    break;
                default:
                    break;
            }
            return httpResponse.Content.ReadAsStringAsync().Result;
        }


    }
}
