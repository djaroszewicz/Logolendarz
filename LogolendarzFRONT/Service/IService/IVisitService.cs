using LogolendarzFRONT.Models;

namespace LogolendarzFRONT.Service.IService
{
    public interface IVisitService
    {
        Task<ResponseDto?> GetVisitByIdAsync(int VisitId);
        Task<ResponseDto?> GetAllVisitsAsync();
        Task<ResponseDto?> CreateVisitAsync(VisitDto visitDto);
        Task<ResponseDto?> UpdateVisitAsync(VisitDto visitDto);
        Task<ResponseDto?> DeleteVisitAsync(int VisitId);
    }
}
