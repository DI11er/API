USE Motor_depot
GO
CREATE PROCEDURE car_insert
@Model nvarchar(50),
@MaxWeight nvarchar(50)
AS
INSERT INTO Car VALUES(@Model, @MaxWeight)
