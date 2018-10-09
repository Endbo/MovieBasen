CREATE TRIGGER [dbo].[TringerRoles] 
   ON  [dbo].[AspNetUsers]
   AFTER INSERT
AS 
BEGIN
	declare @userId varchar(200)
	declare @roleId varchar(200)
	declare @admin varchar(200)

	select @admin = Email from inserted
	select @userId = Id from inserted

		if(@admin = 'benyamneamen@gmail.com')		
			select @roleId = Id from [dbo].[AspNetRoles] where Name = 'Admin'
		
		else
			select @roleId = Id from [dbo].[AspNetRoles] where Name = 'Normal'

	
	Insert into AspNetUserRoles (UserId , RoleId)
	values (@userId, @roleId)
	
END