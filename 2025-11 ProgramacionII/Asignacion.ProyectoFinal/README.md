# Asignacion.ProyectoFinal

## Requisitos del Proyecto

### 1. Investigación de Conceptos Fundamentales.

Tarea: Investigar temas clave de ADO.NET y bases de datos, completando una tabla con definiciones y explicaciones personales.
Entregable: Tabla en un documento Word o PDF con el siguiente formato:
- Tema
- Definición (Fuente: Investigación)
- Explicación con tus palabras
- ADO.NET
- Proveedores de datos
- Objeto Connection
- Objeto Command
- Objeto DataTable
- Objeto DataReader
- Objeto DataAdapter
- Objeto DataSet
- ExecuteNonQuery
- ExecuteScalar


### 2. Conversor de Unidades de Peso

**Tarea:** Crear un programa en C# que convierta de kilogramos a libras.

**Fórmula:** 1 kg = 2.20462 lb

**Entregable:** Aplicación con interfaz gráfica donde el usuario ingresa el peso en kilogramos en un TextBox y, al hacer clic en "Convertir", se muestra el resultado en libras en un Label.
 Validar que la entrada sea un número positivo y añadir un botón "Reiniciar" para limpiar los campos.

### 3. Conversor Inverso de Unidades de Peso

**Tarea:** Crear un programa en C# que convierta de libras a kilogramos.

**Fórmula:** 1 lb = 0.453592 kg

**Entregable:**
- Similar al punto 2, pero con la conversión inversa.
- Mostrar un MessageBox si el peso ingresado es menor a 0 o mayor a 10,000 libras como límite razonable.

### 4. Conversor de Unidades Combinado

**Tarea:** 
Crear un programa en C# que permita convertir entre kilogramos y libras según la selección del usuario.

**Entregable:** Interfaz con:
- Un ComboBox para elegir la conversión ("Kilogramos a Libras" o "Libras a Kilogramos").
- Un TextBox para ingresar el valor.
- Un botón "Convertir" que muestra el resultado en un Label.
- Incluir un ListBox que registre las últimas 5 conversiones con marca de tiempo (fecha y hora).

### 5. Gestión de Movimientos de Inventario en DataGridView

**Tarea:** Crear un programa en C# que gestione entrada de inventario en un DataGridView.
**Entregable:** Interfaz con:
- Campos de entrada: 
	- Código de Producto
	- Nombre
	- Tipo (Entrada/Salida)
	- Cantidad
	- Fecha
- Botón "Agregar" para añadir datos al DataGridView.
- Columnas en el DataGridView: 
	- Código
	- Nombre
	- Tipo
	- Cantidad
	- Fecha
- Botón "Eliminar" para quitar una fila seleccionada.
- Labels debajo mostrando: 
	- Total Entradas
	- Total Salidas
- Validar que la cantidad sea positiva y recalcular el stock neto automáticamente al agregar o eliminar movimientos.

### 6. Creación de Base de Datos

**Tarea:** Diseñar e implementar una base de datos en SQL Server llamada "PacientesDB".
**Entregable:** Script SQL que contenga:
- Creación de la base de datos (CREATE DATABASE PacientesDB).
- Creación de una tabla "Pacientes" con campos:
	- codigopac
	- nombrepac
	- apelldiopac
	- direccionpac
	- telefonopac
	- estatuspac
- Creación de un CRUD para la tabla pacientes.

### 7. Menú Principal en C# 
Llamar todos los formularios desde un menú utilizando el componente Menustrip.

## Technologies
- C#
- Dapper
- SQL Server Express 2025
- Windows Forms (.NET 9)
- Visual Studio 2022

