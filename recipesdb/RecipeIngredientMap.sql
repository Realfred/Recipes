CREATE TABLE [dbo].[ReceipeIngredientMap]
(
	[RecipeId] INT NOT NULL 
  , [IngredientId] INT NOT NULL, QuantityOz smallint
    CONSTRAINT [PK_RecipeIngredientMap] PRIMARY KEY ([RecipeId], [IngredientId]), 
    CONSTRAINT [FK_ReceipeIngredientMap_Recipe] FOREIGN KEY ([RecipeId]) REFERENCES [Recipe]([Id]) ,
    CONSTRAINT [FK_ReceipeIngredientMap_Ingredient] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredient]([Id]) 

) 

