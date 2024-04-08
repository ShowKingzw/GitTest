'''请利用python查看sales.csv文件中的数据表的大小，要求返回数
据表中行的个数和列的个数。'''


import pandas as pd


df1 = pd.read_csv("..\info.csv",sep = ",",encoding = "gbk")

print("数据表格的行数是%d"%df1.shape[0])
print("数据表格的列数是%d"%df1.shape[1])