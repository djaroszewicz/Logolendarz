﻿namespace LogolendarzFRONT.Models
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSucces { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
