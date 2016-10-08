# LUISApp
Chat Bot Sample

●動かすために必要な設定
１．ASP.NETアプリを公開するためのAzure App Serviceを用意 
　※インターネット公開されればどんなWebサーバでもOK
　※Azureサブスクリプションがあれば、Visual Studioで自動作成できる
２．LUISでApplicationを作成。IDとKeyを取得する。
　※Azureサブスクリプションが必要。AzureポータルからLUISサービスを使えるようにする。
３．Microsoft Bot FrameworkのサイトでMy Botを作成。AppIDとPasswordを取得する。 
　※Skypeとの連携は勝手にやってくれる
４．GitHubから落としたアプリに次の設定をする
　①Web.configにMy BotのAppIDとPasswordを設定
　②HelpBot.csにLUISのIDとKeyを設定
５．Skypeの連絡先に作ったBotをAdd。Microsoft Bot FrameworkのMy Botのサイトで作ったBotをAddするためのリンクがでてくる。
