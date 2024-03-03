--Create categories table 03/03/2024 v1.0
CREATE TABLE categories (
	id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
);

--Migration 1 of Products table
--03/03/2024 V2 
ALTER TABLE products
ADD category_id INT,
ADD FOREIGN KEY (category_id) REFERENCES categories(id);
