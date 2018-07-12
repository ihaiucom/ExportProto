/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 *  模块
	 */
	export class testSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.test;

		
		/**
		 * 添加道具
		 * @param itemId  道具id
		 * @param amount  道具数量
		 */
		AddItem(itemId: int, amount: int)
		{
			let req = new Proto.API.test.AddItemRequest();
			req.itemId = itemId;
			req.amount = amount;
			this.send(req);
		}
		
		/**
		 * 增加粉丝(公司升级)
		 * @param amount  粉丝数量
		 */
		AddFans(amount: int)
		{
			let req = new Proto.API.test.AddFansRequest();
			req.amount = amount;
			this.send(req);
		}
		
		/**
		 * 
		 * @param uuid  电影id
		 */
		DeleteMovie(uuid: string)
		{
			let req = new Proto.API.test.DeleteMovieRequest();
			req.uuid = uuid;
			this.send(req);
		}


	}
}