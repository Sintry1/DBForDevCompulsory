-- Migration V3
-- Adding ProductRatings table
CREATE TABLE product_ratings(
  rating_id INT IDENTITY(1,1) PRIMARY KEY,
  rating INT NOT NULL
);

ALTER TABLE Products
ADD rating_id INT;

ALTER TABLE Products
ADD CONSTRAINT FK_Products_ProductRatings FOREIGN KEY (rating_id) REFERENCES product_ratings(rating_id);
