SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE GetCoinInfo
AS
BEGIN
	SET NOCOUNT ON;



	DECLARE @curentTime datetime = (select top 1 [TimeStamp] from MarketSummaries order by TimeStamp desc);
	DECLARE @prevTime1 datetime = (select top 1 [TimeStamp] from MarketSummaries order by TimeStamp desc);

	SELECT [Id]
		  ,[MarketName] as CoinId
		  ,[High]
		  ,[Low]
		  ,[Volume]
		  ,[Last]
		  ,[BaseVolume] as PrevBaseVolume
		  ,[TimeStamp]
		  ,[Bid] as LatestBid
		  ,[Ask] as LatestAsk
		  ,[OpenBuyOrders]
		  ,[OpenSellOrders]
		  ,[PrevDay]
		  ,[Created]
		  ,[DisplayMarketName]
	  FROM [dbo].[MarketSummaries]
	  where TimeStamp = @curentTime

END
GO
