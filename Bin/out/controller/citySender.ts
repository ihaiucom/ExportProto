/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 * 
	 */
	export class citySender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.city;

		
		/**
		 * 设置宣传大使
		 * @param uuid  道具唯一编号
		 * @param cityId  城市id
		 * @param areaId  区域id
		 * @param actorId  艺人id
		 */
		SetPropagandaActor(uuid: string, cityId: int, areaId: int, actorId: int)
		{
			let req = new Proto.API.city.SetPropagandaActorRequest();
			req.uuid = uuid;
			req.cityId = cityId;
			req.areaId = areaId;
			req.actorId = actorId;
			this.send(req);
		}
		
		/**
		 * 宣传
		 * @param uuid  道具唯一编号
		 * @param cityId  城市id
		 * @param areaId  区域id
		 */
		Propaganda(uuid: string, cityId: int, areaId: int)
		{
			let req = new Proto.API.city.PropagandaRequest();
			req.uuid = uuid;
			req.cityId = cityId;
			req.areaId = areaId;
			this.send(req);
		}
		
		/**
		 * 路演
		 * @param uuid  道具唯一编号
		 * @param cityId  城市id
		 * @param areaId  区域id
		 */
		Roadshow(uuid: string, cityId: int, areaId: int)
		{
			let req = new Proto.API.city.RoadshowRequest();
			req.uuid = uuid;
			req.cityId = cityId;
			req.areaId = areaId;
			this.send(req);
		}
		
		/**
		 * 设置形象大使
		 * @param uuid  道具唯一编号
		 * @param cityId  城市id
		 * @param psition  位置1,2,3,4....
		 * @param actuuid  艺人唯一ID
		 */
		SetAmbassador(uuid: string, cityId: int, psition: int, actuuid: string)
		{
			let req = new Proto.API.city.SetAmbassadorRequest();
			req.uuid = uuid;
			req.cityId = cityId;
			req.psition = psition;
			req.actuuid = actuuid;
			this.send(req);
		}
		
		/**
		 * 领取收益
		 * @param uuid  唯一编号
		 * @param cityId  城市id
		 */
		GetReward(uuid: string, cityId: int)
		{
			let req = new Proto.API.city.GetRewardRequest();
			req.uuid = uuid;
			req.cityId = cityId;
			this.send(req);
		}
		
		/**
		 * 占领城市
		 * @param uuid  道具唯一编号
		 */
		HoldCity(uuid: string)
		{
			let req = new Proto.API.city.HoldCityRequest();
			req.uuid = uuid;
			this.send(req);
		}


	}
}