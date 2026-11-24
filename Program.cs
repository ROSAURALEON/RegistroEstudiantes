
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
        // Cadena de conexión con la base de datos
        string cadenaConexion = "Data Source=Estudiantes.db";

        // Establecer conexión con SQLite
        using (var conexion = new SqliteConnection(cadenaConexion))
        {
            conexion.Open();

            Console.WriteLine("CONEXIÓN A SQLITE EXITOSA");

            // Crear la tabla de estudiantes
            string crearTabla = @"
                CREATE TABLE IF NOT EXISTS Estudiantes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Edad INTEGER NOT NULL
                );";

            using (var comando = new SqliteCommand(crearTabla, conexion))
            {
                comando.ExecuteNonQuery();
            }

            Console.WriteLine("Tabla creada correctamente.");

            // Comprobar si ya existen estudiantes registrados
            string contarRegistros = "SELECT COUNT(*) FROM Estudiantes;";

            using (var comandoConteo = new SqliteCommand(contarRegistros, conexion))
            {
                long cantidad = (long)comandoConteo.ExecuteScalar();

                // Insertar estudiantes solamente si la tabla está vacía
                if (cantidad == 0)
                {
                    string insertarDatos = @"
                        INSERT INTO Estudiantes (Nombre, Edad)
                        VALUES (@nombre1, @edad1),
                               (@nombre2, @edad2),
                               (@nombre3, @edad3);";

                    using (var comando = new SqliteCommand(insertarDatos, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre1", "Laura Martinez");
                        comando.Parameters.AddWithValue("@edad1", 20);

                        comando.Parameters.AddWithValue("@nombre2", "Carlos Rodriguez");
                        comando.Parameters.AddWithValue("@edad2", 22);

                        comando.Parameters.AddWithValue("@nombre3", "Ana Garcia");
                        comando.Parameters.AddWithValue("@edad3", 19);

                        int registros = comando.ExecuteNonQuery();

                        Console.WriteLine("Estudiantes registrados: " + registros);
                    }
                }
                else
                {
                    Console.WriteLine("Los estudiantes ya se encuentran registrados.");
                }
            }

            // Consultar los estudiantes almacenados
            string consultarDatos = "SELECT * FROM Estudiantes;";

            using (var comando = new SqliteCommand(consultarDatos, conexion))
            {
                using (var lector = comando.ExecuteReader())
                {
                    Console.WriteLine("\nLISTA DE ESTUDIANTES");
                    Console.WriteLine("-----------------------------");

                    while (lector.Read())
                    {
                        Console.WriteLine(
                            "ID: " + lector["Id"] +
                            " | Nombre: " + lector["Nombre"] +
                            " | Edad: " + lector["Edad"]
                        );
                    }
                }
            }

            Console.WriteLine("\nConsulta finalizada correctamente.");
        }

        Console.WriteLine("\nPresiona una tecla para salir.");
        Console.ReadKey();
    }
}
