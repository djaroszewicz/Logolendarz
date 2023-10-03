using LogolendarzFRONT.Models;
using LogolendarzFRONT.Service.IService;
using LogolendarzFRONT.Utility;

namespace LogolendarzFRONT.Service
{
  public class AuthService : IAuthService
  {
    private readonly IBaseService _baseService;
    public AuthService(IBaseService baseService)
    {
      _baseService = baseService;
    }


    public async Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto)
    {
      return await _baseService.SendAsync(new RequestDto()
      {
        ApiType = SD.ApiType.POST,
        Data = registerRequestDto,
        Url = SD.AuthAPIBase + "/api/auth/AssignRole"
      });
    }

    public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
    {
      return await _baseService.SendAsync(new RequestDto()
      {
        ApiType = SD.ApiType.POST,
        Data = loginRequestDto,
        Url = SD.AuthAPIBase + "/api/auth/login"
      });
    }

    public async Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto)
    {
      return await _baseService.SendAsync(new RequestDto()
      {
        ApiType = SD.ApiType.POST,
        Data = registerRequestDto,
        Url = SD.AuthAPIBase + "/api/auth/register"
      });
    }
  }
}
