while True:
    l = input("输入一个数判断是否为素数；\n输入两个数用空格隔开，计算两数区间内的所有是素数之和\n")
    num = l.split()
    if len(num) == 1:
        p = int(num[0])

        def prime(p):
            for i in range(1, p+1):
                list_temp = []  # 因数列表
                temp = 1
                # 求因数
                while temp <= i:
                    if i % temp == 0:
                        list_temp.append(temp)  # 把因数添加到因数列表
                    temp += 1
            # 判断是否只有两个因数
            if len(list_temp) == 2:
                print("True")
            else:
                print("False")
        prime(p)

    elif len(num) == 2:
        m, n = int(num[0]), int(num[1])

        def primeSum(m, n):
            list_num = []  # 符合条件数的列表
            for i in range(m, n+1):
                list_temp = []  # 因数列表
                temp = 1
                # 求因数
                while temp <= i:
                    if i % temp == 0:
                        list_temp.append(temp)  # 把因数添加到因数列表
                    temp += 1
                # 判断是否只有两个因数
                if len(list_temp) == 2:
                    list_num.append(i)  # 加入到符合条件数的列表
            print("%d到%d范围内所有素数之和：%d" % (m, n, sum(list_num)))
        primeSum(m, n)
    else:
        print("请按要求正确输入！")
