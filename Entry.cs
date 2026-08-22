using WTangent.Core;

namespace WTangent.Client;

/// <summary>client 组件入口（[AgentEntry] 元数据 + 生命周期钩子；命令由生成器收集）。</summary>
[AgentEntry("client", "client 命令", false)]
public sealed partial class Entry : IEntry
{
    [EntryStart]
    private void OnStart(Application app) { }

    [EntryStop]
    private void OnStop() { }
}
