using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoCineReserva.Persistencia;
using ProyectoCineReserva.Models;

namespace ProyectoCineReserva.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregarUsuario()
        {
            UsuarioDAO usudao = new UsuarioDAO();
            Usuario usuario = new Usuario
            {
                Nombre = "Jeffer",
                Apellido = "Carbajal",
                Dni = "12345678",
                userName = "usuario1",
                Clave = "12345",
                TipoUsuario = "Cliente",
                Direccion = "PSJE CHAVELITA",
                Telefono = "989696641"
            };
            Assert.IsNotNull(usudao.Crear(usuario));               
        }

        [TestMethod]
        public void agregarSala()
        {
            SalaDAO saladao = new SalaDAO();
            Cine cine = new Cine();
            cine.idCine = 1;
            Sala sala = new Sala
            {
                Aforo=100,
                nroPiso=3,
               cine=cine
            };
            Assert.IsNotNull(saladao.Crear(sala));
        }

        [TestMethod]
        public void agregarCine()
        {
            CineDAO cineadao = new    CineDAO();
            Cine cine = new Cine
            {
                Nombre = "CINE LARCOMAR",
                Provincia="LIMA",
                Aforo=50,
                nroSalas=6,             
                Direccion = "MIRAFLORES"                
            };
            Assert.IsNotNull(cineadao.Crear(cine));
        }
    }
}
