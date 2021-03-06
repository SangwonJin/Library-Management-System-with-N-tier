USE [master]
GO
/****** Object:  Database [AbcAcademy_Project]    Script Date: 2019-11-28 2:24:45 PM ******/
CREATE DATABASE [AbcAcademy_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AbcAcademy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AbcAcademy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AbcAcademy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\AbcAcademy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AbcAcademy_Project] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AbcAcademy_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AbcAcademy_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AbcAcademy_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AbcAcademy_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AbcAcademy_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AbcAcademy_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET RECOVERY FULL 
GO
ALTER DATABASE [AbcAcademy_Project] SET  MULTI_USER 
GO
ALTER DATABASE [AbcAcademy_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AbcAcademy_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AbcAcademy_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AbcAcademy_Project] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AbcAcademy_Project] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AbcAcademy_Project', N'ON'
GO
ALTER DATABASE [AbcAcademy_Project] SET QUERY_STORE = OFF
GO
USE [AbcAcademy_Project]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Type] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[LoanId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [nvarchar](8) NOT NULL,
	[ResourceId] [int] NOT NULL,
	[CheckoutDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[DateReturned] [datetime] NULL,
	[OverdueCharge] [smallmoney] NULL,
	[NonReturnCharge] [smallmoney] NULL,
	[LoanStatus] [int] NOT NULL,
 CONSTRAINT [PK__Loan__4F5AD457BED7CB73] PRIMARY KEY CLUSTERED 
(
	[LoanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [nvarchar](8) NOT NULL,
	[Date] [datetime] NOT NULL,
	[AmountOfPayment] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resource](
	[ResourceId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [nvarchar](8) NULL,
	[ResourceType] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Publisher] [varchar](30) NOT NULL,
	[PubRefNumber] [varchar](20) NOT NULL,
	[DateOfPurchase] [datetime] NOT NULL,
	[PurchasePrice] [money] NOT NULL,
	[ResourceStatus] [int] NOT NULL,
	[IsReserved] [bit] NULL,
	[DateRemoved] [datetime] NULL,
	[ImageOfItem] [varchar](255) NULL,
 CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED 
(
	[ResourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [nvarchar](8) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](30) NOT NULL,
	[City] [nvarchar](20) NOT NULL,
	[PostalCode] [char](7) NOT NULL,
	[Telephone] [varchar](12) NOT NULL,
	[Program] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[BalanceDue] [smallmoney] NOT NULL,
	[TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [PK__Student__32C52B994FB69BA2] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Resource] FOREIGN KEY([ResourceId])
REFERENCES [dbo].[Resource] ([ResourceId])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Resource]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_StudentId]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Payment] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Payment]
GO
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Student]
GO
/****** Object:  StoredProcedure [dbo].[spCheckoutResource]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCheckoutResource]
       @StudentId		nchar(8),		@ResourceId		int,
       @CheckOutDate	datetime,		@DueDate		datetime
AS

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
		RAISERROR ('The student is not on file', 16,1)
	IF NOT EXISTS (SELECT * FROM [Resource] WHERE ResourceId = @ResourceId)
		RAISERROR ('The resource is not on file', 16,1)

	BEGIN TRANSACTION
		INSERT INTO Loan (StudentId, ResourceId, CheckoutDate, DueDate,LoanStatus)
		VALUES (@StudentId, @ResourceId, @CheckoutDate, @DueDate,0);

		UPDATE [Resource] SET ResourceStatus = 1,StudentId = null,IsReserved=0 WHERE ResourceId = @ResourceId
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION
		END
	DECLARE @ErrorMessage nVarChar(4000) =
		'Error Number ' + Convert(varchar, ERROR_NUMBER(), 1) + ' Transaction rolled back - ' + ERROR_MESSAGE()
	DECLARE @ErrorSeverity Int = ERROR_SEVERITY()
	DECLARE @ErrorState Int = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spDeleteStudent]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteStudent]
	@StudentId	nchar(8)
AS

BEGIN TRY
	DECLARE @Error char(100)
	IF NOT EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
		BEGIN			
			SET @Error = 'The student is not on file'
			RAISERROR (@Error,16,1) 
		END
		DELETE FROM Student WHERE StudentId = @StudentId
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spInsertInstructor]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spInsertInstructor]
       @username nvarchar(20), 
	   @Password nvarchar(20),
       @InstructorType tinyint
AS



BEGIN TRY
	IF EXISTS (SELECT * FROM Instructor WHERE UserName = @username)
		BEGIN
			DECLARE @Error char(50)
			SET @Error = @username + ' is already on file'
			RAISERROR (@Error,16,1) 
		END
		INSERT INTO Instructor (UserName, [Password], Type) 
		VALUES (@username, @Password, @InstructorType)
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spInsertResource]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertResource]
       @ResourceType	tinyint,		@Title			nvarchar(50),
       @Publisher		nvarchar(30),	@PubRefNumber	nvarchar(20),
       @DateOfPurchase	date,			@PurchasePrice	smallmoney,
	   @ResourceStatus	tinyint,		@ImageOfItem	nvarchar(max) null,
	   @ResourceId		int
AS
SET IDENTITY_INSERT resource ON

BEGIN TRY
	IF @ResourceType = 1 OR @ResourceType = 2
		BEGIN
		IF EXISTS  (SELECT *
					FROM [Resource]
					WHERE ResourceType = @ResourceType AND Title = @Title AND Publisher = @Publisher)
			RAISERROR ('Cannot have more than one copy of each book and each manual', 16,1)
		END
	IF EXISTS ( SELECT * FROM Resource WHERE ResourceId = @ResourceId)
		BEGIN
			RAISERROR ('This Resource is already existing', 16,1)
		END
		
	BEGIN TRANSACTION
		INSERT INTO Resource 
			(ResourceId,ResourceType, Title, Publisher, PubRefNumber, DateOfPurchase, 
			PurchasePrice, ResourceStatus, ImageOfItem,IsReserved)
		VALUES 
			(@ResourceId,@ResourceType, @Title, @Publisher, @PubRefNumber, @DateOfPurchase, 
			@PurchasePrice, @ResourceStatus, @ImageOfItem,0)

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION
		END
	DECLARE @ErrorMessage nVarChar(4000) =
		'Error Number ' + Convert(varchar, ERROR_NUMBER(), 1) + ' Transaction rolled back - ' + ERROR_MESSAGE()
	DECLARE @ErrorSeverity Int = ERROR_SEVERITY()
	DECLARE @ErrorState Int = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spInsertStudent]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertStudent]
       @StudentId	nchar(8),		@FirstName nvarchar(30),
       @LastName	nvarchar(20),	@Address nvarchar(30),
       @City		nvarchar(20),	@PostalCode char(6),
	   @Telephone	varchar(13),	@ProgramOption tinyint,
	   @StartDate	date,			@EndDate date,
	   @IsActive	bit
AS

BEGIN TRY
	IF EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
		BEGIN
			DECLARE @Error char(50)
			SET @Error = 'The Student Id, ' + @StudentId + ', is already on file'
			RAISERROR (@Error,16,1) 
		END
		INSERT INTO Student 
			(StudentId, FirstName, LastName, [Address], City, PostalCode, 
			 Telephone, Program, StartDate, EndDate, IsActive, BalanceDue) 
		VALUES 
			(@StudentId, @FirstName, @LastName, @Address, @City, @PostalCode,
			 @Telephone, @ProgramOption, @StartDate, @EndDate, @IsActive, 0)
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLogin]
	@username	nvarchar(20),
	@Password		nvarchar(20)
	--@Result			int OUTPUT
AS

BEGIN TRY
	DECLARE @Error char(50)
	IF NOT EXISTS (SELECT * FROM Instructor  WHERE UserName = @username)
		BEGIN		
			SET @Error = 'The instructor not on file'
			RAISERROR (@Error,16,1) 
		END


	IF NOT EXISTS (SELECT * FROM Instructor WHERE UserName = @username AND Password = @Password)
		BEGIN		
			SET @Error = 'Incorrect password'
			RAISERROR (@Error,16,1) 
		END

	SELECT type FROM Instructor WHERE UserName = @username AND Password = @Password
	--SET @Result = (SELECT [type] FROM Instructor WHERE UserName = @username AND Password = @Password)
	--RETURN @Result
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spMakePayment]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[spMakePayment]
       @StudentId	nchar(8),		@AmountOfPayment	smallmoney,
	   @PaymentDate	datetime
AS

BEGIN TRY
	DECLARE @Error char(255)
	IF NOT EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
		BEGIN
		SET @Error = 'The student is not on file.'
		RAISERROR (@Error,16,1) 
		END

	DECLARE @CurrentBalance smallmoney
	SET @CurrentBalance = (SELECT BalanceDue FROM Student WHERE StudentId = @StudentId)

	IF @CurrentBalance = 0
		BEGIN
		SET @Error = 'The student does not have balance due.'
		RAISERROR (@Error,16,1) 
		END
	IF @AmountOfPayment < = 0
		BEGIN
		SET @Error = 'The amount of payment must be positive number.'
		RAISERROR (@Error,16,1) 
		END
	ELSE IF @AmountOfPayment > @CurrentBalance
		BEGIN
		SET @Error = 'The amount of payment cannot be greater than the current balance. (Current Balance Due: $'  + CONVERT(varchar(10),@CurrentBalance,1) + ')'
		RAISERROR (@Error,16,1) 
		END

	BEGIN TRANSACTION
		INSERT INTO Payment (StudentId, AmountOfPayment, Date)
			VALUES (@StudentId, @AmountOfPayment, @PaymentDate)

		UPDATE Student SET BalanceDue = BalanceDue - @AmountOfPayment WHERE StudentId = @StudentId
	COMMIT TRANSACTION

END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRANSACTION
		END
	DECLARE @ErrorMessage nVarChar(4000) =
		'Error Number ' + Convert(varchar, ERROR_NUMBER(), 1) + ' Transaction rolled back - ' + ERROR_MESSAGE()
	DECLARE @ErrorSeverity Int = ERROR_SEVERITY()
	DECLARE @ErrorState Int = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spRetrieveCurrentLoans]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRetrieveCurrentLoans]
    @StudentId	nchar(8)
AS
SET NOCOUNT ON

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
		BEGIN		
			DECLARE @Error char(50)
			SET @Error = 'The student is not on file'
			RAISERROR (@Error,16,1) 
		END

	SELECT l.LoanId, l.ResourceId, l.StudentId, r.Title, r.ResourceType, l.CheckoutDate, l.DueDate,r.ImageOfItem
	FROM Loan l INNER JOIN [Resource] r ON l.ResourceId = r.ResourceId
	WHERE l.StudentId = @StudentId AND LoanStatus = 0 AND l.DateReturned is null
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spRetrieveCurrentLoansByStudentID]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spRetrieveCurrentLoansByStudentID]
    @StudentId	nchar(8),
	@ResourceId int
AS
SET NOCOUNT ON

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Loan INNER JOIN Student ON Loan.StudentId =  Student.StudentId WHERE Loan.StudentId = @StudentId)
		BEGIN		
			DECLARE @Error char(50)
			SET @Error = 'The student is not on file'
			RAISERROR (@Error,16,1) 
		END

	SELECT * FROM Loan  INNER JOIN Student ON Loan.StudentId =  Student.StudentId
	INNER JOIN Resource ON Resource.ResourceId = Loan.ResourceId WHERE Loan.StudentId = @StudentId AND Loan.ResourceId = @ResourceId
	AND Loan.LoanStatus = 0
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH

GO
/****** Object:  StoredProcedure [dbo].[spRetrieveLoanOne]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRetrieveLoanOne]
    @ResourceId	int
AS
SET NOCOUNT ON

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Loan WHERE ResourceId = @ResourceId AND LoanStatus = 0)
		BEGIN		
			DECLARE @Error char(50)
			SET @Error = 'The Resource is not on loan.'
			RAISERROR (@Error,16,1) 
		END

	SELECT l.LoanId, l.ResourceId, l.StudentId, r.Title, r.ResourceType, l.CheckoutDate, l.DueDate
	FROM Loan l INNER JOIN [Resource] r ON l.ResourceId = r.ResourceId
	WHERE  l.ResourceId = @ResourceId AND l.LoanStatus = 0
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spRetrieveResourceOne]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRetrieveResourceOne]
	@ResourceId	int
AS

SET NOCOUNT ON

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM [Resource] WHERE ResourceId = @ResourceId)
	BEGIN
		DECLARE @Error char(50)
		SET @Error = 'Resource is not on file'
		RAISERROR (@Error,16,1) 
	END
	SELECT * FROM [Resource] WHERE ResourceId = @ResourceId
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spRetrieveStudentLookup]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRetrieveStudentLookup]
	@Keyword nvarchar(20)
AS
SET NOCOUNT ON

BEGIN TRY
	IF EXISTS (SELECT * FROM Student WHERE StudentId = @Keyword)
		BEGIN
		SELECT StudentId, FirstName, LastName 
		FROM Student 
		WHERE StudentId = @Keyword
		END
	ELSE IF EXISTS(SELECT * FROM Student WHERE LastName LIKE '%' + @Keyword + '%')
		BEGIN
		SELECT StudentId, FirstName, LastName 
		FROM Student 
		WHERE LastName LIKE '%' + @Keyword + '%'
		END

	ELSE
		BEGIN
			DECLARE @Error char(50)
			SET @Error = 'No matching student on file'
			RAISERROR (@Error,16,1) 
		END
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spRetrieveStudentOne]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRetrieveStudentOne]
	@StudentId	nchar(8)
AS

SET NOCOUNT ON

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
	BEGIN
		DECLARE @Error char(50)
		SET @Error = 'Student Id, ' + @StudentId + ', is not on file'
		RAISERROR (@Error,16,1) 
	END
	SELECT * FROM Student WHERE StudentId = @StudentId
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spRetriveBorrowerAndResource]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spRetriveBorrowerAndResource]
@ResourceId int


AS

SET NOCOUNT ON

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Loan as l INNER JOIN Resource as r
	ON l.ResourceId = r.ResourceId 
	 WHERE l.LoanId  IN (SELECT LoanId FROM Loan   WHERE  ResourceId = @ResourceId   )
	 AND l.ResourceId = @ResourceId AND l.DateReturned IS null  )
	BEGIN
		DECLARE @Error char(100)
		SET @Error = 'Resource is not on file or is not borrowed by student'
		RAISERROR (@Error,16,1) 
	END

	--SELECT * FROM Loan as l INNER JOIN Resource as r
	--ON l.ResourceId = r.ResourceId 
	--WHERE l.LoanId  IN (SELECT LoanId FROM Loan   WHERE  ResourceId = 16 )
	-- AND l.ResourceId = 16 AND L.DateReturned IS NULL
	

SELECT * FROM Loan as l INNER JOIN Resource as r
	ON l.ResourceId = r.ResourceId 
	WHERE l.LoanId  IN (SELECT LoanId FROM Loan   WHERE  ResourceId = @ResourceId  )
	 AND l.ResourceId = @ResourceId AND l.DateReturned is null
	 END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spReturnResources]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE        PROCEDURE [dbo].[spReturnResources]

@ResourceId int,
@StudentId nvarchar(8),
@DateReturned DateTime,
@LoanStatus int


AS

BEGIN TRY

	IF NOT EXISTS (SELECT * FROM Loan WHERE LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId ) AND StudentId = @StudentId AND ResourceId = @ResourceId AND LoanStatus = 0)
		RAISERROR ('The loan does not exists', 16,1)
	
	--(SELECT * FROM Loan WHERE LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = 13 AND  StudentId = 'ABC12345' ) AND StudentId = 'ABC12345' AND ResourceId = 13 AND LoanStatus = 0)

	BEGIN TRANSACTION
	
	
	UPDATE Resource

	SET ResourceStatus = 0, StudentId = null WHERE  ResourceId = @ResourceId
	UPDATE Loan
	SET  DateReturned = @DateReturned
	
   
	
	WHERE  StudentId = @StudentId AND ResourceId = @ResourceId 
	AND LoanId IN (SELECT LoanId FROM Loan  WHERE ResourceId = @ResourceId AND  StudentId = @StudentId)
	AND LoanStatus = 0
	IF (SELECT DATEDIFF(DAY,Loan.DueDate,Loan.DateReturned) FROM Loan  WHERE 
	  LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND DateReturned = @DateReturned  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned
	    ) < 0
	BEGIN
	UPDATE Loan
		SET OverdueCharge =  0,
		NonReturnCharge = 0,
		LoanStatus = @LoanStatus
		WHERE   LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned
	IF @LoanStatus = 2 OR @LoanStatus =3
	BEGIN
	UPDATE Resource
	SET ResourceStatus = 2  ,
	DateRemoved = (SELECT Loan.CheckoutDate FROM Loan INNER JOIN Resource ON Loan.ResourceId = Resource.ResourceId
	WHERE Loan.ResourceId = @ResourceId AND Loan.StudentId = @StudentId  AND Loan.LoanStatus = @LoanStatus)
	WHERE ResourceId = @ResourceId
	DECLARE @NonReturnCharge1 as Decimal;
	
	SET @NonReturnCharge1 = (SELECT Resource.PurchasePrice FROM [Resource] INNER JOIN Loan
		ON [Resource].ResourceId = Loan.ResourceId WHERE Loan.StudentId = @StudentId AND 
		Loan.ResourceId = @ResourceId AND  Loan.LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = @LoanStatus )) 
	UPDATE Loan
	SET NonReturnCharge = @NonReturnCharge1,
	OverdueCharge = 0
	WHERE   LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = @LoanStatus  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned		
	END
	END
	IF (SELECT DATEDIFF(DAY,Loan.DueDate,Loan.DateReturned) FROM Loan  WHERE 
	  LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned
	    ) > 0 AND  (SELECT DATEDIFF(DAY,Loan.DueDate,Loan.DateReturned) FROM Loan  WHERE 
	  LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned
	    ) < 5
	BEGIN
--	UPDATE Loan
--		SET OverdueCharge =   DATEDIFF(DAY,DueDate,DateReturned) * 5,
--		NonReturnCharge = 0,
--		LoanStatus = @LoanStatus
--WHERE   LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned	 
--IF @LoanStatus = 2 OR @LoanStatus =3
	UPDATE Resource
	SET ResourceStatus = 2  
	WHERE ResourceId = @ResourceId   
	
	
	UPDATE Loan
	SET OverdueCharge =   DATEDIFF(DAY,DueDate,DateReturned) * 5,
	 NonReturnCharge = 0
	, LoanStatus = @LoanStatus
	WHERE   LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned	
	IF @LoanStatus = 2 OR @LoanStatus =3
	BEGIN
	UPDATE Resource
	SET ResourceStatus = 2  ,
	DateRemoved = (SELECT Loan.CheckoutDate FROM Loan INNER JOIN Resource ON Loan.ResourceId = Resource.ResourceId
	WHERE Loan.ResourceId = @ResourceId AND Loan.StudentId = @StudentId  AND Loan.LoanStatus = @LoanStatus)
	WHERE ResourceId = @ResourceId
	DECLARE @NonReturnCharge2 as Decimal;
	
	SET @NonReturnCharge2 = (SELECT Resource.PurchasePrice FROM [Resource] INNER JOIN Loan
		ON [Resource].ResourceId = Loan.ResourceId WHERE Loan.StudentId = @StudentId AND 
		Loan.ResourceId = @ResourceId AND  Loan.LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = @LoanStatus )) 
	UPDATE Loan
	SET NonReturnCharge = @NonReturnCharge2,
	OverdueCharge = DATEDIFF(DAY,DueDate,DateReturned) * 5
	WHERE   LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = @LoanStatus  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned	
	END		
	END
	IF (SELECT DATEDIFF(DAY,Loan.DueDate,Loan.DateReturned) FROM Loan  WHERE 
	  LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0 ) AND DateReturned = @DateReturned  AND ResourceId = @ResourceId AND StudentId = @StudentId AND LoanStatus = 0  ) > 5
	BEGIN
	DECLARE @NonReturnCharge as Decimal;
	
	SET @NonReturnCharge = (SELECT Resource.PurchasePrice FROM [Resource] INNER JOIN Loan
		ON [Resource].ResourceId = Loan.ResourceId WHERE Loan.StudentId = @StudentId AND 
		Loan.ResourceId = @ResourceId AND  Loan.LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = @LoanStatus )) 
		UPDATE Loan
		SET OverdueCharge =  DATEDIFF(DAY,DueDate,DateReturned) * 5 , 
		NonReturnCharge = @NonReturnCharge,
		LoanStatus = @LoanStatus
WHERE   LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = 0  )  AND ResourceId = @ResourceId AND StudentId = @StudentId AND DateReturned = @DateReturned		
IF @LoanStatus = 2 OR @LoanStatus =3
	UPDATE Resource
	SET ResourceStatus = 2  
	WHERE ResourceId = @ResourceId 
		
	END
	

	--DECLARE @BalanceDue as Decimal;
	--SET @BalanceDue = (SELECT l.OverdueCharge + l.NonReturnCharge FROM Loan AS l INNER JOIN Student AS s
	--ON l.StudentId = @StudentId AND l.ResourceId = @ResourceId AND l.LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND DateReturned = @DateReturned) AND DateReturned = @DateReturned)

	DECLARE @BalanceDue as Decimal;
	SET @BalanceDue = (SELECT l.OverdueCharge + l.NonReturnCharge FROM Loan AS l INNER JOIN Student AS s
	 ON l.StudentId = s.StudentId INNER JOIN Resource as r
	 ON l.ResourceId = r.ResourceId
	 WHERE l.StudentId = @StudentId AND l.ResourceId = @ResourceId AND l.LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND LoanStatus = @LoanStatus)
	 AND DateReturned = @DateReturned ) 
	 UPDATE Student
	 SET BalanceDue += @BalanceDue
	 WHERE StudentId IN (SELECT StudentId FROM Loan WHERE StudentId = @StudentId AND ResourceId = @ResourceId AND LoanId IN (SELECT LoanId FROM Loan WHERE ResourceId = @ResourceId AND  StudentId = @StudentId AND DateReturned = @DateReturned AND LoanStatus = @LoanStatus  ) AND DateReturned = @DateReturned  )
	
	
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[spUpdateStudent]    Script Date: 2019-11-28 2:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateStudent]
	   @TimeStamp TIMESTAMP OUTPUT,
       @StudentId	nchar(8),		@FirstName nvarchar(30),
       @LastName	nvarchar(20),	@Address nvarchar(30),
       @City		nvarchar(20),	@PostalCode char(6),
	   @Telephone	varchar(13),	@ProgramOption tinyint,
	   @StartDate	date,			@EndDate date,
	   @IsActive	bit

AS

BEGIN TRY
	IF NOT EXISTS (SELECT * FROM Student WHERE StudentId = @StudentId)
		BEGIN
			DECLARE @Error char(50)
			SET @Error = 'Student Id, ' + @StudentId + ', is not on file'
			RAISERROR (@Error,16,1) 
		END

	IF(SELECT[TimeStamp] FROM Student WHERE StudentId=@StudentId) <> @TimeStamp
		THROW 51005,'The record has been updated by someone since you last retrieved it. Retrieve the record again before you make updates.',1

		UPDATE Student 
			SET FirstName = @FirstName, LastName = @LastName, [Address] = @Address, 
				City = @City, PostalCode = @PostalCode, Telephone = @Telephone,
				Program = @ProgramOption, StartDate = @StartDate, EndDate = @EndDate,
				IsActive = @IsActive
			WHERE StudentId = @StudentId
			SET @TimeStamp = (SELECT [TIMESTAMP] FROM Student where StudentId = @StudentId)
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage nVarChar(4000)
	DECLARE @ErrorSeverity Int
	DECLARE @ErrorState Int
	SELECT	@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH
GO
USE [master]
GO
ALTER DATABASE [AbcAcademy_Project] SET  READ_WRITE 
GO
