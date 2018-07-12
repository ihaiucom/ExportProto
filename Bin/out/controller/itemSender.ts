/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 *  模块
	 */
	export class itemSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.item;

		
		/**
		 * 道具出售
		 * @param uuid  道具唯一编号
		 * @param itemId  道具id
		 * @param amount  道具数量
		 */
		SellOut(uuid: string, itemId: int, amount: int)
		{
			let req = new Proto.API.item.SellOutRequest();
			req.uuid = uuid;
			req.itemId = itemId;
			req.amount = amount;
			this.send(req);
		}
		
		/**
		 * 道具合成
		 * @param uuid  道具唯一编号
		 * @param itemId  道具id
		 * @param amount  道具数量
		 */
		Compound(uuid: string, itemId: int, amount: int)
		{
			let req = new Proto.API.item.CompoundRequest();
			req.uuid = uuid;
			req.itemId = itemId;
			req.amount = amount;
			this.send(req);
		}
		
		/**
		 * 道具拆分
		 * @param uuid  道具唯一编号
		 * @param itemId  道具id
		 * @param amount  道具数量
		 */
		Split(uuid: string, itemId: int, amount: int)
		{
			let req = new Proto.API.item.SplitRequest();
			req.uuid = uuid;
			req.itemId = itemId;
			req.amount = amount;
			this.send(req);
		}
		
		/**
		 * 使用道具
		 * @param uuid  道具唯一编号
		 * @param itemId  道具id
		 * @param amount  道具数量
		 */
		Use(uuid: string, itemId: int, amount: int)
		{
			let req = new Proto.API.item.UseRequest();
			req.uuid = uuid;
			req.itemId = itemId;
			req.amount = amount;
			this.send(req);
		}
		
		/**
		 * 合成艺人
		 * @param uuid  道具唯一编号
		 * @param itemId  道具id
		 */
		CompoundActor(uuid: string, itemId: int)
		{
			let req = new Proto.API.item.CompoundActorRequest();
			req.uuid = uuid;
			req.itemId = itemId;
			this.send(req);
		}


	}
}