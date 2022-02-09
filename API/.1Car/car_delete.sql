USE Motor_depot
GO
CREATE PROCEDURE car_delete
@Id int
AS
DELETE FROM Car WHERE id = @Id
