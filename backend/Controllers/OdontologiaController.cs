using backend.connection;
using backend.entidades;
using backend.servicios;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;
/// <summary>
/// hola
/// </summary>
[EnableCors("DevelopmentCors")]
[ApiController]
[Route("api/[controller]")]
public class OdontologiaController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly string? connectionString;
    /// <summary>
    /// hola
    /// </summary>

    public OdontologiaController(IConfiguration configuration)
    {
        _configuration = configuration;
        connectionString = _configuration["SqlConnectionString:DefaultConnection"];
        BDManager.GetInstance.ConnectionString = connectionString;
    }

    //Muestra la lista de todos los usuarios registrados
    /// <summary>
    /// hola
    /// </summary>

    [HttpGet]
    [Route("GetAllOdontologia")]
    public IActionResult GetAllOdontologia()
    {
        try
        {
            var result = OdontologiaServicios.ObtenerTodo<Odontologia>();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    //insertando los Id muestra el Categoria en una tabla con sus registros
    /// <summary>
    /// hola
    /// </summary>


    [HttpGet]
    [Route("GetOdontologiaById")]
    public IActionResult GetOdontologiaById([FromQuery] int id)
    {
        try
        {
            var result = OdontologiaServicios.ObtenerById<Odontologia>(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    //para Adicionar Registro de Categoria en la base de datos
    /// <summary>
    /// hola
    /// </summary>

    [HttpPost]
    [Route("AddOdontologia")]
    public IActionResult AddOdontologia(Odontologia odontologia)
    {
        try
        {
            var result = OdontologiaServicios.InsertOdontologia(odontologia);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
    /// <summary>
    /// hola
    /// </summary>

    [HttpPut]
    [Route("UpdateOdontologia")]
    public IActionResult UpdateOdontologia(Odontologia odontologia)
    {
        try
        {
            var result = OdontologiaServicios.UpdateOdontologia(odontologia);
            return Ok(result);
        }
        catch (Exception err)
        {
            return StatusCode(500, err.Message);
        }
    }
    /// <summary>
    /// hola
    /// </summary>

    [HttpDelete]
    [Route("DeleteOdontologia")]
    public IActionResult DeleteOdontologia([FromQuery] int id)
    {
        try
        {
            var result = OdontologiaServicios.DeleteOdontologia(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}