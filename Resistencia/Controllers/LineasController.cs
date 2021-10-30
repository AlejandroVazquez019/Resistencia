using Microsoft.AspNetCore.Mvc;
using System;
using Practica1.Resistencia.Domain.Entities;

/* 
    Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Servicios

    Nombre del Maestro: Joel Ivan Chuc Uc

    Nombre de la actividad: Actividad 2 (Unidad ll)

    Nombre del alumno: José Alejandro Vázquez Suaste

    Cuatrimestre: 4    Grupo: A    Parcial: 2
*/

namespace Practica1.Resistencia.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class LineasController : ControllerBase
    {
        [HttpGet]
        [Route("Calcular")]

        public IActionResult Lineas(string _Linea1, string _Linea2, string _Linea3, string _Linea4)

        {
            var rest = new Colores();

            rest.Lineauno(_Linea1);

            if(_Linea1.ToLower()!= "naranja" && _Linea1.ToLower() != "negro" && _Linea1.ToLower() != "violeta" 
            && _Linea1.ToLower() != "blanco" && _Linea1.ToLower() != "azul" &&_Linea1.ToLower() != "verde" 
            &&_Linea1.ToLower() != "gris" && _Linea1.ToLower()!= "amarillo" && _Linea1.ToLower() != "cafe" 
            && _Linea1.ToLower() != "rojo")

            {
                return Ok( "El color de la Linea 1 es INCORRECTO");
            }

            rest.Lineados(_Linea2);

            if(_Linea2.ToLower()!= "naranja" && _Linea2.ToLower() != "negro" && _Linea2.ToLower() != "violeta" 
            && _Linea2.ToLower() != "blanco" && _Linea2.ToLower() != "azul" &&_Linea2.ToLower() != "verde" 
            &&_Linea2.ToLower() != "gris" && _Linea2.ToLower()!= "amarillo" && _Linea2.ToLower() != "cafe" 
            && _Linea2.ToLower() != "rojo")
            
            {
                return Ok( "El color de la Linea 2 es INCORRECTO");
            }

            rest.Lineatres(_Linea3);

            if(_Linea3.ToLower() != "naranja" && _Linea3.ToLower() != "azul" && _Linea3.ToLower() != "verde" 
            && _Linea3.ToLower() != "negro" &&_Linea3.ToLower() != "rojo" && _Linea3.ToLower()!= "cafe"
            &&_Linea3.ToLower()!= "amarillo" || _Linea3.ToLower()=="violeta" || _Linea3.ToLower()=="gris" || _Linea3.ToLower()=="blanco")

            {
                return Ok("El color de la Linea 3 es INCORRECTO");
            }

            rest.Lineacuatro(_Linea4);

            if(_Linea4.ToLower() != "dorado" && _Linea4.ToLower() != "plata")
            {
                return Ok("El color de la Linea 4 es INCORRECTO, Solo se acepta el color DORADO y PLATA");
            }
            rest.Retornardatos();

            return Ok(rest.Retornardatos());
        }
    }
}