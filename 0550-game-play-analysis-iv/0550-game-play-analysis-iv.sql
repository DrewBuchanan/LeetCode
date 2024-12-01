/* Write your T-SQL query statement below */
WITH loginsOrdered AS
(
    SELECT player_id, event_date, ROW_NUMBER() OVER (PARTITION BY player_id ORDER BY event_date) as rn
    FROM activity
    
),
multiple AS
(
    SELECT DISTINCT a.player_id
    FROM loginsOrdered a
        INNER JOIN loginsOrdered b ON a.player_id = b.player_id AND a.rn = 1 AND b.rn = 2 AND b.event_date = DATEADD(DAY, 1, a.event_date)
)
SELECT CAST((SELECT COUNT(*) * 1.0 FROM multiple) /
     (SELECT COUNT(DISTINCT player_id) FROM Activity) AS NUMERIC(3,2)) 'fraction';