/*向point表插入数据*/
Insert Into point(point,pointz,pointm,pointzm)
	Values(
		ST_GeometryFromText('POINT(10 10)',4326),
		ST_GeometryFromText('POINT Z(10 10 10)',4326),
		ST_GeometryFromText('POINT M(10 10 10)',4326),
		ST_GeometryFromText('POINT ZM(10 10 10 10)',4326)
);

/*向linstring表插入数据*/
Insert Into linestring(linestring,linestringz,linestringm,linestringzm)
	Values(
		ST_GeometryFromText('linestring (10 10,20 20,30 30)',4326),
		ST_GeometryFromText('linestring z (10 10 10,20 20 20,30 30 30)',4326),
		ST_GeometryFromText('linestring m (10 10 10,20 20 20,30 30 30)',4326),
		ST_GeometryFromText('linestring zm (10 10 10 10,20 20 20 20,30 30 30 30)',4326)
	);

/*向polygon表插入数据*/
Insert Into polygon(polygon,polygonWithHole,polygonz,polygonm,polygonzm)
	Values(
		ST_GeometryFromText('Polygon((0 0,10 0,10 10,0 10,0 0))',4326),
		ST_GeometryFromText('Polygon((0 0,10 0,10 10,0 10,0 0),(1 1,1 2,2 2,2 1,1 1))',4326),
		ST_GeometryFromText('Polygonz((0 0 0,10 0 0,10 10 10,0 10 10,0 0 0))',4326),
		ST_GeometryFromText('Polygonm((0 0 0,10 0 0,10 10 10,0 10 10,0 0 0))',4326),
		ST_GeometryFromText('Polygonzm((0 0 0 0,10 0 0 0,10 10 10 10,0 10 10 10,0 0 0 0))',4326)
	); 	
	
/*向multipoint表插入数据*/
Insert Into multipoint(multipoint,multipointz,multipointm,multipointzm)
	Values(
		ST_GeometryFromText('multipoint(-1 1,0 0,2 3)',4326),
		ST_GeometryFromText('multipointz(-1 1 3,0 0 1,2 3 1)',4326),
		ST_GeometryFromText('multipointm(-1 1 4,0 0 2,2 3 2)',4326),
		ST_GeometryFromText('multipointzm(-1 1 3 4,0 0 1 2,2 3 1 2)',4326)
	);
	
-- /*向geometrycollection表插入数据*/
-- Insert into geometrycollection(
-- 	geometrycollection,
-- 	geometrycollectionz,
-- 	geometrycollectionm,
-- 	geometrycollectionzm
-- )
-- Values(
-- 	ST_GeometryFromText(
-- 		'Geometrycollection(
-- 			multipoint(-1 1,0 0,2 3),
-- 			multilinestring((0 0,0 1,1 1),(-1 1,-1 -1)),
-- 			polygon(
-- 				(-0.25 -1.25,-0.25 1.25,2.5 1.25,2.5 -1.25,-0.25 -1.25),
-- 				(2.25 0,1.25 1,1.25 -1,2.25 0),
-- 				(1 -1,1 1,0 0,1 -1)))',4326));
	




