CREATE TABLE [dbo].[Appliance] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (100)  NOT NULL,
    [PowerConsumption ] DECIMAL (10, 2) NOT NULL,
    [UsageHoursPerDay]  DECIMAL (5, 2)  NOT NULL,
    [DateAdded]         DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)

);

