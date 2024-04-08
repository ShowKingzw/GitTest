def insertionSort(alist):
    # 失败原因：alist总是为初始值,修改列表后，仍不变
    # 上面说的不对，现在成功了！！！！！！！！！！
    for i in range(1, len(alist)):
        for j in alist[:i]:
            # print(alist)
            if alist[i] < j:
                # alist[alist.index(j)] = alist[i]
                a = alist.pop(i)
                b = alist.index(j)
                alist.insert(b, a)
                # alist.pop(alist.index(j))

                break

    print(alist)


insertionSort([2, 100, 2, 65, 68, 48, 94, 0, 13, 111])
