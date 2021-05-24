using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.CloudStorage
{
    public class CloudinaryStorage : ICloudStorage
    {
        static Account account = new Account(
            "dgvd7jieo",
            "683812999793247",
            "uo9X-kLusUwKk1drMItbv1fySJI");
        Cloudinary cloudinary = new Cloudinary(account);

        public Uri UploadImage(string file)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@file)
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.Url;
        }
    }
}
