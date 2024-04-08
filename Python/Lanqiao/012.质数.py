'''
我们知道第一个质数是 2、第二个质数是 3、第三个质数是 5……

请你计算第 2019 个质数是多少？
'''


def IsZhishu(num):
    for i in range(2, num):
        if num % i == 0:
            return False
    return True

n = 2
nums = []
while len(nums) < 2019:
    if IsZhishu(n) == True:
        nums.append(n)
    n += 1
print(nums[-1])