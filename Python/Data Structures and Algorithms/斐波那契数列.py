# 斐波那契数列
# 1 1 2 3 5 8 13 21......
# n 为下标，并从0开始
# 返回下标为n的相应的数

def fib(n):
    if n == 0 or n == 1:
        return 1
    else:
        return fib(n-1)+fib(n-2)

print(fib(4))