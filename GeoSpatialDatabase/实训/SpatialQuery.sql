CREATE DATABASE 某地区域发展布局数据库
CREATE EXTENSION postgis;
CREATE EXTENSION postgis_topology;


-- 查询海南省（46）县区名字中含有“江”字的区域信息
Select * 
From area
Where name Like '%江%' And pac>=460000 and pac<470000; 

--查询昌江黎族自治县
SELECT geom
FROM area
WHERE name = '昌江黎族自治县';

--查询某一地区凸包
SELECT ST_ConvexHull(geom) AS convex_hull
FROM area
WHERE name = '灵川县';
