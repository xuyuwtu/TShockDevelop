namespace Plugin.Namespace

open System
open Terraria
open TerrariaApi.Server

[<ApiVersion(2, 1)>]
 type Plugin.ClassName = 
    inherit TerrariaPlugin
    new (game) = { inherit TerrariaPlugin(game) }
    override _.Name = "Plugin.Namespace"
    override _.Author = base.Author
    override _.Description = base.Description
    override _.Version = new Version(1, 0)
        
    override _.Initialize() = ()

    override _.Dispose(disposing) = 
        if disposing then ()
        ()
            
