using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraper
{
    public partial class Form1 : Form
    {

        public string siteUrl;
        string baseURL;
        public StringBuilder resultBuilder = new StringBuilder();
        string outputFilePath = @"C:\Users\yippy\source\outputTest.csv";

        public List<Result> Results { get; set; } = new List<Result>();

        public Form1()
        {
            InitializeComponent();

            siteUrl = txtURL.Text;
            
        }

        private void btnStartScrape_Click(object sender, EventArgs e)
        {
            siteUrl = txtURL.Text;
            if(!string.IsNullOrWhiteSpace(txtStartPage.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                //remove querystring if exists
                int index = siteUrl.IndexOf("?");
                if (index > 0)
                    siteUrl = siteUrl.Substring(0, index);

                for(var i = int.Parse(txtStartPage.Text); i <= int.Parse(textBox2.Text); i++)
                {
                    var pagedSiteUrl = $"{siteUrl}?page={i}";
                    ScrapeWebsite(pagedSiteUrl);
                }
            }
            else
            {
                ScrapeWebsite(siteUrl);
            }
           
        }


        internal async void ScrapeWebsite(string url)
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage request = await httpClient.GetAsync(url);
            cancellationToken.Token.ThrowIfCancellationRequested();

            Stream response = await request.Content.ReadAsStreamAsync();
            cancellationToken.Token.ThrowIfCancellationRequested();

            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(response);

            baseURL = new Uri(url).Host;

            GetScrapeResults(document);
        }


        private void GetScrapeResults(IHtmlDocument document)
        {
            IEnumerable<IElement> courseLinks;


            courseLinks = document.All.Where(x => x.ClassName == "studentHeaderLink");

            if (courseLinks.Any())
            {
                // Print Results: See Next Step
                PrintResults(courseLinks);
            }
        }

        public void PrintResults(IEnumerable<IElement> courseLinks)
        {
            // Clean Up Results: See Next Step
            foreach(var result in courseLinks)
            {
                CustomClean(result);
            }

            WriteToCSV(Results);

        }


        private void CustomClean(IElement result)
        {

            var courseTitle = ((AngleSharp.Html.Dom.HtmlElement)result).Title;
            var courseUrl = result.GetAttribute("href");

            Results.Add(new Result
            {
                CourseName = courseTitle,
                CourseURL = baseURL + courseUrl
            });

            resultBuilder.Append("CourseTitle: " + courseTitle);
            resultBuilder.AppendLine();
            resultBuilder.Append("Course URL: " + baseURL + courseUrl);

            resultBuilder.AppendLine();

            resultsTextbox.Text = resultBuilder.ToString();

        }

        private void WriteToCSV(List<Result> results)
        {
            using (var writer = new StreamWriter(outputFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.CurrentCulture))
            {
                csv.WriteRecords(results);
            }
        }



        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(outputFilePath);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(outputFilePath)
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
