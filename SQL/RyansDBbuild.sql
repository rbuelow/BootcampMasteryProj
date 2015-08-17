
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/13/2015 15:48:31
-- Generated from EDMX file: C:\Users\CodeCamp\Desktop\swcguild git dir\RyanNickMasteryProject\RyanNickMasteryProject\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SWC_LMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Assignmen__Cours__20C1E124]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assignment] DROP CONSTRAINT [FK__Assignmen__Cours__20C1E124];
GO
IF OBJECT_ID(N'[dbo].[FK__Course__SubjectI__182C9B23]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK__Course__SubjectI__182C9B23];
GO
IF OBJECT_ID(N'[dbo].[FK__Course__UserId__173876EA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK__Course__UserId__173876EA];
GO
IF OBJECT_ID(N'[dbo].[FK__LmsUser__GradeLe__1273C1CD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LmsUser] DROP CONSTRAINT [FK__LmsUser__GradeLe__1273C1CD];
GO
IF OBJECT_ID(N'[dbo].[FK__Roster__CourseId__1BFD2C07]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roster] DROP CONSTRAINT [FK__Roster__CourseId__1BFD2C07];
GO
IF OBJECT_ID(N'[dbo].[FK__Roster__UserId__1CF15040]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roster] DROP CONSTRAINT [FK__Roster__UserId__1CF15040];
GO
IF OBJECT_ID(N'[dbo].[FK__RosterAss__Assig__24927208]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RosterAssignment] DROP CONSTRAINT [FK__RosterAss__Assig__24927208];
GO
IF OBJECT_ID(N'[dbo].[FK__RosterAss__Roste__239E4DCF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RosterAssignment] DROP CONSTRAINT [FK__RosterAss__Roste__239E4DCF];
GO
IF OBJECT_ID(N'[dbo].[FK__StudentGu__Guard__276EDEB3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentGuardian] DROP CONSTRAINT [FK__StudentGu__Guard__276EDEB3];
GO
IF OBJECT_ID(N'[dbo].[FK__StudentGu__Stude__286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentGuardian] DROP CONSTRAINT [FK__StudentGu__Stude__286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[Assignment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Assignment];
GO
IF OBJECT_ID(N'[dbo].[Course]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course];
GO
IF OBJECT_ID(N'[dbo].[GradeLevel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GradeLevel];
GO
IF OBJECT_ID(N'[dbo].[LmsUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LmsUser];
GO
IF OBJECT_ID(N'[dbo].[Roster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roster];
GO
IF OBJECT_ID(N'[dbo].[RosterAssignment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RosterAssignment];
GO
IF OBJECT_ID(N'[dbo].[StudentGuardian]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentGuardian];
GO
IF OBJECT_ID(N'[dbo].[Subject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subject];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'Assignments'
CREATE TABLE [dbo].[Assignments] (
    [AssignmentId] int IDENTITY(1,1) NOT NULL,
    [CourseId] int  NOT NULL,
    [AssignmentName] varchar(50)  NOT NULL,
    [PossiblePoints] int  NOT NULL,
    [DueDate] datetime  NOT NULL,
    [AssignmentDescription] varchar(255)  NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseId] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [SubjectId] int  NOT NULL,
    [CourseName] varchar(50)  NOT NULL,
    [CourseDescription] varchar(255)  NULL,
    [GradeLevel] tinyint  NOT NULL,
    [IsArchived] bit  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL
);
GO

-- Creating table 'GradeLevels'
CREATE TABLE [dbo].[GradeLevels] (
    [GradeLevelId] tinyint IDENTITY(1,1) NOT NULL,
    [GradeLevelName] varchar(10)  NOT NULL
);
GO

-- Creating table 'LmsUsers'
CREATE TABLE [dbo].[LmsUsers] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Id] nvarchar(128)  NULL,
    [FirstName] varchar(30)  NOT NULL,
    [LastName] varchar(30)  NOT NULL,
    [Email] varchar(50)  NOT NULL,
    [SuggestedRole] varchar(50)  NULL,
    [GradeLevelId] tinyint  NULL
);
GO

-- Creating table 'Rosters'
CREATE TABLE [dbo].[Rosters] (
    [RosterId] int IDENTITY(1,1) NOT NULL,
    [CourseId] int  NOT NULL,
    [UserId] int  NOT NULL,
    [CurrentGrade] varchar(3)  NULL,
    [IsDeleted] bit  NOT NULL
);
GO

-- Creating table 'RosterAssignments'
CREATE TABLE [dbo].[RosterAssignments] (
    [RosterAssignmentId] int IDENTITY(1,1) NOT NULL,
    [RosterId] int  NOT NULL,
    [AssignmentId] int  NOT NULL,
    [PointsEarned] decimal(18,0)  NULL,
    [Percentage] decimal(5,2)  NULL,
    [Grade] varchar(3)  NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [SubjectId] int IDENTITY(1,1) NOT NULL,
    [SubjectName] varchar(50)  NOT NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'StudentGuardian'
CREATE TABLE [dbo].[StudentGuardian] (
    [LmsUsers_UserId] int  NOT NULL,
    [LmsUser1_UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AssignmentId] in table 'Assignments'
ALTER TABLE [dbo].[Assignments]
ADD CONSTRAINT [PK_Assignments]
    PRIMARY KEY CLUSTERED ([AssignmentId] ASC);
GO

-- Creating primary key on [CourseId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- Creating primary key on [GradeLevelId] in table 'GradeLevels'
ALTER TABLE [dbo].[GradeLevels]
ADD CONSTRAINT [PK_GradeLevels]
    PRIMARY KEY CLUSTERED ([GradeLevelId] ASC);
GO

-- Creating primary key on [UserId] in table 'LmsUsers'
ALTER TABLE [dbo].[LmsUsers]
ADD CONSTRAINT [PK_LmsUsers]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [RosterId] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [PK_Rosters]
    PRIMARY KEY CLUSTERED ([RosterId] ASC);
GO

-- Creating primary key on [RosterAssignmentId] in table 'RosterAssignments'
ALTER TABLE [dbo].[RosterAssignments]
ADD CONSTRAINT [PK_RosterAssignments]
    PRIMARY KEY CLUSTERED ([RosterAssignmentId] ASC);
GO

-- Creating primary key on [SubjectId] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([SubjectId] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- Creating primary key on [LmsUsers_UserId], [LmsUser1_UserId] in table 'StudentGuardian'
ALTER TABLE [dbo].[StudentGuardian]
ADD CONSTRAINT [PK_StudentGuardian]
    PRIMARY KEY CLUSTERED ([LmsUsers_UserId], [LmsUser1_UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [CourseId] in table 'Assignments'
ALTER TABLE [dbo].[Assignments]
ADD CONSTRAINT [FK__Assignmen__Cours__20C1E124]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Assignmen__Cours__20C1E124'
CREATE INDEX [IX_FK__Assignmen__Cours__20C1E124]
ON [dbo].[Assignments]
    ([CourseId]);
GO

-- Creating foreign key on [AssignmentId] in table 'RosterAssignments'
ALTER TABLE [dbo].[RosterAssignments]
ADD CONSTRAINT [FK__RosterAss__Assig__24927208]
    FOREIGN KEY ([AssignmentId])
    REFERENCES [dbo].[Assignments]
        ([AssignmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RosterAss__Assig__24927208'
CREATE INDEX [IX_FK__RosterAss__Assig__24927208]
ON [dbo].[RosterAssignments]
    ([AssignmentId]);
GO

-- Creating foreign key on [SubjectId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK__Course__SubjectI__182C9B23]
    FOREIGN KEY ([SubjectId])
    REFERENCES [dbo].[Subjects]
        ([SubjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Course__SubjectI__182C9B23'
CREATE INDEX [IX_FK__Course__SubjectI__182C9B23]
ON [dbo].[Courses]
    ([SubjectId]);
GO

-- Creating foreign key on [UserId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK__Course__UserId__173876EA]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[LmsUsers]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Course__UserId__173876EA'
CREATE INDEX [IX_FK__Course__UserId__173876EA]
ON [dbo].[Courses]
    ([UserId]);
GO

-- Creating foreign key on [CourseId] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [FK__Roster__CourseId__1BFD2C07]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Roster__CourseId__1BFD2C07'
CREATE INDEX [IX_FK__Roster__CourseId__1BFD2C07]
ON [dbo].[Rosters]
    ([CourseId]);
GO

-- Creating foreign key on [GradeLevelId] in table 'LmsUsers'
ALTER TABLE [dbo].[LmsUsers]
ADD CONSTRAINT [FK__LmsUser__GradeLe__1273C1CD]
    FOREIGN KEY ([GradeLevelId])
    REFERENCES [dbo].[GradeLevels]
        ([GradeLevelId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__LmsUser__GradeLe__1273C1CD'
CREATE INDEX [IX_FK__LmsUser__GradeLe__1273C1CD]
ON [dbo].[LmsUsers]
    ([GradeLevelId]);
GO

-- Creating foreign key on [UserId] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [FK__Roster__UserId__1CF15040]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[LmsUsers]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Roster__UserId__1CF15040'
CREATE INDEX [IX_FK__Roster__UserId__1CF15040]
ON [dbo].[Rosters]
    ([UserId]);
GO

-- Creating foreign key on [RosterId] in table 'RosterAssignments'
ALTER TABLE [dbo].[RosterAssignments]
ADD CONSTRAINT [FK__RosterAss__Roste__239E4DCF]
    FOREIGN KEY ([RosterId])
    REFERENCES [dbo].[Rosters]
        ([RosterId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RosterAss__Roste__239E4DCF'
CREATE INDEX [IX_FK__RosterAss__Roste__239E4DCF]
ON [dbo].[RosterAssignments]
    ([RosterId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [LmsUsers_UserId] in table 'StudentGuardian'
ALTER TABLE [dbo].[StudentGuardian]
ADD CONSTRAINT [FK_StudentGuardian_LmsUser]
    FOREIGN KEY ([LmsUsers_UserId])
    REFERENCES [dbo].[LmsUsers]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [LmsUser1_UserId] in table 'StudentGuardian'
ALTER TABLE [dbo].[StudentGuardian]
ADD CONSTRAINT [FK_StudentGuardian_LmsUser1]
    FOREIGN KEY ([LmsUser1_UserId])
    REFERENCES [dbo].[LmsUsers]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentGuardian_LmsUser1'
CREATE INDEX [IX_FK_StudentGuardian_LmsUser1]
ON [dbo].[StudentGuardian]
    ([LmsUser1_UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------