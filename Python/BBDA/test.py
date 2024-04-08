# import pandas as pd

# df = pd.read_excel("..\info.xlsx")

# print(df)

# import pandas as pd


# f1=pd.read_excel("sales.xlsx",nrows=10)
# f2=pd.read_excel("sales.xlsx",nrows="[-5:]")
# f = pd.to_excel(f1,sheet_name="df1")

# import numpy as np
# arr1=np.arange(1,2,0.2)
# print(arr1.dtype)
# import numpy as np
# arr=np.array([[1,2,3],[4,5,6]])
# print(arr[0,1]) # [行,列]

import pandas as pd
data_list = [[1,2,3],[1,5,4],[3,7,9],[6,8,5]]
df = pd.DataFrame(data_list,columns=['C','B','D'])
df.index = ['X','Z','Y','V']
print(df)
df_sort_axis0 = df.sort_index()
print('data after sort_index:')
print(df_sort_axis0)
df_sort_axis1 = df.sort_index(axis=1)
print('data after sort_index(axis = 1):')
print(df_sort_axis1)
df_data_order0 = df.sort_values(by=['D'],ascending=[True]) 
                                    # ascending=[True]默认
print('data after sort_values sorted by D:')
print(df_data_order0)
