Create Extension postgis;

/*创建point表*/
Create Table point(
	id Serial Primary Key,
	point Geometry(POINT,4326),
	pointz Geometry(POINTZ,4326),
	pointm Geometry(POINTM,4326),
	pointzm Geometry(POINTZM,4326)
);

/*向point表插入数据*/
Insert Into point(point,pointz,pointm,pointzm)
	Values(
		ST_GeometryFromText('POINT(10 10)',4326),
		ST_GeometryFromText('POINTZ(10 10 10)',4326),
		ST_GeometryFromText('POINTM(10 10 10)',4326),
		ST_GeometryFromText('POINTZM(10 10 10 10)',4326)
);

/*查询poin表*/
Select GeometryType(point) As point, GeometryType(pointz) AS pointz,
	GeometryType(pointm) AS pointm, GeometryType(pointzm) AS pointzm
From point;