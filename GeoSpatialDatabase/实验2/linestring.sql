/*创建linestring表*/
Create Table linestring(
	id Serial Primary Key,
	linestring Geometry(LINESTRING,4326),
	linestringz Geometry(LINESTRINGZ,4326),
	linestringm Geometry(LINESTRINGM,4326),
	linestringzm Geometry(LINESTRINGZM,4326)
);

/*向linstring表插入数据*/
Insert Into linestring(linestring,linestringz,linestringm,linestringzm)
	Values(
		ST_GeometryFromText('LINESTRING(10 10,20 20,30 30)',4326),
		ST_GeometryFromText('LINESTRINGZ(10 10 10,20 20 20,30 30 30)',4326),
		ST_GeometryFromText('LINESTRINGM(10 10 10,20 20 20,30 30 30)',4326),
		ST_GeometryFromText('LINESTRINGZM(10 10 10 10,20 20 20 20,30 30 30 30)',4326)
);

/*查询linestring表*/
Select GeometryType(linestring) AS linestring, GeometryType(linestringz) AS linestringz,
	GeometryType(linestringm) AS linestringm, GeometryType(linestringzm) AS linestringzm
From linestring;