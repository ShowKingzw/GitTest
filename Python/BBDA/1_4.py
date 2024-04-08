"""读取数据集，添加了一个小费百分比的列tip_pct，按‘smoke’
分组并运用apply（）函数选出最高的5个tip_pct值，为防止分组键
跟原始对象的索引共同构成结果对象中的层次化索引，需要设置禁止
分组键。"""


import pandas as pd


file = pd.read_csv("..\info.csv", encoding="gbk")
file["tip_pct"] = file["销售量"] / file["库存量"]
# file[:5]
# print(file[:9],type(file))


def top(file, n=8, columns="tip_pct"):
    return file.sort_values(by=columns)[-n:]


file.groupby("商品名称", group_keys=False).apply(top)
