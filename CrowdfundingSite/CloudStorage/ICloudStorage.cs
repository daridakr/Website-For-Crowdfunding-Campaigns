using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite.CloudStorage
{
    public interface ICloudStorage
    {
        Uri UploadImage(string file);
    }
}
