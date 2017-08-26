
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/26/2017 19:40:53
-- Generated from EDMX file: C:\Users\Alex Milleman\Documents\GitHub\8451hack\DataAccess\Models\HackModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [84.51hack];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_HouseholdTransactionRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransactionRecords] DROP CONSTRAINT [FK_HouseholdTransactionRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_BasketTransactionRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransactionRecords] DROP CONSTRAINT [FK_BasketTransactionRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductTransactionRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransactionRecords] DROP CONSTRAINT [FK_ProductTransactionRecord];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TransactionRecords]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionRecords];
GO
IF OBJECT_ID(N'[dbo].[Households]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Households];
GO
IF OBJECT_ID(N'[dbo].[Baskets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Baskets];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TransactionRecords'
CREATE TABLE [dbo].[TransactionRecords] (
    [TransactionRecordID] int IDENTITY(1,1) NOT NULL,
    [TransTime] nvarchar(max)  NOT NULL,
    [HouseholdID] int  NOT NULL,
    [BasketID] int  NOT NULL,
    [ProductID] int  NOT NULL
);
GO

-- Creating table 'Households'
CREATE TABLE [dbo].[Households] (
    [HouseholdID] int IDENTITY(1,1) NOT NULL,
    [TransactionRecordID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Baskets'
CREATE TABLE [dbo].[Baskets] (
    [BasketID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TransactionRecordID] in table 'TransactionRecords'
ALTER TABLE [dbo].[TransactionRecords]
ADD CONSTRAINT [PK_TransactionRecords]
    PRIMARY KEY CLUSTERED ([TransactionRecordID] ASC);
GO

-- Creating primary key on [HouseholdID] in table 'Households'
ALTER TABLE [dbo].[Households]
ADD CONSTRAINT [PK_Households]
    PRIMARY KEY CLUSTERED ([HouseholdID] ASC);
GO

-- Creating primary key on [BasketID] in table 'Baskets'
ALTER TABLE [dbo].[Baskets]
ADD CONSTRAINT [PK_Baskets]
    PRIMARY KEY CLUSTERED ([BasketID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [HouseholdID] in table 'TransactionRecords'
ALTER TABLE [dbo].[TransactionRecords]
ADD CONSTRAINT [FK_HouseholdTransactionRecord]
    FOREIGN KEY ([HouseholdID])
    REFERENCES [dbo].[Households]
        ([HouseholdID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HouseholdTransactionRecord'
CREATE INDEX [IX_FK_HouseholdTransactionRecord]
ON [dbo].[TransactionRecords]
    ([HouseholdID]);
GO

-- Creating foreign key on [BasketID] in table 'TransactionRecords'
ALTER TABLE [dbo].[TransactionRecords]
ADD CONSTRAINT [FK_BasketTransactionRecord]
    FOREIGN KEY ([BasketID])
    REFERENCES [dbo].[Baskets]
        ([BasketID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BasketTransactionRecord'
CREATE INDEX [IX_FK_BasketTransactionRecord]
ON [dbo].[TransactionRecords]
    ([BasketID]);
GO

-- Creating foreign key on [ProductID] in table 'TransactionRecords'
ALTER TABLE [dbo].[TransactionRecords]
ADD CONSTRAINT [FK_ProductTransactionRecord]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductTransactionRecord'
CREATE INDEX [IX_FK_ProductTransactionRecord]
ON [dbo].[TransactionRecords]
    ([ProductID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------