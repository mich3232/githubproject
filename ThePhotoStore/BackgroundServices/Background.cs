using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.Storage;
using Windows.UI.Notifications;

namespace BackgroundServices
{
    public sealed class Background : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral deferral = taskInstance.GetDeferral();
            writeTextToFile();
            deferral.Complete();
        }
        private async void writeTextToFile()
        {
            StorageFolder sF = KnownFolders.DocumentsLibrary;
            StorageFile seF = await sF.CreateFileAsync("Background.txt", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(seF, "Hi, I am your background task text!");
            sendToastNotification("Background services file was created.");

        }
        public void sendToastNotification(string message)
        {
            ToastTemplateType ttT = ToastTemplateType.ToastText01;
            XmlDocument tXml = ToastNotificationManager.GetTemplateContent(ttT);
            XmlNodeList xtE = tXml.GetElementsByTagName("text");
            xtE[0].AppendChild(tXml.CreateTextNode(message));
            ToastNotification toast = new ToastNotification(tXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

    }
}
