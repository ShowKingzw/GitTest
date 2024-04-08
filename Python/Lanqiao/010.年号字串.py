'''
小明用字母 A 对应数字 1，B 对应 2，以此类推，用 Z 对应 26。对于 27 以上的数字，小明用两位或更长位的字符串来对应，例如 AA 对应 27，AB 对应 28，AZ 对应 52，LQ 对应 329。

请问 2019 对应的字符串是什么？
'''
n = 2019
s = n
mod = 0
mod = n % 26
wei = []
while True:
    s = s // 26
    t = s % 26
    wei.append(t)
    if s <= 26:
        break

abc = ["A", "B", "C", "D", "E", "F", "G", "H", "I",
       "J", "K", "L", "M", "N", "O", "P", "Q", "R",
       "S", "T", "U", "V", "W", "X", "Y", "Z"]
print(abc[wei[-1]-1]+abc[wei[-2]-1]+abc[mod-1])
