USE Motor_depot
GO
CREATE PROCEDURE log_departure_select
AS
SELECT id, id_Cars, id_Drivers, id_Flights, departure_time_date, product_name, product_valume FROM LogDeparture
