using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorBlazorQRCodeScanner.Models;
public class MediaDeviceInfo
{
    public required string DeviceId { get; set; }
    public string? GroupId { get; set; }
    public string? Kind { get; set; }
    public string? Label { get; set; }


}
