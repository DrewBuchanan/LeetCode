/* Write your T-SQL query statement below */
SELECT
    managers.employee_id AS employee_id,
    managers.name as name,
    (SELECT COUNT(*) FROM Employees reports WHERE managers.employee_id = reports.reports_to) as reports_count,
    (SELECT ROUND(AVG(reports.age * 1.0), 0) FROM Employees reports WHERE managers.employee_id = reports.reports_to) AS average_age
FROM Employees managers
WHERE EXISTS (SELECT * FROM Employees reports WHERE managers.employee_id = reports.reports_to)
ORDER BY employee_id