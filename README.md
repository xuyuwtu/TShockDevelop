## 介绍

本仓库提供了[TShock](https://github.com/Pryaxis/TShock/)插件的项目模板和一些代码片段

### 项目模板 
#### 构建
```
git clone https://github.com/xuyuwtu/TShockDevelop.git
dotnet pack TShock.Plugin.ProjectTemplates/
```
也可以去去Actions下载
#### 使用
```
dotnet new install TShock.Plugin.ProjectTemplates.1.0.0.nupkg
```
### 代码片段
- 为VisualStudio写的，自行导入 [跳转](https://learn.microsoft.com/zh-cn/visualstudio/ide/walkthrough-creating-a-code-snippet?view=vs-2022#import-the-code-snippet)
- 提供了常见内容的for循环片段(NPC, Item, Player, Chest, Projectile, Tile)