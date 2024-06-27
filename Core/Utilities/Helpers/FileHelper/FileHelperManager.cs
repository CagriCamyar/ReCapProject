using Core.Utilities.Helpers.GuidHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath) //filePath CarImageManager'dan gelen dosyanin kaydedildigi adres adi
        {
            if (File.Exists(filePath)) // dosya uzantisinda dosya bulunduysa
            {
                File.Delete(filePath); //buldugun dosyayi sil
            }
            Console.WriteLine("Yanlis bir yol yazdiniz");
        }

        public string Update(IFormFile formFile, string filePath, string root)
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);                
            }
            return Upload(formFile, root);
        }

        public string Upload(IFormFile formFile, string root)
        {
            if(formFile.Length > 0)
            {
                if(!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string existsion = Path.GetExtension(formFile.FileName);
                string guid = GuidHelper.GuidHelper.CreateGuid();
                string filePath = guid + existsion;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    formFile.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }
            return null;
        }
    }
}