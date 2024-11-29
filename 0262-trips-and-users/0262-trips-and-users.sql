/* Write your T-SQL query statement below */
SELECT  request_at AS 'Day',
        CAST(ROUND(SUM(CASE WHEN t.status IN ('cancelled_by_driver', 'cancelled_by_client') THEN 1 ELSE 0 END) * 1.00 / COUNT(*), 2) AS NUMERIC(3,2)) AS 'Cancellation Rate'
FROM Trips t
    INNER JOIN Users d ON d.banned = 'No' AND d.role = 'driver' AND d.users_id = t.driver_id
    INNER JOIN Users c ON c.banned = 'No' AND c.role = 'client' AND c.users_id = t.client_id
WHERE CAST(t.request_at AS DATE) >= '10-01-2013' AND CAST(t.request_at AS DATE) <= '10-03-2013'
GROUP BY request_at;