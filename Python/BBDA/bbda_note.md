# BBDA

## 数据的导入导出

### 导入数据

#### 1、导入Excel表格

`read_excel()`参数如下：

1. `sheet_name`:默认第一页表格，表格的`sheet`
2. `index_col`:指定表格哪一列作为`DataFrame`的索引（可理解表格最左边一列的），从`0`开始
3. `nrows`:控制导入的前行数，对于导入体积大的文件比较有用
4. `skipfooter`:跳过表格底部的若干行
5. `header`:当使用`Pandas`的`read_excel()`时，默认表格第一行为字段名，如果第一段不是字段名，则需要设置，设置为字符串组成的列表
6. `usecols`:控制导入Excel表格的哪些列，参数本质是一个列表，每个元素是导入列的下标，仅导入下标对应列
7. `names`:对导入数据的列名重命名，具体是一个列表，其中1个元素（str）对应1列的列名

#### 2、导入csv格式数据

1. `read_csv()`常用参数如下：
2. `sep`表示要导入的分隔符csv文件一般默认是逗号
3. `encoding`表示编码，一般为`gbk`或`utf-8`
4. `nrows`:控制导入的前行数
5. `usecols`:控制导入Excel表格的哪些列
6. `names`:对导入数据的列名重命名

#### 3、导入JSON数据

JSON在互联网很常见，有时候后台导出来就是JSON文件。其实际存储的是一个JSON数组或JSON对象。JSON对象由多个键值对组成，类似Python字典。JSON数组可由多个JSON对象组成，类似Python列表。 JSON文件的注释:

```json
{
        "json":"data1", //这里是注释
        "JSON":"data2"  //这里是注释
    }
```

`read_json()`用于导入json数据

#### 4、导入txt数据

`read_table()`用于导入txt文件，参数和用法与`read_csv()`类似。

#### 5、导入（爬取）网络数据

爬取表格类数据用的是`pandas`的`read_html()`方法。其导入的是`html`中的`<table></table>`标签。

`read_html()`参数如下：

1. `io`:本质为字符串，可以是文件路径也可以是url链接，网址不接受https，可改为http后再爬取。
2. `header`:指定列表标题所在行
3. `index_col`:指定行标题所在的列

### 输出数据

#### 1、csv格式输出数据输出

`pandas`中的`to_csv()`导出数据，需指定文件名和编码。

常用参数：

1. `path_or_buf`:指定要保存的路径和文件名
2. `sep`:分隔符
3. `columns`:指定要输出的列，用列名列表表示，默认None
4. `header`:是否输出列名，默认True
5. `index`:是否输出索引，默认True
6. `encoding`:默认`utf-8`

#### 2、Excel格式数据输出

`to_excel()`导出 `sheet_name`、`header`与之前的使用方法相同。

1. `index`是bool型，默认`True`，行名
2. `index_label`字符串或序列，默认`None`，文件使用多索引，则要用序列
3. `encoding`默认`None`

导入到多个sheet页：先用`pd.ExcelWriter`打开文件,首先要有sheet页 ，最后`to_Excel()`将数据导入到sheet页中。

## 数据的预处理

### 熟悉数据

#### 1、数据表的基本信息查看

导入数据后，使用`info()`进行查看数据基本信息

#### 2、数据表大小

使用`shape()`查看，`shape[0]`是行数，`shape[1]`是列数，例如：

```python
d = df.shape[0]  # 这是返回行数
w = df.shape[1]  # 这是返回列数  
```

#### 3、数据格式的查看

查看`DataFrame`中的数据类型，是字符串还是数字格式。使用`dtype`和`dtypes`属性，其中`series`数据可用`dtype`属性查看，`DataFrame`数据可用`dtypes`属性查看。例如：

```python
print(df.dtypes)
print(array.dtype) # array是数组
```

#### 4、查看数据分布

查看数据的各元素的个数、均值、方差、最小值、最大值和分位数。使用`describe()`函数进行查看统计量特征。

1. 其返回值用`count`表示
2. `mean`表示数据的平均值
3. `std`表示数据的标准差
4. `min`表示数据的最小值
5. `max`表示数据最大值
6. `25%`，`50%`，`75%`分别表示数据一分位，二分位，三分位数。

### 缺失值处理

#### 1、缺失值检查

