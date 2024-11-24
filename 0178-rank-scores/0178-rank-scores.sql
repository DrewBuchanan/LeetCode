/* Write your T-SQL query statement below */
SELECT score, DENSE_RANK() OVER (ORDER BY score DESC) as rank
FROM scores
ORDER BY 1 DESC