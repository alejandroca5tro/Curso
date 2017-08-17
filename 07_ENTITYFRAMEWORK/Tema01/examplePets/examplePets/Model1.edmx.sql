
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/12/2017 20:10:28
-- Generated from EDMX file: C:\AC\localServer\Curso\SERVER\3_ENTITYFRAMEWORK\Tema01\examplePets\examplePets\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Mascotas];
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

-- Creating table 'PersonaSet'
CREATE TABLE [dbo].[PersonaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AnimalSet'
CREATE TABLE [dbo].[AnimalSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [PersonaId] nvarchar(max)  NOT NULL,
    [ClaseAnimalId] nvarchar(max)  NOT NULL,
    [Persona_Id] int  NOT NULL,
    [ClaseAnimal_Id] int  NOT NULL
);
GO

-- Creating table 'ClaseAnimalSet'
CREATE TABLE [dbo].[ClaseAnimalSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PersonaSet'
ALTER TABLE [dbo].[PersonaSet]
ADD CONSTRAINT [PK_PersonaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AnimalSet'
ALTER TABLE [dbo].[AnimalSet]
ADD CONSTRAINT [PK_AnimalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClaseAnimalSet'
ALTER TABLE [dbo].[ClaseAnimalSet]
ADD CONSTRAINT [PK_ClaseAnimalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Persona_Id] in table 'AnimalSet'
ALTER TABLE [dbo].[AnimalSet]
ADD CONSTRAINT [FK_PersonaAnimal]
    FOREIGN KEY ([Persona_Id])
    REFERENCES [dbo].[PersonaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaAnimal'
CREATE INDEX [IX_FK_PersonaAnimal]
ON [dbo].[AnimalSet]
    ([Persona_Id]);
GO

-- Creating foreign key on [ClaseAnimal_Id] in table 'AnimalSet'
ALTER TABLE [dbo].[AnimalSet]
ADD CONSTRAINT [FK_ClaseAnimalAnimal]
    FOREIGN KEY ([ClaseAnimal_Id])
    REFERENCES [dbo].[ClaseAnimalSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClaseAnimalAnimal'
CREATE INDEX [IX_FK_ClaseAnimalAnimal]
ON [dbo].[AnimalSet]
    ([ClaseAnimal_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------