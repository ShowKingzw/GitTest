# 目标语句 “methinks it is a weasel”


import random


def New():
    checkkey = ""
    # key = "methinks it is a weasel"
    letter = list("abcdefghijklmnopqrstuvwxyz ")
    while len(checkkey) < 23:
        checkkey = checkkey+(random.choice(letter))

    return checkkey


def Compare():

    # global checkkey
    # temp = False
    Key = "methinks it is a weasel"
    for i in New():
        if Key.find(i) == -1:
            temp = False
            break
        else:
            temp = True
    return temp


# Compare()

#temp = bool(New() == "methinks it is a weasel")

# return temp


def main():
    # global temp
    # temp = False
    # while True:
    #     run_ = Compare()
    #     if run_ == True:
    #         break
    # global checkkey
    # print(checkkey)

    while True:
        res=Compare()
        if res == True:
            break
    print("True")


main()

# main()


# key = "methinks it is a weasel"
# checkkey = []
# key = list(key)
# print(len(key))
