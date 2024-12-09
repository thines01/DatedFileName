using System;
using System.IO;
using System.Linq;

namespace DatedFileName
{
    public partial class CDatedFileName
    {
       /// <summary>
       /// Converts 
       ///    "c:/science/data/fred .txt . txt"
       ///    to
       ///    "c:/science/data/fred.txt.20150507161045.txt"
       /// </summary>
       public static FileInfo GetDatedFileName(string strFileName)
       {
         return GetDatedFileName(strFileName, DateTime.Now);
       }

      /// <summary>
      /// Converts 
      ///    "c:/science/data/fred .txt . txt"
      ///    to
      ///    "c:/science/data/fred.txt.20150507161045.txt"
      /// </summary>
      public static FileInfo GetDatedFileName(string strFileName, DateTime dt)
      {
         FileInfo fi = new FileInfo(strFileName);

         string[] arr_strFileParts =
            fi.Name.Split('.').Select(strFilePart => strFilePart.Trim()).ToArray();

         return
            new FileInfo(
               Path.Combine(fi.Directory.FullName,
                  string.Join(".",
                     arr_strFileParts.Reverse().Skip(1).Reverse()
                     .Concat(new string[]
                       {
                           dt.ToString("yyyyMMddHHmmss"),
                           arr_strFileParts.Last()
                       }).ToArray())));
      }
   }
}
