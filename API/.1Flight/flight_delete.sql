USE Motor_depot
GO
CREATE PROCEDURE flight_delete
@Id int
AS
DELETE FROM Flight WHERE id = @Id
