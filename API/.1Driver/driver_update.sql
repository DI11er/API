USE Motor_depot
GO
CREATE PROCEDURE driver_update
@Id int,
@Name nvarchar(50),
@Surname nvarchar(50),
@Patronymic nvarchar(50)
AS
UPDATE Driver SET name=@Name, surname = @Surname, patronymic = @Patronymic where id = @Id