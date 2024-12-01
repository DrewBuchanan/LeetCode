
/* Write your T-SQL query statement below */
SELECT Name
FROM Employee
WHERE id IN (
SELECT m.id
FROM Employee m
    INNER JOIN Employee r ON r.managerId = m.id
GROUP BY m.id
HAVING COUNT(*) >= 5);