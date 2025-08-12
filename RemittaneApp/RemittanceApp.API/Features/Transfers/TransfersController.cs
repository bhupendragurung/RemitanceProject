using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemittanceApp.API.Common;
using RemittanceApp.API.Features.Transfers.Calculate;

namespace RemittanceApp.API.Features.Transfers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransfersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TransfersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("calculate")]
        public async Task<ActionResult<ApiResponse<CalculateTransferResponse>>> CalculateTransfer([FromBody] CalculateTransferCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
