/*创建polygon表*/
Create Table polygon(
	id Serial Primary Key,
	polygon Geometry(POLYGON,4326),
	polygonWithHole Geometry(POLYGON,4326),
	polygonz Geometry(POLYGONZ,4326),
	polygonm Geometry(POLYGONM,4326),
	polygonzm Geometry(POLYGONZM,4326)
);

/*向polygon表插入数据*/
Insert Into polygon(polygon,polygonWithHole,polygonz,polygonm,polygonzm)
	Values(
		ST_GeometryFromText('POLYGON((0 0,10 0,10 10,0 10,0 0))',4326),
		ST_GeometryFromText('POLYGON((0 0,10 0,10 10,0 10,0 0),(1 1,1 2,2 2,2 1,1 1))',4326),
		ST_GeometryFromText('POLYGONZ((0 0 0,10 0 0,10 10 10,0 10 10,0 0 0))',4326),
		ST_GeometryFromText('POLYGONM((0 0 0,10 0 0,10 10 10,0 10 10,0 0 0))',4326),
		ST_GeometryFromText('POLYGONZM((0 0 0 0,10 0 0 0,10 10 10 10,0 10 10 10,0 0 0 0))',4326)
);

/*查询polygon表*/
Select GeometryType(polygon) AS polygon, 
		GeometryType(polygonWithHole) AS polygonWithHole,
		GeometryType(polygonz) AS polygonz,
		GeometryType(polygonm) AS polygonm,
		GeometryType(polygonzm) AS polygonzm
From polygon;
