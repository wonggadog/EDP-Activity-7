CREATE DATABASE newalbum;
USE newalbum;

-- Create Artists table
CREATE TABLE Artists (
    ArtistID INT PRIMARY KEY IDENTITY,
    ArtistName NVARCHAR(255) NOT NULL,
    Genre NVARCHAR(100),
    Country NVARCHAR(100),
    Website NVARCHAR(255)
);

-- Create Albums table
CREATE TABLE Albums (
    AlbumID INT PRIMARY KEY IDENTITY,
    ArtistID INT,
    AlbumTitle NVARCHAR(255) NOT NULL,
    ReleaseDate DATE,
    Price NUMERIC(10, 2),
    StockQuantity INT,
    FOREIGN KEY (ArtistID) REFERENCES Artists(ArtistID)
);

-- Create Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) UNIQUE,
    Address NVARCHAR(255),
    City NVARCHAR(100),
    State NVARCHAR(100),
    ZipCode NVARCHAR(20)
);

-- Create Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount NUMERIC(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Create OrderDetails table
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY,
    OrderID INT,
    AlbumID INT,
    Quantity INT,
    Price NUMERIC(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (AlbumID) REFERENCES Albums(AlbumID)
);

CREATE TABLE credentials (
  username NVARCHAR(45) NOT NULL,
  password NVARCHAR(45) NULL,
  PRIMARY KEY (username)
);





-- Insert data into Artists table
INSERT INTO Artists (ArtistName, Genre, Country, Website) VALUES
('Guns N Roses', 'Hard Rock', 'Los Angeles', 'www.gunsnroses.com'),
('Metallica', 'Metal', 'Los Angeles', 'www.metallica.com'),
('Aerosmith', 'Hard Rock', 'Boston', 'www.aerosmith.com'),
('Bon Jovi', 'Hard Rock', 'New Jersey', 'www.bonjovi.com'),
('Queen', 'Classic Rock', 'London', 'www.queenband.com'),
('Megadeth', 'Metal', 'Los Angeles', 'www.megadeth.com'),
('U2', 'Classic Rock', 'Dublin', 'www.u2.com'),
('Nirvana', 'Grunge', 'Aberdeen', 'www.nirvana.com'),
('Kiss', 'Rock', 'New York', 'www.kissonline.com'),
('Motley Crue', 'Hard Rock', 'Hollywood', 'www.motleycrue.com');

-- Insert data into Albums table
INSERT INTO Albums (ArtistID, AlbumTitle, ReleaseDate, Price, StockQuantity) VALUES
(1, 'Appetite for Destruction', '1987-07-21', 12.99, 100),
(2, 'Kill em all', '1983-07-25', 14.99, 80),
(3, 'Slippery When Wet', '1986-08-18', 11.99, 120),
(4, 'Queen', '1973-07-13', 9.99, 150),
(5, 'Rust in Peace', '1990-09-24', 10.99, 90),
(6, 'War', '1983-02-10', 13.99, 110),
(7, 'Bleach', '1989-06-15', 15.99, 70),
(8, 'Kiss', '1974-02-18', 16.99, 100),
(9, 'Too Fast for Love', '1981-11-10', 11.99, 130),
(10, 'Album10 by Artist10', '2023-06-28', 12.99, 95);

-- Insert data into Customers table
INSERT INTO Customers (FirstName, LastName, Email, Address, City, State, ZipCode) VALUES
('Carlo', 'Catampongan', 'kaloyloy@example.com', 'Busay', 'Daraga', 'PH', '4501'),
('Michael', 'Tindugan', 'mikeysomehting@example.com', 'San Fernando', 'Daraga', 'PH', '4500'),
('Mark', 'Ate', 'bunsoy@example.com', 'Taysan', 'Legazpi', 'PH', '4500'),
('Charty', 'Torres', 'chartyganda@example.com', 'Central Occidental', 'Polangui', 'PH', '4501'),
('Sally', 'Fransisco', 'salsally@example.com', 'Pandan', 'Daraga', 'PH', '4502'),
('Gene', 'Fransisco', 'genevy@example.com', 'Bañag', 'Daraga', 'PH', '4500'),
('Karl', 'Daet', 'kakarl@example.com', 'Arimbay', 'Arimbay', 'PH', '4501'),
('Ryan', 'Lorica', 'loricams@example.com', 'Rizal', 'Legazpi', 'PH', '4502'),
('Abby', 'Gervacio', 'bygayle@example.com', 'San Vicente', 'Tabaco', 'PH', '4500'),
('Al Dian', 'Wong', 'wonggadog@example.com', 'Busay', 'Daraga', 'PH', '4502');

-- Insert data into Orders table
INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES
(1, '2023-01-05', 38.97),
(2, '2022-05-18', 44.97),
(3, '2023-09-25', 23.98),
(4, '2021-12-15', 39.96),
(5, '2022-08-10', 21.98),
(6, '2023-03-20', 41.97),
(7, '2022-12-05', 63.93),
(8, '2023-07-25', 50.97),
(9, '2022-02-20', 35.97),
(10, '2023-06-30', 38.97);

-- Insert data into OrderDetails table
INSERT INTO OrderDetails (OrderID, AlbumID, Quantity, Price) VALUES
(1, 1, 3, 38.97),
(2, 2, 3, 44.97),
(3, 3, 2, 23.98),
(4, 4, 4, 39.96),
(5, 5, 2, 21.98),
(6, 6, 3, 41.97),
(7, 7, 4, 63.93),
(8, 8, 3, 50.97),
(9, 9, 3, 35.97),
(10, 10, 3, 38.97);

-- Insert data into credentials table
INSERT INTO credentials (username, password) VALUES ('root', 'wong');

SELECT * FROM Artists;
SELECT * FROM Albums;
SELECT * FROM Customers;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;
SELECT * FROM credentials;