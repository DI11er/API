USE Motor_depot
GO
CREATE PROCEDURE car_update
@Id int,
@Model nvarchar(50),
@MaxWeight nvarchar(50)
AS
UPDATE Car SET model = @Model, maxWeight = @MaxWeight where id = @Id