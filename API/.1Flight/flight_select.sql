USE Motor_depot
GO
CREATE PROCEDURE flight_select
AS
SELECT id, way FROM Flight
