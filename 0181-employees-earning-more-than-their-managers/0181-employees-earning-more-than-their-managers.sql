/* Write your T-SQL query statement below */
SELECT e1.name as Employee
FROM Employee e1
WHERE e1.salary > (SELECT salary FROM employee e2 WHERE e1.managerId = e2.id)