create table BaseUser (
	   ID uniqueidentifier default newid() not null primary key,
	   UserName nvarchar(30) not null,
	   Password nvarchar(100) not null,
	   CreatedTime DateTime default getdate(),
	   ModifiedTime DateTime default getdate()
)
