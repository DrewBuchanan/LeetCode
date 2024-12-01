/* Write your T-SQL query statement below */
/*
SELECT DISTINCT l.num as 'ConsecutiveNums'
FROM Logs l
    INNER JOIN Logs m ON m.id = l.id + 1 AND m.num = l.num
    INNER JOIN Logs n ON n.id = l.id + 2 AND n.num = l.num;
    */
    
    
SELECT DISTINCT num as 'ConsecutiveNums'
FROM Logs l
WHERE 2 <= (SELECT COUNT(*) FROM Logs WHERE l.num = num AND id IN (l.id + 1, l.id + 2))