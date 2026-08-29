# Changelog

## [0.0.3](https://github.com/WTangent-Org/WTangent.Client/compare/v0.0.2...v0.0.3) (2026-08-29)


### Features

* App 静态属性构造注入（PCL-CE 式）：生成器产 static App + ctor，IEntry 移除 App 成员 ([488d967](https://github.com/WTangent-Org/WTangent.Client/commit/488d967655b8c5dcc0983a69e6e22a7672614fe3))
* 最终特性集 [AgentEntry(id,name,isAsync)]/[EntryStart]/[EntryStop]/[AgentCommand(parent)]/[AgentTool] ([7542278](https://github.com/WTangent-Org/WTangent.Client/commit/7542278775b7347a6ec2d95b96cf1be839723c7b))
* 构造注入 App（无 null!）+ Current 静态桥（PCL-CE 式）；钩子实例方法，纯业务 ([bd07d72](https://github.com/WTangent-Org/WTangent.Client/commit/bd07d7288a734d41913e846d25b94acdf319004f))


### Bug Fixes

* CI 布局——本仓 checkout 进同名子目录复刻本地工作区布局（ProjectReference 的 ../ 不再越出工作区），构建路径加前缀 ([6d5dbae](https://github.com/WTangent-Org/WTangent.Client/commit/6d5dbaeb6bb5505a130eb24cbacf25df0c7542c3))

## [0.0.2](https://github.com/WTangent-Org/WTangent.Client/compare/v0.0.1...v0.0.2) (2026-08-22)


### Features

* client 命令组件（remote/run/web；type=cmd）——从 tui 迁出，组件类型收敛 ui/cmd/tool ([90ed1be](https://github.com/WTangent-Org/WTangent.Client/commit/90ed1be94398b6346cba24d4afb52101a2659a55))
* IEntry 元组命令（父路径挂接）+ 三形态（cmd/sub/tool）+ 类型字段废弃 ([cb2fa9e](https://github.com/WTangent-Org/WTangent.Client/commit/cb2fa9ecc3e5ea2baff4a179e1d3eb29451a75dc))
* IEntry 手写入口（0.0.3）——类型字段废弃，能力由 Entry 声明（Commands/Default/Tools + StartAsync 生命周期） ([0c5dd4e](https://github.com/WTangent-Org/WTangent.Client/commit/0c5dd4ec7fae44245a2b665b825936145de1eb45))
