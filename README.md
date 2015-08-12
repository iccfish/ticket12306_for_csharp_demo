12306订票客户端 FOR .NET 演示项目
========

本项目是由[木鱼]发起的一个基于 **.NET4.5** 的[12306]订票客户端。项目使用C#语言，使用[FSLib.Network]项目作为网络层访问库，主要用于演示目的。

主要原因是因为很多同学希望能借由12306练手，以此打开通往网络编程的大门……选择12306不是没有原因的，因为其复杂多变，又有错综复杂的逻辑关系，又十分具有现实意义，嗯。
[12306订票助手.NET]的代码由于历史和功能的原因，其体系过于庞大，并不适合（且目前也不能）开放源码。因此重新单独启动这个简单的项目，希望能给予想学习网络编程的同学以帮助。

实现目标
--
本项目仅包含基本的12306功能实现：

* 登录
* 查询
* 提交订单

更详细进阶的功能将会在之后视情况是否加入。

技术概述
--

本项目出于演示&练习目的，所以将会使用较新的平台、工具以及技术。部分情况下可能因为较新所以无法被您手中的平台直接编译或使用。遇到此类情形时，请视需要改写再重新测试。

**当前平台以及各项技能设定如下**

* 开发工具： Visual Studio 2015 RC
* 目标平台： .NET FRAMEWORK 4.5
* 网络访问库： [FSLib.Network]
* 辅助库： [FSLib.Extension]
* JSON解析库： JSON.NET
* 执行模型： 单线程，使用异步完成所有操作
* 解决方案为单项目方案，包含所有逻辑和数据对象以及界面

**你可能需要对以下内容或相关技术较为了解才可以无障碍地继续：**

* HTTP协议相关知识
* C#语言
* .NET中网络相关操作的知识
* HTML/Javascript的阅读分析能力
* 遇到比较诡异的错误时脑洞大开的指数，指数越高对解决问题打破僵局越有利
* Fiddler/Chrome/Firefox等浏览器或开发工具调试的能力

流程规划
--

将会按照以下流程逐步推进。由于我时间不固定，无法给出具体的时间安排，希望不会烂尾……
同时依据实际情况，可能会发生变更。对应的章节完成后，这里将会更新。

* [项目概况](http://blog.fishlee.net/?p=2465)
* [准备篇（基础知识以及工具介绍）](http://blog.fishlee.net/?p=2482)
* [所有流程简介&项目结构整理](http://blog.fishlee.net/?p=2518)
* [界面框架&基础数据初始化](http://blog.fishlee.net/?p=2560)
* [查票并显示余票信息](http://blog.fishlee.net/?p=2574)
* [验证码输入](http://blog.fishlee.net/?p=2741)
* 登录
* 准备提交订单
* 提交订单
* 订单排队

相关链接
--
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
[12306订票助手.NET]: http://www.fishlee.net/soft/12306/