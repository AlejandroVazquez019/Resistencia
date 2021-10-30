using System;
namespace Practica1.Resistencia.Domain.Interface
{
    public interface ICalcular
    {
        void Lineauno(string Linea1);

        void Lineados(string Linea2);

        void Lineatres(string Linea3);

        void Lineacuatro(string Linea4);

        string Retornardatos();
    }
}