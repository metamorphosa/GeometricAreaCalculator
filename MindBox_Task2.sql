CREATE TABLE Products (Id INT PRIMARY KEY NOT NULL, Name nvarchar(255) NOT NULL);
CREATE TABLE Categories (Id INT PRIMARY KEY NOT NULL, Name nvarchar(255) NOT NULL);
CREATE TABLE ProductCategories (ProductId INT FOREIGN KEY REFERENCES Products(Id), CategoryId INT FOREIGN KEY REFERENCES Categories(Id));

INSERT INTO Products
VALUES
	(1, 'Potato'),
	(2, 'Banana'),
	(3, 'Beet'),
	(4, 'Meat'),
	(5, 'Mandarin'),
	(6, 'Phone'),
	(7, 'Monitor'),
	(8, 'Scotch'),
	(9, 'GameBook');

INSERT INTO Categories
VALUES
	(1, 'Vegetables'),
	(2, 'Fruits'),
	(3, 'Tech'),
	(4, 'Games'),
	(5, 'Books');

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 1),
	(5, 2),
	(6, 3),
	(7, 3),
	(9, 4),
	(9, 5);

SELECT p.Name AS Product, c.Name AS Category
FROM Products p
LEFT JOIN ProductCategories pc
	ON pc.ProductId = p.Id
LEFT JOIN Categories c
	On c.Id = pc.CategoryId	