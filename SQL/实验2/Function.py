from Connect import *
import pymssql
import os

# 添加数据到数据库
def InsertProductInfo(conn, pdtId, pdtName, pdtPrice, pdtType, pdtDetails, pdtPic, pdtFactory, pdtLatestDate, pdtNum):
    # get游标
    cursor = conn.cursor()

    # 用字符串声明插入数据的SQL代码
    insertQuery = "INSERT INTO ProductInfo (pdtId, pdtName, pdtPrice, pdtType, pdtDetails, pdtPic, pdtFactory, pdtLatestDate, pdtNum) VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s)"

    # 构造参数元组
    values = (pdtId, pdtName, pdtPrice, pdtType, pdtDetails,
              pdtPic, pdtFactory, pdtLatestDate, pdtNum)

    try:
        # 执行插入语句
        cursor.execute(insertQuery, values)
        # 提交事务
        conn.commit()
        # print("test")
        print("商品信息插入成功！")
    except:
        # 回滚
        conn.rollback()
        print("插入错误")
    finally:
        # 关闭游标
        cursor.close()

# 从文件读取需要添加的数据到列表
def ReadProductInfoFile(fileName):
    productList = []
    try:
        # 解决相对路径问题
        scriptDir = os.path.dirname(os.path.abspath(__file__))
        fileName = os.path.join(scriptDir, 'TestData.txt')

        with open(fileName, 'r', encoding='utf-8') as file:
            lines = file.readlines()

            for line in lines:
                # 去除换行符并按照 | 分隔属性
                data = line.strip().split('|')
                productList.append(tuple(data))

        return productList

    except:
        print("发生错误")
        return []
