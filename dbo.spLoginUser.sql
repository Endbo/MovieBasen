CREATE PROCEDURE [dbo].[spLoginUser]
@UserName nvarchar(100)
AS
	begin
	Declare @count int
	Declare @attemt int
	Declare @userLock bit

	select @userLock = LockoutEnabled
	from AspNetUsers where UserName = @UserName

	if (@userLock = 0)
	begin
	select 1 as accountLock, 0 as authenticated, 0 as retryattem
	END

	begin
	select @attemt = ISNULL(AccessFailedCount, 0)
	from AspNetUsers where UserName = @UserName

	set @attemt = @attemt + 1

	if (@attemt <=3)
	begin
	update AspNetUsers set AccessFailedCount = @attemt where UserName = @UserName
	select 0 as accountLock, 0 as authenticated, @attemt as retryattem
	END

	else
	begin 
	update AspNetUsers set AccessFailedCount = @attemt, LockoutEnabled = 0, LockoutEndDateUtc = GETDATE()
	where UserName = @UserName

	select 1 as accountLock, 0 as authenticated, 0 as retryattem
	END
	END
END