USE Motor_depot
GO
CREATE PROCEDURE driver_get
@Id int
AS
SELECT id, name, surname, patronymic FROM Driver WHERE id=@Id
