USE Motor_depot
GO
CREATE PROCEDURE driver_insert
@Name nvarchar(50),
@Surname nvarchar(50),
@Patronymic nvarchar(50)
AS
INSERT INTO Driver VALUES(@Name, @Surname, @Patronymic)
