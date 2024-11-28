/* Write your T-SQL query statement below */
WITH cte AS (
    SELECT name, salary, departmentId, DENSE_RANK() OVER (PARTITION BY departmentId ORDER BY salary DESC) as rank
    FROM Employee
)
SELECT d.name as Department, c.name as Employee, c.salary as Salary
FROM cte c
    INNER JOIN Department d ON c.departmentId = d.id
WHERE rank = 1
ORDER BY d.name, c.salary DESC;