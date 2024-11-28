/* Write your T-SQL query statement below */
SELECT e1.employee_id, e1.department_id
FROM Employee e1
WHERE e1.primary_flag = 'Y' OR 1 = (SELECT COUNT(*) FROM Employee e2 WHERE e2.employee_id = e1.employee_id);