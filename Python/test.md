# 这是一个一级标题:kissing:

## 这是一个二级标题
>这里是引用
```python
# csv文件处理模块
spinfo = []
namecsv = ["商品编号", "商品名称", "库存量", "销售量"]
for i in info:
    tlist = [i]+list(info.get(i))
    spinfo.append(tlist)
indexcsv = [str(i) for i in range(1, len(spinfo)+1)]
infocsv = pd.DataFrame(
    columns=namecsv, index=indexcsv, data=spinfo)
infocsv.to_csv("info.csv", encoding="gbk")
print("数据已保存至csv文件\"info.csv\"!")
```

下面是无需列表`zhehsiyiduandaima`

# Python实践报告
## 计算快递费用需求分析
## 

:blush:
:confused:
:kissing:
