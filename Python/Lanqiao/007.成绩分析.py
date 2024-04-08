def GetMax(alist):
    return sorted(alist)[-1]


def GetMin(alist):
    return sorted(alist)[0]


def GetAvg(alist):
    avg = sum(alist)/len(alist)
    return "{:.2f}".format(avg)

person = int(input())
nums = []

for i in range(person):
    a = int(input())
    nums.append(a)
    
print(GetMax(nums))
print(GetMin(nums))
print(GetAvg(nums))
