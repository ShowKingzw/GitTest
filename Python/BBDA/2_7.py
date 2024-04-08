'''身高与体重的一元线性回归分析，首先构建回归模型，训练模型
并将预测身高为1.67米的体重（使用 scikitlearn.linear_model
的 LinearRegression 模型，训练模型并进行预测）；使用测试数据
对该回归模型进行预测，将预测值与真实值对比计算误差并可视化展
示，最后评估模型对真实数据的拟合程度（线性回归决定系数R方）
训练数据:
X = [[0.86], [0.96], [1.12], [1.35], [1.55], [1.63], [1.71],
[1.78]]
y = [[12], [15], [20], [35], [48], [51], [59], [66]]
测试数据：
X_test = [[0.75], [1.08], [1.26], [1.51], [1.6], [1.85]]
y_test = [[10], [17], [27], [41], [50], [75]]
结果示例'''


import numpy as np
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression
# 输入训练数据
X = [[0.86], [0.96], [1.12], [1.35], [1.55], [1.63], [1.71], [1.78]]
y = [[12], [15], [20], [35], [48], [51], [59], [66]]
# 创建回归模型
model = LinearRegression()
# 将训练数据 X,y 放入模型，进行模型训练
model.fit(X, y)
# 预测
print(' 预 测 身 高 为 1.67 米 的 体 重 是 ： %2.f 公 斤 ' %
model.predict(np.array([1.67]).reshape(-1, 1)))
# 测试
# 使用测试数据对该模型进行预测
X2 = [[0.75], [1.08], [1.26], [1.51], [1.6], [1.85]]
# 调用函数 predict
y2 = model.predict(X2)
# 画图
# 画训练数据 X,y
plt.plot(X, y, 'ob')
# 画测试数据 X2,y2
plt.plot(X2, y2, 'g-')
# 残差预测值
yr = model.predict(X)
for idx, x in enumerate(X):
    plt.plot([x, x], [y[idx], yr[idx]], 'r-')
plt.show()
# 确定系数 R 方，表示模型对真实数据的拟合程度，越高，说明回归模型越好
X_test = [[0.75], [1.08], [1.26], [1.51], [1.6], [1.85]]
y_test = [[10], [17], [27], [41], [50], [75]]
r2 = model.score(X_test, y_test)
print('系数 R^2=%.2f' % r2)
