﻿namespace LogolendarzFRONT.Models
{
  public class RegisterRequestDto
  {
    public string Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string? Role { get; set; }
  }
}
