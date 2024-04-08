import numpy as np
import matplotlib.pyplot as plt

x = np.arange(0, 100000, 0.05)
plt.figure()
plt.plot(x, x**2)
plt.show()
