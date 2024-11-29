/* Write your T-SQL query statement below */
WITH unbanned_drivers AS
(
    SELECT users_id
    FROM Users
    WHERE banned = 'No' AND role = 'driver'
),
unbanned_clients AS
(
    SELECT users_id
    FROM Users
    WHERE banned = 'No' AND role = 'client'
)
SELECT  request_at AS 'Day',
        CAST(ROUND(SUM(CASE WHEN t.status <> 'completed' THEN 1 ELSE 0 END) * 1.00 / COUNT(*), 2) AS NUMERIC(3,2)) AS 'Cancellation Rate'
FROM Trips t
    INNER JOIN unbanned_drivers d ON d.users_id = t.driver_id
    INNER JOIN unbanned_clients c ON c.users_id = t.client_id
WHERE CAST(t.request_at AS DATE) >= '10-01-2013' AND CAST(t.request_at AS DATE) <= '10-03-2013'
GROUP BY request_at;