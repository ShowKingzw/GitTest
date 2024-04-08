--1
Drop Index nyc_census_blocks_geom_idx;

--2
Select blocks.blkid
From nyc_census_blocks blocks
Join nyc_subway_stations subways
On st_contains(blocks.geom,subways.geom)
Where subways.name = 'Broad St';

--3
Create Index nyc_census_blocks_geom_idx
On nyc_census_blocks
Using gist(geom);
