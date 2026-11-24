\# Registro de Estudiantes



\## Descripción del proyecto



Este proyecto consiste en una aplicación de consola desarrollada en C# que permite trabajar con una base de datos SQLite mediante ADO.NET. Su finalidad es demostrar cómo se puede establecer una conexión con una base de datos, crear una tabla, insertar registros y consultar la información almacenada.



\## Tecnologías utilizadas



\- C#

\- .NET 8

\- SQLite

\- Microsoft.Data.Sqlite 8.0.0

\- Visual Studio Code

\- Git y GitHub



\## Funcionalidades



\- Establecer conexión con una base de datos SQLite.

\- Crear una tabla llamada Estudiantes.

\- Registrar tres estudiantes cuando la tabla está vacía.

\- Evitar insertar nuevamente los registros si ya existen.

\- Consultar y mostrar los estudiantes almacenados.



\## Estructura del proyecto



\- `Program.cs`: contiene el código fuente de la aplicación.

\- `RegistroEstudiantes.csproj`: contiene la configuración del proyecto y sus dependencias.

\- `Estudiantes.db`: archivo de la base de datos SQLite.

\- `.gitignore`: indica los archivos y carpetas que Git debe ignorar.



\## Requisitos



\- Tener instalado el SDK de .NET 8.

\- Contar con un editor de código, como Visual Studio Code.



\## Cómo ejecutar el proyecto



1\. Descargar o clonar el repositorio.

2\. Abrir una terminal dentro de la carpeta del proyecto.

3\. Ejecutar el siguiente comando:



```bash

dotnet restore

```



4\. Después, ejecutar:



```bash

dotnet run

```



El programa se conectará a SQLite, creará la tabla si no existe, insertará los estudiantes si la tabla está vacía y mostrará los registros almacenados.



\## Autor



Rosaura León



Ingeniería de Sistemas

