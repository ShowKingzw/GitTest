# 第1题
# 身高存入列表
list_input = [
    int(height)
    for height in input("请输入身高并用空格分隔：").split()
]
list_height = []
for height in list_input:
    if height > 0:
        list_height.append(height) # 添加有效身高到列表
    else:
        print("这是无法计算的无效身高：", height)
# 计算平均身高
count = len(list_height)
average = sum(list_height)/count
print("这是超过平均身高的身高：", end="")
# 与平均身高进行对比
for height in list_height:
    if height > (sum(list_height)/count):
        print(height, end=" ")

###############################################################

# 第2题
while True:
    idnum = input("请输入身份证号（若有X，请大写）：")

    # 判断是否为18位身份证号
    if len(idnum) != 18:
        print("请输入18位身份证号！")
        continue

    list_id = list(idnum)

    # 若第18位是X，则替换成10
    if list_id[17] == 'X':
        list_id[17] = '10'

    # 转换成整数加入列表
    list_id = [int(num) for num in list_id]

    # 加权求和
    weight = [7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2, ]
    weightsum = 0
    for i in range(17):
        temp = weight[i]*list_id[i]
        weightsum = weightsum + temp

    z = weightsum % 11
    m = [1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, ]

    # 检查校验码是否相等
    if list_id[17] == m[z]:
        print("该身份证效验码有效！")
    else:
        print("该身份证效验码无效！")
