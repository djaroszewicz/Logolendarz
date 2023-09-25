using LogolendarzFRONT.Models;
using LogolendarzFRONT.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LogolendarzFRONT.Controllers
{
    public class VisitController : Controller
    {
        private readonly IVisitService _visitService;

        public VisitController(IVisitService visitService)
        {
            _visitService = visitService;
        }

        public async Task<IActionResult> VisitIndex()
        {
            List<VisitDto>? list = new();
            ResponseDto? response= await _visitService.GetAllVisitsAsync();

            if(response!=null && response.IsSucces) 
            {
                list = JsonConvert.DeserializeObject<List<VisitDto>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}
