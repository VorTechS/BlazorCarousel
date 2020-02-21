using System;

namespace Components
{
    public class ImageFile
    {
        public string MimeType { get; set; }

        public byte[] FileContent { get; set; }

        public string FileName { get; set; }

        public string Url { get; set; }

        public string Base64Image
        {
            get
            {
                string convertedContent = null;

                if (this.FileContent != null)
                {
                    convertedContent = $"data:{this.MimeType};base64,{Convert.ToBase64String(this.FileContent)}";
                }

                return convertedContent;
            }
        }

    }
}
