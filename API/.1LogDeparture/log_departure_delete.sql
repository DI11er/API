USE Motor_depot
GO
CREATE PROCEDURE log_departure_delete
@Id int
AS
DELETE FROM LogDeparture WHERE id = @Id
