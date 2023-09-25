﻿using System.Security.AccessControl;
using static LogolendarzFRONT.Utility.SD;

namespace LogolendarzFRONT.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
