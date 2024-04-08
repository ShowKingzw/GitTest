/*1．查询各位学生的学号、班级和姓名。*/
SELECT 学号, 专业班级, 姓名
FROM 学生表;


/*2．查询课程的全部信息。*/
SELECT *
FROM 课程表;


/*3．查询数据库中有哪些专业班级。*/
SELECT DISTINCT 专业班级
FROM 学生表;


/*4．查询学时数大于60的课程信息。*/
SELECT *
FROM 课程表
WHERE 学时数>60;


/*5．查询在1986年出生的学生的学号、姓名和出生日期。*/
SELECT 学号, 姓名, 出生日期
FROM 学生表
WHERE Year(出生日期)=1986;


/*6．查询三次作业的成绩都在80分以上的学号、课程号。*/
SELECT 学号, 课程号
FROM 学生作业表
WHERE 作业1成绩>80 AND 作业2成绩>80 AND 作业3成绩>80;


/*7．查询姓张的学生的学号、姓名和专业班级。*/
SELECT 学号, 姓名, 专业班级
FROM 学生表
WHERE 姓名 LIKE '张%';


/*8．查询05级的男生信息。*/
SELECT *
FROM 学生表
WHERE 专业班级 LIKE '%05' AND 性别='男';


/*9．查询没有作业成绩的学号和课程号。*/
SELECT 学号, 课程号
FROM 学生作业表
WHERE 作业1成绩 IS NULL OR 作业2成绩 IS NULL OR 作业3成绩 IS NULL;


/*10．查询学号为0538的学生的作业1总分。*/
SELECT sum(作业1成绩)
FROM 学生作业表
WHERE 学号='0538';


/*11．查询选修了K001课程的学生人数。*/
SELECT COUNT(DISTINCT 学号) AS K001课程的人数
FROM 学生作业表
WHERE 课程号='K001';


/*12．查询数据库中共有多少个班级。*/
SELECT Count(DISTINCT 专业班级) AS 所有班级个数
FROM 学生表


/*13．查询选修三门以上（含三门）课程的学生的学号和作业1平均分、作业2平均分和作业3平均分。*/
SELECT 学号, AVG(作业1成绩) AS 作业1平均分
, AVG(作业2成绩)AS 作业2平均分, AVG(作业3成绩) AS 作业3平均分
FROM 学生作业表
GROUP BY 学号
HAVING Count(课程号)>=3;


/*14．查询于兰兰的选课信息，列出学号、姓名、课程名（使用两种连接查询的方式）。*/

-- 内连接
SELECT 学生表.学号, 学生表.姓名, 课程表.课程名
FROM 学生表
    INNER JOIN 学生作业表 ON 学生表.学号 = 学生作业表.学号
    INNER JOIN 课程表 ON 学生作业表.课程号=课程表.课程号
WHERE 学生表.姓名='于兰兰';

-- 左外外连接
SELECT 学生表.学号, 学生表.姓名, 课程表.课程名
FROM 学生表
LEFT OUTER JOIN 学生作业表 ON 学生表.学号 = 学生作业表.学号
LEFT OUTER JOIN 课程表 ON 课程表.课程号= 学生作业表.课程号
Where 学生表.姓名 = '于兰兰';
