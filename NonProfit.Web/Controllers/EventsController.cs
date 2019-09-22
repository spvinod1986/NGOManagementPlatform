using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NonProfit.Application.Events.Queries.GetEventDetail;
using Microsoft.Extensions.DependencyInjection;
using NonProfit.Application.Events.Commands.CreateEvent;

namespace NonProfit.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetService<IMediator>();

        // GET api/events
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "event1", "event2" };
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventDetailModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetEventDetailQuery { EventId = id }));
        }

        // POST api/events
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateEventCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        // PUT api/events/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/events/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
