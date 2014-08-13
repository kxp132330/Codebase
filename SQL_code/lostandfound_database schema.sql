USE [LostandFound]
GO
/****** Object:  StoredProcedure [dbo].[Authenticate_User]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery3.sql|0|0|C:\Users\SIVAKR~1\AppData\Local\Temp\~vsE80B.sql
CREATE procedure [dbo].[Authenticate_User]
@Emailid nvarchar(30),
@Password nvarchar(100),
@cid int OUT
as
Begin
Declare @Count int
select @Count=COUNT(c_Emailid) from User_Details where c_Emailid=@Emailid and c_Password=@Password
if (@Count=1)
Begin
Set @cid= (select i_Customer_ID from User_Details where c_Emailid=@Emailid and c_Password=@Password)
End
Else
Begin
Set @cid=0
End
End
GO
/****** Object:  StoredProcedure [dbo].[Register_User]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery5.sql|8|0|C:\Users\SIVAKR~1\AppData\Local\Temp\~vs9A89.sql
CREATE procedure [dbo].[Register_User]
@FirstName Varchar(30),
@LastName  Varchar(30),
@MobileNumber nvarchar(15),
@Emailid nvarchar(30),
@Password nvarchar(100)
as
Begin
Declare @Count int
Declare @ReturnCode int
select @Count=COUNT(c_Emailid) from User_Details where c_Emailid=@Emailid

if @Count>0
Begin
Set @ReturnCode=-1
End

Else
Begin
Set @ReturnCode=1
insert into User_Details values
(@FirstName,@LastName,@MobileNumber,@Password,@Emailid)
End

Select @ReturnCode as ReturnValue
End
GO
/****** Object:  StoredProcedure [dbo].[ReportLostandFound]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery1.sql|0|0|C:\Users\SIVAKR~1\AppData\Local\Temp\~vs2E71.sql
CREATE proc [dbo].[ReportLostandFound]

@lostorfound varchar(10),
@date date,
@category int,
@locdesc int,
@title nvarchar(50),
@description nvarchar(300),
@primarycolor varchar(20),
@serailno nvarchar(30),
@custid int,
@ERROR VARCHAR(100) OUT

as
Begin 
INSERT into [dbo].[Item_Details] (d_Date,i_Category,c_SerialNumber,c_Title,c_Desc,c_PrimaryColor,C_LostorFound,i_LocDesc,i_Customer_ID)
VALUES 
(@date,@category,@serailno ,@title,@description,@primarycolor,@lostorfound,@locdesc,@custid)
SET @ERROR='Items was submitted'
End
GO
/****** Object:  StoredProcedure [dbo].[Search_LostandFound]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery15.sql|11|0|C:\Users\SIVAKR~1\AppData\Local\Temp\~vs2D32.sql
CREATE procedure [dbo].[Search_LostandFound]
@Type varchar(10),
@Location int,
@Category  int,
@Keyword nvarchar(50),
@Date DateTime
as
Begin
select I.c_Title, I.c_desc , I.im_Image, C.c_CategoryDesc, L.C_LocDesc, U.c_FirstName, U.c_LastName, U.c_Emailid from Item_Details I 
join User_Details U on I.i_Customer_ID =U.i_Customer_ID 
join Category_Desc C  on C.i_Category=I.i_Category
join Location_desc L on L.i_LocDesc=I.i_LocDesc 
where I.c_LostorFound=@Type and I.i_LocDesc=@Location and I.i_Category=@Category and I.d_Date>=@Date and I.c_Title like '%'+@Keyword+'%'
End

GO
/****** Object:  Table [dbo].[Category_Desc]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category_Desc](
	[i_Category] [int] NOT NULL,
	[c_CategoryDesc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category_Desc] PRIMARY KEY CLUSTERED 
(
	[i_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Item_Details]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item_Details](
	[i_Product_ID] [int] IDENTITY(100,1) NOT NULL,
	[d_Date] [date] NOT NULL,
	[i_Category] [int] NULL,
	[c_SerialNumber] [nvarchar](30) NULL,
	[c_Title] [nvarchar](50) NULL,
	[c_Desc] [nvarchar](300) NULL,
	[c_PrimaryColor] [varchar](20) NULL,
	[C_LostorFound] [varchar](10) NOT NULL,
	[im_Image] [image] NULL,
	[i_LocDesc] [int] NULL,
	[i_Customer_ID] [int] NOT NULL,
 CONSTRAINT [PK_Item_Details] PRIMARY KEY CLUSTERED 
(
	[i_Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Location_Desc]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location_Desc](
	[i_LocDesc] [int] NOT NULL,
	[C_LocDesc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Location_Desc] PRIMARY KEY CLUSTERED 
(
	[i_LocDesc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_Details]    Script Date: 5/1/2014 5:05:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Details](
	[i_Customer_ID] [int] IDENTITY(100,1) NOT NULL,
	[c_LastName] [varchar](30) NULL,
	[c_FirstName] [varchar](30) NULL,
	[c_PhoneNumber] [nvarchar](15) NULL,
	[c_Password] [nvarchar](100) NULL,
	[c_Emailid] [nvarchar](30) NULL,
 CONSTRAINT [PK_User_Details] PRIMARY KEY CLUSTERED 
(
	[i_Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Item_Details]  WITH CHECK ADD  CONSTRAINT [FK_User_Details_2_Item_Details] FOREIGN KEY([i_Customer_ID])
REFERENCES [dbo].[User_Details] ([i_Customer_ID])
GO
ALTER TABLE [dbo].[Item_Details] CHECK CONSTRAINT [FK_User_Details_2_Item_Details]
GO
