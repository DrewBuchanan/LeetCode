/* Write your T-SQL query statement below */
SELECT s.name
FROM SalesPerson s
    LEFT OUTER JOIN Orders o ON o.sales_id = s.sales_id
    LEFT OUTER JOIN Company c ON c.com_id = o.com_id
GROUP BY s.name
HAVING SUM(CASE WHEN c.name = 'RED' THEN 1 ELSE 0 END) = 0;