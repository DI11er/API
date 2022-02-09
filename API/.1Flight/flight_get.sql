USE Motor_depot
GO
CREATE PROCEDURE flight_get
@Id int
AS
SELECT id, way FROM Flight WHERE id=@Id
