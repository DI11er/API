USE Motor_depot
GO
CREATE PROCEDURE flight_update
@Id int,
@Way nvarchar(50)
AS
UPDATE Flight SET way=@Way WHERE id = @Id