/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
    //====================
    // 消息发送器列表
    //--------------------
    export class ProtoSenderList
    {
        list: ProtoSender[] = [];
		
		// 0 moduleName
		// 1 moduleSenderClassName

		static account = new accountSender();
		static GameData = new GameDataSender();
		static CinemaBuild = new CinemaBuildSender();
		static test = new testSender();
		static item = new itemSender();
		static city = new citySender();
		static movie = new movieSender();
		static Actor = new ActorSender();
		static story = new storySender();


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