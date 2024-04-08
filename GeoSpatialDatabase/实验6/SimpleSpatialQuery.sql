/*简单空间查询*/
--1 查找数据库中所有的空间表
SELECT F_TABLE_NAME
FROM GEOMETRY_COLUMNS;

--2 查找streams表空间参考系的授权
SELECT S.AUTH_SRID
FROM SPATIAL_REF_SYS S,GEOMETRY_COLUMNS G
WHERE G.F_TABLE_NAME='streams'AND S.SRID=G.SRID;

--3 获得75号路的几何类型
SELECT ST_GeometryType(centerlines)
FROM divided_routes 
WHERE name='路75';

--4 获得鹅岛的WKT表示
SELECT ST_AsText(boundary)
FROM island 
WHERE name ='鹅岛';

--5 判断名为路5别名为 “主街”的路段的几何属性是否为空 
SELECT ST_IsEmpty(centerline)
FROM road_segments
WHERE name ='路5' AND alises = '主街';

--6 蓝湖的几何结构是否是简单的
SELECT ST_IsSimple(shore)
FROM lakes 
WHERE name ='蓝湖';

--7 获得鹅岛的边界
SELECT ST_AsText(ST_Boundary(boundary)) 
FROM island 
WHERE name='鹅岛';

--8 获得鹅岛的MBR边界
SELECT ST_AsText(ST_Envelope(boundary)) 
FROM island 
WHERE name='鹅岛';

--9 获得卡姆桥的x，y坐标
SELECT ST_X(position),ST_Y(position)
FROM bridges 
WHERE name='卡姆桥';

--10 获得102路段的起点和终点
SELECT ST_AsText(ST_StartPoint(centerline)),ST_AsText(ST_EndPoint(centerline))
FROM road_segments 
WHERE fid =102;

--11 判断鹅岛的MBR 边界是否闭合
SELECT ST_IsClosed(ST_Boundary(boundary)) 
FROM island 
WHERE name ='鹅岛';

--12 获得106路段的长度
SELECT ST_Length(centerline)
FROM road_segments 
WHERE fid =106;

--13 获得102路段中点的数目
SELECT ST_NumPoints(centerline)
FROM road_segments 
WHERE fid = 102;

--14 获得102路段中点的第一个点
SELECT ST_AsText(ST_PointN(centerline, 1))
FROM road_segments 
WHERE fid = 102;

--15 获得鹅岛的质心
SELECT ST_AsText(ST_Centroid(boundary))
FROM island 
WHERE name='鹅岛';

--16 判断PointOnSurface函数返回鹅岛上的点是否在其边界内
SELECT ST_Contains(boundary,ST_PointOnSurface(boundary))
FROM island 
WHERE name ='鹅岛';

--17 获得鹅岛的面积
SELECT ST_Area(boundary)
FROM island 
WHERE name ='鹅岛';

--18 获得蓝湖内环的数目
SELECT ST_NumInteriorRing(shore)
FROM lakes 
WHERE name ='蓝湖';

--19 判断 75号路的几何元素的数目
SELECT ST_NumGeometries(centerlines) 
FROM divided_routes 
WHERE name='路 75';

--20 获得75号路的第2个几何元素
SELECT ST_AsText(ST_GeometryN(centerlines,2))
FROM divided_routes 
WHERE name ='路 75';

--21 获得75号路的长度
SELECT ST_Length(centerlines)
FROM divided_routes 
WHERE name ='路75';

--22 判断鹅岛是否与其WKT表示构造的同样几何结构是否相等
SELECT ST_Equals(boundary, ST_PolyFromText('POLYGON((67 13,67 18,59 18,59 13,67 13))',101)) 
FROM island 
WHERE name='鹅岛';

--23 判断 75 号路是否与阿诗顿相离
SELECT ST_Disjoint(centerlines, boundary) 
FROM divided_routes d,zone z
WHERE d.name ='路 75' AND z.name='阿诗顿';

--24 卡姆河流是否与蓝湖相接
SELECT ST_Touches(s. centerline, l.shore) 
FROM streams s, lakes l
WHERE s.name='卡姆河'AND l.name='蓝湖';

--25 判断主街215号的建筑物是否在阿诗顿内
SELECT ST_Within(z. boundary, b.footprint) 
FROM zone z, buildings b
WHERE z.name ='阿诗顿'AND b.address ='主街215号';

--26 判断102路段是否跨越75号路
SELECT ST_Crosses(r. centerline,d.centerlines)
FROM road_segments r,divided_routes d 
WHERE r.fid =102 AND d.name='路 75';

--27 判断鹅岛与阿诗顿是否符合"TTTTTTTTT"的关系
SELECT ST_Relate(z.boundary, i.boundary,'TTTTTTTTT')
FROM zone z,island i
WHERE z.name='阿诗顿'AND i.name='鹅岛';

--28 获得卡姆桥与阿诗顿的距离
SELECT ST_Distance(position, boundary) 
FROM bridges b, zone z
WHERE b.name='卡姆桥'AND z.name='阿诗顿';

--29 获得卡姆河与蓝湖相交部分的几何结构
SELECT ST_AsText(ST_Intersection(s.centerline,l.shore))
FROM streams s, lakes l
WHERE s.name ='卡姆河'AND l. name='蓝湖';

--30 获得蓝湖和鹅岛并的几何结构
SELECT ST_AsText(ST_Union(l.shore,i.boundary))
FROM lakes l,island i
WHERE l.name ='蓝湖'AND i.name='鹅岛';

--31 获得蓝湖和鹅岛对称差的几何结构
SELECT ST_AsText(ST_SymDifference(l.shore,i.boundary))
FROM lakes l, island i
WHERE l.name ='蓝湖'AND i.name='鹅岛';

--32 获得蓝湖的凸包
SELECT ST_AsText(ST_ConvexHull(shore))
FROM lakes 
WHERE name ='蓝湖';