CREATE TABLE Contacts
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50),
	Age INT,
	Email VARCHAR(100)
);



CREATE TABLE Projects
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(100),
	[Description] TEXT,
	CreatedDate DATE
);

ALTER TABLE Projects
ALTER COLUMN Title NVARCHAR(100)
ALTER TABLE Contacts
ALTER COLUMN Name VARCHAR(50)
ALTER TABLE Contacts
ALTER COLUMN Name VARCHAR(50)
ALTER TABLE Projects
ALTER COLUMN [Description] NVARCHAR(MAX)





CREATE TABLE Orders
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Quantity DECIMAL(10,2),
	Price DECIMAL(10,2),
	IsActive BIT
);

ALTER TABLE Contacts
ADD Phone VARCHAR(20)



DROP TABLE Orders

INSERT INTO Contacts(Name, Age,Email, Phone)
    VALUES 
	('������', 30, 'oleksiy@example.com', '123-456-7890'),
    ('�����', 25, 'irina@example.com', '987-654-3210'),
    ('³����', 35, 'viktor@example.com', '555-123-4567')

INSERT INTO Projects(Title, [Description] , CreatedDate)
    VALUES
	('������� ��������� �������', '�������� ������� ��� ��������� �������� �� �����', '2024-04-15'),
    ('���-���� ��� ��������� ����������', '��������� ���-����� ��� ����� ����� �� ���������', '2024-04-16'),
    ('��������� ��������� �������', '������������� ��������������� �� ���������� ��������� �������', '2024-04-17')

UPDATE Contacts
SET Phone = '000-000-1111'
WHERE ID = 1	

DELETE Projects
WHERE ID = 2

SELECT * FROM Projects

--6

SELECT * FROM Contacts

SELECT DISTINCT	Name FROM Contacts

SELECT TOP 2 * FROM Projects
WHERE CreatedDate BETWEEN '2024-04-15' AND '2024-04-17'
ORDER BY CreatedDate

SELECT * FROM Contacts
WHERE Name LIKE '%�%'

SELECT * FROM Contacts
WHERE Age < 40 AND Email LIKE '%example%'

SELECT * FROM Projects
WHERE [Description] LIKE '%�����%' OR  [Description] LIKE '%�������%'
ORDER BY CreatedDate DESC

SELECT Name, Age,
   CASE 
       WHEN Age >= 35 THEN 'adult'
	   WHEN Age >= 30 and Age <= 35 THEN 'semi adult'
	   ELSE 'not adult'
   END AS [Group]

 FROM Contacts

  SELECT Name, Phone,
  IIF(Phone is NOT NULL, Phone , '0') AS PhoneNumber 
  FROM Contacts

  SELECT CreatedDate FROM Projects
  GROUP BY CreatedDate
  HAVING 
 
