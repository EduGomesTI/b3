using System.Net.Mime;
using B3.DesafioTecnico.Application.ToDos.Interfaces;
using B3.DesafioTecnico.Application.ToDos.Requests;
using B3.DesafioTecnico.Application.ToDos.Responses;
using Microsoft.AspNetCore.Mvc;

namespace B3.DeafioTecnico.API.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1", Deprecated = false)]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ToDoController : ControllerBase
    {

        #region Properties

        private readonly IToDoService _service;

        #endregion

        #region Constructors

        public ToDoController(IToDoService service)
        {
            _service = service;
        }

        #endregion

        #region Endpoints

        [HttpPost("addToDo")]
        [ProducesResponseType(typeof(ToDoAddResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> AddToDo([FromBody] ToDoAddRequest request, CancellationToken cancellationToken)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _service.AddAsync(request, cancellationToken);
            if(result.Success)
            {
                return Ok(result);
            }
            else if(result.Messages.Count > 0)
            {
                return BadRequest(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpPatch("updateToDo")]
        [ProducesResponseType(typeof(ToDoUpdateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> UpdateToDo([FromBody] ToDoUpdateRequest request, CancellationToken cancellationToken)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _service.UpdateAsync(request, cancellationToken);
            if(result.Success)
            {
                return Ok(result);
            }
            else if(result.Messages.Count > 0)
            {
                return BadRequest(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(ToDoDeleteResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> DeleteToDo([FromBody] ToDoDeleteRequest request, CancellationToken cancellationToken)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _service.DeleteAsync(request, cancellationToken);
            if(result.Success)
            {
                return Ok(result);
            }
            else if(result.Messages.Count > 0)
            {
                return BadRequest(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpGet("toDo/{id}")]
        [ProducesResponseType(typeof(ToDoFindByIdResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> FindByIdToDo(int id, CancellationToken cancellationToken)
        {
            var request = new ToDoFindByIdRequest() { Id = id };

            var result = await _service.FindByIdAsync(request, cancellationToken);
            if(result.Success)
            {
                return Ok(result);
            }
            else if(result.Messages.Count > 0)
            {
                return BadRequest(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpGet("toDo")]
        [ProducesResponseType(typeof(ToDoFindByIdResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> FindAllToDo(CancellationToken cancellationToken)
        {
            var result = await _service.FindAllAsync(cancellationToken);
            if(result.Success)
            {
                return Ok(result);
            }
            else if(result.Messages.Count > 0)
            {
                return BadRequest(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        #endregion
    }
}
