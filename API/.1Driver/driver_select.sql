USE Motor_depot
GO
CREATE PROCEDURE driver_select
AS
SELECT id, name, surname, patronymic FROM Driver
