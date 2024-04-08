/*创建multipoint表*/
Create Table multipoint(
	multipoint Geometry(Multipoint,4326),
	multipointz Geometry(Multipointz,4326),
	multipointm Geometry(Multipointm,4326),
	multipointzm Geometry(Multipointzm,4326)
);

/*向multipoint表插入数据*/
Insert Into multipoint(multipoint,multipointz,multipointm,multipointzm)
	Values(
		ST_GeometryFromText('multipoint(-1 1,0 0,2 3)',4326),
		ST_GeometryFromText('multipointz(-1 1 3,0 0 1,2 3 1)',4326),
		ST_GeometryFromText('multipointm(-1 1 4,0 0 2,2 3 2)',4326),
		ST_GeometryFromText('multipointzm(-1 1 3 4,0 0 1 2,2 3 1 2)',4326)
);