using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Download;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Upload;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;

namespace ProductJsonGen
{
    class Sync
    {
        public static string folderID = "0B3r82ekCjep0c1oxdmU0VEFxajQ"; // папка на гугл диске
        public static string ApplicationName = "My Project";
        public static string pathToDownloadFolder = @"Download\";
        public static string pathFilesForUpload= @"JsonData\";

        static string clientId = "815775364489-bae6i9q49059krf61bbuvvmvun8p2ssm.apps.googleusercontent.com";      // From https://console.developers.google.com
        static string clientSecret = "z9bGUQLr0NIHnccs6htp5BX0";          // From https://console.developers.google.com
        static string apiKey = "AIzaSyDp0WGS2OYzEr3K2rgzAEse5t0As7wmqt4";  // from https://console.developers.google.com (Public API access)

        /*
         * функция для аутентификации 
         * public == true   - нет возможности создания файлов
         * public == true   - можно создавать файлы
         * */
        public static DriveService getService(bool _public = true)
        {
            DriveService service;
            if (_public)
            {
                service = new DriveService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,  // from https://console.developers.google.com (Public API access)
                    ApplicationName = "My Project",
                });
            }
            else
            {
                string[] scopes = new string[] { DriveService.Scope.Drive,
                                     DriveService.Scope.DriveFile};


                // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%
                UserCredential credential =
                            GoogleWebAuthorizationBroker
                                          .AuthorizeAsync(new ClientSecrets
                                          {
                                              ClientId = clientId,
                                              ClientSecret = clientSecret
                                          }
                                                          , scopes
                                                          , "SingleUser"
                                                          , CancellationToken.None
                                                          , new FileDataStore("Daimto.GoogleDrive.Auth.Store")
                                                          ).Result;

                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
            }
            return service;
        }

        public static bool upload()
        {
            var service = getService(false);
            string[] uploadFiles = System.IO.Directory.GetFiles(pathFilesForUpload);
            bool status = true;
            foreach(var i in uploadFiles)
            {
                bool uplStatus = uploadFile(service, i, "");
                if (!uplStatus)
                    status = false;
            }
            Console.WriteLine("upload: {0}", status);
            return status;
        }

        [STAThread]
        public static bool run()
        {

            // Create Drive API service.
            var service = getService(false);
            bool status = true;
            string[] fileNameList = { "product.json", "recipe.json", "categoryrecipe.json", "category.json" };
            List<File> fileList = new List<File>();
            foreach (var i in fileNameList)
            {
                fileList.Add(getFileIdFromFileName(service, i));
            }


            for (int i = 0; i < fileNameList.Length; i++)
            {
                bool _res = downloadFile(service, fileList[i].Id, pathToDownloadFolder + fileNameList[i]);
                if (!_res)
                    status = false;
            }


            Console.WriteLine("download status {0}", status);
            return status;
        }



       

        public static File getFileIdFromFileName(DriveService service, string fileName)
        {
            try {
                // Define parameters of request.
                FilesResource.ListRequest listRequest = service.Files.List();
                listRequest.Q = "('" + folderID + "' in parents) and (name = '" + fileName + "')";
                listRequest.PageSize = 10;

                // List files.
                FileList filesFeed = listRequest.Execute();
                if (filesFeed.Files.Count > 0)
                    return filesFeed.Files[0];
                else
                    return null;
            } catch (Exception e)
            {
                return null;
            }
        }

        public static IList<File> GetFiles(DriveService service)
        {
            IList<File> Files = new List<File>();
            try
            {
                // Define parameters of request.
                FilesResource.ListRequest listRequest = service.Files.List();
                listRequest.Q = "'" + folderID + "' in parents";
                listRequest.PageSize = 10;
                //listRequest.Fields = "nextPageToken, files(id, name, WebContentLink)";

                // List files.
                FileList filesFeed = listRequest.Execute();

                Files = filesFeed.Files;
            }
            catch (Exception ex)
            {
                // In the event there is an error with the request.
                Console.WriteLine(ex.Message);
            }
            return Files;
        }

        //функция скачивания файлов
        public static Boolean downloadFile(DriveService _service, string fileId, string _saveTo)
        {
            var request = _service.Files.Get(fileId);
            using (var memoryStream = new System.IO.MemoryStream())
            {

                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Completed:
                            Console.WriteLine("download complete");
                            break;
                        case DownloadStatus.Failed:
                            Console.WriteLine("download failed");
                            break;
                    }
                };
                request.Download(memoryStream);
                using (var fileStream = new System.IO.FileStream(_saveTo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    fileStream.Write(memoryStream.GetBuffer(), 0, memoryStream.GetBuffer().Length);
                }
            }
            return true;
        }

        // функция загрузки и обновления файла на дисk
        public static bool uploadFile(DriveService _service, string filePath, string contentType)
        {
            string fileName = System.IO.Path.GetFileName(filePath);
            var fileMetaData = new File();
            fileMetaData.Name = fileName;
            fileMetaData.Parents = new List<string> { folderID };
            IUploadProgress progress;
            FilesResource.CreateMediaUpload crtRequest;
            FilesResource.UpdateMediaUpload updRequest;

            File existFile = getFileIdFromFileName(_service, fileName);

            using (var fileStream = new System.IO.FileStream(filePath, System.IO.FileMode.Open))
            {
                if (existFile != null)
                {
                    existFile.Name = null;
                    updRequest = _service.Files.Update(new File(), existFile.Id, fileStream, contentType);
                    progress = updRequest.Upload();
                }
                else
                {
                    crtRequest = _service.Files.Create(fileMetaData, fileStream, contentType);
                    progress = crtRequest.Upload();
                }

            }

            return (progress.Status == UploadStatus.Completed) ? true : false;
        }


    }
}



