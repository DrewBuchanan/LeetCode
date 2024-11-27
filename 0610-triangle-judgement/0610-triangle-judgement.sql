/* Write your T-SQL query statement below */
SELECT  x,
        y,
        z,
        'Yes' as triangle
FROM triangle
WHERE x + y > z AND x + z > y AND y + z > x
UNION
SELECT  x,
        y,
        z,
        'No' as triangle
FROM triangle
WHERE NOT (x + y > z AND x + z > y AND y + z > x);