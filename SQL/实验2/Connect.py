import pymssql

# 连接数据库的函数，无参数，返回connect
def Conn():
    while True:
        serverName = input("输入服务器地址\n>>>")
        userName = input("输入用户名\n>>>")
        password = input("输入密码\n>>>")
        dbName = input("连接数据库的名称\n>>>")
        # serverName = "127.0.0.1"
        # userName = "sa"
        # password = "88888888"
        # dbName = "实验2"
        # print("正在连接……")
        try:
            connect = pymssql.connect(serverName, userName, password, dbName)
            print("连接成功！")
            break
        except:
            print("连接失败！")
            continue
    return connect

