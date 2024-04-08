import pandas as pd


df = pd.DataFrame([[1, 2, 3], [1, 5, 4], [3, 7, 9], [6, 8, 5]],
    index=["X", "Z", "Y", "D"], columns=["C", "B", "D"])
print(df)  # 显示原始数据

print(df.sort_index())  # 按照行索排序，默认行索引
print(df.sort_index(axis=1))  # 按照列索引排序
print(df.sort_values(by="D",axis=1,ascending=True))  
# 根据值某一列或某一行索引，by设置列名或行名，ascending是bool值设置升序