对于爬取的csv文件，要检查缺失个数，汇总。使用`isnull()`方法检查，返回值为bool值，缺失则True，否则False。例如：

```python
print(df.isnull())  
print(df.isnull().sum())  # 统计各列缺失个数
```

#### 2、缺失值删除

1. 使用`dropna()`函数进行删除含有缺失值的行,只要有缺失值就会删除当前行，例如：

    ```python
    df.dropna()
    ```

2. 当某行和某列都为`NaN`时，才删除整行或整列的情况，使用`dropna()`的`how`参数。例如：

    ```python
    df.dropna(how='all',axis=0) 
    # 当整行都是NaN,才删除整行
    # axis=0是行，1是列；axis是轴
    ```

    > `NaN` (Not a Number)，非数，一种数据类型。

3. 当某行或某列有一个`NaN`时，就删除整行或整列的情况，设置`how='any'`,行列由`axis`控制。

#### 3、缺失值替换、填充

如均值填补法、近邻填补法、插值填补法等等。

1. 利用均值填补缺失数据`fillna()`函数，以各列值的均值作为参数。例如：

    ```python
    df.fillna(df.mean())
    ```

2. 近邻填补法，`method`参数设置为`bfill`，使用缺失值后面的数据进行填充；当`method`参数设置为`ffill`则利用缺失值前面的值进行填充。例如：

    ```python
    df.fillna(method='bfill') # 后
    df.fillna(method='ffill') # 前
    ```

3. 利用二次多项式插值填充法对item2列的缺失值进行填充。使用`interpolate`方法及将`order`参数设置为`2`。例如：

    ```python
    # 对item2这一列进行二次多项式插值填充，
    # interpolate是插值
    # 方式是polynomial（多项式），
    # order=2是二次
    df["item2"].interpolate(method="polynomial",order=2)
    ```

4. 对item2列进行三次样条插值填充。三次样条插值，即利用一个三次多项式来逼近原目标函数，然后求解该三次多项式的极小值点来作为原目标函数的近似极小点。例如：

    ```python
    # 对item2这一列进行三次样条插值填充，
    # interpolate是插值
    # 方式参数是spline，
    # order=3是三次
    df["item2"].interpolate(method="spline",order=3)
    ```

### 重复值处理

#### 1、发现重复值

利用`duplicated()`方法检验冗余的行或列，默认判断全部列中的值是否为重复，并返回`bool`值，对于完全没有重复的行返回`False`,有重复时，第一次出现为`False`，之后再出现`True`，例如：

```python
df.duplicated()
```

#### 2、删除重复值

利用`drop_duplicates()`方法，去除冗余的数据，默认删除冗余的所有行，默认判断全部列，例如：

```python
df.drop_duplicates()
```

### 异常值的检测与处理

#### 1、检测异常值

1. 利用`pandas`中的`query()`方法查询数据是否有异常值，然后`boxplot()`检测异常值。例如：

    ```python
    df.query("销量<1000") # 返回销量小于1000的项
    ```

2. 利用箱型图检测异常值，例如：

    ```python
    plt.boxplot(df["销量"])
    ```

#### 2、处理异常值

常用方式是删除，将异常值当作缺失值进行处理，以某个值填充；将异常值当作特殊情况分析，研究出现异常的原因。利用`drop()`方法对csv文件中的异常值进行删除。

```python
df.query("销量<1000") # 返回销量小于1000的项
# 查询到出错在行名为3的行
df1 = df.drop(index=3,axis=0) # 行方向，第三行
df1
```

### 数据类型的转换

#### 1、数据类型检查

利用`numpy`库中的`arange()`函数创建一维整数数组，并查看数据类型。使用`arange()`方法创建数组`arr`，然后打印数组的dtype属性查看数组的数据类型。例如：

```python
arr1=np.arange(1,2,0.2)
print(arr1)
print(arr1.dtype)
```

创建一维浮点型数组`arr1`后，将`arr1`转化为整型，利用`astype()`例如：

```python
arr2=arr1.astype(np.int) # 强制转换
```

### 索引设置

`pandas`库中的索引作用有：更方便地查询数据，使用索引提升查询性能。

#### 1、添加索引

创建数据为[1,2,3,4,5]的`Series`，并指定索引标签为['a','b','c','d','e'],使用index方法索引，例如：

