USE Motor_depot
GO
CREATE PROCEDURE driver_delete
@Id int
AS
DELETE FROM Driver WHERE id = @Id
