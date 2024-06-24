
using System.Net;

var uri = new Uri("ftp://ftp.dlptest.com/");

var request = WebRequest.Create(uri);
request.Credentials = new NetworkCredential("dlpuser", "rNrKYTX9g7z3RgJRmxWuGHbeu");
request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

var response = await request.GetResponseAsync() as FtpWebResponse;
Console.WriteLine($"Status code {response.StatusCode} | {response.StatusDescription}");