USE eproject3
GO



if exists (select * from dbo.sysobjects where id = object_id(N'Area_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Area_Insert
GO
CREATE PROCEDURE Area_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@ShortName varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Area]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IsDeleted],
	[Name],
	[ShortName],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IsDeleted,
	@Name,
	@ShortName,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Area_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Area_Update
GO
CREATE PROCEDURE Area_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@ShortName varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Area]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[ShortName] = @ShortName,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Area_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Area_SelectAll
GO
CREATE PROCEDURE Area_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IsDeleted], [Name], [ShortName], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Area]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Area_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Area_DeleteByPrimaryKey
GO
CREATE PROCEDURE Area_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Area]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Connection_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Connection_Insert
GO
CREATE PROCEDURE Connection_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdConnectionStatus int = null ,
	@IdContract int ,
	@IdDevice int ,
	@IdServicePack int ,
	@IsDeleted int = null ,
	@StartDate datetime2 ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Connection]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdConnectionStatus],
	[IdContract],
	[IdDevice],
	[IdServicePack],
	[IsDeleted],
	[StartDate],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdConnectionStatus,
	@IdContract,
	@IdDevice,
	@IdServicePack,
	@IsDeleted,
	@StartDate,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Connection_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Connection_Update
GO
CREATE PROCEDURE Connection_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdConnectionStatus int = null,
	@IdContract int,
	@IdDevice int,
	@IdServicePack int,
	@IsDeleted int = null,
	@StartDate datetime2,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Connection]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdConnectionStatus] = @IdConnectionStatus,
	[IdContract] = @IdContract,
	[IdDevice] = @IdDevice,
	[IdServicePack] = @IdServicePack,
	[IsDeleted] = @IsDeleted,
	[StartDate] = @StartDate,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Connection_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Connection_SelectAll
GO
CREATE PROCEDURE Connection_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IdConnectionStatus], [IdContract], [IdDevice], [IdServicePack], [IsDeleted], [StartDate], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Connection]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Connection_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Connection_DeleteByPrimaryKey
GO
CREATE PROCEDURE Connection_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Connection]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionStatus_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionStatus_Insert
GO
CREATE PROCEDURE ConnectionStatus_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ConnectionStatus]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionStatus_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionStatus_Update
GO
CREATE PROCEDURE ConnectionStatus_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ConnectionStatus]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionStatus_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionStatus_SelectAll
GO
CREATE PROCEDURE ConnectionStatus_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ConnectionStatus]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionStatus_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionStatus_DeleteByPrimaryKey
GO
CREATE PROCEDURE ConnectionStatus_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ConnectionStatus]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionType_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionType_Insert
GO
CREATE PROCEDURE ConnectionType_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ConnectionType]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionType_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionType_Update
GO
CREATE PROCEDURE ConnectionType_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ConnectionType]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionType_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionType_SelectAll
GO
CREATE PROCEDURE ConnectionType_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ConnectionType]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ConnectionType_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ConnectionType_DeleteByPrimaryKey
GO
CREATE PROCEDURE ConnectionType_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ConnectionType]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Contract_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Contract_Insert
GO
CREATE PROCEDURE Contract_Insert
	@Address varchar(255) ,
	@ContractId varchar(45) ,
	@CreatedAt datetime2 ,
	@CreatedBy int = null ,
	@Id int ,
	@IdArea int ,
	@IdCustomer int ,
	@IsDeleted int = null ,
	@NextPayment datetime2 = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Contract]
(
	[Address],
	[ContractId],
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdArea],
	[IdCustomer],
	[IsDeleted],
	[NextPayment],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Address,
	@ContractId,
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdArea,
	@IdCustomer,
	@IsDeleted,
	@NextPayment,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Contract_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Contract_Update
GO
CREATE PROCEDURE Contract_Update
	@Address varchar(255),
	@ContractId varchar(45),
	@CreatedAt datetime2,
	@CreatedBy int = null,
	@Id int,
	@IdArea int,
	@IdCustomer int,
	@IsDeleted int = null,
	@NextPayment datetime2 = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Contract]
