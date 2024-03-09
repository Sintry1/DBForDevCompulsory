Instructions for setting up the project:
Create a Database, as the script don't include creation of the database, merely the initial table creation.

Documentation for the executing the manual migrations.
The manual migrations can be executes in any order wanted
Merely run the SQL scripts as querries on your desired database and the tables, constaints and column additions will be created.



For rollbacks the following scripts would work for each stage:
The order fo the following script do matter, in the sense that the constraints need to be dropped before the columns and tables can be dropped

To roll back product ratings:
```sql
--Roll back to NOT include product ratings in the database schema
--First to rollback ProductRatings table and then Products table
-- We first need to drop the foreign key constraint if they exists
ALTER TABLE Products
DROP CONSTRAINT IF EXISTS FK_Products_ProductRatings;

-- then we can drop column rating_id from Products table if it exists
ALTER TABLE Products
DROP COLUMN IF EXISTS rating_id;

-- and finally drop ProductRatings table if it exists
DROP TABLE IF EXISTS Product_Ratings;
```

and the following to roll back categories.
```sql
--Rollback to NOT include categories in the database schema
--Next to roll back the Categories table and the related foreign key constraint in products table
-- We first need to drop the foreign key constraint if they exists
ALTER TABLE products
DROP CONSTRAINT IF EXISTS FK_Products_category_id;

-- then we can drop column category_id from Products table if it exists
ALTER TABLE products
DROP COLUMN IF EXISTS category_id;

-- and finally drop Categories table if it exists
DROP TABLE IF EXISTS categories;
```
