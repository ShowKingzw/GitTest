from wordcloud import WordCloud
import matplotlib.pyplot as plt  # 绘制图像的模块
import jieba  # jieba分词
import os
path_txt = 'C:\\Users\\Legion\\Documents\\Code\\Python\\all.txt'
f = open(path_txt, 'r', encoding='UTF-8').read()

# jieba中文分词，生成字符串，wordcloud无法直接生成正确的中文词云
cut_text = " ".join(jieba.cut(f))

wordcloud = WordCloud(
    # 设置字体，此处用到了绝对路径
    font_path="C:/Windows/Fonts/msyh.ttc",
    # 设置了背景，宽高
    background_color="white", width=1800, height=1280).generate(cut_text)
plt.imshow(wordcloud, interpolation="bilinear")
plt.axis("off")
plt.show()
