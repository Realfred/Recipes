CREATE TABLE [dbo].[Recipe]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1,1)
	, Name nvarchar (50) NOT NULL
	, PrepTimeMinutes int NOT NULL
	, TotalCookTimeMinutes int NOT NULL
	, Steps nvarchar (MAX) NOT NULL
	, Servings smallint NOT NULL
)
