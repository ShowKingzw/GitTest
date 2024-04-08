"""导入（爬取）网络数据，编写一个简易爬虫程序，爬取中商情报
网中 A 股公司营业收入排行榜表格来获取相应的金融数据，网址为
https://s.askci.com/stock/a/"""


import pandas as pd
url = "https://s.askci.com/stock/a/"

df = pd.read_html(url)[0]
print(df)
