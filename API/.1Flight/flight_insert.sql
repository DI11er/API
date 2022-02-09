USE Motor_depot
GO
CREATE PROCEDURE flight_insert
@Way nvarchar(50)
AS
INSERT INTO Flight VALUES(@Way)
