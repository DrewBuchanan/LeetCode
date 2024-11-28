/* Write your T-SQL query statement below */
WITH cte AS
(
    SELECT employee_id, COUNT(*) as 'dept_count'
    FROM Employee
    GROUP BY employee_id
)
SELECT e.employee_id, e.department_id
FROM cte c
    INNER JOIN Employee e ON c.employee_id = e.employee_id
WHERE e.primary_flag = 'Y' OR c.dept_count = 1;