SET
	[Address] = @Address,
	[ContractId] = @ContractId,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdArea] = @IdArea,
	[IdCustomer] = @IdCustomer,
	[IsDeleted] = @IsDeleted,
	[NextPayment] = @NextPayment,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Contract_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Contract_SelectAll
GO
CREATE PROCEDURE Contract_SelectAll
AS

	SELECT 
		[Address], [ContractId], [CreatedAt], [CreatedBy], [Id], [IdArea], [IdCustomer], [IsDeleted], [NextPayment], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Contract]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Contract_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Contract_DeleteByPrimaryKey
GO
CREATE PROCEDURE Contract_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Contract]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ContractStatus_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ContractStatus_Insert
GO
CREATE PROCEDURE ContractStatus_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ContractStatus]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ContractStatus_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ContractStatus_Update
GO
CREATE PROCEDURE ContractStatus_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ContractStatus]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ContractStatus_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ContractStatus_SelectAll
GO
CREATE PROCEDURE ContractStatus_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ContractStatus]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ContractStatus_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ContractStatus_DeleteByPrimaryKey
GO
CREATE PROCEDURE ContractStatus_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ContractStatus]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Customer_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Customer_Insert
GO
CREATE PROCEDURE Customer_Insert
	@Address varchar(255) ,
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Email varchar(255) ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@Phone varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Customer]
(
	[Address],
	[CreatedAt],
	[CreatedBy],
	[Email],
	[Id],
	[IsDeleted],
	[Name],
	[Phone],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Address,
	@CreatedAt,
	@CreatedBy,
	@Email,
	@Id,
	@IsDeleted,
	@Name,
	@Phone,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Customer_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Customer_Update
GO
CREATE PROCEDURE Customer_Update
	@Address varchar(255),
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Email varchar(255),
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@Phone varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Customer]
SET
	[Address] = @Address,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Email] = @Email,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[Phone] = @Phone,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Customer_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Customer_SelectAll
GO
CREATE PROCEDURE Customer_SelectAll
AS

	SELECT 
		[Address], [CreatedAt], [CreatedBy], [Email], [Id], [IsDeleted], [Name], [Phone], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Customer]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Customer_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Customer_DeleteByPrimaryKey
GO
CREATE PROCEDURE Customer_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Customer]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'CustomerFeedback_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure CustomerFeedback_Insert
GO
CREATE PROCEDURE CustomerFeedback_Insert
	@Content varchar(255) ,
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdCustomer int ,
	@IsDeleted int = null ,
	@Rating int = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[CustomerFeedback]
(
	[Content],
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdCustomer],
	[IsDeleted],
	[Rating],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Content,
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdCustomer,
	@IsDeleted,
	@Rating,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'CustomerFeedback_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure CustomerFeedback_Update
GO
CREATE PROCEDURE CustomerFeedback_Update
	@Content varchar(255),
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdCustomer int,
	@IsDeleted int = null,
	@Rating int = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[CustomerFeedback]
SET
	[Content] = @Content,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdCustomer] = @IdCustomer,
	[IsDeleted] = @IsDeleted,
	[Rating] = @Rating,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'CustomerFeedback_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure CustomerFeedback_SelectAll
GO
CREATE PROCEDURE CustomerFeedback_SelectAll
AS

	SELECT 
		[Content], [CreatedAt], [CreatedBy], [Id], [IdCustomer], [IsDeleted], [Rating], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[CustomerFeedback]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'CustomerFeedback_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure CustomerFeedback_DeleteByPrimaryKey
GO
CREATE PROCEDURE CustomerFeedback_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[CustomerFeedback]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'DetailImportReceipt_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DetailImportReceipt_Insert
GO
CREATE PROCEDURE DetailImportReceipt_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@IdDevice int ,
	@IdImportReceipt int ,
	@IsDeleted int = null ,
	@Price decimal(10,2) = null ,
	@Quantity int = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[DetailImportReceipt]
