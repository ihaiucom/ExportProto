/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
    //====================
    // 消息处理器列表
    //--------------------
    export class ProtoHandlerList
    {
        list: ProtoHandler[] = [];
		
		// 0 moduleName
		// 1 moduleHandlerClassName

		static account = new accountHandler();
		static GameData = new GameDataHandler();
		static CinemaBuild = new CinemaBuildHandler();
		static test = new testHandler();
		static item = new itemHandler();
		static city = new cityHandler();
		static movie = new movieHandler();
		static Actor = new ActorHandler();
		static story = new storyHandler();


        // 初始化
        install()
        {
            this.initList();
        }


        // 初始化列表
        private initList()
        {
		
            this.list.push(this.account);
            this.list.push(this.GameData);
            this.list.push(this.CinemaBuild);
            this.list.push(this.test);
            this.list.push(this.item);
            this.list.push(this.city);
            this.list.push(this.movie);
            this.list.push(this.Actor);
            this.list.push(this.story);

        }


    }
}