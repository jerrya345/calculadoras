using Microsoft.AspNetCore.Mvc;

namespace calculadoras.Controllers;

/// <summary>
/// Controlador para calcular volúmenes de diferentes figuras geométricas
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class CalculadoraVolumenesController : ControllerBase
{
    private readonly ILogger<CalculadoraVolumenesController> _logger;

    public CalculadoraVolumenesController(ILogger<CalculadoraVolumenesController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Calcula el volumen de un cubo
    /// </summary>
    /// <param name="lado">Longitud del lado del cubo</param>
    /// <returns>El volumen del cubo</returns>
    /// <response code="200">Retorna el volumen calculado</response>
    /// <response code="400">Si el lado es negativo o cero</response>
    [HttpGet("cubo")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularVolumenCubo([FromQuery] double lado)
    {
        if (lado <= 0)
        {
            return BadRequest("El lado debe ser mayor que cero");
        }

        var volumen = lado * lado * lado;
        return Ok(new { volumen = volumen });
    }

    /// <summary>
    /// Calcula el volumen de un prisma rectangular
    /// </summary>
    /// <param name="largo">Largo del prisma</param>
    /// <param name="ancho">Ancho del prisma</param>
    /// <param name="alto">Alto del prisma</param>
    /// <returns>El volumen del prisma rectangular</returns>
    /// <response code="200">Retorna el volumen calculado</response>
    /// <response code="400">Si alguna dimensión es negativa o cero</response>
    [HttpGet("prisma-rectangular")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularVolumenPrismaRectangular([FromQuery] double largo, [FromQuery] double ancho, [FromQuery] double alto)
    {
        if (largo <= 0 || ancho <= 0 || alto <= 0)
        {
            return BadRequest("Todas las dimensiones deben ser mayores que cero");
        }

        var volumen = largo * ancho * alto;
        return Ok(new { volumen = volumen });
    }

    /// <summary>
    /// Calcula el volumen de una esfera
    /// </summary>
    /// <param name="radio">Radio de la esfera</param>
    /// <returns>El volumen de la esfera</returns>
    /// <response code="200">Retorna el volumen calculado</response>
    /// <response code="400">Si el radio es negativo o cero</response>
    [HttpGet("esfera")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularVolumenEsfera([FromQuery] double radio)
    {
        if (radio <= 0)
        {
            return BadRequest("El radio debe ser mayor que cero");
        }

        var volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
        return Ok(new { volumen = volumen });
    }

    /// <summary>
    /// Calcula el volumen de un cilindro
    /// </summary>
    /// <param name="radio">Radio de la base del cilindro</param>
    /// <param name="altura">Altura del cilindro</param>
    /// <returns>El volumen del cilindro</returns>
    /// <response code="200">Retorna el volumen calculado</response>
    /// <response code="400">Si el radio o la altura son negativos o cero</response>
    [HttpGet("cilindro")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularVolumenCilindro([FromQuery] double radio, [FromQuery] double altura)
    {
        if (radio <= 0 || altura <= 0)
        {
            return BadRequest("El radio y la altura deben ser mayores que cero");
        }

        var volumen = Math.PI * radio * radio * altura;
        return Ok(new { volumen = volumen });
    }

    /// <summary>
    /// Calcula el volumen de una pirámide
    /// </summary>
    /// <param name="base">Área de la base de la pirámide</param>
    /// <param name="altura">Altura de la pirámide</param>
    /// <returns>El volumen de la pirámide</returns>
    /// <response code="200">Retorna el volumen calculado</response>
    /// <response code="400">Si el área de la base o la altura son negativas o cero</response>
    [HttpGet("piramide")]
    [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularVolumenPiramide([FromQuery] double @base, [FromQuery] double altura)
    {
        if (@base <= 0 || altura <= 0)
        {
            return BadRequest("El área de la base y la altura deben ser mayores que cero");
        }

        var volumen = (@base * altura) / 3.0;
        return Ok(new { volumen = volumen });
    }
} 