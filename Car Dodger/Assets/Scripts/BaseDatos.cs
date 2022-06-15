using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using TMPro;
using System;

public class BaseDatos : MonoBehaviour
{

    private string dbName = "URI=file:Ranking.db";
    public Text[] texto = new Text[5];
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
                command.CommandText = "SELECT * FROM Ranking ORDER BY tiempo DESC LIMIT 5";


                using (IDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                       

                        Debug.Log("Nombre: " + reader["nombre"] + " \tTiempo: " + reader["tiempo"]);

                        texto[i].text = "Nombre: " + reader["nombre"] + " \tTiempo: " + reader["tiempo"];

                        i++;
                        Debug.Log(i);
                    }
                    reader.Close();
                }

            }


            connection.Close();
        }

    }

}
