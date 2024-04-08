/* 创建商品信息 */
INSERT INTO ProductInfo
    (pdtId, pdtName, pdtPrice, pdtType, pdtDetails, pdtPic, pdtFactory, pdtLatestDate, pdtNum)
VALUES('test011', '小米13', 4699, '数码产品', '小米最新旗舰手机……', NULL, '小米科技有限公司', NULL, 2000),
    ('test012', '深度学习Deep Learning', 299, '图书', '号称AI圣经……', NULL, '人民邮电出版社', '2023-06-01', 50),
    ('test201', 'XPhone', 2999.99, '数码产品', '高性能处理器', '/images/p.jpg', 'X科技公司', '2023-06-02', 50),
    ('test654', 'GO编程入门', 59.99, '图书', '适合初学者的GO编程入门教材', '/images/book1.jpg', '人民邮电出版社', '2023-06-01', 10),
    ('test564', '数据分析', 79.99, '图书', '介绍Python数据分析的实用指南', '/images/book2.jpg', '清华大学出版社', '2023-06-01', 15),
    ('test932', 'C数据结构与算法', 49.99, '图书', 'C的数据结构与算法的教材', '/images/book3.jpg', '人民邮电出版社', '2023-06-01', 20);
-- DELETE FROM ProductInfo;

/* 创建用户 */
INSERT INTO UserInfo
VALUES(
        '13500001001',
        '测试用户01',
        '男',
        'test_user01@shoping.com',
        '云南省大理白族自治州大理市海月街1号'
),
    (
        '13900001022',
        '测试用户02',
        '女',
        'test_user02@shoping.com',
        '云南省大理白族自治州大理市海月街1号'
);
-- DELETE FROM UserInfo;

/* 创建订单 */
INSERT INTO OrderInfo
    (ordId,uPhoneNum,ordSubTime,ordState)
VALUES(
        '20230618000000001',
        '13500001001',
        '08:00:30',
        '已发货'
),
    (
        '20230621000000022',
        '13900001022',
        '20:30:00',
        '已提交'
);
-- DELETE FROM OrderInfo;

/* 创建商品到订单信息 */
INSERT INTO OrderProductInfo
    (ordId,pdtId,pdtCnt)
VALUES('20230618000000001', 'test012', 1),
    ('20230618000000001', 'test654', 1),
    ('20230621000000022', 'test564', 1),
    ('20230621000000022', 'test932', 2);
-- DELETE FROM OrderProductInfo;