import pandas as pd

def top(df):
    return df.sort_values(by="销售量")

df = pd.read_excel("new.xlsx")
df = df.groupby("类别").apply(top)
print(df)

df.to_excel("2_4.xlsx")
