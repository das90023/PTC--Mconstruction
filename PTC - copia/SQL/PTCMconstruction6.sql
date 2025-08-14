-- CREAR BASE DE DATOS
CREATE DATABASE PTCMconstruction6;
GO
USE PTCMconstruction6;
GO

-- TABLA CLIENTES
CREATE TABLE Clientes(
    idCliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    numeroTelefono INT NOT NULL,
    correoElectronico NVARCHAR(100) NOT NULL,
    direccion NVARCHAR(MAX) NOT NULL,
    empresa NVARCHAR(100) NOT NULL
);
GO

-- TABLA ROLES
CREATE TABLE RolUsuario(
    idRolUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreRol NVARCHAR(50) NOT NULL
);
GO

-- TABLA USUARIO (pass es NVARCHAR(50))
CREATE TABLE Usuario(
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario NVARCHAR(50) NOT NULL,
    pass NVARCHAR(50) NOT NULL,
    idRol INT,
    CONSTRAINT fkIdRolUsuarios FOREIGN KEY (idRol) REFERENCES RolUsuario(idRolUsuario) ON DELETE CASCADE
);
GO

-- TABLA CATEGORÍAS
CREATE TABLE CategoriaProducto(
    idCategoriaProducto INT IDENTITY(1,1) PRIMARY KEY,
    nombreCategoriaP NVARCHAR(100) NOT NULL,
    descripcionCategoria NVARCHAR(MAX) NOT NULL
);
GO

-- TABLA MARCA
CREATE TABLE Marca(
    idMarca INT IDENTITY(1,1) PRIMARY KEY,
    nombreMarca NVARCHAR(100) NOT NULL
);
GO

-- TABLA PRODUCTO
CREATE TABLE Producto(
    idProducto INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    descripcionp NVARCHAR(MAX) NOT NULL,
    tipo NVARCHAR(25) CHECK(tipo IN('Material','Herramienta')) NOT NULL,
    precioUnitario MONEY NOT NULL,
    stockActual INT NOT NULL,
    stockMinimo INT DEFAULT 1 NOT NULL,
    id_Categoria INT,
    id_Marca INT,
    CONSTRAINT fkCategoriaP FOREIGN KEY (id_Categoria) REFERENCES CategoriaProducto (idCategoriaProducto) ON DELETE CASCADE,
    CONSTRAINT fkMarcaP FOREIGN KEY (id_Marca) REFERENCES Marca (idMarca) ON DELETE CASCADE
);
GO

-- TABLA ALMACÉN
CREATE TABLE Almacen(
    idEntrada INT IDENTITY(1,1) PRIMARY KEY,
    fechaEntrada DATE NOT NULL,
    id_Producto INT,
    cantidad INT NOT NULL,
    CONSTRAINT fkidEntradaProductoID FOREIGN KEY (id_Producto) REFERENCES Producto (idProducto) ON DELETE CASCADE
);
GO

-- TABLA DETALLEVENTA
CREATE TABLE DetalleVenta(
    idDetalleVenta INT IDENTITY(1,1) PRIMARY KEY,
    ProductosSeleccionados INT,
    fecha DATE,
    metodoPago NVARCHAR(30) CHECK (metodoPago IN('Efectivo','Tarjeta')) NOT NULL,
    montoTotal MONEY NOT NULL,
    CONSTRAINT fkSeleccionProductos FOREIGN KEY (ProductosSeleccionados) REFERENCES Producto (idProducto) ON DELETE CASCADE
);
GO

-- TABLA VENTA
CREATE TABLE Venta(
    idVenta INT IDENTITY(1,1) PRIMARY KEY,
    id_Usuario INT,
    id_DetalleVenta INT,
    id_Cliente INT,
    CONSTRAINT fkIdUsuario FOREIGN KEY (id_Usuario) REFERENCES Usuario (idUsuario) ON DELETE CASCADE,
    CONSTRAINT FKIdDetalleVenta FOREIGN KEY (id_DetalleVenta) REFERENCES DetalleVenta (idDetalleVenta) ON DELETE CASCADE,
    CONSTRAINT FKIDCliente FOREIGN KEY (id_Cliente) REFERENCES Clientes (idCliente) ON DELETE CASCADE
);
GO

