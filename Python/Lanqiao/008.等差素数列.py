'''
2,3,5,7,11,13,.... 是素数序列。 类似：7,37,67,97,127,1577,37,67,97,127,157 这样完全由素数组成的等差数列，叫等差素数数列。

上边的数列公差为 30，长度为 6。

2004 年，格林与华人陶哲轩合作证明了：存在任意长度的素数等差数列。 这是数论领域一项惊人的成果！

有这一理论为基础，请你借助手中的计算机，满怀信心地搜索：

长度为 10 的等差素数列，其公差最小值是多少？
'''


def isSushu(num):
    if num <= 1:
        return False
    for i in range(2, num):
        if num % i == 0:
            return False
    return True
# print(isSushu(5))

# while True:
#     # nums =[]
#     startNum = 2
#     step = 1
#     nums = [ i for i in range(startNum,startNum*10,step)]
