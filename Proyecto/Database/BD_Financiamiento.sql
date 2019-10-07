-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2019-10-06 23:29:38.534

-- tables
-- Table: Categoria_Deuda
CREATE TABLE Categoria_Deuda (
    IDCategoria_Deuda int  NOT NULL,
    NCategoria_Deuda nvarchar(50)  NOT NULL,
    CONSTRAINT Categoria_Deuda_pk PRIMARY KEY  (IDCategoria_Deuda)
);

-- Table: Categoria_Gasto
CREATE TABLE Categoria_Gasto (
    IDCategoria_Gasto int  NOT NULL,
    NCategoria_Gasto nvarchar(50)  NOT NULL,
    CONSTRAINT Categoria_Gasto_pk PRIMARY KEY  (IDCategoria_Gasto)
);

-- Table: Categoria_Ingreso
CREATE TABLE Categoria_Ingreso (
    IDCategoria_Ingreso int  NOT NULL,
    NCategoria_Ingreso nvarchar(50)  NOT NULL,
    CONSTRAINT Categoria_Ingreso_pk PRIMARY KEY  (IDCategoria_Ingreso)
);

-- Table: DetalleReporte
CREATE TABLE DetalleReporte (
    IDTransaccion int  NOT NULL,
    IDReporte int  NOT NULL,
    CONSTRAINT DetalleReporte_pk PRIMARY KEY  (IDTransaccion,IDReporte)
);

-- Table: Deuda
CREATE TABLE Deuda (
    IDDeuda int  NOT NULL,
    NDeuda nvarchar(50)  NOT NULL,
    FechaInicioDeuda date  NOT NULL,
    FechaFinDeuda date  NOT NULL,
    TDescripcion text  NOT NULL,
    Interes float(4)  NULL,
    MontoDeuda money  NOT NULL,
    IDDivisa int  NOT NULL,
    IDCategoria_Deuda int  NOT NULL,
    IDEntidad int  NOT NULL,
    IDUsuario int  NOT NULL,
    CONSTRAINT Deuda_pk PRIMARY KEY  (IDDeuda)
);

-- Table: Divisa
CREATE TABLE Divisa (
    IDDivisa int  NOT NULL,
    NDivisa nvarchar(25)  NOT NULL,
    CONSTRAINT Divisa_pk PRIMARY KEY  (IDDivisa)
);

-- Table: Entidad
CREATE TABLE Entidad (
    IDEntidad int  NOT NULL,
    NEntidad nvarchar(50)  NOT NULL,
    IDEntidad_Tipo int  NOT NULL,
    CONSTRAINT Entidad_pk PRIMARY KEY  (IDEntidad)
);

-- Table: Entidad_Tipo
CREATE TABLE Entidad_Tipo (
    IDEntidad_Tipo int  NOT NULL,
    NEntida_Tipo nvarchar(50)  NOT NULL,
    CONSTRAINT Entidad_Tipo_pk PRIMARY KEY  (IDEntidad_Tipo)
);

-- Table: Frecuencia
CREATE TABLE Frecuencia (
    IDFrecuencia int  NOT NULL,
    NFrecuencia varchar(20)  NOT NULL,
    TDescripcion text  NOT NULL,
    CONSTRAINT Frecuencia_pk PRIMARY KEY  (IDFrecuencia)
);

-- Table: Gasto
CREATE TABLE Gasto (
    IDGasto int  NOT NULL,
    IDCategoria_Gasto int  NOT NULL,
    CONSTRAINT Gasto_pk PRIMARY KEY  (IDGasto,IDCategoria_Gasto)
);

-- Table: Ingreso
CREATE TABLE Ingreso (
    IDIngreso int  NOT NULL,
    IDCategoria_Ingreso int  NOT NULL,
    CONSTRAINT Ingreso_pk PRIMARY KEY  (IDIngreso,IDCategoria_Ingreso)
);

-- Table: Mes
CREATE TABLE Mes (
    IDMes int  NOT NULL,
    NMes nvarchar(15)  NOT NULL,
    CONSTRAINT Mes_pk PRIMARY KEY  (IDMes)
);

-- Table: Reporte
CREATE TABLE Reporte (
    IDReporte int  NOT NULL IDENTITY(001, 1),
    FechaReporte date  NOT NULL,
    FechaInicio date  NOT NULL,
    FechaTermino date  NOT NULL,
    CONSTRAINT Reporte_pk PRIMARY KEY  (IDReporte)
);

-- Table: TipoCuenta
CREATE TABLE TipoCuenta (
    IDTipoCuenta int  NOT NULL,
    NTipoCuenta nvarchar(25)  NOT NULL,
    MTipoCuenta money  NOT NULL,
    TiempoCuenta int  NOT NULL,
    CONSTRAINT TipoCuenta_pk PRIMARY KEY  (IDTipoCuenta)
);

-- Table: Transaccion
CREATE TABLE Transaccion (
    IDTransaccion int  NOT NULL,
    NTransaccion varchar(50)  NOT NULL,
    MontoTransaccion money  NOT NULL,
    FechaTransaccion datetime  NOT NULL,
    IDDivisa int  NOT NULL,
    IDMes int  NOT NULL,
    IDUsuario int  NOT NULL,
    IDFrecuencia int  NOT NULL,
    CONSTRAINT Transaccion_pk PRIMARY KEY  (IDTransaccion)
);

