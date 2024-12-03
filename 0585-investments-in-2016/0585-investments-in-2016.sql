WITH distinct_locations AS
(
	SELECT lat, lon
	FROM insurance
	GROUP BY lat, lon
	HAVING COUNT(*) = 1
)
SELECT CAST(SUM(i.tiv_2016) as NUMERIC(18,2)) as 'tiv_2016'
FROM Insurance i
	INNER JOIN distinct_locations d ON i.lat = d.lat AND i.lon = d.lon
WHERE EXISTS (SELECT * FROM Insurance j WHERE i.pid <> j.pid AND j.tiv_2015 = i.tiv_2015)