(
	[CreatedAt],
	[CreatedBy],
	[IdDevice],
	[IdImportReceipt],
	[IsDeleted],
	[Price],
	[Quantity],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@IdDevice,
	@IdImportReceipt,
	@IsDeleted,
	@Price,
	@Quantity,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'DetailImportReceipt_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DetailImportReceipt_Update
GO
CREATE PROCEDURE DetailImportReceipt_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@IdDevice int,
	@IdImportReceipt int,
	@IsDeleted int = null,
	@Price decimal(10,2) = null,
	@Quantity int = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[DetailImportReceipt]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[IdDevice] = @IdDevice,
	[IdImportReceipt] = @IdImportReceipt,
	[IsDeleted] = @IsDeleted,
	[Price] = @Price,
	[Quantity] = @Quantity,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[IdDevice] = @IdDevice AND 
	[IdImportReceipt] = @IdImportReceipt

GO

if exists (select * from dbo.sysobjects where id = object_id(N'DetailImportReceipt_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DetailImportReceipt_SelectAll
GO
CREATE PROCEDURE DetailImportReceipt_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [IdDevice], [IdImportReceipt], [IsDeleted], [Price], [Quantity], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[DetailImportReceipt]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'DetailImportReceipt_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DetailImportReceipt_DeleteByPrimaryKey
GO
CREATE PROCEDURE DetailImportReceipt_DeleteByPrimaryKey
	@IdDevice int,
	@IdImportReceipt int
AS

DELETE FROM [dbo].[DetailImportReceipt]
 WHERE 
	[IdDevice] = @IdDevice AND 
	[IdImportReceipt] = @IdImportReceipt

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Device_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Device_Insert
GO
CREATE PROCEDURE Device_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdDeviceType int ,
	@IdManufacturer int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@Stock int = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null ,
	@Using int = null 

AS

INSERT [dbo].[Device]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdDeviceType],
	[IdManufacturer],
	[IsDeleted],
	[Name],
	[Stock],
	[UpdatedAt],
	[UpdatedBy],
	[Using]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdDeviceType,
	@IdManufacturer,
	@IsDeleted,
	@Name,
	@Stock,
	@UpdatedAt,
	@UpdatedBy,
	@Using

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Device_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Device_Update
GO
CREATE PROCEDURE Device_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdDeviceType int,
	@IdManufacturer int,
	@IsDeleted int = null,
	@Name varchar(255),
	@Stock int = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null,
	@Using int = null

AS

UPDATE [dbo].[Device]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdDeviceType] = @IdDeviceType,
	[IdManufacturer] = @IdManufacturer,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[Stock] = @Stock,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy,
	[Using] = @Using
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Device_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Device_SelectAll
GO
CREATE PROCEDURE Device_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IdDeviceType], [IdManufacturer], [IsDeleted], [Name], [Stock], [UpdatedAt], [UpdatedBy], [Using]
	FROM [dbo].[Device]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Device_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Device_DeleteByPrimaryKey
GO
CREATE PROCEDURE Device_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Device]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'DeviceType_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DeviceType_Insert
GO
CREATE PROCEDURE DeviceType_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[DeviceType]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'DeviceType_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DeviceType_Update
GO
CREATE PROCEDURE DeviceType_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[DeviceType]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'DeviceType_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DeviceType_SelectAll
GO
CREATE PROCEDURE DeviceType_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[DeviceType]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'DeviceType_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure DeviceType_DeleteByPrimaryKey
GO
CREATE PROCEDURE DeviceType_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[DeviceType]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Employee_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Employee_Insert
GO
CREATE PROCEDURE Employee_Insert
	@Address varchar(255) ,
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Email varchar(255) ,
	@Id int ,
	@IdStore int ,
	@IsActivated int = null ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@Password varchar(255) ,
	@Phone varchar(255) ,
	@Role varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Employee]
(
	[Address],
	[CreatedAt],
	[CreatedBy],
	[Email],
	[Id],
	[IdStore],
	[IsActivated],
	[IsDeleted],
	[Name],
	[Password],
	[Phone],
	[Role],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Address,
	@CreatedAt,
	@CreatedBy,
	@Email,
	@Id,
	@IdStore,
	@IsActivated,
	@IsDeleted,
	@Name,
	@Password,
	@Phone,
	@Role,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Employee_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Employee_Update
GO
CREATE PROCEDURE Employee_Update
	@Address varchar(255),
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Email varchar(255),
	@Id int,
	@IdStore int,
	@IsActivated int = null,
	@IsDeleted int = null,
	@Name varchar(255),
	@Password varchar(255),
	@Phone varchar(255),
	@Role varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Employee]
