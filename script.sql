USE [Scrum]
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'28b26833-8d93-4796-a3c8-cebcec5fdf0b', 0, N'3784deb8-060d-4d26-b8b7-829641991a69', NULL, 0, 1, NULL, NULL, N'JORDAN123', N'AQAAAAEAACcQAAAAEJG+ubz/YB6f10Zdz0F2AjuYmKQQzT9CgiiNbHj8hqekTm+tSAseJRPIoEP9pz6YtQ==', NULL, 0, N'834c9b07-9a71-43a2-9aad-7b383d46c70f', 0, N'Jordan123')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'3a29d541-5cad-48a3-a6a6-69878f13c9ed', 0, N'7d6f01bb-db3a-4bf3-a18e-360988ed388a', NULL, 0, 1, NULL, NULL, N'ANABEL123', N'AQAAAAEAACcQAAAAEGd20eqJo5RZSOTl94v7BpQWUlZ3vpXV8ZpPfEbY1BTsWLlPau5g74BJ4BrTVKJrEA==', NULL, 0, N'89196721-a944-44f7-9bbb-e689c1a3679a', 0, N'Anabel123')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'54c24dc5-aea1-4b09-911a-4edfc2dfc2e5', 0, N'ff3ec076-1fab-4fcd-b490-4d4721d5465d', NULL, 0, 1, NULL, NULL, N'PETE123', N'AQAAAAEAACcQAAAAEAE5cmjOG6m1xpYl1dNHLFZznnjQCmA+3Owmmb7YCxQB2iiitrWo2zqGHVHgXpB3LQ==', NULL, 0, N'b75e6da3-939b-44df-a5ef-f4f31f903d45', 0, N'Pete123')
SET IDENTITY_INSERT [dbo].[Projects] ON 

