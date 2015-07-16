USE [Identity]
GO

--drop table Roles
--drop table UserClaims
--drop table UserLogins
--drop table UserRoles
--drop table Users
--drop schema [identity]

CREATE SCHEMA [identity]
GO

CREATE TABLE [identity].UserRoles (
    [Id]	 INT IDENTITY (1 ,1) NOT NULL,
    [UserId] NVARCHAR (128) NOT NULL,
    [RoleId] INT NOT NULL
);

CREATE TABLE [identity].UserClaims (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [UserId]     NVARCHAR (128) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL
);

CREATE TABLE [identity].UserLogins (
    [Id]			INT	IDENTITY (1, 1)  NOT NULL,
    [UserId]        NVARCHAR (128) NOT NULL,
    [LoginProvider] NVARCHAR (128) NOT NULL,
    [ProviderKey]   NVARCHAR (128) NOT NULL
);

CREATE TABLE [identity].Roles (
    [Id]   NVARCHAR (128) NOT NULL,
    [Name] NVARCHAR (256) NOT NULL
);

CREATE TABLE [identity].Users (
    [Id]                   NVARCHAR (128) NOT NULL,
    [Email]                NVARCHAR (256) NULL,
    [EmailConfirmed]       BIT            NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NULL,
    [SecurityStamp]        NVARCHAR (MAX) NULL,
    [PhoneNumber]          NVARCHAR (MAX) NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [TwoFactorEnabled]     BIT            NOT NULL,
    [LockoutEndDateUtc]    DATETIME       NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [UserName]             NVARCHAR (256) NOT NULL
);

