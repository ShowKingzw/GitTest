import pandas as pd


df = pd.read_excel("../excel_test_doc.xlsx")
df1 = df.tail(10)
f = pd.ExcelWriter("4_1_new.xlsx")
df1.to_excel(f, sheet_name="dataframe")
f.close()
