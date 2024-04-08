import pandas as pd

f1 = pd.read_excel("../info.xlsx")
df1 = f1.head(3)
df2 = f1.tail(3)
f = pd.ExcelWriter("2_1.xlsx")
df1.to_excel(f,sheet_name="df1")
df2.to_excel(f,sheet_name="df2")
f.close()


# import pandas as pd

# df=pd.read_excel("../info.xlsx")
# df1=df.head(2)

# df2=df.tail(2)
# #打开 new.xlsx 文件
# work=pd.ExcelWriter('new.xlsx')
# #将 df1 导出到 new.xlsx 文件的 df1 sheet 页中
# df1.to_excel(work,sheet_name='df1')
# df2.to_excel(work,sheet_name='df2')
# work.close() 