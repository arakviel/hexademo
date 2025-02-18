using HexaDemo.Application.Commands;
using HexaDemo.Application.Dtos;
using HexaDemo.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HexaDemo.Presentation.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] StoreProductDto dto)
    {
        await _mediator.Send(new CreateProductCommand(dto));
        return CreatedAtAction(nameof(GetAll), new { }, null);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductDto dto)
    {
        if (id != dto.Id) return BadRequest("ID mismatch");
        
        await _mediator.Send(new UpdateProductCommand(dto));
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _mediator.Send(new DeleteProductCommand(id));
        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllProductsQuery());
        return Ok(result);
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string name)
    {
        var result = await _mediator.Send(new SearchProductsByNameQuery(name));
        return Ok(result);
    }
}