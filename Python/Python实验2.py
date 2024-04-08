# 准备数据结构
studentid = {}  # 创建字典 序号
studentscore = {}  # 创建字典 分数
course = set()  # 创建集合 课程
# 读入数据
while True:
    line = input()
    if line == 'END':  # 结束标志
        break
    words = line.split()  # 以空格分隔输入行

    if words[-1].isnumeric():  # 最后的字符串是数字，表示成绩

        # if len(words[0]) != 11:
        #     print("请输入11位学号！")

            score = studentscore.get(words[0]) 
            if score == None:  # 该学生还没有成绩
                score = {}
            score[words[1]] = words[2]  # 记下成绩
            studentscore[words[0]] = score  # 更新学生的数据
            course.add(words[1])  # 更新课程集合
    else:  # 否则是学号，姓名关系
        studentid[words[0]] = words[1]
# 列出全部课程
coursename = list(course)
# 打印表头
print("学号"+",姓名", end='')
for name in coursename:
    print(','+name, end='')
print(",平均分")
for id in studentid.keys():
    print(id+','+studentid[id], end='')
    score = studentscore[id]
    sum = 0  # 总分
    cnt = 0  # 课程数
    for name in coursename:  # 遍历全部课程
        print(',', end='')
        if name in score:  # 如果该生有这门课的成绩
            print(score[name], end='')
            sum += int(score[name])  # 加入总分
            cnt += 1  # 课程数+1
        print(','+str(int(sum/cnt)))  # 输出平均分
