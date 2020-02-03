namespace Prospa.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Prospa.Data.Entities;
    using Prospa.Services.Services;
    using Prospa.ViewModels;
    using System;

    [Route("api/[controller]")]
    public class LoanController : Controller
    {
        private readonly ILoanService loanService;
        private readonly IMapper mapper;

        public LoanController(ILoanService loanService, IMapper mapper)
        {
            this.loanService = loanService;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody]BusinessViewModel viewModel)
        {
            try
            {
                var business = this.mapper.Map<Business>(viewModel);
                return this.Ok(this.loanService.Process(business));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}