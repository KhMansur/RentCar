using Npgsql;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    public class EntityForCars
    {
        private readonly string connString = "Server = localhost; User id = postgres; Password = 12345678mn; database = mashinaijarasi";

        public async Task Add(Mashina mashina)
        {
             using var conn = new NpgsqlConnection(connString);
             conn.Open();

            await using (var cmd = new NpgsqlCommand("INSERT INTO mashinalar (model, nomer, narxi, yili, rangi) VALUES (@model, @nomer, @narxi, @yili, @rangi)", conn))
            {
                cmd.Parameters.AddWithValue("model", mashina.Model);
                cmd.Parameters.AddWithValue("nomer", mashina.Nomer);
                cmd.Parameters.AddWithValue("narxi", mashina.Narxi);
                cmd.Parameters.AddWithValue("yili", mashina.Yili);
                cmd.Parameters.AddWithValue("rangi", mashina.Rangi);

                cmd.ExecuteReaderAsync();
            }
        }
        public async Task Delete(int id)
        {
            string commandText = $"DELETE FROM mashinalar WHERE ID=(@p)";
            await using var conn = new NpgsqlConnection(connString);
             conn.Open();
            await using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("p", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
