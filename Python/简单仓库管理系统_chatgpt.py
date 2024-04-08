# 定义商品库存类
class ProductInventory:
    def __init__(self, product_name, product_quantity):
        self.product_name = product_name
        self.product_quantity = product_quantity

    # 增加库存
    def increase_quantity(self, quantity):
        self.product_quantity += quantity

    # 减少库存
    def decrease_quantity(self, quantity):
        self.product_quantity -= quantity

    # 查看库存
    def check_quantity(self):
        return self.product_quantity


# 初始化商品库存
apple_inventory = ProductInventory("apple", 10)

# 增加库存
apple_inventory.increase_quantity(5)

# 减少库存
apple_inventory.decrease_quantity(3)

# 查看库存
print(apple_inventory.check_quantity())  # 12
