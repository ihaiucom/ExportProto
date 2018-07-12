/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 * 
	 */
	export class storySender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.story;

		
		/**
		 * 搜罗剧本
		 */
		findStory()
		{
			let req = new Proto.API.story.findStoryRequest();
			this.send(req);
		}
		
		/**
		 * 清除搜罗时间
		 */
		cleanFindStory()
		{
			let req = new Proto.API.story.cleanFindStoryRequest();
			this.send(req);
		}
		
		/**
		 * 领取剧本组奖励
		 * @param storySuitId  剧本组ID
		 */
		getReward(storySuitId: int)
		{
			let req = new Proto.API.story.getRewardRequest();
			req.storySuitId = storySuitId;
			this.send(req);
		}


	}
}