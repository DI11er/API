USE Motor_depot
GO
CREATE PROCEDURE log_departure_update
@Id int,
@IdCar int,
@IdDriver int,
@IdFlight int,
@DepartureTimeDate datetime,
@ProductName nvarchar(50),
@ProductValume nvarchar(50)
AS
UPDATE LogDeparture SET id_Cars=@IdCar, id_Drivers = @IdDriver, id_Flights = @IdFlight, departure_time_date = @DepartureTimeDate, product_name = @ProductName, product_valume = @ProductValume WHERE id = @Id