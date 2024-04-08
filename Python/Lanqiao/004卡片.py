'''
小蓝有很多数字卡片，每张卡片上都是数字 00 到 99。

小蓝准备用这些卡片来拼一些数，他想从 11 开始拼出正整数，每拼一个，就保存起来，卡片就不能用来拼其它数了。

小蓝想知道自己能从 11 拼到多少。

例如，当小蓝有 3030 张卡片，其中 00 到 99 各 33 张，则小蓝可以拼出 11 到 1010，

但是拼 1111 时卡片 11 已经只有一张了，不够拼出 1111。

现在小蓝手里有 00 到 99 的卡片各 20212021 张，共 2021020210 张，请问小蓝可以从 11 拼到多少？

'''

# nums = 2021*[str(num) for num in range(10)]
# print(len(nums))
# cardNum = 0
# while len(nums) != 0:
#     for i in range(1, 20210):
#         temp = False
#         templist = []
#         for j in str(i):
#             if j in nums:
#                 templist.append(j)
#                 nums.remove(j)
#             else:
#                 temp = True
#                 if templist != []:
#                     nums = nums + templist
#                 break
#         if temp == False:
#             cardNum += 1
# print(cardNum)

# cardNum = 0
# nums = [
#     [0, 2021],
#     [1, 2021],
#     [2, 2021],
#     [3, 2021],
#     [4, 2021],
#     [5, 2021],
#     [6, 2021],
#     [7, 2021],
#     [8, 2021],
#     [9, 2021]
# ]
# for i in range(1, 20210):
#     temp = True
#     for j in str(i):
#         if nums[int(j)][1] < 1:
#             temp = False
#     if temp == True:
#         cardNum += 1
#         for k in str(i):
#             nums[int(k)][1] -= 1
# print(cardNum)

cnt = 0
for i in range(1, 10001):
    cnt += str(i).count("1")
    # 1也有2021张
    if cnt > 3:
        break
print(i - 1)
