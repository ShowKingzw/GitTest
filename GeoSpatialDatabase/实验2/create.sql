/*创建point表*/
Create Table point(
	id Serial Primary Key,
	point Geometry(Point,4326),
	pointz Geometry(Pointz,4326),
	pointm Geometry(Pointm,4326),
	pointzm Geometry(Pointzm,4326)
);

/*创建linestring表*/
Create Table linestring(
	id Serial Primary Key,
	linestring Geometry(Linestring,4326),
	linestringz Geometry(Linestringz,4326),
	linestringm Geometry(Linestringm,4326),
	linestringzm Geometry(Linestringzm,4326)
);

/*创建polygon表*/
Create Table polygon(
	id Serial Primary Key,
	polygon Geometry(Polygon,4326),
	polygonWithHole Geometry(polygon,4326),
	polygonz Geometry(Polygonz,4326),
	polygonm Geometry(Polygonm,4326),
	polygonzm Geometry(Polygonzm,4326)
);

/*创建multipoint表*/
Create Table multipoint(
	multipoint Geometry(Multipoint,4326),
	multipointz Geometry(Multipointz,4326),
	multipointm Geometry(Multipointm,4326),
	multipointzm Geometry(Multipointzm,4326)
);

-- /*创建geometrycollection表*/
-- Create Table geometryCollection(
-- 	geometrycollection Geometry(geometrycollection,4326),
-- 	geometrycollectionz Geometry(geometrycollectionz,4326),
-- 	geometrycollectionm Geometry(geometrycollectionm,4326),
-- 	geometrycollectionzm Geometry(geometrycollectionzm,4326)
-- );



