// 获取卫星影像数据, B4, B3, B2 是指波段B4 (red), B3 (green), and B2 (blue).
/**
 * 使用“选择”方法选择图像，该方法从图像中选择特定波段。
 * 在这种情况下，选择的波段是B4（红色）、B3（绿色）和B2（蓝色）。
 * 
 */
var img = pie.Image("LC08/01/T1_SR/LC08_119038_20170527").select(["B4", "B3", "B2"]);
print(img); // 输出

// 显示 
Map.centerObject(img, 6);
Map.addLayer(img, { min: 0, max: 3000 });

