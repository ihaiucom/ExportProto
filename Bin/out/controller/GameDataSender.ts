/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 *  模块
	 */
	export class GameDataSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.GameData;

		
		/**
		 * 请求初始化游戏数据
		 * @param name  公司名字
		 * @param sex  性别
		 */
		InitGameData(name: string, sex: EUserSex)
		{
			let req = new Proto.API.GameData.InitGameDataRequest();
			req.name = name;
			req.sex = sex;
			this.send(req);
		}
		
		/**
		 * 玩家数据初始化提交
		 * @param channel  客户端的渠道代码
		 */
		GetLoginGameData(channel: string)
		{
			let req = new Proto.API.GameData.GetLoginGameDataRequest();
			req.channel = channel;
			this.send(req);
		}
		
		/**
		 * 支付测试接口 刷新钻石
		 */
		RefreshDiamond()
		{
			let req = new Proto.API.GameData.RefreshDiamondRequest();
			this.send(req);
		}
		
		/**
		 * 
		 * @param nameList  需要获取的类型的string描述 DBOType枚举
		 */
		GetInitGameData(nameList: array<string>)
		{
			let req = new Proto.API.GameData.GetInitGameDataRequest();
			req.nameList = nameList;
			this.send(req);
		}
		
		/**
		 * 修改玩家的名字
		 * @param playerName  更改后的名字
		 */
		RenameGameData(playerName: string)
		{
			let req = new Proto.API.GameData.RenameGameDataRequest();
			req.playerName = playerName;
			this.send(req);
		}
		
		/**
		 * 修改玩家的个性签名
		 * @param perSignature  修改玩家的个性签名
		 */
		RePerSignatureGameData(perSignature: string)
		{
			let req = new Proto.API.GameData.RePerSignatureGameDataRequest();
			req.perSignature = perSignature;
			this.send(req);
		}
		
		/**
		 * 修改玩家的头像
		 * @param type  0表示穿戴 1表示购买
		 * @param portraitId  头像ID
		 */
		RePortraitGameData(type: int, portraitId: int)
		{
			let req = new Proto.API.GameData.RePortraitGameDataRequest();
			req.type = type;
			req.portraitId = portraitId;
			this.send(req);
		}
		
		/**
		 * 获取玩家拓展信息
		 */
		GetGameInfoExt()
		{
			let req = new Proto.API.GameData.GetGameInfoExtRequest();
			this.send(req);
		}
		
		/**
		 *  选择初始化艺人
		 * @param index  
		 */
		GetInitActor(index: int)
		{
			let req = new Proto.API.GameData.GetInitActorRequest();
			req.index = index;
			this.send(req);
		}


	}
}