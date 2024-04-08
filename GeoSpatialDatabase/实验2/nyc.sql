/*（1）查看布鲁克林所有社区的名字*/
SELECT name
FROM nyc_neighborhoods
WHERE BORONAME = 'Brooklyn';


/*（2）查询布鲁克林所有社区的名字里各有多少个字母。*/
Select char_length(name)
From nyc_neighborhoods
Where boroname = 'Brooklyn';


/*（3）布鲁克林所有社区名字的平均字母数和字母数的标准差是多少。*/
Select avg(char_length(name)) AS 平均字母数, 
	stddev(char_length(name)) AS 字母数标准差
From nyc_neighborhoods
Where boroname = 'Brooklyn';


/*（4）基于各个行政区进行分组，纽约市各个行政区的所有社区名字的平均字母数是多少。*/
Select boroname,avg(char_length(name))
From nyc_neighborhoods
Group By boroname;


/*（5）纽约市的总人口是多少？*/
Select sum(popn_total) As 总人口
From nyc_census_blocks;


/*（6）布朗克斯（Bronx）行政区的总人口是多少。*/
Select sum(popn_total) As Bronx总人口
From nyc_census_blocks
Where boroname = 'The Bronx';


/*（7）对每个行政区来说，白人占该行政区总人口的百分比是多少。*/
Select boroname, 
	(sum(popn_white)/sum(popn_total))*100 As 各区白人占百分比
From nyc_census_blocks
Group By boroname;



