USE [SchoolDiaryManagement]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NOT NULL,
	[Class_No] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
	[LUN] [int] NOT NULL,
	[LUD] [datetime] NULL,
	[LUB] [varchar](50) NULL,
	[InsertDate] [datetime] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Klasa] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class_Schedule]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class_Schedule](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Time] [int] NOT NULL,
	[Day] [varchar](10) NOT NULL,
	[Year] [int] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[LUB] [varchar](50) NULL,
	[LUN] [int] NOT NULL,
	[LUD] [datetime] NULL,
 CONSTRAINT [PK_Class_Schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](20) NOT NULL,
	[InsertBy] [varchar](20) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[LUB] [varchar](20) NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[Room_No] [int] NOT NULL,
	[Room_Type] [varchar](30) NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[LUB] [varchar](50) NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NOT NULL,
 CONSTRAINT [PK_Salla] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[Subject_Title] [varchar](30) NOT NULL,
	[Book] [varchar](50) NOT NULL,
	[Book_Author] [varchar](50) NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[LUB] [varchar](50) NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NOT NULL,
	[TeacherID] [int] NOT NULL,
 CONSTRAINT [PK_Lendet] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Qualification] [varchar](50) NOT NULL,
	[Day_of_Birth] [date] NOT NULL,
	[Email] [varchar](320) NOT NULL,
	[Phone_No] [varchar](50) NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[LUB] [varchar](50) NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NOT NULL,
 CONSTRAINT [PK_Arsimtaret] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[TopicID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [int] NOT NULL,
	[Content] [varchar](max) NULL,
	[AbsenceReasoning] [varchar](25) NULL,
	[NoStudents_Absence] [int] NOT NULL,
	[Comment] [varchar](max) NULL,
	[Review] [varchar](max) NOT NULL,
	[LUN] [int] NOT NULL,
	[LUD] [datetime] NULL,
	[LUB] [varchar](50) NULL,
	[InsertDate] [datetime] NOT NULL,
	[InsertBy] [varchar](50) NOT NULL,
	[ReviewDate] [date] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
	[ExpiresDate] [date] NOT NULL,
	[RoleID] [int] NOT NULL,
	[InsertBy] [varchar](20) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[LUB] [varchar](20) NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NOT NULL,
	[First_Name] [varchar](20) NOT NULL,
	[Last_Name] [varchar](20) NOT NULL,
	[LastLoginDate] [datetime] NULL,
	[LastPasswordChangeDate] [datetime] NULL,
	[IsPasswordChanged] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Class] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Class] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Class_Schedule] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Class_Schedule] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Rooms] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Rooms] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Subjects] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Subjects] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Topics] ADD  DEFAULT ((0)) FOR [NoStudents_Absence]
