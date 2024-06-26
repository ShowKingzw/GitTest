''' 运用plot 函数绘制一个余弦函数曲线'''


from matplotlib import pyplot as plt
import numpy as np
import math

x = np.arange(0, math.pi*2, 0.05)
y = np.sin(x)
plt.plot(x, y)
plt.xlabel("angle")
plt.ylabel("sine")
plt.title("sine curve")
plt.show()
