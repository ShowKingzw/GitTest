/*复杂空间查询*/

--例5-1 找出距离Stream中河流中心线最近的一个区域。
SELECT Z1.name, S1.Name
FROM Zone Z1,Streams S1
WHERE ST_Distance(Z1.Boundary, S1.Centerline)<
	ALL(SELECT ST_Distance(Z2.Boundary, S1.Centerline)
		FROM Zone Z2
		WHERE Z1.Name<>Z2.name);

--例5-2 找出中心线长度超过“主街”的所有路段。
SELECT RS1, name
FROM Road_Segments RS1
WHERE ST_Length (RS1.Centerline) >
	ANY(SELECT ST_Length(RS2. Centerline)
		FROM Road_Segments RS2
		WHERE RS2.Name<>'主街');

--例5-3 列出数据库中所有池塘和湖泊的名字和形状。
SELECT Name,Shores
FROM Ponds
UNION
	SELECT Name, Shore
	FROM Lakes;