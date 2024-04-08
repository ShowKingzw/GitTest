from Function import *
from Connect import *

if __name__ == "__main__":
    conn = Conn() # 连接数据库

fileName ="TestData.txt"
ProductInfoList = ReadProductInfoFile(fileName) # 读取实例数据

for i in ProductInfoList:  # 对多条记录执行插入
    InsertProductInfo(conn,i[0], i[1], i[2], i[3], i[4], i[5], i[6], i[7], i[8])

# 断开连接
conn.close()
print("插入完成！")