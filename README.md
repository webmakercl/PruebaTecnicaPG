# Prueba Tecnica PG
## _API .NET 8 CON ANGULAR_

## Documentacion  WebApi .NET 8

Referente a la API .NET 8 se han creado carpetas para manejar los servicios, modelos y controladores

Se ha modificado el **Program.cs** 

* CORS para comunicacion entre los componentes de back y front
* MOCK de datos para EF en Memoria

**Carpeta Controllers**

* Se a�ade controlador Clientes
* Se a�adieron etiquetas para especificar el tipo de dato producido. (application/json)

**Carpeta Models**
* Se a�ade clase Cliente

**Carpeta Data**
* Se a�ade ApplicationDbContext

## Documentacion  Angular
**SRC/APP**
* Se a�ade componente Cliente
* Se a�ade componente Pipes para pruebas
* Se a�ade clase cliente.services para peticion a la api
* Se modifica app module y app.routing.module
* Se a�ade bootstrap 

**TEST ANGULAR**
* **'cd .\PruebaTecnicaPG_app\** -> para entrar a la raiz de la app
* **ng test** -> para ejecutar los casos  


## Como ejecutar la solucion
* Abrir 2 terminal de desarrollador o powershell para desarrolldores una para cada app.

**En el caso de la app .NET 8**
* **' cd .\PruebaTecnicaPG\'** -> para entrar a la raiz de la app
* **dotnet run** -> para ejecutar la aplicacion 
* http://localhost:5072/ 
* http://localhost:5072/swagger/index.html

**En el caso de la app Angular**
* **'cd .\PruebaTecnicaPG_app\** -> para entrar a la raiz de la app
* **npm install** -> para restaurar dependencias
* **ng serve** -> para ejecutar la aplicacion 
* http://localhost:59296/


