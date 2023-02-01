﻿using Npgsql;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    public class EntityForClient
    {
        public NpgsqlConnection conn = new NpgsqlConnection("server = localhost; port = 5432; User id= postgres; password = 123456; Database = mashinaijarasi");


        public async void Add(Mijoz mijoz)
        {
            conn.Open();
            await using (var command = new NpgsqlCommand("Insert into mijoz(ismi, passport, guvohnomanomeri) values(@ismi, @passport, @guvohnomanomeri)", conn))
            {
                command.Parameters.AddWithValue("ismi", mijoz.Ismi);
                command.Parameters.AddWithValue("passport", mijoz.Passport);
                command.Parameters.AddWithValue("guvohnomanomeri", mijoz.GuvohnomaNomeri);

                command.ExecuteNonQuery();
            };
        }
    }
}