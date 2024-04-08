# 第3题
print("1000以内的所有完数：",end='')
for num in range(1, 1001):
    list_temp = []  
    temp = 1
    # 计算因数
    while temp < num:
        if num % temp == 0:
            list_temp.append(temp) # 把所有因子加入到列表
        temp += 1
    if sum(list_temp) == num: # 判断除数本身外的其他因子之和是否等于它本身
        print(num, end=' ')

#############################################################

# 第4题
list_num = [] # 符合条件数的列表
for num in range(100,1001):
    list_temp = [] # 因数列表
    temp = 1
    # 求因数
    while temp <= num:
        if num % temp == 0:
            list_temp.append(temp) # 把因数添加到因数列表
        temp += 1
    # 判断是否只有两个因数
    if len(list_temp) == 2:
        list_num.append(num) # 加入到符合条件数的列表
print("100到1000范围内所有素数之和：%d"%(sum(list_num))) 
