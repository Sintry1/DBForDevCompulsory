--Create categories table 03/03/2024 v1.0
CREATE TABLE categories (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

--Migration 1 of Products table
--03/03/2024 V2 
ALTER TABLE Products
ADD category_id INT;

ALTER TABLE Products
ADD CONSTRAINT FK_Products_Category FOREIGN KEY (category_id) REFERENCES categories(id);
