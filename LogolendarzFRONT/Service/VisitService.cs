using LogolendarzFRONT.Models;
using LogolendarzFRONT.Service.IService;
using LogolendarzFRONT.Utility;

namespace LogolendarzFRONT.Service
{
    public class VisitService : IVisitService
    {

        private readonly IBaseService _baseService;
        public VisitService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateVisitAsync(VisitDto visitDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = visitDto,
                Url = SD.VisitAPIBase + "/api/visitAPI"
            });
        }

        public async Task<ResponseDto?> DeleteVisitAsync(int visitId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.VisitAPIBase + "/api/visitAPI/" + visitId
            });
        }

        public async Task<ResponseDto?> GetAllVisitsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.VisitAPIBase + "/api/visitAPI"
            });
        }

        public async Task<ResponseDto?> GetVisitByIdAsync(int visitId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.VisitAPIBase + "/api/visitAPI/" + visitId
            });
        }

        public async Task<ResponseDto?> UpdateVisitAsync(VisitDto visitDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = visitDto,
                Url = SD.VisitAPIBase + "/api/visitAPI"
            });
        }
    }
}
