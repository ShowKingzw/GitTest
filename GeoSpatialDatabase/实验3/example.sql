Create extension postgis; 


/*例4-1*/
CREATE TABLE landuse
(
	landuse_id INT4 NOT NULL,
	"name" VARCHAR(20),
	the_geom GEOMETRY,
	area FLOAT8,
	perimemter FLOAT8,
	CONSTRAINT pk_landuse PRIMARY KEY(landuse_id)
);


/*例4-2*/
CREATE INDEX geo_index ON landuse USING RTREE(the_geom);


/*例4-3*/
INSERT INTO landuse(landuse_id,name,the_geom,area,perimemter)
VALUES(
	'12','Trimber-forest','01010000001DDB93F460BB4241A84E5AC86F455441',
	'4.78067e+007','3.42462e+004'
	  );


/*例4-4*/
CREATE TABLE landuse_new
(
	landuse_new_id INT4 NOT NULL,
	"name" VARCHAR(20),
	the_geom GEOMETRY,
	area FLOAT8,
	perimemter FLOAT8,
	CONSTRAINT pk_landuse_new PRIMARY KEY(landuse_new_id)
); 

INSERT INTO landuse_new(landuse_new_id,name,the_geom,area,perimemter)
		SELECT * FROM landuse WHERE landuse_id<15;


/*例4-5*/
SELECT AddGeometryColumn('public','landuse','geom',-1,'POLYGON',2);


/*例4-6*/
SELECT ST_LineFromWKB(st_asbinary(st_geomfromtext('linestring(1 2,3 4)'))) 
		AS aline;


/*例4-7*/
SELECT st_issimple(st_geomfromtext('linestring(1 1,2 2,1 3,1 2,2 1)'))
		AS smpl_line, 
		st_issimple(st_geomfromtext('polygon((0 0,0 1,1 1,1 0,0 0))'))
		AS smpl_plygn;


/*例4-8*/
SELECT st_asbinary(st_geomfromtext('polygon((0 0,0 1,1 1,1 0,0 0))',4326));
SELECT st_asewkt(st_geomfromtext('polygon((0 0,0 1,1 1,1 0,0 0))',4326));
SELECT st_assvg(st_geomfromtext('polygon((0 0,0 1,1 1,1 0,0 0))',4326));


/*例4-9*/
SELECT st_asewkt(st_forcecollection(
		'polygon((0 0 2,0 5 2,5 0 2,0 0 2),(1 1 2,3 1 2,1 3 2,1 1 2))'));


/*例4-10*/
SELECT st_asewkt(st_forcerhr(
		'polygon((0 0 2,5 0 2,0 5 2,0 0 2),(1 1 2,1 3 2,3 1 2,1 1 2))'));


/*例4-11*/
SELECT st_asewkt(
    st_affine(the_geom, cos(pi()), 
		-sin(pi()), 0, sin(pi()), cos(pi()),
		0, 0, 0, 1, 0, 0, 0)) AS using_affine
		FROM(
			SELECT st_geomfromewkt('linestring(1 2 3,1 4 3)') AS the_geom)
			AS HAHA;


/*例4-12*/
SELECT st_centroid(the_geom)
FROM landuse
WHERE landuse_id = 12;


/*例4-13*/
SELECT st_buffer(the_geom,3)
FROM landuse
WHERE landuse_id = 12;


/*例4-14*/
SELECT landuse.column1, landuse_new.column1, 
	landuse.column2 && landuse_new.column2 AS overlaps
FROM (VALUES
		(1,'linestring(0 0,2 2)'::geometry),
		(2,'linestring(0 1,0 3)'::geometry)) AS landuse,
		(VAlues
		(3,'linestring(1 1,3 5)'::geometry)) AS landuse_new;


/*例4-15*/
SELECT st_intersects(st_geomfromtext('polygon((1 1,2 1,2 3,1 1))'),
		st_geomfromtext('polygon((3 0,3 2,4 0,3 0))'));


/*例4-16*/
SELECT st_azimuth(st_geomfromtext('point(0 0)'), st_geomfromtext('point(1 1)'));


/*例4-17*/
SELECT st_DistanceSpheroid(st_centroid(the_geom), 
	st_geomfromtext('point(-118 38)'), 
	'SPHEROID["GRS_1980",6378137,298.257222101]')--SPHEROID要大写
FROM landuse;


/*例4-18*/
SELECT st_asewkt(st_lineinterpolatepoint(the_line,0.03))
FROM(SELECT st_geomfromewkt('linestring(25 30,80 100,150 210)')
	AS the_line) AS HOHO;


/*例4-19*/
SELECT st_estimatedextent('public','landuse','the_geom');
SELECT sum(st_memsize(the_geom))
FROM landuse;
