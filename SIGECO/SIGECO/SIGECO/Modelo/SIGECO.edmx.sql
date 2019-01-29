
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/29/2019 14:28:03
-- Generated from EDMX file: C:\Users\Trrr\Documents\GitHub\SIGECO\SIGECO\SIGECO\SIGECO\Modelo\SIGECO.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SIGECO4];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre1] nvarchar(20)  NOT NULL,
    [nombre2] nvarchar(20)  NOT NULL,
    [apellido1] nvarchar(20)  NOT NULL,
    [apellido2] nvarchar(20)  NOT NULL,
    [cedula] nvarchar(10)  NOT NULL,
    [pais] nvarchar(20)  NOT NULL,
    [correo] nvarchar(255)  NOT NULL,
    [telefono] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [numero] nvarchar(12)  NOT NULL,
    [subtotal] decimal(14,4)  NOT NULL,
    [total] decimal(14,4)  NOT NULL,
    [iva] float  NOT NULL,
    [ClienteId] int  NOT NULL,
    [Venta_Id] int  NOT NULL
);
GO

-- Creating table 'DetalleRetencions'
CREATE TABLE [dbo].[DetalleRetencions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [monto] decimal(14,4)  NOT NULL,
    [FacturaId] int  NOT NULL,
    [RetencionId] int  NOT NULL
);
GO

-- Creating table 'Retencions'
CREATE TABLE [dbo].[Retencions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [numRetencion] nvarchar(8)  NOT NULL,
    [porcentaje] float  NOT NULL,
    [valor] decimal(14,4)  NOT NULL
);
GO

-- Creating table 'DetalleFacturas'
CREATE TABLE [dbo].[DetalleFacturas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [cantidad] int  NOT NULL,
    [FacturaId] int  NOT NULL,
    [ProductoId] int  NOT NULL
);
GO

-- Creating table 'Productoes'
CREATE TABLE [dbo].[Productoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [codigo] nvarchar(20)  NOT NULL,
    [nombre] nvarchar(32)  NOT NULL,
    [precio] decimal(14,4)  NOT NULL
);
GO

-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(20)  NOT NULL,
    [ruc] nvarchar(13)  NOT NULL,
    [Representante_Id] int  NOT NULL
);
GO

-- Creating table 'Ventas'
CREATE TABLE [dbo].[Ventas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [tipo] nvarchar(8)  NOT NULL
);
GO

-- Creating table 'ComisionEmpleadoes'
CREATE TABLE [dbo].[ComisionEmpleadoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [monto] decimal(14,4)  NOT NULL,
    [EmpleadoId] int  NOT NULL,
    [ComisionOperacionId] int  NOT NULL
);
GO

-- Creating table 'Cobroes'
CREATE TABLE [dbo].[Cobroes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [fechaEst] datetime  NOT NULL,
    [montoEst] decimal(14,4)  NOT NULL,
    [saldo] decimal(14,4)  NOT NULL,
    [Venta_Id] int  NOT NULL
);
GO

-- Creating table 'Pagoes'
CREATE TABLE [dbo].[Pagoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [monto] decimal(14,4)  NOT NULL,
    [metodo] nvarchar(32)  NOT NULL,
    [CobroId] int  NOT NULL
);
GO

-- Creating table 'ComisionVentas'
CREATE TABLE [dbo].[ComisionVentas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [monto] decimal(14,4)  NOT NULL,
    [DepartamentoId] int  NOT NULL,
    [Venta_Id] int  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [email] nvarchar(255)  NOT NULL,
    [password] nvarchar(16)  NOT NULL,
    [permisos] nvarchar(8)  NOT NULL
);
GO

-- Creating table 'ComisionOperacions'
CREATE TABLE [dbo].[ComisionOperacions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [monto] decimal(14,4)  NOT NULL,
    [ComisionVentaId] int  NOT NULL
);
GO

-- Creating table 'Operacions'
CREATE TABLE [dbo].[Operacions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(20)  NOT NULL,
    [porcentajeComision] float  NOT NULL,
    [DepartamentoId] int  NOT NULL,
    [ComisionOperacion_Id] int  NOT NULL
);
GO

