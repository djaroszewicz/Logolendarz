using LogolendarzFRONT.Models;

namespace LogolendarzFRONT.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
