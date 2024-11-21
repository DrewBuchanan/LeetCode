/* Write your T-SQL query statement below */
SELECT p.firstName, p.lastName, a.city, a.state
FROM Person p
    LEFT OUTER JOIN address a ON p.personId = a.personId;