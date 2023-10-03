using LogolendarzFRONT.Models;

namespace LogolendarzFRONT.Service.IService
{
  public interface IAuthService
  {
    Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
    Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto);
    Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto);
  }
}
