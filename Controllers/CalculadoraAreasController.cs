using Microsoft.AspNetCore.Mvc;

namespace calculadoras.Controllers;

/// <summary>
/// Controlador para calcular áreas de diferentes figuras geométricas
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class CalculadoraAreasController : ControllerBase
{
    private readonly ILogger<CalculadoraAreasController> _logger;

    public CalculadoraAreasController(ILogger<CalculadoraAreasController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Calcula el área de un cuadrado
    /// </summary>
    /// <param name="lado">Longitud del lado del cuadrado</param>
    /// <returns>El área del cuadrado</returns>
    /// <response code="200">Retorna el área calculada</response>
    /// <response code="400">Si el lado es negativo o cero</response>
    [HttpGet("cuadrado")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularAreaCuadrado([FromQuery] double lado)
    {
        if (lado <= 0)
        {
            return BadRequest("El lado debe ser mayor que cero");
        }

        var area = lado * lado;
        return Ok(new { area = area });
    }

    /// <summary>
    /// Calcula el área de un rectángulo
    /// </summary>
    /// <param name="base">Base del rectángulo</param>
    /// <param name="altura">Altura del rectángulo</param>
    /// <returns>El área del rectángulo</returns>
    /// <response code="200">Retorna el área calculada</response>
    /// <response code="400">Si la base o altura son negativas o cero</response>
    [HttpGet("rectangulo")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularAreaRectangulo([FromQuery] double @base, [FromQuery] double altura)
    {
        if (@base <= 0 || altura <= 0)
        {
            return BadRequest("La base y la altura deben ser mayores que cero");
        }

        var area = @base * altura;
        return Ok(new { area = area });
    }

    /// <summary>
    /// Calcula el área de un círculo
    /// </summary>
    /// <param name="radio">Radio del círculo</param>
    /// <returns>El área del círculo</returns>
    /// <response code="200">Retorna el área calculada</response>
    /// <response code="400">Si el radio es negativo o cero</response>
    [HttpGet("circulo")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularAreaCirculo([FromQuery] double radio)
    {
        if (radio <= 0)
        {
            return BadRequest("El radio debe ser mayor que cero");
        }

        var area = Math.PI * radio * radio;
        return Ok(new { area = area });
    }

    /// <summary>
    /// Calcula el área de un triángulo
    /// </summary>
    /// <param name="base">Base del triángulo</param>
    /// <param name="altura">Altura del triángulo</param>
    /// <returns>El área del triángulo</returns>
    /// <response code="200">Retorna el área calculada</response>
    /// <response code="400">Si la base o altura son negativas o cero</response>
    [HttpGet("triangulo")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularAreaTriangulo([FromQuery] double @base, [FromQuery] double altura)
    {
        if (@base <= 0 || altura <= 0)
        {
            return BadRequest("La base y la altura deben ser mayores que cero");
        }

        var area = (@base * altura) / 2;
        return Ok(new { area = area });
    }
} 