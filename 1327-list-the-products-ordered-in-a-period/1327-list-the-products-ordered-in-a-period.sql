/* Write your T-SQL query statement below */
SELECT p.product_name, SUM(o.unit) as unit
FROM Products p
    LEFT OUTER JOIN Orders o ON p.product_id = o.product_id
WHERE o.order_date >= '2020-2-1' AND o.order_date < '2020-3-1'
GROUP BY p.product_name
HAVING SUM(o.unit) >= 100;