/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 *  模块
	 */
	export class CinemaBuildSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.CinemaBuild;

		
		/**
		 * 扩建楼层
		 * @param floor  楼层数
		 */
		ExtendFloor(floor: int)
		{
			let req = new Proto.API.CinemaBuild.ExtendFloorRequest();
			req.floor = floor;
			this.send(req);
		}
		
		/**
		 * 建造房间
		 * @param floor  楼层数
		 * @param roomType  建筑类型
		 */
		BuildRoom(floor: int, roomType: int)
		{
			let req = new Proto.API.CinemaBuild.BuildRoomRequest();
			req.floor = floor;
			req.roomType = roomType;
			this.send(req);
		}
		
		/**
		 * 升级房间
		 * @param roomId  建筑id
		 */
		UpgradeRoom(roomId: int)
		{
			let req = new Proto.API.CinemaBuild.UpgradeRoomRequest();
			req.roomId = roomId;
			this.send(req);
		}


	}
}