# Agencia de Viajes - Sistema de Gestión

Sistema de gestión para agencias de viajes desarrollado en **Windows Forms** con **.NET Framework 4.8**.

## Objetivo

Gestionar clientes, viajes y reservas de una agencia de viajes mediante una interfaz gráfica intuitiva con operaciones CRUD completas.

## Arquitectura

- **Viajes.View**: Interfaz de usuario (Windows Forms)
- **Viajes.Controller**: Lógica de negocio (APIs,DTOs y Mappers)
- **Viajes.Model**: Acceso a datos (Entity Framework, Repositorios)

## Pantallas y Funcionalidades

### 📊 **Pantalla de Inicio** (`FrmInicio`)
Panel principal con estadísticas generales:
- Visualizar total de clientes
- Visualizar total de viajes
- Visualizar total de reservas
- Visualizar ticket medio de reservas
- Acceder a las demás pantallas

---

### 👥 **Gestión de Clientes** (`FrmClientes`)
- **Listar** todos los clientes
- **Crear** nuevo cliente (nombre, apellidos, email)
- **Editar** datos de cliente existente
- **Eliminar** cliente (valida reservas activas)
- **Ver reservas** asociadas a un cliente
- Validación de formato de email

---

### ✈️ **Gestión de Viajes** (`FrmViajes`)
- **Listar** todos los viajes disponibles
- **Crear** nuevo viaje (destino, precio, plazas disponibles)
- **Editar** datos de viaje existente
- **Eliminar** viaje (valida reservas activas)
- **Ver reservas** asociadas a un viaje
- Control de plazas disponibles

---

### 📋 **Gestión de Reservas** (`FrmReservas`)
- **Listar** todas las reservas
- **Crear** nueva reserva (cliente, viaje, fecha)
- **Editar** fecha de reserva
- **Cancelar** reserva
- **Buscar** por cliente o destino
- Validación de fechas (no permite fechas pasadas)
- Decremento automático de plazas al crear reserva
- Incremento automático de plazas al cancelar reserva

---

## Características Técnicas

✅ Arquitectura en 3 capas  
✅ Entity Framework para acceso a datos  
✅ Operaciones asíncronas (async/await)  
✅ Patrón Repository  
✅ DTOs y Mappers  
✅ Validaciones de negocio  
✅ Manejo de errores SQL  
✅ Mensajes de confirmación  

## Base de Datos

Entidades principales:
- **Clientes**: Id, Nombre, Apellidos, Email
- **Viajes**: Id, Destino, Precio, PlazasDisponibles
- **Reservas**: Id, IdCliente, IdViaje, FechaReserva

Relaciones:
- Un cliente puede tener múltiples reservas
- Un viaje puede tener múltiples reservas
- Una reserva pertenece a un cliente y un viaje
