CREATE DATABASE BMS;

USE BMS;

/*图书信息表*/
CREATE TABLE books
(
    -- 主键
    bookisbn int CONSTRAINT pk_books_isbn PRIMARY KEY,
    bookname varchar(50) NOT NULL,
    bookauthor varchar(20) NOT NULL,
    bookpress varchar(20),
    bookprice float(2),
    bookcount int NOT NULL,
    bookintro varchar(200),
    booktheme varchar(20)
);

/*用户信息表*/
CREATE TABLE users
(
    -- 主键
    userid int CONSTRAINT pk_users_userid PRIMARY KEY,
    userpwd varchar(20) NOT NULL,
    username varchar(10) NOT NULL,
    usergender char(2),
    usertel int NOT NULL
);

/*管理员信息表*/
CREATE TABLE adminusers
(
    -- 主键
    adminid int CONSTRAINT pk_adminusers_adminid PRIMARY KEY,
    adminpwd varchar(20) NOT NULL,
    adminname varchar(10) NOT NULL,
    admingender char(2),
    admintel int NOT NULL
);

/*借阅记录信息表*/
CREATE TABLE record
(
    userid int CONSTRAINT fk_record_userid FOREIGN KEY REFERENCES users(userid),
    bookisbn int CONSTRAINT fk_record_bookisbn FOREIGN KEY REFERENCES books(bookisbn),
    timestart date,
    -- 主键
    CONSTRAINT pk_record_userid_bookisbn PRIMARY KEY (userid, bookisbn)
);