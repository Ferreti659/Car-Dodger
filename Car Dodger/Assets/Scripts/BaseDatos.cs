using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class BaseDatos : MonoBehaviour
{

    private string dbName = "URI=file:Ranking.db";

    void Start()
    {
        CrearTabla();

        

        mostrarRanking();
    }

    public void CrearTabla()
    {
        

        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS Ranking (nombre VARCHAR(20) , tiempo INT);";
                command.ExecuteNonQuery();
            }

            Debug.Log("tabla creada");
            connection.Close();
        }
    }

    public void añadirPlayer(string nombre, int tiempo)
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Ranking (nombre, tiempo) VALUES ('" + nombre + "', '" + tiempo + "');";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public void mostrarRanking()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Ranking ORDER BY tiempo DESC";


                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.Log("Nombre: " + reader["nombre"] + " \tTiempo: " + reader["tiempo"]);
                    }
                }

            }


            connection.Close();
        }

    }

}
