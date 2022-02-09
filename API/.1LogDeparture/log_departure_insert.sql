USE Motor_depot
GO
CREATE PROCEDURE log_departure_insert
@IdCar int,
@IdDriver int,
@IdFlight int,
@DepartureTimeDate datetime,
@ProductName nvarchar(50),
@ProductValume nvarchar(50)
AS
INSERT INTO LogDeparture VALUES(@IdCar, @IdDriver, @IdFlight, @DepartureTimeDate, @ProductName, @ProductValume)
