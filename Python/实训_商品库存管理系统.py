import pandas as pd


def p_menu():  # 一级界面呼出菜单
    print("|             【1】录入商品信息              |")
    print("|             【2】增加商品库存              |")
    print("|             【3】删除商品信息              |")
    print("|             【4】显示所有商品              |")
    print("|             【5】商品销量排序              |")  
    print("|          【6】查询库存小于5的商品          |")
    print("|             【0】显示使用帮助              |")


def in_error():
    print("输入错误，请重新输入！")


def in_demo_1():
    print("示例>>>001/矿泉水/30/50")
    print("其中“001是商品编号，“矿泉水”是商品名称，“30”是库存量，“50”是销售量")
    print("每一行只能输入一个商品信息，完成后按下回车键，在下一行继续重复上述步骤")
    print("在新的一行输入【END】,按下回车，退出当前功能，返回上级菜单")


def in_demo_2():
    print("示例>>>001/50")
    print("其中“001”是编号，“50”是增加的库存量")
    print("每一行只能输入一个商品信息，完成后按下回车键，在下一行继续重复上述步骤")
    print("在新的一行输入【END】,按下回车，退出当前功能，返回上级菜单")


def in_demo_3():
    print("示例>>>001/50")
    print("其中“001”是编号，“50”是增加的库存量")
    print("每一行只能输入一个商品信息，完成后按下回车键，在下一行继续重复上述步骤")
    print("在新的一行输入【END】,按下回车，退出当前功能，返回上级菜单")



print("+——————————————商品库存管理系统——————————————+")

info = {}  # 字典用于存储信息


while True:
    # 主菜单
    p_menu()
    in_menu = input("输入功能指令\n>>>")
    if in_menu == "END":  # 退出整个程序
        break

    if in_menu == "1":  # 添加商品
        print("每行输入商品编号、名称、库存量、销售量，并用“/”隔开，“End”完成")
        while True:
            in_new = input(">>>")
            line = in_new.split('/')
            if in_new == "END":  # 退出当前功能
                break
            elif in_new == "0":  # 实时显示帮助
                in_demo_1()

            # 判断输入的编号是否存在
            if info.get(line[0]) != None:
                print("该商品已存在，请重新输入！")
                continue

            # 判断是否都输入商品的4项信息，否则报错重输
            if len(line) == 4:

                # 提取输入的后三个组成列表，并作为以编号为键的字典的值
                info[str(line[0])] = [line[1], int(line[2]), int(line[3])]

            else:
                in_error()
                continue

    elif in_menu == "2":  # 增加库存
        print("每行输入商品编号、添加的数量，并用“/”隔开，“END”完成")
        while True:
            # 输入要添加库存的商品编号
            in_add = input(">>>")
            if in_add == "END":  # 退出当前功能
                break
            elif in_add == "0":  # 实时显示帮助
                in_add()

            line = in_add.split("/")
            temp = info.get(str(line[0]))  # 按输入编号找到对应的值，即一个列表
            temp[1] += int(line[1])  # 原库存量加上所输入的新增数量
            info[str(line[0])] = temp  # 修改好的列表按刚才存入原字典进行替换

    elif in_menu == "3":  # 删除商品
        print("输入商品编号")
        while True:
            in_del = input(">>>")
            if in_del == "END":  # 退出当前功能
                break
            del info[str(in_del)]  # 删除该字典键值对

    elif in_menu == "4":   # 显示所有商品信息
        print("商品编号,商品名称,库存量,销售量")
        id = list(info.keys())  # 获取字典所有的键到id列表
        list_content = list(info.values())  # 获取字典所有的值到列表
        sname = []
        kcl = []
        xsl = []

        # 显示准备
        for i in list_content:
            sname.append(i[0])  # 所有的商品名依添加顺序添加到此列表
            kcl.append(i[1])  # 所有商品库存量添加到此列表
            xsl.append(i[2])  # 所有商品销售量添加到此列表

        # 显示
        for i in range(len(id)):  # 从第1条信息开始到最后  遍历
            print(id[i], end=',')  # 显示id，同行输入
            print(sname[i], end=',')  # 显示商品名，同行输入
            print(str(kcl[i]), end=",")  # 显示库存量，同行输入
            print(str(xsl[i]))  # 显示销售量

    elif in_menu == "5":  # 按销售量排序
        sort_t_values = list(info.values())  # info的所有值
        sort_xsl = []  # 所有销售量
        for i in sort_t_values:  # 从每一个字典值中提取销售量到列表
            sort_xsl.append(i[-1])
        sorted_xsl = sorted(sort_xsl, reverse=True)  # 对所有销售量降序排列
        sorted_id = []  # 已按销售量排序的商品id
        for j in sorted_xsl:
            sort_index = [sort_xsl.index(j)]
            if len(sort_index) == 1:
                sorted_id.append(list(info.keys())[sort_index[0]])

        # 输出显示
        print("商品编号,商品名称,库存量,销售量")
        for k in sorted_id:
            print(k, end="")
            for l in info[str(k)]:
                print(",", end="")
                print(l, end="")
            print()

    elif in_menu == "6":  # 查询库存小于5的商品
        print("商品编号,商品名称,库存量,销售量")
        tless5 = []
        for i in info:
            if info.get(i)[1] < 5:
                tless5.append(i)
                print(i, end="")
                for j in info.get(i):
                    print(","+str(j), end="")
                print()
        if len(tless5) == 0:
            print("暂无库存量小于5的商品！")

    elif in_menu == "0":
        in_help = input("请先输入相应功能的代码:")
        if in_help == "1":
            in_demo_1()
        elif in_help == "2":
            in_demo_2()
        elif in_help == "3":
            in_demo_3()

    else:  # 处理一级界面错误输入
        in_error()
        continue

    # csv文件处理模块
    spinfo = []
    namecsv = ["商品编号", "商品名称", "库存量", "销售量"]
    for i in info:
        tlist = [i]+list(info.get(i))
        spinfo.append(tlist)
    indexcsv = [str(i) for i in range(1, len(spinfo)+1)]
    infocsv = pd.DataFrame(
        columns=namecsv, index=indexcsv, data=spinfo)
    infocsv.to_csv("info.csv", encoding="gbk")
    print("数据已保存至csv文件\"info.csv\"!")

    print("\n")