INSERT [dbo].[Projects] ([ProjectId], [Description], [EndDate], [StartDate], [Title], [userId]) VALUES (1, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2017-08-30T07:54:22.0661013' AS DateTime2), N'Sample Project', N'3a29d541-5cad-48a3-a6a6-69878f13c9ed')
SET IDENTITY_INSERT [dbo].[Projects] OFF
SET IDENTITY_INSERT [dbo].[UserProjects] ON 

INSERT [dbo].[UserProjects] ([UserProjectId], [ProjectId], [UserId]) VALUES (1, 1, N'28b26833-8d93-4796-a3c8-cebcec5fdf0b')
INSERT [dbo].[UserProjects] ([UserProjectId], [ProjectId], [UserId]) VALUES (2, 1, N'3a29d541-5cad-48a3-a6a6-69878f13c9ed')
INSERT [dbo].[UserProjects] ([UserProjectId], [ProjectId], [UserId]) VALUES (3, 1, N'54c24dc5-aea1-4b09-911a-4edfc2dfc2e5')
SET IDENTITY_INSERT [dbo].[UserProjects] OFF
SET IDENTITY_INSERT [dbo].[Phases] ON 

INSERT [dbo].[Phases] ([PhaseId], [Description]) VALUES (1, N'Initiation')
INSERT [dbo].[Phases] ([PhaseId], [Description]) VALUES (2, N'Planning')
INSERT [dbo].[Phases] ([PhaseId], [Description]) VALUES (3, N'Execution')
INSERT [dbo].[Phases] ([PhaseId], [Description]) VALUES (4, N'Testing')
INSERT [dbo].[Phases] ([PhaseId], [Description]) VALUES (5, N'Review')
SET IDENTITY_INSERT [dbo].[Phases] OFF
SET IDENTITY_INSERT [dbo].[Sprints] ON 

INSERT [dbo].[Sprints] ([SprintId], [Done], [EndDate], [Goal], [InProgress], [Name], [ProjectId], [StartDate]) VALUES (1, 0, CAST(N'2017-09-13T00:00:00.0000000' AS DateTime2), N'SPR1', 0, N'SPR1', 1, CAST(N'2017-08-30T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sprints] ([SprintId], [Done], [EndDate], [Goal], [InProgress], [Name], [ProjectId], [StartDate]) VALUES (2, 0, CAST(N'2017-09-25T00:00:00.0000000' AS DateTime2), N'SPR2', 0, N'SPR2', 1, CAST(N'2017-09-14T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Sprints] ([SprintId], [Done], [EndDate], [Goal], [InProgress], [Name], [ProjectId], [StartDate]) VALUES (4, 0, CAST(N'2017-12-05T00:00:00.0000000' AS DateTime2), N'asdfasdfaasd', 0, N'SPR3', 1, CAST(N'2017-12-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Sprints] OFF
SET IDENTITY_INSERT [dbo].[Tasks] ON 

INSERT [dbo].[Tasks] ([TaskId], [Complete], [Description], [InProgress], [PhaseId], [Priority], [SprintId], [UserId], [ProjectId]) VALUES (1, 1, N'asdf', 0, 1, N'High', 1, N'28b26833-8d93-4796-a3c8-cebcec5fdf0b', 1)
INSERT [dbo].[Tasks] ([TaskId], [Complete], [Description], [InProgress], [PhaseId], [Priority], [SprintId], [UserId], [ProjectId]) VALUES (2, 1, N'asdffdsfa', 0, 2, N'High', 1, N'3a29d541-5cad-48a3-a6a6-69878f13c9ed', 1)
INSERT [dbo].[Tasks] ([TaskId], [Complete], [Description], [InProgress], [PhaseId], [Priority], [SprintId], [UserId], [ProjectId]) VALUES (3, 0, N'asfdsdfd', 1, 3, N'High', 1, N'28b26833-8d93-4796-a3c8-cebcec5fdf0b', 1)
INSERT [dbo].[Tasks] ([TaskId], [Complete], [Description], [InProgress], [PhaseId], [Priority], [SprintId], [UserId], [ProjectId]) VALUES (4, 1, N'fdsfdfdfdf', 0, 1, N'High', 1, N'3a29d541-5cad-48a3-a6a6-69878f13c9ed', 1)
INSERT [dbo].[Tasks] ([TaskId], [Complete], [Description], [InProgress], [PhaseId], [Priority], [SprintId], [UserId], [ProjectId]) VALUES (5, 0, N'werwerwer', 0, 1, N'High', 1, N'54c24dc5-aea1-4b09-911a-4edfc2dfc2e5', 1)
INSERT [dbo].[Tasks] ([TaskId], [Complete], [Description], [InProgress], [PhaseId], [Priority], [SprintId], [UserId], [ProjectId]) VALUES (6, 0, N'asdfsddsfsdsd', 0, 1, N'High', 1, N'28b26833-8d93-4796-a3c8-cebcec5fdf0b', 1)
SET IDENTITY_INSERT [dbo].[Tasks] OFF
SET IDENTITY_INSERT [dbo].[UpdateTypes] ON 

INSERT [dbo].[UpdateTypes] ([UpdateTypeId], [Name]) VALUES (1, N'Note')
INSERT [dbo].[UpdateTypes] ([UpdateTypeId], [Name]) VALUES (2, N'Change')
INSERT [dbo].[UpdateTypes] ([UpdateTypeId], [Name]) VALUES (3, N'Beef')
SET IDENTITY_INSERT [dbo].[UpdateTypes] OFF
SET IDENTITY_INSERT [dbo].[Updates] ON 

INSERT [dbo].[Updates] ([UpdateId], [Note], [ProjectId], [SprintId], [TimeStamp], [UpdateTypeId], [UserId]) VALUES (1, N'asdf', 1, NULL, CAST(N'2017-08-30T09:12:00.8844835' AS DateTime2), 3, N'3a29d541-5cad-48a3-a6a6-69878f13c9ed')
INSERT [dbo].[Updates] ([UpdateId], [Note], [ProjectId], [SprintId], [TimeStamp], [UpdateTypeId], [UserId]) VALUES (3, N'asdfasdf', 1, NULL, CAST(N'2017-08-30T09:40:21.4645541' AS DateTime2), 2, N'3a29d541-5cad-48a3-a6a6-69878f13c9ed')
INSERT [dbo].[Updates] ([UpdateId], [Note], [ProjectId], [SprintId], [TimeStamp], [UpdateTypeId], [UserId]) VALUES (5, N'asdfasdfasd', 1, NULL, CAST(N'2017-08-30T09:41:26.8005083' AS DateTime2), 1, N'3a29d541-5cad-48a3-a6a6-69878f13c9ed')
SET IDENTITY_INSERT [dbo].[Updates] OFF
SET IDENTITY_INSERT [dbo].[ToolTypes] ON 

INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (1, N'Framework')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (2, N'Language')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (3, N'Stylesheet')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (4, N'Database')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (5, N'IDE')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (6, N'Markup Language')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (7, N'Hardware')
INSERT [dbo].[ToolTypes] ([ToolTypeId], [Name]) VALUES (8, N'Other')
SET IDENTITY_INSERT [dbo].[ToolTypes] OFF
SET IDENTITY_INSERT [dbo].[Tools] ON 

INSERT [dbo].[Tools] ([ToolId], [Description], [Documentation], [Name], [ToolTypeId]) VALUES (1, N'asdf', N'asdf', N'asdf', 3)
SET IDENTITY_INSERT [dbo].[Tools] OFF
SET IDENTITY_INSERT [dbo].[UserStories] ON 

INSERT [dbo].[UserStories] ([UserStoryId], [ProjectId], [Spec]) VALUES (1, 1, N'test')
INSERT [dbo].[UserStories] ([UserStoryId], [ProjectId], [Spec]) VALUES (2, 1, N'tes')
INSERT [dbo].[UserStories] ([UserStoryId], [ProjectId], [Spec]) VALUES (3, 1, N'te')
INSERT [dbo].[UserStories] ([UserStoryId], [ProjectId], [Spec]) VALUES (4, 1, N't')
SET IDENTITY_INSERT [dbo].[UserStories] OFF
INSERT [dbo].[ProjectTools] ([ProjectId], [ToolId]) VALUES (1, 1)
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170824181612_Initial', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170824195711_Initial1', N'1.0.0-rtm-21431')
