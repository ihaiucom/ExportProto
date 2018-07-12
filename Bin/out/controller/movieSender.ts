/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 * 
	 */
	export class movieSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.movie;

		
		/**
		 * 拍摄电影
		 * @param uuid  唯一编号
		 */
		MakeFilm(uuid: string)
		{
			let req = new Proto.API.movie.MakeFilmRequest();
			req.uuid = uuid;
			this.send(req);
		}
		
		/**
		 * 设置电影名字
		 * @param uuid  电影唯一编号
		 * @param index  选择的电影下标, 从0开始
		 * @param name  名字
		 */
		SetMovieName(uuid: string, index: int, name: string)
		{
			let req = new Proto.API.movie.SetMovieNameRequest();
			req.uuid = uuid;
			req.index = index;
			req.name = name;
			this.send(req);
		}
		
		/**
		 * 设置艺人
		 * @param uuid  电影唯一编号
		 * @param index  选择的电影下标, 从0开始
		 * @param actorId  艺人id
		 */
		SetActor(uuid: string, index: int, actorId: int)
		{
			let req = new Proto.API.movie.SetActorRequest();
			req.uuid = uuid;
			req.index = index;
			req.actorId = actorId;
			this.send(req);
		}
		
		/**
		 * 确认艺人选择
		 * @param uuid  电影唯一编号
		 */
		ConfirmSetActor(uuid: string)
		{
			let req = new Proto.API.movie.ConfirmSetActorRequest();
			req.uuid = uuid;
			this.send(req);
		}
		
		/**
		 * 选择剧本类型
		 * @param uuid  电影唯一编号
		 * @param type  电影类型
		 */
		ChoseType(uuid: string, type: EMovieType)
		{
			let req = new Proto.API.movie.ChoseTypeRequest();
			req.uuid = uuid;
			req.type = type;
			this.send(req);
		}
		
		/**
		 * 接受媒体访问
		 * @param uuid  电影唯一编号
		 * @param mediaId  媒体id
		 */
		AcceptMediaVisit(uuid: string, mediaId: int)
		{
			let req = new Proto.API.movie.AcceptMediaVisitRequest();
			req.uuid = uuid;
			req.mediaId = mediaId;
			this.send(req);
		}
		
		/**
		 * 电影发布
		 * @param uuid  电影唯一编号
		 * @param theaterId  院线id
		 */
		PublishMovie(uuid: string, theaterId: int)
		{
			let req = new Proto.API.movie.PublishMovieRequest();
			req.uuid = uuid;
			req.theaterId = theaterId;
			this.send(req);
		}
		
		/**
		 * 上映结束
		 * @param uuid  电影唯一编号
		 */
		BattleOver(uuid: string)
		{
			let req = new Proto.API.movie.BattleOverRequest();
			req.uuid = uuid;
			this.send(req);
		}
		
		/**
		 * 推广电影
		 * @param uuid  电影唯一编号
		 */
		SpreadMovie(uuid: string)
		{
			let req = new Proto.API.movie.SpreadMovieRequest();
			req.uuid = uuid;
			this.send(req);
		}
		
		/**
		 * 领取收益
		 * @param uuid  电影唯一编号
		 */
		GetRewardMovie(uuid: string)
		{
			let req = new Proto.API.movie.GetRewardMovieRequest();
			req.uuid = uuid;
			this.send(req);
		}
		
		/**
		 * 切换城市
		 * @param uuid  电影唯一编号
		 * @param cityId  城市ID
		 */
		SwitchCity(uuid: string, cityId: int)
		{
			let req = new Proto.API.movie.SwitchCityRequest();
			req.uuid = uuid;
			req.cityId = cityId;
			this.send(req);
		}
		
		/**
		 * 更新电影状态
		 * @param uuid  电影唯一编号
		 * @param state   当前电影状态
		 */
		UpdateMovieState(uuid: string, state: EMovieState)
		{
			let req = new Proto.API.movie.UpdateMovieStateRequest();
			req.uuid = uuid;
			req.state = state;
			this.send(req);
		}


	}
}