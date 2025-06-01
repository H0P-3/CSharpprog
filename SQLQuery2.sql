use gtacademy

select * from [Student Record] where Gender = 'male';



SELECT TOP (1000) [StudentID]
      ,[FirstName]
      ,[LastName]
      ,[Gender]
      ,[DOB]
      ,[Email]
      ,[PhoneNumber]
      ,[Department]
      ,[GPA]
      ,[Graduated]
  FROM [gtacademy].[dbo].[Student Record]
