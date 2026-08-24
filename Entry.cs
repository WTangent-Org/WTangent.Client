namespace WTangent.Client;

/// <summary>client 组件入口（[AgentEntry] 元数据；命令由生成器收集，生命周期钩子用接口默认实现）。</summary>
[AgentEntry("client", "client 命令", false)]
public sealed partial class Entry : IEntry
{
}
