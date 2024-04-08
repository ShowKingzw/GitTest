import numpy as np
import math

h1 = 1.215
h2 = 0.852
h3 = 0.235
h4 = -2.311
h5 = 0.150
h6 = -1.062
h7 = -1.931
h8 = -2.166
ha = 10.210
hb = 12.283

# 间接平差的函数模型  V = B x - l
martixB = np.array([[1, 0, 0], [-1, 0, 0], [0, 0, 1], [0, 0, -1],
                   [0, 1, 0], [-1, 1, 0], [0, 1, 0], [0, 1, -1]])  # 系数矩阵B

martixl = np.array([
    [0],
    [-ha-h1+hb-h2],
    [0],
    [-hb-h3+ha-h4],
    [0],
    [ha-h5-ha-h1-h6],
    [ha+h5-hb-h7],
    [ha+h5-hb-h3-h8]
])

# 权阵
martixP = np.eye(8)  # 权阵为单位阵，即协因数阵

martixNbb = np.dot(np.dot(np.transpose(martixB), martixP), martixB)

martixW = np.dot(np.dot(np.transpose(martixB), martixP), martixl)

martixx = np.dot(np.linalg.inv(martixNbb), martixW)

martixV = np.dot(martixB, martixx) - martixl

vc = martixV[0][0]
vd = martixV[2][0]
ve = martixV[4][0]

print("待定点C的平差高程为{:.3f}米".format(ha+h1+vc))
print("待定点D的平差高程为{:.3f}米".format(ha+h5+vd))
print("待定点E的平差高程为{:.3f}米".format(hb+h3+ve))
