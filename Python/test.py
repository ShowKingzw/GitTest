# # 创建一个计算成绩的程序

# name = input("请输入姓名：")
# chinese = float(input("请输入语文成绩："))
# math = float(input("请输入数学成绩："))
# english = float(input("请输入英语成绩："))
# print(name, "同学，你的总分是", chinese+math+english,
#       "，你的平均分是", (chinese+math+english)/3)
# print("%s同学，你的总分是%f,平均分是%f" %
#       (name, chinese+math+english, (chinese+math+english)/3))

# a=2
# a*=9
# print(a)


# a = 1+5J
# print(type(a))
# x = True
# y = False
# z = False
# print(x or y and z)

# a,n=input().split()
# bb=0
# for i in range(1,int(n)+1):
#     bb = bb+int(a*i)
# print(bb)

# a = range(5)
# print(a)
# s="abd"
# print(format(s,">5d"))
# a="812"
# print(
#     "awdawd"+a
# )

# num_list = [int(i)
#             for i in input("请输入一系列正整数并用空格隔开：").split()]  # 创建一个列表，并转换存储所输入的数
# sum = 0  # 创建初始值
# for i in num_list:  # 开始判断每一个数是否为奇数
#     if i % 2 == 1:
#         sum = sum+i
# print("所有奇数的和是", sum)

# a=[]
# print(type(len(a)))
# a=2
# b="test"
# c=str(a)+b
# d="1111"
# e=a+int(d)
# #How to print multiply values
# print ("c is %s,e is %i" % (c,e))

# num=int(input())
# list_temp = []
# temp = 1
# while temp < num:
#         if num % temp == 0:
#             list_temp.append(temp)
#             temp=temp+1
#         else:
#             temp=temp+1
# a = sum(list_temp)
# if a == num:
#     print(list_temp)
# else:
#     print("no")

# a=1
# a+=1
# print(a)

# x=2;y=2.0
# if(x==y):
#     print('a')
# else:
#     print('b')

# print(317%11)
# a='100'
# b=list(a)
# lista=[int(i) for i in b]
# print(lista)

# a=[1,2,3,4,5,6]
# b=[1,2,3,4,5,6]
# print(a[2]*b[2])

# a=['1','X']
# a[1]='10'
# print(a)

# line = input()
# words = line.split()
# print(type(words))
# print(words)
# a={}
# score = a.get(words[0])
# print(type(score))
# print(score)

# a=input()
# b = a.split()

# print(len(b[0]))
# if len(b[0])!=11:
#     print('no')

# a,b=map(int,input("dddd\n").split())
# print(a,b,type(a),type(b))

# a = 1
# b = 3
# if a == 1 and (b == 2 or b == 4):
#     print("yes")
# else:
#     print('no')

# a = {'001': ['00A', 10, 3], '002': ['00B', 15, 4]}


# print(a)
# va = list(a.values())

# print(va)
# l1 = []
# l2 = []
# l3 = []
# for i in va:
#     l1.append(i[0])
#     l2.append(i[1])
#     l3.append(i[2])
# print(l1, l2, l3)

# print(len(a))
# print(id)
# print(a['001'])

# in_new = input()
# line = in_new.split('/')
# print(type(line[0]))
# a[str(line[0])] = [line[1],int(line[2]),int(line[3])]
# print(a)

# def a(l):
#     b = int(l)+1.0
#     return l


# l = input()
# print(a(l))
# print(type(a(l)))
# print("a",end=",")
# print("b")

# test = open("test.txt","rt",encoding="utf-8")
# htm = test.readlines()
# print(htm)
# test.close()

# import pandas as pd
# b = ["1","5","6"]
# a = [str(i) for i in (range(1,len(b)+1))]
# # print(a,type(a),type(b))
# m = [[1,2,3],[4,5,6],[7,8,9]]
# i = ["1","2","3"]

# test=pd.DataFrame(columns=b,index=a,data=m)
# test.to_csv("test.csv",encoding="utf-8")

# info = {"1":[12,5],"2":[3,56],"3":[55,84]}
# for i in info["1"]:
#     print(i)

# for i in info:
#     if info.get(i)[0] > 10:
#         # print(i)
#         print(i,end="")
#         for j in info.get(i):
#             print(","+str(j),end="")
#         print()

# a = list(info.values())
# print(a)

# for i in info:
#     t = list(info.get(i))
#     print(t,type(t))

# a=['a','b']
# b=['c','d']
# a = a+list("a")
# print(a)

# for i in info:
#     a=[i]+list(info.get(i))
#     print(a)


# a = [10, 51, 6, 94, 64, 2, 51, 65, 48, 6, 2, 4]
# b = sorted(a,reverse=True)
# c = 2
# for j in b:
#     d = [a.index(j)]
#     print(d)

# a=list()
# b = []
# print(a,type(a),b , type(b))
# a = "123456"
# b = "1234 "
# for i in b:
#     print(a.find(i))

# import plotly as py
# from plotly import figure_factory as ff
# import pandas as pd

# pyplt = py.offline.plot
# df = pd.DataFrame([[12, 21], [34, 33]], columns=["num", "data"])
# res = ff.create_table(df)
# pyplt(res, show_link=False)

# import pandas as pd

# df = pd.read_excel("info.xlsx", sheet_name=0)
# print(df)