```python
s=pd.Series([1,2,3,4,5],index=['a','b','c','d','e'])
```

#### 2、更改索引

使用`set_index()`函数，指定某一字段为索引，例如：

```python
# 指定'日期'这一列为索引
df1.df.set_index("日期")
```

同时还可以再导入csv时设置`index_col`参数重置索引，例如：

```python
df=pd.read_csv("1.csv",sep=",",encoding="gbk",index_col="日期")
```

#### 3、重命名索引

使用`reindex()`方法，例如：

```python
s1=pd.Series([10,52,33,14],index=[1,2,3,4])
s2=s1.reindex([1,2,3,4,5,6]) # 5，6出现了缺失值
```

此时5,6处出现了缺失值，可在`reindex()`中设置`method`参数，其表示重新索引时，选择对缺失数据插值的方法，可设置为`None`,`bfill`(向后填充),`ffill`(向前填充)等。列索引是`columns`,行索引是`index`，二者都可设置为`reindex()`参数。

### 其他

#### 1、大小写转换

`lower()`将大写转换为小写，`upper()`转换为大写

#### 2、数据的修改与替换

1. 按列增加数据

    ```python
    # 方法一：直接对df赋值操作
    df["four"]=[1,2,3] # 列名为four,列数据是1 2 3(三行)

    # 方法二：使用loc属性，向df2最后增加一列
    df2.loc=[:,"four"]=[1,2,3] # 冒号表示所有行

    # 使用insert()在第二列和第三列之间插入列，
    df.insert(2,"four",[1,2,3]) # 2表示插入到的下标是2的列
    ```

2. 按行增加数据
利用`loc()`方法和`append()`方法。
例如：

    ```python
    # 使用loc增加一行数据
    df1.loc['D']=[1,2,3] # 行索引为D

    # 可使用append方法增加多行数据

    # 行索引
    index_ = ["a","b","c"]
    # 列索引
    columns_ = [1,2,3]
    # 数据
    data_ = [[4,5,6],[7,5,1],[6,1,9]]
    df=pd.DataFrame(data=data_,index=index_,columns=columns_)
    df2=df1.append(df)
    ```

    将某一行进行替换可使用`loc`和`iloc`方法，例如：

    ```python
    # 方法一：对原有行的三个数字进行覆盖
    df1.loc['D']=[1,2,3]

    # 方法二：使用iloc方法修改数据第三行
    df.iloc[2,:]=[1,2,3] # 冒号表示所有列
    ```

#### 3、删除数据

1. 按列按列删除数据

    使用`DataFrame`的`drop()`方法，删除某一列。`drop()`参数如下：

    - `labels`表示行标签或列标签；
    - `axis`=0表示按行删除，=1表示按列删除，默认=0；
    - `index`删除行，默认None
    - `columns`删除列，默认None
    - `inplace`可选参数，对原数组做出修改并返回一个新数组。默认False，如果为True，那么原数组直接被替换。

## 数据的选择与运算

### 数据的选择

#### 1、NumPy数据选择

- 基础索引：获取单个元素
- 切片：获取子数组
- 布尔索引：根据比较操作，获取数组元素
- 数组索引：传递索引数组，更加快速、灵活的获取子数据集
NumPy中数组索引的两大类：一维索引和二维索引，一维和列表的索引几乎相同，二维数组的索引则有很大的不同。

NumPy数组的索引和切片的操作总结：

1. `a[m]`选择下标m处的元素，其中m为整数（从0开始计数）
2. `a[-m]`从列表末尾选择第m个元素，其中m是整数。列表中的最后一个元素地址为-1，倒数第二个元素地址为-2，依此类推
3. `a[m:n]`选择索引从m开始，以n-1结束的元素（m和n都是整数）
4. `a[:]` or `a[0:-1]`选择给定轴中的所有元素
5. `a[:n]`选择从索引0开始一直到索引n-1（整数）的元素
6. `a[m]` or `a[m:-1]`选择从下标m（整数）开始一直到数组中最后一个元素
7. `a[m:n:p]`选择索引为m到n的元素，跨度（步长）为p
8. `a[::-1]`将数组所有元素逆置

```python
arr=np.array([[1,2,3],[4,5,6]])
print(arr[0,1]) # [行,列]
```