-- TABLA INGRESOS
CREATE TABLE Ingresos(
    idIngresos INT IDENTITY(1,1) PRIMARY KEY,
    id_Venta INT,
    CONSTRAINT fkIdVenta FOREIGN KEY (id_Venta) REFERENCES Venta (idVenta) ON DELETE CASCADE
);
GO

-- INSERTS
SELECT * FROM Clientes;
SELECT * FROM RolUsuario;
SELECT * FROM Usuario;
SELECT * FROM CategoriaProducto;
SELECT * FROM Marca;
SELECT * FROM Producto;
SELECT * FROM Almacen;
SELECT * FROM DetalleVenta;
SELECT * FROM Venta;
SELECT * FROM Ingresos;

INSERT INTO Clientes (nombre, apellido, numeroTelefono, correoElectronico, direccion, empresa) VALUES
('Carlos', 'Martínez', 71234567, 'carlos.martinez@email.com', 'San Salvador, El Salvador', 'Invercon SA'),
('Ana', 'López', 71234568, 'ana.lopez@email.com', 'Santa Tecla, El Salvador', 'Construmax'),
('Luis', 'Pérez', 71234569, 'luis.perez@email.com', 'Soyapango, El Salvador', 'Edifica SRL'),
('Sofía', 'Ramírez', 71234570, 'sofia.ramirez@email.com', 'Mejicanos, El Salvador', 'MegaObras'),
('Diego', 'Siliezar', 71234571, 'diego.siliezar@email.com', 'San Marcos, El Salvador', 'PTCM S.A.');

INSERT INTO RolUsuario (nombreRol) VALUES
('Administrador'),
('Vendedor'),
('Almacenero'),
('Gerente'),
('Supervisor');

-- INSERT USUARIO
INSERT INTO Usuario (nombreUsuario, pass, idRol) VALUES
--Usuario, Contraseña
('Hessem', '123', 1),
('Magics', '321', 2),
('Arturo', '456', 3),
('Oscar', '654', 4),
('Walter', '789', 5);

INSERT INTO CategoriaProducto (nombreCategoriaP, descripcionCategoria) VALUES
('Cemento', 'Material de construcción para estructuras'),
('Herramientas eléctricas', 'Herramientas como taladros, sierras, etc.'),
('Acabados', 'Materiales para acabados de obra'),
('Hierro', 'Materiales metálicos para refuerzos'),
('Pinturas', 'Pinturas para interiores y exteriores');

INSERT INTO Marca (nombreMarca) VALUES
('Holcim'),
('Makita'),
('Sika'),
('Sherwin-Williams'),
('DeWalt');

INSERT INTO Producto (nombre, descripcionp, tipo, precioUnitario, stockActual, id_Categoria, id_Marca) VALUES
('Cemento Gris', 'Bolsa de 42.5kg', 'Material', 8.50, 200, 1, 1),
('Taladro Inalámbrico', '18V con batería recargable', 'Herramienta', 75.00, 40, 2, 2),
('Pintura Blanca', 'Galón interior-exterior', 'Material', 12.00, 60, 5, 4),
('Barra de Hierro 3/8"', '6 metros de largo', 'Material', 5.25, 100, 4, 3),
('Sierra Circular', '185mm 1500W', 'Herramienta', 95.00, 25, 2, 5);

INSERT INTO Almacen (fechaEntrada, id_Producto, cantidad) VALUES
('2025-07-01', 1, 100),
('2025-07-02', 2, 20),
('2025-07-03', 3, 30),
('2025-07-04', 4, 50),
('2025-07-05', 5, 10);

INSERT INTO DetalleVenta (ProductosSeleccionados, fecha, metodoPago, montoTotal) VALUES
(1, '2025-07-10', 'Efectivo', 85.00),
(2, '2025-07-11', 'Tarjeta', 150.00),
(3, '2025-07-12', 'Efectivo', 36.00),
(4, '2025-07-13', 'Tarjeta', 52.50),
(5, '2025-07-14', 'Efectivo', 95.00);

INSERT INTO Venta (id_Usuario, id_DetalleVenta, id_Cliente) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

INSERT INTO Ingresos (id_Venta) VALUES
(1),
(2),
(3),
(4),
(5);
