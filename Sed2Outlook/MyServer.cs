using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.IO;
using System.Web;

using Microsoft.Win32;

namespace Sed2Outlook.CsHTTPServer
{
    public class MyServer : CsHTTPServer
    {
        public string Folder;

        public MyServer() : base()
        {
            this.Folder = "c:\\EmailAttachSed";
        }

        public MyServer(int thePort, string theFolder) : base(thePort)
        {
            this.Folder = theFolder;
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
        public async Task<string> TaskDownloadFile(string uri, dynamic data)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var httpClient = new HttpClient();
            JObject jsonData = (JObject)JToken.FromObject(data);
            var fileInfo = new FileInfo(data.fileName);
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
            public SedUser creator { get; set; }
            public string internalNumber { get; set; }
            public IList<AttachFileInfo> files { get; set; }

        }

        public override void OnResponse(ref HTTPRequestStruct rq, ref HTTPResponseStruct rp)
        {
            string bodyStr = "";
            string docId = "", token = "", sedSRV = "10.75.113.107:8080"; 
            dynamic postData;

            if (!(rq.Args is null))
            {
                if (rq.Args.ContainsKey("id")) docId = rq.Args["id"].ToString();
                if (rq.Args.ContainsKey("token")) token = rq.Args["token"].ToString();
            }
            

            switch (rq.URL)
            {
                case "/add":
                    
                    try
                    {
                        //postData = string.Format("{{'token': '{0}', 'documentId': '{1}' }}", token, docId);
                        postData = new { token = token, documentId = docId };
                        bodyStr = TaskGetDocAsync("http://"+sedSRV+"/api/document/document", postData).Result; //TODO post args
                        JObject doc = JObject.Parse(bodyStr);
                        Doc2msg docForMsg = doc.ToObject<Doc2msg>();
                        foreach (AttachFileInfo elm in docForMsg.files)
                        {
                            //var tasks = new List<Task>();
                            //tasks.Add(PostAsync(""));
                            //Task.WaitAll(tasks.ToArray());
                            //postData = string.Format("{{'filePath': '{0}', 'fileName': '{1}' }}",  elm.fullPath, elm.name);
                            postData = new { filePath = elm.fullPath, fileName = elm.name };
                            bodyStr += TaskDownloadFile("http://" + sedSRV + "/api/document/downloadFile", postData).Result; //TODO post args
                          
                        }
                        rp.BodyData = Encoding.UTF8.GetBytes(bodyStr);
                    }
                    catch (Exception ex)
                    {
                        bodyStr += "Case add";
                        bodyStr += string.Format("Error: {0}  Message: {1}", ex.HResult.ToString("X"), ex.Message); // TODO check error message

                        rp.BodyData = Encoding.UTF8.GetBytes(bodyStr);
                        //Console.WriteLine("Case add");
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

                    rp.BodyData = Encoding.UTF8.GetBytes(bodyStr);
                    break;
            }

            return;

            string path = this.Folder + "\\" + rq.URL.Replace("/", "\\");

            if (Directory.Exists(path))
            {
                if (File.Exists(path + "index.html"))
                    path += "\\index.html";
                else
                {
                    string[] dirs = Directory.GetDirectories(path);
                    string[] files = Directory.GetFiles(path);

                    bodyStr = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\n";
                    bodyStr += "<HTML><HEAD>\n";
                    bodyStr += "<META http-equiv=Content-Type content=\"text/html; charset=windows-1252\">\n";
                    bodyStr += "</HEAD>\n";
                    bodyStr += "<BODY><p>Folder listing, to do not see this add a 'default.htm' document\n<p>\n";
                    for (int i = 0; i < dirs.Length; i++)
                        bodyStr += "<br><a href = \"" + rq.URL + Path.GetFileName(dirs[i]) + "/\">[" + Path.GetFileName(dirs[i]) + "]</a>\n";
                    for (int i = 0; i < files.Length; i++)
                        bodyStr += "<br><a href = \"" + rq.URL + Path.GetFileName(files[i]) + "\">" + Path.GetFileName(files[i]) + "</a>\n";
                                    }
            }

            if (File.Exists(path))
            {
                RegistryKey rk = Registry.ClassesRoot.OpenSubKey(Path.GetExtension(path), true);

                // Get the data from a specified item in the key.
                String s = (String)rk.GetValue("Content Type");

                // Open the stream and read it back.
                rp.fs = File.Open(path, FileMode.Open);
                if (s != "")
                    rp.Headers["Content-type"] = s;
            }
            else
            {

                rp.status = (int)RespState.NOT_FOUND;

                bodyStr = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\n";
                bodyStr += "<HTML><HEAD>\n";
                bodyStr += "<META http-equiv=Content-Type content=\"text/html; charset=windows-1252\">\n";
                bodyStr += "</HEAD>\n";
                bodyStr += "<BODY>File not found!!</BODY></HTML>\n";

                rp.BodyData = Encoding.ASCII.GetBytes(bodyStr);

            }

        }
    }
}