-- Creating table 'Departamentoes'
CREATE TABLE [dbo].[Departamentoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Rangoes'
CREATE TABLE [dbo].[Rangoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [inicio] decimal(14,4)  NOT NULL,
    [fin] decimal(14,4)  NOT NULL,
    [porcentajeComision] float  NOT NULL,
    [DepartamentoId] int  NOT NULL
);
GO

-- Creating table 'PagoEmpleadoes'
CREATE TABLE [dbo].[PagoEmpleadoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] datetime  NOT NULL,
    [monto] decimal(14,4)  NOT NULL,
    [EmpleadoId] int  NOT NULL
);
GO

-- Creating table 'Personas_Cliente'
CREATE TABLE [dbo].[Personas_Cliente] (
    [ruc] nvarchar(13)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Personas_Representante'
CREATE TABLE [dbo].[Personas_Representante] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Personas_Empleado'
CREATE TABLE [dbo].[Personas_Empleado] (
    [porcentajeComision] float  NOT NULL,
    [cargo] nvarchar(20)  NOT NULL,
    [salarioActual] decimal(14,4)  NOT NULL,
    [EmpleadoId] int  NOT NULL,
    [Id] int  NOT NULL,
    [Venta_Id] int  NOT NULL
);
GO

-- Creating table 'OperacionEmpleado'
CREATE TABLE [dbo].[OperacionEmpleado] (
    [Operacions_Id] int  NOT NULL,
    [Empleadoes_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetalleRetencions'
ALTER TABLE [dbo].[DetalleRetencions]
ADD CONSTRAINT [PK_DetalleRetencions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Retencions'
ALTER TABLE [dbo].[Retencions]
ADD CONSTRAINT [PK_Retencions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [PK_DetalleFacturas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Productoes'
ALTER TABLE [dbo].[Productoes]
ADD CONSTRAINT [PK_Productoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [PK_Ventas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComisionEmpleadoes'
ALTER TABLE [dbo].[ComisionEmpleadoes]
ADD CONSTRAINT [PK_ComisionEmpleadoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cobroes'
ALTER TABLE [dbo].[Cobroes]
ADD CONSTRAINT [PK_Cobroes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagoes'
ALTER TABLE [dbo].[Pagoes]
ADD CONSTRAINT [PK_Pagoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComisionVentas'
ALTER TABLE [dbo].[ComisionVentas]
ADD CONSTRAINT [PK_ComisionVentas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComisionOperacions'
ALTER TABLE [dbo].[ComisionOperacions]
ADD CONSTRAINT [PK_ComisionOperacions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Operacions'
ALTER TABLE [dbo].[Operacions]
ADD CONSTRAINT [PK_Operacions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departamentoes'
ALTER TABLE [dbo].[Departamentoes]
ADD CONSTRAINT [PK_Departamentoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rangoes'
ALTER TABLE [dbo].[Rangoes]
ADD CONSTRAINT [PK_Rangoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PagoEmpleadoes'
ALTER TABLE [dbo].[PagoEmpleadoes]
ADD CONSTRAINT [PK_PagoEmpleadoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Cliente'
ALTER TABLE [dbo].[Personas_Cliente]
ADD CONSTRAINT [PK_Personas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Representante'
ALTER TABLE [dbo].[Personas_Representante]
ADD CONSTRAINT [PK_Personas_Representante]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [PK_Personas_Empleado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Operacions_Id], [Empleadoes_Id] in table 'OperacionEmpleado'
ALTER TABLE [dbo].[OperacionEmpleado]
ADD CONSTRAINT [PK_OperacionEmpleado]
    PRIMARY KEY CLUSTERED ([Operacions_Id], [Empleadoes_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_ClienteFactura]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Personas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFactura'
CREATE INDEX [IX_FK_ClienteFactura]
ON [dbo].[Facturas]
    ([ClienteId]);
GO

-- Creating foreign key on [FacturaId] in table 'DetalleRetencions'
ALTER TABLE [dbo].[DetalleRetencions]
ADD CONSTRAINT [FK_FacturaDetalleRetencion]
    FOREIGN KEY ([FacturaId])
    REFERENCES [dbo].[Facturas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaDetalleRetencion'
CREATE INDEX [IX_FK_FacturaDetalleRetencion]
ON [dbo].[DetalleRetencions]
    ([FacturaId]);
GO

-- Creating foreign key on [RetencionId] in table 'DetalleRetencions'
ALTER TABLE [dbo].[DetalleRetencions]
ADD CONSTRAINT [FK_RetencionDetalleRetencion]
    FOREIGN KEY ([RetencionId])
    REFERENCES [dbo].[Retencions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RetencionDetalleRetencion'
CREATE INDEX [IX_FK_RetencionDetalleRetencion]
ON [dbo].[DetalleRetencions]
    ([RetencionId]);
GO

-- Creating foreign key on [FacturaId] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [FK_FacturaDetalleFactura]
    FOREIGN KEY ([FacturaId])
    REFERENCES [dbo].[Facturas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaDetalleFactura'
CREATE INDEX [IX_FK_FacturaDetalleFactura]
ON [dbo].[DetalleFacturas]
    ([FacturaId]);
GO

-- Creating foreign key on [ProductoId] in table 'DetalleFacturas'
ALTER TABLE [dbo].[DetalleFacturas]
ADD CONSTRAINT [FK_ProductoDetalleFactura]
    FOREIGN KEY ([ProductoId])
    REFERENCES [dbo].[Productoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalleFactura'
CREATE INDEX [IX_FK_ProductoDetalleFactura]
ON [dbo].[DetalleFacturas]
    ([ProductoId]);
GO

-- Creating foreign key on [Representante_Id] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [FK_EmpresaRepresentante]
    FOREIGN KEY ([Representante_Id])
    REFERENCES [dbo].[Personas_Representante]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaRepresentante'
CREATE INDEX [IX_FK_EmpresaRepresentante]
ON [dbo].[Empresas]
    ([Representante_Id]);
GO

-- Creating foreign key on [EmpleadoId] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [FK_EmpleadoEmpleado]
    FOREIGN KEY ([EmpleadoId])
    REFERENCES [dbo].[Personas_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoEmpleado'
CREATE INDEX [IX_FK_EmpleadoEmpleado]
ON [dbo].[Personas_Empleado]
    ([EmpleadoId]);
GO

-- Creating foreign key on [Venta_Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [FK_EmpleadoVenta]
    FOREIGN KEY ([Venta_Id])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoVenta'
CREATE INDEX [IX_FK_EmpleadoVenta]
ON [dbo].[Personas_Empleado]
    ([Venta_Id]);
GO

-- Creating foreign key on [Venta_Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_FacturaVenta]
    FOREIGN KEY ([Venta_Id])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaVenta'
CREATE INDEX [IX_FK_FacturaVenta]
ON [dbo].[Facturas]
    ([Venta_Id]);
GO

-- Creating foreign key on [EmpleadoId] in table 'ComisionEmpleadoes'
ALTER TABLE [dbo].[ComisionEmpleadoes]
ADD CONSTRAINT [FK_EmpleadoComisionEmpleado]
    FOREIGN KEY ([EmpleadoId])
    REFERENCES [dbo].[Personas_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoComisionEmpleado'
CREATE INDEX [IX_FK_EmpleadoComisionEmpleado]
ON [dbo].[ComisionEmpleadoes]
    ([EmpleadoId]);
GO

-- Creating foreign key on [CobroId] in table 'Pagoes'
ALTER TABLE [dbo].[Pagoes]
ADD CONSTRAINT [FK_CobroPago]
    FOREIGN KEY ([CobroId])
    REFERENCES [dbo].[Cobroes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CobroPago'
CREATE INDEX [IX_FK_CobroPago]
ON [dbo].[Pagoes]
    ([CobroId]);
GO

-- Creating foreign key on [Venta_Id] in table 'Cobroes'
ALTER TABLE [dbo].[Cobroes]
ADD CONSTRAINT [FK_CobroVenta]
    FOREIGN KEY ([Venta_Id])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CobroVenta'
CREATE INDEX [IX_FK_CobroVenta]
ON [dbo].[Cobroes]
    ([Venta_Id]);
GO

-- Creating foreign key on [Venta_Id] in table 'ComisionVentas'
ALTER TABLE [dbo].[ComisionVentas]
ADD CONSTRAINT [FK_ComisionVentaVenta]
    FOREIGN KEY ([Venta_Id])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComisionVentaVenta'
CREATE INDEX [IX_FK_ComisionVentaVenta]
ON [dbo].[ComisionVentas]
    ([Venta_Id]);
GO

-- Creating foreign key on [ComisionVentaId] in table 'ComisionOperacions'
ALTER TABLE [dbo].[ComisionOperacions]
ADD CONSTRAINT [FK_ComisionVentaComisionOperacion]
    FOREIGN KEY ([ComisionVentaId])
    REFERENCES [dbo].[ComisionVentas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComisionVentaComisionOperacion'
CREATE INDEX [IX_FK_ComisionVentaComisionOperacion]
ON [dbo].[ComisionOperacions]
    ([ComisionVentaId]);
GO

-- Creating foreign key on [ComisionOperacionId] in table 'ComisionEmpleadoes'
ALTER TABLE [dbo].[ComisionEmpleadoes]
ADD CONSTRAINT [FK_ComisionOperacionComisionEmpleado]
    FOREIGN KEY ([ComisionOperacionId])
    REFERENCES [dbo].[ComisionOperacions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComisionOperacionComisionEmpleado'
CREATE INDEX [IX_FK_ComisionOperacionComisionEmpleado]
ON [dbo].[ComisionEmpleadoes]
    ([ComisionOperacionId]);
GO

-- Creating foreign key on [ComisionOperacion_Id] in table 'Operacions'
ALTER TABLE [dbo].[Operacions]
ADD CONSTRAINT [FK_OperacionComisionOperacion]
    FOREIGN KEY ([ComisionOperacion_Id])
    REFERENCES [dbo].[ComisionOperacions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperacionComisionOperacion'
CREATE INDEX [IX_FK_OperacionComisionOperacion]
ON [dbo].[Operacions]
    ([ComisionOperacion_Id]);
GO

-- Creating foreign key on [DepartamentoId] in table 'Rangoes'
ALTER TABLE [dbo].[Rangoes]
ADD CONSTRAINT [FK_DepartamentoRango]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamentoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoRango'
CREATE INDEX [IX_FK_DepartamentoRango]
ON [dbo].[Rangoes]
    ([DepartamentoId]);
GO

-- Creating foreign key on [DepartamentoId] in table 'Operacions'
ALTER TABLE [dbo].[Operacions]
ADD CONSTRAINT [FK_DepartamentoOperacion]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamentoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoOperacion'
CREATE INDEX [IX_FK_DepartamentoOperacion]
ON [dbo].[Operacions]
    ([DepartamentoId]);
GO

-- Creating foreign key on [DepartamentoId] in table 'ComisionVentas'
ALTER TABLE [dbo].[ComisionVentas]
ADD CONSTRAINT [FK_DepartamentoComisionVenta]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamentoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoComisionVenta'
CREATE INDEX [IX_FK_DepartamentoComisionVenta]
ON [dbo].[ComisionVentas]
    ([DepartamentoId]);
GO

-- Creating foreign key on [EmpleadoId] in table 'PagoEmpleadoes'
ALTER TABLE [dbo].[PagoEmpleadoes]
ADD CONSTRAINT [FK_EmpleadoPagoEmpleado]
    FOREIGN KEY ([EmpleadoId])
    REFERENCES [dbo].[Personas_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoPagoEmpleado'
CREATE INDEX [IX_FK_EmpleadoPagoEmpleado]
ON [dbo].[PagoEmpleadoes]
    ([EmpleadoId]);
GO

-- Creating foreign key on [Operacions_Id] in table 'OperacionEmpleado'
ALTER TABLE [dbo].[OperacionEmpleado]
ADD CONSTRAINT [FK_OperacionEmpleado_Operacion]
    FOREIGN KEY ([Operacions_Id])
    REFERENCES [dbo].[Operacions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Empleadoes_Id] in table 'OperacionEmpleado'
ALTER TABLE [dbo].[OperacionEmpleado]
ADD CONSTRAINT [FK_OperacionEmpleado_Empleado]
    FOREIGN KEY ([Empleadoes_Id])
    REFERENCES [dbo].[Personas_Empleado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperacionEmpleado_Empleado'
CREATE INDEX [IX_FK_OperacionEmpleado_Empleado]
ON [dbo].[OperacionEmpleado]
    ([Empleadoes_Id]);
GO

-- Creating foreign key on [Id] in table 'Personas_Cliente'
ALTER TABLE [dbo].[Personas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Personas_Representante'
ALTER TABLE [dbo].[Personas_Representante]
ADD CONSTRAINT [FK_Representante_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Personas_Empleado'
ALTER TABLE [dbo].[Personas_Empleado]
ADD CONSTRAINT [FK_Empleado_inherits_Persona]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------