/////////////////////////////////////
// ihaiu.ExportProto生成
// http://blog.ihaiu.com
/////////////////////////////////////

namespace Games
{
	/**
	 * 
	 */
	export class accountSender extends ProtoSender
	{
	
		moduleName: string = ProtoModuleMames.account;

		
		/**
		 * 
		 * @param account  
		 */
		auth(account: string)
		{
			let req = new Proto.API.account.authRequest();
			req.account = account;
			this.send(req);
		}
		
		/**
		 * 
		 * @param account  
		 * @param token  
		 */
		login(account: string, token: string)
		{
			let req = new Proto.API.account.loginRequest();
			req.account = account;
			req.token = token;
			this.send(req);
		}
		
		/**
		 * 
		 */
		refreshToken()
		{
			let req = new Proto.API.account.refreshTokenRequest();
			this.send(req);
		}


	}
}