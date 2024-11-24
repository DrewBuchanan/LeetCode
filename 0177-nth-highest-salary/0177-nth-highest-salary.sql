CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        SELECT TOP 1 COALESCE(a.salary, NULL)
        FROM (SELECT DISTINCT DENSE_RANK() OVER (ORDER BY salary DESC) AS row, salary
            FROM Employee) a
        WHERE a.row = @N
    );
END