GO
ALTER TABLE [dbo].[Topics] ADD  DEFAULT ('NONE') FOR [Review]
GO
ALTER TABLE [dbo].[Topics] ADD  DEFAULT ((0)) FOR [LUN]
GO
ALTER TABLE [dbo].[Topics] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Topics] ADD  DEFAULT (getdate()) FOR [ReviewDate]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [IsPasswordChanged]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Rooms] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Rooms] ([RoomID])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Rooms]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([TeacherID])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Teachers]
GO
ALTER TABLE [dbo].[Class_Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Class_Schedule_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[Class_Schedule] CHECK CONSTRAINT [FK_Class_Schedule_Class]
GO
ALTER TABLE [dbo].[Class_Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Class_Schedule_Subjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
GO
ALTER TABLE [dbo].[Class_Schedule] CHECK CONSTRAINT [FK_Class_Schedule_Subjects]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([TeacherID])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Teachers]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__RoleID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__RoleID]
GO
/****** Object:  StoredProcedure [dbo].[usp_Absence_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Absence_Create] (
	@topicID int,
	@classID int,
	@subjectID int,
	@date date,
	@time int,
	@absencereasoning varchar(25),
	@nostudents_absence int,
	@LUN int,
	@LUB varchar(50),
	@insertby varchar(50)
)
AS
BEGIN
	IF(@topicID = -1)
	BEGIN
		INSERT INTO dbo.Topics
		(
		    --TopicID - column value is auto-generated
		    ClassID,
		    SubjectID,
		    [Date],
		    [Time],
		    AbsenceReasoning,
			NoStudents_Absence,
		    LUN,
		    LUD,
		    LUB,
		    InsertDate,
		    InsertBy
		)
		VALUES
		(
		    -- TopicID - int
		    @classID, -- ClassID - int
		    @subjectID, -- SubjectID - int
		    @date, -- Date - date
		    @time, -- Time - int
		    @absencereasoning, -- Content - varchar
			@nostudents_absence, -- Content - int
		    @LUN, -- LUN - int
		    GETDATE(), -- LUD - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- InsertDate - datetime
		    @insertby -- InsertBy - varchar
		)
	END

	ELSE
	BEGIN
		UPDATE dbo.Topics
		SET
		    --TopicID - column value is auto-generated
		    dbo.Topics.ClassID = @classID, -- int
		    dbo.Topics.SubjectID = @subjectID, -- int
		    dbo.Topics.[Date] = @date, -- date
		    dbo.Topics.[Time] = @time, -- int
		    dbo.Topics.AbsenceReasoning = @absencereasoning, -- varchar
			dbo.Topics.NoStudents_Absence = @nostudents_absence, -- int
		    dbo.Topics.LUN = @LUN, -- int
		    dbo.Topics.LUD = GETDATE(), -- datetime
		    dbo.Topics.LUB = @LUB -- varchar
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar

		WHERE dbo.Topics.TopicID = @topicID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Absence_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Absence_ViewAll]
AS
BEGIN
	SELECT t.TopicID, t.ClassID, t.SubjectID, t.Date, t.Time, t.AbsenceReasoning, t.NoStudents_Absence,
	t.LUN, t.LUD, t.LUB, t.InsertDate, t.InsertBy, c.Class_No, s.Subject_Title 
	FROM dbo.Topics AS t
		INNER JOIN dbo.Class AS c
			ON t.ClassID = c.ClassID
		INNER JOIN dbo.Subjects AS s
			ON t.SubjectID = s.SubjectID
	WHERE t.AbsenceReasoning IS	NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Authenticate]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Authenticate]
	@username VARCHAR(50),
	@password VARCHAR(50)
AS

UPDATE dbo.Users
	SET dbo.Users.LastLoginDate = GETDATE()
	WHERE dbo.Users.UserName = @username AND dbo.Users.UserPass = @password;

SELECT *
FROM dbo.Users AS u
WHERE u.UserName = @username AND u.UserPass	= @password;

GO
/****** Object:  StoredProcedure [dbo].[usp_Class_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Class_Create] (
	@classID int,
	@teacherID int,
	@classno int,
	@roomID int,
	@LUN int,
	@LUB varchar(20),
	@insertby varchar(20)
)
AS
BEGIN
	IF(@classID	= -1)
	BEGIN
		INSERT INTO dbo.Class
		(
		    --ClassID - column value is auto-generated
		    TeacherID,
		    Class_No,
		    RoomID,
		    LUN,
		    LUD,
		    LUB,
		    InsertDate,
		    InsertBy
		)
		VALUES
		(
		    -- ClassID - int
		    @teacherID, -- TeacherID - int
		    @classno, -- Class_No - int
		    @roomID, -- RoomID - int
		    @LUN, -- LUN - int
		    GETDATE(), -- LUD - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- InsertDate - datetime
		    @insertby -- InsertBy - varchar
		)
	END

	ELSE
	BEGIN
		UPDATE dbo.Class
		SET
		    -- ClassID - column value is auto-generated
		    dbo.Class.TeacherID = @teacherID, -- int
		    -- ClassNo nuk behet update -- int
		    dbo.Class.RoomID = @roomID, -- int
		    dbo.Class.LUN = @LUN, -- int
		    dbo.Class.LUD = GETDATE(), -- datetime
		    dbo.Class.LUB = @LUB -- varchar
			-- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar

		WHERE dbo.Class.ClassID = @classID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Class_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Class_Delete] (
	@classID int
)
AS
BEGIN
	DELETE FROM dbo.Class WHERE [ClassID] = @classID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Classes_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Classes_ViewAll]
AS
BEGIN
	SELECT c.*, r.Room_Type, t.First_Name, t.Last_Name
	FROM dbo.Class AS c 
		INNER JOIN dbo.Rooms AS r
			ON c.RoomID = r.RoomID
		INNER JOIN dbo.Teachers AS t
			ON c.TeacherID = t.TeacherID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ClassSchedule_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_ClassSchedule_Create] (
	@scheduleID int,
	@classID int,
	@subjectID int,
	@time int,
	@date varchar(20),
	@year int,
	@insertby varchar(20),
	@LUB varchar(20),
	@LUN int
)
AS
BEGIN
	IF(@scheduleID = -1)
	BEGIN
		INSERT INTO dbo.Class_Schedule
		(
		    --ScheduleID - column value is auto-generated
		    ClassID,
		    SubjectID,
		    [Time],
		    [Day],
		    [Year],
		    InsertBy,
		    InsertDate,
		    LUB,
		    LUN,
		    LUD
		)
		VALUES
		(
		    -- ScheduleID - int
		    @classID, -- ClassID - int
		    @subjectID, -- SubjectID - int
		    @time, -- Time - int
		    @date, -- Date - varchar
		    @year, -- Year - int
		    @insertby, -- InsertBy - varchar
		    GETDATE(), -- InsertDate - datetime
		    @LUB, -- LUB - varchar
		    @LUN, -- LUN - int
		    GETDATE() -- LUD - datetime
		)
	END

	ELSE
	BEGIN
		UPDATE	dbo.Class_Schedule
		SET
		    --ScheduleID - column value is auto-generated
		    dbo.Class_Schedule.ClassID = @classID, -- int
		    dbo.Class_Schedule.SubjectID = @subjectID, -- int
		    dbo.Class_Schedule.[Time] = @time, -- int
		    dbo.Class_Schedule.[Day] = @date, -- varchar
		    dbo.Class_Schedule.[Year] = @year, -- int
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar
		    dbo.Class_Schedule.LUB = @LUB, -- varchar
		    dbo.Class_Schedule.LUN = @LUN, -- int
		    dbo.Class_Schedule.LUD = GETDATE() -- datetime

		WHERE dbo.Class_Schedule.ScheduleID = @scheduleID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ClassSchedule_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ClassSchedule_Delete] (
	@scheduleID int
)
AS
BEGIN
	DELETE FROM dbo.Class_Schedule WHERE [ScheduleID] = @scheduleID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ClassSchedule_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_ClassSchedule_ViewAll]
AS
BEGIN
	SELECT cs.*, c.Class_No, s.Subject_Title
	FROM dbo.Class_Schedule AS cs
		INNER JOIN dbo.Class AS c
			ON cs.ClassID = c.ClassID
		INNER JOIN dbo.Subjects AS s
			ON cs.SubjectID = s.SubjectID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Comment_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Comment_Create] (
	@topicID int,
	@classID int,
	@subjectID int,
	@date date,
	@time int,
	@comment varchar(MAX),
	@LUN int,
	@LUB varchar(50),
	@insertby varchar(50)
)
AS
BEGIN
	IF(@topicID = -1)
	BEGIN
		INSERT INTO dbo.Topics
		(
		    --TopicID - column value is auto-generated
		    ClassID,
		    SubjectID,
		    [Date],
		    [Time],
			Comment,
		    LUN,
		    LUD,
		    LUB,
		    InsertDate,
		    InsertBy
		)
		VALUES
		(
		    -- TopicID - int
		    @classID, -- ClassID - int
		    @subjectID, -- SubjectID - int
		    @date, -- Date - date
		    @time, -- Time - int
			@comment, -- Comment - varchar
		    @LUN, -- LUN - int
		    GETDATE(), -- LUD - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- InsertDate - datetime
		    @insertby -- InsertBy - varchar
		)
	END
	ELSE
	BEGIN
		UPDATE dbo.Topics
		SET
		    --TopicID - column value is auto-generated
		    dbo.Topics.ClassID = @classID, -- int
		    dbo.Topics.SubjectID = @subjectID, -- int
		    dbo.Topics.[Date] = @date, -- date
		    dbo.Topics.[Time] = @time, -- int
		    dbo.Topics.Comment = @comment, -- varchar
		    dbo.Topics.LUN = @LUN, -- int
		    dbo.Topics.LUD = GETDATE(), -- datetime
		    dbo.Topics.LUB = @LUB, -- varchar
		    dbo.Topics.InsertDate = GETDATE(), -- datetime
		    dbo.Topics.InsertBy = @insertby -- varchar

		WHERE dbo.Topics.TopicID = @topicID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Comment_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Comment_ViewAll]
AS
BEGIN
	SELECT t.TopicID, t.ClassID, t.SubjectID, t.Date, t.Time, t.Comment, t.Review,
	t.LUN, t.LUD, t.LUB, t.InsertDate, t.InsertBy, c.Class_No, s.Subject_Title 
	FROM dbo.Topics AS t
		INNER JOIN dbo.Class AS c
			ON t.ClassID = c.ClassID
		INNER JOIN dbo.Subjects AS s
			ON t.SubjectID = s.SubjectID
	WHERE t.Comment IS NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Review]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Review] (
	@topicid int,
	@review varchar(MAX),
	@reviewdate date,
	@LUN int,
	@LUB varchar(50),
	@insertby varchar(50)
)
AS
BEGIN
	UPDATE dbo.Topics
		SET
			--TopicID - column value is auto-generated
			dbo.Topics.Review = @review, -- varchar
			dbo.Topics.LUN = @LUN, -- int
			dbo.Topics.LUD = GETDATE(), -- datetime
			dbo.Topics.LUB = @LUB, -- varchar
			dbo.Topics.ReviewDate = @reviewdate -- date

	WHERE dbo.Topics.TopicID = @topicid
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Review_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Review_ViewAll]
AS
BEGIN
	SELECT t.TopicID, t.ClassID, t.SubjectID, t.[Date], t.[Time], t.Comment, t.Review, t.ReviewDate,
	t.LUN, t.LUD, t.LUB, t.InsertDate, t.InsertBy, c.Class_No, s.Subject_Title 
	FROM dbo.Topics AS t
		INNER JOIN dbo.Class AS c
			ON t.ClassID = c.ClassID
		INNER JOIN dbo.Subjects AS s
			ON t.SubjectID = s.SubjectID
	WHERE t.Review <> 'NONE'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Role_Create]
	@roleID int,
	@rolename varchar(20),
	@insertby varchar(20),
	@LUB varchar(20),
	@LUN int
AS
BEGIN
	IF (@roleID = -1)
	BEGIN
		INSERT INTO dbo.Roles
		(
			--RoleID - column value is auto-generated
			RoleName,
			InsertBy,
			InsertDate,
			LUB,
			LUD,
			LUN
		)
		VALUES
		(
			@rolename,
			@insertby,
			GETDATE(),
			@LUB,
			GETDATE(),
			@LUN
		)
	END

	ELSE
	BEGIN
		UPDATE	dbo.Roles
		SET
			--RoleID - column value is auto-generated
			dbo.Roles.RoleName = @rolename, -- varchar
			-- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar
			dbo.Roles.LUB = @LUB, -- varchar
			dbo.Roles.LUD = GETDATE(), -- datetime
			dbo.Roles.LUN = @LUN -- int

			WHERE dbo.Roles.RoleID = @roleID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_GetByID]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Role_GetByID] (
	@roleID int
)
AS
BEGIN
	SELECT r.RoleName FROM dbo.Roles AS r
	WHERE r.RoleID = @roleID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Roles_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Roles_Delete]
	@roleID int
AS
BEGIN
	DELETE FROM dbo.Roles 
	WHERE [RoleID]=@roleID
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Roles_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Roles_ViewAll]
AS
BEGIN
SELECT * FROM dbo.Roles
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Room_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Room_Create] (
	@roomID int,
	@roomno int,
	@roomtype varchar(30),
	@insertby varchar(20),
	@LUB varchar(20),
	@LUN int
)
AS
BEGIN
	IF (@roomID	= -1)
	BEGIN
		INSERT INTO dbo.Rooms
		(
		    --RoomID - column value is auto-generated
		    Room_No,
		    Room_Type,
		    InsertBy,
		    InsertDate,
		    LUB,
		    LUD,
		    LUN
		)
		VALUES
		(
		    -- RoomID - int
		    @roomno, -- Room_No - int
		    @roomtype, -- Room_Type - varchar
		    @insertby, -- InsertBy - varchar
		    GETDATE(), -- InsertDate - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- LUD - datetime
		    @LUN -- LUN - int
		)
	END

	ELSE
	BEGIN
		UPDATE dbo.Rooms
		SET
		    --RoomID - column value is auto-generated
		    dbo.Rooms.Room_No = @roomno, -- int
		    dbo.Rooms.Room_Type = @roomtype, -- varchar
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar
		    dbo.Rooms.LUB = @LUB, -- varchar
		    dbo.Rooms.LUD = GETDATE(), -- datetime
		    dbo.Rooms.LUN = @LUN -- int

		WHERE dbo.Rooms.RoomID = @roomID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Room_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Room_Delete] (
	@roomid int
)
AS
BEGIN
	DELETE FROM dbo.Rooms WHERE [RoomID] = @roomid
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Rooms_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Rooms_ViewAll]
AS
BEGIN
	SELECT * from dbo.Rooms as r
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Subject_Create] (
	@subjectID int,
	@subjecttitle varchar(30),
	@book varchar(50),
	@bookauthor varchar(50),
	@insertby varchar(20),
	@LUB varchar(20),
	@LUN int,
	@teacherID int
)
AS
BEGIN
	IF (@subjectID = -1)
	BEGIN
		INSERT INTO dbo.Subjects
		(
		    --SubjectID - column value is auto-generated
		    Subject_Title,
		    Book,
		    Book_Author,
		    InsertBy,
		    InsertDate,
		    LUB,
		    LUD,
		    LUN,
			TeacherID
		)
		VALUES
		(
		    -- SubjectID - int
		    @subjecttitle, -- Subject_Title - varchar
		    @book, -- Book - varchar
		    @bookauthor, -- Book_Author - varchar
		    @insertby, -- InsertBy - varchar
		    GETDATE(), -- InsertDate - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- LUD - datetime
		    @LUN, -- LUN - int
			@teacherID -- TeacherID - int
		)
	END

	ELSE
	BEGIN
		UPDATE dbo.Subjects
		SET
		    -- SubjectID - column value is auto-generated
		    -- SubjectTitle - varchar
		    dbo.Subjects.Book = @book, -- varchar
		    dbo.Subjects.Book_Author = @bookauthor, -- varchar
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar
		    dbo.Subjects.LUB = @LUB, -- varchar
		    dbo.Subjects.LUD = GETDATE(), -- datetime
		    dbo.Subjects.LUN = @LUN, -- int
			dbo.Subjects.TeacherID = @teacherID -- int

		WHERE dbo.Subjects.SubjectID = @subjectID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subject_Delete] (
	@subjectID int	
)
AS
BEGIN
	DELETE FROM dbo.Subjects WHERE [SubjectID] = @subjectID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Subject_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Subject_ViewAll]
AS
BEGIN
	SELECT s.*, t.First_Name, t.Last_Name
	FROM dbo.Subjects as s
		INNER JOIN dbo.Teachers as t
			ON s.TeacherID = t.TeacherID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Teacher_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Teacher_Create]
	@teacherID int,
	@firstname varchar(20),
	@lastname varchar(20),
	@gender varchar(20),
	@city varchar(20),
	@qualification varchar(20),
	@dayofbirth date,
	@email varchar(320),
	@phoneno varchar(20),
	@insertby varchar(20),
	@LUB varchar(20),
	@LUN int
AS
BEGIN
	IF(@teacherID = -1)
	BEGIN
		INSERT INTO	dbo.Teachers
		(
		    --TeacherID - column value is auto-generated
		    First_Name,
		    Last_Name,
		    Gender,
		    City,
		    Qualification,
		    Day_of_Birth,
		    Email,
		    Phone_No,
		    InsertBy,
		    InsertDate,
		    LUB,
		    LUD,
		    LUN
		)
		VALUES
		(
		    -- TeacherID - int
		    @firstname, -- First_Name - varchar
		    @lastname, -- Last_Name - varchar
		    @gender, -- Gender - varchar
		    @city, -- Address - varchar
		    @qualification, -- Qualification - varchar
		    @dayofbirth, -- Day_of_Birth - date
		    @email, -- Email - varchar
		    @phoneno, -- Phone_No - varchar
		    @insertby, -- InsertBy - varchar
		    GETDATE(), -- InsertDate - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- LUD - datetime
		    @LUN -- LUN - int
		)
	END
	
	ELSE
	BEGIN
		UPDATE dbo.Teachers
		SET
		    --TeacherID - column value is auto-generated
		    dbo.Teachers.First_Name = @firstname, -- varchar
		    dbo.Teachers.Last_Name = @lastname, -- varchar
		    dbo.Teachers.Gender = @gender, -- varchar
		    dbo.Teachers.City = @city, -- varchar
		    dbo.Teachers.Qualification = @qualification, -- varchar
		    dbo.Teachers.Day_of_Birth = @dayofbirth, -- date
		    dbo.Teachers.Email = @email, -- varchar
		    dbo.Teachers.Phone_No = @phoneno, -- varchar
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar
		    dbo.Teachers.LUB = @LUB, -- varchar
		    dbo.Teachers.LUD = GETDATE(), -- datetime
		    dbo.Teachers.LUN = @LUN -- int

		WHERE dbo.Teachers.TeacherID = @teacherID
	END
END 
GO
/****** Object:  StoredProcedure [dbo].[usp_Teachers_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Teachers_Delete]
	@teacherID int
AS
BEGIN
	DELETE FROM dbo.Teachers WHERE [TeacherID] = @teacherID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Teachers_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Teachers_ViewAll]
AS
BEGIN 
SELECT * FROM dbo.[Teachers] AS t
END	
GO
/****** Object:  StoredProcedure [dbo].[usp_Topic_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Topic_Create] (
	@topicID int,
	@classID int,
	@subjectID int,
	@date date,
	@time int,
	@content varchar(MAX),
	@LUN int,
	@LUB varchar(50),
	@insertby varchar(50)
)
AS
BEGIN
	IF(@topicID = -1)
	BEGIN
		INSERT INTO dbo.Topics
		(
		    --TopicID - column value is auto-generated
		    ClassID,
		    SubjectID,
		    [Date],
		    [Time],
		    Content,
		    LUN,
		    LUD,
		    LUB,
		    InsertDate,
		    InsertBy
		)
		VALUES
		(
		    -- TopicID - int
		    @classID, -- ClassID - int
		    @subjectID, -- SubjectID - int
		    @date, -- Date - date
		    @time, -- Time - int
		    @content, -- Content - varchar
		    @LUN, -- LUN - int
		    GETDATE(), -- LUD - datetime
		    @LUB, -- LUB - varchar
		    GETDATE(), -- InsertDate - datetime
		    @insertby -- InsertBy - varchar
		)
	END

	ELSE
	BEGIN
		UPDATE dbo.Topics
		SET
		    --TopicID - column value is auto-generated
		    dbo.Topics.ClassID = @classID, -- int
		    dbo.Topics.SubjectID = @subjectID, -- int
		    dbo.Topics.[Date] = @date, -- date
		    dbo.Topics.[Time] = @time, -- int
		    dbo.Topics.Content = @content, -- varchar
		    dbo.Topics.LUN = @LUN, -- int
		    dbo.Topics.LUD = GETDATE(), -- datetime
		    dbo.Topics.LUB = @LUB -- varchar
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar

		WHERE dbo.Topics.TopicID = @topicID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Topic_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Topic_Delete] (
	@topicID int
)
AS
BEGIN
	DELETE FROM dbo.Topics WHERE [TopicID] = @topicID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Topics_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Topics_ViewAll]
AS
BEGIN
	SELECT t.TopicID, t.ClassID, t.SubjectID, t.Date, t.Time, t.Content,
		t.LUN, t.LUD, t.LUB,t.InsertDate, t.InsertBy, c.Class_No, s.Subject_Title 
	FROM dbo.Topics AS t
		INNER JOIN dbo.Class AS c
			ON t.ClassID = c.ClassID
		INNER JOIN dbo.Subjects AS s
			ON t.SubjectID = s.SubjectID
	WHERE t.Content IS NOT NULL 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_ChangePassword]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_User_ChangePassword] (
	@userID int,
	@userpass varchar(20),
	@lastpasswordchangedate datetime,
	@ispasswordchanged bit,
	@LUN int,
	@LUB varchar(50)
)
AS
BEGIN
	UPDATE dbo.Users
	SET
	    --UserID - column value is auto-generated
	    dbo.Users.UserPass = @userpass, -- varchar
		dbo.Users.LastPasswordChangeDate = GETDATE(), -- datetime
		dbo.Users.IsPasswordChanged = @ispasswordchanged, -- bit
		dbo.Users.LUN = @LUN, -- int
		dbo.Users.LUD = GETDATE(), -- datetime
		dbo.Users.LUB = @LUB

	WHERE dbo.Users.UserID = @userID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Create]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_User_Create]
	@userID int,
	@firstname varchar(20),
	@lastname varchar(20),
	@expiresdate date,
	@roleID int,
	@username varchar(20),
	@userpassword varchar(20),
	@insertby varchar(20),
	@LUB varchar(20),
	@LUN int
AS
BEGIN 
	IF (@userID = -1)
	BEGIN
		INSERT INTO dbo.Users
		(
			--UserID - column value is auto-generated
			UserName,
			UserPass,
			ExpiresDate,
			RoleID,
			InsertBy,
			InsertDate,
			LUB,
			LUD,
			LUN,
			First_Name,
			Last_Name
		)
		VALUES
		(
			@username,
			@userpassword,
			@expiresdate,
			@roleID,
			@insertby,
			GETDATE(),
			@LUB,
			GETDATE(),
			@LUN,
			@firstname,
			@lastname
		)
	END

	ELSE
	BEGIN
		UPDATE	dbo.Users
		SET
		    --UserID - column value is auto-generated
		    dbo.Users.UserName = @username, -- varchar
		    -- UserPassword nuk behet update -- varchar
		    dbo.Users.ExpiresDate = @expiresdate, -- date
		    dbo.Users.RoleID = @roleID, -- int
		    -- InsertDate nuk behet update -- datetime
		    -- InsertBy nuk behet update -- varchar
		    dbo.Users.LUB = @LUB, -- varchar
		    dbo.Users.LUD = GETDATE(), -- datetime
		    dbo.Users.LUN = @LUN, -- int
			dbo.Users.First_Name = @firstname, -- varchar
			dbo.Users.Last_Name = @lastname -- varchar

		WHERE dbo.Users.UserID = @userID
	END
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Users_Delete]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Users_Delete]
	@userID int
AS
BEGIN
	DELETE FROM dbo.Users WHERE [UserID] = @userID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Users_ViewAll]    Script Date: 08/06/2020 2:33:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Users_ViewAll]
AS
BEGIN 
	SELECT u.*, r.RoleName 
	FROM dbo.[Users] AS u
		INNER JOIN dbo.Roles AS r
			ON u.RoleID = r.RoleID
END	
GO
