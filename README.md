# Prueba Fred Rodriguez

## Ejecución Proyecto
### 1. Actualizar cadenas de conexión
Actualizar cadenas de conexión de los microservicios Admin y Booking.

### 2. Ejecutar migracion Api Admin
```
En la consola del administrador de paquetes seleccionar el proyecto 02.Admin/03.Persistence\Admin.Persistence.Database

Crear migracion ejecutar siguiente comando
EntityFrameworkCore\Add-Migration Initialize

Actualizar base de datos con la migracion ejecutar
EntityFrameworkCore\Update-Database
```

### 3. Ejecutar migracion Api Booking
```
Seleccionar el proyecto 03.Booking/03.Persistence\Booking.Persistence.Database

Crear migracion ejecutar siguiente comando
EntityFrameworkCore\Add-Migration Initialize

Actualizar base de datos con la migracion ejecutar
EntityFrameworkCore\Update-Database
```

### 4. Ejecucion procedimiento almacenado
Luego de ejecutar migraciones, ejecutar en base de datos el procedimiento almacenado SpConsultHotel que se encuentra en la carpeta Database de este repositorio.


