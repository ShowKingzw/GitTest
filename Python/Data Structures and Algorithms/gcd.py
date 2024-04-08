# 欧几里得算法：求两个数的最大公约数

def gcd(a,b):
# *************begin************#
    if a<b:
        t=a
        a=b
        b=t
    while a%b!=0:
        temp=a%b
        a=b
        b=temp
    return b

# **************end*************#
a = int(input())
b = int(input())
r = gcd(a,b)
print(r)
