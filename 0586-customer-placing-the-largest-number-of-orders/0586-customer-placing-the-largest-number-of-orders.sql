/* Write your T-SQL query statement below */
WITH cte AS
(
    SELECT customer_number, COUNT(*) as count
    FROM Orders
    GROUP BY customer_number
)
SELECT TOP 1 customer_number FROM cte ORDER BY count DESC