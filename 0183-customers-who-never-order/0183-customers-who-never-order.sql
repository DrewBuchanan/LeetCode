/* Write your T-SQL query statement below */
SELECT name as Customers
FROM customers c
WHERE NOT EXISTS (SELECT * FROM orders o WHERE o.customerId = c.id)