SET
	[Address] = @Address,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Email] = @Email,
	[Id] = @Id,
	[IdStore] = @IdStore,
	[IsActivated] = @IsActivated,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[Password] = @Password,
	[Phone] = @Phone,
	[Role] = @Role,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Employee_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Employee_SelectAll
GO
CREATE PROCEDURE Employee_SelectAll
AS

	SELECT 
		[Address], [CreatedAt], [CreatedBy], [Email], [Id], [IdStore], [IsActivated], [IsDeleted], [Name], [Password], [Phone], [Role], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Employee]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Employee_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Employee_DeleteByPrimaryKey
GO
CREATE PROCEDURE Employee_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Employee]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Fee_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Fee_Insert
GO
CREATE PROCEDURE Fee_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Fee]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Fee_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Fee_Update
GO
CREATE PROCEDURE Fee_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Fee]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Fee_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Fee_SelectAll
GO
CREATE PROCEDURE Fee_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Fee]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Fee_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Fee_DeleteByPrimaryKey
GO
CREATE PROCEDURE Fee_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Fee]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Image_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Image_Insert
GO
CREATE PROCEDURE Image_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdCustomer int = null ,
	@IsDeleted int = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null ,
	@Url varchar(255) = null 

AS

INSERT [dbo].[Image]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdCustomer],
	[IsDeleted],
	[UpdatedAt],
	[UpdatedBy],
	[Url]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdCustomer,
	@IsDeleted,
	@UpdatedAt,
	@UpdatedBy,
	@Url

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Image_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Image_Update
GO
CREATE PROCEDURE Image_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdCustomer int = null,
	@IsDeleted int = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null,
	@Url varchar(255) = null

AS

UPDATE [dbo].[Image]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdCustomer] = @IdCustomer,
	[IsDeleted] = @IsDeleted,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy,
	[Url] = @Url
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Image_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Image_SelectAll
GO
CREATE PROCEDURE Image_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IdCustomer], [IsDeleted], [UpdatedAt], [UpdatedBy], [Url]
	FROM [dbo].[Image]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Image_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Image_DeleteByPrimaryKey
GO
CREATE PROCEDURE Image_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Image]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ImportReceipt_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ImportReceipt_Insert
GO
CREATE PROCEDURE ImportReceipt_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdProvider int ,
	@ImportDate datetime2 ,
	@IsDeleted int = null ,
	@TotalPrice decimal(10,2) = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ImportReceipt]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdProvider],
	[ImportDate],
	[IsDeleted],
	[TotalPrice],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdProvider,
	@ImportDate,
	@IsDeleted,
	@TotalPrice,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ImportReceipt_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ImportReceipt_Update
GO
CREATE PROCEDURE ImportReceipt_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdProvider int,
	@ImportDate datetime2,
	@IsDeleted int = null,
	@TotalPrice decimal(10,2) = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ImportReceipt]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdProvider] = @IdProvider,
	[ImportDate] = @ImportDate,
	[IsDeleted] = @IsDeleted,
	[TotalPrice] = @TotalPrice,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ImportReceipt_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ImportReceipt_SelectAll
GO
CREATE PROCEDURE ImportReceipt_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IdProvider], [ImportDate], [IsDeleted], [TotalPrice], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ImportReceipt]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ImportReceipt_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ImportReceipt_DeleteByPrimaryKey
GO
CREATE PROCEDURE ImportReceipt_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ImportReceipt]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Manufacturer_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Manufacturer_Insert
GO
CREATE PROCEDURE Manufacturer_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Logo varchar(255) = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Manufacturer]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IsDeleted],
	[Logo],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IsDeleted,
	@Logo,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Manufacturer_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Manufacturer_Update
GO
CREATE PROCEDURE Manufacturer_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IsDeleted int = null,
	@Logo varchar(255) = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Manufacturer]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Logo] = @Logo,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Manufacturer_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Manufacturer_SelectAll
