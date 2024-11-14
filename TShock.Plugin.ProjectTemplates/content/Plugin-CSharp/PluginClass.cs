using Terraria;
using TerrariaApi.Server;

namespace Plugin.Namespace;

[ApiVersion(2, 1)]
public class Plugin : TerrariaPlugin
{
    public override string Name => "Plugin.Namespace";
    public override string Author => base.Author;
    public override string Description => base.Description;
    public override Version Version => new Version(1, 0);
    public Plugin(Main game) : base(game)
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
