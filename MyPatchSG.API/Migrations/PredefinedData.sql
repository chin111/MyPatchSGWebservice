SET IDENTITY_INSERT [dbo].[Clients] ON
GO

INSERT [dbo].[Clients] ([Id], [Secret], [Name], [ApplicationType], [Active], [RefreshTokenLifeTime], [AllowedOrigin]) VALUES (N'TestMyPatchSGClient', N'Vw5vMAoZ3Q6FRUdnHL1/qOmLVWQinn0boe6SNKLOMHQ=', N'Test Web MyPatchSG API Client', 0, 1, 7200, N'http://localhost')
GO
INSERT [dbo].[Clients] ([Id], [Secret], [Name], [ApplicationType], [Active], [RefreshTokenLifeTime], [AllowedOrigin]) VALUES (N'TestNativeMyPatchSGClient', N'lCXDroz4HhR1EIx8qaz3C13z/quTXBkQ3Q5hj7Qx3aA=', N'Test Native MyPatchSG Client', 1, 1, 14400, N'*')
GO

SET IDENTITY_INSERT [dbo].[Clients] OFF
GO

SET IDENTITY_INSERT [dbo].[AppInfos] ON
GO

INSERT [dbo].[AppInfos] ([Id], [ClientOS], [Version], [AppStoreURL], [ForceUpdate], [Remark]) VALUES (N'1001', N'ANDROID', N'1.0', N'', 0, N'1: ForceUpdate, 0: Manual Update')
GO
INSERT [dbo].[AppInfos] ([Id], [ClientOS], [Version], [AppStoreURL], [ForceUpdate], [Remark]) VALUES (N'1002', N'IOS', N'1.0', N'', 0, N'1: ForceUpdate, 0: Manual Update')
GO

SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
