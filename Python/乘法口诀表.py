# 乘法口诀表
# /t 制表符对齐
line = 1
for j in range(1, 10):
    for i in range(1, line+1):
        print("{0}x{1}={2}\t".format(i, line, i*line), end="")
    print()
    line += 1