-- Table: Usuario
CREATE TABLE Usuario (
    IDUsuario int  NOT NULL IDENTITY(0000001, 1),
    Nombre varchar(50)  NOT NULL,
    Apellidos varchar(100)  NULL,
    Email   varchar(50)  NOT NULL,
    Nickname varchar(25)  NULL,
    Password varchar(20)  NOT NULL,
    Celular varchar(12)  NOT NULL,
    IDTipoCuenta int  NOT NULL,
    CONSTRAINT Usuario_pk PRIMARY KEY  (IDUsuario)
);

-- foreign keys
-- Reference: Deuda_Categoria_Deuda (table: Deuda)
ALTER TABLE Deuda ADD CONSTRAINT Deuda_Categoria_Deuda
    FOREIGN KEY (IDCategoria_Deuda)
    REFERENCES Categoria_Deuda (IDCategoria_Deuda);

-- Reference: Deuda_Divisa (table: Deuda)
ALTER TABLE Deuda ADD CONSTRAINT Deuda_Divisa
    FOREIGN KEY (IDDivisa)
    REFERENCES Divisa (IDDivisa);

-- Reference: Deuda_Entidad (table: Deuda)
ALTER TABLE Deuda ADD CONSTRAINT Deuda_Entidad
    FOREIGN KEY (IDEntidad)
    REFERENCES Entidad (IDEntidad);

-- Reference: Deuda_Usuario (table: Deuda)
ALTER TABLE Deuda ADD CONSTRAINT Deuda_Usuario
    FOREIGN KEY (IDUsuario)
    REFERENCES Usuario (IDUsuario);

-- Reference: Entidad_Entidad_Tipo (table: Entidad)
ALTER TABLE Entidad ADD CONSTRAINT Entidad_Entidad_Tipo
    FOREIGN KEY (IDEntidad_Tipo)
    REFERENCES Entidad_Tipo (IDEntidad_Tipo);

-- Reference: Gasto_Categoria_Gasto (table: Gasto)
ALTER TABLE Gasto ADD CONSTRAINT Gasto_Categoria_Gasto
    FOREIGN KEY (IDCategoria_Gasto)
    REFERENCES Categoria_Gasto (IDCategoria_Gasto);

-- Reference: Gasto_Transaccion (table: Gasto)
ALTER TABLE Gasto ADD CONSTRAINT Gasto_Transaccion
    FOREIGN KEY (IDGasto)
    REFERENCES Transaccion (IDTransaccion);

-- Reference: Ingreso_Categoria_Ingreso (table: Ingreso)
ALTER TABLE Ingreso ADD CONSTRAINT Ingreso_Categoria_Ingreso
    FOREIGN KEY (IDCategoria_Ingreso)
    REFERENCES Categoria_Ingreso (IDCategoria_Ingreso);

-- Reference: Ingreso_Transaccion (table: Ingreso)
ALTER TABLE Ingreso ADD CONSTRAINT Ingreso_Transaccion
    FOREIGN KEY (IDIngreso)
    REFERENCES Transaccion (IDTransaccion);

-- Reference: Table_24_Reporte (table: DetalleReporte)
ALTER TABLE DetalleReporte ADD CONSTRAINT Table_24_Reporte
    FOREIGN KEY (IDReporte)
    REFERENCES Reporte (IDReporte);

-- Reference: Table_24_Transaccion (table: DetalleReporte)
ALTER TABLE DetalleReporte ADD CONSTRAINT Table_24_Transaccion
    FOREIGN KEY (IDTransaccion)
    REFERENCES Transaccion (IDTransaccion);

-- Reference: Transaccion_Divisa (table: Transaccion)
ALTER TABLE Transaccion ADD CONSTRAINT Transaccion_Divisa
    FOREIGN KEY (IDDivisa)
    REFERENCES Divisa (IDDivisa);

-- Reference: Transaccion_Frecuencia (table: Transaccion)
ALTER TABLE Transaccion ADD CONSTRAINT Transaccion_Frecuencia
    FOREIGN KEY (IDFrecuencia)
    REFERENCES Frecuencia (IDFrecuencia);

-- Reference: Transaccion_Mes (table: Transaccion)
ALTER TABLE Transaccion ADD CONSTRAINT Transaccion_Mes
    FOREIGN KEY (IDMes)
    REFERENCES Mes (IDMes);

-- Reference: Transaccion_Usuario (table: Transaccion)
ALTER TABLE Transaccion ADD CONSTRAINT Transaccion_Usuario
    FOREIGN KEY (IDUsuario)
    REFERENCES Usuario (IDUsuario);

-- Reference: Usuario_TipoCuenta (table: Usuario)
ALTER TABLE Usuario ADD CONSTRAINT Usuario_TipoCuenta
    FOREIGN KEY (IDTipoCuenta)
    REFERENCES TipoCuenta (IDTipoCuenta);

-- End of file.

