﻿using System.Threading.Tasks;

namespace WindowsGSM.GameServer.Action
{
    class Update
    {
        private readonly GameServerTable server;
        public string Error = "";
        public string Notice = "";

        public Update(GameServerTable server)
        {
            this.server = server;
        }

        public async Task<bool> Run()
        {
            bool updated = false;

            switch (server.Game)
            {
                case (GameServer.CSGO.FullName):
                    {
                        GameServer.CSGO gameServer = new GameServer.CSGO(server.ID);
                        updated = await gameServer.Update();
                        Error = gameServer.Error;
                        break;
                    }
                case (GameServer.GMOD.FullName):
                    {
                        GameServer.GMOD gameServer = new GameServer.GMOD(server.ID);
                        updated = await gameServer.Update();
                        Error = gameServer.Error;
                        break;
                    }
                case (GameServer.TF2.FullName):
                    {
                        GameServer.TF2 gameServer = new GameServer.TF2(server.ID);
                        updated = await gameServer.Update();
                        Error = gameServer.Error;
                        break;
                    }
                case (GameServer.MCPE.FullName):
                    {
                        GameServer.MCPE gameServer = new GameServer.MCPE(server.ID);
                        updated = await gameServer.Update();
                        Error = gameServer.Error;
                        break;
                    }
                case (GameServer.RUST.FullName):
                    {
                        GameServer.RUST gameServer = new GameServer.RUST(server.ID);
                        updated = await gameServer.Update();
                        Error = gameServer.Error;
                        break;
                    }
                default: break;
            }

            return updated;
        }
    }
}
