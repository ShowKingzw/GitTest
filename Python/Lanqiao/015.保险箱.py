'''
2023蓝桥杯真题
'''


def getStep(x, y):
    global intx, wei,cnt
    if 5 >= x-y > 0:
        intx[wei] = intx[wei]-(x-y)-10
        cnt += abs(x-y)
        # return intx[wei]
        # return x-y
    elif 5 < x-y <= 9:
        intx[wei+1] += 1
        intx[wei] = intx[wei]-(x-(y+10))-10
        cnt += abs(x-(y+10))
        # return x-(y+10)
    elif -5 < x-y < 0:
        intx[wei+1] -= 1
        intx[wei] = intx[wei]-(x+10-y)+10
        cnt += abs(x+10-y)
        # return x+10-y
    elif -9 <= x-y <= -5:
        intx[wei+1] -= 1
        intx[wei] = intx[wei]-(x+10-y)+10
        cnt += abs(x+10-y)
        # return x+10-y

    # if -5<x-y<=5:
    #     if x>y:

    #     else:
    #         intx[wei+1]-=1
    #         return x+10-y
    #     # return x-y # -4 -3 -2 -1 1 2 3 4 5
    # else: # -9 -8 -7 -6 -5 6 7 8 9
    #     if x>y:
    #         intx[wei+1]+=1 # 进位
    #         return x-(y+10)
    #     else:
    #         intx[wei+1]-=1 # 借位
    #         return (x+10)-y


n = int(input())
x = int(input())
y = int(input())

intx = [int(i) for i in str(x)]
inty = [int(i) for i in str(y)]
intx.reverse()
inty.reverse()
cnt = 0
wei = 0
while True:
    if intx == inty:
        break
    if wei == n-1:
        intx[-1] = intx[-1] % 10
        if intx[-1]==inty[-1]:
            break
        if intx[-1] != inty[-1]:
            if 5 >= intx[-1]-inty[-1] > 0:
                intx[-1] = intx[-1]-(intx[-1]-inty[-1])
                cnt += (intx[-1]-inty[-1])
            elif 9 >= intx[-1]-inty[-1] > 5:
                intx[-1] = intx[-1]-(intx[-1]-inty[-1]-10)-10
                cnt += (intx[-1]-inty[-1]-10)
            elif -5 < intx[-1]-inty[-1] < 0:
                intx[-1] = intx[-1]-(intx[-1] - inty[-1])
                cnt += (intx[-1] - inty[-1])
            elif -5 >= intx[-1]-inty[-1] >= -9:
                intx[-1] = intx[-1]-(intx[-1]-inty[-1])
                cnt += (intx[-1] - inty[-1])

        intx[-1] = intx[-1] % 10

    else:
        if intx[wei]==inty[wei]:
            cnt=cnt
        step = getStep(intx[wei], inty[wei])  # 处理完毕
        
        wei += 1

        # 对每一位保证一位数处理
        for i in range(1, n):
            if i == n-1:
                intx[-1] = intx[-1] % 10
                break
            if intx[i]//10 >= 1:
                intx[i+1] += intx[i]//10
            intx[i] = intx[i] % 10

print(cnt)