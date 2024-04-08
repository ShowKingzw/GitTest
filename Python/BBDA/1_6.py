'''给定某只股票从2021年12月31日到2022年1月11日的收盘价格，
形式如下所示，请利用Python的折线图和散点图组合图形式进行数据
的绘制。
data=[12.23,12.59,12.36,12.47,12.85,12.79,12.76]
date=['12/31/2021','04/01/2022','05/01/2022','06/01/2022','07/01/202
2','10/01/2022','11/01/2022']
'''


import matplotlib.pyplot as plt
data = [12.23, 12.59, 12.36, 12.47, 12.85, 12.79, 12.76]
date = [' 12/31/2021','04/01/2022', '05/01/2022',
        '06/01/2022', '07/01/2022',
        '10/01/2022', '11/ 01/2022']
plt.figure(figsize=(7, 4))
plt.plot(date, data, 'b', label='stock xxxxxx')
plt.plot(date, data, 'ro')
plt. grid(True)
plt. legend(loc=0)
plt.xlabel('日期')
plt.ylabel('收盘价')
plt.title('close price of stock xxxxxx')
plt.savefig('1_6', dpi=600) # dpi 600
plt.show()