GO
CREATE PROCEDURE Manufacturer_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IsDeleted], [Logo], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Manufacturer]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Manufacturer_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Manufacturer_DeleteByPrimaryKey
GO
CREATE PROCEDURE Manufacturer_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Manufacturer]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Payment_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Payment_Insert
GO
CREATE PROCEDURE Payment_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdContract int ,
	@IsDeleted int = null ,
	@PayDate datetime2 = null ,
	@TotalPrice decimal(10,2) = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Payment]
(
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdContract],
	[IsDeleted],
	[PayDate],
	[TotalPrice],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdContract,
	@IsDeleted,
	@PayDate,
	@TotalPrice,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Payment_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Payment_Update
GO
CREATE PROCEDURE Payment_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdContract int,
	@IsDeleted int = null,
	@PayDate datetime2 = null,
	@TotalPrice decimal(10,2) = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Payment]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdContract] = @IdContract,
	[IsDeleted] = @IsDeleted,
	[PayDate] = @PayDate,
	[TotalPrice] = @TotalPrice,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Payment_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Payment_SelectAll
GO
CREATE PROCEDURE Payment_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Id], [IdContract], [IsDeleted], [PayDate], [TotalPrice], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Payment]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Payment_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Payment_DeleteByPrimaryKey
GO
CREATE PROCEDURE Payment_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Payment]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'PaymentFee_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure PaymentFee_Insert
GO
CREATE PROCEDURE PaymentFee_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@IdFee int ,
	@IdPayment int ,
	@IsDeleted int = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null ,
	@Value varchar(255) 

AS

INSERT [dbo].[PaymentFee]
(
	[CreatedAt],
	[CreatedBy],
	[IdFee],
	[IdPayment],
	[IsDeleted],
	[UpdatedAt],
	[UpdatedBy],
	[Value]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@IdFee,
	@IdPayment,
	@IsDeleted,
	@UpdatedAt,
	@UpdatedBy,
	@Value

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'PaymentFee_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure PaymentFee_Update
GO
CREATE PROCEDURE PaymentFee_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@IdFee int,
	@IdPayment int,
	@IsDeleted int = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null,
	@Value varchar(255)

AS

UPDATE [dbo].[PaymentFee]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[IdFee] = @IdFee,
	[IdPayment] = @IdPayment,
	[IsDeleted] = @IsDeleted,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy,
	[Value] = @Value
 WHERE 
	[IdFee] = @IdFee AND 
	[IdPayment] = @IdPayment

GO

if exists (select * from dbo.sysobjects where id = object_id(N'PaymentFee_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure PaymentFee_SelectAll
GO
CREATE PROCEDURE PaymentFee_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [IdFee], [IdPayment], [IsDeleted], [UpdatedAt], [UpdatedBy], [Value]
	FROM [dbo].[PaymentFee]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'PaymentFee_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure PaymentFee_DeleteByPrimaryKey
GO
CREATE PROCEDURE PaymentFee_DeleteByPrimaryKey
	@IdFee int,
	@IdPayment int
AS

DELETE FROM [dbo].[PaymentFee]
 WHERE 
	[IdFee] = @IdFee AND 
	[IdPayment] = @IdPayment

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Provider_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Provider_Insert
GO
CREATE PROCEDURE Provider_Insert
	@Address varchar(255) ,
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Email varchar(255) ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@Phone varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Provider]
(
	[Address],
	[CreatedAt],
	[CreatedBy],
	[Email],
	[Id],
	[IsDeleted],
	[Name],
	[Phone],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Address,
	@CreatedAt,
	@CreatedBy,
	@Email,
	@Id,
	@IsDeleted,
	@Name,
	@Phone,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Provider_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Provider_Update
GO
CREATE PROCEDURE Provider_Update
	@Address varchar(255),
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Email varchar(255),
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@Phone varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Provider]
SET
	[Address] = @Address,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Email] = @Email,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[Phone] = @Phone,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Provider_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Provider_SelectAll
GO
CREATE PROCEDURE Provider_SelectAll
AS

	SELECT 
		[Address], [CreatedAt], [CreatedBy], [Email], [Id], [IsDeleted], [Name], [Phone], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Provider]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Provider_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Provider_DeleteByPrimaryKey
