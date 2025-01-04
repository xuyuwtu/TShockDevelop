using Terraria;
using TerrariaApi.Server;

namespace Plugin.Namespace;

[ApiVersion(2, 1)]
public class Plugin.ClassName : TerrariaPlugin
{
    public override string Name => "Plugin.Namespace";
    public override string Author => "Plugin.Author";
    public override string Description => "Plugin.Description";
    public override Version Version => new Version(1, 0);
    public Plugin.ClassName(Main game) : base(game)
    {
    }

    public override void Initialize()
    {
        
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {

        }
    }
}
