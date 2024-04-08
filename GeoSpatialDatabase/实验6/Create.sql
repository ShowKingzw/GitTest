Create Extension postgis;

/*空间参考系*/
Insert Into Spatial_ref_sys 
Values(101,'POSC',32214,'PROJCS["UTM_ZONE_14N",
	GEOGCS["World Geodetic System 72",
	DATUM["WGS_72",ELLIPSOID["NWL_10D",6378135,298.26]],PRIMEE["Greenwich",0],
	UNIT["Meter",1.0]],PROJECTION["Transverse_Mercator"],
	PARAMETER["Flase_Easting",500000.0],PARAMETER["False_Northing",0.0],
	PARAMETER["Central_Meridian",-99.0],PARAMETER["Scale_Factor",0.9996],
	PARAMETER["Latitude_of_origin",0.0],UNIT["Meter",1.0]]');
								   
-- 湖泊
CREATE TABLE lakes(
	fid Integer not null primary key,
	name varchar(64),
	shore geometry
	);

-- 路段
Create Table road_segments(
	fid Integer not null primary key,
	name varchar(64),
	alises varchar(64),
	num_lanes Integer,
	centerline geometry
);

-- 组合路
Create Table divided_routes(
	fid Integer not null primary key,
	name varchar(64),
	num_lanes Integer,
	centerlines geometry
	);
	
--桥
Create Table bridges(
	fid Integer not null primary key,
	name varchar(64),
	roadseg1id Integer References road_segments,
	roadseg2id Integer References road_segments,
	position geometry
);

-- 河流
Create Table streams(
	fid Integer not null primary key,
	name varchar(64),
	fromlakeid Integer References lakes,
	tolakeid Integer References lakes,
	centerline geometry
);

--建筑物
CREATE TABLE buildings (
	fid INTEGER NOT NULL PRIMARY KEY,
	address VARCHAR(64),
	position GEOMETRY,
	footprint GEOMETRY
);

-- 池塘
CREATE TABLE ponds (
	fid INTEGER NOT NULL PRIMARY KEY,
	name VARCHAR(64),
	type VARCHAR(64),
	shores GEOMETRY
);

--岛
CREATE TABLE island(
	fid INTEGER NOT NULL PRIMARY KEY,
	name VARCHAR(64),
	lakeid INTEGER REFERENCES lakes,
	boundary GEOMETRY
);

--区域
CREATE TABLE zone (
	fid INTEGER NOT NULL PRIMARY KEY,
	name VARCHAR(64),
	boundary GEOMETRY
);