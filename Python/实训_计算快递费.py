def sum_fee(weight,initial,extra):
    if 0 < weight < 1:
        weight = 1
    if weight == 0.0:
        fee = 0
    else:
        fee = initial+(weight-1)*extra
    print("运费是%.2f元！" % fee)
    print()


while True:
    area, weight = map(
        float, input(
            "1区[1],2区[2],3区[3],4区[4],同城[5]\n请输入目的区域代码和寄件重量(用空格隔开)："
        ).split())

    if area == 0.0 and weight == -1.0:  # 停止
        break

    if area not in [1.0, 2.0, 3.0, 4.0, 5.0] or weight < 0:  # 无效性判断
        print("请输入正确的地区代码和重量！")
        print()
        continue

    # 不同区域选择不同计费方案
    if area == 1.0:                    # 1区
        initial = 12
        extra = 4
        sum_fee(weight, initial, extra)
    elif area == 2.0:                  # 2区
        initial = 15
        extra = 5
        sum_fee(weight, initial, extra)
    elif area == 3.0:                  # 3区
        initial = 15
        extra = 6.5
        sum_fee(weight, initial, extra)
    elif area == 4.0:                  # 4区
        initial = 15
        extra = 10
        sum_fee(weight, initial, extra)
    elif area == 5.0:                  # 同城
        initial = 12
        exrtra = 3
        sum_fee(weight, initial, extra)
