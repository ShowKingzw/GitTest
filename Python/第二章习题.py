# 第1题
n = int(input("请输入一个正整数："))  # 声明一个变量n，
print(sum(list(range(1, n+1))))  # 给出1到n的范围，传入到列表中，并求各项和，输出和的结果


# 第2题
x = float(input("请输入一个实数："))  # 声明一个浮点数x
if x != 0:  # 若x不等于0，则执行以下代码
    x = 1/x
    print("f(x)=", "{0:.1f}".format(x))  # 结果格式化
else:  # 否则执行以下代码
    print("f(x)=", x)


# 第3题
electricity = float(input("请输入用电量："))  # 声明浮点数变量electricity存储用电量
if electricity >= 0:  # 若大于0，则继续
    if electricity <= 50:  # 若小于等于50，按[0,50]的区间进行计算
        print("cost=", format(0.53*electricity, ".2f"))  # 格式化结果，保留两位小数
    else:  # 大于50则继续
        print("cost=", format(50*electricity+(electricity-50) *(0.53+0.05), '.2f'))  # 格式化结果，保留两位小数
else:  # 小于0则提示是无效值
    print("Invalid Value!")


# 第4题
a = int(input("请输入数字a："))
n = int(input("请输入几个数相加："))
s = 0
for i in range(1, n+1):
    temp = 0
    for j in range(i):
        temp = temp+10**j
    s = s+(a*temp)
print(s)


# 第5题
num_list = [int(i)
            for i in input("请输入一系列正整数并用空格隔开：").split()]  # 创建一个列表，并转换存储所输入的数
sum = 0  # 创建初始值
for i in num_list:  # 开始判断每一个数是否为奇数
    if i % 2 == 1:
        sum = sum+i
print("所有奇数的和是", sum)


# 第6题
n = int(input("请输入一个正整数:")) # 输入n
sum = 0 # 创建初始值
for i in range(1, n+1): # 遍历列出的n项
    if i % 2 == 1: #奇数项
        sum = sum+i/(i*2-1)
    else: # 偶数项
        sum = sum-i/(i*2-1)
print("前n项之和是", format(sum, ".3f")) # 格式化结果三位小数

