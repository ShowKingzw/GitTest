CREATE DATABASE 实验2;
USE 实验2;

/* 商品信息表 */
CREATE TABLE ProductInfo
(
    pdtId VARCHAR(10) CONSTRAINT pk_pdt_id PRIMARY KEY,
    pdtName VARCHAR(30) NOT NULL,
    pdtPrice FLOAT(2) NOT NULL,
    pdtType VARCHAR(20),
    pdtDetails VARCHAR(100),
    -- 用于存储缩略图的文件路径或URL地址
    pdtPic VARCHAR(255),
    pdtFactory VARCHAR(30),
    pdtLatestDate DATE,
    pdtNum INT
);

/* 用户信息表 */
CREATE TABLE UserInfo
(
    -- 以手机号为uid
    uPhoneNum CHAR(11) CONSTRAINT pk_user_uid PRIMARY KEY,
    uName VARCHAR(10) NOT NULL,
    uGender char(2),
    uEmail VARCHAR(30),
    uAddr VARCHAR(100) NOT NULL,
);

/* 订单信息表 */
CREATE TABLE OrderInfo
(
    --参照订单id
    ordId CHAR(17) CONSTRAINT pk_ord_oid PRIMARY KEY,
    --参照手机号码（uid）
    uPhoneNum CHAR(11) CONSTRAINT fk_ord_uid 
        FOREIGN KEY REFERENCES UserInfo(uPhoneNum),
    ordSubTime TIME NOT NULL,
    ordState CHAR(6) NOT NULL
);

/* 订单商品信息表 */
CREATE TABLE OrderProductInfo
(
    --参照订单id
    ordId CHAR(17) CONSTRAINT fk_op_oid 
        FOREIGN KEY REFERENCES OrderInfo(ordId),
    --参照商品id
    pdtId VARCHAR(10) CONSTRAINT fk_op_pid 
        FOREIGN KEY REFERENCES ProductInfo(pdtId),
    pdtCnt INT
        CONSTRAINT pk_op_oid_pid PRIMARY KEY(ordId,pdtId)
);

/* 视图：显示订单编号及总价 */
CREATE VIEW ViewTotalCost
AS
    (
    SELECT ordId AS 订单编号, SUM(pdtPrice*pdtCnt) AS 总价
    FROM OrderProductInfo, ProductInfo
    GROUP BY ordId 
    );
-- 使用视图
SELECT *
FROM ViewTotalCost;
