﻿// 值类型和引用类型的区别

// 二者在内存上存储的地方不一样
// 在传递值类型和传递引用类型的时候，传递方式不一样
// 值类型成为值传递，引用类型成为引用传递

// 常见值类型
// int、double、bool、char、decimal、struct、enum
// 常见引用类型
// string、自定义类、数组

// 值类型 的值是存储在内存的 栈 当中
// 引用类型 的值是存储在内存的 堆 中

string s1 = "aa";
string s2 = "aa";
// 二者在内存堆中是同一块地址，同一内存空间，
// 但s1,s2在栈上从两个地方指向堆的同一地址（“aa”所在处）