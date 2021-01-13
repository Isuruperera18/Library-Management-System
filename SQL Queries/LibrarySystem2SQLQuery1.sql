
GO
CREATE TRIGGER AfterINSERTTrigger on [Branch]
FOR INSERT 
AS DECLARE 
	   @LibName VARCHAR(50),
	   @ContactNum nchar(10);

SELECT @LibName = ins.Library_Name FROM INSERTED ins;
SELECT @ContactNum = ins.Contect_Number FROM INSERTED ins;


INSERT INTO [Library]( 
       [Library_Name]
      ,[Contect_Number])
VALUES (@LibName,
	@ContactNum
	
	);
PRINT 'Trigger Fired for INSERT'
GO
--trigger2--

GO
CREATE TRIGGER [[AfterDeletetrigger] on [Branch]
FOR DELETE
AS DECLARE 
	   @LibName VARCHAR(50),
	   @ContactNum nchar(10);

SELECT @LibName = ins.Library_Name FROM DELETED ins;
SELECT @ContactNum = ins.Contect_Number FROM DELETED ins;


DELETE FROM dbo.Library  
WHERE Library.Contect_Number = @ContactNum;  
	
PRINT 'Trigger Fired and Deleted the record.'
-------------------------------------------------------------------------------------
-- Views --

CREATE VIEW [Borrowed_Books_by_Member] AS
SELECT MemberID, Issue_Date, Returned_Date, Due_Date
FROM Lend
WHERE MemberID = 'MemberID_variable'; 

CREATE VIEW [Books_By_Publisher] AS
SELECT Title, ISBN
FROM Books
WHERE PublisherID = 'PublisherID_Variable'; 

CREATE VIEW [Branches_By_City] AS
SELECT Library_No, Library_Name, Contect_Number, Street
FROM Branch
WHERE PublisherID = 'City_Variable'; 
-------------------------------------------------------------------------------------

--funcs--





CREATE FUNCTION Books_afteraYear (
	@year VARCHAR(6)
)
RETURNS TABLE AS
RETURN
	SELECT *
	FROM CopyRecords 
	WHERE CopyRecords.Copy_Year > @year;
	
	
	
	
	CREATE FUNCTION fullName (@firstName VARCHAR(50), @lastName VARCHAR(50))
  RETURNS VARCHAR(200)
  AS
    BEGIN 
       RETURN (SELECT  @firstName + SPACE(2) + @lastName )
    END
	
	
	---usage---
	
	GO
SELECT [MemberID]
       -- Passing Parameters to fullname Function
      ,dbo.fullname([FirstName], [lastName]) AS [Name]
      ,[Education]
      ,[Occupation]
      ,[YearlyIncome]
      ,[Sales]
      ,[HireDate]
  FROM [Member]

-------------------------------------------------------------------------------------

-- stored procedures-01-


CREATE PROCEDURE BooksBorrowedByDate @Date DATE
AS
SELECT * FROM Lend WHERE Issue_Date = @Date
GO;

--usage--
EXEC BooksBorrowedByDate @Date = '2020-10-20'; 

--stored procedures-02-

CREATE PROCEDURE AvailableBooksBetweenDates @DayInput1 VARCHAR(20), @DayInput2 VARCHAR(20)
AS

SELECT * FROM Books
WHERE ISBN NOT IN (
   SELECT DISTINCT ISBN
   FROM Lend
   WHERE Issue_Date <= @DayInput1 AND Due_Date >= @DayInput2 );
GO

--usage--

EXEC AvailableBooksBetweenDates @DayInput1 = '2020-10-09', @DayInput2 = '2020-10-13'; 

--end--