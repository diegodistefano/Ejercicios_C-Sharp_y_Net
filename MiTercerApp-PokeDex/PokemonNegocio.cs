﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MiTercerApp_PokeDex
{
    class PokemonNegocio
    {
        public List<Pokemon> listar() 
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //Toda funcionalidad que pueda fallar

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType =   
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
