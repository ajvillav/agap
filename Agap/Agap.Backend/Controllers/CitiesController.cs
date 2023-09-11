using Agap.Backend.Interfaces;
using Agap.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Agap.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : GenericController<City>
    {
        public CitiesController(IGenericUnitOfWork<City> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
