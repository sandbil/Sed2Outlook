using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using OutLook = Microsoft.Office.Interop.Outlook;

using Microsoft.Win32;

namespace Sed2Outlook.CsHTTPServer
{
    public class MyServer : CsHTTPServer
    {
        public string Folder;
        public string serverSed;
        OutLook.Application outlookObj = null;
        OutLook.MAPIFolder root = null;
        OutLook.MailItem mailItem = null;

        public MyServer() : base()
        {
            this.Folder = "c:\\EmailAttachSed";
            this.serverSed =  "10.75.113.107:8080";
        }

        public MyServer(int thePort, string sedSRV) : base(thePort)
        {
            this.serverSed = sedSRV;
        }

        public async Task<String> TaskGetDocAsync(string uri, dynamic data)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var httpClient = new HttpClient();
            JObject jsonData = (JObject)JToken.FromObject(data);
            using (var content = new StringContent(jsonData.ToString(), System.Text.Encoding.UTF8, "application/json"))
                response = await httpClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            return await response.Content.ReadAsStringAsync();
            //if (result.StatusCode == System.Net.HttpStatusCode.Created)
            //    return await response.Content.ReadAsStringAsync();
            //string returnValue = result.Content.ReadAsStringAsync().Result;
            //throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");


        }
        public async Task<string> TaskDownloadFile(string uri, dynamic data, DirectoryInfo tempFolder)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var httpClient = new HttpClient();
            JObject jsonData = (JObject)JToken.FromObject(data);
            string targetPath = Path.Combine(tempFolder.FullName, data.fileName);
            var fileInfo = new FileInfo(targetPath);
            using (var content = new StringContent(jsonData.ToString(), System.Text.Encoding.UTF8, "application/json"))
                response = await httpClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();
            using (var ms = await response.Content.ReadAsStreamAsync())
            {
                using (var fs = File.Create(fileInfo.FullName))
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.CopyTo(fs);
                }
            }
            httpClient.Dispose();
            response.Dispose();

            return fileInfo.FullName;
        }

        public class SedUser
        {
            public string id { get; set; }
            public string surname { get; set; }
            public string name { get; set; }
            public string patronymic { get; set; }
            public string departmentId { get; set; }
            public string departmentName { get; set; }
            public string position { get; set; }
            public string role { get; set; }
            public string headRole { get; set; }
            public string isController { get; set; }
        }

        public class AttachFileInfo
        {
            public string id { get; set; }
            public string name { get; set; }
            public string localPath { get; set; }
            public string fullPath { get; set; }
            public int type { get; set; }
            public bool isSign { get; set; }
            public string fileId { get; set; }
            public string userId { get; set; }
            public string dateTime { get; set; }
            public string topLeftX { get; set; }
            public string topLeftY { get; set; }
            public string width { get; set; }
            public string height { get; set; }
            public string page { get; set; }
            public string isMultiplyPageSigning { get; set; }
            public string multiplyPageSigningItems { get; set; }
        }

    public class Doc2msg
        {
            public string guid { get; set; }
            public string summary { get; set; }
            public string comment { get; set; }
            public DateTime dateInternalRegistration { get; set; }
            public SedUser creator { get; set; }
            public string internalNumber { get; set; }
            public IList<AttachFileInfo> files { get; set; }

        }

        public void ReleaseCOMObjects()
        {
            if (outlookObj != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookObj);
            if (mailItem != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(mailItem);

            // The internet said do this and it works so it's here
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public override void OnResponse(ref HTTPRequestStruct rq, ref HTTPResponseStruct rp)
        {
            string bodyStr = "";
            string docId = "", token = ""; 

            dynamic postData;
            string headPage = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\n";
            headPage += "<HTML><HEAD>\n";
            headPage += "<META http-equiv=Content-Type content=\"text/html; charset=utf-8\">\n";
            headPage += "</HEAD>\n";
            bodyStr += "<BODY><p>Сервис создания почтовых сообщений из документов СЭД\n<p>\n";
            bodyStr += "</BODY></HTML>\n";

            if (!(rq.Args is null))
            {
                if (rq.Args.ContainsKey("id")) docId = rq.Args["id"].ToString();
                if (rq.Args.ContainsKey("token")) token = rq.Args["token"].ToString();
            }
            

            switch (rq.URL)
            {
                case "/add":

                    var tempFolder = new DirectoryInfo(Path.Combine(Paths.Temp, Path.GetRandomFileName()));
                    tempFolder.Create();
                    try
                    {
                        outlookObj = new OutLook.Application();
                        root = outlookObj.Session.DefaultStore.GetRootFolder();
                        mailItem = outlookObj.CreateItem(OutLook.OlItemType.olMailItem) as OutLook.MailItem;

                        postData = new { token = token, documentId = docId };
                        string docJsonStr = TaskGetDocAsync("http://" + this.serverSed + "/api/document/document", postData).Result; 
                        JObject doc = JObject.Parse(docJsonStr);
                        Doc2msg docForMsg = doc.ToObject<Doc2msg>();

                        string pattern = @"([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)";
                        Regex rgx = new Regex(pattern);
                        if (docForMsg.comment != null)
                        foreach (Match match in rgx.Matches(docForMsg.comment))
                            mailItem.To = mailItem.To + "; " + match.Value;

                        mailItem.Subject = "№ " + docForMsg.internalNumber + " от " + docForMsg.dateInternalRegistration.ToShortDateString();
                        //mailItem.Body = mailItem.Subject + "\n" + "Краткое содержание: " + docForMsg.summary;

                        foreach (AttachFileInfo elm in docForMsg.files)
                        {
                            //var tasks = new List<Task>();
                            //tasks.Add(PostAsync(""));
                            //Task.WaitAll(tasks.ToArray());

                            postData = new { filePath = elm.fullPath, fileName = elm.name };
                            string downloadFile = TaskDownloadFile("http://" + this.serverSed + "/api/document/downloadFile", postData, tempFolder).Result;
                            mailItem.Attachments.Add(downloadFile, 1, 1, elm.name);

                        }

                        mailItem.Display(true);
                        //mailItem.Send();

                        rp.Headers["Access-Control-Allow-Origin"] = rq.Headers["Origin"];
                        rp.Headers["Content-Type"] = "application/json; charset=utf-8";
                        rp.BodyData = Encoding.UTF8.GetBytes("{\"result\":true, \"msg\":\"\"}");
                    }
                    catch (Exception ex)
                    {
                        //bodyStr = headPage +  "<BODY><p>" + string.Format("Error: {0}  Message: {1}", ex.HResult.ToString("X"), ex.Message) + "<p>\n";
                        //bodyStr += "</BODY></HTML>\n";
                        rp.status = (int)RespState.SRV_ERR;
                        rp.Headers["Access-Control-Allow-Origin"] = rq.Headers["Origin"];
                        rp.Headers["Content-Type"] = "application/json; charset=utf-8";
                        rp.BodyData = Encoding.UTF8.GetBytes("{\"result\":false, \"error\":\"" + ex.HResult.ToString("X") + "\",\"msg\":\"" + ex.Message + "\"}");
                    }
                    finally
                    {
                        tempFolder.Delete(true);
                        ReleaseCOMObjects();
                    }
                    break;
                case "/status":
                    Console.WriteLine("Case 2");
                    break;
                default:
                    bodyStr = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\n";
                    bodyStr += "<HTML><HEAD>\n";
                    bodyStr += "<META http-equiv=Content-Type content=\"text/html; charset=utf-8\">\n";
                    bodyStr += "</HEAD>\n";
                    bodyStr += "<BODY><p>Сервис создания почтовых сообщений из документов СЭД\n<p>\n";
                    bodyStr += "</BODY></HTML>\n";
                    rp.Headers["Content-Type"] = "text/html; charset=utf-8";
                    rp.BodyData = Encoding.UTF8.GetBytes(bodyStr);
                    break;
            }
            return;
        }
    }
}
