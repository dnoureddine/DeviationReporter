//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Windows.Forms;

//namespace DeviationManager.Model
//{
//    public class UploadFile
//    {

//        private FtpWebResponse response;
//        private String password;
//        private String userName;

//        public UploadFile(String userName, String password){
//             this.password=password;
//             this.userName = userName;
//        }

//        //host attribut example =ftp://ftp.deviationmanager.esy.es/test
//        public string UploadFielToFtp(String hostName,String filePath)
//        {
//            try
//            {
//                // Get the object used to communicate with the server.
//                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(new Uri(hostName));
//                request.Method = WebRequestMethods.Ftp.UploadFile;

//                // Add Credentials .
//                request.Credentials = new NetworkCredential(this.userName, this.password);


//                // Copy the contents of the file to the request stream.
//                StreamReader sourceStream = new StreamReader(filePath);
//                byte[] fileContents = File.ReadAllBytes(filePath);
//                sourceStream.Close();
//                request.ContentLength = fileContents.Length;


//                //Begin Streaming
//                Stream requestStream = request.GetRequestStream();
//                requestStream.Write(fileContents, 0, fileContents.Length);
//                requestStream.Close();

//                response = (FtpWebResponse)request.GetResponse();


//                return "uploaded";
//            }
//            catch (WebException webex)
//            {
//                return "Error!, The Attachement Could Not Be Uploaded, Try Again !";     
//            }


//        }


//        //download file
//        public String DownloadFileFTP(String hostName, String fileSave)
//        {
//            try
//            {
//                // Get the object used to communicate with the server.
//                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(new Uri(hostName));
//                request.Method = WebRequestMethods.Ftp.DownloadFile;

//                // Add Credentials .
//                request.Credentials = new NetworkCredential(this.userName, this.password);


//                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

//                Stream responseStream = response.GetResponseStream();
//                FileStream writeStream = new FileStream(fileSave, FileMode.Create);

//                int Length = 32*1024;
//                Byte[] buffer = new Byte[Length];
//                int bytesRead = responseStream.Read(buffer, 0, buffer.Length);

//                while (bytesRead > 0)
//                {
//                    writeStream.Write(buffer, 0, bytesRead);
//                    bytesRead = responseStream.Read(buffer, 0, buffer.Length);
//                }

//                responseStream.Close();
//                writeStream.Close();



//                return "downloaded";
//            }
//            catch (WebException webex)
//            {
//                return "Error!, Download failed, Try Again !";
//            }

//        }


//        //get Image stream
//        public Stream getImageStream(String hostName)
//        {
      
//            try
//            {
//                // Get the object used to communicate with the server.
//                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(new Uri(hostName));
//                request.Method = WebRequestMethods.Ftp.DownloadFile;

//                // Add Credentials .
//                request.Credentials = new NetworkCredential(this.userName, this.password);


//                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

//                Stream responseStream = response.GetResponseStream();


//                return responseStream;
//            }
//            catch (WebException webex)
//            {
//               MessageBox.Show("Download failed!");

//               return null;
//            }
//        }

//        //delete file auf em FTP
//        public String deleteFileFTP(String hostName)
//        {
//            try
//            {
//                // Get the object used to communicate with the server.
//                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(new Uri(hostName));
//                request.Method = WebRequestMethods.Ftp.AppendFile;

//                // Add Credentials .
//                request.Credentials = new NetworkCredential(this.userName, this.password);


//                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

//                Stream responseStream = response.GetResponseStream();

//                responseStream.Close();

//                return "deleted";
//            }
//            catch (WebException webex)
//            {
//                return "Error!, Delete failed, Try Again !";
//            }
//        }

//        //generate file name to save in the DB
//        public String generateFileName(string fileName)
//        {
//            DateTime now = DateTime.Now;

//            String year = now.Year.ToString();
//            String day = now.Day.ToString();
//            String month = now.Month.ToString();
//            String hour = now.Hour.ToString();
//            String minutes = now.Minute.ToString();
//            String second = now.Second.ToString();
//            String miliSecond = now.Millisecond.ToString();

//            return year + day + hour + month + minutes + second + miliSecond + fileName;

//        }


//        /****_____class ****/


//    }
//}
