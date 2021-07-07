using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OutlookHandler outlookHandler = new OutlookHandler();
            // recipient and attachmentPath can either be strings or List<string>s - attachmentPath is optional
            outlookHandler.SendMail("testC#", "test msg from C#", "sandbil@ya.ru");

            

            dynamic oApp;
            dynamic oMsg;
            dynamic oAttachs;
            dynamic oAttach;

            oApp = Activator.CreateInstance(Type.GetTypeFromProgID("Outlook.Application"));

            oMsg = oApp.CreateItem(0);
            //oMsg.Display(false);

            oMsg.To = "sandbil@ya.ru";
            oMsg.Subject = "This is the subject";
            oMsg.Body = "This is the body без предупр";

            oAttachs = oMsg.Attachments;
            // for (int i = 0; i < sAttachments.Length; i++)
            // {
            //     oAttach = oAttachs.Add(sAttachments[i], Type.Missing, oMsg.Body.Length + 1, sAttachments[i]);
            // }
            //oMsg.Display();
            

            oMsg.Send();
        }
    }
}
