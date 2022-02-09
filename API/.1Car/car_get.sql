USE Motor_depot
GO
CREATE PROCEDURE car_get
@Id int
AS
SELECT id, model, maxWeight FROM Car WHERE id=@Id
