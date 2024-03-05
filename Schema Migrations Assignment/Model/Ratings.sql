-- Migration V3
-- Adding ProductRatings table
CREATE TABLE product_ratings(
  rating_id INT AUTO_INCREMENT PRIMARY KEY,
  rating INT NOT_NULL
)

ALTER TABLE Products(
  ADD rating_id INT,
  ADD FOREIGN KEY (rating_id) REFERENCES ProductRatings(rating_id);
)