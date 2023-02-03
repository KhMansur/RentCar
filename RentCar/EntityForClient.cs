using Npgsql;
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

        public async void GetAll()
        {
            conn.Open();
            await using (var command = new NpgsqlCommand("Select * from mijoz", conn))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + " | " + reader.GetString(2) + " | " + reader.GetString(3));
                }
            }
        }

        public async void Delete(int id)
        {
            conn.Open();
            await using (var command = new NpgsqlCommand("DELETE FROM mijoz WHERE id=(@id)", conn))
            {
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
            }
        }

        public async void Getbyid(int a)
        {
            conn.Open();
            await using (var command = new NpgsqlCommand("select * FROM mijoz  Where id = " + a, conn))
            {



                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Console.WriteLine(reader.GetInt32(0) + " | " +  reader.GetString(1) + " | " + reader.GetString(2) + " | " + reader.GetString(3));
                }

            }
        }
}
