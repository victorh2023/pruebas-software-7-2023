﻿using backend.connection;
using backend.entidades;
using backend.servicios;


namespace backend_unit_test
{
    public class UnitTestCarritoCompra
    {   
        public UnitTestCarritoCompra() 
        {
            BDManager.GetInstance.ConnectionString = "workstation id=DBVictorhugocondorib.mssql.somee.com;packet size=4096;user id=victorhugo2023_SQLLogin_1;pwd=535xd3kqwg;data source=DBVictorhugocondorib.mssql.somee.com;persist security info=False;initial catalog=DBVictorhugocondorib";
        }

        [Fact] 
        public void CarritoCompra_Get_Verificar_NotNull()
        {
            var result = CarritoCompraServicios.ObtenerTodo<CarritoCompra>();
            Assert.NotNull(result);
        }

        [Fact]
        public void CarritoCompra_GetById_VerificarItem()
        {
            var result = CarritoCompraServicios.ObtenerById<CarritoCompra>(1);
            Assert.Equal(1, result.Id);
        }
    }
}
