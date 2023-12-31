﻿using Agap.Backend.Interfaces;
using Agap.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Agap.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FertilizersController : GenericController<Fertilizer>
    {
        public FertilizersController(IGenericUnitOfWork<Fertilizer> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