GO
CREATE PROCEDURE Provider_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Provider]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceForm_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceForm_Insert
GO
CREATE PROCEDURE ServiceForm_Insert
	@Address varchar(255) ,
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdArea int ,
	@IdCustomer int = null ,
	@IdEmployee int = null ,
	@IdServiceFormStatus int = null ,
	@IdServicePack int ,
	@IsDeleted int = null ,
	@ServiceFormId varchar(255) = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ServiceForm]
(
	[Address],
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdArea],
	[IdCustomer],
	[IdEmployee],
	[IdServiceFormStatus],
	[IdServicePack],
	[IsDeleted],
	[ServiceFormId],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Address,
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdArea,
	@IdCustomer,
	@IdEmployee,
	@IdServiceFormStatus,
	@IdServicePack,
	@IsDeleted,
	@ServiceFormId,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceForm_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceForm_Update
GO
CREATE PROCEDURE ServiceForm_Update
	@Address varchar(255),
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdArea int,
	@IdCustomer int = null,
	@IdEmployee int = null,
	@IdServiceFormStatus int = null,
	@IdServicePack int,
	@IsDeleted int = null,
	@ServiceFormId varchar(255) = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ServiceForm]
SET
	[Address] = @Address,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdArea] = @IdArea,
	[IdCustomer] = @IdCustomer,
	[IdEmployee] = @IdEmployee,
	[IdServiceFormStatus] = @IdServiceFormStatus,
	[IdServicePack] = @IdServicePack,
	[IsDeleted] = @IsDeleted,
	[ServiceFormId] = @ServiceFormId,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceForm_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceForm_SelectAll
GO
CREATE PROCEDURE ServiceForm_SelectAll
AS

	SELECT 
		[Address], [CreatedAt], [CreatedBy], [Id], [IdArea], [IdCustomer], [IdEmployee], [IdServiceFormStatus], [IdServicePack], [IsDeleted], [ServiceFormId], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ServiceForm]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceForm_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceForm_DeleteByPrimaryKey
GO
CREATE PROCEDURE ServiceForm_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ServiceForm]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceFormStatus_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceFormStatus_Insert
GO
CREATE PROCEDURE ServiceFormStatus_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ServiceFormStatus]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceFormStatus_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceFormStatus_Update
GO
CREATE PROCEDURE ServiceFormStatus_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ServiceFormStatus]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceFormStatus_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceFormStatus_SelectAll
GO
CREATE PROCEDURE ServiceFormStatus_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ServiceFormStatus]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServiceFormStatus_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServiceFormStatus_DeleteByPrimaryKey
GO
CREATE PROCEDURE ServiceFormStatus_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ServiceFormStatus]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePack_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePack_Insert
GO
CREATE PROCEDURE ServicePack_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Description varchar(255) = null ,
	@Id int ,
	@IdConnectionType int ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[ServicePack]
(
	[CreatedAt],
	[CreatedBy],
	[Description],
	[Id],
	[IdConnectionType],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@Description,
	@Id,
	@IdConnectionType,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePack_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePack_Update
GO
CREATE PROCEDURE ServicePack_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Description varchar(255) = null,
	@Id int,
	@IdConnectionType int,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[ServicePack]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Description] = @Description,
	[Id] = @Id,
	[IdConnectionType] = @IdConnectionType,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePack_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePack_SelectAll
GO
CREATE PROCEDURE ServicePack_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [Description], [Id], [IdConnectionType], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[ServicePack]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePack_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePack_DeleteByPrimaryKey
GO
CREATE PROCEDURE ServicePack_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[ServicePack]
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePackFee_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePackFee_Insert
GO
CREATE PROCEDURE ServicePackFee_Insert
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@IdFee int ,
	@IdServicePack int ,
	@IsDeleted int = null ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null ,
	@Value varchar(255) 

AS

