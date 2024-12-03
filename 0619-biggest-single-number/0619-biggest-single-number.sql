/* Write your T-SQL query statement below */
SELECT TOP 1 num
FROM (SELECT TOP 1 num
FROM MyNumbers
GROUP BY num
HAVING COUNT(*) = 1
ORDER BY num DESC
UNION SELECT NULL) a
ORDER BY num DESC;