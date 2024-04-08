/*空间数据的插入*/

-- 湖泊
INSERT INTO lakes VALUES (101,'蓝湖',
	ST_GeomFromText('MULTIPOLYGON(((52 18, 66 23, 73 9, 48 6,52 18),
		(59 18,67 18,67 13,59 13,59 18)))',101));

INSERT INTO lakes VALUES(0,'图外其他湖泊');

-- 路段
INSERT INTO road_segments VALUES(102,'路5', NULL,2,
	ST_GeomFromText('LINESTRING(0 18,10 21,16 23,28 26,44 31)',101));

INSERT INTO road_segments VALUES(103,'路5','主街',4,
	ST_GeomFromText('LINESTRING(44 31,56 34,70 38)',101));

INSERT INTO road_segments VALUES(104,'路5',NULL, 2,
	ST_GeomFromText('LINESTRING(70 38,72 48)',101));

INSERT INTO road_segments VALUES(105, '主街',NULL,4,
	ST_GeomFromText('LINESTRING(70 38,84 42)',101));

INSERT INTO road_segments VALUES(106,'绿森林边路',NULL,1,
	ST_GeomFromText('LINESTRING(28 26,28 0)',101));

--组合路
INSERT INTO divided_routes VALUES(119,'路 75', 4,
	ST_GeomFromText('MULTILINESTRING((10 48, 10 21, 10 0), (16 0, 16 23, 16
	48))', 101));

--桥
INSERT INTO bridges VALUES(110,'卡姆桥',102,103, st_PointFromText('POINT(44 31)',101));

-- 河流
INSERT INTO streams VALUES(111,'卡姆河',0,101,
	ST_GeomFromText('LINESTRING(38 48,44 41,41 36,44 31,52 18)',101));

INSERT INTO streams VALUES(112, NULL,101,0,
	ST_GeomFromText('LINESTRING(76 0, 78 4, 73 9 )', 101));

-- 建筑物
INSERT INTO buildings VALUES(113,'主街123号',
	ST_GeomFromText('POINT(52 30)', 101),
	ST_GeomFromText('POLYGON((50 31,54 31,54 29,50 29,50 31))',101));

INSERT INTO buildings VALUES(114,'主街215号',
	ST_GeomFromText('POINT(64 33)', 101),
	ST_GeomFromText('POLYGON((66 34, 62 34, 62 32,66 32,66 34))',101));

-- 池塘
INSERT INTO ponds VALUES(120, NULL,'思道哥池塘',
	ST_GeomFromText('MULTIPOLYGON(((24 44, 22 42,24 40,24 44)),
	((26 44,26 40,28 42,26 44)))',101));

--岛
INSERT INTO island VALUES(109,'鹅岛',101,
	ST_GeomFromText('MULTIPOLYGON(((67 13,67 18,59 18,59 13,67 13)))',101));

--区域
INSERT INTO zone VALUES(117,'阿诗顿',
	ST_GeomFromText('MULTIPOLYGON(((62 48, 84 48,84 30,56 30,56 34,62
	48)))',101));

INSERT INTO zone VALUES(118,'绿森林',
	ST_GeomFromText('MULTIPOLYGON(((28 26,28 0, 84 0,84 42,28 26),
	(52 18, 66 23, 73 9,48 6, 52 18)), ((59 18,67 18,67 13,59 13,59 18)))',101));

