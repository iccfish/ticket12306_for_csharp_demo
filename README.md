12306订票客户端 FOR .NET 演示项目
========

本项目是由[木鱼]发起的一个基于**.NET4.5**的[12306]订票客户端。项目使用C#语言，使用[FSLib.Network]项目作为网络层访问库，主要用于演示目的。

实现目标
==
本项目仅包含基本的12306功能实现：

* 登录
* 查询
* 提交订单

更详细进阶的功能将会在之后视情况是否加入。

技术概述
==

本项目出于演示&amp;联系目的，所以将会使用较新的平台、工具以及技术。部分情况下可能因为较新所以无法被您手中的平台直接编译或使用。遇到此类情形时，请视需要改写再重新测试。

**当前平台以及各项技能设定如下**
* 开发工具： Visual Studio 2015 RC
* 目标平台： .NET FRAMEWORK 4.5
* 网络访问库： [FSLib.Network]
* 辅助库： [FSLib.Extension]
* JSON解析库： JSON.NET
* 执行模型： 单线程，使用异步完成所有操作
* 解决方案为单项目方案，包含所有逻辑和数据对象以及界面

相关链接
-
本项目仅作为演示目的，禁止用于将全部或部分代码用于商业目的。
禁止转载。


* **相关博客： [http://blog.fishlee.net/tag/ticket-12306-demo/](http://blog.fishlee.net/tag/ticket-12306-demo/)**
* **木鱼主页** [http://www.fishlee.net/](http://www.fishlee.net/)
* 腾讯微博 [http://t.qq.com/ccfish](http://t.qq.com/ccfish)
* 新浪微博 [http://weibo.com/imcfish](http://weibo.com/imcfish)
* 项目主页@GitHub [https://github.com/iccfish/ticket12306_for_csharp_demo](https://github.com/iccfish/ticket12306_for_csharp_demo)



[木鱼]: http://www.fishlee.net/
[12306]: https://kyfw.12306.cn/otn/
[FSLib.Network]: http://blog.fishlee.net/2015/01/19/officially_announced_fslib_network_lib/
[FSLib.Extension]: http://blog.fishlee.net/2015/01/15/fslib_extension_lib_officially_announced/