# in_str = input()
# print("year:%s\ndepartment:%s\nclass:%s" % (
#     in_str[:4], in_str[4:6], in_str[6:8]))
# import time
# a = time.time()
# def yinshu(num):
#     yinshu = []
#     for i in range(1, num):
#         if num % i == 0:
#             yinshu.append(i)
#     return max(yinshu)
# b = time.time()
# print(yinshu(900000000),b-a)

# def gcd(a, b):
#     # *************begin************#
#     if a < b:
#         t = a
#         a = b
#         b = t
#     while a % b != 0:
#         temp = a % b
#         a = b
#         b = temp
#     return b

# # **************end*************#


# t = int(input(">>>"))
# nums = []
# for i in range(t):
#     nums.append(list(map(int, input(">>>").split())))

# for i in nums:
#     print(gcd(i[0], i[1]))


# def f(nums):
#     cha = nums[1]-nums[0]
#     res = True
#     for i in range(1,len(nums)):
#         if (nums[i]-nums[i-1])!=cha:
#             res = False
#             return res
#     return res
# nums = []
# n= int(input(">>>"))

# for i in range(n):
#     num = input(">>>")
#     nums.append(int(num))

# print(f(nums))

# a = ["1","2"]
# b = ["1","3","2"]

# a = " 10"
# b = "25"
# print(float(a+"."+b))

# a,b = map(int,input("输入两个数字，用空格个隔开").split())
# print(a,b,type(a),type(b))


# # 乘法口诀表
#
# line=1
# for j in range(1,10):
#     for i in range(1,line+1):
#         print("{0}x{1}={2}".format(i,line,i*line),end="   ")
#     print()
#     line+=1

# import pie
#
# pie.Map()


# count = int(input())
# line = input().split(" ")
# #nums = []
# no = 0
# while no>-count:
#     print(line[no-1],end=" ")
#     no-=1

# # 读取输入
# n = int(input())
# nums = list(map(int, input().split()))

# # 将数组逆序
# nums.reverse()

# # 输出结果
# print(" ".join(map(str, nums)))




# from PIL import Image
# import argparse

# # 命令行输入参数处理
# parser = argparse.ArgumentParser()

# # 输入文件， 输出文件， 输出字符画宽， 输出字符画高
# parser.add_argument('file')
# parser.add_argument('-o', '--output')
# parser.add_argument('--width', type=int, default=150)
# parser.add_argument('--height', type=int, default=80)

# # 获取参数
# args = parser.parse_args()

# IMG = args.file
# WIDTH = args.width
# HEIGHT = args.height
# OUTPUT = args.output

# ascii_char = list("$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,\"^`'. ")


# # 将256灰度映射到70个字符上
# def get_char(r, g, b, alpha=256):
#     if alpha == 0:
#         return ' '
#     length = len(ascii_char)
#     gray = int(0.2126 * r + 0.7152 * g + 0.0722 * b)

#     unit = (256.0 + 1)/length
#     return ascii_char[int(gray/unit)]


# if __name__ == "__main__":
#     im = Image.open(IMG)
#     im = im.resize((WIDTH, HEIGHT), Image.NEAREST)

#     txt = ''

#     for i in range(HEIGHT):
#         for j in range(WIDTH):
#             txt += get_char(*im.getpixel((j,i)))
#         txt += '\n'

#     print(txt)

#     # 字符画输出到文件
#     if OUTPUT:
#         with open(OUTPUT, 'w') as f:
#             f.write(txt)
#     else:
#         with open('output.txt', 'w') as f:
#             f.write(txt)





# from PIL import Image
# import argparse

# # 命令行输入参数处理
# parser = argparse.ArgumentParser()

# # 输入文件， 输出文件， 输出字符画宽， 输出字符画高
# parser.add_argument('file')
# parser.add_argument('-o', '--output')
# parser.add_argument('--width', type=int, default=150)
# parser.add_argument('--height', type=int, default=80)

# # 获取参数
# args = parser.parse_args()

# IMG = args.file
# WIDTH = args.width
# HEIGHT = args.height
# OUTPUT = args.output

# ascii_char = list("$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,\"^`'. ")


# # 将256灰度映射到70个字符上
# def get_char(r, g, b, alpha=256):
#     if alpha == 0:
#         return ' '
#     length = len(ascii_char)
#     gray = int(0.2126 * r + 0.7152 * g + 0.0722 * b)

#     unit = (256.0 + 1)/length
#     return ascii_char[int(gray/unit)]


# if __name__ == "__main__":
#     print("Opening image...")
#     im = Image.open(IMG)
#     print("Resizing image...")
#     im = im.resize((WIDTH, HEIGHT), Image.NEAREST)

#     txt = ''

#     print("Converting image to ASCII...")

#     for i in range(HEIGHT):
#         for j in range(WIDTH):
#             txt += get_char(*im.getpixel((j,i)))
#         txt += '\n'

#     print(txt)

#     print("Saving ASCII art...")

#     # 字符画输出到文件
#     if OUTPUT:
#         with open(OUTPUT, 'w') as f:
#             f.write(txt)
#     else:
#         with open('output.txt', 'w') as f:
#             f.write(txt)

#     print("Done!")
# print(4)
# print()
# print()



def b_and(num1,num2):
  res = bin(num1) & bin(num2)
  return bin(res)


def f(num):
  string = str(num)
  count = 0
  for i in string:
    if i =="1":
      count+=1
  return count

res = 0
a_size = int(input())
a = list(map(int,input().split(" ")))

for i in range(1,a_size+1):
  for j in range(i+1,a_size+1):
    count = f(b_and(a[i],a[j]))
    res +=count
print(res)
