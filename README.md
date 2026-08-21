# WTangent.Client

`client` 命令组件（type: cmd）：客户端命令域——服务器注册表 / 一次性问答 / 浏览器打开 Web UI。

```bash
wtangent remote add <name> <ip> [port] [加入码]   # 注册服务器
wtangent remote list / remove / user / passwd
wtangent run <prompt> [<remote>]                  # 一次性问答（LLM 由 serve 调用）
wtangent web [<remote>]                           # 浏览器打开目标 serve 的 Web UI
```

- 读写 `%APPDATA%\agent\remotes.json`（优先宿主注入的 `Entry.App.Store`）
- 会话协议（SSE）独立实现，不依赖 tui 组件
