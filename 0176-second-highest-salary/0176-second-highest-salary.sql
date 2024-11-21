/* Write your T-SQL query statement below */
SELECT MAX(salary) as SecondHighestSalary
FROM Employee
WHERE salary NOT IN (SELECT MAX(salary) from Employee);