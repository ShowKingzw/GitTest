m = int(input("按实验要求输入整数M："))
n = int(input("按实验要求输入整数N："))

if -100 <= m <= n <= 100: # 判断mn是否符合实验要求
    temp = 0 # 创建并初始化用于记数的变量
    sum = 0 # 初始化变量和
    for i in range(m, n+1): # 遍历m到n+1
        temp = temp+1 # 每遍历一次记数加一
        if temp % 5 != 0: # 判断该数是否是每行的第五个数，不是则执行以下
            print("{:>5d}".format(i), end="") #需要下一个数紧接在该数后输出
        else: # 是第五个则执行以下
            print("{:>5d}".format(i))
        sum = sum+i # 计算所有数的和
else:
    print("请按实验要求正确输入！") # 提示错误

print("\nSum =",sum) # 对sum进行换行输出，避免sum紧接最后一个数同行输出的情况
