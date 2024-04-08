CREATE EXTENSION Postgis;
CREATE EXTENSION Postgis_raster;

/*例4-20*/
CREATE TABLE simulate_rast(rid int4, rast raster);


/*例4-21*/
INSERT INTO simulate_rast (rid,rast)
	VALUES(1,
	('01'
	||'0000'
	||'0000'
	||'0000000000000040'
	||'0000000000000840'
	||'000000000000E03F'
	||'000000000000E03F'
	||'0000000000000000'
	||'0000000000000000'
	||'00000000'
	||'0A00'
	||'1400'):: raster),
	(2,('01000003009A9999999999A93F9A9999999999A9BF000000E02B274A'
||'41000000007719564100000000000000000000000000000000FFFFFFFF050005000400FDFEFDFEFEFDFEFEFDF9FAFEF'
||'EFCF9FBFDFEFEFDFCFAFEFEFE04004E627AADD16076B4F9FE6370A9F5FE59637AB0E54F58617087040046566487A1506CA2E3FA5A6CAFFBFE4D566DA4CB3E454C5665'):: raster);


/*例4-22*/
ALTER TABLE simulate_rast Drop Column rast;
-- 把删除的字段再添加回来
ALTER TABLE simulate_rast Add column rast raster;


/*例4-23*/
INSERT INTO simulate_rast(rid, rast)
	VALUES(
	15, ST_MakeEmptyRaster(100, 100, 0.0005, 0.0005, 1, 1, 0,0,4326)
	);
	
/*例4-24*/
SELECT ST_GeoReference (rast,'GDAL') As gdal_ref, 
	ST_GeoReference (rast,'ESRI') As esri_ref 
FROM simulate_rast 
WHERE rid=1;


/*例4-25*/
SELECT st_BandIsNoData(rast,1)
FROM simulate_rast
WHERE rid =2;

/*例4-26*/
SELECT rid, ST_Value(rast, 1, 1, 1) As b1val, 
	ST_Value(rast, 2, 1, 1) As b2val
FROM simulate_rast
WHERE rid= 2;


/*例4-27*/
SELECT st_asbinary(rast)
FROM simulate_rast
WHERE rid = 1;


/*例4-28*/
UPDATE simulate_rast
SET rast = st_SetGeoReference(rast,'20031.52','ESRI')
WHERE rid =5;


/*例4-29*/
UPDATE simulate_rast
SET rast = st_SetBandIsNoData(rast,1)
WHERE rid =7;


/*例4-30*/
SELECT st_AStext(st_Envelope(rast)) AS env,
	st_astext(st_convexHull(rast)) AS convhull
FROM simulate_rast
WHERE rid =1;



