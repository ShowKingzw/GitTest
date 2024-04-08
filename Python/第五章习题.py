while True:
    list_input = input("输入一个列表，元素间使用空格间隔：")
    list_temp = list_input.split()  # 将输入内容转换成列表
    set_temp = set(list_temp)  # 将列表转换成集合
    if len(set_temp) == len(list_temp):  # 判断元素个数是否相等，不等则重复
        print("False")
    else:
        print("True")
