/* Write your T-SQL query statement below */
SELECT day.id
FROM Weather day
WHERE day.temperature > (SELECT temperature FROM Weather priorDay WHERE priorDay.recordDate = DATEADD(day, -1, day.recordDate))