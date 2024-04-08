import pandas as pd


data = pd.DataFrame([[0, 4, -1], [1, 5, -2], [2, 6, -3]],
                    index=["a", "b", "c"],
                    columns=["one", "two", "three"]
                    )

print(data.mean(axis=1))