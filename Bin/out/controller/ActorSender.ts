/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 *  艺人
	 */
	export class ActorSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.Actor;

		
		/**
		 * 查探艺人
		 * @param isUseCard  是否使用星探卡，强制查探
		 */
		NoseInfoActor(isUseCard: bool)
		{
			let req = new Proto.API.Actor.NoseInfoActorRequest();
			req.isUseCard = isUseCard;
			this.send(req);
		}
		
		/**
		 * 招募艺人
		 * @param actorId  艺人ID
		 */
		RecruitActor(actorId: int)
		{
			let req = new Proto.API.Actor.RecruitActorRequest();
			req.actorId = actorId;
			this.send(req);
		}
		
		/**
		 * 雪藏艺人
		 * @param actorId  艺人ID
		 * @param isHide  是否雪藏艺人，true雪藏，false取消雪藏
		 */
		HideActor(actorId: int, isHide: bool)
		{
			let req = new Proto.API.Actor.HideActorRequest();
			req.actorId = actorId;
			req.isHide = isHide;
			this.send(req);
		}
		
		/**
		 * 增加艺人槽位
		 */
		AddActorSlot()
		{
			let req = new Proto.API.Actor.AddActorSlotRequest();
			this.send(req);
		}
		
		/**
		 * 艺人升级
		 * @param actorId  艺人ID
		 */
		UpgradeActor(actorId: int)
		{
			let req = new Proto.API.Actor.UpgradeActorRequest();
			req.actorId = actorId;
			this.send(req);
		}
		
		/**
		 * 赠送艺人资产
		 * @param actorId  艺人ID
		 * @param giveType  赠送类型
		 * @param giveLevel  赠送等级
		 * @param giveNum  赠送数量
		 */
		GiveActorAssets(actorId: int, giveType: int, giveLevel: int, giveNum: int)
		{
			let req = new Proto.API.Actor.GiveActorAssetsRequest();
			req.actorId = actorId;
			req.giveType = giveType;
			req.giveLevel = giveLevel;
			req.giveNum = giveNum;
			this.send(req);
		}
		
		/**
		 * 艺人技能升级
		 * @param actorId  艺人ID
		 * @param skillId  技能ID
		 */
		UpgradeActorSkill(actorId: int, skillId: int)
		{
			let req = new Proto.API.Actor.UpgradeActorSkillRequest();
			req.actorId = actorId;
			req.skillId = skillId;
			this.send(req);
		}
		
		/**
		 * 艺人培养
		 * @param actorId  艺人ID
		 * @param trainType  培养类型
		 * @param useDiamond  使用钻石
		 */
		ActorTrain(actorId: int, trainType: int, useDiamond: bool)
		{
			let req = new Proto.API.Actor.ActorTrainRequest();
			req.actorId = actorId;
			req.trainType = trainType;
			req.useDiamond = useDiamond;
			this.send(req);
		}
		
		/**
		 * 艺人改名
		 * @param actorId  艺人ID
		 * @param name  艺人名字
		 */
		ActorChangeName(actorId: int, name: string)
		{
			let req = new Proto.API.Actor.ActorChangeNameRequest();
			req.actorId = actorId;
			req.name = name;
			this.send(req);
		}


	}
}