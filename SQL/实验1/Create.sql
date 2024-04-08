CREATE DATABASE 实验;
USE 实验;

-- 创建学生表
CREATE TABLE 学生表
(
    学号 CHAR(4) CONSTRAINT pk_student_sno PRIMARY KEY, -- 主键约束
    姓名 VARCHAR(10) NOT NULL,
    性别 CHAR(2) NOT NULL DEFAULT '男',
    专业班级 VARCHAR(10) NOT NULL,
    出生日期 DATE NOT NULL,
    联系电话 CHAR(11)
);

-- 创建课程表
CREATE TABLE 课程表
(
    课程号 CHAR(4) CONSTRAINT pk_course_cno PRIMARY KEY, -- 主键约束
    课程名 VARCHAR(20) NOT NULL CONSTRAINT uk_course_cname UNIQUE, -- 唯一性约束
    学分数 FLOAT(1) NOT NULL,
    学时数 INT NOT NULL,
    任课教师 VARCHAR(10) NOT NULL
);

-- 创建学生作业表
CREATE TABLE 学生作业表
(
    课程号 CHAR(4) NOT NULL CONSTRAINT fk_work_cno 
        FOREIGN KEY REFERENCES 课程表(课程号), -- 参照 课程表(课程号)
    学号 CHAR(4) NOT NULL CONSTRAINT fk_work_sno 
        FOREIGN KEY REFERENCES 学生表(学号), -- 参照 学生表(学号)
    -- 对三种成绩分数区间进行约束
    作业1成绩 INT CONSTRAINT chk_score1_range 
        CHECK(作业1成绩 >= 0 AND 作业1成绩 <= 100),
    作业2成绩 INT CONSTRAINT chk_score2_range 
        CHECK(作业2成绩 >= 0 AND 作业2成绩 <= 100),
    作业3成绩 INT CONSTRAINT chk_score3_range 
        CHECK(作业3成绩 >= 0 AND 作业3成绩 <= 100),
    -- 表级约束：主键约束
    CONSTRAINT pk_work_cno_sno PRIMARY KEY(课程号,学号)
);
