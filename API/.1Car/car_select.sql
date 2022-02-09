USE Motor_depot
GO
CREATE PROCEDURE car_select
AS
SELECT id, model, maxWeight FROM Car