INSERT [dbo].[ServicePackFee]
(
	[CreatedAt],
	[CreatedBy],
	[IdFee],
	[IdServicePack],
	[IsDeleted],
	[UpdatedAt],
	[UpdatedBy],
	[Value]

)
VALUES
(
	@CreatedAt,
	@CreatedBy,
	@IdFee,
	@IdServicePack,
	@IsDeleted,
	@UpdatedAt,
	@UpdatedBy,
	@Value

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePackFee_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePackFee_Update
GO
CREATE PROCEDURE ServicePackFee_Update
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@IdFee int,
	@IdServicePack int,
	@IsDeleted int = null,
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null,
	@Value varchar(255)

AS

UPDATE [dbo].[ServicePackFee]
SET
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[IdFee] = @IdFee,
	[IdServicePack] = @IdServicePack,
	[IsDeleted] = @IsDeleted,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy,
	[Value] = @Value
 WHERE 
	[IdFee] = @IdFee AND 
	[IdServicePack] = @IdServicePack

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePackFee_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePackFee_SelectAll
GO
CREATE PROCEDURE ServicePackFee_SelectAll
AS

	SELECT 
		[CreatedAt], [CreatedBy], [IdFee], [IdServicePack], [IsDeleted], [UpdatedAt], [UpdatedBy], [Value]
	FROM [dbo].[ServicePackFee]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'ServicePackFee_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure ServicePackFee_DeleteByPrimaryKey
GO
CREATE PROCEDURE ServicePackFee_DeleteByPrimaryKey
	@IdFee int,
	@IdServicePack int
AS

DELETE FROM [dbo].[ServicePackFee]
 WHERE 
	[IdFee] = @IdFee AND 
	[IdServicePack] = @IdServicePack

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Store_Insert') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Store_Insert
GO
CREATE PROCEDURE Store_Insert
	@Address varchar(255) ,
	@CreatedAt datetime2 = null ,
	@CreatedBy int = null ,
	@Id int ,
	@IdArea int ,
	@IsClosed int = null ,
	@IsDeleted int = null ,
	@Name varchar(255) ,
	@UpdatedAt datetime2 = null ,
	@UpdatedBy int = null 

AS

INSERT [dbo].[Store]
(
	[Address],
	[CreatedAt],
	[CreatedBy],
	[Id],
	[IdArea],
	[IsClosed],
	[IsDeleted],
	[Name],
	[UpdatedAt],
	[UpdatedBy]

)
VALUES
(
	@Address,
	@CreatedAt,
	@CreatedBy,
	@Id,
	@IdArea,
	@IsClosed,
	@IsDeleted,
	@Name,
	@UpdatedAt,
	@UpdatedBy

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'Store_Update') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Store_Update
GO
CREATE PROCEDURE Store_Update
	@Address varchar(255),
	@CreatedAt datetime2 = null,
	@CreatedBy int = null,
	@Id int,
	@IdArea int,
	@IsClosed int = null,
	@IsDeleted int = null,
	@Name varchar(255),
	@UpdatedAt datetime2 = null,
	@UpdatedBy int = null

AS

UPDATE [dbo].[Store]
SET
	[Address] = @Address,
	[CreatedAt] = @CreatedAt,
	[CreatedBy] = @CreatedBy,
	[Id] = @Id,
	[IdArea] = @IdArea,
	[IsClosed] = @IsClosed,
	[IsDeleted] = @IsDeleted,
	[Name] = @Name,
	[UpdatedAt] = @UpdatedAt,
	[UpdatedBy] = @UpdatedBy
 WHERE 
	[Id] = @Id

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Store_SelectAll') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Store_SelectAll
GO
CREATE PROCEDURE Store_SelectAll
AS

	SELECT 
		[Address], [CreatedAt], [CreatedBy], [Id], [IdArea], [IsClosed], [IsDeleted], [Name], [UpdatedAt], [UpdatedBy]
	FROM [dbo].[Store]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'Store_DeleteByPrimaryKey') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure Store_DeleteByPrimaryKey
GO
CREATE PROCEDURE Store_DeleteByPrimaryKey
	@Id int
AS

DELETE FROM [dbo].[Store]
 WHERE 
	[Id] = @Id

GO
