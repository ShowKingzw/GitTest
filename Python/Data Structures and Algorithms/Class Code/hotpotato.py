from pythonds.basic.queue import Queue

def hotPotato(namelist,num):
    simqueue = Queue()
    for name in namelist:
        simqueue.enqueue(name)
    while simqueue.size() > 1:
        for i in range(num):
            simqueue.enqueue(simqueue.dequeue())
        simqueue.dequeue()
    return simqueue.dequeue()

print(hotPotato(["Bill","穿山甲","啊哈哈哈，鸡汤来喽","高级双料特工"],6))