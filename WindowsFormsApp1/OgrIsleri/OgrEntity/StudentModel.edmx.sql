
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/06/2021 12:42:09
-- Generated from EDMX file: C:\Users\OZER\source\repos\CsharpWorms-Mo\WindowsFormsApp1\OgrIsleri\OgrEntity\StudentModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NORTHWND];
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

-- Creating table 'tbl_sehirler'
CREATE TABLE [dbo].[tbl_sehirler] (
    [id] int IDENTITY(1,1) NOT NULL,
    [sehir] nvarchar(255)  NULL
);
GO

-- Creating table 'tblDeparments'
CREATE TABLE [dbo].[tblDeparments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BolumAdi] nvarchar(100)  NULL,
    [isActive] bit  NULL
);
GO

-- Creating table 'tblOgrBilgi'
CREATE TABLE [dbo].[tblOgrBilgi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(50)  NULL,
    [Soyad] nvarchar(50)  NULL,
    [Tcno] nvarchar(11)  NULL,
    [OgrNo] nvarchar(10)  NULL,
    [BolumId] int  NULL,
    [SehirId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'tbl_sehirler'
ALTER TABLE [dbo].[tbl_sehirler]
ADD CONSTRAINT [PK_tbl_sehirler]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'tblDeparments'
ALTER TABLE [dbo].[tblDeparments]
ADD CONSTRAINT [PK_tblDeparments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'tblOgrBilgi'
ALTER TABLE [dbo].[tblOgrBilgi]
ADD CONSTRAINT [PK_tblOgrBilgi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SehirId] in table 'tblOgrBilgi'
ALTER TABLE [dbo].[tblOgrBilgi]
ADD CONSTRAINT [FK_tblOgrBilgi_tblSehirler]
    FOREIGN KEY ([SehirId])
    REFERENCES [dbo].[tbl_sehirler]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblOgrBilgi_tblSehirler'
CREATE INDEX [IX_FK_tblOgrBilgi_tblSehirler]
ON [dbo].[tblOgrBilgi]
    ([SehirId]);
GO

-- Creating foreign key on [BolumId] in table 'tblOgrBilgi'
ALTER TABLE [dbo].[tblOgrBilgi]
ADD CONSTRAINT [FK_tblOgrBilgi_tblDeparments]
    FOREIGN KEY ([BolumId])
    REFERENCES [dbo].[tblDeparments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblOgrBilgi_tblDeparments'
CREATE INDEX [IX_FK_tblOgrBilgi_tblDeparments]
ON [dbo].[tblOgrBilgi]
    ([BolumId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------